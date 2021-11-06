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
        FormInicio form1 = new FormInicio();
        public FormTableros(cJuego juego, FormInicio f1)
        {
            form1 = f1;
            partida = juego;
            InitializeComponent();
            ImprimirTableros();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbttnAmenazasfatales.Checked)
            {
                ImprimirFatales();
            }
            else
            {
                //FatalesBorrado();
            }
        }
        //public void FatalesBorrado()
        //{
        //    Fatales = new Panel[gridSize, gridSize]; ;
        //    //ImprimirTableros();
        //    for (int i = 0; i < gridSize; i++)
        //    {
        //        for (int j = 0; j < gridSize; j++)
        //        {
        //            Panel newPanel2 = new Panel
        //            {
        //                Size = new Size(tileSize, tileSize),
        //                Location = new Point((tileSize * i) + 542, (tileSize * j) + 69)
        //            };
        //            Controls.Add(newPanel2);
        //            Fatales[i, j] = newPanel2;
        //            if (i % 2 == 0)
        //                newPanel2.BackColor = j % 2 != 0 ? clr1 : clr2;
        //            else
        //                newPanel2.BackColor = j % 2 != 0 ? clr2 : clr1;

        //            if (partida.matrizFatales[tab].tablero[i, j] != 0)
        //            {
        //                newPanel2.BackColor = Color.Maroon;

        //            }

        //        }
        //    }
        //}
        public void ImprimirTableros()
        {
            //nt l = 0;
            //Tableros();

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

                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImage = Image.FromFile("caballo.png");
                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImageLayout = ImageLayout.Stretch;
                            //Controls.Add(_chessBoardPanels[aux.fila, aux.columna]);

                            break;
                        }

                    case e_Pieza.TORRE1:
                    case e_Pieza.TORRE2:
                        {
                            cPosicion aux = new cPosicion();
                            aux.fila = partida.Tableros[tab, i].pos.fila;
                            aux.columna = partida.Tableros[tab, i].pos.columna;

                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImage = Image.FromFile("torre2.png");
                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImageLayout = ImageLayout.Stretch;
                            //Controls.Add(_chessBoardPanels[aux.fila, aux.columna]);

                            break;
                        }

                    case e_Pieza.ALFIL1:
                    case e_Pieza.ALFIL2:
                        {
                            cPosicion aux = new cPosicion();
                            aux.fila = partida.Tableros[tab, i].pos.fila;
                            aux.columna = partida.Tableros[tab, i].pos.columna;
                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImage = Image.FromFile("alfil2.png");
                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImageLayout = ImageLayout.Stretch;
                            Controls.Add(_chessBoardPanels[aux.fila, aux.columna]);
                            break;
                        }
                    case e_Pieza.REINA:
                        {
                            cPosicion aux = new cPosicion();
                            aux.fila = partida.Tableros[tab, i].pos.fila;
                            aux.columna = partida.Tableros[tab, i].pos.columna;
                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImage = Image.FromFile("reina.png");
                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImageLayout = ImageLayout.Stretch;
                            Controls.Add(_chessBoardPanels[aux.fila, aux.columna]);

                            break;

                        }
                    case e_Pieza.REY:
                        {
                            cPosicion aux = new cPosicion();
                            aux.fila = partida.Tableros[tab, i].pos.fila;
                            aux.columna = partida.Tableros[tab, i].pos.columna;
                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImage = Image.FromFile("rey.png");
                            _chessBoardPanels[aux.fila, aux.columna].BackgroundImageLayout = ImageLayout.Stretch;
                            Controls.Add(_chessBoardPanels[aux.fila, aux.columna]);

                            break;

                        }
                    default:
                        break;
                }

            }


        }
        public void ImprimirFatales()
        {
           Fatales= new Panel[gridSize, gridSize]; ;
            //ImprimirTableros();
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    Panel newPanel2 = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point((tileSize * i) + 542, (tileSize * j) + 69)
                    };
                    Controls.Add(newPanel2);
                    Fatales[i, j] = newPanel2;
                    if (i % 2 == 0)
                        newPanel2.BackColor = j % 2 != 0 ? clr1 : clr2;
                    else
                        newPanel2.BackColor = j % 2 != 0 ? clr2 : clr1;
                   
                    if (partida.matrizFatales[tab].tablero[i, j] != 0)
                    {
                        newPanel2.BackgroundImage = Image.FromFile("star.png");
                        newPanel2.BackgroundImageLayout = ImageLayout.Stretch;

                    }

                }
            }
        }


        private void BttnSiguiente_Click(object sender, EventArgs e)
        {
            if (tab < partida.cant_tableros_a_generar)
            {
                //ImprimirTableros();
                tab++;

                this.Show();
            }
            else
            {
                form1.Show();
                this.Close();//
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (0 < tab && tab < partida.cant_tableros_a_generar)
            {
                tab--;
                ImprimirTableros();
            }
            else
            {
                form1.Show();
                this.Close();
            }
        }
    }
}
