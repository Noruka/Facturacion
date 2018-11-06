using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class sistemaFacturacion : System.Windows.Forms.Form
    {

        /*Aqui inserto las variables. Las pongo afuera para poder usarla entre las funciones.
         
             He creado varias funciones para ir llamandolas desde la acción del botón de calcular.
             Las funciones calculan cada una de las cosas.
             
             Hospedaje() calcula el precio de ocupación.
             La función devolvera el tiempo del hospedaje seleccionado multiplicado la tarifa seleccionada.

             Extras() Calcula los extras y suma 1 a un contador. Ese contador luego se multiplicara por 20 y devolvera ese valor.
             Cada vez que se llame a la función Extra() el contador se resetea a 0.

            Total() simplemente suma los valores devueltos por Hospedaje() y Extras().

            IVA() calcula el IVA (21%) de Total().

            Al darle a calcular se llamara a las varias funciones y mostrara por los cuadros de texto los valores
            que se hayan calculado.
             
             */

        int tiempoHospedaje, precioHospedaje;

        public sistemaFacturacion()
        {
            InitializeComponent();
        }

        int Hospedaje() {

            tiempoHospedaje = (int)(nudHospedaje.Value);

            if (rbNegocio.Checked)
            {
                precioHospedaje = 70;
            }
            if (rbTurista.Checked)
            {
                precioHospedaje = 50;
            }

            return  tiempoHospedaje*precioHospedaje; 

        }

        int Extras() {

            int contador=0;

            if (cbTV.Checked)
            {
                contador++;
            }
            if (cbTelFax.Checked)
            {
                contador++;
            }
            if (cbBar.Checked)
            {
                contador++;
            }

            return contador * 20;

        }

        int Total()
        {


            return Hospedaje() + Extras();

        }

        int IVA()
        {

            return Total() * 21 / 100;


        }

        /*Aqui se llama a las varias funciones para recibir los datos calculados y mostrarlos por pantalla.
         Si faltan datos cruciales como el nombre, los dias o la tarifa el programa saltara un mensaje de error.*/

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (nudHospedaje.Value == 0 || (rbNegocio.Checked == false && rbTurista.Checked == false) || txtNombre.Text == "")
            {
                MessageBox.Show("Error, faltan datos");
            }
            else
            {
                txtTotalHospedaje.Text = Hospedaje() + "€";
                txtTotalExtras.Text = Extras() + "€";

                txtTotal.Text = Total() + "€";
                txtIVA.Text = IVA() + "€";

                txtTotalPagar.Text = Total() + IVA() + "€";

            }

        }

        /*Este botón simplemente acaba el programa.*/

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*El boton de acercaDe abre el tercer formulario sin cerrar el segundo.
         Este botón abre una ventana sobre cosas del programa y del Autor.*/

        private void btnAcerdaDe_Click(object sender, EventArgs e)
        {
            AboutMe.Form3 miventana = new AboutMe.Form3();
            miventana.Show();
        }

        private void sistemaFacturacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /*El boton Nuevo resetea los valores del formulario para poder volver a insertar datos.*/

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            nudHospedaje.Value = 0;
            rbNegocio.Checked = false;
            rbTurista.Checked = false;
            cbTV.Checked = false;
            cbTelFax.Checked = false;
            cbBar.Checked = false;
            txtIVA.Text = "";
            txtTotal.Text = "";
            txtTotalExtras.Text = "";
            txtTotalHospedaje.Text = "";
            txtTotalPagar.Text = "";
        }
    }
}
