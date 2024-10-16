﻿using System;
using System.Collections.Generic;
using System.Text;
using CRUDZero.Domain.Enum;

namespace CRUDZero.Domain.Entities
{
    public class Dog
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Peso { get; set; }
        public Porte Porte { get; set; }
        public Opcao SRD { get; set; }
        public Opcao Doente { get; set; }
    }
}