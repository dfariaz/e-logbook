﻿// Decompiled with JetBrains decompiler
// Type: VTMLive.Data.Ets2Placement
// Assembly: VTMLive, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 405901AF-83ED-4E80-B7BB-F0DDF2F4489D
// Assembly location: C:\Users\Deivid Farias\AppData\Local\Apps\2.0\M3LJPQZ8.L6C\9AVGE6T1.ZRW\vtml..tion_0000000000000000_0001.0001_e9801713934c92a6\VTMLive.exe

namespace VTMLive.Data
{
  internal class Ets2Placement : IEts2Placement
  {
    public float X { get; }

    public float Y { get; }

    public float Z { get; }

    public float Heading { get; }

    public float Pitch { get; }

    public float Roll { get; }

    public Ets2Placement(float x, float y, float z, float heading, float pitch, float roll)
    {
      this.X = x;
      this.Y = y;
      this.Z = z;
      this.Heading = heading;
      this.Pitch = pitch;
      this.Roll = roll;
    }
  }
}