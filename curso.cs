public class Curso
{
    public List<Alumno> alumnos = new List<Alumno>();


    public void AgregarAlumno(Alumno alumno)
{
    if (BuscarAlumno(alumno.DNI) == null)
    {
        alumnos.Add(alumno);
        Console.WriteLine("Alumno agregado correctamente.");
    }
    else
    {
        Console.WriteLine("Error. ya existe un alumno con ese DNI.");
    }
}


    public Alumno BuscarAlumno(int dni)
    {
        foreach (Alumno a in alumnos)
        {
            if (a.DNI == dni)
                return a;
        }
        return null;
    }


    public void MostrarAlumnos()
    {
        foreach (Alumno a in alumnos)
        {
            a.Mostrar();
        }
    }


    public void MostrarLibres()
    {
        foreach (Alumno a in alumnos)
        {
            if (a.CantidadFaltas > 15)
            {
                a.Mostrar();
            }
        }
    }
}

