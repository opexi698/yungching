using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yungching.Model;

namespace yungching.Service.Services
{
    public interface IEmployeesService
    {
        IList<Employees> GetEmployees();
    }
}
