using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AboutMe
{
    public partial class Form3 : Form
    {
        
        //Aqui simplemente el boton  Aceptar cierra el Form3. Es una ventana informativa.


        public Form3()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
