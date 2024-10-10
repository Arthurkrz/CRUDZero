using System;
using System.Collections.Generic;
using System.Text;
using CRUDZero.Repository;
using CRUDZero.Domain.Enum;
using CRUDZero.Domain.Entities;

namespace CRUDZero.Service
{
    class ServiceDog
    {
        private RepositoryDog _repositoryDog;
        public void Add(string nome, int peso, Porte porte, bool srd, bool doente)
        {
            if (Valid(nome, peso, porte))
            {
                _repositoryDog = new RepositoryDog();
                public Dog(string nome, int peso, Porte porte, bool srd, bool doente)
                {
                    Dog.Nome = nome;


                }
            }
        }
        public bool Valid(string nome, int peso, Porte porte)
        {
            if (nome != null 
                && peso > 0 
                && peso < 100 
                && porte != Porte.NA)
            {
                return true;
            }
            return false;
        }
    }
}
