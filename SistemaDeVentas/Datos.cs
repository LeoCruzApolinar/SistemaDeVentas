namespace SistemaDeVenta
{
    public class Productos
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
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
        public ClientesFactura ClientesFacturaList { get; set; }
        public List<Productosfactura> ProductosfacturaList { get; set; }
        public string Fecha { get; set; }
        public string HoraDeFacturacion { get; set; }
        public string MetodoDePago { get; set; }
        public string Facturador { get; set; }
        public int Total { get; set; }

    }
    public class ClientesFactura
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }
    public class Productosfactura
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Tipo { get; set; }
        public int PrecioXUnidad { get; set; }
        public int Total { get; set; }

    }
    public class LOG 
    {
        public string User {set; get;}
        public string Pass {set; get;}
        public string Nombre {set; get;}
        public string ID {set; get;}
    }
    public class Logtime 
    {
        public string Fecha { set; get;}
        public string Hora { set; get;}
        public string IdEmpleado { set; get;}
        public string Nombre { set; get; }
    }
}