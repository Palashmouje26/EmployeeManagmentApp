using EmployeeManagmentApplication.Modal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagmentApplication.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeRepository _EmployeeRepository;


        public EmployeeRepository()
        {

        }

        public bool DeleteEmployee(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetEmployee()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeByID(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> InsertEmployee(Employee employee)
        {
            
            //var result = await _EmployeeRepository.InsertEmployee(Employee);
            //if (result.EmployeeId == 0)
            ////{
            ////    return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            ////}
            //return Ok("Added Successfully");
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
