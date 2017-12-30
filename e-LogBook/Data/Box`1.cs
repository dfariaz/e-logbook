namespace e_LogBook.Data
{
  internal class Box<T> where T : struct
  {
    public T Struct { get; set; }

    public Box(T @struct)
    {
      this.Struct = @struct;
    }
  }
}
