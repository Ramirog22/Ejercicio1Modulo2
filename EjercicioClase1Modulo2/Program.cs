//using EjercicioClase1Modulo2.Ejercicio_1;
//using EjercicioClase1Modulo2.Ejercicio_2;
using EjercicioClase1Modulo2.Clases.EJ1;
using EjercicioClase1Modulo2.Clases.EJ2;
using EjercicioClase1Modulo2.Clases.EJ3;
using System.Text.Json;

namespace EjercicioClase1Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio clase 1 modulo 2");
            // Consigna:
            // En la ruta principal del proyecto hay 3 archivos json, para cada uno de ellos crear las clases que consideren necesarias para poder deserializar correctamente
            // Uso: JsonSerializer.Deserialize<ClaseCreada>(data);

            var pathEjercicio1 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio1.json";
            var pathEjercicio2 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio2.json";
            var pathEjercicio3 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio3.json";

            var dataEjercicio1 = File.ReadAllText(pathEjercicio1);
            var dataEjercicio2 = File.ReadAllText(pathEjercicio2);
            var dataEjercicio3 = File.ReadAllText(pathEjercicio3);

            #region Ejercicio 1
            Usuario u = JsonSerializer.Deserialize<Usuario>(dataEjercicio1);

            Console.WriteLine("EJERCICIO 1\nNombre: " + u.Nombre);

            Console.WriteLine("Amigos:");
            foreach (var item in u.Amigos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("El booleano de notificaciones esta en " + u.Notificaciones);
            #endregion

            #region Ejercicio 2
            Estadisticas e = JsonSerializer.Deserialize<Estadisticas>(dataEjercicio2);

            Console.WriteLine("\nEJERCICIO 2:\nLa cantidad de equipos anotados son " + e.equipos.Count);

            foreach (var item in e.equipos)
            {
                Console.WriteLine("El nombre del equipo es " + item.NombreEquipo);

                Console.WriteLine("Sus jugadores son:");
                foreach (var p in item.Jugadores)
                {
                    Console.WriteLine(p.Nombre + " con " + p.Kills + " kills y " + p.Deaths + " deaths.");
                }

                if (item.Campeon) Console.WriteLine("Y salió campeon");
                else Console.WriteLine("No salió campeon");
            }


            #endregion

            #region Ejercicio 3
            Inventario i = JsonSerializer.Deserialize<Inventario>(dataEjercicio3);

            Console.WriteLine("\nEJERCICIO3\nTenemos " + i.Productos.Count + " productos dentro del inventario");

            for (int j = 0; j < i.Productos.Count; j++)
            {
                int n = j + 1;
                Console.WriteLine("\nProducto nro. " + n + ":");
                Console.WriteLine("Nombre: " + i.Productos[j].Nombre);
                Console.WriteLine("Precio: " + i.Productos[j].Precio);
                Console.WriteLine("Existencias: " + i.Productos[j].Existencias);
                Console.WriteLine("Descuento: " + i.Productos[j].TieneDescuento);
                Console.Write("Tags: ");
                foreach (var tag in i.Productos[j].Tags) { Console.Write(tag + ", "); }
                Console.WriteLine("\nPeso: " + i.Productos[j].Detalles.Peso);
                Console.WriteLine("Dimensiones: " + i.Productos[j].Detalles.Dimensiones.Alto + " - "+ i.Productos[j].Detalles.Dimensiones.Ancho + " - " + i.Productos[j].Detalles.Dimensiones.Profundidad);
            }
            #endregion
        }
    }
}