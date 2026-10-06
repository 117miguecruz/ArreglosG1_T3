using Arreglos.Logica;

Console.WriteLine("Arreglo\n");

MiArreglo oMiArreglo = new MiArreglo(5);

try
{
    oMiArreglo.Agregar(7);
    oMiArreglo.Agregar(-2);
    Console.WriteLine(oMiArreglo);

    Console.ReadKey();
    oMiArreglo.Insertar(500, 20);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine(oMiArreglo);

//Console.WriteLine("Arreglo\n");
//MiArreglo oMiArreglo = new MiArreglo(100);
//oMiArreglo.Llenar(1, 20);

//Console.WriteLine("Arreglo desordenado\n");
//Console.WriteLine(oMiArreglo);

//Console.WriteLine("Arreglo ordenado de forma ascendente\n");
//oMiArreglo.Ordenar();
//Console.WriteLine(oMiArreglo);
//Console.WriteLine("Arreglo ordenado de forma descendente\n");
//oMiArreglo.Ordenar(false);
//Console.WriteLine(oMiArreglo);

Console.ReadKey();
