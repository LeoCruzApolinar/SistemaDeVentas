namespace SistemaDeVenta
{
    public class Productos
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public int PrecioXUnidad { get; set; }
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
        public string IDfacturador { get; set; }

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
    public class Objproductos
    {
        public string Nombre { set; get; }
        public string Tipo { set; get; }
        public int PrecioXUnidad { set; get; }
        public int Cantidad { set; get; }
    }
    public class ObjEmpleados
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string Cumpleanos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Pass { get; set; }
        public string User { get; set; }
    }
    public class ObjClientes
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Cumpleanos { get; set; }
    }
    public class Empleados
    {
        public string Nombre {get; set;}
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string Cumpleanos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Pass { get; set; }
        public string User { get; set; }
        public string id { get; set; }

    }
    public class Cclientes
    {

    }
    public class lista 
    {
        public string Orden {get; set;}
        public string key { get; set; }
        public object obj { get; set; }

    }




}