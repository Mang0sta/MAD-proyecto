namespace Mad_Pantallas_Prototipo
{
    partial class Login
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
            this.Entrar_Btn_Login = new System.Windows.Forms.Button();
            this.Clave_TxtBox_Login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Contraseña_TxtBox_Login = new System.Windows.Forms.TextBox();
            this.Salir_Btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Entrar_Btn_Login
            // 
            this.Entrar_Btn_Login.Location = new System.Drawing.Point(60, 175);
            this.Entrar_Btn_Login.Name = "Entrar_Btn_Login";
            this.Entrar_Btn_Login.Size = new System.Drawing.Size(75, 23);
            this.Entrar_Btn_Login.TabIndex = 2;
            this.Entrar_Btn_Login.Text = "Entrar";
            this.Entrar_Btn_Login.UseVisualStyleBackColor = true;
            this.Entrar_Btn_Login.Click += new System.EventHandler(this.Entrar_Btn_Login_Click);
            // 
            // Clave_TxtBox_Login
            // 
            this.Clave_TxtBox_Login.Location = new System.Drawing.Point(97, 56);
            this.Clave_TxtBox_Login.Name = "Clave_TxtBox_Login";
            this.Clave_TxtBox_Login.Size = new System.Drawing.Size(132, 20);
            this.Clave_TxtBox_Login.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clave";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Contraseña_TxtBox_Login
            // 
            this.Contraseña_TxtBox_Login.Location = new System.Drawing.Point(97, 110);
            this.Contraseña_TxtBox_Login.Name = "Contraseña_TxtBox_Login";
            this.Contraseña_TxtBox_Login.Size = new System.Drawing.Size(132, 20);
            this.Contraseña_TxtBox_Login.TabIndex = 1;
            this.Contraseña_TxtBox_Login.UseSystemPasswordChar = true;
            // 
            // Salir_Btn_Login
            // 
            this.Salir_Btn_Login.Location = new System.Drawing.Point(154, 175);
            this.Salir_Btn_Login.Name = "Salir_Btn_Login";
            this.Salir_Btn_Login.Size = new System.Drawing.Size(75, 23);
            this.Salir_Btn_Login.TabIndex = 3;
            this.Salir_Btn_Login.Text = "Salir";
            this.Salir_Btn_Login.UseVisualStyleBackColor = true;
            this.Salir_Btn_Login.Click += new System.EventHandler(this.Salir_Btn_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.Salir_Btn_Login);
            this.Controls.Add(this.Contraseña_TxtBox_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clave_TxtBox_Login);
            this.Controls.Add(this.Entrar_Btn_Login);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entrar_Btn_Login;
        private System.Windows.Forms.TextBox Clave_TxtBox_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Contraseña_TxtBox_Login;
        private System.Windows.Forms.Button Salir_Btn_Login;
    }
}

