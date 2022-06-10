//1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
//2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
//3) Declarar un vector de tipo double llamado promedios
//4) Recorrer la matriz para su carga con elementos de tipo int
//5) Recorrer la matriz para mostrar cada valor de la matriz
//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
//7) Mostrar los promedios recorriendo el vector promedios


Console.WriteLine("Ingrese cantidad de filas: ");
int filas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese cantidad de columnas: ");
int columnas = int.Parse(Console.ReadLine());

int[,] numeros = new int[filas, columnas];
double[] promedios = new double[columnas];

int cantFilas = numeros.GetUpperBound(0) + 1;
int cantColumnas = numeros.GetUpperBound(1) + 1;

//ingreso de datos y cálculo de promedio
for (int columna = 0; columna < cantColumnas; columna++)
{
    Console.WriteLine($"\nColumna nº {columna + 1}:");

    for (int fila = 0; fila < cantFilas; fila++)
    {
        Console.WriteLine($"Ingrese el número en la fila nº {fila + 1}:");
        numeros[fila,columna] = int.Parse(Console.ReadLine());
        promedios[columna] += numeros[fila,columna];
    }
    promedios[columna] /= cantFilas;
}

//muestro matriz cargada en consola
Console.Write("\n----------------------------------\nMatriz resultante");
for (int fila = 0; fila < cantFilas; fila++)
{
    Console.WriteLine();
    for (int columna = 0; columna < cantColumnas; columna++)
    {
        Console.Write($" {numeros[fila,columna]} -");   
    }
}

//muestro promedios
Console.Write("\n----------------------------------\nPromedios:\n");
for (int columna = 0; columna < promedios.Length; columna++)
{
    Console.Write($" {String.Format("{0:0.##}", promedios[columna])} -");
}
Console.WriteLine();
