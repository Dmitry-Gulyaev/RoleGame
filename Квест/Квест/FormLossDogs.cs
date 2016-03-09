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
            if (Globals.Heal > 0)
                label1.Text = "Собака вгрызлась Вам в плоть, но Вам удалось вырваться из ее когтей.";

            else

                label1.Text = "Вы погибли.";

        }
    }
}