using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppFactoryRedone.Classes;
using System.Data.SqlClient;
using System.Data;

namespace AppFactoryRedone.Classes
{
    public class AccessDB
    {
        string connectionString;

        public CommandType QueryType { get; set; }
        public string  QueryString { get; set; }

         

        public AccessDB()
        {
            connectionString = "Data Source=(localdb)\\Projects;Initial Catalog=AppFactoryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
   
        }


        public int InsertIntoDB(InternData intern)
        {


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = QueryType;
                    cmd.CommandText = QueryString;
                    cmd.Connection = conn;


                    cmd.Parameters.AddWithValue("@FirstName", intern.FirstName);
                    cmd.Parameters.AddWithValue("@Surname", intern.LastName);
                    cmd.Parameters.AddWithValue("@Role", intern.Role);
                    cmd.Parameters.AddWithValue("@cellNumber", intern.ContactNumber);
                    cmd.Parameters.AddWithValue("@isPrimary", intern.IsPrimary);
                    cmd.Parameters.AddWithValue("@email", intern.Email);
                    cmd.Parameters.AddWithValue("@isBusiness", intern.IsBusiness);
                    cmd.Parameters.AddWithValue("@DateOfBirth", intern.DateOfBirth);
                    conn.Open();
                    int rowAffected = (int)cmd.ExecuteNonQuery();

                    if (rowAffected > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }

                }
            }


        }

        public List<InternData> ReadDataToTable()
        {

           var internList = new List<InternData>();
           var intern = new InternData();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using(SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = QueryType;
                        cmd.CommandText  = QueryString;
                        cmd.Connection = conn;

                        conn.Open();
                        using(SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while(reader.Read())
                            {
                                intern = new InternData(); // so that it doesnt overide the data of the previous obj intaciated
                                
                                intern.FullName = reader.GetString(reader.GetOrdinal("FullName"));
                                intern.DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")).ToShortDateString();
                                intern.Role = reader.GetInt32(reader.GetOrdinal("Role"));
                                intern.Email = reader.GetString(reader.GetOrdinal("EmailAddress"));
                                intern.IsBusiness = reader.GetBoolean(reader.GetOrdinal("IsBusiness"));
                                intern.ContactNumber = reader.GetString(reader.GetOrdinal("CellPhoneNo"));
                                intern.IsPrimary = reader.GetBoolean(reader.GetOrdinal("IsPrimary"));
                                intern.personID = reader.GetInt32(reader.GetOrdinal("PersonId"));
                               
                                internList.Add(intern);
                            }

                            
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                
               
                throw;
            }
            return internList;
            
        }

        public InternData ReadDataToUpdate(int id)
        {

           // var internList = new List<InternData>();
            var intern = new InternData();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = QueryType;
                        cmd.CommandText = QueryString;
                        cmd.Connection = conn;
                        cmd.Parameters.AddWithValue("@personID", id);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (reader.Read())
                            {
                                
                                intern.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                                intern.LastName = reader.GetString(reader.GetOrdinal("Surname"));

                                intern.DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")).ToShortDateString();
                                intern.Role = reader.GetInt32(reader.GetOrdinal("Role"));
                                intern.Email = reader.GetString(reader.GetOrdinal("EmailAddress"));
                                intern.IsBusiness = reader.GetBoolean(reader.GetOrdinal("IsBusiness"));
                                intern.ContactNumber = reader.GetString(reader.GetOrdinal("CellPhoneNo"));
                                intern.IsPrimary = reader.GetBoolean(reader.GetOrdinal("IsPrimary"));
                                intern.personID = reader.GetInt32(reader.GetOrdinal("PersonId"));

                               
                            }


                        }
                    }
                }
            }
            catch (SqlException ex)
            {


                throw;
            }
            return intern;

        }

        public int Update(InternData intern)
        {


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = QueryType;
                    cmd.CommandText = QueryString;
                    cmd.Connection = conn;

 
                    cmd.Parameters.AddWithValue("@Name", intern.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", intern.LastName);
                    cmd.Parameters.AddWithValue("@personRole", intern.Role);
                    cmd.Parameters.AddWithValue("@Number", intern.ContactNumber);
                    cmd.Parameters.AddWithValue("@prmaryNumber", intern.IsPrimary);
                    cmd.Parameters.AddWithValue("@email_add", intern.Email);
                    cmd.Parameters.AddWithValue("@businessEmail", intern.IsBusiness);
                    cmd.Parameters.AddWithValue("@DOB", intern.DateOfBirth);
                    cmd.Parameters.AddWithValue("@personID", intern.personID);
                    conn.Open();
                    int rowAffected = (int)cmd.ExecuteNonQuery();

                    if (rowAffected > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }

                }
            }


        }

        }
}