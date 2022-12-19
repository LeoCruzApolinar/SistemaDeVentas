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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaDeVentas
{
    public partial class FacturaForm : Form
    {
        public FacturaForm()
        {
            InitializeComponent();
        }
        private object _FacturaListForm = new Factura();
        public object FacturaListForm 
        {
            get { return _FacturaListForm; }
            set { _FacturaListForm = value; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FacturaForm_Load(object sender, EventArgs e)
        {
            Factura data = new Factura();
            data = (Factura)_FacturaListForm;
            LBLId.Text = data.ClientesFacturaList.Id;
            LBLN.Text = data.ClientesFacturaList.Nombre;
            LBLT.Text = data.ClientesFacturaList.Telefono;
            LBLTotal.Text = data.Total.ToString()+" $";
            LBLFecha.Text = data.Fecha;
            LBLH.Text = data.HoraDeFacturacion;
            LBLMetodoDePago.Text = data.MetodoDePago;
            LBLIDFA.Text = data.Id;
            LBLFacturador.Text = data.Facturador;
            int i = data.ProductosfacturaList.Count;
            for(int a = 0; a < i; a++)
            {
                dataGridView1.Rows.Add();
                int X = dataGridView1.Rows.Count - 1;
                dataGridView1[0, X].Value = data.ProductosfacturaList[a].Id;
                dataGridView1[1, X].Value = data.ProductosfacturaList[a].Nombre;
                dataGridView1[2, X].Value = data.ProductosfacturaList[a].Cantidad;
                dataGridView1[3, X].Value = data.ProductosfacturaList[a].Tipo;
                dataGridView1[4, X].Value = data.ProductosfacturaList[a].PrecioXUnidad + " $";
                dataGridView1[5, X].Value = data.ProductosfacturaList[a].Total + " $";
            }
        }

        private void LBLFacturador_Click(object sender, EventArgs e)
        {

        }
    }
}
