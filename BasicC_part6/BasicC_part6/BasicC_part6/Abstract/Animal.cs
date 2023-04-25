namespace BasicC_part6.Abstract
{
    public abstract class Animal
    {
        public abstract string Sound { get; }
        public  string Name { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("Animal class");
            Console.WriteLine(Sound);
            Console.WriteLine();
        }

        public virtual void Eat()
        {
            Console.WriteLine("Animal class - Eats ...");
        }

        public abstract void Move();
        
    }
}
