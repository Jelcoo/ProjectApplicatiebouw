﻿using ChapeauModel;
using System.Data.SqlClient;

namespace ChapeauDAL.Readers
{
    static class TableReader
    {
        public static Table ReadTable(SqlDataReader reader)
        {
            Table table = new Table(
                tableId: (int)reader["tableId"],
                occupied: (bool)reader["occupied"],
                invoiceId: (int)reader["invoiceId"]
            );

            return table;
        }
    }
}
