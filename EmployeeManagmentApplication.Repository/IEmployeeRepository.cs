using EmployeeManagmentApplication.Modal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagmentApplication.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployee();
        Task<Employee> GetEmployeeByID(int ID);
        Task<Employee> InsertEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        bool DeleteEmployee(int ID);
    }
}
