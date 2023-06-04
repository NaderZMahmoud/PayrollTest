using PayrollTest.API.Resources;

namespace PayrollTest.API.Services
{
    public class PaycheckService : IPaycheckService
    {
        public Task<PaycheckResource> CreatePaycheck(Guid EmployeeId)
        {
            throw new NotImplementedException();
        }

        public Task<PaycheckResource> CalculatePaycheck(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<PaycheckResource> GetPaycheck(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
