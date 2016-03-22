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
    public partial class FormBatleMonster : Form
    {
        public FormBatleMonster()
        {
            InitializeComponent();
            
        }

        private Button[] S = new Button[10];
        public void InitB()
        {
        
        }
        private void FormBatleDogs_PM_Load(object sender, EventArgs e)
        {
            LabelHeal.Text = Globals.Heal.ToString();
            LabelLevel.Text = Globals.Level.ToString();
            LabelMoney.Text = Globals.Money.ToString();
            //=============Пистолет Макарова==========
            if (id.SelGun == 1)
            {
                int menace = 3 /*hit = 0*/;
                if (Globals.Level == 1 || Globals.Level == 2)
                    menace = 3;
                if (Globals.Level == 3 || Globals.Level == 4 && Globals.Level == 5)
                    menace = 1;
                if (Globals.Level > 5)
                {
                    menace = 0;
                    FormVictoryDogs form2 = new FormVictoryDogs();
                    this.Hide();
                    form2.ShowDialog();
                    this.Close();
                }

                Random rand = new Random();
                int Victory = rand.Next(0, menace);
                for (int i = 0; i < menace; i++)
                {
                    Button Shot = new Button();
                    Shot.Top = 30;
                    Shot.Left = 10 + 100 * i;
                    Shot.Size = new Size(100, 50);
                    Shot.Text = "+";
                    //med.ForeColor = System.Drawing.Color.Red;
                    Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    this.Controls.Add(Shot);
                    // Shot.Click += Shot_Click;

                    if (i == Victory)
                    {
                        Shot.Name = "VictoryButton";
                        Shot.Click += new EventHandler(VictoryShot_Click);
                    }
                    else
                    {
                        Shot.Name = "NoVictoryButton";
                        Shot.Click += new EventHandler(NoVictoryShot_Click);
                    }
                }
                }
            }
            private void VictoryShot_Click(object sender, EventArgs e)
            {
                FormVictoryDogs form2 = new FormVictoryDogs();
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
            private void NoVictoryShot_Click(object sender, EventArgs e)
            {
                Random rand = new Random();
                int damage = rand.Next(10, 25);
                Globals.Heal -= damage;
                if (Globals.Heal < 0)
                {
                    Globals.Heal = 0;
                }
                FormLossDogs form2 = new FormLossDogs();
                this.Hide();
                form2.ShowDialog();
                this.Close();
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
    }
}
