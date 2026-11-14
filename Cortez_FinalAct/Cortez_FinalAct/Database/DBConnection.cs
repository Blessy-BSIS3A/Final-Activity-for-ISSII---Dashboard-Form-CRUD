
using System;
using System.Data.OleDb;
using System.IO;

namespace Cortez_FinalAct
{
    public class DBConnection
    {
        private static string dbPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "Database",
            "CortezInventoryDB.accdb"
        );

        private static string connectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            + dbPath + ";Persist Security Info=False;";

        public static OleDbConnection GetConnection()
        {
            if (!File.Exists(dbPath))
            {
                throw new FileNotFoundException(
                    "Database file not found: " + dbPath
                );
            }

            return new OleDbConnection(connectionString);
        }
    }
}
