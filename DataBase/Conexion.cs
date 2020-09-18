using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ProyFinJBarboza
{
    public class Conexion {

        String connectionString = "Server=127.0.0.1;Port=3306;Database=clinica;Uid=root;password='    ';";

        public Medico getMedicoeById(int id_Medicos)
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT * FROM Medicos WHERE id_Medicos = ?id";
                cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = id_Medicos;
                Medico Medico = new Medico();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id_Medicos"].ToString());
                        string nombre = reader["nombre"].ToString();
                        string apellido = reader["apellido"].ToString();
                        int dni = int.Parse(reader["dni"].ToString());

                        Medico.setId(id);
                        Medico.setNombre(nombre, apellido);
                        Medico.setDni(dni);
                        // Console.WriteLine(reader["id_Medico"].ToString());
                        // Console.WriteLine(reader["nombre"].ToString());
                        // Console.WriteLine(reader["apellido"].ToString());
                        // Console.WriteLine(reader["dni"].ToString());
                    }
                }
                conexion.Dispose();
                return Medico;
            }

        }

         public List<Medico> getAllMedicos()
        {
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT * FROM Medicos";
                List<Medico> Medicos = new List<Medico>();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Medico Medico = new Medico();
                        int id = int.Parse(reader["id_Medico"].ToString());
                        string nombre = reader["nombre"].ToString();
                        string apellido = reader["apellido"].ToString();
                        int dni = int.Parse(reader["dni"].ToString());

                        Medico.setId(id);
                        Medico.setNombre(nombre, apellido);
                        Medico.setDni(dni);
                        

                        Medicos.Add(Medico);
                    }
                }
                conexion.Dispose();
                return Medicos;
            }

        }




    }
}