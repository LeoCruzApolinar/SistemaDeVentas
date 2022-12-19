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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace SistemaDeVentas
{
    public partial class FormFactura : UserControl
    {
        public FormFactura()
        {
            InitializeComponent();
        }
        private object  _FacturaList = new Factura();
        public object FacturaList
        {
            get { return _FacturaList; }
            set { _FacturaList = value; }
        }
        private void FormFactura_Load(object sender, EventArgs e)
        {
            Factura data = new Factura();
            data = (Factura)_FacturaList;
            LbLN.Text = data.ClientesFacturaList.Nombre;
            IDLbL.Text = data.ClientesFacturaList.Id;

        }

        private void FormFactura_DoubleClick(object sender, EventArgs e)
        {
            Factura data = new Factura();
            data = (Factura)_FacturaList;
            FacturaForm frm = new FacturaForm();
            frm.FacturaListForm = data;
            frm.Show();
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            Factura data = new Factura();
            data = (Factura)_FacturaList;
            FacturaForm frm = new FacturaForm();
            frm.FacturaListForm = data;
            frm.Show();
        }
    }
}
