//EJERCICIO #1

System.Console.Write("digite un numero: ");
int numeroTabla = Convert.ToInt32(Console.ReadLine());

for (int n = 1; n <= 10; n++)
{
    System.Console.WriteLine($"{numeroTabla} * {n} = {numeroTabla * n}");
}

//NOTA LA i LA CAMBIE POR UNA n YA QUE VOLVI A UTILIZARLA EN EL EJERCICIO #5 Y NO ME FIJE :)


//EJERCICIO #2

System.Console.Write("digite el numero elevado: ");
int numeroElevado = Convert.ToInt32(Console.ReadLine());

System.Console.Write("digite la potencia: ");
int numeroPotencia = Convert.ToInt32(Console.ReadLine());

double potencia = Math.Pow(numeroElevado, numeroPotencia); 

System.Console.WriteLine($"La potencia del numero es: {potencia}");

// EJERCICIO #5


    int edad,edadMenor, edadMayor = 0, suma = 0, i = 0;
    float promedio;
    System.Console.WriteLine("INGRESE 0 PARA TERMINAR EL CICLO");
    System.Console.Write("Ingrese la edad de la persona: ");
    edad = Convert.ToInt32(Console.ReadLine());
    edadMenor = edad;

    while (edad > 0) {

      suma +=  edad;

      i++;

      if (edad > edadMayor)

        edadMayor = edad;

      if (edad <edadMenor)

        edadMenor = edad;

      Console.Write("\nIngrese la edad de la persona: ");

      edad = Convert.ToInt32(Console.ReadLine());

    }

    promedio = (suma) /i;

    Console.WriteLine($"La edad mayor es {edadMayor}");

    Console.WriteLine($"La edad menor es {edadMenor}");

    Console.WriteLine($"El promedio es {promedio}");

 

  



    