﻿// Decompiled with JetBrains decompiler
// Type: VTMLive.Data.IEts2Navigation
// Assembly: VTMLive, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 405901AF-83ED-4E80-B7BB-F0DDF2F4489D
// Assembly location: C:\Users\Deivid Farias\AppData\Local\Apps\2.0\M3LJPQZ8.L6C\9AVGE6T1.ZRW\vtml..tion_0000000000000000_0001.0001_e9801713934c92a6\VTMLive.exe

using System;

namespace e_LogBook.Data
{
  public interface IEts2Navigation
  {
    DateTime EstimatedTime { get; }

    int EstimatedDistance { get; }

    int SpeedLimit { get; }
  }
}
