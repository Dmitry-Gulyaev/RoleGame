using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            StreamWriter sw = new StreamWriter("Save.txt", false);
            String st;           
            st = Globals.Level.ToString();
            sw.WriteLine(st);
            st = Globals.Heal.ToString();
            sw.WriteLine(st);
            st = Globals.Medic.ToString();
            sw.WriteLine(st);
            st = Globals.Points.ToString();
            sw.WriteLine(st);
            st = Globals.Money.ToString();
            sw.WriteLine(st);
            st = Globals.Ammo.ToString();
            sw.WriteLine(st);
            sw.Close();
        }
        
    }

   
   
    
}
