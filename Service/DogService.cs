using System;
using System.Collections.Generic;
using System.Text;
using CRUDZero.Domain.Entities;
using CRUDZero.Domain.Enum;
using CRUDZero.Repository;

namespace CRUDZero.Service
{
    class DogService
    {
        private DogRepository _dogRepository;
        public DogService()
        {
            _dogRepository = new DogRepository();
        }
        public static bool Valid(string nome, int peso, Porte porte, bool srd, bool doente)
        {
            if (String.IsNullOrWhiteSpace(nome) || peso == 0 || porte == Porte.NA)
            {
                return false;
            }
            return true;
        }
        public void Add(string nome, int peso, Porte porte, bool srd, bool doente)
        {
            Dog dog = new Dog()
            {
                Nome = nome,
                Peso = peso,
                Porte = porte,
                SRD = srd,
                Doente = doente
            };
            _dogRepository.Add(dog);
        }
        public void Delete(Dog dog, int id)
        {
            _dogRepository.Delete(dog, id);
        }
        public void Update()
        {

        }
        public List<Dog> List(Dog dog)
        {
            return _dogRepository.List(dog);
        }
    }
}