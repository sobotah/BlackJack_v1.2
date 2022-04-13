using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSTART_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            this.Hide();

            BlackJack f1 = new BlackJack();

            f1.Show();

        }
    }
}
