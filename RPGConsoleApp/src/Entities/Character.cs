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

        // Ataque básico
        public virtual int BasicAttack(Character defender)
        {
            int damage = Math.Max(0, this.AttackPoints - defender.DefensePoints);
            defender.HP -= damage;
            return damage;
        }

        // Habilidade especial
        public virtual int SpecialAttack(Character defender)
        {
            if (this.MP >= 10)
            {
                int damage = Math.Max(0, (this.AttackPoints * 2) - defender.DefensePoints);
                defender.HP -= damage;
                this.MP -= 10; // Consome 10 MP
                return damage;
            }
            return 0; // Sem MP suficiente
        }

        // Chance de crítico
        public virtual int CriticalAttack(Character defender)
        {
            Random random = new Random();
            bool isCritical = random.Next(0, 100) < 20; // 20% de chance de crítico
            int damage = Math.Max(0, this.AttackPoints - defender.DefensePoints);
            if (isCritical)
            {
                damage *= 2; // Dano crítico dobra
            }
            defender.HP -= damage;
            return damage;
        }

        // Método para resetar os valores
        public void Reset(int HP, int MP, int AttackPoints, int DefensePoints)
        {
            this.HP = HP;
            this.MP = MP;
            this.AttackPoints = AttackPoints;
            this.DefensePoints = DefensePoints;
        }

    }
}