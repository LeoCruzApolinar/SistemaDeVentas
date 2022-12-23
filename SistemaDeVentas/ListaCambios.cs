using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas
{
    public partial class ListaCambios : UserControl
    {
        public ListaCambios()
        {
            InitializeComponent();
        }
        public string Nombre;
        public string Remitente;
        public string Accion;
        public int select = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(select == 0) 
            {
                button1.BackColor = Color.Black;
                select = 1;
            }
            else 
            {
                button1.BackColor = Color.White;
                select = 0;
            }

        }
    }
}
