internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int numero = 0;
        bool esNumero = false;
        Console.WriteLine("Ingrese un número");
        while(!esNumero){
            esNumero = int.TryParse(Console.ReadLine(), out numero);
        }
        if (numero % 2 == 0)
        {
            Console.WriteLine("El número " + numero + " es par");
        }
        else
        {
            Console.WriteLine("El número " + numero + " es impar");
        }
    }
}