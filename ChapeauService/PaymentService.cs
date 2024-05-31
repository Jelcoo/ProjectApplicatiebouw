using ChapeauModel;
using ChapeauDAL;
using ChapeauModel.Enums;

namespace ChapeauService
{
    public class PaymentService
    {
        private PaymentDao _paymentDao;

        public PaymentService()
        {
            _paymentDao = new PaymentDao();
        }
        public Payment MakeNewPayment(Invoice invoice, double amount, EPaymentMethod paymentMethod, double tipAmount)
        {
            Tip tip = _paymentDao.AddTip(invoice, new Tip(tipAmount));

            Payment payment = new Payment(
                invoice,
                amount: amount,
                paidAt: DateTime.Now
            );
            payment.SetTip(tip);
            payment.SetPaymentMethod(paymentMethod);

            return _paymentDao.CreatePayment(invoice, payment);
        }
    }
}
