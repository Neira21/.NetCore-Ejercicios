internal class Program
{
    
    private static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al juego del ahorcado!");
        string[] palabras = { "programacion", "computadora", "desarrollo", "software", "depurar" };
        string palabraSecreta = palabras[new Random().Next(0, palabras.Length)].ToLower();
        char[] letrasAdivinadas = new char[palabraSecreta.Length];
        int intentos = 6;
        bool ganador = false;

        for (int i = 0; i < letrasAdivinadas.Length; i++)
        {
            letrasAdivinadas[i] = '_';
        }

        while (intentos > 0 && !ganador)
        {
            Console.WriteLine("\nPalabra: " + string.Join(" ", letrasAdivinadas));
            Console.WriteLine("Intentos restantes: " + intentos);
            Console.Write("Ingresa una letra: ");
            char letra = char.ToLower(Console.ReadKey().KeyChar);
            bool letraAdivinada = false;

            for (int i = 0; i < palabraSecreta.Length; i++)
            {
                if (palabraSecreta[i] == letra)
                {
                    letrasAdivinadas[i] = letra;
                    letraAdivinada = true;
                }
            }

            if (!letraAdivinada)
            {
                intentos--;
                Console.WriteLine("\n¡Letra incorrecta!");
            }

            if (palabraSecreta == new string(letrasAdivinadas))
            {
                ganador = true;
            }
        }

        if (ganador)
        {
            Console.WriteLine("\n¡Felicidades, has ganado! La palabra era: " + palabraSecreta);
        }
        else
        {
            Console.WriteLine("\n¡Has perdido! La palabra era: " + palabraSecreta);
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir.");
        Console.ReadKey();

    }
}