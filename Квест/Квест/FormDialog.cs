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
            if (Globals.Points > 100)
            {
                Globals.Level += 1;
                Globals.Points = 0;
            }
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
            Label dialog = new Label();
            dialog.Location = new Point (25,180);
            dialog.Size = new Size (500,140);
            dialog.BackColor = Color.Transparent;
            dialog.ForeColor = Color.White;
            dialog.Text = "Ему удалось нанять двоих профессиональных сталкеров для помощи с освоением Андрея в Зоне, а также для помощи поиска остальных ингредиентов Оазисонола. \nШрам и Клин дали Андрею прозвище Лис и теперь их путешествие по Большой земле подошло к концу. После непродолжительного похода от Центра Изучения ЧЗО впереди показалась колючая проволока и бетонные заборы - периметр Зоны. \nВам предстояло пройти через блокпост, который тщательно охранялся военными. \nШрам: - Так, нам нужно либо сразу разделиться и в рассыпную, ибо идти толпой - опасно, либо подойти поближе и разведать обстановку. Если на дежурстве сегодня капитан Абрамов, то можем немного заплатить ему и пройти спокойно. \nЕсли Устименко, то разговаривать с ним и смысла нет. ";
            Controls.Add(dialog);

            Button Answer1 = new Button();
            Answer1.Location = new Point(25, 320);
            Answer1.Size = new Size(500, 25); 
            Answer1.Text = "Подойдем поближе и посмотрим кто дежурный.";
            Answer1.Click += new EventHandler(Answer1_Click);
            Controls.Add(Answer1);

            Button Answer2 = new Button();
            Answer2.Location = new Point(25, 350);
            Answer2.Size = new Size(500, 25);
            Answer2.Text = "Давайте разделимся. Встретимся в условном месте.";
            Answer2.Click += new EventHandler(Answer2_Click);
            Controls.Add(Answer2);
            }
        }

            private void Answer1_Click(object sender, EventArgs e)
    {

    }
            private void Answer2_Click(object sender, EventArgs e)

     {
         FormVillage form2 = new FormVillage();
         this.Hide();
         form2.ShowDialog();
         this.Close();
     }

    }

    
}
