using System;

namespace Trafficlight_with_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();

            Console.WriteLine(trafficLight.GetCurrentColor());
            trafficLight.NextState();

            Console.WriteLine(trafficLight.GetCurrentColor());
            trafficLight.NextState();

            Console.WriteLine(trafficLight.GetCurrentColor());
            trafficLight.NextState();

            Console.WriteLine(trafficLight.GetCurrentColor());
        }
    }
}
