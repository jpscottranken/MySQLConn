//  How to Connect to MySQL database in c# | C# MySQL connection in Visual Studio 2022 (Programming Guru)
//  https://www.youtube.com/watch?v=n1QarlZj3lM

using MySql.Data.MySqlClient;
using System;
using static System.Console;

namespace MySQLConsoleAppProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //	Set up connection string parameters
            string server   = "localhost";
            string database = "acme_widget";
            string username = "root";
            string password = "";

            //  https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection.connectionstring?view=dotnet-plat-ext-7.0
            //  https://www.connectionstrings.com/mysql-connector-net-mysqlconnection/
            //  https://dev.mysql.com/doc/connector-net/en/connector-net-connections-string.html
            //	Set up the connection string variable
            string connstr = "SERVER="   + server   + ";" +
                             "DATABASE=" + database + ";" +
                             "USERNAME=" + username + ";" +
                             "PASSWORD=" + password + ";";

            //	Create actual connection
            MySqlConnection conn = new MySqlConnection(connstr);

            //	Open the connection
            conn.Open();

            //	Set up the query variable
            string query1 = "SELECT * FROM employee";

            //  https://dev.mysql.com/doc/connector-net/en/connector-net-programming-mysqlcommand.html
            //  Set up command object
            MySqlCommand cmd1 = new MySqlCommand(query1, conn);

            Write("\n\nHit any key to see the contents of the employee table: ");
            ReadLine();
            Clear();
            WriteLine("Showing the contents of table employee:\n");

            //  Set up the datareader object
            //  https://dev.mysql.com/doc/dev/connector-net/latest/html/T_MySql_Data_MySqlClient_MySqlDataReader.htm
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                WriteLine("Employee ID: "        + reader1["employeeid"]);
                Write("Employee Name: "          + reader1["first_name"] + " ");
                WriteLine(reader1["last_name"]);
                WriteLine("Employee Address: "   + reader1["address"]);
                Write("City, State, Zip: "       + reader1["city"] + " ");
                Write(reader1["state_code"] + " ");
                WriteLine(reader1["zip"]);
                WriteLine("Employee Phone: "     + reader1["phone"]);
                WriteLine("Employee Dept Code: " + reader1["department_code"]);
                WriteLine("Employee Salary: "    + reader1["salary"] + "\n");
            }

            conn.Close();
            conn.Open();

            //	Create actual connection
            string query2 = "SELECT * FROM department";

            //  Set up command object
            MySqlCommand cmd2 = new MySqlCommand(query2, conn);

            Write("\n\nHit any key to see the contents of the department table: ");
            ReadLine();
            Clear();
            WriteLine("Showing the contents of table department:\n");
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                WriteLine("Department Code: " + reader2["department_code"]);
                WriteLine("Department Name: " + reader2["department_name"] + "\n");
            }

            Write("\n\nHit any key to see the contents of the state table: ");
            ReadLine();
            Clear();

            conn.Close();
            conn.Open();

            //	Set up the query variable
            string query3 = "SELECT * FROM state";

            //  Set up command object
            MySqlCommand cmd3 = new MySqlCommand(query3, conn);

            WriteLine("Showing the contents of table state:\n");
            MySqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                WriteLine("State Code: " + reader3["state_code"]);
                WriteLine("State Name: " + reader3["state_name"] + "\n");
            }

            Write("\n\nHit any key to end the program: ");
            ReadLine();
        }
    }
}
