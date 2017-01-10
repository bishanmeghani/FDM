using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo.Connection
{
    public interface IBrokerDisconnected
    {
        List<Broker> GetAllBrokers();

    }

    public class BrokerRepositoryDisconnected : IBrokerDisconnected
    {
        List<Broker> allBrokers = new List<Broker>();
        string _connectionString;
        public BrokerRepositoryDisconnected(string connectionString)
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
    }
}
