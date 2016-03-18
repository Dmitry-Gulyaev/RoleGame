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
            if (Globals.Medic < 1)
            //if (MedResource.medicine < 1)
            {
                MessageBox.Show("Нет аптечек!");
            }
            else
            {
                Globals.Heal += 50;
                Globals.Medic--;
                //MedResource.medicine--;
                Globals m = new Globals();
                m.control();
                LabelHeal.Text = Globals.Heal.ToString();
                LabelLevel.Text = Globals.Level.ToString();
                LabelMoney.Text = Globals.Money.ToString();

            }
  
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            LabelHeal.Text = Globals.Heal.ToString();
            LabelLevel.Text = Globals.Level.ToString();
            LabelMoney.Text = Globals.Money.ToString();
            if (Globals.Medic > 0)
                for (int i = 0; i <= Globals.Medic; i++)
                    //Button Med = new Button();
                    ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVillage form2 = new FormVillage();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }


        private void PDAButton_Click(object sender, EventArgs e)
        {
            PDA form3 = new PDA();
            this.Hide();
            form3.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Globals s = new Globals();
            s.Save();
        }

    }
}
