﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ch11Ex02
{
    internal class AnimalCollection : CollectionBase
    {
        public void Add(Animal newAnimal) =>
            List.Add(newAnimal);

        public void Remove(Animal newAnimal) =>
            List.Remove(newAnimal);

        public Animal this[int animalIndex] 
        {
            get {  return (Animal)List[animalIndex]; }
            set { List[animalIndex] = value; }
        }
    }
}
