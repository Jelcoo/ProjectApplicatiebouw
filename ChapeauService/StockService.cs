using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;

namespace ChapeauService
{
    public class StockService
    {
        private StockDao _stockDao;

        public StockService()
        {
            _stockDao = new StockDao();
        }

        public Dictionary<int, (string name, int stock)> GetStock()
        {
            return _stockDao.GetStock();
        }
    }
}