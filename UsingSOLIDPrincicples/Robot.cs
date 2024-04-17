namespace UsingSOLIDPrincicples;

public interface IWorker
{
    void Work();
}

public interface ICanEat
{
    void Eat();
}

public class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("I can work!");
    }
}

public class Person : IWorker, ICanEat
{
    public void Work()
    {
        Console.WriteLine("I can work!");
    }

    public void Eat()
    {
        Console.WriteLine("I can eat!");
    }
}
