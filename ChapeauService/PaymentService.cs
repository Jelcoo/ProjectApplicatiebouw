using ChapeauModel;
using ChapeauDAL;

namespace ChapeauService
{
    public class PaymentService
    {
        private PaymentDao _paymentDao;

        public PaymentService()
        {
            _paymentDao = new PaymentDao();
        }
        public Payment MakeNewPayment(Invoice invoice, int paymentMethodId, float amount, DateTime paidAt, int tipAmount)
        {
            int tipId = _paymentDao.AddTip(invoice, tipAmount);

            Payment payment = new Payment(
                invoiceId: invoice.InvoiceId,
                paymentMethodId: paymentMethodId,
                amount: amount,
                paidAt: paidAt,
                tipId: tipId
            );

            return _paymentDao.CreatePayment(invoice, payment);
        }
    }
}
