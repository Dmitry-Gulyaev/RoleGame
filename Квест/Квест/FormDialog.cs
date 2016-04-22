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
    public partial class FormDialog : Form
    {
        public FormDialog()
        {
            InitializeComponent();
            LabelHeal.Text = Globals.Heal.ToString();
            LabelLevel.Text = Globals.Level.ToString();
            LabelMoney.Text = Globals.Money.ToString();



        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Globals s = new Globals();
            s.Save();
            MessageBox.Show("Процесс игры сохранен.");
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

        private void FormDialog_Load(object sender, EventArgs e)
        {
            if (IdDialog.PeopleDialog == "Шрам1")
            {

            this.BackgroundImage = Image.FromFile("Шрам.jpg", false);
            //this.Size = new Size(500, 432);
         
            
            dialog.BackColor = Color.Transparent;
            dialog.ForeColor = Color.White;
            dialog.Text = "Ему удалось нанять двоих профессиональных сталкеров для помощи с освоением Андрея в Зоне, \nа также для помощи поиска остальных ингредиентов Оазисонола. \nШрам и Клин дали Андрею прозвище Лис и теперь их путешествие по Большой земле подошло к концу. \nПосле непродолжительного похода от Центра Изучения ЧЗО впереди показалась колючая проволока \nи бетонные заборы - периметр Зоны. \nВам предстояло пройти через блокпост, который тщательно охранялся военными. \nШрам: - Так, нам нужно либо сразу разделиться и в рассыпную, ибо идти толпой - опасно, \nлибо подойти поближе и разведать обстановку. Если на дежурстве сегодня капитан Абрамов, \nто можем немного заплатить ему и пройти спокойно. \nЕсли Устименко, то разговаривать с ним и смысла нет. ";
            Controls.Add(dialog);

            
            Answer1.Location = new Point(25, 370);
            Answer1.Size = new Size(500, 25); 
            Answer1.Text = "Подойдем поближе и посмотрим кто дежурный.";
            Answer1.Click += new EventHandler(Answer1_Click);
            Controls.Add(Answer1);

          
            Answer2.Location = new Point(25, 400);
            Answer2.Size = new Size(500, 25);
            Answer2.Text = "Давайте разделимся. Встретимся в условном месте.";
            Answer2.Click += new EventHandler(Answer2_Click);
            Controls.Add(Answer2);
            }
        }

            private void Answer1_Click(object sender, EventArgs e)
    {
            Random rand = new Random();
            int a = rand.Next(1,3);
                if (a == 1)
                {
                    if (Contr.KPP == 1)
                    {
                        dialog.Text = "Вам удалось подойти поближе.  На дежурстве был капитан Абрамов.";
                        Controls.Add(dialog);
                        Answer1.Text = "Поговорить с Капитаном.";
                        Answer1.Click +=new EventHandler (DialogAbramov_Click);
                        Answer2.Text = "Попробовать проникнуть незаметно";
                        Answer2.Click += new EventHandler(Penetrate_Click);
                    }
                    if (Contr.KPP == 2)
                    {
                        dialog.Text = "Вам удалось подойти поближе.  На дежурстве был капитан Устименко.";
                        Controls.Add(dialog);
                        Answer1.Text = "Попробовать проникнуть незаметно";
                        Answer1.Click += new EventHandler(Penetrate_Click);
                        Answer2.Visible = false;

                    }
                }
                if (a == 2)
                {
                    dialog.Text = "Вам не удалось подойти ближе и вас заметили! \nС блокпоста по вам открыли пулеметный огонь и все вы разбежались в разные стороны.\nЛис залег в кустах, укрывшись за огромным камнем. Он слышал, как в нескольких метрах рыскали \nвоенные.Это значит, что огонь из пулеметов не откроют, потому что есть риск задеть своих.\nБежать! Сейчас или никогда!";
                    Controls.Add(dialog);

                    Answer1.Text = "Бежать!!!";
                    Answer1.Click += new EventHandler(Escape_Click);
                    Answer2.Visible = false;
                }


    }
            private void Answer2_Click(object sender, EventArgs e)
             {

             }

            private void DialogAbramov_Click(object sender, EventArgs e)
            {
                dialog.Text = "((Разговор с Абрамовым))";
            }
            private void Penetrate_Click(object sender, EventArgs e) // попробовать пройти незаметно
            {
                dialog.Text = "((Проход))";
            }
            private void Escape_Click(object sender, EventArgs e) // побег
            {
                dialog.Text = "((побег))";
            }


    }

    
}
