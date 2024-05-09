﻿using ChapeauModel;
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
                paymentMethod: ReadPaymentMethod(reader),
                amount: (float)reader["amount"],
                paidAt: (DateTime)reader["paidAt"],
                tip: ReadTip(reader)
            );

            return payment;
        }

        public static PaymentMethod ReadPaymentMethod(SqlDataReader reader)
        {
            PaymentMethod paymentMethod = new PaymentMethod(
                paymentMethodId: (int)reader["paymentMethodId"],
                name: (string)reader["name"]
            );

            return paymentMethod;
        }

        public static Tip ReadTip(SqlDataReader reader)
        {
            Tip tip = new Tip(
                tipId: (int)reader["tipId"],
                payment: ReadPayment(reader),
                amount: (float)reader["amount"]
            );

            return tip;
        }
    }
}
