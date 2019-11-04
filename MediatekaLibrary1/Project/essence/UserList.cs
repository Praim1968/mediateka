using System;
using System.Collections.Generic;

namespace MediatekaLibrary1
{
    public class UserList : Element
    {
        public ICollection<IElement> Items { get; private set; }
 

        public UserList(Guid id, string name, ICollection<IElement> Items) : base(id, name)
        {
            this.Items = Items;
        }
           
        public void AddElement(IElement element)
        {
            Items.Add(element);
        }

        public void RemoveElement(IElement element)
        {
            Items.Remove(element);
        }

    
        public void Play(IPlayer player)//проходим циклом нашу колекцию
        {
            foreach (var item in Items)
            {
                player.Play(item);
            }
        }



    }
}
