using System;

namespace TestIntuition
{
    public abstract class Vehicle
    {
        public abstract void WriteIn();
    }

    public class Car : Vehicle
    {
        public override void WriteIn()
        {
            Console.WriteLine("some logic here");
        }
    }

    public class Truck : Vehicle
    {
        public override void WriteIn()
        {
            Console.WriteLine("something else here");
        }
    }

    public class Train : Vehicle
    {
        public override void WriteIn()
        {
            Console.WriteLine("of course I need more than just Writeln");
        }
    }

}
