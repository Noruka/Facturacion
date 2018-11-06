using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioFinal___Sistema_de_facturacion
{
    public partial class Form1 : Form
    {
        /*Aqui creo las variables, las hago afuera por si fuera necesario utilizarlas en mas botones*/
        /*Creo una variable Bool para indicarle al programa de que el usuario a acertado o fallado, y 
        lo junto con una variable contador para saber si despues de 3 intentos a introducido los 
        datos correctamente o no.*/
        bool acierto = false;

        int contador = 0;
        int contadorResta = 2;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {



            /*lbDebug1.Text = "" + contador;*/ /*Pequeño debugger que tengo para seguir el contador de intentos*/

            /*
            Aqui es donde ejecuto el boton de loggeo. Los if comprueban si los datos introducidos son correctos.
            Si lo son, y no has agotado el numero de intentos, entonces te dejara pasar y resetea el contador.
            Si no es el caso y te has equivocado demasiadas veces cerrara el programa.
            No uso un bucle porque le tienes que dar la oportunidad al usuario de cambiar los datos.
            Si falla, el programa limpia los campos para que lo vuelva a intentar.

            El boton cancelar limpia los cuadros de texto sin utilizar intentos.

            Al final el programa comprueba si el usuario ha acertado los datos. Si es asi abrira el siguiente
            formulario. En caso contrario simplemente se cerrara.
            */

            contador++;

            if (txtUsuario.Text == "DAM" && txtContrasenya.Text == "PROGRESA")
            {
                MessageBox.Show("Acceso concedido!");
                contador = 0;
                txtUsuario.Text = "";
                txtContrasenya.Text = "";
                acierto = true;
                Close();
                
            }
            else
            {
                MessageBox.Show("Acceso Denegado! Intentos restantes: "+contadorResta);
                /*lbDebug1.Text = "" + contador;*/
                txtUsuario.Text = "";
                txtContrasenya.Text = "";
                contadorResta--;
            }
            if (contador == 3)
            {
                MessageBox.Show("Demsasiados Intentos! Cerrando...");
                Application.Exit();
            }

        }

        /*El boton cancelar resetea los cuadros de texto sin usar intentos.*/

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContrasenya.Text = "";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!acierto)
            {
                //acierto == false - acierto != false
                Application.Exit();

            }
        }
    }
}
