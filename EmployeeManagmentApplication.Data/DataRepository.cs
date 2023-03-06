using EmployeeManagmentApplication.Modal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagmentApplication.Data
{
    public class DataRepository : IDataReposatory
    {
        private readonly EmployeeDBContext _DBContext;
        public DataRepository(EmployeeDBContext dbContext)
        {
            _DBContext = dbContext;
        }

        public bool DeleteEmployee(int ID)
        {
            bool result = false;
            var employee = _DBContext.Employee.Find(ID);
            if (employee != null)
            {  
                _DBContext.Entry(employee).State = EntityState.Deleted;
                _DBContext.SaveChanges();
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            return await _DBContext.Employee.ToListAsync();
        }

        public async Task<Employee> GetEmployeeByID(int ID)
        {
            return await _DBContext.Employee.FindAsync(ID);
        }

        public async Task<Employee> InsertEmployee(Employee employee)
        {
            _DBContext.Employee.Add(employee);
            await _DBContext.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            _DBContext.Entry(employee).State = EntityState.Modified;
            await _DBContext.SaveChangesAsync();
            return employee;
        }
    }
}
