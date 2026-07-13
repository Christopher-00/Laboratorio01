using System;

namespace RegistroEstudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_MATERIAS = 6;
            Console.WriteLine("==============================");
            Console.WriteLine("--- Registro de Estudiante ---");
            Console.WriteLine("==============================");
            Console.WriteLine("");

            Console.Write("Nombre completo:");
            string nombre = Console.ReadLine();

            Console.Write("Edad:");
            int edad = int.Parse(Console.ReadLine()); 

            Console.Write("Carrera:");
            string carrera = Console.ReadLine();

            Console.Write("Carné o código de estudiante:");
            string carne = Console.ReadLine();

            Console.Write("Correo electrónico:");
            string correo = Console.ReadLine();

            Console.Write("Número de teléfono:");
            string telefono = Console.ReadLine();

            Console.Write("Promedio actual:");
            double promedio = double.Parse(Console.ReadLine());

            Console.Write("Número de materias inscritas:");
            int materiasInscritas = int.Parse(Console.ReadLine());


            int edadFutura = edad + 5; 
            bool puedeInscribir = materiasInscritas < MAX_MATERIAS;

            Console.WriteLine("-------------------------");
            Console.WriteLine("\nREGISTRO DEL ESTUDIANTE");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            Console.WriteLine($"Bienvenido(a), {nombre}");
            Console.WriteLine("");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Edad dentro de 5 años: {edadFutura} años");
            Console.WriteLine("");
            Console.WriteLine($"Carrera: {carrera}");
            Console.WriteLine($"Carné: {carne}");
            Console.WriteLine($"Correo: {correo}");
            Console.WriteLine($"Teléfono: {telefono}");
            Console.WriteLine("");
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Materias inscritas: {materiasInscritas}");
            Console.WriteLine($"Máximo permitido: {MAX_MATERIAS}");
            Console.WriteLine($"Puede inscribir más materias: {(puedeInscribir ? "Si" : "No")}");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Gracias por utilizar el sistema.");
            Console.WriteLine("--------------------------------");
            Console.ReadKey();
        }
    }
}