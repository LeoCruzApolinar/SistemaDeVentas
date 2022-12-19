using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using SistemaDeVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SistemaDeVentas
{
    public partial class FormLogin : Form
    {
        bool AdminLog;
        static IFirebaseConfig Conexion = new FirebaseConfig
        {
            AuthSecret = "ib4rtRweg2ETx0I9JKVV32Yl9pPbVdIyGuMOlZpN",
            BasePath = "https://prueba-b5bb6-default-rtdb.firebaseio.com/"
        };
        static IFirebaseClient client = null;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            BtnAdmin.BackColor = Color.Maroon;
            BtnAdmin.ForeColor = Color.White;
            BtnEmpleado.BackColor = Color.Navy;
            BtnEmpleado.ForeColor = Color.White;
            AdminLog = false;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(Conexion);
            BtnEmpleado.BackColor = Color.Navy;
            BtnEmpleado.ForeColor = Color.White;
            BtnAdmin.BackColor = Color.Maroon;
            BtnAdmin.ForeColor = Color.White;
            AdminLog = false;
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            BtnEmpleado.BackColor = Color.Maroon;
            BtnEmpleado.ForeColor = Color.White;
            BtnAdmin.BackColor = Color.Navy;
            BtnAdmin.ForeColor = Color.White;
            AdminLog = true;
        }

        private void BTNLOG_Click(object sender, EventArgs e)
        {
            if (AdminLog)
            {
                int A = 0;
                Dictionary<string, LOG> Admin = new Dictionary<string, LOG>();
                FirebaseResponse responsesP = client.Get("Administradores");
                Admin = JsonConvert.DeserializeObject<Dictionary<string, LOG>>(responsesP.Body);
                List<LOG> UssList = new List<LOG>();
                foreach (KeyValuePair<string, LOG> elemento in Admin)
                {
                    UssList.Add(new LOG()
                    {
                        User = elemento.Value.User,
                        Pass = elemento.Value.Pass,
                    });
                }
                for (int i = 0; i < UssList.Count; i++)
                {
                    if (UssList[i].User == textBoxuser.Text && UssList[i].Pass == TXTPASS.Text)
                    {
                        //llenar
                        A = 1;
                        break;
                    }
                }
                if (A != 1)
                {
                    MessageBox.Show("Revise la contraseña o el usuario");
                }
                else 
                {
                    
                }
            }
            else
            {
                int A = 0;
                int uss = 0;
                Dictionary<string, LOG> Admin = new Dictionary<string, LOG>();
                FirebaseResponse responsesP = client.Get("Datos/Empleados");
                Admin = JsonConvert.DeserializeObject<Dictionary<string, LOG>>(responsesP.Body);
                List<LOG> UssList = new List<LOG>();
                foreach (KeyValuePair<string, LOG> elemento in Admin)
                {
                    UssList.Add(new LOG()
                    {
                        User = elemento.Value.User,
                        Pass = elemento.Value.Pass,
                        Nombre = elemento.Value.Nombre,
                        ID = elemento.Value.ID,
                    });
                }
                for (int i = 0; i < UssList.Count; i++)
                {
                    if (UssList[i].User == textBoxuser.Text && UssList[i].Pass == TXTPASS.Text)
                    {
                        A = 1;
                        uss = i;
                        //llenar
                        break;
                    }
                }
                if (A != 1) 
                {
                    MessageBox.Show("Revise la contraseña o el usuario");
                }
                else
                {
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.ENombre = UssList[uss].Nombre;
                    frm.EID = UssList[uss].ID;
                    frm.Show();
                }
            }
        }
    }
}
