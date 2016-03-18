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
        public static int Ammo=10; //патроны
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

        public void Reader()
        {
            StreamReader sr = new StreamReader("Save.txt");
            String st;
            st = sr.ReadLine();
            Globals.Level = System.Int32.Parse(st);
            st = sr.ReadLine();
            Globals.Heal = System.Int32.Parse(st);
            st = sr.ReadLine();
            Globals.Medic = System.Int32.Parse(st);
            st = sr.ReadLine();
            Globals.Points = System.Int32.Parse(st);
            st = sr.ReadLine();
            Globals.Money = System.Int32.Parse(st);
            st = sr.ReadLine();
            Globals.Ammo = System.Int32.Parse(st);
            sr.Close();
        public void control()
        {
            if (Globals.Points > 100)
            {
                Globals.Level += 1;
                Globals.Points = 0;
            }
            if (Globals.Heal > 100)
            {
                Globals.Heal = 100;
            }
            if (Globals.Heal < 0)
                Globals.Heal = 0;
        }

        
    }
    
    public static class Gun
    {
        public static int PM=1;
        public static int Beretta=1;
        public static int Desert_Eagle = 1;
        public static int AKS_74Y = 0;
        public static int AK_105 = 0;
        public static int AH_94 = 0;
        public static int TOZ34 = 0;
        public static int ShotGun = 0;
        public static int Saiga_12 = 0;
        public static int Dragunov_sniper_rifle = 0;
        public static int Vintorez = 0;
        public static int Gaus_Gun = 0;

    }
    public static class MedResource
    {
        public static int medicine = 3; // аптечка
        public static int bandage = 0; // бинт
        public static int analgesic = 0;//обезболивающее
        public static int antidote = 0;

    }
    
                
    }

