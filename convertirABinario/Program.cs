// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int validarNumero(){
    int numero = 0;
    bool esNumero = false;
    Console.WriteLine("Ingrese un número");
    while(!esNumero){
        esNumero = int.TryParse(Console.ReadLine(), out numero);
        if(!esNumero){
            Console.WriteLine("Ingrese un número válido");
        }
    }
    return numero;
}

int numero = validarNumero();

string convertirABinario(int numero){
    string numeroBinario=string.Empty;
    
    while(numero > 0){
        numeroBinario = (numero % 2).ToString() + numeroBinario;
        numero = numero / 2;
        
    }
    
    return numeroBinario;
}

Console.WriteLine("El número " + numero + " en binario es " + convertirABinario(numero));


