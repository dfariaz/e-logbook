// Decompiled with JetBrains decompiler
// Type: VTMLive.Data.Ets2Job
// Assembly: VTMLive, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 405901AF-83ED-4E80-B7BB-F0DDF2F4489D
// Assembly location: C:\Users\Deivid Farias\AppData\Local\Apps\2.0\M3LJPQZ8.L6C\9AVGE6T1.ZRW\vtml..tion_0000000000000000_0001.0001_e9801713934c92a6\VTMLive.exe

using System;
using VTMLive.Data.Reader;

namespace VTMLive.Data
{
  internal class Ets2Job : IEts2Job
  {
    private readonly Box<Ets2TelemetryStructure> _rawData;

    public Ets2Job(Box<Ets2TelemetryStructure> rawData)
    {
      this._rawData = rawData;
    }

    public int Income
    {
      get
      {
        return this._rawData.Struct.jobIncome;
      }
    }

    public DateTime DeadlineTime
    {
      get
      {
        return Ets2TelemetryData.MinutesToDate(this._rawData.Struct.jobDeadline);
      }
    }

    public DateTime RemainingTime
    {
      get
      {
        if (this._rawData.Struct.jobDeadline > 0)
          return Ets2TelemetryData.MinutesToDate(this._rawData.Struct.jobDeadline - this._rawData.Struct.timeAbsolute);
        return Ets2TelemetryData.MinutesToDate(0);
      }
    }

    public string SourceCity
    {
      get
      {
        return Ets2TelemetryData.BytesToString(this._rawData.Struct.jobCitySource);
      }
    }

    public string SourceCompany
    {
      get
      {
        return Ets2TelemetryData.BytesToString(this._rawData.Struct.jobCompanySource);
      }
    }

    public string DestinationCity
    {
      get
      {
        return Ets2TelemetryData.BytesToString(this._rawData.Struct.jobCityDestination);
      }
    }

    public string DestinationCompany
    {
      get
      {
        return Ets2TelemetryData.BytesToString(this._rawData.Struct.jobCompanyDestination);
      }
    }
  }
}
