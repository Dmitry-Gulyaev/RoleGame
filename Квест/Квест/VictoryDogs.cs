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
    public partial class FormVictoryDogs : Form
    {
        public FormVictoryDogs()
        {
            InitializeComponent();
            Globals.Ammo -= 1;
            if (id.Monster == 1)
            {
                label1.Text = "Ты победил псевдоплоть!\n-1 патрон\n+ 5 опыта";
                Globals.Points += 5;
                Statistics.KillFlech += 1;
            }

            if (id.Monster == 2)
            {
                label1.Text = "Ты победил кабана !\n-1 патрон\n+5 опыта";
                Globals.Points += 5;
                Statistics.KillBoar += 1;
            }
            if (id.Monster == 3)
            {
                label1.Text = "Ты победил псевдопса !\n-1 патрон\n+10 опыта";
                Globals.Points += 10;
                Statistics.KillDogs += 1;
            }
            if (id.Monster == 4)
            {
                label1.Text = "Ты победил снорка !\n-1 патрон\n+15 опыта";
                Globals.Points += 15;
                Statistics.KillSnork += 1;
            }
            if (id.Monster == 5)
            {
                label1.Text = "Ты победил кровососа !\n-1 патрон\n+20 опыта";
                Globals.Points += 20;
                Statistics.KillLeech += 1;
            }
            if (id.Monster == 6)
            {
                label1.Text = "Ты победил полтергейста !\n-1 патрон\n+25 опыта";
                Globals.Points += 25;
                Statistics.KillPoltergeist += 1;
            }
            if (id.Monster == 7)
            {
                label1.Text = "Ты победил контролера !\n-1 патрон\n+30 опыта";
                Globals.Points += 30;
                Statistics.KillController += 1;
            }
            if (id.Monster == 8)
            {
                label1.Text = "Ты победил бюрера !\n-1 патрон\n+35 опыта";
                Globals.Points += 35;
                Statistics.KillByurer += 1;
            }
            if (id.Monster == 9)
            {
                label1.Text = "Ты победил химеру!\n-1 патрон\n+40 опыта";
                Globals.Points += 40;
                Statistics.KillChimera += 1;
            }
            if (id.Monster == 10)
            {
                label1.Text = "Ты победил псевдогиганта !\n-1 патрон\n+50 опыта";
                Globals.Points += 50;
                Statistics.KillGiant += 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            



            
            FormTravel form2 = new FormTravel();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void FormVictoryDogs_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;

            LabelHeal.Text = Globals.Heal.ToString();
            LabelLevel.Text = Globals.Level.ToString();
            LabelMoney.Text = Globals.Money.ToString();
        }

        private void PDAButton_Click(object sender, EventArgs e)
        {
            PDA form3 = new PDA();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            inventory form2 = new inventory();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Globals s = new Globals();
            s.Save();
            MessageBox.Show("Процесс игры сохранен.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
