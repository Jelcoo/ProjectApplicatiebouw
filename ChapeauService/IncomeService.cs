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

        public double GetIncome(DateTime date)
        {
            DateTime startOfDay = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);
            DateTime endOfDay = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59, 999);

            return _incomeDao.GetIncome(startOfDay, endOfDay);
        }

        public double GetIncome(DateTime startDate, DateTime endDate)
        {
            DateTime startDateStart = new DateTime(startDate.Year, startDate.Month, startDate.Day, 0, 0, 0, 0);
            DateTime endDateEnd = new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59, 999);

            return _incomeDao.GetIncome(startDateStart, endDateEnd);
        }


    }
}
