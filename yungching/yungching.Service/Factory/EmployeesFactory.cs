using yungching.Dao.Dao;

namespace yungching.Service.Services
{
    public class EmployeesFactory
    {
        public IEmployeesDao GetEmployeesDao()
        {
            IEmployeesDao result;
            switch (ServiceTools.GetAppsetting("CurrentEmployeesDao"))
            {
                case "Y":
                    result = new EmployeesDao();
                    break;

                default:
                    result = new EmployeesDao();
                    break;
            }
            return result;
        }
    }
}