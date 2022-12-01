namespace Strategy;

using System;


#nullable disable


    
    /// Strategy Design Pattern Example1
    
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Context context;
    //        // Three contexts following different strategies
    //        context = new Context(new ConcreteStrategyA());
    //        context.ContextInterface();
    //        context = new Context(new ConcreteStrategyB());
    //        context.ContextInterface();
    //        context = new Context(new ConcreteStrategyC());
    //        context.ContextInterface();
    //        // Wait for user
    //        Console.ReadKey();
    //    }
    //}

    //public abstract class Strategy
    //{
    //    public abstract void AlgorithmInterface();
    //}

    //public class ConcreteStrategyA : Strategy
    //{
    //    public override void AlgorithmInterface()
    //    {
    //        Console.WriteLine(
    //            "Called ConcreteStrategyA.AlgorithmInterface()");
    //    }
    //}


    //public class ConcreteStrategyB : Strategy
    //{
    //    public override void AlgorithmInterface()
    //    {
    //        Console.WriteLine(
    //            "Called ConcreteStrategyB.AlgorithmInterface()");
    //    }


    //public class ConcreteStrategyC : Strategy
    //{
    //    public override void AlgorithmInterface()
    //    {
    //        Console.WriteLine(
    //            "Called ConcreteStrategyC.AlgorithmInterface()");
    //    }
    //}


    //public class Context
    //{
    //    Strategy strategy;
    //    // Constructor
    //    public Context(Strategy strategy)
    //    {
    //        this.strategy = strategy;
    //    }
    //    public void ContextInterface()
    //    {
    //        strategy.AlgorithmInterface();
    //    }
    //}



//Example2


public interface IStrategy
{
    string GetTravelTime(string source, string destination);
}

public class CarStrategy : IStrategy
{
    public string GetTravelTime(string source, string destination)
    {
        return "It takes 40 minutes to reach from " + source + " to " + destination + " using Car.";
    }
}
public class BikeStrategy : IStrategy
{
    public string GetTravelTime(string source, string destination)
    {
        return "It takes 25 minutes to reach from " + source + " to " + destination + " using Bike.";
    }
}
public class BusStrategy : IStrategy
{
    public string GetTravelTime(string source, string destination)
    {
        return "It takes 60 minutes to reach from " + source + " to " + destination + " using Bus.";
    }
}

public class TravelStrategy
{
    private IStrategy _strategy;
    public TravelStrategy(IStrategy chosenStrategy)
    {
        _strategy = chosenStrategy;
    }
    public void GetTravelTime(string source, string destination)
    {
        var result = _strategy.GetTravelTime(source, destination);
        Console.WriteLine(result);
    }
}

class Program
{

    static void Main()
    {
        Console.WriteLine("Hello!, Please select the mode of transport to get the travel time between source and destination: \nCar \nBike \nBus");
        var userStrategy = Console.ReadLine().ToLower();
        Console.WriteLine("\nUser has selected *" + userStrategy + "* as mode of transport\n");
        Console.WriteLine("\n*****************************************************************************************************\n");
        switch (userStrategy)
        {
            case "car":
                new TravelStrategy(new CarStrategy()).GetTravelTime("Point A", "Point B");
                break;
            case "bike":
                new TravelStrategy(new BikeStrategy()).GetTravelTime("Point A", "Point B");
                break;
            case "bus":
                new TravelStrategy(new BusStrategy()).GetTravelTime("Point A", "Point B");
                break;
            default:
                Console.WriteLine("You have chosen an invalid mode of transport.");
                break;
        }
    }
}