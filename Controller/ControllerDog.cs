using System;
using System.Collections.Generic;
using System.Text;
using CRUDZero.Domain.Entities;
using CRUDZero.Domain.Enum;
using CRUDZero.Service;

namespace CRUDZero.Controller
{
    internal class ControllerDog
    {
        private ServiceDog _serviceDog;
        /*Tentei iniciar um método fora de uma classe...*/
        public void Cadastro(string nome, int peso, Porte porte, bool srd, bool doente)
        {
            if (nome != null && peso > 0 && porte != Porte.NA)
            {
                /*Eu achava que era um construtor que entrava aqui e não um instanciamento*/
                Dog dog = new Dog()
                {
                    Nome = nome,
                    Peso = peso,
                    Porte = porte,
                    SRD = srd,
                    Doente = doente
                };
                /*Pq não faz o seguinte?
                  private ServiceDog _serviceDog;
                  _serviceDog = new Dog();
                  _serviceDog = dog;
                */
                _serviceDog = new ServiceDog();
                _serviceDog.Add(dog);
            }
        }
    }
}