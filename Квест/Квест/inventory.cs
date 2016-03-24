using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Квест
{
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }

        private void medicine_Click(object sender, EventArgs e)
        {
            label2.Text = MedResource.medicine.ToString();
            if (MedResource.medicine <= 0)
            {
                MessageBox.Show("Нет аптечек!");
            }
            else
            {
                MedResource.medicine -= 1;
                label2.Text = MedResource.medicine.ToString();
                Globals.Heal += 50;
                
                Globals m = new Globals();
                m.control();
                LabelHeal.Text = Globals.Heal.ToString();
                LabelLevel.Text = Globals.Level.ToString();
                LabelMoney.Text = Globals.Money.ToString();

            }
  
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.button1, "Патроны");
            toolTip1.SetToolTip(this.medicine, "Аптечки");
            
            label4.Text = Globals.Ammo.ToString();
            label2.Text = MedResource.medicine.ToString();
            LabelHeal.Text = Globals.Heal.ToString();
            LabelLevel.Text = Globals.Level.ToString();
            LabelMoney.Text = Globals.Money.ToString();


            label5.Text = "Оружие:\n";
            if (Gun.PM == 1)
            {
                label5.Text += "Пистолет Макарова\n";
            }
            if (Gun.Beretta == 1)
            {
                label5.Text += "Beretta\n";
            }
            if (Gun.Desert_Eagle == 1)
            {
                label5.Text += "Desert Eagle\n";
            }
            if (Gun.AKS_74Y == 1)
            {
                label5.Text += "АКС - 74У\n";
            }
            if (Gun.AK_105 == 1)
            {
                label5.Text += "АК - 105\n";
            }
            if (Gun.AH_94 == 1)
            {
                label5.Text += "AH - 94\n";
            }
            if (Gun.TOZ34 == 1)
            {
                label5.Text += "ТОЗ - 34\n";
            }
            if (Gun.ShotGun == 1)
            {
                label5.Text += "Ружье\n";
            }
            if (Gun.Saiga_12 == 1)
            {
                label5.Text += "Cайга - 12\n";
            }
            if (Gun.Dragunov_sniper_rifle == 1)
            {
                label5.Text += "Снайпеская винтовка Драгунова\n";
            }
            if (Gun.Vintorez == 1)
            {
                label5.Text += "Винторез\n";
            }
            if (Gun.Gaus_Gun == 1)
            {
                label5.Text += "Гаус Пушка\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVillage form2 = new FormVillage();
            this.Hide();
            form2.ShowDialog();
            this.Hide();
        }


        private void PDAButton_Click(object sender, EventArgs e)
        {
            PDA form3 = new PDA();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

    }
}
