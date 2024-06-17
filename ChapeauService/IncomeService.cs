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
            // Asks IncomeDao for totalIncome
            return _incomeDao.GetIncome();
        }

        public double GetIncome(DateTime date)
        {
            // Sets Start and End of date
            DateTime startOfDay = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);
            DateTime endOfDay = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59, 999);


            //Asks incomeDao for Single Day income
            return _incomeDao.GetIncome(startOfDay, endOfDay);
        }

        public double GetIncome(DateTime startDate, DateTime endDate)
        {
            // Sets StartDate to start of the day; 00:00.000
            DateTime startDateStart = new DateTime(startDate.Year, startDate.Month, startDate.Day, 0, 0, 0, 0);

            // Sets StartDate to end of the day; 23:59:999
            DateTime endDateEnd = new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59, 999);

            //Asks incomeDao for Double Day income
            return _incomeDao.GetIncome(startDateStart, endDateEnd);
        }


    }
}
