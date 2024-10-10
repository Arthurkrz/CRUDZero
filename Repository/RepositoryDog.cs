using System;
using System.Collections.Generic;
using System.Text;
using CRUDZero.Domain.Entities;

namespace CRUDZero.Repository
{
    class RepositoryDog
    {
        /*Essas listas são estáticas. É possível criar um objeto cujo um dos parâmetros é uma lista?*/
        private static List<Dog> dogs = new List<Dog>();
        private static List<Dog> dogsFeira = new List<Dog>();
        public void AddLista(Dog dog)
        {
            dogs.Add(dog);
        }
        public void AddFeira(Dog dog)
        {
            dogsFeira.Add(dog);
        }
        public void Delete(Dog dog)
        {
            
        }
        public void Update(Dog dog)
        {

        }
        public List<Dog> List(Dog dog)
        {

        }
    }
}
