using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGConsoleApp.src.Entities
{
    public class CharacterData
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public CharacterData(string type, string name, int level, int hp, int mp, int attack, int defense)
        {
            Type = type;
            Name = name;
            Level = level;
            HP = hp;
            MP = mp;
            Attack = attack;
            Defense = defense;
        }
    }
}