using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo.Connection
{


    public class MicrosoftSqlServerBrokerRepositoryDisconnected : IBrokerRepository
    {
        List<Broker> allBrokers = new List<Broker>();
        string _connectionString;
        public MicrosoftSqlServerBrokerRepositoryDisconnected(string connectionString)
        {
            _connectionString = connectionString;
        }
        public List<Broker> GetAllBrokers()
        {
            string _sqlStatement = "SELECT id, firstName, lastName FROM brokers";
            DataSet dataSet = new DataSet();
            IDbDataAdapter dataAdapter = new SqlDataAdapter();
            IDbConnection connection = new SqlConnection(_connectionString);
            IDbCommand command = new SqlCommand(_sqlStatement, (SqlConnection)connection);
            dataAdapter.SelectCommand = command;
            try
            {
                connection.Open();
                dataAdapter.Fill(dataSet);
                
            }
            finally
            {
                connection.Close();
            }
        

            foreach (DataRow row in dataSet.Tables[0].Rows)
	        {
		        allBrokers.Add(new Broker()
                {
                    id = int.Parse(row["id"].ToString()),
                    firstName = row["firstName"].ToString(),
                    lastName = row["lastName"].ToString()
                });
	        }
            return allBrokers;
        }


        public void AddNewBroker(Broker brokerToAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateBroker(int brokerToUpdateId, Broker newBroker)
        {
            string _sqlStatement =
                "SELECT id, firstName, lastName FROM brokers";

            string _sqlUpdateStatement =
                "UPDATE brokers SET firstName = @firstName, lastName = @lastName WHERE id = @id";

            IDbConnection connection = new SqlConnection(_connectionString);
            IDbCommand command = new SqlCommand(_sqlStatement, (SqlConnection)connection);
            IDbCommand updateCommand = new SqlCommand(_sqlUpdateStatement, (SqlConnection)connection);

            IDataParameter param = new SqlParameter("@firstName", SqlDbType.VarChar, 255);
            param.Value = newBroker.firstName;
            updateCommand.Parameters.Add(param);

            IDataParameter param2 = new SqlParameter("@lastName", SqlDbType.VarChar, 255);
            param2.Value = newBroker.lastName;
            updateCommand.Parameters.Add(param2);

            IDataParameter param3 = new SqlParameter("@id", SqlDbType.Int, 55);
            param3.Value = brokerToUpdateId;
            updateCommand.Parameters.Add(param3);

            DataSet dataSet = new DataSet();
            IDbDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            da.UpdateCommand = updateCommand;

            try
            {
                connection.Open();
                da.Fill(dataSet);
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                if (int.Parse(row["id"].ToString()) == brokerToUpdateId)
                {
                    row["firstName"] = newBroker.firstName;
                    row["lastName"] = newBroker.lastName;
                    break;
                }
            }

            try
            {
                connection.Open();
                da.Update(dataSet);
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }


        public void RemoveBroker(int BrokerToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
