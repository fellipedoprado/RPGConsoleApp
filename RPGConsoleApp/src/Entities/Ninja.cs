using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGConsoleApp.src.Entities
{
    public class Ninja : Character
    {
        public Ninja(string Name, int Level, int HP, int MP, int AttackPoints, int DefensePoints) : base(Name, Level, HP, MP, AttackPoints, DefensePoints)
        {
        }

        public override int BasicAttack(Character defender)
        {
            int damage = Math.Max(0, this.AttackPoints - defender.DefensePoints);
            defender.HP -= damage;
            Console.WriteLine($"{this.Name} lançou uma shuriken, causando {damage} de dano!");
            return damage;
        }

        public override int SpecialAttack(Character defender)
        {
            if (this.MP >= 10)
            {
                int damage = Math.Max(0, (this.AttackPoints * 2) - defender.DefensePoints);
                defender.HP -= damage;
                this.MP -= 10; // Consome 10 MP
                Console.WriteLine($"{this.Name} usou um ataque furtivo: 'Golpe das Sombras', causando {damage} de dano!");
                return damage;
            }
            Console.WriteLine($"{this.Name} tentou usar um ataque furtivo, mas não tinha MP suficiente!");
            return 0;
        }

        public override int CriticalAttack(Character defender)
        {
            Random random = new Random();
            bool isCritical = random.Next(0, 100) < 30; // 30% de chance de crítico
            int damage = Math.Max(0, this.AttackPoints - defender.DefensePoints);
            if (isCritical)
            {
                damage *= 2; // Dano crítico dobra
                Console.WriteLine($"{this.Name} realizou um ataque crítico com precisão ninja, causando {damage} de dano!");
            }
            else
            {
                Console.WriteLine($"{this.Name} atacou rapidamente, causando {damage} de dano.");
            }
            defender.HP -= damage;
            return damage;
        }
    }
}