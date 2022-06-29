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
        //Output is a list of type Person, referencing the Person.cs class, with all of the properties that match up with it
        public List<Movie> GetMovie()
        {
            //The line below allows us to compile the application while working on it
            //throw new NotImplementedException();

            //Opens a connection to the SQL server. Once it exits these brackets, the door to the db closes
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieNight")))
            {
                //Calls on the stored procedure Person.spPerson_GetInfo & takes in the parameter @LastName
                // new { LastName = lastName } - Dynamic class to take in the input lastName, & places it inside the @LastName parameter
                var output = connection.Query<Movie>("dbo.Movies_GetMovie").ToList();
                return output;

                /*
                 * Stored Procedure Person.spPerson_GetInfo:
                 * 
                 * 	@LastName nvarchar(50)
                    AS
                    BEGIN
	                SELECT *
                    FROM Person.EmailAddress PE
                    LEFT OUTER JOIN Person.Person P
                    ON PE.BusinessEntityID = P.BusinessEntityID

                    END
                 */




                /*
                 * This block here is straight SQL. Bad practice & is susceptible to SQL injection
                //asks for data back <the data you want back> (SELECT statement to run. use this for now until we pull in stored procedure)
                var output = connection.Query<Person>($"select * from Person.Person where LastName = '{ lastName }'").ToList();
                return output;
                */



            }

        }


        public void InsertPerson(string MovieName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("MovieNight")))
            {
                //Person newPerson = new Person { FirstName = FirstName, LastName = LastName, EmailAddress = EmailAddress};

                List<Movie> people = new List<Movie>();

                people.Add(new Movie { MovieName = MovieName});

                //people is a list of Person. In each person you have the parameters @FirstName, @LastName, @EmailAddress
                //MUST CHANGE: Person.spPerson_GetInfo to a new stored procedure that is like dbo.People_Insert from Sample DB
                connection.Execute("Person.People_Insert @FirstName, @LastName, @BusinessEntityID, @PersonType", people);





                /*
                 * Old stored procedure when trying to insert into multiple tables
                 * ALTER PROCEDURE [Person].[People_Insert]
	                @FirstName nvarchar(50),
	                @LastName nvarchar(50),
	                @EmailAddress nvarchar(100),
	                @BusinessEntityID int
                    AS
                    BEGIN
	                SET NOCOUNT ON;

                    insert into Person.Person(FirstName, LastName, BusinessEntityID)
	                values (@FirstName, @LastName, @BusinessEntityID);

	                insert into Person.EmailAddress(EmailAddress, BusinessEntityID)
	                values (@EmailAddress, @BusinessEntityID);

                    END
                   */


            }

        }
    }
}
