using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Bat : Monster
    {
        //fields
        //props
        public bool IsSharp { get; set; }
        public bool CanFly { get; set; }

        //ctor
        public Bat(string name, int health, int maxHealth, int hitChance, int block, int minDamage, int maxDamage, string description, bool isSharp, bool canFly) : base(name, health, maxHealth, hitChance, block, minDamage, maxDamage, description)
        {
            IsSharp = isSharp;
            CanFly = canFly;
        }

        public Bat()
        {
            MaxHealth = 15;
            MaxDamage = 5;
            Health = 15;
            HitChance = 50;
            Name = "Bat";
            MinDamage = 1;
            Block = 12;
            Description = "A bat with large wings is hanging from the cave ceiling. Looks like it's sleeping.";
            IsSharp = false;
            CanFly = false;
        }

        //methods
        public override string ToString()
        {
            return string.Format($"{base.ToString()}\n{(CanFly ? "It can fly! Its block has increased." : "It cannot fly.")}\n{(IsSharp ? "It has sharp teeth! It packs a bigger punch!" : "Its dull teeth make it practially harmless.")}");
        }
        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (CanFly)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }

        public override int CalcDamage()
        {
            int calculatedDamage = MaxDamage;

            if (IsSharp)
            {
                calculatedDamage += calculatedDamage + 4;
            }
            return calculatedDamage;
        }
    }
}
