using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {
        //fields
        private int _health;

        //props
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxHealth { get; set; }
        public int Health {
            get { return _health; }
            set
            {
                if (value <= MaxHealth)
                {
                    _health = value;
                }
                else
                {
                    _health = MaxHealth;
                }
            }
        }//end Health

        //methods
        public virtual int CalcBlock()
        {
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;//overridden in Monster and Player
        }//end CalcDamage()
    }
}
