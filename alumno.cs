public class Alumno
{
    public int DNI=0;
    public string Nombre="";
    public double CantidadFaltas=0;

    public Alumno(int dni, string nombre)
    {
        DNI = dni;
        Nombre = nombre;
        CantidadFaltas = 0;
    }

    public void AgregarFalta(double falta)
    {
        CantidadFaltas += falta;
    }

    public void Mostrar()
    {
        Console.WriteLine("DNI: " + DNI + "- Nombre: " + Nombre + "- Faltas: " + CantidadFaltas);
    }
}