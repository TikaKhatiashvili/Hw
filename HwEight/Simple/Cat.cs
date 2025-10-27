namespace HwEight.Simple;

public class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine($"Cat meows: Meow!");
    }
}