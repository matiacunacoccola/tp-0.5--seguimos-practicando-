public class Curso
{
    private Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        if (!alumnos.ContainsKey(alumno.GetDNI()))
        {
            alumnos.Add(alumno.GetDNI(), alumno);
            Console.WriteLine("Alumno agregado correctamente.");
        }
        else
        {
            Console.WriteLine("Error. Ya existe un alumno con ese DNI.");
        }
    }

    public Alumno BuscarAlumno(int dni)
    {
        if (alumnos.ContainsKey(dni))
            return alumnos[dni];

        return null;
    }

    
    public void AgregarFalta(int dni, double falta)
    {
        Alumno alumno = BuscarAlumno(dni);

        if (alumno != null)
        {
            alumno.AgregarFalta(falta);
        }
        else
        {
            Console.WriteLine("Alumno no encontrado");
        }
    }

    public void MostrarAlumnos()
    {
        foreach (Alumno a in alumnos.Values)
        {
            Console.WriteLine(a.Mostrar());
        }
    }

    public void MostrarLibres()
    {
        foreach (Alumno a in alumnos.Values)
        {
            if (a.GetFaltas() > 15)
            {
                Console.WriteLine(a.Mostrar());
            }
        }
    }
}

