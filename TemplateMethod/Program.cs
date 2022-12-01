using System;
namespace TemplateMethod;


/// The 'AbstractClass' abstract class

public abstract class AbstractClass
{
    public abstract void PrimitiveOperation1();
    public abstract void PrimitiveOperation2();
    // The "Template method"
    public void TemplateMethod()
    {
        PrimitiveOperation1();
        PrimitiveOperation2();
        Console.WriteLine("");
    }
}


/// A 'ConcreteClass' class

public class ConcreteClassA : AbstractClass
{
    public override void PrimitiveOperation1()
    {
        Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
    }
    public override void PrimitiveOperation2()
    {
        Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
    }
}


/// A 'ConcreteClass' class
public class ConcreteClassB : AbstractClass
{
    public override void PrimitiveOperation1()
    {
        Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
    }
    public override void PrimitiveOperation2()
    {
        Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
    }
}


/// Template Design Pattern
public class Program
{
    public static void Main()
    {
        AbstractClass aA = new ConcreteClassA();
        aA.TemplateMethod();
        AbstractClass aB = new ConcreteClassB();
        aB.TemplateMethod();
        // Wait for user
        Console.ReadKey();
    }
}