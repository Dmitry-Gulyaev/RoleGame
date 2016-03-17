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
            if (Gun.PM == 1 && Globals.Ammo > 0)
            {
                InitializeComponent();
                Button newbtn = new Button();
                newbtn.Location = new Point(10, 50);
                newbtn.Name = "newbtnPM";
                newbtn.Size = new Size(100, 50);
                newbtn.TabIndex = 3;
                newbtn.Text = "Пистолет Макарова";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnPM_Click);
                Controls.Add(newbtn);
            }
            if (Gun.Beretta == 1 && Globals.Ammo > 0)
            {
                InitializeComponent();
                Button newbtn = new Button();
                newbtn.Location = new Point(120, 50);
                newbtn.Name = "newbtnBeretta";
                newbtn.Size = new Size(100, 50);
                newbtn.TabIndex = 3;
                newbtn.Text = "Beretta";
                newbtn.UseVisualStyleBackColor = true;
               newbtn.Click += new EventHandler(newbtnBeretta_Click);
                Controls.Add(newbtn);
            }
            if (Gun.Desert_Eagle == 1 && Globals.Ammo > 0)
            {
                InitializeComponent();
                Button newbtn = new Button();
                newbtn.Location = new Point(230, 50);
                newbtn.Name = "newbtnDE";
                newbtn.Size = new Size(100, 50);
                newbtn.TabIndex = 3;
                newbtn.Text = "Desert Eagle";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnDE_Click);
                Controls.Add(newbtn);
            }


        }

        private void newbtnPM_Click(object sender, EventArgs e)
        {
            FormBatleDogs_PM form2 = new FormBatleDogs_PM();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }
        private void newbtnBeretta_Click(object sender, EventArgs e)
        {

        }
        private void newbtnDE_Click(object sender, EventArgs e)
        {

        }

        private void FormBatleDogs_Load(object sender, EventArgs e)
        {
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
    }
}
