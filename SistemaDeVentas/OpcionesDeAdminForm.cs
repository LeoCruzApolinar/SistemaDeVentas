using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using SistemaDeVenta;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SistemaDeVentas
{
    public partial class OpcionesDeAdminForm : Form
    {
        public OpcionesDeAdminForm()
        {
            InitializeComponent();
        }
        static IFirebaseConfig Conexion = new FirebaseConfig
        {
            AuthSecret = "ib4rtRweg2ETx0I9JKVV32Yl9pPbVdIyGuMOlZpN",
            BasePath = "https://prueba-b5bb6-default-rtdb.firebaseio.com/"

        };
        static IFirebaseClient client = null;
        List<Empleados> ListaE = new List<Empleados>();
        List<Clientes> ListaC = new List<Clientes>();
        List<Productos> ListaP = new List<Productos>();
        List<lista> Datos = new List<lista>();
        ListaCambios[] listaCambios = new ListaCambios[1];
        int n = 0;
        int p = 0;
        public List<Productos> AgregarProductos( ) 
        {
            List<Productos> AgregarProductos = new List<Productos>();
            AgregarProductos.Add(new Productos()
            {
                Nombre = aTxTn.Text,
                Cantidad = int.Parse(aTxTc.Text),
                Precio = int.Parse(aTxTp.Text),
                Tipo = aTxTt.Text,
                Id = aTxTn.Text + "-" + generateID()
            });
            return AgregarProductos;
        }
        public string generateID()
        {
            return Guid.NewGuid().ToString("N");
            //SetResponse response = client.Set("/Facturas" + "/" + d, facturaList);
        }

        private void PbtnA_Click(object sender, EventArgs e)
        {
            if (aTxTn.Text != "" && aTxTc.Text != "" && aTxTp.Text != "" && aTxTt.Text != "") 
            {
                string kEY = aTxTn.Text + "-" + generateID();
                var date = new Objproductos
                {
                    Nombre = aTxTn.Text,
                    Cantidad = int.Parse(aTxTc.Text),
                    PrecioXUnidad = int.Parse(aTxTp.Text),
                    Tipo = aTxTt.Text,
                };
                Cambios("Productos","Agregar", kEY, date);
            }
        }

        public void AnadirAlista() 
        {
            Dictionary<string, Productos> DLProductos = new Dictionary<string, Productos>();
            FirebaseResponse responsesP = client.Get("Datos/Productos");
            DLProductos = JsonConvert.DeserializeObject<Dictionary<string, Productos>>(responsesP.Body);
            List<Productos> ListaProductos = new List<Productos>();

            foreach (KeyValuePair<string, Productos> elemento in DLProductos)
            {
                ListaProductos.Add(new Productos()
                {
                    Id = elemento.Key,
                    Nombre = elemento.Value.Nombre,
                    Cantidad = elemento.Value.Cantidad,
                    Precio = elemento.Value.Precio,
                    Tipo = elemento.Value.Tipo

                });
                listBox1.Items.Add(elemento.Value.Nombre);
            }
            ListaP = ListaProductos;

            Dictionary<string, Clientes> DLClientes = new Dictionary<string, Clientes>();
            FirebaseResponse responsesC = client.Get("Datos/Clientes");
            DLClientes = JsonConvert.DeserializeObject<Dictionary<string, Clientes>>(responsesC.Body);
            List<Clientes> ListaClientes = new List<Clientes>();

            foreach (KeyValuePair<string, Clientes> elemento in DLClientes)
            {
                ListaClientes.Add(new Clientes()
                {
                    Id = elemento.Key,
                    Nombre = elemento.Value.Nombre,
                    Apellido = elemento.Value.Apellido,
                    Correo = elemento.Value.Correo,
                    Telefono = elemento.Value.Telefono,
                    Cumpleanos = elemento.Value.Cumpleanos

                });
                listBox3.Items.Add(elemento.Value.Nombre);

            }
            ListaC = ListaClientes;
            Dictionary<string, Empleados> DLEmpleados = new Dictionary<string, Empleados>();
            FirebaseResponse responsess = client.Get("Datos/Empleados");
            DLEmpleados = JsonConvert.DeserializeObject<Dictionary<string, Empleados>>(responsess.Body);
            List<Empleados> ListaEmpleados = new List<Empleados>();

            foreach (KeyValuePair<string, Empleados> elemento in DLEmpleados)
            {
                ListaEmpleados.Add(new Empleados()
                {
                    id = elemento.Key,
                    Nombre = elemento.Value.Nombre,
                    Apellido = elemento.Value.Apellido,
                    Correo = elemento.Value.Correo,
                    Telefono = elemento.Value.Telefono,
                    Cumpleanos = elemento.Value.Cumpleanos,
                    Cedula = elemento.Value.Cedula,
                    Pass = elemento.Value.Pass,
                    User = elemento.Value.User,
                    Direccion = elemento.Value.Direccion,


                });
                listBox2.Items.Add(elemento.Value.Nombre);

            }
            ListaE = ListaEmpleados;

        }
        private void OpcionesDeAdminForm_Load(object sender, EventArgs e)
        {
            aTxTt.Items.Add("Liquido");
            aTxTt.Items.Add("Alimento");
            aTxTt.Items.Add("Limpieza");
            client = new FireSharp.FirebaseClient(Conexion);
            AnadirAlista();
        }
        public void Cambios(string remitente, string Orden, string key, object data) 
        {
            Datos.Add(new lista()
            {
                Orden = Orden,
                key = key,
                obj = data,

            });
            var date = (Objproductos)data;

            listaCambios[n] = new ListaCambios();
            listaCambios[n].Dock = DockStyle.Top;
            listaCambios[n].Nombre = date.Nombre;
            listaCambios[n].Accion = Orden;
            listaCambios[n].Remitente = remitente;
            PanelCambios.Controls.Add(listaCambios[n]);
            int ss = listaCambios[n].select;
            n++;
            Array.Resize(ref listaCambios, n + 1);
            Eliminar();
        }
        void Eliminar() 
        {
            for (int i = 0; i < listaCambios.Length; i++) 
            {
                if (listaCambios[i] != null && listaCambios[i].select == 1)
                {
                    PanelCambios.Controls.Remove(listaCambios[i]);
         
                }
            }
        }
    }
}
