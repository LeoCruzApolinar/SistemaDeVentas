namespace SistemaDeVenta
{
    public class Productos
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
    }
    public class Clientes
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Cumpleanos { get; set; }
    }
    public class Empleados
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
    }
    public class Factura
    {
        public string Id { get; set; }
        public string NombreDelCliente { get; set; }
        public string NombreDelEmpleado { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public int Total { get; set; }
        public string FechaDeFacturacion { get; set; }
        public string HoraDeFacturacion { get; set; }

    }
}