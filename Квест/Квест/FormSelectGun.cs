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
    public partial class FormSelectGun : Form
    {
        public FormSelectGun()
        {
            InitializeComponent();
            
          
            if (Globals.Ammo < 1)
            {
                Label lable1 = new Label();
                lable1.Location = new Point(50, 50);
                lable1.Size = new Size(1000, 100);
                lable1.Text = "Нет патронов. Также как и шансов спастись ...";
                Controls.Add(lable1);
                Globals.Heal = 0;
                Button Loss = new Button();
                Loss.Location = new Point(120, 150);
                Loss.Size = new Size(100, 50);
                Loss.Text = "Не успеть убежать";
                Loss.Click += new EventHandler(Loss_Click);
                Controls.Add(Loss);
               
                
                
            }
            // ============================= Пистолет Макарова ПМ ===============
            if (Gun.PM == 1 && Globals.Ammo > 0)
            {
                
                Button newbtn = new Button();
                newbtn.Location = new Point(10, 50);
                newbtn.Name = "newbtnPM";
                newbtn.Size = new Size(100, 50);
                newbtn.BackgroundImage = Image.FromFile("ПМ.jpg",false);
                newbtn.BackgroundImageLayout = ImageLayout.Stretch;

                newbtn.TabIndex = 3;
                newbtn.Text = "";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnPM_Click);
                toolTip1.SetToolTip(newbtn, "Пистолет Макарова");
                Controls.Add(newbtn);
            }
            if (Gun.PM == 0 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(10, 50);
                newbtn.Name = "newbtnNoPM";
                newbtn.Size = new Size(100, 50);
                newbtn.TabIndex = 3;
                newbtn.Text = "Слот пуст";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnNoPM_Click);
                Controls.Add(newbtn);
            }

            // ============================= Беретта Beretta ===============

            if (Gun.Beretta == 1 && Globals.Ammo > 0)
            {
                
                Button newbtn = new Button();
                newbtn.Location = new Point(120, 50);
                newbtn.Name = "newbtnBeretta";
                newbtn.Size = new Size(100, 50);
                newbtn.BackgroundImage = Image.FromFile("Beretta.jpg", false);
                newbtn.TabIndex = 3;
                newbtn.Text = " ";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnBeretta_Click);
                toolTip1.SetToolTip(newbtn, "Beretta");
                Controls.Add(newbtn);
            }
            if (Gun.Beretta == 0 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(120, 50);
                newbtn.Name = "newbtnNoBeretta";
                newbtn.Size = new Size(100, 50);
                newbtn.TabIndex = 3;
                newbtn.Text = "Слот пуст";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnNoBeretta_Click);
                Controls.Add(newbtn);
            }

            // ============================= Desert Eagle Пустынный орел ===============

            if (Gun.Desert_Eagle == 1 && Globals.Ammo > 0)
            {
                
                Button newbtn = new Button();
                newbtn.Location = new Point(230, 50);
                newbtn.Name = "newbtnDE";
                newbtn.Size = new Size(100, 50);
                newbtn.BackgroundImage = Image.FromFile("Desert Eagle.jpg", false);
                newbtn.BackgroundImageLayout = ImageLayout.Stretch;
                newbtn.TabIndex = 3;
                newbtn.Text = "";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnDE_Click);
                toolTip1.SetToolTip(newbtn, "Desert Eagle");
                Controls.Add(newbtn);
            }
            if (Gun.Desert_Eagle == 0 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(230, 50);
                newbtn.Name = "newbtnNoDE";
                newbtn.Size = new Size(100, 50);
                newbtn.TabIndex = 3;
                newbtn.Text = "Слот пуст";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnNoDE_Click);
                Controls.Add(newbtn);
            }

            // ============================= АКС - 74у ===============

            if (Gun.AKS_74Y == 1 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(10, 100);
                newbtn.Name = "newbtnAKS74Y";
                newbtn.Size = new Size(100, 50);
                newbtn.BackgroundImage = Image.FromFile("АКС - 74У.jpg", false);
                newbtn.BackgroundImageLayout = ImageLayout.Stretch;
                newbtn.TabIndex = 3;
                newbtn.Text = " ";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnAKS74Y_Click);
                toolTip1.SetToolTip(newbtn, "АКС - 74У");
                Controls.Add(newbtn);
            }
            if (Gun.AKS_74Y == 0 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(10, 100);
                newbtn.Name = "newbtnNoAKS_74Y";
                newbtn.Size = new Size(100, 50);
                newbtn.TabIndex = 3;
                newbtn.Text = "Слот пуст";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnNoAKS74Y_Click);
                Controls.Add(newbtn);
            }

            // ============================= АК - 105 ===============

            if (Gun.AK_105 == 1 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(120, 100);
                newbtn.Name = "newbtnAK_105";
                newbtn.Size = new Size(100, 50);
                newbtn.BackgroundImage = Image.FromFile("АК - 105.jpg", false);
                newbtn.BackgroundImageLayout = ImageLayout.Stretch;
                newbtn.TabIndex = 3;
                newbtn.Text = "";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnAK105_Click);
                toolTip1.SetToolTip(newbtn, "АК - 105");
                Controls.Add(newbtn);
            }
            if (Gun.AK_105 == 0 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(120, 100);
                newbtn.Name = "newbtnNoAK_105";
                newbtn.Size = new Size(100, 50);
                newbtn.TabIndex = 3;
                newbtn.Text = "Слот пуст";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnNoAK105_Click);
                Controls.Add(newbtn);
            }

            // ============================= АН 94 ===============

            if (Gun.AH_94 == 1 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(230, 100);
                newbtn.Name = "newbtnAH_94";
                newbtn.Size = new Size(100, 50);
                newbtn.BackgroundImage = Image.FromFile("АН - 94.jpg", false);
                newbtn.BackgroundImageLayout = ImageLayout.Stretch;
                newbtn.TabIndex = 3;
                newbtn.Text = "";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnAH94_Click);
                toolTip1.SetToolTip(newbtn, "АH - 94");
                Controls.Add(newbtn);
            }
            if (Gun.AH_94 == 0 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(230, 100);
                newbtn.Name = "newbtnNoAH_94";
                newbtn.Size = new Size(100, 50);
                newbtn.TabIndex = 3;
                newbtn.Text = "Слот пуст";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnNoAH94_Click);
                Controls.Add(newbtn);
            }

            // ============================= Тоз 34 обрез ===============

            if (Gun.TOZ34 == 1 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(10, 150);
                newbtn.Name = "newbtnTOZ34";
                newbtn.Size = new Size(100, 50);
                newbtn.BackgroundImage = Image.FromFile("ТОЗ - 34.jpg", false);
                newbtn.BackgroundImageLayout = ImageLayout.Stretch;
                newbtn.TabIndex = 3;
                newbtn.Text = "";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnTOZ34_Click);
                toolTip1.SetToolTip(newbtn, "ТОЗ - 34");
                Controls.Add(newbtn);
            }
            if (Gun.TOZ34 == 0 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(10, 150);
                newbtn.Name = "newbtnNoTOZ34";
                newbtn.Size = new Size(100, 50);
                newbtn.TabIndex = 3;
                newbtn.Text = "Слот пуст";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnNoTOZ34_Click);
                Controls.Add(newbtn);
            }

            // ============================= Ружье ===============

            if (Gun.ShotGun == 1 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(120, 150);
                newbtn.Name = "newbtnShotGun";
                newbtn.Size = new Size(100, 50);
                newbtn.BackgroundImage = Image.FromFile("Ружье.jpg", false);
                newbtn.BackgroundImageLayout = ImageLayout.Stretch;
                newbtn.TabIndex = 3;
                newbtn.Text = "";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnShotGun_Click);
                toolTip1.SetToolTip(newbtn, "Ружье");
                Controls.Add(newbtn);
            }
            if (Gun.ShotGun == 0 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(120, 150);
                newbtn.Name = "newbtnNoShotGun";
                newbtn.Size = new Size(100, 50);
                newbtn.TabIndex = 3;
                newbtn.Text = "Слот пуст";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnNoShotGun_Click);
                Controls.Add(newbtn);
            }

            // ============================= Сайга 12 ===============

            if (Gun.Saiga_12 == 1 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(230, 150);
                newbtn.Name = "newbtnSaiga_12";
                newbtn.Size = new Size(100, 50);
                newbtn.BackgroundImage = Image.FromFile("Сайга.jpg", false);
                newbtn.BackgroundImageLayout = ImageLayout.Stretch;
                newbtn.TabIndex = 3;
                newbtn.Text = "";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnSaiga12_Click);
                toolTip1.SetToolTip(newbtn, "Сайга - 12");
                Controls.Add(newbtn);
            }
            if (Gun.Saiga_12 == 0 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(230, 150);
                newbtn.Name = "newbtnNoSaiga_12";
                newbtn.Size = new Size(100, 50);
                newbtn.TabIndex = 3;
                newbtn.Text = "Слот пуст";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnNoSaiga12_Click);
                Controls.Add(newbtn);
            }

            // ============================= СВД ===============

            if (Gun.Dragunov_sniper_rifle == 1 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(10, 200);
                newbtn.Name = "newbtnDragunov_sniper_rifle";
                newbtn.Size = new Size(100, 50);
                newbtn.BackgroundImage = Image.FromFile("СВД.jpg", false);
                newbtn.BackgroundImageLayout = ImageLayout.Stretch;
                newbtn.TabIndex = 3;
                newbtn.Text = "";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnDragunov_sniper_rifle_Click);
                toolTip1.SetToolTip(newbtn, "СВД");
                Controls.Add(newbtn);
            }
            if (Gun.Dragunov_sniper_rifle == 0 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(10, 200);
                newbtn.Name = "newbtnNoDragunov_sniper_rifle";
                newbtn.Size = new Size(100, 50);
                newbtn.TabIndex = 3;
                newbtn.Text = "Слот пуст";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnNoDragunov_sniper_rifle_Click);
                Controls.Add(newbtn);
            }

            // ============================= Винторез ===============

            if (Gun.Vintorez == 1 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(120, 200);
                newbtn.Name = "newbtnVintorez";
                newbtn.Size = new Size(100, 50);
                newbtn.BackgroundImage = Image.FromFile("Винторез.jpg", false);
                newbtn.BackgroundImageLayout = ImageLayout.Stretch;
                newbtn.TabIndex = 3;
                newbtn.Text = "";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnVintorez_Click);
                toolTip1.SetToolTip(newbtn, "Винторез");
                Controls.Add(newbtn);
            }
            if (Gun.Vintorez == 0 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(120, 200);
                newbtn.Name = "newbtnNoVintorez";
                newbtn.Size = new Size(100, 50);
                newbtn.TabIndex = 3;
                newbtn.Text = "Слот пуст";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnNoVintorez_Click);
                Controls.Add(newbtn);
            }

            // ============================= Гаус пушка===============

            if (Gun.Gaus_Gun == 1 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(230, 200);
                newbtn.Name = "newbtnGaus_Gun";
                newbtn.Size = new Size(100, 50);
                newbtn.BackgroundImage = Image.FromFile("Гаус пушка.jpg", false);
                newbtn.BackgroundImageLayout = ImageLayout.Stretch;
                newbtn.TabIndex = 3;
                newbtn.Text = "";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnGausGun_Click);
                toolTip1.SetToolTip(newbtn, "Гаус Пушка");
                Controls.Add(newbtn);
            }
            if (Gun.Gaus_Gun == 0 && Globals.Ammo > 0)
            {

                Button newbtn = new Button();
                newbtn.Location = new Point(230, 200);
                newbtn.Name = "newbtnNoGaus_Gun";
                newbtn.Size = new Size(100, 50);
                newbtn.TabIndex = 3;
                newbtn.Text = "Слот пуст";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtnNoGausGun_Click);
                Controls.Add(newbtn);
            }
        }

        private void newbtnPM_Click(object sender, EventArgs e)
        {
            FormBatleMonster form2 = new FormBatleMonster();
            id.SelGun = 1;
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
        private void newbtnNoPM_Click(object sender, EventArgs e)
        {
            
        }
        private void newbtnBeretta_Click(object sender, EventArgs e)
        {
            FormBatleMonster form2 = new FormBatleMonster();
            id.SelGun = 2;
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
        private void newbtnNoBeretta_Click(object sender, EventArgs e)
        {

        }
        private void newbtnDE_Click(object sender, EventArgs e)
        {
            FormBatleMonster form2 = new FormBatleMonster();
            id.SelGun = 3; 
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
        private void newbtnNoDE_Click(object sender, EventArgs e)
        {

        }
        private void newbtnAKS74Y_Click(object sender, EventArgs e)
        {
            FormBatleMonster form2 = new FormBatleMonster();
            id.SelGun = 4;
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
        private void newbtnNoAKS74Y_Click(object sender, EventArgs e)
        {

        }
        private void newbtnAK105_Click(object sender, EventArgs e)
        {
            FormBatleMonster form2 = new FormBatleMonster();
            id.SelGun = 5; 
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
        private void newbtnNoAK105_Click(object sender, EventArgs e)
        {

        }
        private void newbtnAH94_Click(object sender, EventArgs e)
        {
            FormBatleMonster form2 = new FormBatleMonster();
            id.SelGun = 6;
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
        private void newbtnNoAH94_Click(object sender, EventArgs e)
        {

        }
        private void newbtnTOZ34_Click(object sender, EventArgs e)
        {
            FormBatleMonster form2 = new FormBatleMonster();
            id.SelGun = 7; 
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
        private void newbtnNoTOZ34_Click(object sender, EventArgs e)
        {

        }
        private void newbtnShotGun_Click(object sender, EventArgs e)
        {
            FormBatleMonster form2 = new FormBatleMonster();
            id.SelGun = 8; 
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
        private void newbtnNoShotGun_Click(object sender, EventArgs e)
        {

        }
        private void newbtnSaiga12_Click(object sender, EventArgs e)
        {
            FormBatleMonster form2 = new FormBatleMonster();
            id.SelGun = 9;
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
        private void newbtnNoSaiga12_Click(object sender, EventArgs e)
        {

        }
        private void newbtnDragunov_sniper_rifle_Click(object sender, EventArgs e)
        {
            FormBatleMonster form2 = new FormBatleMonster();
            id.SelGun = 10;
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
        private void newbtnNoDragunov_sniper_rifle_Click(object sender, EventArgs e)
        {

        }
        private void newbtnVintorez_Click(object sender, EventArgs e)
        {
            FormBatleMonster form2 = new FormBatleMonster();
            id.SelGun = 11;
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
        private void newbtnNoVintorez_Click(object sender, EventArgs e)
        {

        }
        private void newbtnGausGun_Click(object sender, EventArgs e)
        {
            FormBatleMonster form2 = new FormBatleMonster();
            id.SelGun = 12;
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
        private void newbtnNoGausGun_Click(object sender, EventArgs e)
        {

        }
        private void Loss_Click(object sender, EventArgs e)
        {
            FormLossDogs form2 = new FormLossDogs();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
        //============ Конец ================


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
