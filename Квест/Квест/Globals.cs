namespace Квест
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

    public class Globals //
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
            //====статистика
            st = Statistics.KillFlech.ToString();
            sw.WriteLine(st);
            st = Statistics.KillBoar .ToString();
            sw.WriteLine(st);
            st = Statistics.KillDogs.ToString();
            sw.WriteLine(st);
            st = Statistics.KillSnork.ToString();
            sw.WriteLine(st);
            st = Statistics.KillLeech.ToString();
            sw.WriteLine(st);
            st = Statistics.KillPoltergeist.ToString();
            sw.WriteLine(st);
            st = Statistics.KillController.ToString();
            sw.WriteLine(st);
            st = Statistics.KillByurer.ToString();
            sw.WriteLine(st);
            st = Statistics.KillChimera.ToString();
            sw.WriteLine(st);
            st = Statistics.KillGiant.ToString();
            sw.WriteLine(st);
            st = Statistics.SecretFarmCatacombs.ToString();
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
            st = sr.ReadLine();
            Statistics.KillFlech = System.Int32.Parse(st);
            st = sr.ReadLine();
            Statistics.KillBoar = System.Int32.Parse(st);
            st = sr.ReadLine();
            Statistics.KillDogs = System.Int32.Parse(st);
            st = sr.ReadLine();
            Statistics.KillSnork = System.Int32.Parse(st);
            st = sr.ReadLine();
            Statistics.KillLeech = System.Int32.Parse(st);
            st = sr.ReadLine();
            Statistics.KillPoltergeist = System.Int32.Parse(st);
            st = sr.ReadLine();
            Statistics.KillController = System.Int32.Parse(st);
            st = sr.ReadLine();
            Statistics.KillByurer = System.Int32.Parse(st);
            st = sr.ReadLine();
            Statistics.KillChimera = System.Int32.Parse(st);
            st = sr.ReadLine();
            Statistics.KillGiant = System.Int32.Parse(st);
            st = sr.ReadLine();
            Statistics.SecretFarmCatacombs = System.Int32.Parse(st);
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
        public static int KillFlech;
        public static int KillBoar;
        public static int KillDogs;
        public static int KillSnork;
        public static int KillLeech;
        public static int KillPoltergeist;
        public static int KillController;
        public static int KillByurer;
        public static int KillChimera;
        public static int KillGiant;
        public static int SecretFarmCatacombs = 0; // переменная отвечающая за найденные секретные катакомбы на ферме
        public static int Step;
        }
    public static class id
    {
        public static int Monster;
        public static int SelGun;
        public static int Click;  //переменная для подсчета количества выстрелов из автоматов
        public static int Seller; // продавцы. 1- Сидорович
        public static int Maps; // ид карт. 1-кордон, 2 -затон, 3-юпитер,4-припять
        public static int Location; // ид локаций. У баз ид=0


    }
    public static class Contr // отвечает за генерацию юнитов, под контролем которых находятся динамические локации.
    {
        public static int Farm; // если 0-пусто, 1- бандиты, 2-сталкеры.
        public static int KPP; // если 1 - то, Абрамов, если 2, то Устименко
        
    }
    public static class IdDialog
    {
        public static string PeopleDialog; // Id человека, с которым ведется диалог
    }

                
    }

