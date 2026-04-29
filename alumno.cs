public class Alumno
{
    private int dni;
    private string nombre;
    private double cantidadFaltas;

    public Alumno(int dni, string nombre)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.cantidadFaltas = 0;
    }

    public void AgregarFalta(double falta)
    {
        cantidadFaltas += falta;
    }

 
    public int GetDNI() { return dni; }
    public string GetNombre() { return nombre; }
    public double GetFaltas() { return cantidadFaltas; }

   
    public string Mostrar()
    {
        return "DNI: " + dni + " - Nombre: " + nombre + " - Faltas: " + cantidadFaltas;
    }
}
