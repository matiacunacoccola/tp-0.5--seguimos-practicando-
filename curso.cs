public class Curso
{
    public List<Alumno> alumnos = new List<Alumno>();


    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
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

