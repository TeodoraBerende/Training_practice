namespace BasicC_part6.Abstract
{
    public class Cat : Animal
    {
        public override string Sound => "Meow!";

        public override void Move()
        {
            Console.WriteLine("Moving on its paws...");
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Cat class - Eats fish");
        }
    }
}
