using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using yungching.Model;

namespace yungching.Dao.Dao
{
    public class EmployeesDao : IEmployeesDao
    {
        /// <summary>
        /// 取得連線字串
        /// </summary>
        /// <returns></returns>
        private string GetDbConnectionString()
        {
            return DaoTools.GetDBConnectionString("DefaultConnection");
        }

        /// <summary>
        /// DataTable轉ModelList
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private IList<Employees> ConvertToModel(DataTable dt)
        {
            IList<Employees> employeesList = new List<Employees>();

            foreach (DataRow dr in dt.Rows)
            {
                Employees employees = new Employees()
                {
                    EmployeeID = dr.Field<int>("EmployeeID"),
                    LastName = dr.Field<string>("LastName"),
                    FirstName = dr.Field<string>("FirstName"),
                    Title = dr.Field<string>("Title"),
                    TitleOfCourtesy = dr.Field<string>("TitleOfCourtesy")
                };
                employeesList.Add(employees);
            }
            return employeesList;
        }

        /// <summary>
        /// 取得員工清單
        /// </summary>
        /// <returns></returns>
        public IList<Employees> GetEmployees()
        {
            DataTable dt = new DataTable();
            IList<Employees> employeesList = new List<Employees>();
            string queryString =
            "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy FROM Employees";
            using (SqlConnection connection =
            new SqlConnection(GetDbConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dt);
                employeesList = ConvertToModel(dt);
            }

            return employeesList;
        }
    }
}