using System;

namespace e_LogBook.Data
{
  public interface IEts2Game
  {
    bool Connected { get; }

    string GameName { get; }

    DateTime Time { get; }

    bool Paused { get; }

    string TelemetryPluginVersion { get; }

    string Version { get; }

    DateTime NextRestStopTime { get; }

    float TimeScale { get; }
  }
}
