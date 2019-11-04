using System;
using System.Collections.Generic;
using System.Text;

namespace MediatekaLibrary1
{
   public interface IElement
    {
        //Идентификатор файла 
        Guid Id { get;  }//записывается в виде строки из тридцати двух шестнадцатеричных цифр, разбитой на группы дефисами и опционально окружённой фигурными скобками:
        string Name { get; set; }//имя файла 

        //добавить path
     
    }
}
