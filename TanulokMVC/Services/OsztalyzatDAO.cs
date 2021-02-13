using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TanulokMVC.Models;

namespace TanulokMVC.Services
{
    public class OsztalyzatDAO
    {
        string connectionString = @"Data Source=DESKTOP-OGSV7BN;Initial Catalog=TanulokMVC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public List<OsztalyzatModel> TanuloOsztalyzatok(int id)
        {
            List<OsztalyzatModel> osztalyzatok = new List<OsztalyzatModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStatement = "SELECT * FROM dbo.Osztalyzatok WHERE TanuloID = @tanuloId";

                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@tanuloId", id);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        osztalyzatok.Add(new OsztalyzatModel((int)reader["OsztalyzatId"], (int)reader["TanuloID"], (Tantargyak)(int)reader["Tantargy"], (OsztalyzatTipus)(int)reader["OsztalyzatTipus"], (byte)reader["Osztalyzat"], (string)reader["Megnevezes"], (string)reader["Megjegyzes"], (bool)reader["Sulyozott"], (DateTime)reader["Datum"]));
                    }
                }
                catch (Exception)
                {

                    throw new Exception("Something went wrong");
                }

            }

            return osztalyzatok.OrderBy(osztalyzat => osztalyzat.Datum).ToList();
        }



        internal OsztalyzatModel OsztalyzatIdAlapjan(int id)
        {
            OsztalyzatModel osztalyzat = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStatement = "SELECT * FROM dbo.Osztalyzatok WHERE OsztalyzatID = @osztalyzatId";

                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@osztalyzatId", id);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        osztalyzat = new OsztalyzatModel((int)reader["OsztalyzatId"], (int)reader["TanuloID"], (Tantargyak)(int)reader["Tantargy"], (OsztalyzatTipus)(int)reader["OsztalyzatTipus"], (byte)reader["Osztalyzat"], (string)reader["Megnevezes"], (string)reader["Megjegyzes"], (bool)reader["Sulyozott"], (DateTime)reader["Datum"]);
                    }
                }
                catch (Exception)
                {

                    throw new Exception("Something went wrong");
                }

            }

            return osztalyzat;
        }



        public void OsztalyzatFelvitel(OsztalyzatModel ujOsztalyzat)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStatement = "INSERT INTO dbo.Osztalyzatok (TanuloID, Tantargy, OsztalyzatTipus, Osztalyzat, Megnevezes, Megjegyzes, Sulyozott, Datum) VALUES (@tanuloId, @tantargy, @osztalyzatTipus, @osztalyzat, @megnevezes, @megjegyzes, @sulyozott, @datum)";

                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@tanuloId", ujOsztalyzat.TanuloId);
                command.Parameters.AddWithValue("@tantargy", ujOsztalyzat.Tantargy);
                command.Parameters.AddWithValue("@osztalyzatTipus", ujOsztalyzat.OsztalyzatTipus);
                command.Parameters.AddWithValue("@osztalyzat", ujOsztalyzat.Osztalyzat);
                command.Parameters.AddWithValue("@megnevezes", ujOsztalyzat.Megnevezes);
                command.Parameters.AddWithValue("@megjegyzes", ujOsztalyzat.Megjegyzes);
                command.Parameters.AddWithValue("@sulyozott", ujOsztalyzat.Sulyozott);
                command.Parameters.AddWithValue("@datum", ujOsztalyzat.Datum);

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

        public void OsztalyzatModositas(OsztalyzatModel modositandoOsztalyzat)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStatement = "UPDATE dbo.Osztalyzatok SET TanuloID = @tanuloId, Tantargy = @tantargy, OsztalyzatTipus = @osztalyzatTipus, Osztalyzat = @osztalyzat, Megnevezes = @megnevezes, Megjegyzes = @megjegyzes, Sulyozott = @sulyozott, Datum = @datum WHERE OsztalyzatID = @osztalyzatId";

                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@tanuloId", modositandoOsztalyzat.TanuloId);
                command.Parameters.AddWithValue("@tantargy", modositandoOsztalyzat.Tantargy);
                command.Parameters.AddWithValue("@osztalyzatTipus", modositandoOsztalyzat.OsztalyzatTipus);
                command.Parameters.AddWithValue("@osztalyzat", modositandoOsztalyzat.Osztalyzat);
                command.Parameters.AddWithValue("@megnevezes", modositandoOsztalyzat.Megnevezes);
                command.Parameters.AddWithValue("@megjegyzes", modositandoOsztalyzat.Megjegyzes);
                command.Parameters.AddWithValue("@sulyozott", modositandoOsztalyzat.Sulyozott);
                command.Parameters.AddWithValue("@datum", modositandoOsztalyzat.Datum);
                command.Parameters.AddWithValue("@osztalyzatId", modositandoOsztalyzat.OsztalyzatId);


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

        public void OsztalyzatTorles(int osztalyzatId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlStatement = "DELETE FROM dbo.Osztalyzatok WHERE OsztalyzatID = @osztalyzatId";

                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@osztalyzatId", osztalyzatId);


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
