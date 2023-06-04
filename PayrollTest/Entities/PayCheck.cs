namespace PayrollTest.API.Models
{
    public class PayCheck
    {
        public Guid Id { get; set; }
        public double Value { get; set; }

        public Guid EmployeeId { get; set; }

    }
}
