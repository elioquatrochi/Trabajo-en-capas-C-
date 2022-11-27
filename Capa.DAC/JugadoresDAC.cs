using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa.Entities;

namespace Capa.DAC
{
    public class JugadoresDAC
    {
        string conexion = "Data Source=PUESTO212;Initial Catalog=Prg4Parcial220221111;Integrated Security=True";
        public DataTable GetAll()
        {
            string sqlsentecia = "SP_JugadoresGetAll";
            SqlConnection conn = new SqlConnection();


            conn.ConnectionString = conexion;

            SqlCommand comm = new SqlCommand(sqlsentecia, conn);
            comm.CommandType = CommandType.StoredProcedure;

            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            da.Fill(ds);

            conn.Close();

            return ds.Tables[0];
        }
        public int insert(Jugadores obe)
        {

            string sqlsentecia = "SP_JugadoresBkpAdd";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conexion;



            SqlCommand comm = new SqlCommand(sqlsentecia, conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@Nro", SqlDbType.Int).Value = obe.Nro;
            comm.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = obe.Nombre;
            comm.Parameters.Add("@Goles", SqlDbType.Int).Value = obe.Goles;
            comm.Parameters.Add("@Estado", SqlDbType.Int).Value = obe.Estado;

            conn.Open();



            comm.ExecuteNonQuery();


            conn.Close();


            return 1;
        }
        public int update(Jugadores obe)
        {

            string sqlsentecia = "updateEstado";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conexion;



            SqlCommand comm = new SqlCommand(sqlsentecia, conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.Add("@Id", SqlDbType.Int).Value = obe.IdJugador;
           

            conn.Open();



            comm.ExecuteNonQuery();


            conn.Close();


            return 1;
        }


    }


}
