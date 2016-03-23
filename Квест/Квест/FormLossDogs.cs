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
    public partial class FormLossDogs : Form
    {
        public FormLossDogs()
        {
            InitializeComponent();
        }

        private void FormLossDogs_Load(object sender, EventArgs e)
        {
            LabelHeal.Text = Globals.Heal.ToString();
            LabelLevel.Text = Globals.Level.ToString();
            LabelMoney.Text = Globals.Money.ToString();


            if (Globals.Heal > 0)
            {
                Globals.Ammo -= 1;
                label1.Text = "Собака вгрызлась Вам в плоть, но \nВам удалось вырваться из ее когтей.\n-1 парон ";
                Button con = new Button();
                con.Location = new Point(200, 200);
                con.Size = new Size(100, 50);
                con.Text = "Попробовать еще раз";
                con.UseVisualStyleBackColor = true;
                con.Click += new EventHandler (con_Click);
                this.Controls.Add(con);

            }

            else
            {
                Globals.Ammo -= 1;

                label1.Text = "Вы тяжело ранены.\n За Ваше лечение у Вас будет взята некоторая сумма денег."; // здесь нужна проверка на нахождение персонажа относительно локации
                
                Random rand = new Random();
                int MinusMoney = rand.Next(100, 300);
                Globals.Money -= MinusMoney;
                
                Button con1 = new Button();
                con1.Location = new Point(200, 200);
                con1.Size = new Size(100, 50);
                con1.Text = "Очнуться на базе";
                con1.UseVisualStyleBackColor = true;
                con1.Click += new EventHandler (con1_Click);
                this.Controls.Add(con1);
                
            }
        }
            private void con_Click(object sender, EventArgs e)
            {
            FormSelectGun form2 = new FormSelectGun();
            this.Hide();
            form2.ShowDialog();
            this.Close();
            }
        private void con1_Click(object sender, EventArgs e)
            {
            Globals.Heal = 100;
            FormVillage form2 = new FormVillage();
            this.Hide();
            form2.ShowDialog();
            this.Close();
            
            }

        }
    }
