using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TPCS05
{
    static class Trainning
    {
        public static void Train()
        {
            Pony my_first_poney = new Pony("Jacqueline", 100, 100, 42, Pony.PonyColor.Applejack);
            my_first_poney.Name = "Jacqueline";
            my_first_poney.Pv = 100;
            my_first_poney.Pv_max = 100;
            my_first_poney.Age = 42;
            my_first_poney.Color = Pony.PonyColor.Applejack;
            my_first_poney.Talk();

        }
    }
}