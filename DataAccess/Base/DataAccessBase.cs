using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KutuphaneOtomasyonu.DataAccess.Base
{
    public class DataAccessBase
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private string connectionString = "Data Source=.;Initial Catalog=hastaneDB;Integrated Security=True";

        public DataAccessBase()
        {
            _connection = new SqlConnection(connectionString);
        }

        private void OpenConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (_connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        public DataSet Get(string sqlSentence)
        {
            DataSet readedValues = new DataSet();

            using (_command = new SqlCommand(sqlSentence, _connection))
            {
                OpenConnection();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlSentence, _connection))
                {
                    adapter.Fill(readedValues);
                }
            }
            CloseConnection();

            return readedValues;
        }

        public void Post(string sqlSentence)
        {
            using (_command = new SqlCommand(sqlSentence, _connection))
            {
                OpenConnection();
                _command.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}
