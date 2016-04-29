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
    public partial class FormLocation : Form
    {
        public FormLocation()
        {
            

            InitializeComponent();
            button1.Visible = false;
            
            if (id.Location == 1)
            {
                this.BackgroundImage = Image.FromFile("Ферма.jpg",false);
                this.Size = new Size(708, 400);
                this.Text = "Ферма";
                
                label.Size = new Size(650, 70);
                label.BackColor = Color.Transparent;
                label.ForeColor = Color.White;
                label.Text = "Ферма - заброшенные деревянные и кирпичные строения. Иногда здесь останавливаются сталкеры и бандиты. \nНичего примечательного у этого места нет, но поговаривают о наличии у фермы подземной вентиляционной шахты. \nГде вход в нее никто не знает, но говорят, что нашедшие эту шахту сталкеры пропали. Если это больше, чем легенда, \nто сталкеры пропали не просто так. \nЗона наверняка что-то охраняет. ";
                Controls.Add(label);

                Button newbtn = new Button();
                newbtn.Location = new Point(10, 100);
                newbtn.Size = new Size(150, 50);
                newbtn.Text = "Исследовать левый ангар";
                newbtn.Click += new EventHandler(Farm1_Click);
                Controls.Add(newbtn);

                Button newbtn2 = new Button();
                newbtn2.Location = new Point(160, 100);
                newbtn2.Size = new Size(150, 50);
                newbtn2.Text = "Исследовать правый ангар";
                newbtn2.Click += new EventHandler(Farm2_Click);
                Controls.Add(newbtn2);

                Button newbtn3 = new Button();
                newbtn3.Location = new Point(310, 100);
                newbtn3.Size = new Size(150, 50);
                newbtn3.Text = "Исследовать двор фермы";
                newbtn3.Click += new EventHandler(Farm3_Click);
                Controls.Add(newbtn3);
                

                Button newbtn1 = new Button();
                newbtn1.Location = new Point(160, 150);
                newbtn1.Size = new Size(150, 50);
                newbtn1.Text = "Отправиться в Зону";
                newbtn1.Click += new EventHandler(newbtn1_Click);
                Controls.Add(newbtn1);

                if (Statistics.SecretFarmCatacombs == 1)
                {
                    Button Secret = new Button();
                    Secret.Location = new Point(160, 200);
                    Secret.Size = new Size(150, 50);
                    Secret.Text = "Спуститься в люк";
                    Secret.Click += new EventHandler(Secret_Click);
                    Controls.Add(Secret);

                }


            }

            if (id.Location == 2)
            {
                this.BackgroundImage = Image.FromFile("АТП.jpg", false);
                this.Size = new Size(819, 400);
                this.Text = "АТП";
                
                label.Size = new Size(650, 70);
                label.BackColor = Color.Transparent;
                label.ForeColor = Color.White;
                label.Text = "Множество заброшенных гаражей, зданий и проржавевшего транспорта, огороженные бетонным забором - отличное оборонительное место. \nЗдесь и обосновались местные бандиты. \nИх организованности и слаженности могут позавидовать даже Долговцы. При контакте с ними будьте осторожны. \nОни сами не знают чего хотят: напасть или отпустить восвояси ";
                Controls.Add(label);

                Button newbtn = new Button();
                newbtn.Location = new Point(210, 100);
                newbtn.Size = new Size(150, 50);
                newbtn.Text = "Исследовать место";
                newbtn.Click += new EventHandler(newbtn2_Click);
                Controls.Add(newbtn);

                Button newbtn1 = new Button();
                newbtn1.Location = new Point(210, 150);
                newbtn1.Size = new Size(150, 50);
                newbtn1.Text = "Отправиться в Зону";
                newbtn1.Click += new EventHandler(newbtn1_Click);
                Controls.Add(newbtn1);
            }
            if (id.Location == 3)
            {
                this.BackgroundImage = Image.FromFile("НИИ Агропром.jpg", false);
                this.Size = new Size(711, 400);
                this.Text = "НИИ Агропром";
                
                label.Size = new Size(650, 70);
                label.BackColor = Color.Transparent;
                label.ForeColor = Color.White;
                label.Text = "Представляет из себя огромный комплекс сооружений. Не зря за это место когда-то шла ожесточенная война между \nгруппировками. Сейчас часть комплекса принадлежит Долговцам, другая его часть, заполненная аномалиями, доступна для \nпосещения сталкерами. Где-то у территории НИИ имеются подземные катакомбы. ";
                Controls.Add(label);

                Button newbtn = new Button();
                newbtn.Location = new Point(210, 100);
                newbtn.Size = new Size(150, 50);
                newbtn.Text = "Исследовать место";
                newbtn.Click += new EventHandler(newbtn3_Click);
                Controls.Add(newbtn);

                Button newbtn1 = new Button();
                newbtn1.Location = new Point(210, 150);
                newbtn1.Size = new Size(150, 50);
                newbtn1.Text = "Отправиться в Зону";
                newbtn1.Click += new EventHandler(newbtn1_Click);
                Controls.Add(newbtn1);
            }
            if (id.Location == 4)
            {
                this.BackgroundImage = Image.FromFile("Темная долина.jpg", false);
                this.Size = new Size(533, 400);
                this.Text = "Тёмная долина";
                
                label.Size = new Size(650, 70);
                label.BackColor = Color.Transparent;
                label.ForeColor = Color.White;
                label.Text = "Огромная по площади таящая опасность долина. Скудный пейзаж, \nболотистая местность, изобилие аномалий и мутантов - главные ее достопримечательности. \nНа юге долины находятся сооружения, которые сейчас принадлежат группировке Свобода. ";
                Controls.Add(label);

                Button newbtn = new Button();
                newbtn.Location = new Point(210, 100);
                newbtn.Size = new Size(150, 50);
                newbtn.Text = "Исследовать место";
                newbtn.Click += new EventHandler(newbtn4_Click);
                Controls.Add(newbtn);

                Button newbtn1 = new Button();
                newbtn1.Location = new Point(210, 150);
                newbtn1.Size = new Size(150, 50);
                newbtn1.Text = "Отправиться в Зону";
                newbtn1.Click += new EventHandler(newbtn1_Click);
                Controls.Add(newbtn1);
            }
        }



        
        private void newbtn2_Click(object sender, EventArgs e)
        {

        }
        private void newbtn3_Click(object sender, EventArgs e)
        {

        }
        private void newbtn4_Click(object sender, EventArgs e)
        {

        }

        private void Farm1_Click(object sender, EventArgs e)//Ферма левый ангар
        {
            if (Contr.Farm == 0)
            {
                label.Text = "Сейчас Ферма пустует и ничего интересного найти на ней не предоставляется возможным.";
                
            }
            if (Contr.Farm == 1)
            {
                label.Text = "Сейчас ферма перепала во временное владение к бандитам.";

                button1.Visible = true;
                button1.Size = new Size(150, 50);
                button1.Text = "Поговорить с бандитами";
                button1.Click += new EventHandler(button1_Click); 
                Controls.Add(button1);

            }
            if (Contr.Farm == 2)
            {
                label.Text = "Сейчас ферма перепала во временное владение к сталкерам.";

                button1.Visible = true;
                button1.Size = new Size(150, 50);
                button1.Text = "Поговорить со сталкерами";
                button1.Click += new EventHandler(button1_Click);
                Controls.Add(button1);
            }

        }
        private void Farm2_Click(object sender, EventArgs e)//Ферма правый ангар
        {
            if (Contr.Farm == 0)
            {
                label.Text = "Сейчас Ферма пустует и ничего интересного найти на ней не предоставляется возможным.";

            }
            if (Contr.Farm == 1)
            {
                label.Text = "Сейчас ферма перепала во временное владение к бандитам.Немного побродив, ты нашел их главного.";

                button1.Visible = true;
                button1.Size = new Size(150, 50);
                button1.Text = "Поговорить с главарем бандитов";
                button1.Click += new EventHandler(button1_Click);
                Controls.Add(button1);
            }
            if (Contr.Farm == 2)
            {
                label.Text = "Сейчас ферма перепала во временное владение к сталкерам.";

                button1.Visible = true;
                button1.Size = new Size(150, 50);
                button1.Text = "Поговорить со сталкерами";
                button1.Click += new EventHandler(button1_Click);
                Controls.Add(button1);
            }
        }
        private void Farm3_Click(object sender, EventArgs e)//Ферма
        {
            if (Contr.Farm == 0)
            {
                if (Statistics.SecretFarmCatacombs == 1)
                {
                    Button Secret = new Button();
                    Secret.Location = new Point(160, 200);
                    Secret.Size = new Size(150, 50);
                    Secret.Text = "Спуститься в люк";
                    Secret.Click += new EventHandler(Secret_Click);
                    Controls.Add(Secret);

                }
                Random rand = new Random();
                int a = rand.Next(1, 50);
                if (a == 9)
                {
                    label.Text = "В поисках чего-нибудь интересного ты случайно натыкаешься на какой-то люк. Кхм...Надо его приметить.";
                    Statistics.SecretFarmCatacombs = 1;
                }
                else
                    label.Text = "Сейчас Ферма пустует и ничего интересного найти на ней не предоставляется возможным.";
            }
            if (Contr.Farm == 1)
            {
                label.Text = "Сейчас ферма перепала во временное владение к бандитам. Окинув местность своим взором, \nты приметил выгодные места для нападения. Сумасшедшая идея, не правда ли? ";

                button1.Visible = true;
                button1.Size = new Size(150, 50);
                button1.Text = "Напасть на бандитов";
                button1.Click += new EventHandler(button1_Click);
                Controls.Add(button1);
            }
            if (Contr.Farm == 2)
            {
                label.Text = "Сейчас ферма перепала во временное владение к сталкерам.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Secret_Click(object sender, EventArgs e)//Ферма
        {

        }

        
        private void newbtn1_Click(object sender, EventArgs e)
        {
            FormTravel form2 = new FormTravel();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Globals s = new Globals();
            s.Save();
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

        private void FormLocation_Load(object sender, EventArgs e)
        {
            LabelHeal.Text = Globals.Heal.ToString();
            LabelLevel.Text = Globals.Level.ToString();
            LabelMoney.Text = Globals.Money.ToString();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
