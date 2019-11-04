using System;
using System.Collections.Generic;
using System.Text;

namespace MediatekaLibrary1
{
    public class Mediateka
    {
        public ICollection<IElement> Items { get; private set; }//поток файла
        public ICollection<IMediaList> UserLists { get; private set; } //поток подборки 

        public Mediateka(ICollection<IElement> items, ICollection<IMediaList> userLists)
        {
            Items = items;
            UserLists = userLists;
        }
    }
}
