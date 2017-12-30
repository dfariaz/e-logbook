namespace e_LogBook.Data
{
  public interface IEts2Trailer
  {
    string Id { get; }

    string Name { get; }

    bool Attached { get; }

    float Mass { get; }

    IEts2Placement Placement { get; }

    float Wear { get; }
  }
}
