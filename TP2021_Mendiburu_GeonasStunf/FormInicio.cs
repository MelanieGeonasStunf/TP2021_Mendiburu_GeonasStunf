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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(txtPedirCantTableros.Text);
            if (cant <= 0)
            {
                DialogResult mensaje = MessageBox.Show("Ingrese una cantidad mayor a 0", "CANTIDAD INACEPTABLE");
            }
            else
            {
                cJuego partida = new cJuego();//tuvimos en cuenta los bordes del tablero haciendo los randoms de 0 a 8
                partida.InicializarTableroAlfil();
                partida.arrayPiezas = CrearPiezas();
                partida.cant_tableros_a_generar = cant;
                partida.GenerarTableros();
                FormTableros formTab = new FormTableros(partida);
                formTab.Show();
                this.Hide();
            }
        }
        private void txtPedirCantTableros_TextChanged(object sender, EventArgs e)
        {            

        }
        static Pieza[] CrearPiezas()
        {
            Pieza[] piezas = new Pieza[8];
            for (int i = 0; i < 8; i++)
            {
                piezas[i] = new Pieza((e_Pieza)i + 2);
            }
            return piezas;
        }
    }
}
