using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    public class DataAccess
    {
        //Output is a list of type Movie, referencing the Movie.cs class, with all of the properties that match up with it
        public List<Movie> GetMovie()
        {
            //The line below allows us to compile the application while working on it
            //throw new NotImplementedException();

            //Opens a connection to the SQL server. Once it exits these brackets, the door to the db closes
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieNight")))
            {
                //Calls on the stored procedure dbo.Movies_GetMovie that returns a random MovieName
                var output = connection.Query<Movie>("dbo.Movies_GetMovie").ToList();
                return output;

                /*
                 * Stored Procedure dbo.Movies_GetMovie
                 * 
                 * SELECT TOP 1 MovieName
                    FROM Movies
                    ORDER BY NEWID()
                 */




                /*
                 * This block here is straight SQL. Bad practice & is susceptible to SQL injection - Keeping around for example
                //asks for data back <the data you want back> (SELECT statement to run. use this for now until we pull in stored procedure)
                var output = connection.Query<Person>($"select * from Person.Person where LastName = '{ lastName }'").ToList();
                return output;
                */



            }

        }



        //Takes the input from MovieNameInsertText.Text & uses the dbo.Movies_spInsertMovie with the
        //@MovieName param to insert the desired movie into the MovieNight DB
        public void InsertMovie(string MovieName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieNight")))
            {
                

                List<Movie> movie = new List<Movie>();

                movie.Add(new Movie { MovieName = MovieName});

                connection.Execute("dbo.Movies_spInsertMovie @MovieName", movie);



                /*
                 * Stored Procedure dbo.Movies_spInsertMovie
                 @MovieName nvarchar(max)
                 AS
                 BEGIN
                 SET NOCOUNT ON;
                 insert into dbo.Movies(MovieName)
                 values (@MovieName);
                 END
                   */


            }

        }


        //Takes the input from RandomMovieListBox.Text & uses the stored procedure dbo.Movies_spRemoveMovie to
        //remove any instances of it in the MovieNight DB
        public void RemoveMovie(string MovieName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieNight")))
            {
                

                List<Movie> movie = new List<Movie>();

                movie.Add(new Movie { MovieName = MovieName });

                connection.Execute("dbo.Movies_spRemoveMovie @MovieName", movie);



                /*
                 * Stored Procedure dbo.Movies_spRemoveMovie
                 * @MovieName nvarchar(max)
                   AS
                   BEGIN
                   SET NOCOUNT ON;
                   DELETE FROM dbo.Movies
                   WHERE MovieName = @MovieName
                   END
                 */


            }

        }


         //Output is a list of type Movie, referencing the Movie.cs class, with all of the properties that match up with it
        public List<Movie> GetMovieList()
        {
            //The line below allows us to compile the application while working on it
            //throw new NotImplementedException();

            //Opens a connection to the SQL server. Once it exits these brackets, the door to the db closes
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieNight")))
            {
                //Calls on the stored procedure dbo.Movies_GetMovie that returns a random MovieName
                var output = connection.Query<Movie>("dbo.Movies_GetList").ToList();
                return output;

                /*
                 * Stored Procedure dbo.Movies_GetList
                 * 
                 * AS
                   SELECT TOP 500 MovieName
                   FROM Movies
                   ORDER BY MovieName ASC
                 */




                /*
                 * This block here is straight SQL. Bad practice & is susceptible to SQL injection - Keeping around for example
                //asks for data back <the data you want back> (SELECT statement to run. use this for now until we pull in stored procedure)
                var output = connection.Query<Person>($"select * from Person.Person where LastName = '{ lastName }'").ToList();
                return output;
                */



            }

        }




    }
}
