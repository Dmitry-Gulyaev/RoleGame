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
    public partial class FormSellGun : Form
    {
        public FormSellGun()
        {
            InitializeComponent();
        }

        private void FormSellGun_Load(object sender, EventArgs e)
        {
            LabelHeal.Text = Globals.Heal.ToString();
            LabelLevel.Text = Globals.Level.ToString();
            LabelMoney.Text = Globals.Money.ToString();
            int X = 0;
            int Y = 100;
            
            if (id.Seller == 1)
            {
                label1.Text = "Сидорович: - Решил продать ненужный ствол? Ну давай посмотрим что там у тебя.\nНаведи на иконку оружия, чтобы узнать цену и нажми на нее, чтобы продать оружие.";

                if (Gun.PM == 1)
                {
                    Button SellPm = new Button();
                    X = X+10;
                  
                    SellPm.Location = new Point (X,Y);
                    SellPm.Size = new Size(100, 50);
                    SellPm.Click += new EventHandler (SellPm_Click);
                    SellPm.BackgroundImage = Image.FromFile("ПМ.jpg", false);
                    toolTip1.SetToolTip(SellPm, "Пистолет Макарова?Ну куплю я его... Скажем, за 300 RUB");
                    Controls.Add(SellPm); 


                }
                if (Gun.Beretta == 1)
                {
                    Button BerettaSell = new Button();
                    if (X == 0)
                    {
                        X = 10;
                       
                    }
                    
                    {
                        X = X + 110;
                       
                    }
                    BerettaSell.Location = new Point(X, Y);
                    BerettaSell.Size = new Size(100, 50);
                    BerettaSell.Click += new EventHandler(BerettaSell_Click);
                    BerettaSell.BackgroundImage = Image.FromFile("Beretta.jpg", false);
                    toolTip1.SetToolTip(BerettaSell, "Beretta?Ну куплю я его... Скажем, за 800 RUB");
                    Controls.Add(BerettaSell);
                }

                if (Gun.Desert_Eagle == 1)
                {
                    Button DESell = new Button();
                    if (X == 0)
                    {
                        X = 10;
                        
                    }
                    else
                    {
                        X = X + 110;
                        
                    }
                    DESell.Location = new Point(X, Y);
                    DESell.Size = new Size(100, 50);
                    DESell.Click += new EventHandler(DESell_Click);
                    DESell.BackgroundImage = Image.FromFile("Desert Eagle.jpg", false);
                    toolTip1.SetToolTip(DESell, "Desert Eagle??? Вот это вещь! 1300 RUB");
                    Controls.Add(DESell);
                }
                if (Gun.AKS_74Y == 1)
                {
                    Button AKSSell = new Button();
                    if (X == 0)
                    {
                        X = 10;
                        ;
                    }
                    else
                    {
                        X = X + 110;
                        
                    }
                    AKSSell.Location = new Point(X, Y);
                    AKSSell.Size = new Size(100, 50);
                    AKSSell.Click += new EventHandler(AKSSell_Click);
                    AKSSell.BackgroundImage = Image.FromFile("АКС - 74У.jpg", false);
                    toolTip1.SetToolTip(AKSSell, "АКС - 74У?Ну куплю я его... Скажем, за 1100 RUB");
                    Controls.Add(AKSSell);
                }
                if (Gun.AK_105 == 1)
                {
                    Button AKSell = new Button();

                    if (X == 0)
                    {
                        X = 10;
                        
                    }
                    else
                    {
                        X = X + 110;
                        
                    }
                    if (X > 340)
                    {
                        Y += 50;
                        X = 10;
                    }
                    AKSell.Location = new Point(X, Y);
                    AKSell.Size = new Size(100, 50);
                    AKSell.Click += new EventHandler(AKSell_Click);
                    AKSell.BackgroundImage = Image.FromFile("АК - 105.jpg", false);
                    toolTip1.SetToolTip(AKSell, "АКС - 105??? Давай его сюда скорее!3600 RUB");
                    Controls.Add(AKSell);
                }
                if (Gun.AH_94 == 1)
                {
                    Button AHSell = new Button();
                    if (X == 0)
                    {
                        X = 10;
                        
                    }
                    else
                    {
                        X = X + 110;
                       
                    }
                    if (X > 340)
                    {
                        Y += 50;
                        X = 10;
                    }
                    AHSell.Location = new Point(X, Y);
                    
                    AHSell.Size = new Size(100, 50);
                    AHSell.Click += new EventHandler(AHSell_Click);
                    AHSell.BackgroundImage = Image.FromFile("АН - 94.jpg", false);
                    AHSell.BackgroundImageLayout = ImageLayout.Stretch;
                    toolTip1.SetToolTip(AHSell, "АH - 94???Офигеть!!!9000 RUB");
                    Controls.Add(AHSell);
                }
                if (Gun.TOZ34 == 1)
                {
                    Button TOZSell = new Button();
                    if (X == 0)
                    {
                        X = 10;
                        
                    }
                    else
                    {
                        X = X + 110;
                        
                    }
                    if (X > 340)
                    {
                        Y += 50;
                        X = 10;
                    }
                    TOZSell.Location = new Point(X, Y);

                    TOZSell.Size = new Size(100, 50);
                    TOZSell.Click += new EventHandler(TOZSell_Click);
                    TOZSell.BackgroundImage = Image.FromFile("ТОЗ - 34.jpg", false);
                    toolTip1.SetToolTip(TOZSell, "ТОЗ - 34? Ну куплю за 1900 RUB");
                    Controls.Add(TOZSell);
                }
                if (Gun.ShotGun == 1)
                {
                    Button SGSell = new Button();
                    if (X == 0)
                    {
                        X = 10;
                        
                    }
                    else
                    {
                        X = X + 110;
                        
                    }
                    if (X > 340)
                    {
                        Y += 50;
                        X = 10;
                    }
                    SGSell.Location = new Point(X, Y);

                    SGSell.Size = new Size(100, 50);
                    SGSell.Click += new EventHandler(SGSell_Click);
                    SGSell.BackgroundImage = Image.FromFile("Ружье.jpg", false);
                    SGSell.BackgroundImageLayout = ImageLayout.Stretch;
                    toolTip1.SetToolTip(SGSell, "Ружье? Ну куплю за 2700 RUB");
                    Controls.Add(SGSell);
                }
                if (Gun.Saiga_12 == 1)
                {
                    Button SSell = new Button();
                    if (X == 0)
                    {
                        X = 10;
                        
                    }
                    else
                    {
                        X = X + 110;
                        
                    }
                    if (X > 340)
                    {
                        Y += 50;
                        X = 10;
                    }
                    SSell.Location = new Point(X, Y);

                    SSell.Size = new Size(100, 50);
                    SSell.Click += new EventHandler(SSell_Click);
                    SSell.BackgroundImage = Image.FromFile("Сайга.jpg", false);
                    toolTip1.SetToolTip(SSell, "Сайга-12??? С руками и ногами, как говорится. 6700 RUB");
                    Controls.Add(SSell);
                }
                if (Gun.Dragunov_sniper_rifle == 1)
                {
                    Button DSSell = new Button();
                    if (X == 0)
                    {
                        X = 10;
                      
                    }
                    else
                    {
                        X = X + 110;
                        
                    }
                    if (X > 340)
                    {
                        Y += 50;
                        X = 10;
                    }
                    DSSell.Location = new Point(X, Y);
                    DSSell.Size = new Size(100, 50);
                    DSSell.Click += new EventHandler(DSSell_Click);
                    DSSell.BackgroundImage = Image.FromFile("СВД.jpg", false);
                    DSSell.BackgroundImageLayout = ImageLayout.Stretch;
                    toolTip1.SetToolTip(DSSell, "Снайперская Винтовка Драгунова??? Думал, не водятся в Зоне такие. 45000 RUB");
                    Controls.Add(DSSell);
                }
                if (Gun.Vintorez == 1)
                {
                    Button VSell = new Button();
                    if (X == 0)
                    {
                        X = 10;
                        
                    }
                    else
                    {
                        X = X + 110;
                        
                    }
                    if (X > 340)
                    {
                        Y += 50;
                        X = 10;
                    }
                    VSell.Location = new Point(X, Y);
                    VSell.Size = new Size(100, 50);
                    VSell.Click += new EventHandler(VSell_Click);
                    VSell.BackgroundImage = Image.FromFile("Винторез.jpg", false);
                    VSell.BackgroundImageLayout = ImageLayout.Stretch;
                    toolTip1.SetToolTip(VSell, "ВСС Винторез???Впервые вижу такую машинку. 60000 RUB");
                    Controls.Add(VSell);
                }
                if (Gun.Gaus_Gun == 1)
                {
                    Button GSell = new Button();
                    if (X == 0)
                    {
                        X = 10;
                         
                    }
                    else
                    {
                        X = X + 110;
                        
                    }
                    if (X > 340)
                    {
                        Y += 50;
                        X = 10;
                    }
                    GSell.Location = new Point(X, Y);
                    GSell.Size = new Size(100, 50);
                    GSell.Click += new EventHandler(GSell_Click);
                    GSell.BackgroundImage = Image.FromFile("Гаус пушка.jpg", false);
                    GSell.BackgroundImageLayout = ImageLayout.Stretch;
                    toolTip1.SetToolTip(GSell, "Гаус-пушка???Она реально существует?! 100000 RUB");
                    Controls.Add(GSell);
                }
            }
            
        }

        private void SellPm_Click(object sender, EventArgs e)//PM
        {
            Globals.Money += 300;
            LabelMoney.Text = Globals.Money.ToString();
            Gun.PM = 0;
            MessageBox.Show ("Держи деньги, гони ствол!\nПродан предмет: Пистолет Макарова");
            FormShopSidor form2 = new FormShopSidor();
            this.Hide();
            form2.ShowDialog();
            this.Close();
            
        }

        private void BerettaSell_Click(object sender, EventArgs e) //Beretta
        {
            Globals.Money += 800;
            LabelMoney.Text = Globals.Money.ToString();
            Gun.Beretta = 0;
            MessageBox.Show("Держи деньги, гони ствол!\nПродан предмет: Пистолет Beretta");
            FormShopSidor form2 = new FormShopSidor();
            this.Hide();
            form2.ShowDialog();
            this.Close();
            
        }

        private void DESell_Click(object sender, EventArgs e)//Desert Eagle
        {
            Globals.Money += 1300;
            LabelMoney.Text = Globals.Money.ToString();
            Gun.Desert_Eagle = 0;
            MessageBox.Show("Держи деньги, гони ствол!\nПродан предмет: Пистолет Desert Eagle");
            FormShopSidor form2 = new FormShopSidor();
            this.Hide();
            form2.ShowDialog();
            this.Close();
            
        }

        private void AKSSell_Click(object sender, EventArgs e)//АКС - 74У
        {
            Globals.Money += 1100;
            LabelMoney.Text = Globals.Money.ToString();
            Gun.AKS_74Y = 0;
            MessageBox.Show("Держи деньги, гони ствол!\nПродан предмет: Автомат АКС - 74У");
            FormShopSidor form2 = new FormShopSidor();
            this.Hide();
            form2.ShowDialog();
            this.Close();

        }

        private void AKSell_Click(object sender, EventArgs e)//АК - 105
        {
            Globals.Money += 3600;
            LabelMoney.Text = Globals.Money.ToString();
            Gun.AK_105 = 0;
            MessageBox.Show("Держи деньги, гони ствол!\nПродан предмет: Автомат АК - 105");
            FormShopSidor form2 = new FormShopSidor();
            this.Hide();
            form2.ShowDialog();
            this.Close();

        }

        private void AHSell_Click(object sender, EventArgs e)//Ан - 94
        {
            Globals.Money += 9000;
            LabelMoney.Text = Globals.Money.ToString();
            Gun.AH_94 = 0;
            MessageBox.Show("Держи деньги, гони ствол!\nПродан предмет: Автомат АН - 94");
            FormShopSidor form2 = new FormShopSidor();
            this.Hide();
            form2.ShowDialog();
            this.Close();

        }
        private void TOZSell_Click(object sender, EventArgs e)//ТОЗ - 34
        {
            Globals.Money += 1900;
            LabelMoney.Text = Globals.Money.ToString();
            Gun.TOZ34 = 0;
            MessageBox.Show("Держи деньги, гони ствол!\nПродан предмет: Обрез ТОЗ - 34");
            FormShopSidor form2 = new FormShopSidor();
            this.Hide();
            form2.ShowDialog();
            this.Close();

        }

        private void SGSell_Click(object sender, EventArgs e)//Ружье
        {
            Globals.Money += 2300;
            LabelMoney.Text = Globals.Money.ToString();
            Gun.ShotGun= 0;
            MessageBox.Show("Держи деньги, гони ствол!\nПродан предмет: Ружье");
            FormShopSidor form2 = new FormShopSidor();
            this.Hide();
            form2.ShowDialog();
            this.Close();

        }
        private void SSell_Click(object sender, EventArgs e)//Сайга
        {
            Globals.Money += 6700;
            LabelMoney.Text = Globals.Money.ToString();
            Gun.Saiga_12 = 0;
            MessageBox.Show("Держи деньги, гони ствол!\nПродан предмет: Сайга - 12");
            FormShopSidor form2 = new FormShopSidor();
            this.Hide();
            form2.ShowDialog();
            this.Close();

        }
        private void DSSell_Click(object sender, EventArgs e)//СВД
        {
            Globals.Money += 45000;
            LabelMoney.Text = Globals.Money.ToString();
            Gun.Dragunov_sniper_rifle = 0;
            MessageBox.Show("Держи деньги, гони ствол!\nПродан предмет: Снайперская Винтовка Драгунова");
            FormShopSidor form2 = new FormShopSidor();
            this.Hide();
            form2.ShowDialog();
            this.Close();

        }
        private void VSell_Click(object sender, EventArgs e)//Винторез
        {
            Globals.Money += 60000;
            LabelMoney.Text = Globals.Money.ToString();
            Gun.Vintorez = 0;
            MessageBox.Show("Держи деньги, гони ствол!\nПродан предмет: ВВС Винторез");
            FormShopSidor form2 = new FormShopSidor();
            this.Hide();
            form2.ShowDialog();
            this.Close();

        }

        private void GSell_Click(object sender, EventArgs e)//Гауспушка
        {
            Globals.Money += 100000;
            LabelMoney.Text = Globals.Money.ToString();
            Gun.Gaus_Gun = 0;
            MessageBox.Show("Держи деньги, гони ствол!\nПродан предмет: Гаус пушка");
            FormShopSidor form2 = new FormShopSidor();
            this.Hide();
            form2.ShowDialog();
            this.Close();

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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Globals s = new Globals();
            s.Save();
            MessageBox.Show("Процесс игры сохранен.");
        }
    }
}
