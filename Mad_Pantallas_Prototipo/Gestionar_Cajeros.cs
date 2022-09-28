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
    public partial class Gestionar_Cajeros : Form
    {
        public Gestionar_Cajeros()
        {
            InitializeComponent();
        }

        private void DGV_Gestionar_Cajeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Fecha_DTP_Gestionar_Cajeros_ValueChanged(object sender, EventArgs e)
        {
            Fecha_Nacimiento_DTP_Gestionar_Cajeros.MaxDate = DateTime.Now;
            //Fecha_DTP_Gestionar_Cajeros.MinDate = new DateTime(1669, 04, 01);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fecha_Ingreso_DTP_Gestionar_Cajeros_ValueChanged(object sender, EventArgs e)
        {
            Fecha_Ingreso_DTP_Gestionar_Cajeros.MaxDate = DateTime.Now;
        }

        private void Volver_Menu_Btn_Gestionar_Cajeros_Click(object sender, EventArgs e)
        {

        }

        private void Correo_TxtBox_Gestionar_Cajeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Numero_Nomina_TxtBox_Gestionar_Cajeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Consultar_Cajero_Btn_Gestionar_Cajeros_Click(object sender, EventArgs e)
        {

        }

        private void CURP_TxtBox_Gestionar_Cajeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void Apellido_Materno_TxtBox_Gestionar_Cajeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void Apellido_Paterno_TxtBox_Gestionar_Cajeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contraseña_TxtBox_Gestionar_Cajeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salir_Btn_Gestionar_Cajeros_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clave_Usuario_TxtBox_Gestionar_Cajeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void Borrar_Cajero_Btn_Gestionar_Cajeros_Click(object sender, EventArgs e)
        {

        }

        private void Modificar_Cajero_Btn_Gestionar_Cajeros_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Cajero_Btn_Gestionar_Cajeros_Click(object sender, EventArgs e)
        {

        }
    }
}
