// Decompiled with JetBrains decompiler
// Type: VTMLive.Data.Ets2Game
// Assembly: VTMLive, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 405901AF-83ED-4E80-B7BB-F0DDF2F4489D
// Assembly location: C:\Users\Deivid Farias\AppData\Local\Apps\2.0\M3LJPQZ8.L6C\9AVGE6T1.ZRW\vtml..tion_0000000000000000_0001.0001_e9801713934c92a6\VTMLive.exe

using System;
using e_LogBook.Data.Reader;
using e_LogBook.Helpers;

namespace e_LogBook.Data
{
  internal class Ets2Game : IEts2Game
  {
    private readonly Box<Ets2TelemetryStructure> _rawData;

    public Ets2Game(Box<Ets2TelemetryStructure> rawData)
    {
      this._rawData = rawData;
    }

    public bool Connected
    {
      get
      {
        if ((int) this._rawData.Struct.ets2_telemetry_plugin_revision != 0 && Ets2ProcessHelper.IsEts2Running)
          return (uint) this._rawData.Struct.timeAbsolute > 0U;
        return false;
      }
    }

    public string GameName
    {
      get
      {
        return Ets2ProcessHelper.LastRunningGameName;
      }
    }

    public bool Paused
    {
      get
      {
        return this._rawData.Struct.paused > 0U;
      }
    }

    public DateTime Time
    {
      get
      {
        return Ets2TelemetryData.MinutesToDate(this._rawData.Struct.timeAbsolute);
      }
    }

    public float TimeScale
    {
      get
      {
        return this._rawData.Struct.localScale;
      }
    }

    public DateTime NextRestStopTime
    {
      get
      {
        return Ets2TelemetryData.MinutesToDate(this._rawData.Struct.nextRestStop);
      }
    }

    public string Version
    {
      get
      {
        return string.Format("{0}.{1}", (object) this._rawData.Struct.ets2_version_major, (object) this._rawData.Struct.ets2_version_minor);
      }
    }

    public string TelemetryPluginVersion
    {
      get
      {
        return this._rawData.Struct.ets2_telemetry_plugin_revision.ToString();
      }
    }
  }
}
