using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class StockService
    {
        private StockDao _stockDao;

        public StockService()
        {
            _stockDao = new StockDao();
        }

        public List<MenuItem> GetStock()
        {
            return _stockDao.GetStock();
        }

        public void AddDelivery(Stock stock, int deliveryAmount)
        {
            stock.Increase(deliveryAmount);
            ChangeStock(stock);
        }

        public void ChangeStock(Stock stock)
        {
            _stockDao.ChangeStock(stock);
        }
    }
}