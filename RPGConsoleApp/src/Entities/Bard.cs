using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGConsoleApp.src.Entities
{
    public class Bard : Character
    {
        public Bard(string Name, int Level, int HP, int MP, int AttackPoints, int DefensePoints) : base(Name, Level, HP, MP, AttackPoints, DefensePoints)
        {
        }

        public override int BasicAttack(Character defender)
        {
            int damage = Math.Max(0, this.AttackPoints - defender.DefensePoints);
            defender.HP -= damage;
            Console.WriteLine($"{this.Name} lançou um feitiço básico, causando {damage} de dano!");
            return damage;
        }

        public override int SpecialAttack(Character defender)
        {
            if (this.MP >= 20)
            {
                int damage = Math.Max(0, (this.AttackPoints * 4) - defender.DefensePoints);
                defender.HP -= damage;
                this.MP -= 20; // Consome 20 MP
                Console.WriteLine($"{this.Name} usou 'Tempestade Arcana', causando {damage} de dano!");
                return damage;
            }
            Console.WriteLine($"{this.Name} tentou usar 'Tempestade Arcana', mas não tinha MP suficiente!");
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
                Console.WriteLine($"{this.Name} lançou um feitiço crítico devastador, causando {damage} de dano!");
            }
            else
            {
                Console.WriteLine($"{this.Name} lançou um feitiço, causando {damage} de dano.");
            }
            defender.HP -= damage;
            return damage;
        }
    }
}