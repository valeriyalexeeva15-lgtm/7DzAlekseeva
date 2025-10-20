using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DzAlekseeva
{
    internal class Character
    {
        public int Health;
        public int Mana;
        public string Name;

        public Character(string name, int health, int mana)
        {
            Name = name;
            Health = health;
            Mana = mana;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name} атакует! Здоровье: {Health}, Мана: {Mana}");
        }
    }
}