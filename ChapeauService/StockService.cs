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
            // Asks stockDao for all stock
            return _stockDao.GetStock();
        }

        public void AddDelivery(Stock stock, int deliveryAmount)
        {
            // increases the count of the Stock with the deliveryAmount
            stock.Increase(deliveryAmount);

            //Sends data to changeStock
            ChangeStock(stock);
        }

        public void ChangeStock(Stock stock)
        {
            // Asks stockDao to change stock
            _stockDao.ChangeStock(stock);
        }
    }
}