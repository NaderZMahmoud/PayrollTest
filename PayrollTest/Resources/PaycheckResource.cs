namespace PayrollTest.API.Resources
{
    public class PaycheckResource: Resource
    {
        public string? Description { get; set; }
        public decimal OriginalValue { get; set; }
        public decimal CalculatedValue { get; set; }
    }
}
