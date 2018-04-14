using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Circulo c1 = new Circulo();
            double area =c1.Area();
            Circulo c2 = new Circulo(7);
            c2.Area();
            Cuadrado cua1 = new Cuadrado();
            cua1.Area();
            Cuadrado cua2 = new Cuadrado(10);
            cua2.Area();
            Triangulo t1 = new Triangulo();
            t1.Area();
            Triangulo t2 = new Triangulo(15, 30);
            t2.Area();
            Reactangulo r1 = new Reactangulo();
            r1.Area();
            Reactangulo r2 = new Reactangulo(10, 50);
            r2.Area();
        }
    }
}
