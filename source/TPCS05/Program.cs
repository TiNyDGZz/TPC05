using System;
using System.Windows.Forms;

namespace TPCS05
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if PONY 

             Pony Left = new Pony("Star Wars",42,100,100, Pony.PonyColor.Applejack);
             Pony Right = new Pony("Pitbull", 42, 100, 100,Pony.PonyColor.PinkiePie);

             Attack attack_1 = new Attack("Boulouloubi",10,50,10,100);
             Attack attack_2 = new Attack("Bouloulouba",20,60,10,100);

             Arena arena = new Arena(Left,Right);

            Application.Run(new Form1(arena));
#else
            Application.Run(new Form1());
#endif
        }
    }
}