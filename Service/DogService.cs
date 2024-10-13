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
        public bool Valid(string nome, int peso, Porte porte, Opcao srd, Opcao doente)
        {
            if (String.IsNullOrWhiteSpace(nome) || peso == 0 || porte == Porte.NA)
            {
                return false;
            }
            return true;
        }
        public void Add(string nome, int peso, Porte porte, Opcao srd, Opcao doente)
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
            if (dog.ID == id)
            {
                _dogRepository.Delete(dog, id);
            }
            else
            {
                Console.WriteLine("O ID inserido não corresponde a nenhum animal.");
            }
        }
        public void Update(Dog dog, int id)
        {
            if (dog.ID == id)
            {
                Console.WriteLine("Insira, linha a linha, o nome e peso (somente números) do animal.");
                string nome = Console.ReadLine();
                int peso = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a opção que corresponde ao porte do animal:\n\n1 - P;\n2 - M;\n3 - G;\n4 - GG.");
                if(Enum.TryParse<Porte>(Console.ReadLine(), true, out Porte porte))
                {
                    Console.WriteLine("O animal apresenta uma raça definida? Insira o dígito da opção correta:\n\n1 - Sim;\n2 - Não.");
                    if (Enum.TryParse<Opcao>(Console.ReadLine(), true, out Opcao srd))
                    {
                        Console.WriteLine("O animal está doente? Insira o dígito da opção correta:\n\n1 - Sim;\n2 - Não.");
                        if (Enum.TryParse<Opcao>(Console.ReadLine(), true, out Opcao doente))
                        {
                            _dogRepository.Update(dog, id, nome, peso, porte, srd, doente);
                        }
                        else
                        {
                            Console.WriteLine("Ocorreu um erro.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ocorreu um erro.");
                }
            }
            else
            {
                Console.WriteLine("O ID inserido não corresponde a nenhum animal.");
            }
        }
        public List<Dog> List(Dog dog)
        {
            return _dogRepository.List(dog);
        }
    }
}