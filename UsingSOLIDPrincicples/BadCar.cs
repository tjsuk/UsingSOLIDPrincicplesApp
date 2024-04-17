namespace UsingSOLIDPrincicples;

public class BadCar
{
    // Set some rules and logic to the car class
}

public class PetrolCar : BadCar
{
    private PetrolEngine engine = new PetrolEngine();
}

public class ElectricCar : BadCar
{
    private ElectricEngine engine = new ElectricEngine();
}

public class PetrolEngine : IEngine
{
    int litreEngine = 0;

    public void Start()
    {
        Console.WriteLine("Produces CO2!");
    }
}

public class ElectricEngine : IEngine
{
    double range = 0;

    public void Start()
    {
        Console.WriteLine("Too quiet to hear!");
    }
}

public interface IEngine
{
    void Start();
}