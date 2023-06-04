using PayrollTest.API.Resources;

namespace PayrollTest.API.Services
{
    public interface IBenefitService
    {
        Task<List<BenefitResource>> GetBenefits();
    }
}
