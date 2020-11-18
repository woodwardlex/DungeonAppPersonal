using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Player : Character
    {
        //props
        public Race CharacterRace { get; set; }
        public Weapons WeaponEquipped { get; set; }
        public int Inventory { get; set; }

        //ctors
        public Player(string name, int hitChance, int block, int health, int maxHealth, Race characterRace, Weapons weaponEquipped)//, int inventory)
        {
            MaxHealth = maxHealth;
            Name = name;
            Block = block;
            Health = health;
            CharacterRace = characterRace;
            WeaponEquipped = weaponEquipped;
            HitChance = hitChance;
        }

        //methods
        public override string ToString()
        {
            return string.Format("~~~~ {0} ~~~~\n" +
                "Health: {1} - {2}\n" +
                "Hit Chance: {3}\n" +
                "Block: {4}\n" +
                "Weapon: {5}\n" +
                "Description: {6}\n",
                Name, Health, MaxHealth, CalcHitChance(), Block, WeaponEquipped, CharacterRace);
        }

        public override int CalcDamage()
        {
            Random rand = new Random();

            int damage = rand.Next(WeaponEquipped.MinDamage, WeaponEquipped.MaxDamage + 1);
            return damage;
        }

        //public override int CalcHitChance()
        //{
        //    return base.CalcHitChance() + 
        //}
    }
}
