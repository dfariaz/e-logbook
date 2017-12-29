// Decompiled with JetBrains decompiler
// Type: VTMLive.Helpers.Ets2ProcessHelper
// Assembly: VTMLive, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 405901AF-83ED-4E80-B7BB-F0DDF2F4489D
// Assembly location: C:\Users\Deivid Farias\AppData\Local\Apps\2.0\M3LJPQZ8.L6C\9AVGE6T1.ZRW\vtml..tion_0000000000000000_0001.0001_e9801713934c92a6\VTMLive.exe

using System;
using System.Diagnostics;
using System.Threading;

namespace e_LogBook.Helpers
{
  public static class Ets2ProcessHelper
  {
    private static long _lastCheckTime;
    private static bool _cachedRunningFlag;

    public static string LastRunningGameName { get; set; }

    public static bool IsEts2Running
    {
      get
      {
        if (DateTime.Now - new DateTime(Interlocked.Read(ref Ets2ProcessHelper._lastCheckTime)) > TimeSpan.FromSeconds(1.0))
        {
          Interlocked.Exchange(ref Ets2ProcessHelper._lastCheckTime, DateTime.Now.Ticks);
          foreach (Process process in Process.GetProcesses())
          {
            try
            {
              if (process.MainWindowTitle.StartsWith("Euro Truck Simulator 2") && process.ProcessName == "eurotrucks2" || process.MainWindowTitle.StartsWith("American Truck Simulator") && process.ProcessName == "amtrucks")
              {
                Ets2ProcessHelper._cachedRunningFlag = true;
                Ets2ProcessHelper.LastRunningGameName = process.ProcessName == "eurotrucks2" ? "ETS2" : "ATS";
                return Ets2ProcessHelper._cachedRunningFlag;
              }
            }
            catch
            {
            }
          }
          Ets2ProcessHelper._cachedRunningFlag = false;
        }
        return Ets2ProcessHelper._cachedRunningFlag;
      }
    }
  }
}
