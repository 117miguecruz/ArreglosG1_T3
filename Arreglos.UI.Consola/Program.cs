using Arreglos.Logica;

Console.WriteLine("Arreglo\n");

MiArreglo oMiArreglo = new MiArreglo(5);

try
{
    oMiArreglo.Agregar(7);
    oMiArreglo.Agregar(-2);
    oMiArreglo.Agregar(8);

    Console.WriteLine(oMiArreglo);
    Console.WriteLine("\nInsertar el 500 en la posición 1\n");
    Console.ReadKey();
    oMiArreglo.Insertar(500, 1);
    Console.WriteLine(oMiArreglo);

    Console.WriteLine("\nEliminar el 500 en la posición 1\n");
    Console.ReadKey();
    oMiArreglo.Eliminar(1);
    Console.WriteLine(oMiArreglo);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


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
