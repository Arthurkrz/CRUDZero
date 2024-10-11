using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CRUDZero.Domain.Entities;

namespace CRUDZero.Repository
{
    class DogRepository
    {
        private static List<Dog> dogs = new List<Dog>();
        private static int id = 0;
        public void Add(Dog dog)
        {
            dog.ID = id++;
            dogs.Add(dog);
        }
        public void Delete(Dog dog, int id)
        {
            dogs.Remove(dogs.FirstOrDefault(x => dog.ID.Equals(id)));
        }
        public void Update(Dog dog)
        {

        }
        public List<Dog> List(Dog dog)
        {
            return dogs;
        }
    }
}