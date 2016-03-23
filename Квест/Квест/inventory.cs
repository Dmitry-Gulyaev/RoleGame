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
