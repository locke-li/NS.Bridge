
using System.IO;
using System.Text;
using UnityEngine;

namespace NS.Bridge {
    public static class PathSetting {
#if UNITY_EDITOR
        public static string ManifestPrefix = "_";//should match those in graphs
        public static string LuaPathEditor = "SrcLua";
        public static string BuildStagingPath = "Assets/AssetStaging/_build";
        public static string AssetManifestPackedPath => $"{BuildStagingPath}/{AssetManifestFile}.x";
#endif
        public static string LuaPathStaging = "_lua_src";
        public static string LuaPathConf = "lua";

        public const string ConfPathUpdated = "lua/gen/conf/rawdata";
        public const string ConfPath = "conf";
        public const string ConfExt = ".bytes";

        public static string PackExtension = ".x";
        public static string PackedAssetPath => Path.Combine(Application.streamingAssetsPath, "asset");
        public static string AssetManifestPath => Path.Combine(Application.streamingAssetsPath, $"{AssetManifestFile}.x");
        public static string AssetManifestFile => "asset_list";
    }
}