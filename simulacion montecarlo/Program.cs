//EN ESTE CODIGO VOY A MOSTAR LO QUE ES LA APROXIMACION DE PI CON EL MODELO O METODO DE MONTECARLO

//HICIMOS Y TRATAMOS DE HACER LO MEJOR POSIBLE ING ESPERO CONTAR CON SU APOYO HACIA MI CODIGO MI EZFUERZO Y SACRIFICIO


using System;

namespace MonteCarloPiApproximation
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPoints = 1000000; // Número total de puntos a generar
            int insideCircle = 0;
            Random random = new Random();

            for (int i = 0; i < totalPoints; i++)
            {
                double x = random.NextDouble() * 2 - 1; // Coordenada x aleatoria entre -1 y 1
                double y = random.NextDouble() * 2 - 1; // Coordenada y aleatoria entre -1 y 1

                // Distancia desde el origen
                double distance = Math.Sqrt(x * x + y * y);

                // Si el punto está dentro del círculo (distancia <= 1), lo contamos
                if (distance <= 1)
                {
                    insideCircle++;
                }
            }

            // Aproximación de π utilizando el área del cuadrado y del círculo
            double piApproximation = 4.0 * insideCircle / totalPoints;

            // MOSTRAR LA APROXIMACION DE π
            Console.WriteLine("Valor aproximado de π: " + piApproximation);
            Console.ReadLine(); // Para que la consola no se cierre inmediatamente
        }
    }
}
           // ESTE TRABAJO FUE HECHO POR MARIO ALBERTO CABRERA GIL Y UN ASESOR,
           //ING DISCULPE SI HAY ALGUNOS ERRORES YA QUE ESTE CODIGO NO LO HICE YO COMO TAL , ME AYUDARON EN LA MAYORIA 