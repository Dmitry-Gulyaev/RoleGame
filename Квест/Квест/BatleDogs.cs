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
    public partial class FormBatleDogs : Form
    {
        public FormBatleDogs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Dogs, hit=0;
            if (Globals.Level == 1 || Globals.Level == 2);
            Dogs = 3;
            if (Globals.Level == 3 || Globals.Level == 4 && Globals.Level == 5);
            Dogs = 1;
            if (Globals.Level > 5)
                Dogs = 0;


            Random rand = new Random();
            int Victory = rand.Next(0, 3);

            //label1.Text = Victory.ToString();
            
            int a = Convert.ToInt32(textBox1.Text);
            if (a == Victory)
                hit += 1;
            int b = Convert.ToInt32(textBox2.Text);
            if (b == Victory)
                hit += 1; 
            int c = Convert.ToInt32(textBox3.Text);
            if (c == Victory)
                hit += 1;
           // label2.Text = hit.ToString();

           if (hit >= 1)
            {
                FormVictoryDogs form2 = new FormVictoryDogs();
                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
            else
            {
                Globals.Heal -= rand.Next(20, 40);
                FormLossDogs form2 = new FormLossDogs();
                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
        }

        private void FormBatleDogs_Load(object sender, EventArgs e)
        {

        }
    }
}
