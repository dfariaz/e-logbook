// Decompiled with JetBrains decompiler
// Type: VTMLive.Data.IEts2Job
// Assembly: VTMLive, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 405901AF-83ED-4E80-B7BB-F0DDF2F4489D
// Assembly location: C:\Users\Deivid Farias\AppData\Local\Apps\2.0\M3LJPQZ8.L6C\9AVGE6T1.ZRW\vtml..tion_0000000000000000_0001.0001_e9801713934c92a6\VTMLive.exe

using System;

namespace VTMLive.Data
{
  public interface IEts2Job
  {
    int Income { get; }

    DateTime DeadlineTime { get; }

    DateTime RemainingTime { get; }

    string SourceCity { get; }

    string DestinationCity { get; }

    string SourceCompany { get; }

    string DestinationCompany { get; }
  }
}
