using System;
using System.Collections.Generic;
using System.Text;
using CRUDZero.Domain.Enum;

namespace CRUDZero.Domain.Entities
{
    public class Dog
    {
        /*Adicionei ID, já que tem 2 listas diferentes com seus métodos de adição e delete*/
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Peso { get; set; }
        public Porte Porte { get; set; }
        public bool SRD { get; set; } = false;
        public bool Doente { get; set; } = false;
    }
}