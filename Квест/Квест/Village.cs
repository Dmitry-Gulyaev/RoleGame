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
    public partial class FormVillage : Form
    {
        public FormVillage()
        {           
            InitializeComponent();
            
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
            //this.Show();
        }

        private void LabelHeal_Click(object sender, EventArgs e)
        {
            
        }

        private void FormVillage_Load(object sender, EventArgs e)
        {
            if (Globals.Points > 100)
            {
                Globals.Level += 1;
                Globals.Points = 0;
            }
            LabelHeal.Text = Globals.Heal.ToString();
            LabelLevel.Text = Globals.Level.ToString();
            LabelMoney.Text = Globals.Money.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBatleDogs form2 = new FormBatleDogs();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }
    }
}
