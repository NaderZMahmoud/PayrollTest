using Microsoft.EntityFrameworkCore;
using PayrollTest.API.DataAccess;
using PayrollTest.API.Resources;

namespace PayrollTest.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly PayrollDBContext _dbContext;
        public EmployeeService(PayrollDBContext dbContext)
        {
            _dbContext= dbContext;
        }
        public async Task<BenefitResource?> AddBenefit(Guid employeeId, Guid benefitId)
        {
            if(employeeId == Guid.Empty  || benefitId == Guid.Empty)
            {
                
            }


            var emp = _dbContext.Employees.Where(emp => emp.Id == employeeId).FirstOrDefault();
            var ben = _dbContext.Benefits.Where(ben => ben.Id == benefitId).FirstOrDefault();
            if (emp != null && ben != null)
            {
                if (emp.Benefits == null)
                    emp.Benefits = new List<Models.Benefit>();

                emp.Benefits.Add(new Models.Benefit() { Id = new Guid(), Value = ben.Value, Description = ben.Description });
                await _dbContext.SaveChangesAsync();

                return new BenefitResource() { Value = ben.Value, Description = ben.Description };
            }
            else
            return null;
        }

        public Task<PaycheckResource> AddPaycheck()
        {
            throw new NotImplementedException();
        }

        public Task<List<BenefitResource>> GetBenefitList()
        {
            throw new NotImplementedException();
        }

        public Task<List<PaycheckResource>> GetPaycheckList()
        {
            throw new NotImplementedException();
        }
    }
}
