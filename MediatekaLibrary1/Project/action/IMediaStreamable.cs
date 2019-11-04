using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MediatekaLibrary1
{
  public  interface IMediaStreamable
    {
        StreamReader Stream { get; }//будем считывать поток .
    }
}
