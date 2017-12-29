// Decompiled with JetBrains decompiler
// Type: VTMLive.Data.Ets2TelemetryDataReader
// Assembly: VTMLive, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 405901AF-83ED-4E80-B7BB-F0DDF2F4489D
// Assembly location: C:\Users\Deivid Farias\AppData\Local\Apps\2.0\M3LJPQZ8.L6C\9AVGE6T1.ZRW\vtml..tion_0000000000000000_0001.0001_e9801713934c92a6\VTMLive.exe

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
