using System;
using System.Text;
using e_LogBook.Data.Reader;

namespace e_LogBook.Data
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
