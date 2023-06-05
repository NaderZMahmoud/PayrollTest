using System;
using Xunit;
using PayrollTest.API.Services;

namespace PayrollTest.Tests
{
    public class EmployeeTests
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeTests(IEmployeeService employeeService)
        {

            _employeeService = employeeService; 

        }
        [Fact]
        public void AddBenefit()
        {
           // _employeeService.AddBenefit(employeeId, benefitId);
        }
    }
}