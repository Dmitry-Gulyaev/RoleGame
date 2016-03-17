using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квест
{
    public static class Globals
    {
        public static int Heal=5;
        public static int Level=1;
        public static int Points; //баллы
        public static int Money;
        public static int Ammo=10; //патроны

        
    }
    class resourse
    {
        public void func()
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
