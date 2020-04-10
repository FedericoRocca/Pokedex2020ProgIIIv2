using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pokedex2020ProgIIIv2
{
    class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            try
            {
                List<Pokemon> listado = new List<Pokemon>();

                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();
                SqlDataReader lector;

                conexion.ConnectionString = "Connectionstring";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Nombre, Numero, Imagen from pokemons";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while( lector.Read() )
                {
                    Pokemon aux = new Pokemon();
                    aux.nombre = (string)lector["Nombre"];
                    aux.numero = lector.GetInt32(1);
                    aux.urlImagen = (string)lector["Imagen"];
                    listado.Add( aux );
                }

                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
