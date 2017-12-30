namespace e_LogBook.Data
{
  internal class Ets2Vector : IEts2Vector
  {
    public float X { get; }

    public float Y { get; }

    public float Z { get; }

    public Ets2Vector(float x, float y, float z)
    {
      this.X = x;
      this.Y = y;
      this.Z = z;
    }
  }
}
