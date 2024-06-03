using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;

namespace ChapeauService
{
    public class IncomeService
    {
        private IncomeDao _incomeDao;

        public IncomeService()
        {
            _incomeDao = new IncomeDao();
        }

        public double GetAllTimeIncome()
        {
            return _incomeDao.GetAllTimeIncome();
        }
        public double GetIncome(DateTime startDate)
        {
            return _incomeDao.GetIncome(startDate);
        }

        public double GetIncome(DateTime startDate, DateTime endDate)
        {
            return _incomeDao.GetIncome(startDate, endDate);
        }


    }
}
