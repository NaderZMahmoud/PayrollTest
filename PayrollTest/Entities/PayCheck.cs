using PayrollTest.API.Entities;

namespace PayrollTest.API.Models
{
    public class PayCheck
    {
        public PayCheck()
        {
            Deductions=new List<Deduction>();
        }
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public decimal OriginalValue { get; set; }
        public decimal CalculatedValue { get; set; }

        public List<Deduction>? Deductions { get; set; }

        public Guid EmployeeId { get; set; }

    }
}
