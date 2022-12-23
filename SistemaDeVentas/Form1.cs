using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SistemaDeVenta;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace SistemaDeVentas
{
    public partial class Form1 : Form
    {
        static IFirebaseConfig Conexion = new FirebaseConfig
        {
            AuthSecret = "ib4rtRweg2ETx0I9JKVV32Yl9pPbVdIyGuMOlZpN",
            BasePath = "https://prueba-b5bb6-default-rtdb.firebaseio.com/"

        };
        static IFirebaseClient client = null;
        List<Productos> ListaP = new List<Productos>();
        List<Clientes> ListaC = new List<Clientes>();
        FormFactura[] ListFactura = new FormFactura[1];
        int n = 0;
        int p = 0;
        public string User;
        public string ENombre;
        public string EID;
        public Form1()
        {
            InitializeComponent();
            LBLFecha.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
            Application.EnableVisualStyles();

        }
       
        private void BtnGuardar_MouseHover(object sender, EventArgs e)
        {
            BtnGuardar.BackColor = Color.FromArgb(0, 64, 0);
        }

        private void BtnGuardar_MouseLeave(object sender, EventArgs e)
        {
            BtnGuardar.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void BTNCancelar_MouseHover(object sender, EventArgs e)
        {
            BTNCancelar.BackColor = Color.FromArgb(64, 0, 0);
        }

        private void BTNCancelar_MouseLeave(object sender, EventArgs e)
        {
            BTNCancelar.BackColor = Color.FromArgb(0, 0, 64);
        }

        private async void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {
                e.Handled = true;
                if (textBox1.Text != "" && textBox1.Text[0] != '0')
                {
                    e.Handled = false;
                }

            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            try {
                if (textBox1.Text[0] == '0')
                {
                    textBox1.Text = textBox1.Text.Trim(new Char[] { ' ', '0', '.' });
                }
            } 
            catch
            {
                
            }
        }
        public async void DatosConexion()
        {
            //Productos
            Dictionary<string, Productos> DLProductos = new Dictionary<string, Productos>();
            FirebaseResponse responsesP =  client.Get("Datos/Productos");
            DLProductos = JsonConvert.DeserializeObject< Dictionary<string, Productos>>(responsesP.Body);
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
                Pproductos.Items.Add(elemento.Value.Nombre);
            }
            ListaP = ListaProductos;

            //MetodoDePago
            PmetodoDepago.Items.Add("Tarjeta");
            PmetodoDepago.Items.Add("Efectivo");
            PmetodoDepago.Items.Add("transferencia");

            //Clientes
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
                PClientes.Items.Add(elemento.Value.Nombre);
               
            }
            ListaC = ListaClientes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LBLCajero.Text = ENombre + " ( "+EID+" )";
            client = new FireSharp.FirebaseClient(Conexion);
            DatosConexion();
            PmetodoDepago.DropDownStyle = ComboBoxStyle.DropDownList;
            Pproductos.DropDownStyle = ComboBoxStyle.DropDownList;
            Dcantidad.Text = "";
            Dprecio.Text = "";
           


        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            //validacion
            
            if (PmetodoDepago.SelectedIndex != -1 && PClientes.SelectedIndex != -1 && DataTableLista.RowCount > 0)
            {
                Atualizar();
                AgregarFactura(GetFacturas());
                textBox1.Text = "";
                Pproductos.SelectedItem = null;
                PmetodoDepago.SelectedItem = null;
                PClientes.SelectedItem = null;
                DataTableLista.Rows.Clear();
                LbLNtotal.Text = "";
                Dprecio.Text = "";
                Dcantidad.Text ="";

            }
            else
            {
                MessageBox.Show("Los campos {Cliente}, {Metodo de pago} y {El listado de productos} deben de estar completos");
            }

            //construir
        }
        void AgregarFactura(object facturaList) 
        {

            ListFactura[n] = new FormFactura();
            ListFactura[n].Dock = DockStyle.Top;
            ListFactura[n].FacturaList = facturaList;

            int c = flowLayoutPanel1.Controls[p].Controls.Count;
            if (c == 3)
            {
                p++;
                flowLayoutPanel1.Controls.Add(new Panel());
                flowLayoutPanel1.Controls[p].Dock = DockStyle.Left;
                flowLayoutPanel1.Controls[p].Size = new Size(202, 317);
            }
            flowLayoutPanel1.Controls[p].Controls.Add(ListFactura[n]);
            n++;
            Array.Resize(ref ListFactura, n + 1);
        }
        public string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }
        string generarIdF(int a)
        {
            string Id;
            string fecha = DateTime.UtcNow.ToString("dd-MM-yyyy");
            string Hora = DateTime.Now.ToString("HH-mm");
            string IdCliente = ListaC[PClientes.SelectedIndex].Id.ToString();
            string guid = generateID();
            Id = IdCliente+"-"+fecha+"-"+Hora+"-"+guid;
            if (a == 1) 
            {
                Id = IdCliente + "-" + fecha + "-" + Hora+"-" + guid;
            }
            else { Id = IdCliente + "-" + fecha + "-" + Hora; }
            return Id; 
        }
        int TotalF() 
        {
            int total = 0;
            for (int i = 0; i < DataTableLista.Rows.Count; i++) 
            {
                string t = DataTableLista[5, i].Value.ToString();
                t = t[..^2];
                total = total + int.Parse(t);
            }
            return total;
        }
        public List<Productosfactura> GetPRODUCTOS()
        {
            List<Productosfactura> ProductosfacturaLista = new List<Productosfactura>();


            for (int i = 0; i < DataTableLista.Rows.Count; i++) 
            {
                string C = DataTableLista[4, i].Value.ToString();
                C = C[..^2];
                string t = DataTableLista[5, i].Value.ToString();
                t = t[..^2];
                
                ProductosfacturaLista.Add(new Productosfactura()
                {
                    Id = DataTableLista[0, i].Value.ToString(),
                    Nombre = DataTableLista[1,i].Value.ToString(),
                    Cantidad = Convert.ToInt32(DataTableLista[2,i].Value),
                    PrecioXUnidad = int.Parse(C),
                    Total = int.Parse(t),
                    Tipo = DataTableLista[3,i].Value.ToString()
                    
                });
            }

            return ProductosfacturaLista;
        }
        public object GetFacturas() 
        {
            var facturaList = new Factura
            {

                Id = generarIdF(2),
                Fecha = DateTime.UtcNow.ToString("dd/MM/yyyy"),
                MetodoDePago = PmetodoDepago.Text,
                HoraDeFacturacion = DateTime.Now.ToString("hh:mm tt"),
                Total = TotalF(),
                ClientesFacturaList = new ClientesFactura
                {
                    Id = ListaC[PClientes.SelectedIndex].Id.ToString(),
                    Nombre = ListaC[PClientes.SelectedIndex].Nombre.ToString(),
                    Telefono = ListaC[PClientes.SelectedIndex].Telefono.ToString()
                },
                ProductosfacturaList = GetPRODUCTOS(),
                Facturador = LBLCajero.Text,


            };
            string d = generarIdF(1);
            SetResponse response = client.Set("/Facturas/"+ d, facturaList); 
           return facturaList;
        }
        public async void Atualizar() 
        {
            for (int i = 0; i < DataTableLista.RowCount; i++) 
            {
                FirebaseResponse responsesP = client.Get("Datos/Productos/"+ DataTableLista[0, i].Value.ToString()+"/"+"Cantidad");
                int c = int.Parse(responsesP.Body);
                string P = DataTableLista[4, i].Value.ToString();
                P = P[..^2];
                var dproductos = new Productos()
                {
                    Cantidad = (c - Convert.ToInt32(DataTableLista[2,i].Value)),
                    Nombre = DataTableLista[1,i].Value.ToString(),
                    Precio = int.Parse(P),
                    Tipo = DataTableLista[3,i].Value.ToString(),
                };
                string URL = "/Datos/Productos/" + DataTableLista[0,i].Value.ToString();
                FirebaseResponse responsed = client.Update(URL, dproductos);
            }
        }
        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Pproductos.SelectedItem = null;
            PmetodoDepago.SelectedItem = null;
            PClientes.SelectedItem = null;
        }
        void Enlistar() 
        {
            bool add = true;
            for (int i = 0; i < DataTableLista.Rows.Count; i++)
            {
                if (DataTableLista[0, i].Value == ListaP[Pproductos.SelectedIndex].Id)
                {
                    int s = Convert.ToInt32(DataTableLista.Rows[i].Cells[2].Value); ;
                    DataTableLista[2, i].Value = s + int.Parse(textBox1.Text);
                    DataTableLista[5, i].Value = (s + int.Parse(textBox1.Text)) * ListaP[Pproductos.SelectedIndex].Precio;
                    add = false;
                }
            }
            if (add)
            {
                DataTableLista.Rows.Add();
                int X = DataTableLista.Rows.Count - 1;
                DataTableLista[0, X].Value = ListaP[Pproductos.SelectedIndex].Id;
                DataTableLista[1, X].Value = ListaP[Pproductos.SelectedIndex].Nombre;
                DataTableLista[2, X].Value = int.Parse(textBox1.Text);
                DataTableLista[3, X].Value = ListaP[Pproductos.SelectedIndex].Tipo;
                DataTableLista[4, X].Value = ListaP[Pproductos.SelectedIndex].Precio + " $";
                DataTableLista[5, X].Value = ListaP[Pproductos.SelectedIndex].Precio * int.Parse(textBox1.Text) + " $";
            }
        }
        private void BtnEnlistar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && Pproductos.SelectedIndex != -1)
            {

                int A = int.Parse(textBox1.Text);
                int B = ListaP[Pproductos.SelectedIndex].Cantidad;
                if (A <= B && A != 0)
                {
                    ListaP[Pproductos.SelectedIndex].Cantidad = B-A;
                    UPD();
                    Enlistar();
                    LbLNtotal.Text = TotalF().ToString()+" $";
                }
                else
                {
                    if (A == 0)
                    { MessageBox.Show("La cantida escrita no puede ser 0"); }
                    else
                    {
                        MessageBox.Show("La cantida escrita supera el stock, " +
                        "La cantidad actual de " + Pproductos.Text + " es " + B.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Los campos {Cantidad} y {Productos} deben de estar completos");
            }
        }
        void UPD() 
        {
            Dprecio.Text = ListaP[Pproductos.SelectedIndex].Precio.ToString() + " $";
            Dcantidad.Text = ListaP[Pproductos.SelectedIndex].Cantidad.ToString() + " en stock";
        }

        private void BtnEliminarlista_Click(object sender, EventArgs e)
        {
            
            if (DataTableLista.SelectedRows.Count != 0)
            {
                int Index = DataTableLista.CurrentCell.RowIndex;
                int a = Convert.ToInt32(DataTableLista[2, Index].Value);
                ListaP[Pproductos.SelectedIndex].Cantidad = ListaP[Pproductos.SelectedIndex].Cantidad + a;
                UPD();
                DataTableLista.Rows.RemoveAt(Index);
            }
            else 
            {
                MessageBox.Show("No se selecciono una fila");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBLTH.Text = DateTime.Now.ToString("hh :mm tt");
        }

        private void Pproductos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try 
            { 
                  UPD();
            }
            catch 
            { 
            }

          
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FormLogin mv = new FormLogin();
            mv.Show();

            this.Close();
        }
    }


}
