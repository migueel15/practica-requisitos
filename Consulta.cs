using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisitos
{
    internal class Consulta
    {
        private ConexionMySQL conexionMySQL;
        
        public Consulta()
        {
            conexionMySQL = new ConexionMySQL();
        }

        public List<object[]> Select(string consulta)
        {
            // Vuestro codigo para hacer consulta
            MySqlCommand command = new MySqlCommand(consulta, conexionMySQL.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<object[]> lista = new List<object[]>();
            while (reader.Read())
            {
                object[] fila = new object[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    fila[i] = reader.GetValue(i);
                }
                lista.Add(fila);
            }
            return lista;
        }

        public void Update(string consulta)
        {
            // Vuestro codigo para hacer consulta
            MySqlCommand command = new MySqlCommand(consulta, conexionMySQL.GetConnection());
        }

        public void Delete(string consulta)
        {
            // Vuestro codigo para hacer consulta
            MySqlCommand command = new MySqlCommand(consulta, conexionMySQL.GetConnection());
        }

        public void Insert(string consulta)
        {
            // Vuestro codigo para hacer consulta
            MySqlCommand command = new MySqlCommand(consulta, conexionMySQL.GetConnection());
        }
    }
}
