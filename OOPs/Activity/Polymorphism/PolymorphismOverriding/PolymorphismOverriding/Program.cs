namespace PolymorphismOverriding
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
           cat.MakingSound();
            dog.MakingSound();
        }
    }
}