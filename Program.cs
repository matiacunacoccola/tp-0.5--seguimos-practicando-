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
                    Console.Write("DNI del alumno a agregar: ");
                    int dni = int.Parse(Console.ReadLine());

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Alumno nuevo = new Alumno(dni, nombre);
                    curso.AgregarAlumno(nuevo);
                    break;

                case 2:
                    Console.Write("DNI a buscar: ");
                    int dniBuscar = int.Parse(Console.ReadLine());

                    Alumno encontrado = curso.BuscarAlumno(dniBuscar);

                    if (encontrado != null)
                        encontrado.Mostrar();
                    else
                        Console.WriteLine("No encontrado");
                    break;

                case 3:
                    Console.Write("DNI: ");
                    int dniFalta = int.Parse(Console.ReadLine());

                    Alumno alumno = curso.BuscarAlumno(dniFalta);

                    if (alumno != null)
                    {
                        Console.Write("Ingrese falta (1 o 0.5): ");
                        double falta = double.Parse(Console.ReadLine());

                        alumno.AgregarFalta(falta);
                    }
                    else
                    {
                        Console.WriteLine("Alumno no encontrado");
                    }
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
}



