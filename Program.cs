// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Curso curso = new Curso();
        int opcion;

        do
        {
            Console.WriteLine("\n1- Agregar alumno");
            Console.WriteLine("2- Buscar alumno");
            Console.WriteLine("3- Agregar falta");
            Console.WriteLine("4- Mostrar alumnos");
            Console.WriteLine("5- Mostrar libres");
            Console.WriteLine("0- Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    int dni = PedirInt("DNI del alumno a agregar: ");
                    string nombre = PedirString("Nombre: ");

                    Alumno nuevo = new Alumno(dni, nombre);
                    curso.AgregarAlumno(nuevo);
                    break;

                case 2:
                    int dniBuscar = PedirInt("DNI a buscar: ");

                    Alumno encontrado = curso.BuscarAlumno(dniBuscar);

                    if (encontrado != null)
                        Console.WriteLine(encontrado.Mostrar());
                    else
                        Console.WriteLine("No encontrado");
                    break;

                case 3:
                    int dniFalta = PedirInt("DNI: ");
                    double falta = PedirDouble("Ingrese falta (1 o 0.5): ");

                    curso.AgregarFalta(dniFalta, falta);
                    break;

                case 4:
                    curso.MostrarAlumnos();
                    break;

                case 5:
                    curso.MostrarLibres();
                    break;
            }

        } while (opcion != 0);
    }


    static int PedirInt(string mensaje)
    {
        Console.Write(mensaje);
        return int.Parse(Console.ReadLine());
    }

    static string PedirString(string mensaje)
    {
        Console.Write(mensaje);
        return Console.ReadLine();
    }

    static double PedirDouble(string mensaje)
    {
        Console.Write(mensaje);
        return double.Parse(Console.ReadLine());
    }
}
