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
            //ImprimirTableros();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
       public void ImprimirTableros()
       {
            //nt l = 0;
            Tableros();
            
            for (int i = 0; i < partida.arrayPiezas.Length; i++)
            {
                switch (partida.Tableros[tab, i].tipoPieza)
                {
                    case e_Pieza.CABALLO1:
                    case e_Pieza.CABALLO2:
                        {
                            cPosicion aux = new cPosicion();
                            aux.fila = partida.Tableros[tab, i].pos.fila;
                            aux.columna = partida.Tableros[tab, i].pos.columna;


                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImage = Image.FromFile("caballo.jpg");
                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImageLayout = ImageLayout.Stretch;
                            break;
                        }

                    case e_Pieza.TORRE1:
                    case e_Pieza.TORRE2:
                        {
                            cPosicion aux = new cPosicion();
                            aux.fila = partida.Tableros[tab, i].pos.fila;
                            aux.columna = partida.Tableros[tab, i].pos.columna;


                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImage = Image.FromFile("torre.png");
                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImageLayout = ImageLayout.Stretch;
                            break;

                        }

                    case e_Pieza.ALFIL1:
                    case e_Pieza.ALFIL2:
                        {
                            cPosicion aux = new cPosicion();
                            aux.fila = partida.Tableros[tab, i].pos.fila;
                            aux.columna = partida.Tableros[tab, i].pos.columna;
                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImage = Image.FromFile("alfil.png");
                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImageLayout = ImageLayout.Stretch;
                            break;

                        }
                    case e_Pieza.REINA:
                        {
                            cPosicion aux = new cPosicion();
                            aux.fila = partida.Tableros[tab, i].pos.fila;
                            aux.columna = partida.Tableros[tab, i].pos.columna;
                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImage = Image.FromFile("reina.jpg");
                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImageLayout = ImageLayout.Stretch;
                            break;

                        }
                    case e_Pieza.REY:
                        {
                            cPosicion aux = new cPosicion();
                            aux.fila = partida.Tableros[tab, i].pos.fila;
                            aux.columna = partida.Tableros[tab, i].pos.columna;
                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImage = Image.FromFile("rey.jpg");
                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImageLayout = ImageLayout.Stretch;
                            break;

                        }
                    default:
                        break;
                    }

                }

            tab++;

       }

        private void BttnSiguiente_Click(object sender, EventArgs e)
        {
            if (tab < partida.cant_tableros_a_generar)
            {
                ImprimirTableros();
                this.Show();
            }
            else
            {
                //this.Close();
                //FormInicio.Show();
            }
        }
    }
}
