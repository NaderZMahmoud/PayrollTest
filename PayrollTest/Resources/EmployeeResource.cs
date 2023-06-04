using PayrollTest.API.Models;

namespace PayrollTest.API.Resources
{
    public class EmployeeResource : Resource
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public EmployeeTitle Title { get; set; }
    }
}
