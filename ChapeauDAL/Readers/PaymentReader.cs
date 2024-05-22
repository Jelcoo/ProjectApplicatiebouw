using ChapeauModel;
using ChapeauModel.Enums;
using System.Data.SqlClient;

namespace ChapeauDAL.Readers
{
    static class PaymentReader
    {
        public static Payment ReadPayment(SqlDataReader reader)
        {
            Payment payment = new Payment(
                paymentId: (int)reader["paymentId"],
                invoice: InvoiceReader.ReadInvoice(reader),
                amount: (float)reader["paymentAmount"],
                paidAt: (DateTime)reader["paidAt"]
            );

            if (reader["tipId"] != DBNull.Value)
            {
                payment.SetTip(ReadTip(reader));
            }

            if (reader["paymentMethodId"] != DBNull.Value)
            {
                payment.SetPaymentMethod((EPaymentMethod)(int)reader["paymentMethodId"]);
            }

            return payment;
        }

        public static Tip ReadTip(SqlDataReader reader)
        {
            Tip tip = new Tip(
                tipId: (int)reader["tipId"],
                amount: (float)reader["tipAmount"]
            );

            return tip;
        }
    }
}
