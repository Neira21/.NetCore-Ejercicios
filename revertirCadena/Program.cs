// Convertir a mayúsculas toUpper() y a minúsculas toLower()

//Leer una entrada escrita por el usuario con el texto: "Escribe una palabra: "
using System.Text;

string cadena = "Hola Mundo";

//Primera forma para invertir un array
string cadenaVolteada1= "";
for(int i = cadena.Length -1; i>=0 ; i--){
    cadenaVolteada1 += cadena[i];
}
// Console.WriteLine(cadenaVolteada1);

//Segunda forma para invertir un array
char[] array = new char[cadena.Length];
int index = 0;
for (int i = cadena.Length -1 ; i >= 0; i--)
{
    array[index] = cadena[i];
    index++;
}
// Console.WriteLine(array);

//Tercera forma para invertir un array
char[] array2 = cadena.ToCharArray();
Array.Reverse(array2);
// Console.WriteLine(array2);


//Elminar caracteres duplicados
string cadena2 = "This is a string and nothing more than a string";
string result = "";
for(int i=0; i<=cadena2.Length-1; i++){
    if(!result.Contains(cadena2[i])){
        result += cadena2[i];
    }
}
//Console.WriteLine(result);

//Eliminar caracteres duplicados con LINQ
string result2 = new string(cadena2.Distinct().ToArray());
//Console.WriteLine(result2);

//Contar caracteres repetidos en una cadena en un diccionario
string cadena3 = "This is a string and nothing more than a string";
string nuevaCadena = String.Empty;
int contadorS = 0;
string nuevaCadenaMinuscula = cadena3.ToLower();
Dictionary<char, int> diccionario = new Dictionary<char, int>();
//Borrar espacios y borrar las dos primeras s del texto
for(int i=0; i<=cadena3.Length-1; i++){
    if(cadena3[i] == ' ')continue;
    if(cadena3[i] == 'S' || cadena3[i] == 's' && contadorS < 2){
        contadorS++;
        continue;
    }
    nuevaCadena+=cadena3[i];
}
//Console.WriteLine(nuevaCadena);
foreach (var item in nuevaCadenaMinuscula){
    if(item != ' '){
        if(!diccionario.ContainsKey(item)){
            diccionario.Add(item, 1);
        }else
        {
            diccionario[item]++;
        }
    }
}
foreach (var item in diccionario)
{
    //Escribir linea con $ para concatenar variables
    //Console.WriteLine($"El caracter {item.Key} se repite {item.Value} veces");
}

//Encontrar todos los substring consecutivos de una cadena
string cadena4 = "abcd";
for(int i=0; i<=cadena4.Length-1; i++){
    string subCadena = "";
    for(int j=i; j<=cadena4.Length-1; j++){
        subCadena += cadena4[j];
        //Console.WriteLine(subCadena);
    }
}

//Encontrar todos los substring consecutivos mediante stringbuilder
string cadena5 = "abcd";
for(int i=0; i<=cadena5.Length-1; i++){
    StringBuilder substring = new StringBuilder(cadena5.Length-i);
    for(int j=i; j<=cadena5.Length-1; j++){
        substring.Append(cadena5[j]);
        //Console.WriteLine(substring);
    }   
}

//Encontrar todos los substrings de una cadena mediante LINQ
string cadena6 = "abcd";
var subCadenas = from i in Enumerable.Range(0, cadena6.Length)
                 from j in Enumerable.Range(1, cadena6.Length - i)
                 select cadena6.Substring(i, j);

//Console.WriteLine(string.Join(", ", subCadenas));


//Indicar si una cadena es palíndromo
string cadena7 = "abcdedcba";

bool flag = false;

for(int i=0, j=cadena7.Length - 1; i < cadena7.Length/2; i++, j--){
    if(cadena7[i] != cadena7[j]){
        flag = true;
        break;
    }
}
if(flag){
    Console.WriteLine("No es palíndromo");
}else{
    Console.WriteLine("Es palíndromo");
}











