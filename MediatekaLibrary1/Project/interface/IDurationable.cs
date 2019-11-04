using System;
using System.Collections.Generic;
using System.Text;

namespace MediatekaLibrary1
{
  public  interface IDurationable
    {
        TimeSpan Duration { get; }//Timespan - это класс, который содержит информацию о промежутке времени, он может участвовать в качестве параметра в методе добавления или вычитания времени DateTime.
    }
}
