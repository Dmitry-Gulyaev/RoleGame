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
    public partial class FormIntro : Form
    {
        
        public FormIntro()
        {
            InitializeComponent();
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                       
            Globals read = new Globals();
            read.Reader();

            if (Statistics.Step == 0)
            {
                IdDialog.PeopleDialog = "Шрам1";
                FormDialog form2 = new FormDialog();
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                FormVillage form3 = new FormVillage();
                this.Hide();
                form3.ShowDialog();
                this.Close();
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormIntro_Load(object sender, EventArgs e)
        {
         
            Random rand = new Random();
            Contr.Farm = rand.Next(0, 3);
            Random rand1 = new Random();
            Contr.KPP = rand.Next(1, 3);
        
        }
    }
}
