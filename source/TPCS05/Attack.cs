using System;

namespace TPCS05
{
    public class Attack
    {
        public string name;
        public int min_damage;
        public int max_damage;
        public int critical_fail_rate;
        public int critical_bonus_rate;
      
        
        public Attack(string _name, int _min_damage, int _max_dammage, int _critical_fail_rate, int _critical_bonus_rate)
        {
           
            name = _name;
            min_damage = _min_damage;
            max_damage = _max_dammage;
            if (_critical_bonus_rate > 100 || _critical_bonus_rate < 0)
            {
                Console.WriteLine("error");
            }
            else { _critical_bonus_rate = critical_bonus_rate; };

            if (_critical_fail_rate > 100 || _critical_fail_rate < 0)
	        {
                Console.WriteLine("error");
	        }
            else { _critical_fail_rate = critical_fail_rate;};

        }

        public int Damage()
        {
            int dammage;
            Random rand = new Random();
            critical_fail_rate = rand.Next(0, 100);
            critical_bonus_rate = rand.Next(0, 100);
            dammage = rand.Next(0,100);

            if ( critical_fail_rate < critical_bonus_rate )
            {
                dammage = min_damage;
            }

            if (critical_bonus_rate > critical_fail_rate)
            {
                dammage += ( dammage * critical_bonus_rate / 100 );
            }

            return dammage;
        }
    }
}