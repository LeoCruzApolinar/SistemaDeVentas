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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
                PrecioXUnidad = int.Parse(aTxTp.Text),
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
                Cambios("Productos","Agregar", kEY, date, aTxTn.Text);
            }
        }

        public void AnadirAlista() 
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
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
                    PrecioXUnidad = elemento.Value.PrecioXUnidad,
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
        public void Cambios(string remitente, string Orden, string key, object data, string nombre) 
        {
            Datos.Add(new lista()
            {
                Orden = Orden,
                key = key,
                obj = data,

            });

            listaCambios[n] = new ListaCambios();
            listaCambios[n].Dock = DockStyle.Top;
            listaCambios[n].Nombre = nombre;
            listaCambios[n].Accion = Orden;
            listaCambios[n].Remitente = remitente;
            PanelCambios.Controls.Add(listaCambios[n]);
            int ss = listaCambios[n].select;
            n++;
            Array.Resize(ref listaCambios, n + 1);
        }
        void Eliminar() 
        {
            for (int i = 0; i < listaCambios.Length; i++) 
            {
                if (listaCambios[i] != null && listaCambios[i].select == 1)
                {
                    PanelCambios.Controls.Remove(listaCambios[i]);
                    Datos.RemoveAt(i);
                    listaCambios = ElimarDelArregloOPCForm(listaCambios, i);
                    n--;
                    i--;
                }
            }
        }
        public ListaCambios[] ElimarDelArregloOPCForm(ListaCambios[] datos, int x) 
        {
            ListaCambios[] ejemplo = new ListaCambios[listaCambios.Length - 1];
            int A = 0;
            for (int i = 0; i < listaCambios.Length; i++)
            {
                if (i == x) 
                {
                    i++;
                    ejemplo[A] = datos[i];
                }
                else 
                {
                    ejemplo[A] = datos[i];
                }
                A++;
            }
            datos = ejemplo;
            return datos;
        }
        void AgregarFireBase()
        {
            for (int i = 0; i < listaCambios.Length; i++)
            {
                if (listaCambios[i] != null && listaCambios[i].select == 1)
                {
                    UbicarEnFirebse(i);
                }
            }
            Eliminar();
        }
        void UbicarEnFirebse(int x) 
        {
            switch (listaCambios[x].Remitente)
            {
                case "Productos":
                   
                    switch (listaCambios[x].Accion)
                    {
                        case "Agregar":

                            SetResponse response = client.Set("/Datos/Productos/" + Datos[x].key, Datos[x].obj);

                            break;

                        case "Eliminar":

                            if (ListaP.Count != 1)
                            {
                                DeleteResponse responseE = client.Delete("/Datos/Productos/" + Datos[x].key);

                            }
                            else
                            {
                                MessageBox.Show("La cantida de productos no puede ser 0");
                            }

                            break;

                        case "Actualizar":

                            SetResponse responses = client.Set("/Datos/Productos/" + Datos[x].key, Datos[x].obj);

                            break;

                    }
                    break;

                break;

                case "Empleados":
                    
                    switch (listaCambios[x].Accion)
                    {
                        case "Agregar":
                            SetResponse response = client.Set("/Datos/Empleados/" + Datos[x].key, Datos[x].obj);
                            break;

                        case "Eliminar":

                           if (ListaE.Count != 1) 
                           {
                                DeleteResponse responseE = client.Delete("/Datos/Empleados/" + Datos[x].key);
                                
                           }
                            else 
                            {
                                MessageBox.Show("La cantida de empleado no puede ser 0");
                            }
                            break;

                        case "Actualizar":
                            SetResponse responses = client.Set("/Datos/Empleados/" + Datos[x].key, Datos[x].obj);
                            break;

                    }
                    break;

                break;

                case "Clientes":
                    
                    switch (listaCambios[x].Accion)
                    {
                        case "Agregar":
                            SetResponse response = client.Set("/Datos/Clientes/" + Datos[x].key, Datos[x].obj);
                            break;

                        case "Eliminar":

                            if (ListaC.Count != 1)
                            {
                                DeleteResponse responseE = client.Delete("/Datos/Clientes/" + Datos[x].key);

                            }
                            else
                            {
                                MessageBox.Show("La cantida de Clientes no puede ser 0");
                            }
                            break;

                        case "Actualizar":

                            SetResponse respons = client.Set("/Datos/Clientes/" + Datos[x].key, Datos[x].obj);

                            break;

                    }
                    break;

               break;

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        public void CopiaDeSeguridad()
        {
            FirebaseResponse responsess = client.Get("/");
            string JSON = responsess.Body;
            string FileCopia = DateTime.UtcNow.ToString("MM-dd-yyyy") + DateTime.Now.ToString("HH-mm-ss") + "CopiaDeSegurida";
            string fileName = @"C:\Users\leona\OneDrive\Documentos\ProyectosVisual\SistemaDeVentas\Backup\" + FileCopia+".txt";
            StreamWriter writer = new StreamWriter(fileName);
            writer.Write(JSON);
            writer.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CopiaDeSeguridad();
            AgregarFireBase();
            AnadirAlista();
        }

        private void EbtnA_Click(object sender, EventArgs e)
        {
            if (eTxTn.Text != "" && eTxTa.Text != "" && cTxTc.Text != "" && eTxTb.Text != "" 
                && eTxTt.Text != "" && eTxTcedula.Text != "" && eTxTu.Text != "" 
                && eTxTpass.Text != "" && txtAPD.Text != "")
            {
                string kEY = eTxTn.Text + "-" + generateID();
                var date = new ObjEmpleados
                {
                    Nombre = eTxTn.Text,
                    Apellido = eTxTa.Text,
                    Cedula = eTxTcedula.Text,
                    Correo = cTxTc.Text,
                    Cumpleanos = eTxTb.Text,
                    Direccion = txtAPD.Text,
                    User = eTxTu.Text,
                    Pass = eTxTpass.Text,
                    Telefono = eTxTt.Text,
                   

                };
                Cambios("Empleados", "Agregar", kEY, date, eTxTn.Text);
            }
        }

        private void CbtnA_Click(object sender, EventArgs e)
        {
            if (cTxTn.Text != "" && cTxTa.Text != "" && cTxTcorreo.Text != "" && cTxTcumple.Text != ""
                && cTxTt.Text != "")
            {
                string kEY = cTxTn.Text + "-" + generateID();
                var date = new ObjClientes
                {
                    Nombre = cTxTn.Text,
                    Apellido = cTxTa.Text,
                    Correo = cTxTcorreo.Text,
                    Cumpleanos = cTxTcumple.Text,
                    Telefono= cTxTt.Text,


                };
                Cambios("Clientes", "Agregar", kEY, date, cTxTn.Text);
            }
        }

        private void listBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            try {

                eTxTnEdit.Text = ListaE[listBox2.SelectedIndex].Nombre;
                eTxTaEdit.Text = ListaE[listBox2.SelectedIndex].Apellido;
                cTxTcEdit.Text = ListaE[listBox2.SelectedIndex].Correo;
                eTxTbEditar.Text = ListaE[listBox2.SelectedIndex].Cumpleanos;
                eTxTtEditar.Text = ListaE[listBox2.SelectedIndex].Telefono;
                eTxTcedulaEditar.Text = ListaE[listBox2.SelectedIndex].Cedula;
                eTxTuEditar.Text = ListaE[listBox2.SelectedIndex].User;
                eTxTpassEditar.Text = ListaE[listBox2.SelectedIndex].Pass;
                EditarDTXTEP.Text = ListaE[listBox2.SelectedIndex].Direccion;
            }
            catch { }
           
        }

        private void EbtnE_Click(object sender, EventArgs e)
        {
            var date = new ObjEmpleados
            {
            };
            if(listBox2.SelectedIndex != -1) 
            {
                Cambios("Empleados", "Eliminar", ListaE[listBox2.SelectedIndex].id, date, ListaE[listBox2.SelectedIndex].Nombre);
            }
            else 
            {
                MessageBox.Show("Debe seleccionar un empleado");
            }
            
        }

        private void PbtnE_Click(object sender, EventArgs e)
        {
            var date = new Objproductos
            {
            };
            if (listBox1.SelectedIndex != -1)
            {
                Cambios("Productos", "Eliminar", ListaP[listBox1.SelectedIndex].Id, date, ListaP[listBox1.SelectedIndex].Nombre);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void CbtnE_Click(object sender, EventArgs e)
        {

            var date = new ObjClientes
            {
            };
            if (listBox3.SelectedIndex != -1)
            {
                Cambios("Clientes", "Eliminar", ListaC[listBox3.SelectedIndex].Id, date, ListaC[listBox3.SelectedIndex].Nombre);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }

        }

        private void CbtnEditar_Click(object sender, EventArgs e)
        {
            if (cTxTnEdit.Text != "" && cTxTaEdit.Text != "" && cTxTcorreoEditar.Text != "" && cTxTcumpleEditar.Text != ""
                && cTxTtEditar.Text != "")
            {
                string kEY = ListaC[listBox3.SelectedIndex].Id;
                var date = new ObjClientes
                {
                    Nombre = cTxTnEdit.Text,
                    Apellido = cTxTaEdit.Text,
                    Correo = cTxTcorreoEditar.Text,
                    Cumpleanos = cTxTcumpleEditar.Text,
                    Telefono = cTxTtEditar.Text,


                };
                Cambios("Clientes", "Actualizar", kEY, date, cTxTnEdit.Text);
            }
        }
        private void listBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            try {
                cTxTnEdit.Text = ListaC[listBox3.SelectedIndex].Nombre;
                cTxTaEdit.Text = ListaC[listBox3.SelectedIndex].Apellido;
                cTxTcorreoEditar.Text = ListaC[listBox3.SelectedIndex].Correo;
                cTxTcumpleEditar.Text = ListaC[listBox3.SelectedIndex].Cumpleanos;
                cTxTtEditar.Text = ListaC[listBox3.SelectedIndex].Telefono;

            } catch { }
           
           
        }

        private void EbtnED_Click(object sender, EventArgs e)
        {
            if (eTxTnEdit.Text != "" && eTxTaEdit.Text != "" && cTxTcEdit.Text != "" && eTxTbEditar.Text != ""
               && eTxTtEditar.Text != "" && eTxTcedulaEditar.Text != "" && eTxTuEditar.Text != ""
               && eTxTpassEditar.Text != "" && EditarDTXTEP.Text != "")
            {
                string kEY = ListaE[listBox2.SelectedIndex].id;
                var date = new ObjEmpleados
                {
                    Nombre = eTxTnEdit.Text,
                    Apellido = eTxTaEdit.Text,
                    Cedula = eTxTcedulaEditar.Text,
                    Correo = cTxTcEdit.Text,
                    Cumpleanos = eTxTbEditar.Text,
                    Direccion = EditarDTXTEP.Text,
                    User = eTxTuEditar.Text,
                    Pass = eTxTpassEditar.Text,
                    Telefono = eTxTtEditar.Text,


                };
                Cambios("Empleados", "Actualizar", kEY, date, eTxTnEdit.Text);
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                aTxTnEditar.Text = ListaP[listBox1.SelectedIndex].Nombre;
                aTxTpEditar.Text = ListaP[listBox1.SelectedIndex].PrecioXUnidad.ToString();
                aTxTtEditar.Text = ListaP[listBox1.SelectedIndex].Tipo;
                aTxTcEditar.Text = ListaP[listBox1.SelectedIndex].Cantidad.ToString();

            }
            catch { }
        }

        private void PbtnEditar_Click(object sender, EventArgs e)
        {
            if (aTxTnEditar.Text != "" && aTxTpEditar.Text != "" && aTxTtEditar.Text != "" && aTxTcEditar.Text != "")
            {
                string kEY = ListaP[listBox1.SelectedIndex].Id;
                var date = new Objproductos
                {
                    Nombre = aTxTnEditar.Text,
                    Cantidad = int.Parse(aTxTcEditar.Text),
                    PrecioXUnidad = int.Parse(aTxTpEditar.Text),
                    Tipo = aTxTtEditar.Text,
                };
                Cambios("Productos", "Actualizar", kEY, date, aTxTnEditar.Text);
            }
        }

        private void OpcionesDeAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin frm = new FormLogin();

            frm.Show();
        }

        private void aTxTp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {
                e.Handled = true;
                if (aTxTp.Text != "" && aTxTp.Text[0] != '0')
                {
                    e.Handled = false;
                }

            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (aTxTp.Text[0] == '0')
                {
                    aTxTp.Text = aTxTp.Text.Trim(new Char[] { ' ', '0', '.' });
                }
            }
            catch
            {

            }
        }

        private void aTxTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {
                e.Handled = true;
                if (aTxTc.Text != "" && aTxTc.Text[0] != '0')
                {
                    e.Handled = false;
                }

            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (aTxTc.Text[0] == '0')
                {
                    aTxTc.Text = aTxTc.Text.Trim(new Char[] { ' ', '0', '.' });
                }
            }
            catch
            {

            }
        }

        private void aTxTpEditar_TextChanged(object sender, EventArgs e)
        {

        }

        private void aTxTpEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {
                e.Handled = true;
                if (aTxTpEditar.Text != "" && aTxTpEditar.Text[0] != '0')
                {
                    e.Handled = false;
                }

            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (aTxTpEditar.Text[0] == '0')
                {
                    aTxTpEditar.Text = aTxTpEditar.Text.Trim(new Char[] { ' ', '0', '.' });
                }
            }
            catch
            {

            }
        }

        private void aTxTcEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
            {
                e.Handled = true;
                if (aTxTcEditar.Text != "" && aTxTcEditar.Text[0] != '0')
                {
                    e.Handled = false;
                }

            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (aTxTcEditar.Text[0] == '0')
                {
                    aTxTcEditar.Text = aTxTcEditar.Text.Trim(new Char[] { ' ', '0', '.' });
                }
            }
            catch
            {

            }
        }




        //eTxTnEdit.Text = ListaP[listBox2.SelectedIndex];
        //eTxTaEdit;
        //cTxTcEdit;
        //eTxTbEditar;
        //eTxTtEditar;
        //eTxTcedulaEditar;
        //eTxTuEditar;
        //eTxTpassEditar;
        //EditarDTXTEP;
    }
}