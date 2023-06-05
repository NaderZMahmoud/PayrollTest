namespace PayrollTest.API.Models
{
    public class Employee: Person
    {
        public Employee() {
            Dependents = new List<Person> { };
            Paychecks = new List<PayCheck> { };
            Benefits= new List<Benefit> { };    
        }   
        public EmployeeTitle Title { get; set; }
        public List<Person>? Dependents { get; set; }
        public List<PayCheck>? Paychecks { get; set; }

        public List<Benefit>? Benefits { get; set; }
    }
}
