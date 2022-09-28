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
    public partial class Administrador_Menu : Form
    {
        public Administrador_Menu()
        {
            InitializeComponent();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            
        }

        private void Gestionar_Cajeros_Btn_Administrador_Menu_Click(object sender, EventArgs e)
        {
            Gestionar_Cajeros GESTIONAR_CAJEROS = new Gestionar_Cajeros();
            GESTIONAR_CAJEROS.Show();

        }

        private void Gestionar_Cajas_Btn_Administrador_Menu_Click(object sender, EventArgs e)
        {
            Gestionar_Cajas GESTIONAR_CAJAS = new Gestionar_Cajas();
            GESTIONAR_CAJAS.Show();
        }

        private void Inventario_Btn_Administrador_Menu_Click(object sender, EventArgs e)
        {
            Inventario INVENTARIO = new Inventario();
            INVENTARIO.Show();
        }

        private void Reporte_Ventas_Btn_Administrador_Menu_Click(object sender, EventArgs e)
        {
            Reporte_Ventas REPORTE_VENTAS = new Reporte_Ventas();
            REPORTE_VENTAS.Show();
        }

        private void Reporte_Cajero_Btn_Administrador_Menu_Click(object sender, EventArgs e)
        {
            Reporte_Cajero REPORTE_CAJERO = new Reporte_Cajero();
            REPORTE_CAJERO.Show();
        }

        private void Devoluciones_Btn_Administrador_Menu_Click(object sender, EventArgs e)
        {
            Devoluciones DEVOLUCIONES = new Devoluciones();
            DEVOLUCIONES.Show();
        }

        private void Salir_Btn_Administrador_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consulta_Recibos_Notas_Credito_Btn_Administrador_Menu_Click(object sender, EventArgs e)
        {
            Consulta_Recibos_y_Notas_Credito CONSULTA_RECIBOS_Y_NOTAS_CREDITO = new Consulta_Recibos_y_Notas_Credito();
            CONSULTA_RECIBOS_Y_NOTAS_CREDITO.Show();
        }

        private void Productos_Inventario_Btn_Administrador_Menu_Click(object sender, EventArgs e)
        {
            Productos_Inventario PRODUCTOS_INVENTARIO = new Productos_Inventario();
            PRODUCTOS_INVENTARIO.Show();
        }
    }
}
