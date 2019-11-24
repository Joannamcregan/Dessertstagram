using DessertIsland.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DessertIsland.DAL
{
    public class ClickSQLDAO: IClickSQLDAO
    {
        private readonly string connectionString;

        public ClickSQLDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        

      
        public IList<DessertClick> GetAllClicks()
        {
            List<DessertClick> output = new List<DessertClick>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM allClicks", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        {
                            DessertClick dessertClick = new DessertClick();
                            
                            dessertClick.DessertId = Convert.ToInt32(reader["recipeId"]);
                            dessertClick.WhenClicked = Convert.ToDateTime(reader["whenClicked"]);
                            output.Add(dessertClick);
                        };
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return output;
        }

        public void AddClick(int dessertId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO allClicks (recipeId, whenClicked) VALUES (@dessertId, @whenClicked);", conn);
                    cmd.Parameters.AddWithValue("@dessertId", dessertId);
                    cmd.Parameters.AddWithValue("@whenClicked", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        //void CountClicksById(int dessertId)
        //{
            
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(connectionString))
        //        {
        //            conn.Open();

        //            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM allClicks WHERE allClicks.recipeId = @dessertId", conn);
                    


        //        }
        //    }
        //    catch (SqlException)
        //    {
        //        throw;
        //    }
        //}

    }
}
