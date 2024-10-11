using System;
using System.Collections.Generic;
using System.Text;
using CRUDZero.Domain.Entities;

namespace CRUDZero
{
    abstract class BaseRepository
    {
        public abstract void Add();
        public abstract void Delete();
        public abstract void Update();
        public abstract List<Dog> List();
    }
}