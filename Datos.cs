using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Datos
    {
        public SqlConnection con;


        public SqlConnection Conectar()
        {
            con = new SqlConnection("server=.; database=Registro; Trusted_Connection=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public SqlCommand Cmd(string cmdText)
        {
            SqlCommand cmd = new SqlCommand(cmdText, Conectar());
            return cmd;
        }

        public SqlDataAdapter sqlData(string cmdText)
        {
            SqlDataAdapter data = new SqlDataAdapter(cmdText, Conectar());
            return data;
        }

        public DataTable Trimestres()
        {
            object[] valores = new object[2];
            valores[0] = 0;
            valores[1] = "Trimestre";
            string cmdText = "Select * from Trimestre";
            DataTable tabla = new DataTable();
            sqlData(cmdText).Fill(tabla);
            DataRow fila = tabla.NewRow();
            fila.ItemArray = valores;
            tabla.Rows.InsertAt(fila, 0);
            return tabla;
        }
        public void insertTrimestre(string trimestre, string periodo)
        {
            SqlCommand cmd = Cmd("insertTrimestre");
            cmd.Parameters.AddWithValue("@trimestre", trimestre);
            cmd.Parameters.AddWithValue("@periodo", periodo);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable Asignaturas()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = Cmd("getAsignaturas");
            cmd.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            return tabla;

        }
        public DataTable Aprobadas()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = Cmd("getAprobadas");
            cmd.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            return tabla;

        }
        public DataTable Reprobadas()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = Cmd("getReprobada");
            cmd.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            return tabla;

        }
        public void insertAsignatura(string asignatura, string facilitador, 
            int calificacion, char literal, int trimestre)
        {
            SqlCommand cmd = Cmd("[insertAsignatura]");
            cmd.Parameters.AddWithValue("@asignatura", asignatura);
            cmd.Parameters.AddWithValue("@facilitador", facilitador);
            cmd.Parameters.AddWithValue("@calificacion", calificacion);
            cmd.Parameters.AddWithValue("@literal", literal);
            cmd.Parameters.AddWithValue("@idtrimestre", trimestre);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
