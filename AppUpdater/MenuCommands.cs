#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using CenturyGame.AppUpdaterLib.Runtime;
using System.IO;

namespace CenturyGame.FrameworkSample.Game.AppUpdater.Editor
{
    public static class MenuCommands 
    {
        [MenuItem("CenturyGame/AppBuilder/Commands/清理SandBox")]
        static void ClearSandbox()
        {
            var sandboxFolder = AssetsFileSystem.PersistentDataPath;

            if (Directory.Exists(sandboxFolder))
            {
                Directory.Delete(sandboxFolder,true);
                Debug.Log("Delete curret project sandbox folder .");

            }
            else
            {
                Debug.Log("No sandbox folder in current project ");
            }

            Debug.Log("Clear sandbox folder completed!");
        }
    }

}

#endif