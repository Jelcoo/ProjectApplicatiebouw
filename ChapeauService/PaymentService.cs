using ChapeauModel;
using ChapeauDAL;

namespace ChapeauService
{
    public class PaymentService
    {
        public Payment MakeNewPayment(Invoice invoice, int paymentMethodId, float amount, DateTime paidAt, int tipAmount)
        {
            PaymentDao paymentDao = new PaymentDao();

            int tipId = paymentDao.AddTip(invoice, tipAmount);

            Payment payment = new Payment(
                invoiceId: invoice.InvoiceId,
                paymentMethodId: paymentMethodId,
                amount: amount,
                paidAt: paidAt,
                tipId: tipId
            );

            return paymentDao.CreatePayment(invoice, payment);
        }
    }
}
