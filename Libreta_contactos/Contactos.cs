using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Libreta_contactos
{
     class Contactos
    {

        private int id;
        private string nombre;
        private string tipo;
        private string direccion;
        private string apellidos;
        private string celular;

        SqlConnection cn = new SqlConnection ("Data Source=DESKTOP-5BB01PJ\\MSSQLSERVER01;Initial Catalog=BD_contactos;Integrated Security=True");

        public Contactos(string nombre, string celular, string tipo, string apellidos, string direccion)
        {
            //this para referise al atributo de la clase private//
            //recibimos como parametros metado contructor y los agregar alos atributos this //

            this.nombre = nombre;
            this.tipo = tipo;
            this.direccion = direccion;
            this.apellidos = apellidos;
            this.celular = celular;
        }
        public int AgregarContactos()
        {
           cn.Open ();
            SqlCommand consulta = new SqlCommand("INSERT INTO tb_contactos VALUES(@nombre,@apellidos,@celular,@tipo,@direccion)", cn);
            
//corresponde alos atributos al crear nombre utiliza en metodo constructor donde recibe los paramtro y
//los parametrso se asignan alos atributos
//@ para vincular la consulta



            consulta.Parameters.AddWithValue("nombre", nombre);
            consulta.Parameters.AddWithValue("apellidos", apellidos);
            consulta.Parameters.AddWithValue("celular", celular);
            consulta.Parameters.AddWithValue("tipo", tipo);
            consulta.Parameters.AddWithValue("direccion", direccion);
        //variable para guardar la consulta realizada ala Base de datos
            int filasafectadas = consulta.ExecuteNonQuery ();
            cn.Close ();

            return filasafectadas;
        }

    }
}
