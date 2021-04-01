using UnityEngine;
using CenturyGame.AppUpdaterLib.Runtime.Interfaces;
using SimpleDiskUtils;

public class StorageInfoProvider : IStorageInfoProvider
{
    public int GetAvailableDiskSpace()
    {
        return DiskUtils.CheckAvailableSpace();
    }

    public int GetTotalDiskSpace()
    {
        return DiskUtils.CheckTotalSpace();
    }

    public int GetBusyDiskSpace()
    {
        return DiskUtils.CheckBusySpace();
    }
}
