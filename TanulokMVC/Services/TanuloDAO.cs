using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TanulokMVC.Models;

namespace TanulokMVC.Services
{
    public class TanuloDAO
    {
        string connectionString = @"Data Source=DESKTOP-OGSV7BN;Initial Catalog=TanulokMVC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public List<TanuloModel> OsztalyTanulok(int id)
        {
            List<TanuloModel> tanulok = new List<TanuloModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStatement = "SELECT * FROM dbo.Tanulok WHERE OsztalyId = @osztalyId";

                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@osztalyId", id);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        tanulok.Add(new TanuloModel((int)reader["TanuloID"], (int)reader["OsztalyId"], (string)reader["VezetekNev"], (string)reader["KeresztNev"]));
                    }
                }
                catch (Exception)
                {

                    throw new Exception("Something went wrong");
                }

            }

            return tanulok;
        }


        internal TanuloModel TanuloIdAlapjan(int id)
        {
            TanuloModel tanulo = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStatement = "SELECT * FROM dbo.Tanulok WHERE TanuloID = @tanuloId";

                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@tanuloId", id);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        tanulo = new TanuloModel((int)reader["TanuloID"], (int)reader["OsztalyId"], (string)reader["VezetekNev"], (string)reader["KeresztNev"]);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }

            return tanulo;
        }



        public void Ujtanulo(TanuloModel ujTanulo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStatement = "INSERT INTO dbo.Tanulok (OsztalyId, VezetekNev, KeresztNev) VALUES (@osztalyId, @vezetekNev, @keresztNev)";

                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@osztalyId", ujTanulo.OsztalyId);
                command.Parameters.AddWithValue("@vezetekNev", ujTanulo.VezetekNev);
                command.Parameters.AddWithValue("@keresztNev", ujTanulo.KeresztNev);

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

        public void TanuloModositas(TanuloModel modositandoTanulo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStatement = "UPDATE dbo.Tanulok SET OsztalyId = @osztalyId, VezetekNev = @vezetekNev, KeresztNev = @keresztNev WHERE TanuloID = @tanuloId";

                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@osztalyId", modositandoTanulo.OsztalyId);
                command.Parameters.AddWithValue("@vezetekNev", modositandoTanulo.VezetekNev);
                command.Parameters.AddWithValue("@keresztNev", modositandoTanulo.KeresztNev);
                command.Parameters.AddWithValue("@tanuloId", modositandoTanulo.TanuloId);

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

        public void TanuloTorles(int tanuloId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStatement = "DELETE FROM dbo.Tanulok WHERE TanuloID = @tanuloId; DELETE FROM dbo.Osztalyzatok WHERE TanuloID = @tanuloId";

                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@tanuloId", tanuloId);

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
