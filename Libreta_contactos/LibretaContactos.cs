using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreta_contactos
{
    public partial class LibretaContactos : Form
    {
        public LibretaContactos()
        {
            InitializeComponent();
        }

        private void LibretaContactos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string nombre= txtnombre.Text;
            string apellidos = txtapellidos.Text;
            string celular= txtcelular.Text;
            string tipo = cmbtipo.Text;
            string direccion = txtdireccion.Text;
            
            if (nombre == ""||apellidos==""||direccion==""||celular==""||
            tipo== "seleccionar tipo")
                    {
                MessageBox.Show("requiere llenar los campos ");
            } else
            {
              Contactos nuevoContactos = new Contactos(nombre, apellidos,celular, tipo, direccion);
                int fila = nuevoContactos.AgregarContactos();
                if (fila ==1) 
                {
                    MessageBox.Show("El registro se agrego correctamente",
                    "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnombre.Text = "";
                    txtapellidos.Text = "";
                    txtcelular.Text = "";
                    txtdireccion.Text = "";
                    cmbtipo.Text = "seleccionar tipo";
                       
                }
                else
                {

                    MessageBox.Show("ocurrio un proble al agregar",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
