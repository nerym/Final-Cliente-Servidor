using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

namespace Renta
{
    public class funciones : Ifunciones
    {
      public void guardar(int a, string b, string c, string d, string e, string f)
        {
            SqlConnection con;
            SqlCommand cmd;
            string cadena = "";
            con = new SqlConnection("Data Source=DESKTOP-CABRK5M; Initial Catalog=Rentas;Integrated Security=false;user=nery;password=12345;");
            con.Open();
            cadena = "insert into vestidoss values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "', '" + f + "')";
            cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public bool modificar(int a, string b, string c, string d, string e, string f)
        {
            SqlConnection con;
            SqlCommand cmd;
            string cadena = "";
            con = new SqlConnection("Data Source=DESKTOP-CABRK5M; Initial Catalog=Rentas;Integrated Security=false;user=nery;password=12345;");
            con.Open();
            cadena = "UPDATE vestidoss SET IDrenta= ('" + a + "'), Responsable = ('" + b + "'), Fecha_prestamo = ('" + c + "'), Fecha_entrega = ('" + d + "'), Descripcion = ('" + e + "'), Monto = ('" + f + "')where IDrenta = ('" + a + "')";
            cmd = new SqlCommand(cadena, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            con.Close();

        }
        public bool eliminar(int a)
        {
            SqlConnection con;
            SqlCommand cmd;
            string cadena = "";
            con = new SqlConnection("Data Source=DESKTOP-CABRK5M; Initial Catalog=Rentas;Integrated Security=false;user=nery;password=12345;");
            con.Open();
            cadena = "delete from vestidoss where IDrenta=" + a;
            cmd = new SqlCommand(cadena, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;

            }
            else
            {
                return false;
            }

            con.Close();
        }
        public string[] buscar(int cla)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dato;
            string cadena = "";
            string[] datos = new string[6];
            con = new SqlConnection("Data Source=DESKTOP-CABRK5M; Initial Catalog=Rentas;Integrated Security=false;user=nery;password=12345;");
            con.Open();
            cadena = "select * from vestidoss where IDrenta=" + cla ;
            cmd = new SqlCommand(cadena, con);
            dato = cmd.ExecuteReader();
            if (dato.Read())
            {
                datos[0] = dato.GetInt64(0).ToString();
                datos[1] = dato.GetString(1);
                datos[2] = dato.GetString(2);
                datos[3] = dato.GetString(3);
                datos[4] = dato.GetString(4);
                datos[5] = dato.GetString(5);
            }
            con.Close();
            return datos;
        }
    }
}
