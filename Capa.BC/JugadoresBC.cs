using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.DAC;
using Capa.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Capa.BC
{
    public class JugadoresBC
    {
        public DataTable GetAll()
        {

            JugadoresDAC oClaseDAC = new JugadoresDAC();
            return oClaseDAC.GetAll();
        }
        public void Insert(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)

            {

                Jugadores oJugadores = new Jugadores();

                oJugadores.IdJugador = (int)dr[0];
                oJugadores.Nro = (int)dr[1];
                oJugadores.Nombre = dr[2].ToString();
                oJugadores.Goles = (int)dr[3];
                oJugadores.Estado = (int)dr[4];


                JugadoresDAC ooClaseDAC = new JugadoresDAC();

                oJugadores.IdJugador = oJugadores.IdJugador;
                ooClaseDAC.update(oJugadores);

                JugadoresDAC oClaseDAC = new JugadoresDAC();
                oClaseDAC.insert(oJugadores);




            }
        }
    }


}
