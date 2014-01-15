using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TPCS05
{
    public class Pony
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int pv;
        public int Pv
        {
            get { return pv; }
            set { pv = value; }
        }

        private int pv_max;
        public int Pv_max
        {
            get { return pv_max; }
            set { pv_max = value; }
        }

        public enum PonyColor { Applejack, Rarity, PinkiePie, Fluttershy, TwilightSparkle, RainBowDash };
        private PonyColor color;
        public PonyColor Color
        {
            get { return color; }
            set{color = value;}
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string Talk()
        {
            return "Wesch";
        }

        public Pony(string _name, int _age, int _pv, int _pv_max, PonyColor _color)
        {
            _name = name;
            _age = age;
            _pv = pv;
            _pv_max = pv_max;
            _color = color;
        }

        private Attack[] attack_tab;
        public void SetAttack(Attack newAttack, int n)
        {
            attack_tab[n] = newAttack;
        }

        public Attack GetAttack(int n)
        {
             return attack_tab[n];
        }

        public bool IsAlive()
        {
            return (pv > 0);
        }

        public void LoosePV(Attack AttackQuiTue)
        {
            pv -= AttackQuiTue.Damage();
        }
    }
}
