
Console.WriteLine(" un numero entero");
int XD = Convert.ToInt32(Console.ReadLine());
bool primo = true;
if (XD <= 1)
{
    primo = false;
    Console.WriteLine("no es primo");
}
else
{
    for (int CAMA = 2; CAMA < XD; CAMA++)
    {
        if (XD % CAMA == 0)
        {
            primo = false;
        }
    }
}
if (primo == true)
{
    Console.WriteLine(XD + " es primo");
}
else
{
    Console.WriteLine(XD + " no es primo");
}

Console.WriteLine("ingrese un numero para generar la factorial");
int MAN = Convert.ToInt32(Console.ReadLine());

int xdD = 1;
for (int SIXSEVEN = 1; SIXSEVEN <= MAN; SIXSEVEN++)
{
    xdD = xdD* SIXSEVEN;
}
Console.WriteLine("el factorial de tu numero es: " + xdD);


Console.WriteLine("ingrese un numero");

int n = Convert.ToInt32(Console.ReadLine());
int fibonacci;
int pt = 0;
int st = 1;

for (int a = 0; a < n; a++)
{
    Console.WriteLine(pt);
    if (st > n)
    {
        break;
    }
    fibonacci = pt;
    pt = st;
    st = fibonacci + pt;
}



Console.WriteLine("menú interactivo");
Console.WriteLine("ingrese 1 para decir hola");
Console.WriteLine("ingrese 2 para decir chau");
Console.WriteLine("ingrese 3 para terminar el programa");

int asd = Convert.ToInt16(Console.ReadLine());
switch (asd)
{
    case 1:
        Console.WriteLine("hola");
        break;
    case 2:
        Console.WriteLine("chau");
        break;
    default:
        break;

}
