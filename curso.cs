public class Curso
{
      public Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
    
        if (!alumnos.ContainsKey(alumno.DNI))
        {
           
            alumnos.Add(alumno.DNI, alumno); 
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

    public void MostrarAlumnos()
    {
          foreach (Alumno a in alumnos.Values)
        {
            a.Mostrar();
        }
    }

    public void MostrarLibres()
    {
        foreach (Alumno a in alumnos.Values)
        {
            if (a.CantidadFaltas > 15)
            {
                a.Mostrar();
            }
        }
    }
}

