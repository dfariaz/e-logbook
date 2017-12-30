using System;
using e_LogBook.Data.Reader;

namespace e_LogBook.Data
{
  internal class Ets2Navigation : IEts2Navigation
  {
    private readonly Box<Ets2TelemetryStructure> _rawData;

    public Ets2Navigation(Box<Ets2TelemetryStructure> rawData)
    {
      this._rawData = rawData;
    }

    public DateTime EstimatedTime
    {
      get
      {
        return Ets2TelemetryData.SecondsToDate((int) this._rawData.Struct.navigationTime);
      }
    }

    public int EstimatedDistance
    {
      get
      {
        return (int) this._rawData.Struct.navigationDistance;
      }
    }

    public int SpeedLimit
    {
      get
      {
        if ((double) this._rawData.Struct.navigationSpeedLimit <= 0.0)
          return 0;
        return (int) Math.Round((double) this._rawData.Struct.navigationSpeedLimit * 3.59999990463257);
      }
    }

        public float DistanceLeft
        {
            get
            {
                return (float) this._rawData.Struct.navigationDistance;
            }
        }
  }
}
