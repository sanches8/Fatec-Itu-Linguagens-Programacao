using System;

class Program
{
    static void Main()
    {
        float a1, a2, a3;

        Console.WriteLine("Insira o primeiro ângulo: ");
        a1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Insira o segundo ângulo: ");
        a2 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Insira o terceiro ângulo: ");
        a3 = Convert.ToSingle(Console.ReadLine());

        if (a1 + a2 + a3 == 180)
        {
            if (a1 == 90 || a2 == 90 || a3 == 90)
            {
                Console.WriteLine("O triângulo com os ângulos internos: " + a1 + ", " + a2 + ", " + a3 + " é um triângulo retângulo");
            }
            else if (a1 > 90 || a2 > 90 || a3 > 90)
            {
                Console.WriteLine("O triângulo com os ângulos internos: " + a1 + ", " + a2 + ", " + a3 + " é um triângulo obtusângulo");
            }
            else
            {
                Console.WriteLine("O triângulo com os ângulos internos: " + a1 + ", " + a2 + ", " + a3 + " é um triângulo acutângulo");
            }
        }
        else
        {
            Console.WriteLine("Os valores " + a1 + ", " + a2 + " e " + a3 + " não podem ser os ângulos internos de um triângulo, pois a soma entre eles é diferente de 180 graus");
        }
    }
}
