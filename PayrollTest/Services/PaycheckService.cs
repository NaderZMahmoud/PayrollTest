using PayrollTest.API.Resources;

namespace PayrollTest.API.Services
{
    public class PaycheckService : IPaycheckService
    {
        private readonly IConfiguration Configuration;
        private readonly decimal DefaultPaycheckValue;
        public PaycheckService(IConfiguration configuration)
        {
            Configuration = configuration;
            DefaultPaycheckValue = decimal.Parse(Configuration["DefaultPayCheck:OriginalValue"]);
        }
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
