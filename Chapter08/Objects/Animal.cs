﻿using static System.Console;

namespace Objects
{
    public class Animal : IAnimal
    {
        public Animal()
        {
            Name = default;
            Age = default;
        }
        public Animal(string name, int age)
        {
            Name = name ?? " ";
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public void EatFood()
        {
            WriteLine($"{Name} is eating food");
        }

        public void Breed()
        {
            WriteLine($"{Name} is breeding");
        }

    }
}
