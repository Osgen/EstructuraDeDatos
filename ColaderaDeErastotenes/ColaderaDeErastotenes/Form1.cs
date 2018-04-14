using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColaderaDeErastotenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnGenerar_Click(object sender, EventArgs e)
        {
            Coladera c = new Coladera();
            txtRes.Text= c.enterosPrimos(1000);
        }
    }
}
