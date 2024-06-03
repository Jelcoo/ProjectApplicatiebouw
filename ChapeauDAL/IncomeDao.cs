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
        public double GetIncome(DateTime date)
        {
            string query = @"
SELECT SUM(ol.quantity * mi.price) AS TotalIncome
FROM invoices i
JOIN orders AS o ON i.invoiceId = o.invoiceId
JOIN orderLines AS ol ON o.orderId = ol.orderId
JOIN menuItems AS mi ON ol.menuItemId = mi.menuItemId
JOIN payments AS p ON i.invoiceId = p.invoiceId
WHERE CAST(i.createdAt AS DATE) = @SelectedDate AND CAST(p.paidAt AS DATE) = @SelectedDate;";

            double income = 0.0;

            try
            {
                using (SqlConnection connection = OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SelectedDate", date);

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

        public double GetIncome(DateTime startDate, DateTime endDate)
        {
            string query = @"
SELECT SUM(ol.quantity * mi.price) AS TotalIncome
FROM invoices i
JOIN orders AS o ON i.invoiceId = o.invoiceId
JOIN orderLines AS ol ON o.orderId = ol.orderId
JOIN menuItems AS mi ON ol.menuItemId = mi.menuItemId
JOIN payments AS p ON i.invoiceId = p.invoiceId
WHERE CAST(i.createdAt AS DATE) BETWEEN @StartDate AND @EndDate
AND CAST(p.paidAt AS DATE) BETWEEN @StartDate AND @EndDate;";

            double income = 0.0;
            try
            {
                using (SqlConnection connection = OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SelectedDate", startDate);
                        command.Parameters.AddWithValue("@SelectedDate", endDate);
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

        public double GetAllTimeIncome()
        {
            string query = @"
SELECT SUM(ol.quantity * mi.price) AS TotalIncome
FROM invoices AS i
JOIN orders AS o ON i.invoiceId = o.invoiceId
JOIN orderLines AS ol ON o.orderId = ol.orderId
JOIN menuItems AS mi ON ol.menuItemId = mi.menuItemId
AS JOIN payments p ON i.invoiceId = p.invoiceId
WHERE CAST(i.createdAt AS DATE) BETWEEN @StartDate AND @EndDate
AND CAST(p.paidAt AS DATE) BETWEEN @StartDate AND @EndDate;";

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
