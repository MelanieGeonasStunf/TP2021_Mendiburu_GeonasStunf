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
    public partial class FormPropiedadesPoda : Form
    {
        FormInicio form1;       
        public FormPropiedadesPoda(FormInicio form1_)
        {
            form1 = form1_;
            
            InitializeComponent();
        }

        private void FormPropiedades_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnComplejidad_Click(object sender, EventArgs e)
        {
            FormComplejidad formCom = new FormComplejidad(form1, this);
            formCom.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {       
            form1.Show();
            this.Close();
        }
    }
}
