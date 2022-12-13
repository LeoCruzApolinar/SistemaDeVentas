using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using SistemaDeVenta;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    Precio = elemento.Value.Precio
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
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(Conexion);
            DatosConexion();
            PmetodoDepago.DropDownStyle = ComboBoxStyle.DropDownList;
            Pproductos.DropDownStyle = ComboBoxStyle.DropDownList;
            Dcantidad.Text = "";
            Dprecio.Text = "";


        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
        }
        public async void CrearFactura() 
        {
            var Factura = new Productos()
            {

            };
            //FirebaseResponse responsed = client.Update();
        }
        public async void Atualizar() 
        {
            //int A = int.Parse(textBox1.Text);
            //int B = ListaP[Pproductos.SelectedIndex].Cantidad;
            //ListaP[Pproductos.SelectedIndex].Cantidad = B - A;
            //string URL = "/Datos/Productos/" + ListaP[Pproductos.SelectedIndex].Id;
            //var dproductos = new Productos()
            //{
            //    Cantidad = ListaP[Pproductos.SelectedIndex].Cantidad,
            //    Nombre = ListaP[Pproductos.SelectedIndex].Nombre,
            //    Precio = ListaP[Pproductos.SelectedIndex].Precio,
            //};
            //FirebaseResponse responsed = client.Update(URL, dproductos);
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
            //for (int i = 0; i < dataGridView2.Rows.Count; i++) 
            //{
            //    if (dataGridView2[0,i].Value == ListaP[Pproductos.SelectedIndex].Id) 
            //    {
            //        int s = Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value); ;
            //        dataGridView2[2,i].Value = s + int.Parse(textBox1.Text);
            //        dataGridView2[4, i].Value = (s + int.Parse(textBox1.Text)) * ListaP[Pproductos.SelectedIndex].Precio;
            //        add = false;
            //    }
            //}
            if (add)
            {
                dataGridView2.Rows.Add();
                int X = dataGridView2.Rows.Count - 1;
                dataGridView2[0, X].Value = ListaP[Pproductos.SelectedIndex].Id;
                dataGridView2[1, X].Value = ListaP[Pproductos.SelectedIndex].Nombre;
                dataGridView2[2, X].Value = int.Parse(textBox1.Text);
                dataGridView2[3, X].Value = ListaP[Pproductos.SelectedIndex].Precio + " $";
                dataGridView2[4, X].Value = ListaP[Pproductos.SelectedIndex].Precio * int.Parse(textBox1.Text) + " $";
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
        private void Pproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            UPD();
        }
        void UPD() 
        {
            Dprecio.Text = ListaP[Pproductos.SelectedIndex].Precio.ToString() + " $";
            Dcantidad.Text = ListaP[Pproductos.SelectedIndex].Cantidad.ToString() + " en stock";
        }

        private void BtnEliminarlista_Click(object sender, EventArgs e)
        {
            int Index = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(Index);
            int a = Convert.ToInt32(dataGridView2.Rows[Index].Cells[2].Value);
            int d = 0;


        }
    }


}
