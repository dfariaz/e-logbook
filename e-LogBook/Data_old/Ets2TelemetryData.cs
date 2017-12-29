// Decompiled with JetBrains decompiler
// Type: VTMLive.Data.Ets2TelemetryData
// Assembly: VTMLive, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 405901AF-83ED-4E80-B7BB-F0DDF2F4489D
// Assembly location: C:\Users\Deivid Farias\AppData\Local\Apps\2.0\M3LJPQZ8.L6C\9AVGE6T1.ZRW\vtml..tion_0000000000000000_0001.0001_e9801713934c92a6\VTMLive.exe

using System;
using System.Text;
using VTMLive.Data.Reader;

namespace VTMLive.Data
{
  internal class Ets2TelemetryData : IEts2TelemetryData
  {
    private Box<Ets2TelemetryStructure> _rawData;

    public void Update(Ets2TelemetryStructure rawData)
    {
      this._rawData = new Box<Ets2TelemetryStructure>(rawData);
    }

    internal static DateTime SecondsToDate(int seconds)
    {
      if (seconds < 0)
        seconds = 0;
      return new DateTime((long) seconds * 10000000L, DateTimeKind.Utc);
    }

    internal static DateTime MinutesToDate(int minutes)
    {
      return Ets2TelemetryData.SecondsToDate(minutes * 60);
    }

    internal static string BytesToString(byte[] bytes)
    {
      if (bytes == null)
        return string.Empty;
      return Encoding.UTF8.GetString(bytes, 0, Array.FindIndex<byte>(bytes, (Predicate<byte>) (b => (int) b == 0)));
    }

    public IEts2Game Game
    {
      get
      {
        return (IEts2Game) new Ets2Game(this._rawData);
      }
    }

    public IEts2Truck Truck
    {
      get
      {
        return (IEts2Truck) new Ets2Truck(this._rawData);
      }
    }

    public IEts2Trailer Trailer
    {
      get
      {
        return (IEts2Trailer) new Ets2Trailer(this._rawData);
      }
    }

    public IEts2Job Job
    {
      get
      {
        return (IEts2Job) new Ets2Job(this._rawData);
      }
    }

    public IEts2Navigation Navigation
    {
      get
      {
        return (IEts2Navigation) new Ets2Navigation(this._rawData);
      }
    }
  }
}
