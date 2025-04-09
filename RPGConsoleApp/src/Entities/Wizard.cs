using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGConsoleApp.src.Entities
{
    public class Wizard : Character
    {
        public Wizard(string Name, int Level, int HP, int MP, int AttackPoints, int DefensePoints) : base(Name, Level, HP, MP, AttackPoints, DefensePoints)
        {
        }

        public override string Attack()
        {
            return this.Name + " atacou com a magia!";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return this.Name + " atacou com a magia super efetiva! Bonus de: " + bonus;
            }
            else
            {
                return this.Name + " atacou com a magia! Bonus de: " + bonus;
            }
        }
    }
}