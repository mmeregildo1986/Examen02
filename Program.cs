//Examen 01

using System.Security.Cryptography;

string FuncionPositivoNegativo(int numero)
{
    string numeroPN ="";
    if (numero > 0)
    {
        numeroPN = "POSITIVO";
    }
    else if (numero < 0)
    {
        numeroPN = "NEGATIVO";
       
    }
    return numeroPN;

    }

void DiaSemana()
{
    int dia = 0;
    Console.WriteLine("Ingresa el dia de la semana");
    dia = int.Parse(Console.ReadLine());

    switch (dia)
    {
        case 1:
            Console.WriteLine("El dia de la semana es LUNES");
            break;
        case 2:
            Console.WriteLine("El dia de la semana es MARTES");
            break;
        case 3:
            Console.WriteLine("El dia de la semana es MIERCOLES");
            break;
        case 4:
            Console.WriteLine("El dia de la semana es JUEVES");
            break;
        case 5:
            Console.WriteLine("El dia de la semana es VIERNES");
            break;
        case 6:
            Console.WriteLine("El dia de la semana es SABADO");
            break;
        case 7:
            Console.WriteLine("El dia de la semana es DOMINGO");
            break;
        default:
            break;
    }

}

int Suma100()
{
    int sumar = 100;
    int suma = 0;
    for (int i = 1; i <= sumar; i++)
    {
        suma = suma + i;
    }

    return suma;

}

void Imprimirnumero()
{
    int valor = 0;
    Console.WriteLine("Ingresa un numero =>>");
    valor = int.Parse(Console.ReadLine());

    for (int i = 1; i <= valor; i++)
    {
        Console.WriteLine("numero ==> "+i);
        
    }

}

double CalcularAreaRadio() 
{
    
}

Console.WriteLine("===Examen 01===");

int opcion = 0;

do
{
    Console.WriteLine("Ingresa una de las siguientes opciones:");
    Console.WriteLine("1) Numero Ingresado es positivo o negativo");
    Console.WriteLine("2) Imprimir dia de la semana segun numero Ingresado");
    Console.WriteLine("3) Suma de los primeros 100 numeros naturales");
    Console.WriteLine("4) Imprimir todos los numeros del 1 hasta el ingresado");
    Console.WriteLine("5) Calcular área de circulo utilizando el radio ingresado");
    Console.WriteLine("6) Mostrar elementos de un arreglo unidimensional");
    Console.WriteLine("7) Mostar nombres de personas almacenados en una lista");
    Console.WriteLine("8) Salir");
    Console.WriteLine("=====>");
    opcion = int.Parse(Console.ReadLine().ToUpper());

    if (opcion==8)
    {
        Console.WriteLine("Salio del Sistema");
        break;
    }

    switch (opcion)
    {
            
        case 1:
            int numero = 0;
            Console.WriteLine("Ingresa un numero Positivo o Negativo");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero: " + numero + " es " + FuncionPositivoNegativo(numero));

            break;
        case 2:
            DiaSemana();

            break;
        case 3:
            Console.WriteLine("La suma de los 100 primeros numeros naturales es:  " + Suma100()); 
            break;
        case 4:
            Imprimirnumero();
            break;
        case 5:
            Console.WriteLine("Buenas noches hasta mañana");
            break;
        case 6:
            Console.WriteLine("Buenas noches hasta mañana");
            break;
        case 7:
            Console.WriteLine("Buenas noches hasta mañana");
            break;
        default:
            break;
    }
    Console.WriteLine("==============");
    Console.WriteLine("==============");

} while ( opcion != 8);

Console.ReadLine();