using System;
using System.Collections.Generic;
using System.Text;

namespace MediatekaLibrary1
{
   public  interface IMediaList : IElement, IPlayable
    {
       ICollection<IElement> Items { get; set; }//
       
       

       

    }
    /*
    class T
    {
        public void Foo()
        {
            IMediaList mediaList = null;
            mediaList.RemoveElement();
            mediaList.Items.Remove();
        }
    }
    */
}
