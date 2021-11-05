using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2021_Mendiburu_GeonasStunf
{
    public partial class FormTableros : Form
    {
        public FormTableros(cJuego juego)
        {
            partida = juego;
            InitializeComponent();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
       public void ImprimirTableros()
       {
           int l = 0;
            while (l < partida.cant_tableros_a_generar)
            {
              for (int i = 0; i < partida.pos_piezas.tablero.GetLength(0); i++)
              {
                  for (int j = 0; j < partida.pos_piezas.tablero.GetLength(0); j++)
                  {
                        switch()
                  }
              }
            }

       }
    }
}
