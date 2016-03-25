using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Квест
{
    public partial class FormShopGun : Form
    {
        public FormShopGun()
        {
            InitializeComponent();
            LabelHeal.Text = Globals.Heal.ToString();
            LabelLevel.Text = Globals.Level.ToString();
            LabelMoney.Text = Globals.Money.ToString();
        }

        private void FormShopGun_Load(object sender, EventArgs e)
        {
            
            if (id.Seller == 1) // Сидорович
            {
                label1.Text = "Ну вот весь мой арсенал. Не густо, да? Ну,как говорится, чем богаты...\nНаведи на изображение, чтобы узнать подробную информацию";  
               
               
                Button newbtn = new Button();
                newbtn.Location = new Point(10, 70);
                newbtn.Name = "newbtnPM";
                newbtn.Size = new Size(100, 50);
                newbtn.BackgroundImage = Image.FromFile("ПМ.jpg", false);
               // newbtn.BackgroundImageLayout = ImageLayout.Stretch;

                newbtn.TabIndex = 3;
                newbtn.Text = " ";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnPM_Click);
                toolTip1.SetToolTip(newbtn, "Пистолет Макарова\nЦена: 700 RUB\n\nИнформация из энциклопедии:\nНе влияет на шанс.");
                Controls.Add(newbtn);

                //=======Беретта=======
                Button newbtnbrt = new Button();
                newbtnbrt.Location = new Point(120, 70);
                newbtnbrt.Name = "newbtnBeretta";
                newbtnbrt.Size = new Size(100, 50);
                newbtnbrt.BackgroundImage = Image.FromFile("Beretta.jpg", false);

                newbtnbrt.TabIndex = 3;
                newbtnbrt.Text = "";
                newbtnbrt.UseVisualStyleBackColor = true;
                newbtnbrt.Click += new EventHandler(newbtnBeretta_Click);
                toolTip1.SetToolTip(newbtnbrt, "Beretta\nЦена: 1000 RUB\n\nИнформация из энциклопедии:\nПовышает шанс на 1");
                Controls.Add(newbtnbrt);


                //=======АКС - 74У=======
                Button aks = new Button();
                aks.Location = new Point(230, 70);
                aks.Name = "aks";
                aks.Size = new Size(100, 50);
                aks.BackgroundImage = Image.FromFile("АКС - 74У.jpg", false);

                aks.TabIndex = 3;
                aks.Text = " ";
                aks.UseVisualStyleBackColor = true;
                aks.Click += new EventHandler(aks_Click);
                toolTip1.SetToolTip(aks, "АКС - 74У\nЦена: 2000 RUB\n\nИнформация из энциклопедии:\nПозволяет выбрать 2 числа");
                Controls.Add(aks);


                //=======ТОЗ -34=======
                Button toz = new Button();
                toz.Location = new Point(10, 120);
                toz.Name = "TOZ";
                toz.Size = new Size(100, 50);
                toz.BackgroundImage = Image.FromFile("ТОЗ - 34.jpg", false);

                toz.TabIndex = 3;
                toz.Text = "";
                toz.UseVisualStyleBackColor = true;
                toz.Click += new EventHandler(toz_Click);
                toolTip1.SetToolTip(toz, "ТОЗ - 34\nЦена: 2300 RUB\n\nИнформация из энциклопедии:\nПозволяет выбрать 2 числа и повышает шанс на 1");
                Controls.Add(toz);


                //=======Патроны=======
                Button ammo = new Button();
                ammo.Location = new Point(10, 170);
                ammo.Name = "TOZ";
                ammo.Size = new Size(100, 50);
                ammo.BackgroundImage = Image.FromFile("Патроны.jpg", false);

                ammo.TabIndex = 3;
                ammo.Text = " ";
                ammo.UseVisualStyleBackColor = true;
                ammo.Click += new EventHandler(ammo_Click);
                toolTip1.SetToolTip(ammo, "Пачка патронов 30 шт\nЦена: 300 RUB\n\nИнформация из энциклопедии:\nВ данной версии игры для всех типов оружия патроны одинаковы");
                Controls.Add(ammo);
            }
        }

        private void newbtnPM_Click(object sender, EventArgs e) // ПМ
        {
            if (Gun.PM == 1)
            {
                MessageBox.Show("Сидорович: - Э, брат. Есть у тебя уже такая игрушка. Зачем еще одна?");
            }
            else
            {
                if (Globals.Money < 700)
                {
                    MessageBox.Show("Сидорович: -Нет у тебя денег столько. Вот как накопишь - приходи. Всегда рад!");
                }
                else
                {
                    Gun.PM =  1;
                    Globals.Money -= 700;
                    LabelMoney.Text = Globals.Money.ToString();
                    MessageBox.Show("Сидорович: - Поздравляю с еще одной пушкой в твоем арсенале! Эх, как от сердца отрываю.\nКуплен предмет: Пистолет Макарова.");
                }
            }
        }
        private void newbtnBeretta_Click(object sender, EventArgs e) // beretta
        {
            if (Gun.Beretta == 1)
            {
                MessageBox.Show("Сидорович: - Э, брат. Есть у тебя уже такая игрушка. Зачем еще одна?");
            }
            else
            {
                if (Globals.Money < 1000)
                {
                    MessageBox.Show("Сидорович: -Нет у тебя денег столько. Вот как накопишь - приходи. Всегда рад!");
                }
                else
                {
                    Gun.Beretta = 1;
                    Globals.Money -= 1000;
                    LabelMoney.Text = Globals.Money.ToString();
                    MessageBox.Show("Сидорович: - Поздравляю с еще одной пушкой в твоем арсенале! Эх, как от сердца отрываю.\nКуплен предмет: Пистолет Beretta.");
                }
            }
        }

        private void aks_Click(object sender, EventArgs e) // АКС - 74У
        {
            if (Gun.AKS_74Y == 1)
            {
                MessageBox.Show("Сидорович: - Э, брат. Есть у тебя уже такая игрушка. Зачем еще одна?");
            }
            else
            {
                if (Globals.Money < 2000)
                {
                    MessageBox.Show("Сидорович: -Нет у тебя денег столько. Вот как накопишь - приходи. Всегда рад!");
                }
                else
                {
                    Gun.AKS_74Y = 1;
                    Globals.Money -= 2000;
                    LabelMoney.Text = Globals.Money.ToString();
                    MessageBox.Show("Сидорович: - Поздравляю с еще одной пушкой в твоем арсенале! Эх, как от сердца отрываю.\nКуплен предмет: Автомат АКС - 74У.");
                }
            }
        }


        private void toz_Click(object sender, EventArgs e) // ТОЗ - 34
        {
            if (Gun.TOZ34 == 1)
            {
                MessageBox.Show("Сидорович: - Э, брат. Есть у тебя уже такая игрушка. Зачем еще одна?");
            }
            else
            {
                if (Globals.Money < 2300)
                {
                    MessageBox.Show("Сидорович: -Нет у тебя денег столько. Вот как накопишь - приходи. Всегда рад!");
                }
                else
                {
                    Gun.TOZ34 = 1;
                    Globals.Money -= 2300;
                    LabelMoney.Text = Globals.Money.ToString();
                    MessageBox.Show("Сидорович: - Поздравляю с еще одной пушкой в твоем арсенале! Эх, как от сердца отрываю.\nКуплен предмет: Двустволка ТОЗ - 34.");
                }
            }
        }

        private void ammo_Click(object sender, EventArgs e)//патроны
        {
            if (Globals.Money < 300)
            {
                MessageBox.Show("Сидорович: -Нет у тебя денег столько. Вот как накопишь - приходи. Всегда рад!");
            }
            else
            {
                Globals.Ammo += 30;
                Globals.Money -= 300;
                LabelMoney.Text = Globals.Money.ToString();
                MessageBox.Show("Сидорович: - Может к патрончикам еще чего присмотришь?\nКуплена пачка патронов (30 шт).");
            }
        }
       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        private void InventoryButton_Click(object sender, EventArgs e)
        {
            inventory form2 = new inventory();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }

        private void PDAButton_Click(object sender, EventArgs e)
        {
            PDA form3 = new PDA();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }
    }
}
