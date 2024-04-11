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
            Console.WriteLine($"characterísticas da 1ª bola:");
            Console.WriteLine($"Raio: {bola1.GetRaio()}");
            Console.WriteLine($"Vezes atirada: {bola1.GetTimesThrown()}");
            Console.WriteLine($"Cor: {bola1.GetCor()}\n");
            Console.WriteLine($"characterísticas da 2ª bola:");
            Console.WriteLine($"Raio: {bola2.GetRaio()}");
            Console.WriteLine($"Vezes atirada: {bola2.GetTimesThrown()}");
            Console.WriteLine($"Cor: {bola2.GetCor()}\n");
            Console.WriteLine($"characterísticas da 3ª bola:");
            Console.WriteLine($"Raio: {bola3.GetRaio()}");
            Console.WriteLine($"Vezes atirada: {bola3.GetTimesThrown()}");
            Console.WriteLine($"Cor: {bola3.GetCor()}\n");
            Console.WriteLine($"characterísticas da 4ª bola:");
            Console.WriteLine($"Raio: {bola4.GetRaio()}");
            Console.WriteLine($"Vezes atirada: {bola4.GetTimesThrown()}");
            Console.WriteLine($"Cor: {bola4.GetCor()}\n");
            Console.WriteLine($"characterísticas da 5ª bola:");
            Console.WriteLine($"Raio: {bola5.GetRaio()}");
            Console.WriteLine($"Vezes atirada: {bola5.GetTimesThrown()}");
            Console.WriteLine($"Cor: {bola5.GetCor()}\n");
        }
    }
}
