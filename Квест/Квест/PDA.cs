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
    public partial class PDA : Form
    {
        public PDA()
        {
            InitializeComponent();
        }

        private void PDA_Load(object sender, EventArgs e)
        {
            LabelHeal.Text = Globals.Heal.ToString();
            LabelLevel.Text = Globals.Level.ToString();
            LabelMoney.Text = Globals.Money.ToString();
        }

        private void OpenMaps_Click(object sender, EventArgs e)
        {
            FormPdaMaps form2 = new FormPdaMaps();
            this.Hide();
            form2.ShowDialog();
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormVillage form2 = new FormVillage();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Globals s = new Globals();
            s.Save();
        }
    }
}
