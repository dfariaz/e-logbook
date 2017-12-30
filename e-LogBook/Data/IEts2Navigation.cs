using System;

namespace e_LogBook.Data
{
  public interface IEts2Navigation
  {
    DateTime EstimatedTime { get; }

    int EstimatedDistance { get; }

    int SpeedLimit { get; }
  }
}
