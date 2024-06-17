using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL.Readers;
using ChapeauModel;

namespace ChapeauDAL
{
    public class IncomeDao : BaseDao
    {
        //Gets Income by date
        public double GetIncome(DateTime startDate, DateTime endDate)
        {
            string query = @"
SELECT SUM(paymentAmount) AS TotalIncome
FROM payments
WHERE paidAt BETWEEN @StartDate AND @EndDate;";

            double income = 0.0;
            try
            {
                using (SqlConnection connection = OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);
                        command.ExecuteNonQuery();

                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            income = Convert.ToDouble(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return income;
        }

        //Gets TotalIncome
        public double GetIncome()
        {
            string query = @"
SELECT SUM(paymentAmount) AS TotalIncome
FROM payments;";

            double income = 0.0;
            try
            {
                using (SqlConnection connection = OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            income = Convert.ToDouble(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return income;
        }
    }
}
