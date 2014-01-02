using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace venta_de_boletos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_Nombre.Focus();
                e.Handled = true;
            }
        }

        private void textBox_Boletos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_Boletos.Focus();
                e.Handled = true;
            }
        }

        private void textBox_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_Precio.Focus();
                e.Handled = true;
            }
        }
        public void Comprar()
        {
            int boleto;
            double precio;
            double valor;
            string nombre;
            string jornada;

            if (textBox_Nombre.Text == "")
            {
                MessageBox.Show("Indruduzca un nombre de un cliente ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_Nombre.Focus();
            }
            else
            {

                
                if (textBox_Boletos.Text=="")
                {
                    MessageBox.Show("Indruduzca una cantidad de boletos ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    textBox_Boletos.Focus();
                }
                else
                {
                    boleto = Convert.ToInt32(textBox_Boletos.Text);
                    if (boleto == 0)
                    {
                        MessageBox.Show("Numero de boletos erroneos ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                       
                    }
                    else
                    {
                        jornada = comboBox_Jornada.SelectedItem.ToString();
                        if (jornada == "Jornadas")
                        {
                            MessageBox.Show("Seleccione una jornada ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                          
                            if(textBox_Precio.Text=="")
                            {
                                MessageBox.Show("Intruduzca un precio ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                textBox_Precio.Focus();
                            }
                            else
                            {
                                valor = Convert.ToDouble(textBox_Precio.Text);
                                precio = boleto * valor;
                                nombre = textBox_Nombre.Text;

                                label_Nombre.Text = nombre;
                                label_Boletos.Text = ((int)boleto).ToString();
                                label_Precio.Text = ((double)precio).ToString();
                                label_Jornadas.Text = jornada;
                            }
                        }
                    }
                }
            }
        }

        private void button_Comprar_Click(object sender, EventArgs e)
        {
            Comprar();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Nombre.Text = "";
            textBox_Boletos.Text = "";
            textBox_Precio.Text = "";
            label_Nombre.Text = "0";
            label_Boletos.Text = "0";
            label_Precio.Text = "0";
            label_Jornadas.Text = "0";
            textBox_Nombre.Focus();
            comboBox_Jornada.SelectedItem = "Jornadas";
        }
    }
}

