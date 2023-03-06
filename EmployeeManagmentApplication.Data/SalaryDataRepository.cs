using EmployeeManagmentApplication.Modal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagmentApplication.Data
{
    public class SalaryDataRepository : ISalaryDataRepository
    {
        private readonly EmployeeDBContext _DBContext;
        public SalaryDataRepository(EmployeeDBContext dbContext)
        {
            _DBContext = dbContext;
        }
        public bool DeleteSalaryModule(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SalaryModule>> GetSalaryModule()
        {
            throw new NotImplementedException();
        }

        public Task<SalaryModule> GetSalaryModuleByID(int ID)
        {
            throw new NotImplementedException();
        }

        public async  Task<SalaryModule> InsertSalary(SalaryModule SalaryModule)
        {
            _DBContext.SalaryModule.Add(SalaryModule);
            await _DBContext.SaveChangesAsync();
            return SalaryModule;
        }

        public Task<SalaryModule> UpdateSalary(SalaryModule SalaryModule)
        {
            throw new NotImplementedException();
        }
    }
}
