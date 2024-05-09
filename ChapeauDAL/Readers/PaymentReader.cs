using ChapeauModel;
using System.Data.SqlClient;

namespace ChapeauDAL.Readers
{
    static class PaymentReader
    {
        public static Payment ReadPayment(SqlDataReader reader)
        {
            Payment payment = new Payment(
                paymentId: (int)reader["paymentId"],
                invoiceId: (int)reader["invoiceId"],
                paymentMethodId: (int)reader["paymentMethodId"],
                amount: (float)reader["paymentAmount"],
                paidAt: (DateTime)reader["paidAt"],
                tipId: (int)reader["tipId"]
            );

            return payment;
        }

        public static PaymentMethod ReadPaymentMethod(SqlDataReader reader)
        {
            PaymentMethod paymentMethod = new PaymentMethod(
                paymentMethodId: (int)reader["paymentMethodId"],
                name: (string)reader["methodName"]
            );

            return paymentMethod;
        }

        public static Tip ReadTip(SqlDataReader reader)
        {
            Tip tip = new Tip(
                tipId: (int)reader["tipId"],
                paymentId: (int)reader["paymentId"],
                amount: (float)reader["tipAmount"]
            );

            return tip;
        }
    }
}
