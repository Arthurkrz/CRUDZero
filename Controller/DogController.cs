﻿using System;
using System.Collections.Generic;
using System.Text;
using CRUDZero.Domain.Entities;
using CRUDZero.Domain.Enum;
using CRUDZero.Service;

namespace CRUDZero.Controller
{
    class DogController
    {
        DogService _dogService;
        public DogController()
        {
            _dogService = new DogService();
        }
        public void Format(string nome, int peso, Porte porte, bool srd, bool doente)
        {
            if (DogService.Valid(nome, peso, porte, srd, doente))
            {
                Add(nome, peso, porte, srd, doente);
            }
            else
            {
                Console.WriteLine("Um ou mais parâmetros estão inválidos.");
            }
            
        }
        public void Add(string nome, int peso, Porte porte, bool srd, bool doente)
        {
            _dogService.Add(nome, peso, porte, srd, doente);
        }
        public void Delete(Dog dog, int id)
        {
            _dogService.Delete(dog, id);
        }
    }
}