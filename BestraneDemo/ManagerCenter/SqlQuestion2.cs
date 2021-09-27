using System;
namespace BestraneDemo.ManagerCenter
{
    public class SqlQuestion2
    {
        private readonly string ConnectionKey;

        public SqlQuestion2(string connectionKey)
        {
            ConnectionKey = connectionKey;
        }


        public void UpdateYear(int year)
        {

            SqlConnection connection = new SqlConnection(ConnectionKey);

            var command = connection.CreateCommand();
            command.CommandText = "update enrollments set year = @year where id between 20 and 100";

            command.Parameters.AddWithValue("Year", 2015);

            command.ExecuteNonQuery();
        }
    }
}
