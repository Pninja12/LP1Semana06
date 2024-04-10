using System;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cores
            Color Red = new Color(255, 0, 0);
            Color Green = new Color(0, 255, 0);
            Color Blue = new Color(0, 0, 255);
            Color SemivisibleYellow = new Color(235, 235, 0, 200);
            Color Orange = new Color(255, 165, 0);

            //Bolas
            Sphere bola1 = new Sphere(Red, 10);
            Sphere bola2 = new Sphere(Green, 20);
            Sphere bola3 = new Sphere(Blue, 30);
            Sphere bola4 = new Sphere(SemivisibleYellow, 40);
            Sphere bola5 = new Sphere(Orange, 50);

            //Bolas a bolar
            bola1.Throw();
            bola2.Throw();
            bola3.Pop();
            bola4.Throw();
            bola5.Throw();
            bola1.Throw();
            bola2.Throw();
            bola3.Throw();
            bola4.Throw();
            bola5.Pop();
            bola1.Throw();
            bola2.Pop();
            bola3.Throw();
            bola4.Throw();
            bola5.Throw();

            //Impressão das bolas e as suas características
            Console.WriteLine($"Ball 1: {bola1.GetTimesThrown()}"+
            "\nColor: Red\n");
            Console.WriteLine($"Ball 2: {bola2.GetTimesThrown()}"+
            "\nColor: Green\n");
            Console.WriteLine($"Ball 3: {bola3.GetTimesThrown()}"+
            "\nColor: Blue\n");
            Console.WriteLine($"Ball 4: {bola4.GetTimesThrown()}"+
            "\nColor: SemivisibleYellow\n");
            Console.WriteLine($"Ball 5: {bola5.GetTimesThrown()}"+
            "\nColor: Orange\n");
        }
    }
}
