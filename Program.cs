// //Alumno: Abel Ignacio Leiva



// using System.Collections.Generic;

void MensajeSalida(string mensaje)
{
    Console.WriteLine("*****************************************************");
    Console.WriteLine($" {mensaje} \n");
    Console.WriteLine("*****************************************************");
}


// //Ejercicio 1
// List<int> calificaciones = [9, 5, 6, 8, 4, 4, 6, 9, 7, 10];

// int total = 0;
// foreach (int calificacion in calificaciones)
// {
//     total += calificacion;

// }
// double promedio = (double)total / calificaciones.Count;
// MensajeSalida($"Ejercicio_1 \n\n Calificaciones: {string.Join(",", calificaciones)}\n Promedio: {promedio:F2}");

// //Ejercicio 2
// List<int> edades = [12, 25, 18, 40, 16, 22, 15, 30, 19, 17, 20, 14, 33, 28, 11, 24, 27, 13, 45, 21];

// int mayores = 0;
// int menores = 0;

// foreach (int edad in edades)
// {
//     if (edad >= 18)
//         mayores++;
//     else menores++;
// }
// MensajeSalida($"Ejercicio_2\n\n Mayores : {mayores}\n Menores: {menores}");

// //Ejercicio 3
// List<string> nombres = ["Lucía", "Leo", "Mateo", "Sofía", "Juan", "Valentina", "Tomás", "Camila", "Agustín", "Martina", "Nicolás"];

// string nombreMasLargo = nombres[0];
// string nombreMasCorto = nombres[0];
// foreach (string nombre in nombres)
// {
//     if (nombre.Length > nombreMasLargo.Length) nombreMasLargo = nombre;
//     if (nombre.Length < nombreMasCorto.Length) nombreMasCorto = nombre;
// }
// MensajeSalida($" Ejercicio_3 \n\n Nombre más largo: {nombreMasLargo} \n Nombre más corto: {nombreMasCorto}");

// //Ejercicio 4
// List<string> listaPlaneada = ["pan", "leche", "cafe"]; ;
// List<string> listaNoPlanificados = [];
// List<string> listaTotalComprados = [];

// while (true)
// {
//     Console.WriteLine("Ingrese el nombre del producto comprado para verificar si esta o no en la lista planificada, o ingrese la palabra fin para salir del programa\n");

//     string ingreso = Console.ReadLine().Trim().ToLower();
//     if (ingreso == "fin") break;

//     if (listaPlaneada.Remove(ingreso)) Console.WriteLine("El producto estaba en la lista y se quitara de ella\n");

//     else { listaNoPlanificados.Add(ingreso); Console.WriteLine("El producto no estaba en lista\n"); }

//     listaTotalComprados.Add(ingreso);
// }
// MensajeSalida($"Productos que no compró: {string.Join(", ", listaPlaneada)}\n Productos comprados de más: {string.Join(", ", listaNoPlanificados)}\n Todos los productos comprados: {string.Join(", ", listaTotalComprados)}");

//Ejercicio 5
// char[,] multiDimensionalArray = new char[5, 5];

// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         int posicion = i * 5 + j + 1;
//         multiDimensionalArray[i, j] = (posicion % 2 == 0) ? 'P' : 'I';
//     }


// }
// int contador = 0;
// string str = "";
// foreach (char item in multiDimensionalArray)
// {
//     str += item + " ";
//     contador++;
//     if (contador % 5 == 0) str += "\n ";
// }

// MensajeSalida(str);

// //Ejercicio 6
// int[,] temperaturas = new int[5, 7];
// string[] dias = ["Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"];
// Random rnd = new Random();


// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 7; j++)
//     {
//         temperaturas[i, j] = rnd.Next(7, 39);
//     }
// }

// string resultado = "Temperaturas del mes:\n\n";

// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 7; j++)
//     {
//         resultado += temperaturas[i, j].ToString("00") + " ";
//     }
//     resultado += "\n";
// }

// resultado += "\n--- Resultados por semana ---\n\n";

// int tempMaxMes = 0;
// int semanaMax = 0;
// int diaMaxMes = 0;


// for (int i = 0; i < 5; i++)
// {
//     int max = temperaturas[i, 0];
//     int min = temperaturas[i, 0];
//     int diaMax = 0;
//     int diaMin = 0;
//     int suma = 0;

//     for (int j = 0; j < 7; j++)
//     {
//         int valor = temperaturas[i, j];
//         suma += valor;

//         if (valor > max) { max = valor; diaMax = j; }
//         if (valor < min) { min = valor; diaMin = j; }

//         if (valor > tempMaxMes)
//         {
//             tempMaxMes = valor;
//             semanaMax = i;
//             diaMaxMes = j;
//         }
//     }

//     double promedio = (double)suma / 7;
//     resultado += $"Semana {i + 1}:\n";
//     resultado += $"  Máxima: {max}°C ({dias[diaMax]})\n";
//     resultado += $"  Mínima: {min}°C ({dias[diaMin]})\n";
//     resultado += $"  Promedio: {promedio:F2}°C\n\n";
// }


// int diaDelMes = semanaMax * 7 + diaMaxMes + 1;
// if (diaDelMes > 31) diaDelMes = 31;

// resultado += $"Temperatura más alta del mes: {tempMaxMes}°C\n";
// resultado += $"Día: {dias[diaMaxMes]} {diaDelMes} de mayo";

// MensajeSalida(resultado);

//Ejercicio 7
// int[,] tabla = new int[10, 10];

// for (int i = 0; i < 10; i++)
// {
//     tabla[0, i] = i;
//     tabla[i, 0] = i;
// }

// for (int i = 1; i < 10; i++)
// {
//     for (int j = 1; j < 10; j++)
//     {
//         tabla[i, j] = tabla[i, 0] * tabla[0, j];
//     }
// }

// string tablaCompleta = "Tablas del 1 al 9:\n\n";
// for (int i = 0; i < 10; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         tablaCompleta += tabla[i, j].ToString("00") + " ";
//     }
//     tablaCompleta += "\n";
// }

// MensajeSalida(tablaCompleta);

// //Ejercicio 8
// char[,] matriz = new char[10, 10];
// Random random = new Random();
// int cantidadX = random.Next(10, 51);
// int aciertos = 0;
// int fallos = 0;

// for (int i = 0; i < 10; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         matriz[i, j] = '*';
//     }
// }

// for (int i = 0; i < cantidadX; i++)
// {
//     int f, c;
//     do
//     {
//         f = random.Next(10);
//         c = random.Next(10);
//     } while (matriz[f, c] == 'X');
//     matriz[f, c] = 'X';
// }

// MensajeSalida($"Se escondieron {cantidadX} X en la matriz. Tenes 3 intentos para fallar.\n");

// while (aciertos < cantidadX && fallos < 3)
// {
//     Console.Write("Fila (0-9): ");
//     int fila = int.Parse(Console.ReadLine());
//     Console.Write("Columna (0-9): ");
//     int col = int.Parse(Console.ReadLine());

//     if (fila < 0 || fila > 9 || col < 0 || col > 9)
//     {
//         Console.WriteLine("Fuera de rango, proba de nuevo.\n");
//         continue;
//     }

//     if (matriz[fila, col] == 'X')
//     {
//         Console.WriteLine("Acertaste una X!\n");
//         aciertos++;
//         matriz[fila, col] = 'A';
//     }
//     else
//     {
//         Console.WriteLine("Fallaste...\n");
//         fallos++;
//     }
// }

// MensajeSalida("\nJuego terminado. Mostrando la matriz final:\n");

// for (int i = 0; i < 10; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         if (matriz[i, j] == 'A' || matriz[i, j] == 'X')
//             Console.Write("X ");
//         else
//             Console.Write("* ");
//     }
//     Console.WriteLine();
// }

// MensajeSalida($"\nAciertos: {aciertos} - Fallos: {fallos}");

//Ejercicio 9
//Ejercicio 9
Dictionary<string, double> calificaciones = new Dictionary<string, double>();

while (true)
{
    Console.WriteLine("Ingrese nombre de alumno (o fin para terminar):");
    string alumno = Console.ReadLine().Trim();
    if (alumno.ToLower() == "fin") break;

    Console.WriteLine("Ingrese la nota:");
    string input = Console.ReadLine();
    double nota;
    if (double.TryParse(input, out nota))
    {
        calificaciones.Add(alumno, nota);
    }
    else
    {
        Console.WriteLine("Nota invalida, intente de nuevo");
    }
}

if (calificaciones.Count > 0)
{
    double suma = 0;
    string mejorAlumno = "", peorAlumno = "";
    double mejorNota = double.MinValue, peorNota = double.MaxValue;

    foreach (var item in calificaciones)
    {
        suma += item.Value;
        if (item.Value > mejorNota)
        {
            mejorNota = item.Value;
            mejorAlumno = item.Key;
        }
        if (item.Value < peorNota)
        {
            peorNota = item.Value;
            peorAlumno = item.Key;
        }
    }

    double promedio = suma / calificaciones.Count;
    MensajeSalida($"Promedio general: {promedio:F2}\nMejor nota: {mejorAlumno} ({mejorNota})\nPeor nota: {peorAlumno} ({peorNota})");
}
else
{
    MensajeSalida("No se ingresaron alumnos");
}
