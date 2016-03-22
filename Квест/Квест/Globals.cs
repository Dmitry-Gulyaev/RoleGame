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
        //public static int Medic; // кол-во аптечек
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
           // st = Globals.Medic.ToString();
           // sw.WriteLine(st);
            st = Globals.Points.ToString();
            sw.WriteLine(st);
            st = Globals.Money.ToString();
            sw.WriteLine(st);
            st = Globals.Ammo.ToString();
            sw.WriteLine(st);
            //======Сохранение данных об оружии======
            st = Gun.PM.ToString();
            sw.WriteLine(st);
            st = Gun.Beretta.ToString();
            sw.WriteLine(st);
            st = Gun.Desert_Eagle.ToString();
            sw.WriteLine(st);
            st = Gun.AKS_74Y.ToString();
            sw.WriteLine(st);
            st = Gun.AK_105.ToString();
            sw.WriteLine(st);
            st = Gun.AH_94.ToString();
            sw.WriteLine(st);
            st = Gun.TOZ34.ToString();
            sw.WriteLine(st);
            st = Gun.ShotGun.ToString();
            sw.WriteLine(st);
            st = Gun.Saiga_12.ToString();
            sw.WriteLine(st);
            st = Gun.Dragunov_sniper_rifle.ToString();
            sw.WriteLine(st);
            st = Gun.Vintorez.ToString();
            sw.WriteLine(st);
            st = Gun.Gaus_Gun.ToString();
            sw.WriteLine(st);
            //======= Мед ресурсы
            st = MedResource.medicine.ToString();
            sw.WriteLine(st);
            st = MedResource.bandage.ToString();
            sw.WriteLine(st);
            st = MedResource.analgesic.ToString();
            sw.WriteLine(st);
            st = MedResource.antidote.ToString();
            sw.WriteLine(st);
            //====статисика
            st = Statistics.KillDogs.ToString();
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
            //st = sr.ReadLine();
           // Globals.Medic = System.Int32.Parse(st);
            st = sr.ReadLine();
            Globals.Points = System.Int32.Parse(st);
            st = sr.ReadLine();
            Globals.Money = System.Int32.Parse(st);
            st = sr.ReadLine();
            Globals.Ammo = System.Int32.Parse(st);
            st = sr.ReadLine();
            // =====Загрузка данных об оружии=====
            Gun.PM = System.Int32.Parse(st);
            st = sr.ReadLine();
            Gun.Beretta = System.Int32.Parse(st);
            st = sr.ReadLine();
            Gun.Desert_Eagle = System.Int32.Parse(st);
            st = sr.ReadLine();
            Gun.AKS_74Y = System.Int32.Parse(st);
            st = sr.ReadLine();
            Gun.AK_105 = System.Int32.Parse(st);
            st = sr.ReadLine();
            Gun.AH_94 = System.Int32.Parse(st);
            st = sr.ReadLine();
            Gun.TOZ34 = System.Int32.Parse(st);
            st = sr.ReadLine();
            Gun.ShotGun = System.Int32.Parse(st);
            st = sr.ReadLine();
            Gun.Saiga_12 = System.Int32.Parse(st);
            st = sr.ReadLine();
            Gun.Dragunov_sniper_rifle = System.Int32.Parse(st);
            st = sr.ReadLine();
            Gun.Vintorez = System.Int32.Parse(st);
            st = sr.ReadLine();
            Gun.Gaus_Gun = System.Int32.Parse(st);
            //=======медресурсы
            st = sr.ReadLine();
            MedResource.medicine = System.Int32.Parse(st);
            st = sr.ReadLine();
            MedResource.bandage = System.Int32.Parse(st);
            st = sr.ReadLine();
            MedResource.analgesic = System.Int32.Parse(st);
            st = sr.ReadLine();
            MedResource.antidote = System.Int32.Parse(st);
            st = sr.ReadLine();
            //======cтатистика
            Statistics.KillDogs = System.Int32.Parse(st);
            
            sr.Close();
        }
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
        public static int PM; //id 1
        public static int Beretta; //id 2
        public static int Desert_Eagle; //id 3
        public static int AKS_74Y; //id 4
        public static int AK_105; //id 5
        public static int AH_94;//id 6
        public static int TOZ34; //id 7
        public static int ShotGun;//id 8
        public static int Saiga_12;//id 9
        public static int Dragunov_sniper_rifle;//id 10
        public static int Vintorez;//id 11
        public static int Gaus_Gun;//id 12

    }
    public static class MedResource
    {
        public static int medicine ; // аптечка
        public static int bandage; // бинт
        public static int analgesic;//обезболивающее
        public static int antidote;//антирадиационное средство

    }
    public static class Statistics
    {
        public static int KillDogs;
    }
    public static class id
    {
        public static int Monster;
        public static int SelGun;
    }
                
    }

