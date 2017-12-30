using System;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;

namespace e_LogBook.Data.Reader
{
  internal class SharedProcessMemory<T> : IDisposable
  {
    private readonly string _mapName;
    private MemoryMappedFile _memoryMappedFile;
    private MemoryMappedViewAccessor _memoryMappedAccessor;

    public T Data { get; set; }

    public bool IsConnected
    {
      get
      {
        this.InitializeViewAccessor();
        return this._memoryMappedAccessor != null;
      }
    }

    public SharedProcessMemory(string mapName)
    {
      this._mapName = mapName;
      this.Data = default (T);
    }

    private void InitializeViewAccessor()
    {
      if (this._memoryMappedAccessor != null)
        return;
      try
      {
        this._memoryMappedFile = MemoryMappedFile.OpenExisting(this._mapName, MemoryMappedFileRights.ReadWrite);
        this._memoryMappedAccessor = this._memoryMappedFile.CreateViewAccessor(0L, (long) Marshal.SizeOf(typeof (T)), MemoryMappedFileAccess.Read);
      }
      catch
      {
      }
    }

    public void Read()
    {
      this.InitializeViewAccessor();
      if (this._memoryMappedAccessor == null)
        return;
      byte[] numArray = new byte[Marshal.SizeOf(typeof (T))];
      this._memoryMappedAccessor.ReadArray<byte>(0L, numArray, 0, numArray.Length);
      IntPtr num = IntPtr.Zero;
      T structure;
      try
      {
        num = Marshal.AllocHGlobal(numArray.Length);
        Marshal.Copy(numArray, 0, num, numArray.Length);
        structure = (T) Marshal.PtrToStructure(num, typeof (T));
      }
      finally
      {
        if (num != IntPtr.Zero)
          Marshal.FreeHGlobal(num);
      }
      this.Data = structure;
    }

    public void Dispose()
    {
      if (this._memoryMappedAccessor == null)
        return;
      this._memoryMappedAccessor.Dispose();
      this._memoryMappedFile.Dispose();
    }
  }
}
