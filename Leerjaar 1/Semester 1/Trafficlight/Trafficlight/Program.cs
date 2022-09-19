using System;

namespace Trafficlight
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
