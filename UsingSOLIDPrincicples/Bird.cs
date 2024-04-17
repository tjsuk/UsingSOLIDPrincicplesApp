namespace UsingSOLIDPrincicples;

public interface IFlyable
{
    void Fly();
}

public interface ISwim
{
    void Swim();
}

public class Bird : IFlyable
{
    public virtual void Fly()
    {
        Console.WriteLine("Hey, I'm flying!");
    }
}

public class Penguin : ISwim
{
    public void Swim()
    {
        Console.WriteLine("I can't fly, but I can out swim you!");
    }
}
