using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DvdLibraryMilestone5.Models;

namespace DvdLibraryMilestone5.Data.Repositories
{
    public class DVDRepositoryADO : IDvdRepository
    {
        //private const string selectDvd = "SELECT d.DvdId,d.Title,d.RatingId,d.Director,d.ReleaseYear FROM Dvds d";
        private const string selectDvd = "SELECT d.DvdId, d.Title, d.Director, d.ReleaseYear, r.RatingId, r.RatingName FROM Dvds d LEFT JOIN Ratings r on d.RatingId = r.RatingId";

        // private const string selectDvd ="SELECT d.DvdId, d.Title, d.Director, d.ReleaseYear, r.RatingId, r.RatingName FROM Dvds d LEFT JOIN Ratings r on d.RatingId = r.RatingId";
        private const string updateDvd = "Update Dvds Set Title = @Title,RatingId = @RatingId,Director = @Director,ReleaseYear = @ReleaseYear WHERE DvdId = @DvdId";
        private const string deleteDvd = "DELETE FROM Dvds WHERE DvdId = @DvdId";
        private const string insertDvd = "INSERT INTO Dvds (Title,RatingId,Director,ReleaseYear) VALUES(@Title,@RatingId,@Director,@ReleaseYear)";



        public void CreateDvd(Dvd dvd)
        {
            using (SqlConnection conn = new SqlConnection(Settings.GetConnectionString()))
            {

                SqlCommand cmd = new SqlCommand(insertDvd, conn);

                cmd.Parameters.AddWithValue("@Title", dvd.Title);
                cmd.Parameters.AddWithValue("@RatingId", dvd.RatingId);
                cmd.Parameters.AddWithValue("@Director", dvd.Director);
                cmd.Parameters.AddWithValue("@ReleaseYear", dvd.ReleaseYear);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                }

            }
        }

        public IEnumerable<Dvd> GetAll()
        {
            List<Dvd> results = new List<Dvd>();
            
            using (SqlConnection conn = new SqlConnection(Settings.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(selectDvd, conn);

                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Dvd d = new Dvd();

                        d.DvdId = int.Parse(dr["DvdId"].ToString());
                        d.Title = dr["Title"].ToString();
                        d.RatingId = int.Parse(dr["RatingId"].ToString());
                        d.Director = dr["Director"].ToString();
                        d.ReleaseYear = dr["ReleaseYear"].ToString();

                        results.Add(d);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                }
            }

            return results;
        }

        public Dvd GetById(int id)
        {
            Dvd dvd = null;
            using (SqlConnection conn = new SqlConnection(Settings.GetConnectionString()))
            {

                SqlCommand cmd = new SqlCommand(selectDvd + " WHERE DvdId = @DvdId", conn);
                cmd.Parameters.AddWithValue("@DvdId", id);

                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    // if instead of while?
                    while (dr.Read())
                    {
                        Dvd d = new Dvd();

                        d.DvdId = int.Parse(dr["DvdId"].ToString());
                        d.Title = dr["Title"].ToString();
                        d.RatingId = int.Parse(dr["RatingId"].ToString());
                        d.Director = dr["Director"].ToString();
                        d.ReleaseYear = dr["ReleaseYear"].ToString();
                        dvd = d;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                }
            }
            return dvd;
        }

        public IEnumerable<Dvd> GetbyRating(string rating)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dvd> GetByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dvd> GetByDirector(string director)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dvd> GetByReleaseYear(string year)
        {
            throw new NotImplementedException();
        }

        public void Update(Dvd dvd)
        {
            using (SqlConnection conn = new SqlConnection(Settings.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(updateDvd, conn);
                cmd.Parameters.AddWithValue("@Title", dvd.Title);
                cmd.Parameters.AddWithValue("@RatingId", dvd.RatingId);
                cmd.Parameters.AddWithValue("@Director", dvd.Director);
                cmd.Parameters.AddWithValue("@ReleaseYear", dvd.ReleaseYear);
                cmd.Parameters.AddWithValue("@DvdId", dvd.DvdId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                }
            }

        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(Settings.GetConnectionString()))
            {


                SqlCommand cmd = new SqlCommand(deleteDvd, conn);

                cmd.Parameters.AddWithValue("@DvdId", id);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}