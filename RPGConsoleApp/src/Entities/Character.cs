using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGConsoleApp.src.Entities
{
    public abstract class Character
    {
        public string Name;
        public int Level;
        public int HP;
        public int MP;
        public int AttackPoints;
        public int DefensePoints;

        public Character(string Name, int Level, int HP, int MP, int AttackPoints, int DefensePoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HP = HP;
            this.MP = MP;
            this.AttackPoints = AttackPoints;
            this.DefensePoints = DefensePoints;
        }

        public override string ToString()
        {
            return $"Nome: {this.Name}, Nível: {this.Level}, Tipo: {this.GetType().Name}, HP: {this.HP}, MP: {this.MP}";
        }

        public virtual string Attack()
        {
            return this.Name + " atacou com a espada!";
        }
        
    }
}