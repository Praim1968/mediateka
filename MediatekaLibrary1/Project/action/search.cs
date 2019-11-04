using System;
using System.Collections.Generic;
using System.Text;


namespace MediatekaLibrary1.Project.action
{
    public abstract class Search<T> : UserList
    {
        public Search(Guid id, string name, ICollection<IElement> Items) : base(id, name, Items)
        {
        }
       
        public T Found(Guid id, string name)
        {

            IEnumerator<T> collect;
            
          Array.FindAll(Items, (Items) =>  Items.Id == idValue);//Найти все элементы, где Id = искомому значению

        }

      
    }
}
