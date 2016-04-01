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
            if (id.Monster == 1)
            {
                this.BackgroundImage = Image.FromFile("Псевдоплоть.jpg", false);
                this.Size = new Size(800, 736);
            }
            if (id.Monster == 2)
            {
                this.BackgroundImage = Image.FromFile("Кабан.jpg", false);
                this.Size = new Size(613, 476);
            }
            if (id.Monster == 3)
            {
                this.BackgroundImage = Image.FromFile("Псевдопес.jpg", false);
                this.Size = new Size(604,453);
            }
            if (id.Monster == 4)
            {
                this.BackgroundImage = Image.FromFile("Снорк.jpg", false);
                this.Size = new Size(680,470);
            }
            if (id.Monster == 5)
            {
                this.BackgroundImage = Image.FromFile("Кровосос.jpg", false);
                this.Size = new Size(604,453);
            }
            if (id.Monster == 6)
            {
                this.BackgroundImage = Image.FromFile("Полтергейст.png", false);
                this.Size = new Size(720,684);
            }
            if (id.Monster == 7)
            {
                this.BackgroundImage = Image.FromFile("Контролер.jpg", false);
                this.Size = new Size(1000,750);
            }
            if (id.Monster == 8)
            {
                this.BackgroundImage = Image.FromFile("Бюрер.jpg", false);
                this.Size = new Size(800,464);
            }
            if (id.Monster == 9)
            {
                this.BackgroundImage = Image.FromFile("Химера.jpg", false);
                this.Size = new Size(510,446);
            }
            if (id.Monster == 10)
            {
                this.BackgroundImage = Image.FromFile("Псевдогигант.jpg", false);
                this.Size = new Size(712,400);
            }
            
        }

        private Button[] S = new Button[10];
        public void InitB()
        {
        
        }
        private void FormBatleDogs_PM_Load(object sender, EventArgs e)
        {
            id.Click = 0;
            LabelHeal.Text = Globals.Heal.ToString();
            LabelLevel.Text = Globals.Level.ToString();
            LabelMoney.Text = Globals.Money.ToString();


            //----------========Проверка на уровень========---------
            int menace = 0;// уровень угрозы



            if (id.Monster == 1)//Бой с плотью
            {
                if (Globals.Level == 1 || Globals.Level == 2)
                    menace = 2;
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
                

                //=============Пистолет Макарова==========
                if (id.SelGun == 1)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);


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

                //==================Beretta===================
                if (id.SelGun == 2)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==================Desert Eagle====================
                if (id.SelGun == 3)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АКС - 74У===============
                if (id.SelGun == 4)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                        if (menace < 1)
                        {
                            FormVictoryDogs form2 = new FormVictoryDogs();
                            this.Hide();
                            form2.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            {
                                Button Shot = new Button();
                                Shot.Top = 30;
                                Shot.Left = 10 + 100 * i;
                                Shot.Size = new Size(100, 50);
                                Shot.Text = "+";
                                Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                this.Controls.Add(Shot);


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
                //==============АК - 105===============
                if (id.SelGun == 5)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АH 94===============
                if (id.SelGun == 6)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============ТО3 34===============
                if (id.SelGun == 7)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Ружье===============
                if (id.SelGun == 8)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Сайга===============
                if (id.SelGun == 9)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============СВД===============
                if (id.SelGun == 10)
                {
                    int hit = menace / 2;
                    if (menace % 2 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //==============Винторез===============
                if (id.SelGun == 11)
                {
                    int hit = menace / 3;
                    if (menace % 3 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //=============Гаус Пушка==========
                if (id.SelGun == 12)
                {

                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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


            if (id.Monster == 2) // бой с кабаном
            {
                if (Globals.Level == 1 || Globals.Level == 2)
                    menace = 2;
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



                //=============Пистолет Макарова==========
                if (id.SelGun == 1)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);


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

                //==================Beretta===================
                if (id.SelGun == 2)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==================Desert Eagle====================
                if (id.SelGun == 3)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АКС - 74У===============
                if (id.SelGun == 4)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                        if (menace < 1)
                        {
                            FormVictoryDogs form2 = new FormVictoryDogs();
                            this.Hide();
                            form2.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            {
                                Button Shot = new Button();
                                Shot.Top = 30;
                                Shot.Left = 10 + 100 * i;
                                Shot.Size = new Size(100, 50);
                                Shot.Text = "+";
                                Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                this.Controls.Add(Shot);


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
                //==============АК - 105===============
                if (id.SelGun == 5)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АH 94===============
                if (id.SelGun == 6)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============ТО3 34===============
                if (id.SelGun == 7)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Ружье===============
                if (id.SelGun == 8)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Сайга===============
                if (id.SelGun == 9)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============СВД===============
                if (id.SelGun == 10)
                {
                    int hit = menace / 2;
                    if (menace % 2 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //==============Винторез===============
                if (id.SelGun == 11)
                {
                    int hit = menace / 3;
                    if (menace % 3 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //=============Гаус Пушка==========
                if (id.SelGun == 12)
                {

                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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


            if (id.Monster == 3) // Бой с собакой
            {
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



                //=============Пистолет Макарова==========
                if (id.SelGun == 1)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);


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

                //==================Beretta===================
                if (id.SelGun == 2)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==================Desert Eagle====================
                if (id.SelGun == 3)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АКС - 74У===============
                if (id.SelGun == 4)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                        if (menace  < 1)
                        {
                            FormVictoryDogs form2 = new FormVictoryDogs();
                            this.Hide();
                            form2.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            {
                                Button Shot = new Button();
                                Shot.Top = 30;
                                Shot.Left = 10 + 100 * i;
                                Shot.Size = new Size(100, 50);
                                Shot.Text = "+";
                                Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                this.Controls.Add(Shot);


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
                //==============АК - 105===============
                if (id.SelGun == 5)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АH 94===============
                if (id.SelGun == 6)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============ТО3 34===============
                if (id.SelGun == 7)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Ружье===============
                if (id.SelGun == 8)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Сайга===============
                if (id.SelGun == 9)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============СВД===============
                if (id.SelGun == 10)
                {
                    int hit = menace / 2;
                    if (menace % 2 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //==============Винторез===============
                if (id.SelGun == 11)
                {
                    int hit = menace / 3;
                    if (menace % 3 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //=============Гаус Пушка==========
                if (id.SelGun == 12)
                {

                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
            }// Конец боя с собакой

            if (id.Monster == 4) //  Бой со снорком
            {
                if (Globals.Level == 1 || Globals.Level == 2)
                    menace = 4;
                if (Globals.Level == 3 || Globals.Level == 4 && Globals.Level == 5)
                    menace = 3;
                if (Globals.Level > 5)
                {
                    menace = 2;
                   
                }



                //=============Пистолет Макарова==========
                if (id.SelGun == 1)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);


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

                //==================Beretta===================
                if (id.SelGun == 2)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==================Desert Eagle====================
                if (id.SelGun == 3)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) <1 )
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АКС - 74У===============
                if (id.SelGun == 4)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                        if (menace < 1)
                        {
                            FormVictoryDogs form2 = new FormVictoryDogs();
                            this.Hide();
                            form2.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            {
                                Button Shot = new Button();
                                Shot.Top = 30;
                                Shot.Left = 10 + 100 * i;
                                Shot.Size = new Size(100, 50);
                                Shot.Text = "+";
                                Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                this.Controls.Add(Shot);


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
                //==============АК - 105===============
                if (id.SelGun == 5)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АH 94===============
                if (id.SelGun == 6)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============ТО3 34===============
                if (id.SelGun == 7)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Ружье===============
                if (id.SelGun == 8)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Сайга===============
                if (id.SelGun == 9)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============СВД===============
                if (id.SelGun == 10)
                {
                    int hit = menace / 2;
                    if (menace % 2 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //==============Винторез===============
                if (id.SelGun == 11)
                {
                    int hit = menace / 3;
                    if (menace % 3 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //=============Гаус Пушка==========
                if (id.SelGun == 12)
                {

                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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

            if (id.Monster == 5) //  Бой с кровососм
            {
                if (Globals.Level == 1 || Globals.Level == 2)
                    menace = 5;
                if (Globals.Level == 3 || Globals.Level == 4 && Globals.Level == 5)
                    menace = 3;
                if (Globals.Level > 5)
                {
                    menace = 2;
                    
                }



                //=============Пистолет Макарова==========
                if (id.SelGun == 1)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);


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

                //==================Beretta===================
                if (id.SelGun == 2)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==================Desert Eagle====================
                if (id.SelGun == 3)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АКС - 74У===============
                if (id.SelGun == 4)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                        if (menace  < 1)
                        {
                            FormVictoryDogs form2 = new FormVictoryDogs();
                            this.Hide();
                            form2.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            {
                                Button Shot = new Button();
                                Shot.Top = 30;
                                Shot.Left = 10 + 100 * i;
                                Shot.Size = new Size(100, 50);
                                Shot.Text = "+";
                                Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                this.Controls.Add(Shot);


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
                //==============АК - 105===============
                if (id.SelGun == 5)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АH 94===============
                if (id.SelGun == 6)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============ТО3 34===============
                if (id.SelGun == 7)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Ружье===============
                if (id.SelGun == 8)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Сайга===============
                if (id.SelGun == 9)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============СВД===============
                if (id.SelGun == 10)
                {
                    int hit = menace / 2;
                    if (menace % 2 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //==============Винторез===============
                if (id.SelGun == 11)
                {
                    int hit = menace / 3;
                    if (menace % 3 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //=============Гаус Пушка==========
                if (id.SelGun == 12)
                {

                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
            if (id.Monster == 6) //  Бой с полтергестом
            {
                if (Globals.Level == 1 || Globals.Level == 2)
                    menace = 5;
                if (Globals.Level == 3 || Globals.Level == 4 && Globals.Level == 5)
                    menace = 3;
                if (Globals.Level > 5)
                {
                    menace = 2;
                    
                }



                //=============Пистолет Макарова==========
                if (id.SelGun == 1)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);


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

                //==================Beretta===================
                if (id.SelGun == 2)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==================Desert Eagle====================
                if (id.SelGun == 3)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АКС - 74У===============
                if (id.SelGun == 4)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                        if (menace  < 1)
                        {
                            FormVictoryDogs form2 = new FormVictoryDogs();
                            this.Hide();
                            form2.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            {
                                Button Shot = new Button();
                                Shot.Top = 30;
                                Shot.Left = 10 + 100 * i;
                                Shot.Size = new Size(100, 50);
                                Shot.Text = "+";
                                Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                this.Controls.Add(Shot);


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
                //==============АК - 105===============
                if (id.SelGun == 5)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АH 94===============
                if (id.SelGun == 6)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============ТО3 34===============
                if (id.SelGun == 7)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Ружье===============
                if (id.SelGun == 8)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Сайга===============
                if (id.SelGun == 9)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============СВД===============
                if (id.SelGun == 10)
                {
                    int hit = menace / 2;
                    if (menace % 2 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //==============Винторез===============
                if (id.SelGun == 11)
                {
                    int hit = menace / 3;
                    if (menace % 3 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //=============Гаус Пушка==========
                if (id.SelGun == 12)
                {

                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
            if (id.Monster == 7) //  Бой  с контролером
            {
                if (Globals.Level == 1 || Globals.Level == 2)
                    menace = 6;
                if (Globals.Level == 3 || Globals.Level == 4 && Globals.Level == 5)
                    menace = 5;
                if (Globals.Level > 5)
                {
                    menace = 3;
                    
                }



                //=============Пистолет Макарова==========
                if (id.SelGun == 1)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);


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

                //==================Beretta===================
                if (id.SelGun == 2)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==================Desert Eagle====================
                if (id.SelGun == 3)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АКС - 74У===============
                if (id.SelGun == 4)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                        if (menace  < 1)
                        {
                            FormVictoryDogs form2 = new FormVictoryDogs();
                            this.Hide();
                            form2.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            {
                                Button Shot = new Button();
                                Shot.Top = 30;
                                Shot.Left = 10 + 100 * i;
                                Shot.Size = new Size(100, 50);
                                Shot.Text = "+";
                                Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                this.Controls.Add(Shot);


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
                //==============АК - 105===============
                if (id.SelGun == 5)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АH 94===============
                if (id.SelGun == 6)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============ТО3 34===============
                if (id.SelGun == 7)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Ружье===============
                if (id.SelGun == 8)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Сайга===============
                if (id.SelGun == 9)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============СВД===============
                if (id.SelGun == 10)
                {
                    int hit = menace / 2;
                    if (menace % 2 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //==============Винторез===============
                if (id.SelGun == 11)
                {
                    int hit = menace / 3;
                    if (menace % 3 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //=============Гаус Пушка==========
                if (id.SelGun == 12)
                {

                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
            if (id.Monster == 8) //  Бой  с бюрером
            {
                if (Globals.Level == 1 || Globals.Level == 2)
                    menace = 7;
                if (Globals.Level == 3 || Globals.Level == 4 && Globals.Level == 5)
                    menace = 5;
                if (Globals.Level > 5)
                {
                    menace = 3;
                    
                }



                //=============Пистолет Макарова==========
                if (id.SelGun == 1)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);


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

                //==================Beretta===================
                if (id.SelGun == 2)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==================Desert Eagle====================
                if (id.SelGun == 3)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АКС - 74У===============
                if (id.SelGun == 4)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                        if (menace  < 1)
                        {
                            FormVictoryDogs form2 = new FormVictoryDogs();
                            this.Hide();
                            form2.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            {
                                Button Shot = new Button();
                                Shot.Top = 30;
                                Shot.Left = 10 + 100 * i;
                                Shot.Size = new Size(100, 50);
                                Shot.Text = "+";
                                Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                this.Controls.Add(Shot);


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
                //==============АК - 105===============
                if (id.SelGun == 5)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АH 94===============
                if (id.SelGun == 6)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============ТО3 34===============
                if (id.SelGun == 7)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Ружье===============
                if (id.SelGun == 8)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Сайга===============
                if (id.SelGun == 9)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============СВД===============
                if (id.SelGun == 10)
                {
                    int hit = menace / 2;
                    if (menace % 2 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //==============Винторез===============
                if (id.SelGun == 11)
                {
                    int hit = menace / 3;
                    if (menace % 3 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //=============Гаус Пушка==========
                if (id.SelGun == 12)
                {

                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
            if (id.Monster == 9) //  Бой с химерой
            {
                if (Globals.Level == 1 || Globals.Level == 2)
                    menace = 9;
                if (Globals.Level == 3 || Globals.Level == 4 && Globals.Level == 5)
                    menace = 7;
                if (Globals.Level > 5)
                {
                    menace = 5;
                }



                //=============Пистолет Макарова==========
                if (id.SelGun == 1)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);


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

                //==================Beretta===================
                if (id.SelGun == 2)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==================Desert Eagle====================
                if (id.SelGun == 3)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АКС - 74У===============
                if (id.SelGun == 4)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                        if (menace  < 1)
                        {
                            FormVictoryDogs form2 = new FormVictoryDogs();
                            this.Hide();
                            form2.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            {
                                Button Shot = new Button();
                                Shot.Top = 30;
                                Shot.Left = 10 + 100 * i;
                                Shot.Size = new Size(100, 50);
                                Shot.Text = "+";
                                Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                this.Controls.Add(Shot);


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
                //==============АК - 105===============
                if (id.SelGun == 5)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АH 94===============
                if (id.SelGun == 6)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============ТО3 34===============
                if (id.SelGun == 7)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Ружье===============
                if (id.SelGun == 8)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Сайга===============
                if (id.SelGun == 9)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============СВД===============
                if (id.SelGun == 10)
                {
                    int hit = menace / 2;
                    if (menace % 2 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //==============Винторез===============
                if (id.SelGun == 11)
                {
                    int hit = menace / 3;
                    if (menace % 3 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //=============Гаус Пушка==========
                if (id.SelGun == 12)
                {

                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
            if (id.Monster == 10) //  Бой с псевдогигант
            {
                if (Globals.Level == 1 || Globals.Level == 2)
                    menace = 10;
                if (Globals.Level == 3 || Globals.Level == 4 && Globals.Level == 5)
                    menace = 10;
                if (Globals.Level > 5)
                {
                    menace = 8;
                }



                //=============Пистолет Макарова==========
                if (id.SelGun == 1)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);


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

                //==================Beretta===================
                if (id.SelGun == 2)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==================Desert Eagle====================
                if (id.SelGun == 3)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АКС - 74У===============
                if (id.SelGun == 4)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                        if (menace < 1)
                        {
                            FormVictoryDogs form2 = new FormVictoryDogs();
                            this.Hide();
                            form2.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            {
                                Button Shot = new Button();
                                Shot.Top = 30;
                                Shot.Left = 10 + 100 * i;
                                Shot.Size = new Size(100, 50);
                                Shot.Text = "+";
                                Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                                this.Controls.Add(Shot);


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
                //==============АК - 105===============
                if (id.SelGun == 5)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);


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
                //==============АH 94===============
                if (id.SelGun == 6)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 2);
                    if ((menace - 2) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 2; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============ТО3 34===============
                if (id.SelGun == 7)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 1);
                    if ((menace - 1) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 1; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Ружье===============
                if (id.SelGun == 8)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============Сайга===============
                if (id.SelGun == 9)
                {
                    Random rand = new Random();
                    int Victory = rand.Next(0, menace - 3);
                    if ((menace - 3) < 1)
                    {
                        FormVictoryDogs form2 = new FormVictoryDogs();
                        this.Hide();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        for (int i = 0; i < menace - 3; i++)
                        {
                            Button Shot = new Button();
                            Shot.Top = 30;
                            Shot.Left = 10 + 100 * i;
                            Shot.Size = new Size(100, 50);
                            Shot.Text = "+";
                            Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            this.Controls.Add(Shot);

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
                //==============СВД===============
                if (id.SelGun == 10)
                {
                    int hit = menace / 2;
                    if (menace % 2 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //==============Винторез===============
                if (id.SelGun == 11)
                {
                    int hit = menace / 3;
                    if (menace % 3 < 0)
                    {
                        hit = menace + 1;
                    }
                    Random rand = new Random();
                    int Victory = rand.Next(0, hit);// Для функции в 2 раза больше

                    for (int i = 0; i < hit; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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
                //=============Гаус Пушка==========
                if (id.SelGun == 12)
                {

                    Random rand = new Random();
                    int Victory = rand.Next(0, menace);
                    for (int i = 0; i < menace; i++)
                    {
                        Button Shot = new Button();
                        Shot.Top = 30;
                        Shot.Left = 10 + 100 * i;
                        Shot.Size = new Size(100, 50);
                        Shot.Text = "+";
                        Shot.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        this.Controls.Add(Shot);

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


        }
                
            



        
            private void VictoryShot_Click(object sender, EventArgs e)
            {  
                int maxdamage = 0;
                if (id.Monster == 1)
                {
                     maxdamage = 15;
                }
                if (id.Monster == 2)
                {
                     maxdamage = 20;
                }
                if (id.Monster == 3)
                {
                     maxdamage = 25;
                }
                if (id.Monster == 4)
                {
                     maxdamage = 35;
                }
                if (id.Monster == 5)
                {
                     maxdamage = 45;
                }
                if (id.Monster == 6)
                {
                    maxdamage = 50;
                }
                if (id.Monster == 7)
                {
                    maxdamage = 55;
                }
                if (id.Monster == 8)
                {
                    maxdamage = 60;
                }
                if (id.Monster == 9)
                {
                    maxdamage = 70;
                }
                if (id.Monster == 10)
                {
                    maxdamage = 80;
                }




                if (id.SelGun == 12) //Для Гаус Пушки
                {
                    Random rand = new Random();
                    int damage = rand.Next(10, maxdamage);
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
                else
 
                {
                    FormVictoryDogs form2 = new FormVictoryDogs();
                    this.Hide();
                    form2.ShowDialog();
                    this.Close();
                }
            }
            private void NoVictoryShot_Click(object sender, EventArgs e)
            {
                int maxdamage = 0;
                if (id.Monster == 1)
                {
                    maxdamage = 15;
                }
                if (id.Monster == 2)
                {
                    maxdamage = 20;
                }
                if (id.Monster == 3)
                {
                    maxdamage = 25;
                }
                if (id.Monster == 4)
                {
                    maxdamage = 35;
                }
                if (id.Monster == 5)
                {
                    maxdamage = 45;
                }
                if (id.Monster == 6)
                {
                    maxdamage = 50;
                }
                if (id.Monster == 7)
                {
                    maxdamage = 55;
                }
                if (id.Monster == 8)
                {
                    maxdamage = 60;
                }
                if (id.Monster == 9)
                {
                    maxdamage = 70;
                }
                if (id.Monster == 10)
                {
                    maxdamage = 80;
                }


                if (id.SelGun == 1 || id.SelGun == 2 || id.SelGun == 3 || id.SelGun == 8 || id.SelGun == 10)//Пм,Беретта, Desert Eagle, ружье, СВД
                {
                    Random rand = new Random();
                    int damage = rand.Next(10, maxdamage);
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
                
                if (id.SelGun == 4 || id.SelGun == 5 || id.SelGun ==7 || id.SelGun == 9) //АКС-74У AK-105 ТОЗ-34 Сайга
                {
                    id.Click += 1;
                    if (id.Click < 2)
                    {
                        Globals.Ammo -= 1;
                        MessageBox.Show("Мимо! Но и монстр тебя не достал. Стреляй еще!\n-1 патрон");
                    }
                    else
                    {
                        Random rand = new Random();
                        int damage = rand.Next(10, maxdamage);
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
                }
                if (id.SelGun == 11) //Винторез
                {
                    id.Click += 1;
                    if (id.Click < 3)
                    {
                        Globals.Ammo -= 1;
                        MessageBox.Show("Мимо! Но и монстр тебя не достал. Стреляй еще!\n-1 патрон");
                    }
                    else
                    {
                        Random rand = new Random();
                        int damage = rand.Next(10, maxdamage);
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
                }
                if (id.SelGun == 6) //AH 94
                {
                    id.Click += 1;
                    if (id.Click < 4)
                    {
                        Globals.Ammo -= 1;
                        MessageBox.Show("Мимо! Но и монстр тебя не достал. Стреляй еще!\n-1 патрон");
                    }
                    else
                    {
                        Random rand = new Random();
                        int damage = rand.Next(10, maxdamage);
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
                }
                if (id.SelGun == 12)
                {
                    FormVictoryDogs form2 = new FormVictoryDogs();
                    this.Hide();
                    form2.ShowDialog();
                    this.Close();
                }
                
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

            private void SaveButton_Click(object sender, EventArgs e)
            {
                Globals s = new Globals();
                s.Save();
                MessageBox.Show("Процесс игры сохранен.");
            }
    }
}
