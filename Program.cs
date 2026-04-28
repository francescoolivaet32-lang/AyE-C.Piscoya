string Ejercicio1(int i)
{
    string resultado;
    if (i > 0)
    {
        resultado = "es positivo";
        return resultado;
    }
    else if (i < 0)
    {
        resultado = "es negativo";
        return resultado;
    }
    else
    {
        resultado = "es igual a 0";
        return resultado;
    }

}}


string Ejercicio2(int edad)
{
    string fiesta;
    if (edad >= 18)
    {
        fiesta = "¡Bienvenido a la fiesta!";
        return fiesta;

    }
    else if (edad >= 0)
    {
        fiesta = "no podes sos joven";
        return fiesta;
    }
    else
    {
        fiesta = "edad no valida";
        return fiesta;
    }

}
string Ejercicio3(string contra)
{
    string clave;
    if (contra == "python123")
    {
        clave = " ¡Contraseña correcta! Acceso concedido.";
        return clave;
    }
    else
    {
        clave = "¡Contraseña incorrecta, Autodestrucción en 5 minutos!";
        return clave;
    }

}

bool seguimos = true;
while (seguimos == true)
{

    Console.WriteLine("1- ejercicio1, 2-ejercicio2 3-ejercicio3, 4-ejercicio4, 5-ejercicio5");
    int x = Convert.ToInt32(Console.ReadLine());


    switch (x)
    {
        case 1:
            Console.WriteLine("Escribime un numero y te digo si es positivo");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Ejercicio1(a));
            break;

        case 2:
            Console.WriteLine("vamos a ver si pasas a la fiesta segun tu edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Ejercicio2(edad));
            break;

        case 3:
            Console.WriteLine("ingrese la contraseña");
            string contraseña = Convert.ToString(Console.ReadLine());
            Console.WriteLine(Ejercicio3(contraseña));

            break;
        case 0:
            seguimos = false;
            break;
    }


}
