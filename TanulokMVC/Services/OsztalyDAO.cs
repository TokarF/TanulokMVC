using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TanulokMVC.Models;

namespace TanulokMVC.Services
{
    public class OsztalyDAO
    {
        string connectionString = @"Data Source=DESKTOP-OGSV7BN;Initial Catalog=TanulokMVC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<OsztalyModel> OsszesOsztaly()
        {
            List<OsztalyModel> osztalyok = new List<OsztalyModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStatement = "SELECT * FROM dbo.Osztalyok";

                SqlCommand command = new SqlCommand(sqlStatement, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        osztalyok.Add(new OsztalyModel((int)reader["OsztalyId"], (string)reader["OsztalyNev"], (string)reader["OsztalyFonok"], (string)reader["Tanterem"]));
                    }
                }
                catch (Exception)
                {

                    throw new Exception("Something went wrong");
                }

            }

            return osztalyok;
        }

   

        public OsztalyModel OsztalyIdAlapjan(int id)
        {
            OsztalyModel osztaly = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStatement = "SELECT * FROM dbo.Osztalyok WHERE OsztalyId = @osztalyId";

                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@osztalyId", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        osztaly = new OsztalyModel((int)reader["OsztalyId"], (string)reader["OsztalyNev"], (string)reader["OsztalyFonok"], (string)reader["Tanterem"]);
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Valami hiba történt!");
                }

            }

            return osztaly;
        }

        public void UjOsztaly(OsztalyModel ujOsztaly)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStatement = "INSERT INTO dbo.Osztalyok (OsztalyNev, OsztalyFonok, Tanterem) VALUES (@osztalyNev, @osztalyFonok, @tanterem)";

                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@osztalyNev", ujOsztaly.OsztalyNev);
                command.Parameters.AddWithValue("@osztalyFonok", ujOsztaly.OsztalyFonok);
                command.Parameters.AddWithValue("@tanterem", ujOsztaly.Tanterem);

                try
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                }
                catch (Exception)
                {

                    throw new Exception("Something went wrong");
                }

            }
        }


        public void OsztalyModositas(OsztalyModel modositandoOsztaly)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStatement = "UPDATE dbo.Osztalyok SET OsztalyNev = @osztalyNev, OsztalyFonok = @osztalyFonok, Tanterem = @tanterem WHERE OsztalyId = @osztalyId";

                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@osztalyNev", modositandoOsztaly.OsztalyNev);
                command.Parameters.AddWithValue("@osztalyFonok", modositandoOsztaly.OsztalyFonok);
                command.Parameters.AddWithValue("@tanterem", modositandoOsztaly.Tanterem);
                command.Parameters.AddWithValue("@osztalyId", modositandoOsztaly.OsztalyId);

                try
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

    }

}
