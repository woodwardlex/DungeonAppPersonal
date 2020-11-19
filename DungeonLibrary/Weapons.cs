using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapons
    {
        //fields
        private int _minDamage;
        private int _minDurability;
        private bool _isEnchanted;
        private int _maxDamage;
        private int _maxDurability;
        private string _name;
        private bool _isTwoHanded;

        //props
        public int MaxDamage {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public int MaxDurability {
            get { return _maxDurability; }
            set { _maxDurability = value; }
        }

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public bool IsTwoHanded {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }


        public int MinDurability {
            get { return _minDurability; }
            set
            {
                _minDurability = 1;
            }
        }

        public int MinDamage {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        public bool IsEnchanted {
            get { return _isEnchanted; }
            set
            {
                //_isEnchanted = value;
                if (value == true)
                {
                    _maxDamage += 5;
                    _maxDurability += 10;
                    _isEnchanted = value;
                }
                else
                {
                    _isEnchanted = value;
                }
            }
        }//end IsEnchanted

        //ctor
        public Weapons(int minDamage, int minDurability, int maxDamage, int maxDurability, string name, bool isEnchanted, bool isTwoHanded)
        {
            MaxDamage = maxDamage;
            MaxDurability = maxDurability;
            MinDamage = minDamage;
            MinDurability = minDurability;
            Name = name;
            IsEnchanted = isEnchanted;
            IsTwoHanded = IsTwoHanded;
        }

        public Weapons() { }

        //methods
        public override string ToString()
        {
            return string.Format("{0}\n" +
                "Damage: {1} to {2}\n" +
                "Durability: {3} to {4}\n" +
                "Enchanted? {5}\n" +
                "Two-Handed? {6}\n",
                Name, MinDamage, MaxDamage, MinDurability, MaxDurability,
                IsEnchanted ? "Yes\n(+5 Damage)\n(+10 Durability)" : "No",
                IsTwoHanded ? "Yes" : "No");
        }//end toString()

        //public override int CalcEnchantBonus()
        //{
        //    int calculatedDurabilityBonus = MaxDurability;
        //    int calculatedDamageBonus = MaxDamage;

        //    if (IsEnchanted)
        //    {
        //        calculatedDurabilityBonus += calculatedDurabilityBonus + 10;
        //        calculatedDamageBonus += calculatedDamageBonus + 5;
        //    }

        //    return calculatedDamageBonus + calculatedDurabilityBonus;// calculatedDamageBonus;
        }//end CalcEnchantBonus()

    }

