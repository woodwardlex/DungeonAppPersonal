using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Slime : Monster
    {
        //fields - n/a
        //props
        public bool IsFire { get; set; }
        
        //ctors
        public Slime(string name, int health, int maxHealth, int hitChance, int block, int minDamage, int maxDamage, string description, bool isFire) : base(name, health, maxHealth, hitChance, block, minDamage, maxDamage, description)
        {
            IsFire = isFire;
        }

        public Slime()
        {
            Name = "Green Slime";
            Health = 20;
            MaxHealth = 20;
            HitChance = 45;
            Block = 20;
            MinDamage = 1;
            MaxDamage = 7;
            Description = "Just a slime monster. They're usually pretty weak.";
            IsFire = false;
        }

        //methods
        public override int CalcDamage()
        {
            int calculatedDamage = MaxDamage;

            if (IsFire)
            {
                calculatedDamage += calculatedDamage / 2;
            }
            return calculatedDamage;
        }
    }
}
