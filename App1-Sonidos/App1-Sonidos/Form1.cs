using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace App1_Sonidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList lista = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            datos.RowTemplate.Height = 150;
            Guerrero goku = new DragonBall("Goku", Image.FromFile("goku.jpg"));
            lista.Add(goku);
            Guerrero Ash=new Pokemon("Ash",Image.FromFile("ash.jpg"));
            lista.Add(Ash);
            Guerrero zeya = new Zodiaco("Zeya", Image.FromFile("zeya.jpg"));
            lista.Add(zeya);

            int i = 0;
            foreach (Guerrero item in lista)
            {
                
                datos.Rows.Add();
                datos[0, i].Value = item.FotoGuerrero;
                datos[1, i].Value = item.NombreGuerrero;
                datos[2, i].Value = "Reproducir"; 
                i++;                 
            }
        }

        private void datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Guerrero obj = (Guerrero)lista[e.RowIndex];
                obj.Reproduce();
            }
        }
    }
}
