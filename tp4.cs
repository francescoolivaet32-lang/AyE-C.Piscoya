
//ejercicio 1
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("ejercicio1");
string contraseña = "pedo";
string h = "_";
Console.WriteLine("ingrese la contraseña");

while ( h != contraseña)
{
    if ( h == "_")
    {

    }
    else
    {
        Console.WriteLine("intentelo de nuevo");
    }
    h = Console.ReadLine();
}
Console.WriteLine("ENTRANDO");

// ejericio 2


for (int e = 5; e >= 1; e--)
{

    Console.WriteLine(e);

    Console.WriteLine("¡Listo para despegar");

    
}

Console.WriteLine("despegue!");

//ejercicio 3

Console.WriteLine("ejercicio2");
string numero = "7";
string r = "_";
Console.WriteLine("ingrese la contraseña");

while (r != numero)
{
    if (r == "_")
    {

    }
    else
    {
        Console.WriteLine("intentelo de nuevo");
    }
    r = Console.ReadLine();
}
Console.WriteLine("¡Felicidades! Adivinaste el número");

//ejercicio 4
Console.WriteLine("ejercicio4");
int suma = 0;
int numer = 1;
while ( numer != 0)
{
    Console.WriteLine("ingrese los numeros a sumar, con 0 se termina la suma");
    numer = Convert.ToInt32(Console.ReadLine());
    suma += numer;
}
Console.WriteLine("la suma es: ");
Console.WriteLine(suma);