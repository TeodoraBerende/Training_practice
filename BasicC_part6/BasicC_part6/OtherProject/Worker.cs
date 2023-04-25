using BasicC_part6.Inheritance;

namespace OtherProject
{
    public class Worker : Person
    {
        public string CompanyName { get; set; }
        public Worker(string firstName, string lastName, int age, string companyName) : base(firstName, lastName, age)
        {
            CompanyName = companyName;
        }

        public void ChangeAge(int age)
        {
            Age = age;
        }
    }
}
