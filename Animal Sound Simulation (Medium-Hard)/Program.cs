namespace Animal_Sound_Simulation__Medium_Hard_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Losi");
            cat.MakeSound();
            Dog dog = new Dog("Wax");
            dog.MakeSound();
            Cow cow = new Cow("May");
            cow.MakeSound();

        }
    }
    public abstract class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void MakeSound();
    }
    class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine(Name + ",it sound is : Woof!");
        }
    }
    class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine(Name + ",it sound is : Meow");
        }
    }
    class Cow : Animal
    {
        public Cow(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine(Name + ",it sound is : Moo!");
        }
    }
}
