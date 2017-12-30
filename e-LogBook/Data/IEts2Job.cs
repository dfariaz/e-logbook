using System;

namespace e_LogBook.Data
{
  public interface IEts2Job
  {
    int Income { get; }

    DateTime DeadlineTime { get; }

    DateTime RemainingTime { get; }

    string SourceCity { get; }

    string DestinationCity { get; }

    string SourceCompany { get; }

    string DestinationCompany { get; }
  }
}
