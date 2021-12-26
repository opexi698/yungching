using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yungching.Dao.Dao;
using yungching.Model;

namespace yungching.Service.Services
{
    public class EmployeesService : IEmployeesService
    {
        /// <summary>
        /// 取得員工清單
        /// </summary>
        /// <returns></returns>
        public IList<Employees> GetEmployees()
        {
            EmployeesFactory employeesFactory = new EmployeesFactory();
            IEmployeesDao employeesDao = employeesFactory.GetEmployeesDao();

            return employeesDao.GetEmployees();
        }
    }
}
