using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mad_Pantallas_Prototipo
{
    public partial class Reporte_Cajero : Form
    {
        public Reporte_Cajero()
        {
            InitializeComponent();
        }

      

        private void Fecha_Inicial_DTP_Reporte_Cajero_ValueChanged(object sender, EventArgs e)
        {
            Fecha_Inicial_DTP_Reporte_Cajero.MaxDate = DateTime.Now;
        }

        private void Fecha_Finall_DTP_Reporte_Cajero_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
