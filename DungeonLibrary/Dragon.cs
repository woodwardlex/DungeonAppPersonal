using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Dragon : Monster
    {
        //props
        public bool IsFire { get; set; }
        public bool IsIce { get; set; }

        //ctor
        public Dragon(string name, int health, int maxHealth, int hitChance, int block, int minDamage, int maxDamage, string description, bool isFire, bool isIce) : base(name, health, maxHealth, hitChance, block, minDamage, maxDamage, description)
        {
            IsFire = isFire;
            IsIce = isIce;
        }

        //default dragon
        public Dragon()
        {
            MaxHealth = 10;
            MaxDamage = 7;
            Name = "Baby Dragon";
            Health = 8;
            HitChance = 25;
            Block = 20;
            MinDamage = 2;
            Description = "Just a normal baby dragon. It's scales are already grown in, but it, still looks ferocious. ";
            IsFire = false;
            IsIce = false;
        }//end default Dragon

        //methods
        public override int CalcDamage()
        {
            int calculatedDamage = MaxDamage;

            if (IsFire)
            {
                calculatedDamage += calculatedDamage / 2;
            }
            else if (IsIce)
            {
                calculatedDamage += calculatedDamage / 4;
            }

            return calculatedDamage;
        }//end CalcDamage()
    }
}
