using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Diferencias en precisión entre float y double

            float acumA = 0;
            float divideA = 7;
            for (float numA = 1; numA <= 100000; numA++) {
                acumA += 1 / divideA;
            }

            double acumB = 0;
            double divideB = 7;
            for (double numB = 1; numB <= 100000; numB++) {
                acumB += 1 / divideB;
            }

            Console.WriteLine("Resultados: " + acumA.ToString() + " y " + acumB.ToString());
            Console.ReadKey();
        }
    }
}
