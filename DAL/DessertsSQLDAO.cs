using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using DessertIsland.Models;

namespace DessertIsland.DAL
{
    public class DessertsSQLDAO: IDessertsSQLDAO
    {
        private readonly string connectionString;

        public DessertsSQLDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Dessert> GetAllDesserts()
        {
            List<Dessert> output = new List<Dessert>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE allRecipes SET totalLikes = (SELECT COUNT(whenClicked) FROM allClicks WHERE allClicks.recipeId = allRecipes.id) SELECT * FROM allRecipes", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        {
                            Dessert dessert = new Dessert();

                            dessert.Id = Convert.ToInt32(reader["id"]);
                            dessert.Name = Convert.ToString(reader["recipeName"]);
                            dessert.Source = Convert.ToString(reader["recipeSource"]);
                            dessert.ImageSource = Convert.ToString(reader["imageSource"]);
                            dessert.Type = Convert.ToString(reader["recipeType"]);
                            dessert.IsVegan = Convert.ToBoolean(reader["isVegan"]);
                            dessert.IsLowFat = Convert.ToBoolean(reader["isLowFat"]);
                            dessert.IsSugarFree = Convert.ToBoolean(reader["isSugarFree"]);
                            dessert.IsFiveIngredientsOrLess = Convert.ToBoolean(reader["isFiveIngredientsOrLess"]);
                            dessert.DateAdded = Convert.ToDateTime(reader["whenAdded"]);
                            dessert.HashTag1 = (Convert.ToString(reader["hashTag1"]));
                            dessert.HashTag2 = (Convert.ToString(reader["hashTag2"]));
                            dessert.HashTag3 = (Convert.ToString(reader["hashTag3"]));
                            dessert.HashTag4 = (Convert.ToString(reader["hashTag4"]));
                            dessert.HashTag5 = (Convert.ToString(reader["hashTag5"]));
                            dessert.HashTag6 = (Convert.ToString(reader["hashTag6"]));
                            dessert.HashTag7 = (Convert.ToString(reader["hashTag7"]));
                            dessert.HashTag8 = (Convert.ToString(reader["hashTag8"]));
                            dessert.HashTag9 = (Convert.ToString(reader["hashTag9"]));
                            dessert.HashTag10 = (Convert.ToString(reader["hashTag10"]));
                            dessert.TotalLikes = (Convert.ToInt32(reader["totalLikes"]));
                            output.Add(dessert);
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

        //public Dessert GetDessertById(int id)
        //{
        //    Dessert dessert = new Dessert();
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(connectionString))
        //        {
        //            conn.Open();

        //            SqlCommand cmd = new SqlCommand(@"SELECT * FROM allRecipes where id = @id", conn);

                    
        //            SqlDataReader reader = cmd.ExecuteReader();

        //            while (reader.Read())
        //            {

        //                dessert.Id = Convert.ToInt32(reader["id"]);
        //                dessert.Name = Convert.ToString(reader["recipeName"]);
        //                dessert.Source = Convert.ToString(reader["recipeSource"]);
        //                dessert.ImageSource = Convert.ToString(reader["imageSource"]);
        //                dessert.Type = Convert.ToString(reader["recipeType"]);
        //                dessert.IsVegan = Convert.ToBoolean(reader["isVegan"]);
        //                dessert.IsLowFat = Convert.ToBoolean(reader["isLowFat"]);
        //                dessert.IsSugarFree = Convert.ToBoolean(reader["isSugarFree"]);
        //                dessert.IsFiveIngredientsOrLess = Convert.ToBoolean(reader["isFiveIngredientsOrLess"]);
        //                dessert.DateAdded = Convert.ToDateTime(reader["whenAdded"]);
        //                dessert.HashTag1 = (Convert.ToString(reader["hashTag1"]));
        //                dessert.HashTag2 = (Convert.ToString(reader["hashTag2"]));
        //                dessert.HashTag3 = (Convert.ToString(reader["hashTag3"]));
        //                dessert.HashTag4 = (Convert.ToString(reader["hashTag4"]));
        //                dessert.HashTag5 = (Convert.ToString(reader["hashTag5"]));
        //                dessert.HashTag6 = (Convert.ToString(reader["hashTag6"]));
        //                dessert.HashTag7 = (Convert.ToString(reader["hashTag7"]));
        //                dessert.HashTag8 = (Convert.ToString(reader["hashTag8"]));
        //                dessert.HashTag9 = (Convert.ToString(reader["hashTag9"]));
        //                dessert.HashTag10 = (Convert.ToString(reader["hashTag10"]));
        //                dessert.TotalLikes = (Convert.ToInt32(reader["totalLikes"]));
        //            }
        //        }
        //    }
        //    finally
        //    {
        //    }
        //    return dessert;
        //}

        public void AddDessert(Dessert newDessert)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO allRecipes (recipeName, recipeSource, imageSource, recipeType, isVegan, isLowFat, isSugarFree, isFiveIngredientsOrLess, whenAdded, hasthtag1, hashtag2, hashtag3, hashtag4, hashtag5, hashtag6, hashtag7, hashtag8, hashtag9, hashtag10, totalLikes) VALUES (@recipeName, @recipeSource, @imageSource, @recipeType, @isVegan, @isLowFat, @isSugarFree, @isFiveIngredientsOrLess, @whenAdded, @hashtag1, @hashtag2, @hashtag3, @hashtag4, @hashtag5, @hashtag6, @hashtag7, @hashtag8, @hashtag9, @hashtag10, @totalLikes);", conn);
                    cmd.Parameters.AddWithValue("@recipeName", newDessert.Name);
                    cmd.Parameters.AddWithValue("@recipeSource", newDessert.Source);
                    cmd.Parameters.AddWithValue("@imageSource", newDessert.ImageSource);
                    cmd.Parameters.AddWithValue("@recipeType", newDessert.Type);
                    cmd.Parameters.AddWithValue("@isVegan", newDessert.IsVegan);
                    cmd.Parameters.AddWithValue("@isLowFat", newDessert.IsLowFat);
                    cmd.Parameters.AddWithValue("@isSugarFree", newDessert.IsSugarFree);
                    cmd.Parameters.AddWithValue("@isFiveIngredientsOrLess", newDessert.IsFiveIngredientsOrLess);
                    cmd.Parameters.AddWithValue("@whenAdded", newDessert.DateAdded);
                    cmd.Parameters.AddWithValue("@hashtag1", newDessert.HashTag1);
                    cmd.Parameters.AddWithValue("@hashtag2", newDessert.HashTag2);
                    cmd.Parameters.AddWithValue("@hashtag3", newDessert.HashTag3);
                    cmd.Parameters.AddWithValue("@hashtag4", newDessert.HashTag4);
                    cmd.Parameters.AddWithValue("@hashtag5", newDessert.HashTag5);
                    cmd.Parameters.AddWithValue("@hashtag6", newDessert.HashTag6);
                    cmd.Parameters.AddWithValue("@hashtag7", newDessert.HashTag7);
                    cmd.Parameters.AddWithValue("@hashtag8", newDessert.HashTag8);
                    cmd.Parameters.AddWithValue("@hashtag9", newDessert.HashTag9);
                    cmd.Parameters.AddWithValue("@hashtag10", newDessert.HashTag10);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        


    }
}
