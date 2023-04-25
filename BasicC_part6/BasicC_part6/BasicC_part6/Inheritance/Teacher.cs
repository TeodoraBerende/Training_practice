namespace BasicC_part6.Inheritance
{
    public class Teacher : Person
    {
        public List<string> Classes { get; set; }

        public Teacher(string firstName, string lastName, int age, List<string> classes) : base(firstName, lastName, age)
        {
            Classes = classes;            
        }

        //override ShowAge with Console.WriteLine("Age is rivate");      

        public override void ShowAge()
        {
            Console.WriteLine("Age is private");
        }
    }
}
