using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MediatekaLibrary1
{
  public  interface IPlayable
    {
        void Play(IPlayer player);//В интерфейсе IPlayer будет обект пользователь который сможет воспроизводть файл 
        //также для Stop || Close
    }
}
