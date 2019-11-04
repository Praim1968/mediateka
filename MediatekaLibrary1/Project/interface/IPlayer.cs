using System;
using System.Collections.Generic;
using System.Text;

namespace MediatekaLibrary1
{
 public interface IPlayer//??
    {
        void Play(IElement element);//воспроизывести файл
        void Stop(IElement element);//остоновть файл 
        void Close(IElement element);//закрыть файл
    }
}
