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
    public partial class FormStatistica : Form
    {
        public FormStatistica()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormStatistica_Load(object sender, EventArgs e)
        {
            label1.Text = "Убито Псевдособак:" + Statistics.KillDogs.ToString();
            label3.Text = "Убито Псевдоплотей :" + Statistics.KillFlech.ToString();
            label4.Text = "Убито Кабанов :" + Statistics.KillBoar.ToString();
            label5.Text = "Убито Снорков  :" + Statistics.KillSnork.ToString();
            label6.Text = "Убито Полтергейст :" + Statistics.KillPoltergeist.ToString();
            label7.Text = "Убито Контролеров :" + Statistics.KillController.ToString();
            label8.Text = "Убито Бюреров :" + Statistics.KillByurer.ToString();
            label9.Text = "Убито Химер :" + Statistics.KillChimera.ToString();
            label10.Text = "Убито Псевдогигантов :" + Statistics.KillGiant.ToString();
            label11.Text = "Убито Кровососов :" + Statistics.KillLeech.ToString();
        }
    }
}
