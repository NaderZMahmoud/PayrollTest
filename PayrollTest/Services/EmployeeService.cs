using PayrollTest.API.Resources;

namespace PayrollTest.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Task<BenefitResource> AddBenefit(Guid BenefitId)
        {
            throw new NotImplementedException();
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
