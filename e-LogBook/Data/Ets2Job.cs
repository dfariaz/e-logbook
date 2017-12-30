using System;
using e_LogBook.Data.Reader;

namespace e_LogBook.Data
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
