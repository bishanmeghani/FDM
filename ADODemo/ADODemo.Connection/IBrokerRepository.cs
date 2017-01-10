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

        void AddNewBroker(Broker brokerToAdd);

        void UpdateBroker(int BrokerToUpdateid, Broker newBroker);

        void RemoveBroker(int BrokerToRemove);

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


        public void AddNewBroker(Broker brokerToAdd)
        {
            string _sqlstatement = "INSERT INTO brokers(id, firstName, lastName) VALUES(@id, @firstName, @lastName)";
            IDbConnection connection = new SqlConnection(_connectionString);
            IDbCommand command = new SqlCommand(_sqlstatement, (SqlConnection)connection);
            IDataParameter parameter = new SqlParameter("@id", SqlDbType.Int, 25); //25 size of the int
            parameter.Value = brokerToAdd.id;
            command.Parameters.Add(parameter);
            IDataParameter parameter1 = new SqlParameter("@firstName", SqlDbType.VarChar, 255); //25 size of the int
            parameter1.Value = brokerToAdd.firstName;
            command.Parameters.Add(parameter1);
            IDataParameter parameter2 = new SqlParameter("@lastName", SqlDbType.VarChar, 255); //25 size of the int
            parameter2.Value = brokerToAdd.lastName;
            command.Parameters.Add(parameter2);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                
                throw;
            }
            finally
            {
                connection.Close();

            }
        }


        public void UpdateBroker(int BrokerToUpdateid, Broker newBroker)
        {
            string _sqlStatement = "UPDATE brokers SET firstName = @firstName, lastName = @lastName WHERE id = @id";
            IDbConnection connection = new SqlConnection(_connectionString);
            IDbCommand command = new SqlCommand(_sqlStatement, (SqlConnection)connection);
            IDataParameter parameter = new SqlParameter("@firstName", SqlDbType.VarChar, 255);
            IDataParameter parameter1 = new SqlParameter("@lastName", SqlDbType.VarChar, 255);
            IDataParameter parameter2 = new SqlParameter("@id", SqlDbType.Int, 55);
            parameter.Value = newBroker.firstName;
            command.Parameters.Add(parameter);
            parameter1.Value = newBroker.lastName;
            command.Parameters.Add(parameter1);
            parameter2.Value = BrokerToUpdateid;
            command.Parameters.Add(parameter2);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                
                throw;
            }
            finally
            {
                connection.Close();
            }
        }


        public void RemoveBroker(int brokerToRemove)
        {
            string _sqlStatement = "DELETE FROM brokers WHERE id = @id";
            IDbConnection connection = new SqlConnection(_connectionString);
            IDbCommand command = new SqlCommand(_sqlStatement, (SqlConnection)connection);
            IDataParameter parameter = new SqlParameter("@id", SqlDbType.Int, 55);
            parameter.Value = brokerToRemove;
            command.Parameters.Add(parameter);
            

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException exn)
            {

                throw;
            }
            finally
            {
                connection.Close();

            }
        }
    }
}