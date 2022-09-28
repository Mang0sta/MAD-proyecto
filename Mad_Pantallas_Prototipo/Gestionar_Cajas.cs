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
    public partial class Gestionar_Cajas : Form
    {
        public Gestionar_Cajas()
        {
            InitializeComponent();
        }

        private void Fecha_Apertura_DTP_Gestionar_Cajas_ValueChanged(object sender, EventArgs e)
        {

            //Fecha_Apertura_DTP_Gestionar_Cajas.MaxDate = DateTime.Now;
        }

        private void Fecha_Cierre_DTP_Gestionar_Cajas_ValueChanged(object sender, EventArgs e)
        {
           // Fecha_Cierre_DTP_Gestionar_Cajas.MaxDate = DateTime.Now;
        }

       
    }
}
