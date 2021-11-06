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
    public partial class FormComplejidad : Form
    {
        FormInicio form1;
        FormPropiedadesPoda formPoda;
        public FormComplejidad(FormInicio form1_, FormPropiedadesPoda formPoda_)
        {
            form1 = form1_;
            formPoda = formPoda_;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }
    }
}
