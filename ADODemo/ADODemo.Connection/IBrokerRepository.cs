using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo.Connection
{
    public interface IBrokerRepository
    {
        List<Broker> GetAllBrokers();

    }

    public class MicrosoftSqlServerBrokerRepository : IBrokerRepository
    {
        string _connectionString;

        public MicrosoftSqlServerBrokerRepository(string ConnectionString)
        {
            _connectionString = ConnectionString;
        }
        public List<Broker> GetAllBrokers()
        {
            List<Broker> allBrokers = new List<Broker>();
            
            string _sqlstatement = "SELECT id, firstName, lastName FROM Brokers";
            IDbConnection connection = new SqlConnection(_connectionString); //Where the database is
            IDbCommand command = new SqlCommand(_sqlstatement, (SqlConnection)connection); //What to do and where to do it

            try
            {
                connection.Open();

                IDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    allBrokers.Add(new Broker()
                    {
                        id = int.Parse(reader["id"].ToString()),
                        firstName = reader["firstName"].ToString(),
                        lastName = reader["lastName"].ToString()
                    });
                }               
            }
                catch(SqlException exception)
            {
                // log exception
                return allBrokers;
            }
            finally
            {
                connection.Close(); //this close avoids slowing down program
            }

            return allBrokers;
        }
    }
}