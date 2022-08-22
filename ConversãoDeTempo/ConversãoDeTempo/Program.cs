using System;

namespace ConversãoDeTempo {
    class Program {
        static void Main(string[] args) {

            for (int i = 0; i < 3; i++) {

                Console.WriteLine("Digite quantos segundos deseja converter: ");

                int N, segundos, minutos, horas, sobra;

                N = int.Parse(Console.ReadLine());

                horas = N / 3600;
                sobra = N % 3600;
                minutos = sobra / 60;
                segundos = sobra % 60;

                Console.WriteLine(horas + ":" + minutos + ":" + segundos);
            }
        }
    }
}
