

string Ejercicio1 (int n){
    string resultado;

    if (n > 0)  {
        resultado = "Es positivo";
        return resultado;
    }
  else if (n==0){
        resultado = "Es 0";
        return resultado;
    }

    else{
        resultado = "es negativo";
        return resultado;

    }
  
}


Console.WriteLine(Ejercicio1(Convert.ToInt32(Console.ReadLine())));



string Ejercicio2(int v)
{
    string resultado;

    if (v > 18)
    {
        resultado = "Puede Ingresar";
        return resultado;
    }
    else if (v == 0)
    {
        resultado = "justo pero puede pasar";
        return resultado;
    }

    else
    {
        resultado = "es menor de edad";
        return resultado;

    }

}

Console.WriteLine(Ejercicio2(Convert.ToInt32(Console.ReadLine())));

string Ejercicio3(string h)
{
    string resultado;

    if (h == "python123")
    {
        resultado = "Contraseña Correcta";
        return resultado;
    }

    else
    {
        resultado = "Contraseña Incorrecta";
        return resultado;
    }
  
    
    }

Console.WriteLine(Ejercicio3(Console.ReadLine()));

