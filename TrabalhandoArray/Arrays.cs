using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhandoArray
{
    public partial class Arrays : Form
    {
        public Arrays()
        {
            InitializeComponent();
        }

        private void buttonAcao_Click(object sender, EventArgs e)
        {
            int[] numeros = { 0, 50, 100, 200, 250, 200, 450, 500 };

            for(int i = 0; i <= numeros.Length -1; i++){
                labelTela.Text = "Números[" + i + "] = " + numeros[i];
                listBoxResultado.Items.Add("Números[" + i + "] = " + numeros[i]);
            }
            foreach(int i in numeros)
            {
                listBoxResultado.Items.Add("Número: " + i);
            }

            //Array bidimensional
            int[,] frutas = new int[3, 5];
            labelTela.Text = "frutas: " + frutas.Length;

            //Array tridimensional
            int[,,] musica = new int[2, 3, 4];
            labelTela.Text += "\n Músicas dimensões: " + musica.Rank;
            labelTela.Text += "\n Músicas tamanho array: " + musica.Length;

        }
    }
}
