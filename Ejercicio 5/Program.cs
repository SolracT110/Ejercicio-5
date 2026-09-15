//--------------------------------------------------------------------      Encabezado del programa
Console.WriteLine("EJERCICIO_5");
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");
Console.WriteLine();

//--------------------------------------------------------------------      Entradas
double suma = 0;

for (int numero = 1; numero <= 5; numero++)
{
    Console.Write($"Ingrese la calificación {numero}: ");
    double calificacion = Convert.ToDouble(Console.ReadLine());

    suma = suma + calificacion;
}

//--------------------------------------------------------------------      Operaciones
double promedio = suma / 5.0;

//--------------------------------------------------------------------      Salidas
Console.WriteLine();
Console.WriteLine($"El promedio de las tres calificaciones es: {promedio:F2}");
Console.WriteLine();

//--------------------------------------------------------------------      Evaluación por rangos
if (promedio >= 90 && promedio <= 100)
{
    Console.WriteLine("Estatus: Excelente");
}
else if (promedio >= 80 && promedio < 90)
{
    Console.WriteLine("Estatus: Alumno Bueno");
}
else if (promedio >= 70 && promedio < 80)
{
    Console.WriteLine("Estatus: Alumno Regular");
}
else if (promedio >= 60 && promedio < 70)
{
    Console.WriteLine("Estatus: Requiere Apoyo");
}
else if (promedio >= 10 && promedio < 60)
{
    Console.WriteLine("Estatus: Alumno Deficiente");
}
else if (promedio >= 0 && promedio < 10)
{
    Console.WriteLine("Estatus: Baja Definitiva");
}
else
{
    Console.WriteLine("Estatus: Calificación fuera de rango (0 - 100)");
}