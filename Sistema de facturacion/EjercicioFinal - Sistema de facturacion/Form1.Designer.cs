namespace EjercicioFinal___Sistema_de_facturacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbContrasenya = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenya = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbDebug1 = new System.Windows.Forms.Label();
            this.lbDebug2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(161, 21);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(207, 35);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Inicio Sistema";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(115, 77);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(46, 13);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lbContrasenya
            // 
            this.lbContrasenya.AutoSize = true;
            this.lbContrasenya.Location = new System.Drawing.Point(97, 103);
            this.lbContrasenya.Name = "lbContrasenya";
            this.lbContrasenya.Size = new System.Drawing.Size(64, 13);
            this.lbContrasenya.TabIndex = 2;
            this.lbContrasenya.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(167, 74);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(184, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtContrasenya
            // 
            this.txtContrasenya.Location = new System.Drawing.Point(167, 100);
            this.txtContrasenya.Name = "txtContrasenya";
            this.txtContrasenya.PasswordChar = '*';
            this.txtContrasenya.Size = new System.Drawing.Size(184, 20);
            this.txtContrasenya.TabIndex = 4;
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(167, 145);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(75, 23);
            this.btnAcceder.TabIndex = 5;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(276, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbDebug1
            // 
            this.lbDebug1.AutoSize = true;
            this.lbDebug1.Location = new System.Drawing.Point(378, 74);
            this.lbDebug1.Name = "lbDebug1";
            this.lbDebug1.Size = new System.Drawing.Size(0, 13);
            this.lbDebug1.TabIndex = 7;
            // 
            // lbDebug2
            // 
            this.lbDebug2.AutoSize = true;
            this.lbDebug2.Location = new System.Drawing.Point(378, 103);
            this.lbDebug2.Name = "lbDebug2";
            this.lbDebug2.Size = new System.Drawing.Size(0, 13);
            this.lbDebug2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 195);
            this.Controls.Add(this.lbDebug2);
            this.Controls.Add(this.lbDebug1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtContrasenya);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbContrasenya);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Form1";
            this.Text = "Identificación";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbContrasenya;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenya;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbDebug1;
        private System.Windows.Forms.Label lbDebug2;
    }
}

