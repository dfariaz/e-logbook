namespace e_LogBook.Data
{
  internal class Ets2Placement : IEts2Placement
  {
    public float X { get; }

    public float Y { get; }

    public float Z { get; }

    public float Heading { get; }

    public float Pitch { get; }

    public float Roll { get; }

    public Ets2Placement(float x, float y, float z, float heading, float pitch, float roll)
    {
      this.X = x;
      this.Y = y;
      this.Z = z;
      this.Heading = heading;
      this.Pitch = pitch;
      this.Roll = roll;
    }
  }
}
