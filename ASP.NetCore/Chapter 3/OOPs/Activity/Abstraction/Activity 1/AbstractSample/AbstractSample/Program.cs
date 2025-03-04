namespace AbstractSample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
           dog.AnimalSound();
            dog.Eat();
            cat.AnimalSound();
            cat.Eat();
        }
    }
}
