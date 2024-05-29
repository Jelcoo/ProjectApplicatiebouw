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
        public Payment MakeNewPayment(Invoice invoice, float amount, DateTime paidAt, float tipAmount)
        {
            Tip tip = _paymentDao.AddTip(invoice, new Tip(tipAmount));

            Payment payment = new Payment(
                invoice,
                amount: amount,
                paidAt: paidAt
            );
            payment.SetTip(tip);

            return _paymentDao.CreatePayment(invoice, payment);
        }
    }
}
