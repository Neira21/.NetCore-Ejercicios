internal class Program
{
    //Método leer número
    public static int leerNumero(){
        int numero = 0;
        bool esNumero = false;
        Console.WriteLine("Ingrese un numero");
        while(!esNumero){
            esNumero = int.TryParse(Console.ReadLine(), out numero);
            //La variable esNumero retorna true si el valor ingresado es un número
            //El método tryparse es el encargado de convertir el valor ingresado a un número
            if(!esNumero){
                Console.WriteLine("Ingrese un numero valido");
            }
        }
        return numero;
    }

    public static string esPrimo(){
        int numero = leerNumero();
        int contador = 0;
        for(int i = 1; i <= numero; i++){
            if(numero % i == 0){
                contador++;
            }
        }
        if(contador == 2){
            return "Es primo";
        }else{
            return "No es primo";
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Iniciando Programa");
        Console.WriteLine(esPrimo());
    }
}