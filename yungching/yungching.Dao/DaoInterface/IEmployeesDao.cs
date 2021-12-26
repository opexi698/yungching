using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yungching.Model;

namespace yungching.Dao.Dao
{
    public interface IEmployeesDao
    {
        IList<Employees> GetEmployees();
    }
}
