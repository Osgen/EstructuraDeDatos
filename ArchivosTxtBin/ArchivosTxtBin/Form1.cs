using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArchivosTxtBin
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool NoValido(Int16 bm)
        {
            if(bm == 19778)
            {
                return false ;
            }
            return true;
        }

        public string Datos(Int32 tam, Int32 an, Int32 alt, Int16 np)
        {
            string s = "Tamaño: " + tam +" bytes"+ Environment.NewLine + "Ancho: " + an +
                " Pixeles"+ Environment.NewLine + "Alto: " + alt+ " Pixeles"+Environment.NewLine+"No.Bit/Px: "+np;
            return s;
        }

        public string LeerArchivo()
        {
            ofd.ShowDialog();
            FileStream archivo = new FileStream(ofd.FileName, FileMode.Open);
            BinaryReader br = new BinaryReader(archivo);
           
            Int16 bm = br.ReadInt16();
          
            if (NoValido(bm))
            {
                br.Close();
                archivo.Close();
                return "No es un archivo BMP";
            }
            Int32 tamaño = br.ReadInt32();
            for(int i =0; i<12; i++)
            {
                br.Read();
            }
            Int32 ancho = br.ReadInt32();
            Int32 alto = br.ReadInt32();
            for (int i = 0; i < 2; i++)
            {
                br.Read();
            }
            Int16 nPixel = br.ReadInt16();
            br.Close();
            archivo.Close();
            return Datos(tamaño, ancho, alto,nPixel);
        }

        private void bttnAbrir_Click(object sender, EventArgs e)
        {
            txtDatos.Text= LeerArchivo();
        }

        public void GenerarXml(string tit, string genero, string des, string plat, string precio)
        {
            sfd.ShowDialog();
            FileStream archivo = new FileStream(sfd.FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(archivo);
            sw.WriteLine("<?xml version=\"1.0\" encoding =\"UTF - 8\" ?>");
            sw.WriteLine("<CATALOGO>");
            sw.WriteLine("  <JUEGO1>");
            sw.WriteLine("      <TITULO>" + tit + "</TITULO>");
            sw.WriteLine("      <GENERO>"+genero+"</GENERO>");
            sw.WriteLine("      <DESCRIPCION>"+des+"</DESCRIPCION>");
            sw.WriteLine("      <PLATAFORMA>" + plat + "</PLATAFORMA>");
            sw.WriteLine("      <PRECIO>"+precio+"</PRECIO>");
            sw.WriteLine("  </JUEGO1>");
            sw.WriteLine("</CATALOGO>");
            sw.Close();
            archivo.Close();
        }

        private void bttnXml_Click(object sender, EventArgs e)
        {
            GenerarXml(txtTitulo.Text, txtGenero.Text, txtDescripcion.Text, txtPlataforma.Text, txtPrecio.Text);

        }
    }
}
