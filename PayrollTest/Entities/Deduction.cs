namespace PayrollTest.API.Entities
{
    public class Deduction
    {
        public Guid Id { get; set; }
        public double Value { get; set; }
        public string? Description { get; set; }
    }
}
