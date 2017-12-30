namespace e_LogBook.Data
{
  public interface IEts2TelemetryData
  {
    IEts2Game Game { get; }

    IEts2Truck Truck { get; }

    IEts2Trailer Trailer { get; }

    IEts2Job Job { get; }

    IEts2Navigation Navigation { get; }
  }
}
