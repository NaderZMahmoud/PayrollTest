using PayrollTest.API.Resources;

namespace PayrollTest.API.Services
{
    public interface IPaycheckService
    {
        Task<PaycheckResource> GetPaycheck(Guid Id);
        Task<PaycheckResource> CreatePaycheck(Guid EmployeeId);
        Task<PaycheckResource> CalculatePaycheck(Guid Id);
    }
}
