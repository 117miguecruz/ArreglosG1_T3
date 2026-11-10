using Arreglos.Logica;

Console.WriteLine("Arreglo\n");

MiArreglo oMyArreglo = new MiArreglo(100);

try
{
    Console.WriteLine("\nArreglo\n");
    oMyArreglo.Llenar();
    Console.WriteLine(oMyArreglo);
    Console.ReadKey();

    Console.WriteLine("\nPares\n");
    var verPares = oMyArreglo.ObtenerPares();
    Console.WriteLine(verPares);
    Console.ReadKey();

    Console.WriteLine("\nPares ordenados\n");
    verPares.Ordenar(true);
    Console.WriteLine(verPares);
    Console.ReadKey();

    Console.WriteLine("\nPrimos\n");
    var verPrimos = oMyArreglo.ObtenerPrimos();
    Console.WriteLine(verPrimos);
    Console.ReadKey();

    Console.WriteLine("\nPrimos ordenados\n");
    verPrimos.Ordenar(true);
    Console.WriteLine(verPrimos);
    Console.ReadKey();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


//try
//{
//    oMiArreglo.Agregar(7);
//    oMiArreglo.Agregar(-2);
//    oMiArreglo.Agregar(8);

//    Console.WriteLine(oMiArreglo);
//    Console.WriteLine("\nInsertar el 500 en la posición 1\n");
//    Console.ReadKey();
//    oMiArreglo.Insertar(500, 1);
//    Console.WriteLine(oMiArreglo);

//    Console.WriteLine("\nEliminar el 500 en la posición 1\n");
//    Console.ReadKey();
//    oMiArreglo.Eliminar(1);
//    Console.WriteLine(oMiArreglo);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


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
