namespace Mad_Pantallas_Prototipo
{
    partial class Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Departamento_CB_Inventario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Productos_Agotados_Check_Box_Inventario = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Merma_Check_Box_Inventario = new System.Windows.Forms.CheckBox();
            this.Existencia_Minima_Txt_Inventario = new System.Windows.Forms.TextBox();
            this.DGV_Inventario = new System.Windows.Forms.DataGridView();
            this.Volver_Menu_Btn_Inventario = new System.Windows.Forms.Button();
            this.Salir_Btn_Inventario = new System.Windows.Forms.Button();
            this.Consultar_Inventario_Btn_Inventario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // Departamento_CB_Inventario
            // 
            this.Departamento_CB_Inventario.FormattingEnabled = true;
            this.Departamento_CB_Inventario.Location = new System.Drawing.Point(127, 41);
            this.Departamento_CB_Inventario.Name = "Departamento_CB_Inventario";
            this.Departamento_CB_Inventario.Size = new System.Drawing.Size(132, 21);
            this.Departamento_CB_Inventario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Departamento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Existencia Minima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Solo Productos Agotados";
            // 
            // Productos_Agotados_Check_Box_Inventario
            // 
            this.Productos_Agotados_Check_Box_Inventario.AutoSize = true;
            this.Productos_Agotados_Check_Box_Inventario.Location = new System.Drawing.Point(172, 113);
            this.Productos_Agotados_Check_Box_Inventario.Name = "Productos_Agotados_Check_Box_Inventario";
            this.Productos_Agotados_Check_Box_Inventario.Size = new System.Drawing.Size(66, 17);
            this.Productos_Agotados_Check_Box_Inventario.TabIndex = 6;
            this.Productos_Agotados_Check_Box_Inventario.Text = "Agotado";
            this.Productos_Agotados_Check_Box_Inventario.UseVisualStyleBackColor = true;
            this.Productos_Agotados_Check_Box_Inventario.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Con Merma";
            // 
            // Merma_Check_Box_Inventario
            // 
            this.Merma_Check_Box_Inventario.AutoSize = true;
            this.Merma_Check_Box_Inventario.Location = new System.Drawing.Point(172, 148);
            this.Merma_Check_Box_Inventario.Name = "Merma_Check_Box_Inventario";
            this.Merma_Check_Box_Inventario.Size = new System.Drawing.Size(58, 17);
            this.Merma_Check_Box_Inventario.TabIndex = 8;
            this.Merma_Check_Box_Inventario.Text = "Merma";
            this.Merma_Check_Box_Inventario.UseVisualStyleBackColor = true;
            // 
            // Existencia_Minima_Txt_Inventario
            // 
            this.Existencia_Minima_Txt_Inventario.Location = new System.Drawing.Point(127, 72);
            this.Existencia_Minima_Txt_Inventario.Name = "Existencia_Minima_Txt_Inventario";
            this.Existencia_Minima_Txt_Inventario.Size = new System.Drawing.Size(132, 20);
            this.Existencia_Minima_Txt_Inventario.TabIndex = 9;
            // 
            // DGV_Inventario
            // 
            this.DGV_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Inventario.Location = new System.Drawing.Point(12, 171);
            this.DGV_Inventario.Name = "DGV_Inventario";
            this.DGV_Inventario.Size = new System.Drawing.Size(560, 287);
            this.DGV_Inventario.TabIndex = 10;
            // 
            // Volver_Menu_Btn_Inventario
            // 
            this.Volver_Menu_Btn_Inventario.Location = new System.Drawing.Point(479, 122);
            this.Volver_Menu_Btn_Inventario.Name = "Volver_Menu_Btn_Inventario";
            this.Volver_Menu_Btn_Inventario.Size = new System.Drawing.Size(93, 39);
            this.Volver_Menu_Btn_Inventario.TabIndex = 24;
            this.Volver_Menu_Btn_Inventario.Text = "Volver al menu";
            this.Volver_Menu_Btn_Inventario.UseVisualStyleBackColor = true;
            // 
            // Salir_Btn_Inventario
            // 
            this.Salir_Btn_Inventario.Location = new System.Drawing.Point(360, 122);
            this.Salir_Btn_Inventario.Name = "Salir_Btn_Inventario";
            this.Salir_Btn_Inventario.Size = new System.Drawing.Size(93, 39);
            this.Salir_Btn_Inventario.TabIndex = 25;
            this.Salir_Btn_Inventario.Text = "Salir";
            this.Salir_Btn_Inventario.UseVisualStyleBackColor = true;
            // 
            // Consultar_Inventario_Btn_Inventario
            // 
            this.Consultar_Inventario_Btn_Inventario.Location = new System.Drawing.Point(360, 41);
            this.Consultar_Inventario_Btn_Inventario.Name = "Consultar_Inventario_Btn_Inventario";
            this.Consultar_Inventario_Btn_Inventario.Size = new System.Drawing.Size(93, 39);
            this.Consultar_Inventario_Btn_Inventario.TabIndex = 26;
            this.Consultar_Inventario_Btn_Inventario.Text = "Consultar Inventario";
            this.Consultar_Inventario_Btn_Inventario.UseVisualStyleBackColor = true;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.Consultar_Inventario_Btn_Inventario);
            this.Controls.Add(this.Salir_Btn_Inventario);
            this.Controls.Add(this.Volver_Menu_Btn_Inventario);
            this.Controls.Add(this.DGV_Inventario);
            this.Controls.Add(this.Existencia_Minima_Txt_Inventario);
            this.Controls.Add(this.Merma_Check_Box_Inventario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Productos_Agotados_Check_Box_Inventario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Departamento_CB_Inventario);
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Departamento_CB_Inventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Productos_Agotados_Check_Box_Inventario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Merma_Check_Box_Inventario;
        private System.Windows.Forms.TextBox Existencia_Minima_Txt_Inventario;
        private System.Windows.Forms.DataGridView DGV_Inventario;
        private System.Windows.Forms.Button Volver_Menu_Btn_Inventario;
        private System.Windows.Forms.Button Salir_Btn_Inventario;
        private System.Windows.Forms.Button Consultar_Inventario_Btn_Inventario;
    }
}