using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квест
{
    public class Globals
    {
        public static int Heal=5;
        public static int Level=1;
        public static int Points; //баллы
        public static int Money;
        public static int Ammo; //патроны
        public static int Medic=1;

        public void func()
        {
            if (Points > 100)
            {
                Level += 1;
                Points = 0;
            }
            if (Heal > 100)
            {
                Heal = 100;
            }
        }
    }

   
   
    
}
