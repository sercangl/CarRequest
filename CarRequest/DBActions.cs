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
        // kolaylık olması bakımından tanımlanmış global değişkenler
       
        static string connectionString = "Server=EPDI-4W68LX1\\SQLEXPRESS;Initial Catalog=CarRequest;Integrated Security=SSPI;";
        
        internal static void AddRent(int v1, DateTime dateTime1, DateTime dateTime2)
        {
            throw new NotImplementedException();
        }



        //Kişileri veri tabanına ekleyen fonksiyon
        public static void AddPerson(string name, string lastname, int persID, bool isadmin)
        {


            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                //INSERT INTO tblPerson (Name,Lastname,PersID,IsAdmin) VALUES (@name,@lastname,@persid,@isadmin)
                // Connect to DB
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("addPerson", con);
                cmd.CommandType = CommandType.StoredProcedure;
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
      
        
        //Kaza raporlarını veri tabanına giren fonksiyon 
        public static void AddAccident(string Description,bool RepairRequired,DateTime RepairTime)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                //INSERT INTO tblIncident (Description,RepairRequired,RepairTime) VALUES (@description,@repairrequired,@repairTime)
                cmd = new SqlCommand("acientAdd",con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@description", Description);
                cmd.Parameters.AddWithValue("@repairrequired",RepairRequired );
                cmd.Parameters.AddWithValue("@repairTime", RepairTime);





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

        internal static DataTable talepEtArama(int personID)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataAdapter adp = null;
            DataTable ret = null;
            try
            {
                //SELECT  * FROM  tblRent WHERE fkPerson=@personID and KM IS NULL and fkCar IS NULL
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("talepEtArama", con);
                cmd.Parameters.AddWithValue("@personID", personID);
                ret = new DataTable("GenericTable");
                adp = new SqlDataAdapter(cmd);
               
                adp.Fill(ret);
            }
            catch (Exception ex)
            {
                //TODO
                //Log hazırla
            }
            return ret;

        }


        //Eklenecek arabanın bilgilerini veritabanına giren fonksiyon
        public static void AddCar(int fkPerson,string marka,string model,DateTime rentStart,DateTime rentEnd,string plaka,int lastKm,bool available )
        {

            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                //INSERT INTO tblCar(fkPerson,Marka,Model,RentStart,RentEnd,Plaka,LastKM,IsAvailable)  VALUES (@fkPerson,@marka,@model,@rentStart,@rentEnd,@plaka,@lastkm,@available)
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("addCar", con);
                cmd.CommandType = CommandType.StoredProcedure;
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
        

      // Talep edilen aracın bilgilerini veritabanına giren fonksiyon
        public static void AddRentt(int fkPerson,DateTime StartDate,DateTime EndDate)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;


            try
            {
                //INSERT INTO tblRent (fkPerson,StartDate,EndDate) VALUES (@fkPerson,@StartDate,@EndDate)
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand("addRent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fkPerson", fkPerson);
                cmd.Parameters.AddWithValue("@StartDate", StartDate);
                cmd.Parameters.AddWithValue("@EndDate", EndDate);
              
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





    }
}
