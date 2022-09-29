using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPrueba
{
    public enum operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        division = 3,
        multiplicacion = 4,
        Modulo = 5,
    }

    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        operacion operador = operacion.NoDefinida;
        public Form1()
        {
            InitializeComponent();
        }

        private void LeerNumero(string numero)
        {

            if (cajaResultado.Text == "0" && cajaResultado.Text != null)
            {
                cajaResultado.Text = numero;
            }
            else
            {
                cajaResultado.Text += numero;
            }
        }
        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)
            {
                case operacion.Suma:
                    resultado = valor1 + valor2;
                    break;
                case operacion.Resta:
                    resultado = valor1 - valor2;
                    break;
                case operacion.division:
                    if(valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir en 0");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case operacion.multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case operacion.Modulo:
                    resultado = valor1 % valor2;
                    break;
                    
            }
            return resultado;
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            LeerNumero("0");
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            LeerNumero("1");
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            LeerNumero("2");

        }

        private void boton3_Click(object sender, EventArgs e)
        {
            LeerNumero("3");

        }

        private void boton4_Click(object sender, EventArgs e)
        {
            LeerNumero("4");

        }

        private void boton5_Click(object sender, EventArgs e)
        {
            LeerNumero("5");

        }

        private void boton6_Click(object sender, EventArgs e)
        {
            LeerNumero("6");

        }

        private void boton7_Click(object sender, EventArgs e)
        {
            LeerNumero("7");

        }

        private void boton8_Click(object sender, EventArgs e)
        {
            LeerNumero("8");

        }

        private void boton9_Click(object sender, EventArgs e)
        {
            LeerNumero("9");

        }

        private void ObtenerValor (string operador)
        {
            valor1 = Convert.ToDouble(cajaResultado.Text);
            Historial.Text = cajaResultado.Text + operador;
            cajaResultado.Text = "0";
        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            operador = operacion.Suma;
            ObtenerValor("+");           
        }

        private void botonResultado_Click(object sender, EventArgs e)
        {
            if(valor2 == 0)
            {
                valor2 = Convert.ToDouble(cajaResultado.Text);
                Historial.Text = valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                cajaResultado.Text = Convert.ToString(resultado);
            }
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            operador = operacion.Resta;
            ObtenerValor("-");
        }

        private void botonMultiplicar_Click(object sender, EventArgs e)
        {
            operador = operacion.multiplicacion;
            ObtenerValor("x");
        }

        private void botonDivision_Click(object sender, EventArgs e)
        {
            operador = operacion.division;
            ObtenerValor("/");
        }

        private void botonPorcentaje_Click(object sender, EventArgs e)
        {
            operador = operacion.Modulo;
            ObtenerValor("%");
        }

        private void botonReset_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = "0";
            Historial.Text = "";
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            if (cajaResultado.Text.Length > 1)
            {
                string txtResultado = cajaResultado.Text;
                txtResultado = txtResultado.Substring(0,txtResultado.Length - 1);
                
                if(txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    cajaResultado.Text = "0";
                }
                else
                   cajaResultado.Text += txtResultado;                                 
            }
            else
                cajaResultado.Text = "0";
                    
        }

        private void botonComa_Click(object sender, EventArgs e)
        {
            if(cajaResultado.Text.Contains(".")) 
            {
                return;
            }
            
            cajaResultado.Text += ".";

        }
    }
}
