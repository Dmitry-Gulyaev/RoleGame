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
            label2.Text = Statistics.KillDogs.ToString();
        }
    }
}
