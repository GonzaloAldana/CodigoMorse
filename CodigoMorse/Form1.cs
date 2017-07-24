using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace CodigoMorse
{
    public partial class Form1 : Form
    {
        private SerialPort miPuerto;
        int datosAnterior = -1;
        int datos;
        string aux = "";
        ControladorMorse cm = new ControladorMorse();

        public Form1()
        {
            InitializeComponent();
        }

        public void MiPuerto_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Al presionar el boton del arduino comenzará una cuenta incrementable, cada ciclo se le suma 1
            // Mientras el boton no esté presionado enviará puros ceros
            try
            {
                aux = miPuerto.ReadLine();
                string aux2 = "";

                // El arduino envia un arreglo de caracteres o STRING con el formato "numero\r"
                // y la computadora marca error al convertir un string a entero por los últimos 2 caracteres "\r"
                // Éste código elimina el error quitando esos caracteres
                for (int i = 0; i < aux.Length; i++)
                {
                    if (aux[i] == '0' || aux[i] == '1' || aux[i] == '2' || aux[i] == '3' || aux[i] == '4' || aux[i] == '5' || aux[i] == '6' || aux[i] == '7' || aux[i] == '8' || aux[i] == '9')
                        aux2 += aux[i];

                }
                datos = int.Parse(aux2);

                // El programa lleva un registro del numero que envia el arduino y el numero anterio que envió
                // Si el arduino envia un cero pero antes ya había enviado otro número significa que el botón 
                // estuvo presionado por N ciclos y luego lo soltaron, de ser así comprueba el número de ciclos 
                // y decide si fue un punto o una linea en codigo morse
                if (datos == 0 && datosAnterior > 0)
                {
                    if (datosAnterior <= 80) // Es un punto, el número lo saqué por prueba y error
                        aux = "O";
                    else if (datosAnterior <= 200)// Es una linea, el número lo saqué por prueba y error
                        aux = "-";
                    cm.AgregarCaracter(aux); // Guarda en la memoria el dato que recibió del arduino
                }
                datosAnterior = datos;
            }catch(Exception aaaa)            {            }
        }
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            // Aquí se configura el puerto Serial con el Arduino
            miPuerto = new SerialPort();
            miPuerto.BaudRate = 9600;

            miPuerto.PortName = txtPuerto.Text;
            miPuerto.Parity = Parity.None;
            miPuerto.DataBits = 8;
            miPuerto.StopBits = StopBits.One;
            miPuerto.DataReceived += MiPuerto_DataReceived;
            try
            {
                miPuerto.Open();
            }
            catch (Exception ex)
            {
                // Muestra un error si no ne puede abrir la conexión
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            // Toma los datos de la caja de texto y lo traduce
            cm.NuevoCaracter();
            cm.AgregarCaracter(txtPrueba.Text);
            cm.DescifrarCaracter();
            label3.Text = cm.ObterLetra();
        }

        private void btnLectura_Click(object sender, EventArgs e)
        {
            // Escribe en la caja de texto el codigo morse del arduino
            txtPrueba.Text = cm.ObterCaracter();
            // label4.Text = datos.ToString();
        }

        private void btnBorrarCaracter_Click(object sender, EventArgs e)
        {
            // Borra el caracter del arduino de la pantalla y la memoria
            txtPrueba.Text = "";
            label3.Text = "";
            cm.NuevoCaracter();
            cm.NuevaLetra();
        }

        private void btnAgregarCaracterALaPalabra_Click(object sender, EventArgs e)
        {
            // Le agrega el caracter a la palabra, que son todos los caracteres
            cm.AgregarLetra();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Muestra la palabra, que son todos los caracteres
            lblPalabra.Text = cm.ObterLetras();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Borra la palabra de la pantalla y la memoria
            lblPalabra.Text = "";
            cm.NuevaPalabra();            
        }
    }
}
