using System;
using System.Collections.Generic;
using System.Text;
using CRUDZero.Repository;
using CRUDZero.Domain.Enum;
using CRUDZero.Domain.Entities;

namespace CRUDZero.Service
{
    internal class ServiceDog
    {
        private RepositoryDog _repositoryDog;
        /*Esqueci que o parâmetro pode ser só 'Dog dog', já que como 'dog' tem suas propriedades, fica mais simples*/
        public void Add(Dog dog)
        {
            if (Valid(dog))
            {
                /*Pensei que entrava um construtor aqui...*/
                _repositoryDog = new RepositoryDog();
                _repositoryDog.AddLista(dog);
                if (dog.Doente == false)
                {
                    _repositoryDog.AddFeira(dog);
                }
            }
            else
            {
                Console.WriteLine("Ocorreu um erro.");
            }
        }
        public void Delete(Dog dog)
        {
            if (OpcaoDelete.Sim)
            {

            }
            else
            {

            }
            _repositoryDog = new RepositoryDog();
            _repositoryDog.Delete(dog);
        }
        public void Update(Dog dog)
        {
            _repositoryDog = new RepositoryDog();
            _repositoryDog.Update(dog);
        }
        public List<Dog> List(Dog dog)
        {
            _repositoryDog = new RepositoryDog();
            return _repositoryDog.List(dog);
        }
        public bool Valid(Dog dog)
        {
            if (dog.Nome != null
                && dog.Peso > 0 
                && dog.Peso < 100 
                && dog.Porte != Porte.NA)
            {
                return true;
            }
            return false;
        }
    }
}
