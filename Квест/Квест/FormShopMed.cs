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
    public partial class FormShopMed : Form
    {
        public FormShopMed()
        {
            InitializeComponent();
            LabelHeal.Text = Globals.Heal.ToString();
            LabelLevel.Text = Globals.Level.ToString();
            LabelMoney.Text = Globals.Money.ToString();
        }

        private void FormShopMed_Load(object sender, EventArgs e)
        {
            if (id.Seller == 1)
            {
                label1.Text = "Подлечиться решил? Ну выбирай.";

                Button newbtn = new Button();
                newbtn.Location = new Point(10, 70);
                newbtn.Name = "Аптечка";
                newbtn.Size = new Size(100, 100);
                newbtn.BackgroundImage = Image.FromFile("Аптечка.jpg", false);
                // newbtn.BackgroundImageLayout = ImageLayout.Stretch;

                newbtn.TabIndex = 3;
                newbtn.Text = " ";
                newbtn.UseVisualStyleBackColor = true;
                newbtn.Click += new EventHandler(newbtn_Click);
                toolTip1.SetToolTip(newbtn, "Аптечка\nЦена: 150 RUB\n\nИнформация из энциклопедии:\nВосстанавливает 50 единиц здоровья.");
                Controls.Add(newbtn);


            }
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            if (Globals.Money < 150)
            {
                MessageBox.Show("Сидорович: -Нет у тебя денег столько. Вот как накопишь - приходи. Всегда рад!");
            }
            else
            {
                Globals.Money -= 150;
                LabelMoney.Text = Globals.Money.ToString();
                MedResource.medicine += 1;
                MessageBox.Show("Сидорович: - Держи аптечку. Надеюсь не пригодится!");

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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Globals s = new Globals();
            s.Save();
            MessageBox.Show("Процесс игры сохранен.");
        }
    }
}
