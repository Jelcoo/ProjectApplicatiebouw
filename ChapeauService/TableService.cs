using ChapeauModel;
using ChapeauDAL;
using ChapeauModel.Enums;

namespace ChapeauService
{
    public class TableService
    {
        private TableDao _tableDao;

        public TableService()
        {
            _tableDao = new TableDao();
        }

        public List<Table> GetTables()
        {
            List<Table> tables = _tableDao.GetTables();
            return tables;
        }
    }
}
