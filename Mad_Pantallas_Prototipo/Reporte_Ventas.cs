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
    public partial class Reporte_Ventas : Form
    {
        public Reporte_Ventas()
        {
            InitializeComponent();
        }


        private void Fecha_Inicial_DTP_Reporte_Ventas_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Reporte_Venta_Load(object sender, EventArgs e)
        {

        }

        private void Fecha_Inicial_DTP_Reporte_Ventas_ValueChanged_1(object sender, EventArgs e)
        {
            Fecha_Inicial_DTP_Reporte_Ventas.MaxDate = DateTime.Now;
        }

        private void Salir_Btn_Reporte_Ventas_Click(object sender, EventArgs e)
        {
           
        }

        private void Volver_Menu_Btn_Reporte_Ventas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
