using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MediatekaLibrary1
{
   public abstract class Element :IElement, IMediaStreamable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Element(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public FileInfo FileInfo { get; private set; }

        public StreamReader Stream
        {
            get { return new StreamReader(FileInfo.FullName); }
        }
    }
}
