namespace BasicC_part6.Inheritance
{
    public class Student : Person
    {
        public string Faculty { get; set; }
        public int UniversityYear { get; set; }
        public Student(string firstName, string lastName, int age, string faculty, int universityYear) : base(firstName, lastName, age)
        {
            Faculty = faculty;
            UniversityYear = universityYear;
        }

        public void ShowFaculty()
        {
            Console.WriteLine(Faculty + " year: " + UniversityYear);            
        }

        public void ChangeAge(int age)
        {
            Age = age;
        }

        public override void ShowAge()
        {
            Console.WriteLine("Calling from student");
            base.ShowAge();
            
        }

        //override ShowAge with Console.WriteLine("from Student");
    }
}
