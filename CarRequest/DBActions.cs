using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRequest
{
    static class DBActions
    {
        static string connectionString = "Server=EPDI-4W68LX1\\SQLEXPRESS;Initial Catalog=CarRequest;Integrated Security=SSPI;";
        
        public static void AddPerson(string name, string lastname, int persID, bool isadmin)
        {


            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                // Connect to DB
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("INSERT INTO tblPerson (Name,Lastname,PersID,IsAdmin) VALUES (@name,@lastname,@persid,@isadmin)", con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@persid", persID);
                cmd.Parameters.AddWithValue("@isadmin", isadmin);
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                try
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Dispose();
                    }
                }
                catch (Exception)
                {


                }

            }




        }

        internal static void AddRent(int v1, DateTime dateTime1, DateTime dateTime2, int v2, int v3, int v4, int v5)
        {
            throw new NotImplementedException();
        }

        public static void AddAccident(string Description,bool RepairRequired,DateTime RepairTime)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("INSERT INTO tblIncident (Description,RepairRequired,RepairTime) VALUES (@description,@repairrequired,@repairtime) ",con);

                cmd.Parameters.AddWithValue("@description", Description);
                cmd.Parameters.AddWithValue("@repairrequired",RepairRequired );
                cmd.Parameters.AddWithValue("@repairtime", RepairTime);
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                try
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Dispose();
                    }
                }
                catch (Exception)
                {


                }

            }


        }

        public static void AddCar(int fkPerson,string marka,string model,DateTime rentStart,DateTime rentEnd,string plaka,int lastKm,bool available )
        {

            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("INSERT INTO tblCar(fkPerson,Marka,Model,RentStart,RentEnd,Plaka,LastKM,IsAvailable)  VALUES (@fkPerson,@marka,@model,@rentStart,@rentEnd,@plaka,@lastkm,@available)", con);
                cmd.Parameters.AddWithValue("@fkPerson", fkPerson);
                cmd.Parameters.AddWithValue("@marka", marka);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@rentStart", rentStart);
                cmd.Parameters.AddWithValue("@rentEnd", rentEnd);
                cmd.Parameters.AddWithValue("@plaka", plaka);
                cmd.Parameters.AddWithValue("@lastkm", lastKm);


                cmd.Parameters.AddWithValue("@available", available);

                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();

                    cmd.ExecuteNonQuery();
                }

            }

            catch(Exception)
            {
                throw;


            }

            finally
            {
                try
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Dispose();
                    }
                }
                catch (Exception)
                {


                }

            }


        }

        public static void AddRent(int fkPerson,DateTime StartDate,DateTime EndDate,int KM,int fkCar)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;


            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("INSERT INTO tblRent (fkPerson,StartDate,EndDate,KM,fkCar) VALUES (@fkPerson,@StartDate,@EndDate,@KM,@fkCar)", con);
                cmd.Parameters.AddWithValue("@fkPerson", fkPerson);
                cmd.Parameters.AddWithValue("@StartDate", StartDate);
                cmd.Parameters.AddWithValue("@EndDate", EndDate);
                cmd.Parameters.AddWithValue("@KM", KM);
                cmd.Parameters.AddWithValue("@fkCar", fkCar);

                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();

                cmd.ExecuteNonQuery();
                
            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                try
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Dispose();
                    }
                }
                catch (Exception)
                {


                }

            }


        }

        public static void AddBack()
        {

        }

       


    }
}
