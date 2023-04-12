using System;


class Program
{
    static void Main(string[] args)
    {
        bool participacion = true;
        int numeroAleatorio;

        //Se genera un número aleatorio y al finalizar el juego se le pregunta al usuario si quiere
        //volver a participar.
        while(participacion)
        {
            Random rand = new Random();
            numeroAleatorio = rand.Next(101);
            Console.WriteLine("Intente adivinar el número entre 0 y 100 en 4 intentos.");
            adivinarNumero();
            Console.WriteLine("¿Quieres volver a participar? Pulsa 1 para aceptar y 2 para salir.");
            int salir = int.Parse(Console.ReadLine());
            if(salir == 2)
            {
                participacion = false;
            }

        }

        //Método que pide un número al usuario y le da 4 intentos para acertar el numero aleatorio,
        //en el caso de quedar a en un rango 10, se le informará mediante un mensaje.
        void adivinarNumero()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Intento {i + 1}:  ");
                try
                {
                    int numeroUsuario = int.Parse(Console.ReadLine());

                if (numeroUsuario == numeroAleatorio)
                {
                    Console.WriteLine("Felicidades, has acertado.");
                    return;
                }
                else if (numeroUsuario > numeroAleatorio + 10 || numeroUsuario < numeroAleatorio - 10)
                {
                    Console.WriteLine("Estás bastante alejado del número.");
                }
                else if (numeroUsuario > numeroAleatorio || numeroUsuario < numeroAleatorio)
                {
                    Console.WriteLine("Estás en un rango de 10 del número.");
                }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Introduce un número entero.\n" + ex.Message);
                }
            }
            Console.WriteLine($"Lo sentimos, el numero aletario era {numeroAleatorio}.");
        }
    }
}
