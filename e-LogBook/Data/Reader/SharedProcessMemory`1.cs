// Decompiled with JetBrains decompiler
// Type: VTMLive.Data.Reader.SharedProcessMemory`1
// Assembly: VTMLive, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 405901AF-83ED-4E80-B7BB-F0DDF2F4489D
// Assembly location: C:\Users\Deivid Farias\AppData\Local\Apps\2.0\M3LJPQZ8.L6C\9AVGE6T1.ZRW\vtml..tion_0000000000000000_0001.0001_e9801713934c92a6\VTMLive.exe

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
