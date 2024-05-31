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

        public string GetDetailNameById(int id)
        {
            return _stockDao.GetDetailNameById(id);
        }

        public Dictionary<MenuItem, Stock> GetMenuItemAndStockById(int id)
        {
            return _stockDao.GetMenuItemAndStockById(id);
        }

        public void AddDelivery(int stockId, int amount)
        {
            _stockDao.AddDelivery(stockId, amount);
        }

        public void AlterStock(Stock stock)
        {
            _stockDao.AlterStock(stock);
        }
    }
}