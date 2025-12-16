using System;
using MySql.Data.MySqlClient;

namespace ClubMembership
{
    public static class DBHelper
    {
        public static string ConnectionString = "server=localhost;database=ClubMembershipDB;uid=root;pwd=pogiko;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
