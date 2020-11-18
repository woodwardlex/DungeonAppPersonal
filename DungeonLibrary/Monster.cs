﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //fields
        private int _minDamage;

        //props
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value >= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        //ctors
        public Monster() { }
        public Monster(string name, int health, int maxHealth, int hitChance, int block, int minDamage, int maxDamage, string description)
        {
            MaxHealth = maxHealth;
            MaxDamage = maxDamage;
            Name = name;
            Health = health;
            HitChance = HitChance;
            Block = block;
            MinDamage = minDamage;
            Description = description;
        }

        //methods
        public override string ToString()
        {
            return string.Format("-=-= {0} =-=-\n" +
                "Health: {1} - {2}\n" +
                "Damage: {3} - {4}\n" +
                "Block: {5}\n" +
                "Description:\n" +
                "{6}",
                Name, Health, MaxHealth, MinDamage, MaxDamage, Block, Description);
        }//end ToString()

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }//end CalcDamage()
    }
}
