public class Employee
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string ProyectoActual { get; set; } = string.Empty;
    public List<string> ProyectosAnteriores { get; set; } = new();
    public int TiempoEnLaEmpresa { get; set; } // En años
}

