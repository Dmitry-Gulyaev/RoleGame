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
    public partial class FormIntro : Form
    {
        
        public FormIntro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globals read = new Globals();
            read.Reader();
            FormVillage form2 = new FormVillage();
            this.Hide();
            form2.ShowDialog();
            this.Close();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormIntro_Load(object sender, EventArgs e)
        {
            
        }
    }
}
