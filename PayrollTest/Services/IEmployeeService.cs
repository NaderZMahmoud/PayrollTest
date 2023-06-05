using PayrollTest.API.Resources;

namespace PayrollTest.API.Services
{
    public interface IEmployeeService
    {
        Task<BenefitResource?> AddBenefit(Guid EmployeeId, Guid BenefitId);
        Task<PaycheckResource> AddPaycheck();

        Task<List<BenefitResource>> GetBenefitList();

        Task<List<PaycheckResource>> GetPaycheckList();
    }
}
