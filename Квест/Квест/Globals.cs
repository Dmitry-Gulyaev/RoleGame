using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квест
{
    public class Globals
    {
        public static int Level=1;
        public static int Heal=5;
        public static int Medic=3; // кол-во аптечек
        public static int Points=0; //баллы
        public static int Money=0;
        public static int Ammo=0; //патроны
        public int[] param;
    
        public void Save()
        {
            param = new int[6];
            for (int i = 0; i < 6; i++)
            {
                //param[i];
            }
        }
        
    }

   
   
    
}
