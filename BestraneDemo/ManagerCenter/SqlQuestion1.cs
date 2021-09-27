using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BestraneDemo.Models;
using System.Threading.Tasks;
using System.Linq;

namespace BestraneDemo.ManagerCenter
{
    public class SqlQuestion1
    {
        private readonly string ConnectionKey;

        public SqlQuestion1(string connectionKey)
        {
            ConnectionKey = connectionKey;
        }

        //john
        public List<Student> GetFirstName(string firstName)
        {
            firstName = "john";
            SqlConnection connection = new SqlConnection(ConnectionKey);

            var command = connection.CreateCommand();
            command.CommandText = "select * from Student where FirstName = @firstName";
            command.Parameters.AddWithValue("FirstName", firstName);

            var table = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(table);

            var studentList = table.Select().Select(x =>
            {
                var student = new Student();
                student.Id = (int)x["id"];
                student.FirstName = (string)x["firstName"];
                student.LastName = (string)x["lastName"];

                return student;

            }).ToList();

            return studentList;
        }
    }
}
