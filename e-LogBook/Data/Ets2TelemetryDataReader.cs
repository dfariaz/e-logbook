using System;
using e_LogBook.Data.Reader;

namespace e_LogBook.Data
{
  public class Ets2TelemetryDataReader : IDisposable
  {
    private static readonly Lazy<Ets2TelemetryDataReader> instance = new Lazy<Ets2TelemetryDataReader>((Func<Ets2TelemetryDataReader>) (() => new Ets2TelemetryDataReader()));
    private readonly SharedProcessMemory<Ets2TelemetryStructure> _sharedMemory = new SharedProcessMemory<Ets2TelemetryStructure>("Local\\Ets2TelemetryServer");
    private readonly Ets2TelemetryData _data = new Ets2TelemetryData();
    private readonly object _lock = new object();
    private const string Ets2TelemetryMappedFileName = "Local\\Ets2TelemetryServer";

    public static Ets2TelemetryDataReader Instance
    {
      get
      {
        return Ets2TelemetryDataReader.instance.Value;
      }
    }

    public bool IsConnected
    {
      get
      {
        return this._sharedMemory.IsConnected;
      }
    }

    public IEts2TelemetryData Read()
    {
      lock (this._lock)
      {
        this._sharedMemory.Data = new Ets2TelemetryStructure();
        this._sharedMemory.Read();
        this._data.Update(this._sharedMemory.Data);
        return (IEts2TelemetryData) this._data;
      }
    }

    public void Dispose()
    {
      SharedProcessMemory<Ets2TelemetryStructure> sharedMemory = this._sharedMemory;
      if (sharedMemory == null)
        return;
      // ISSUE: explicit non-virtual call
      sharedMemory.Dispose();
    }
  }
}
