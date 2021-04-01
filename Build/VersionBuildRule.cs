#if UNITY_EDITOR
using System.IO;
using System.Text;
using System.Linq;
using CenturyGame.AppUpdaterLib.Runtime;
using Transient;
using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using System.Reflection;
using CenturyGame.AppBuilder.Editor.Builds;
using static NS.Bridge.PathSetting;

namespace NS.Bridge {
    public static class VersionBuildRule {
        [ExtendableTool("Build Version", "Build", priority:500)]
        public static void BuildVersion() {
            var method = Assembly.GetAssembly(typeof(AppBuildConfig))
                .GetType("CenturyGame.AppBuilder.Editor.Commands.AppBuildCommand")
                .GetMethod("MakeBaseVersionResources", BindingFlags.Static | BindingFlags.NonPublic);
            method.Invoke(null, null);
        }


        [MenuItem("DevShortcut/Sync Conf", priority = 1000)]
        [ExtendableTool("Sync Conf", "Build Staging", priority: 1000)]
        public static void SyncConfAll() => SyncConf(lua: true);

        public static void SyncConf(bool data = true, bool source = true, bool lua = false) {
            var confRepoPath = string.Empty;
            foreach(var sub in Directory.EnumerateDirectories("../../")) {
                if (sub.EndsWith("data")) confRepoPath = sub;
            }
            if (string.IsNullOrEmpty(confRepoPath)) {
                Debug.LogError("failed to locate data repo");
                return;
            }
            var list = new List<(string, string, string[], string[])>();
            if (data) list.Add((confRepoPath + "/gen/rawdata/client", Path.Combine(Application.streamingAssetsPath, ConfPath),
                new string[] { "*.bytes" }, null));
            if (source) list.Add((confRepoPath + "/gen/csharp", "Packages/NS.Bridge/Gen",
                new string[] { "*.cs" }, null));
            if (lua) list.Add((confRepoPath + "/gen/lua", $"Assets/{LuaPathEditor}/gen",
                new string[] { "*.lua" }, null));
            foreach (var (src, _, _, _) in list) {
                if (!Directory.Exists(src)) {
                    Debug.LogError($"Config repo path unavailable:{src}");
                    return;
                }
            }
            foreach (var (src, dst, pattern, filter) in list) {
                if (filter != null) FileUtility.DeleteDirectory(dst, filter);
                else if (Directory.Exists(dst)) Directory.Delete(dst, true);
                Debug.Log($"{src} -> {dst}");
                FileUtility.CopyDirectory(src, dst, pattern);
            }
            AssetDatabase.Refresh();
        }

        [MenuItem("DevShortcut/Clear Version Cache", priority = 1001)]
        [ExtendableTool("Clear Version Cache", "Build Staging", priority: 1001)]
        public static void ClearVersionCache() => ClearVersionCache(true);

        public static void ClearVersionCache(bool overwrite) {
            var appInfoFile = Path.Combine(Application.streamingAssetsPath, "app_info.x");
            var resDataFile = Path.Combine(Application.streamingAssetsPath, "res_data.json");
            var resAssetFile = Path.Combine(Application.streamingAssetsPath, "res_android.json");
            var list = new string[] { appInfoFile, resDataFile, resAssetFile };
            if (!overwrite && list.All(f => File.Exists(f))) return;
            var platform = "Android";
            var emptyAppInfo = $"{{\"version\": \"0.0.0\", \"dataResVersion\": \"0\", \"unityDataResVersion\": \"0\", \"TargetPlatform\": \"{platform}\"}}";
            Directory.CreateDirectory(Application.streamingAssetsPath);
            File.WriteAllText(appInfoFile, emptyAppInfo);
            File.WriteAllText(resDataFile, "{}");
            File.WriteAllText(resAssetFile, "{}");
            var sandboxPath = AssetsFileSystem.RootFolder;
            if (Directory.Exists(sandboxPath)) {
                Directory.Delete(sandboxPath, true);
            }
        }

        [MenuItem("DevShortcut/Reset Data Version", priority = 1002)]
        [ExtendableTool("Reset Data Version", "Build Staging", priority: 1002)]
        public static void ResetDataVersion() {
            var builder = new StringBuilder();
            var file = Path.Combine(Application.streamingAssetsPath, "app_info.x");
            var reader = new StreamReader(File.OpenRead(file));
            while (!reader.EndOfStream) {
                var line = reader.ReadLine();
                if (line.Contains("dataResVersion")) builder.AppendLine("    \"dataResVersion\": \"0\",");
                else builder.AppendLine(line);
            }
            reader.Close();
            File.WriteAllText(file, builder.ToString());
            file = Path.Combine(Application.streamingAssetsPath, "res_data.json");
            File.WriteAllText(file, "{}");
            var sandboxPath = AssetsFileSystem.RootFolder;
            if (Directory.Exists(sandboxPath)) {
                Directory.Delete(sandboxPath, true);
            }
        }
    }
}
#endif