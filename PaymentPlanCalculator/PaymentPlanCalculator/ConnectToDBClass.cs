using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PaymentPlanCalculator
{
    class ConnectToDBClass
    {/*
         static void Main(string[] args)
        {
            //Console .NET FRAMEWORK App
            //Added MySqlConnector NuGet Package
            //
            GenerateTables dbTables = new GenerateTables(); // Naming GenerateTables class as 'dbTables'






            //Manage Nuget -> Add EntityFramework
            //Rightclick PROJECT -> Add -> New File
            //



            dbTables.Run();
            
        } */
    }
    class GenerateTables
    {
        public List<string> tableNames; // Create list named 'tableNames' within GenerateTables class

        public void Run()
        {
            tableNames = new List<string>(); // list created for tableNames as string List

            //MySqlConnection is Variable Type and connection is Variable

            using (MySqlConnection connection = new MySqlConnection("Server=50.63.161.72;User ID=root;Password=admin;Database=collectionsmax")) // Force connection with static string to test DB
            {

                connection.Open(); // Open Connection

                // MySqlCommand and MySqlDataReader are both variabe types likely from MySql.Data
                // command and reader are variables

                //using (MySqlCommand command = new MySqlCommand("SELECT table_name FROM information_schema.tables WHERE table_type = 'base table'", connection))
                //
                using (MySqlCommand command = new MySqlCommand("SHOW TABLES FROM collectionsmax", connection)) // create query and specify connection
                using (MySqlDataReader reader = command.ExecuteReader()) // execute query from above (command)
                    while (reader.Read()) // While tables are being read from the specified query
                    {
                        string str = reader.GetString(0); // Save table name as a string at index 0
                        tableNames.Add(str); // Add table name as a sting to tableNames List
                        Console.WriteLine(str); // Write out the name of the table being written to the string and added to the List in previous line
                    }
            }
            Console.ReadKey(); // Prevent console window from closing
        }
    }
}
