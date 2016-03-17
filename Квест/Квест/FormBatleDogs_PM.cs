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
    public partial class FormBatleDogs_PM : Form
    {
        public FormBatleDogs_PM()
        {
            InitializeComponent();
            
        }

        private Button[] S = new Button[10];
        public void InitB()
        {
            int Dogs = 3, hit = 0;
            if (Globals.Level == 1 || Globals.Level == 2)
                Dogs = 3;
            if (Globals.Level == 3 || Globals.Level == 4 && Globals.Level == 5)
                Dogs = 1;
            if (Globals.Level > 5)
            {
                Dogs = 0;
            FormVictoryDogs form2 = new FormVictoryDogs();
            this.Hide();
            form2.ShowDialog();
            this.Close();
            }



            Random rand = new Random();
            int Victory = rand.Next(0, Dogs);
            
            for (int i = 0; i < 5; ++i)
            {
                S[i] = new Button();
              //S[i].IsShip = false;
                S[i].Location = new Point(i * 40);
                S[i].Size = new Size(40, 40);
              // S[i].Click += new EventHandler(S[i]_Click);
                this.Controls.Add(S[i]);
            }
        }
        private void FormBatleDogs_PM_Load(object sender, EventArgs e)
        {
            //TextBox[] tb = new TextBox[20];

            //for (int i = 0; i < tb.Length; i++)
            //{
            //    tb[i] = new TextBox();
            //    //бла-бла-бла
            //    Controls.Add(tb[i]);
            //}
        }
    }
}
