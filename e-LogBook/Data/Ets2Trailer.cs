﻿using e_LogBook.Data.Reader;

namespace e_LogBook.Data
{
  internal class Ets2Trailer : IEts2Trailer
  {
    private readonly Box<Ets2TelemetryStructure> _rawData;

    public Ets2Trailer(Box<Ets2TelemetryStructure> rawData)
    {
      this._rawData = rawData;
    }

    public bool Attached
    {
      get
      {
        return (uint) this._rawData.Struct.trailer_attached > 0U;
      }
    }

    public string Id
    {
      get
      {
        return Ets2TelemetryData.BytesToString(this._rawData.Struct.trailerId);
      }
    }

    public string Name
    {
      get
      {
        return Ets2TelemetryData.BytesToString(this._rawData.Struct.trailerName);
      }
    }

    public float Mass
    {
      get
      {
        return this._rawData.Struct.trailerMass;
      }
    }

    public float Wear
    {
      get
      {
        return this._rawData.Struct.wearTrailer;
      }
    }

    public IEts2Placement Placement
    {
      get
      {
        return (IEts2Placement) new Ets2Placement(this._rawData.Struct.trailerCoordinateX, this._rawData.Struct.trailerCoordinateY, this._rawData.Struct.trailerCoordinateZ, this._rawData.Struct.trailerRotationX, this._rawData.Struct.trailerRotationY, this._rawData.Struct.trailerRotationZ);
      }
    }
  }
}
