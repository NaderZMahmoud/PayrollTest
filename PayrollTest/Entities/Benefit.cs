namespace PayrollTest.API.Models
{
    public class Benefit
    {
        public Guid Id { get; set; }
        public double Value { get; set; }
        public string? Description { get; set; }
    }
}
