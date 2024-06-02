using ChapeauDAL.Readers;
using ChapeauModel;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class PaymentDao : BaseDao
    {
        public Payment CreatePayment(Invoice invoice, Payment payment)
        {
            string query = @"
INSERT INTO payments (invoiceId, paymentMethodId, paymentAmount, paidAt)
VALUES (@invoiceId, @paymentMethodId, @paymentAmount, @paidAt)
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@invoiceId", invoice.InvoiceId);
            command.Parameters.AddWithValue("@paymentMethodId", payment.PaymentMethod);
            command.Parameters.AddWithValue("@paymentAmount", payment.Amount);
            command.Parameters.AddWithValue("@paidAt", payment.PaidAt);

            int paymentId = Convert.ToInt32(command.ExecuteScalar());
            payment.SetPaymentId(paymentId);

            CloseConnection();

            return payment;
        }

        public Tip AddTip(Invoice invoice, Tip tip)
        {
            string query = @"
INSERT INTO tips (invoiceId, tipAmount)
VALUES (@invoiceId, @tipAmount);
SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@invoiceId", invoice.InvoiceId);
            command.Parameters.AddWithValue("@tipAmount", tip.Amount);

            int tipId = Convert.ToInt32(command.ExecuteScalar());
            tip.SetId(tipId);

            return tip;
        }

        public Payment GetPaymentByInvoiceId(int invoiceId)
        {
            string query = @"
SELECT paymentId, invoiceId, paymentMethodId, paymentAmount, paidAt
FROM payments
WHERE invoiceId = @invoiceId";

            SqlCommand command = new SqlCommand(query, OpenConnection());
            command.Parameters.AddWithValue("@invoiceId", invoiceId);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Payment payment = PaymentReader.ReadPayment(reader);

                reader.Close();
                CloseConnection();

                return payment;
            }
            else {
                throw new Exception($"Payment with Invoice ID '{invoiceId}' not found");
            }
        }
    }
}
