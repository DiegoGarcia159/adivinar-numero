using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adivinar_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroAleatorio = GenerarNumeroAleatorio();
            int intentos = 0;
            bool adivinado = false;


            Console.WriteLine("¡Bienvenido al juego Adivina el número!");
            Console.WriteLine("Tienes 5 intentos para adivinar un número entre 1 y 99.");


            while (intentos < 5 && !adivinado)
            {
                intentos++;
                int numeroUsuario = PedirNumero();

                adivinado = EvaluarNumero(numeroUsuario, numeroAleatorio);
            }

            MostrarResultado(adivinado, numeroAleatorio, intentos);
            Console.ReadKey();
        }

        static int GenerarNumeroAleatorio()
        {
            Random random = new Random();
            return random.Next(1, 99);
        }

        static int PedirNumero()
        {
            Console.WriteLine("Introduce un número: ");
            return int.Parse(Console.ReadLine());
        }

        static bool EvaluarNumero(int numeroUsuario, int numeroAleatorio)
        {
            if (numeroUsuario == numeroAleatorio)
            {
                Console.WriteLine("¡Felicidades! Has adivinado el número.");
                return true;
            }
            else if (numeroUsuario > numeroAleatorio)
            {
                Console.WriteLine("El número es más bajo.");
            }
            else
            {
                Console.WriteLine("El número es más alto.");
            }

            return false;
        }

        static void MostrarResultado(bool adivinado, int numeroAleatorio, int intentos)
        {
            if (adivinado)
            {
                Console.WriteLine("¡Has adivinado el número en {0} intentos!", intentos);
            }
            else
            {
                Console.WriteLine("Lo siento, no has adivinado el número. El número era {0}.", numeroAleatorio);
            }
        }
    }
}
