namespace BasicC_part6.Inheritance
{
    public class Person
    {       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected internal int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void ShowName()
        {
            Console.WriteLine(FirstName+ " " + LastName);
        }

        public virtual void ShowAge()
        {
            Console.WriteLine("Age: "+ Age);
        }
    }
}
