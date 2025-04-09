using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGConsoleApp.src.Entities
{
    public class Warrior : Character
    {
        public Warrior(string Name, int Level, int HP, int MP, int AttackPoints, int DefensePoints) : base(Name, Level, HP, MP, AttackPoints, DefensePoints)
        {
        }

        public override int BasicAttack(Character defender)
        {
            int damage = Math.Max(0, this.AttackPoints - defender.DefensePoints);
            defender.HP -= damage;
            Console.WriteLine($"{this.Name} atacou com sua espada pesada, causando {damage} de dano!");
            return damage;
        }

        public override int SpecialAttack(Character defender)
        {
            if (this.MP >= 15)
            {
                int damage = Math.Max(0, (this.AttackPoints * 3) - defender.DefensePoints);
                defender.HP -= damage;
                this.MP -= 15; // Consome 15 MP
                Console.WriteLine($"{this.Name} usou 'Golpe Devastador', causando {damage} de dano!");
                return damage;
            }
            Console.WriteLine($"{this.Name} tentou usar 'Golpe Devastador', mas não tinha MP suficiente!");
            return 0;
        }

        public override int CriticalAttack(Character defender)
        {
            Random random = new Random();
            bool isCritical = random.Next(0, 100) < 20; // 20% de chance de crítico
            int damage = Math.Max(0, this.AttackPoints - defender.DefensePoints);
            if (isCritical)
            {
                damage *= 2; // Dano crítico dobra
                Console.WriteLine($"{this.Name} realizou um ataque crítico esmagador, causando {damage} de dano!");
            }
            else
            {
                Console.WriteLine($"{this.Name} atacou com força, causando {damage} de dano.");
            }
            defender.HP -= damage;
            return damage;
        }
    }
}