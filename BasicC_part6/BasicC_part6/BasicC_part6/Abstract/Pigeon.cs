
namespace BasicC_part6.Abstract
{
    //Implement Abstract class
    public class Pigeon : Animal
    {
        public override string Sound => "Pigeon Sound";

        public override void Move()
        {
            Console.WriteLine("Flies");
        }
    }
}
