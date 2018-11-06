namespace Facturacion
{
    partial class sistemaFacturacion
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
            this.lbNombreApellidos = new System.Windows.Forms.Label();
            this.lbDiasOcupa = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nudHospedaje = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAcerdaDe = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rbNegocio = new System.Windows.Forms.RadioButton();
            this.rbTurista = new System.Windows.Forms.RadioButton();
            this.grpServicios = new System.Windows.Forms.GroupBox();
            this.cbBar = new System.Windows.Forms.CheckBox();
            this.cbTelFax = new System.Windows.Forms.CheckBox();
            this.cbTV = new System.Windows.Forms.CheckBox();
            this.lbTotalHospedaje = new System.Windows.Forms.Label();
            this.lbTotalExtras = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbIVA = new System.Windows.Forms.Label();
            this.lbTotalPagar = new System.Windows.Forms.Label();
            this.txtTotalHospedaje = new System.Windows.Forms.TextBox();
            this.txtTotalExtras = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudHospedaje)).BeginInit();
            this.grpTipo.SuspendLayout();
            this.grpServicios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNombreApellidos
            // 
            this.lbNombreApellidos.AutoSize = true;
            this.lbNombreApellidos.Location = new System.Drawing.Point(52, 33);
            this.lbNombreApellidos.Name = "lbNombreApellidos";
            this.lbNombreApellidos.Size = new System.Drawing.Size(97, 13);
            this.lbNombreApellidos.TabIndex = 0;
            this.lbNombreApellidos.Text = "Nombre y Apellidos";
            // 
            // lbDiasOcupa
            // 
            this.lbDiasOcupa.AutoSize = true;
            this.lbDiasOcupa.Location = new System.Drawing.Point(52, 69);
            this.lbDiasOcupa.Name = "lbDiasOcupa";
            this.lbDiasOcupa.Size = new System.Drawing.Size(96, 13);
            this.lbDiasOcupa.TabIndex = 1;
            this.lbDiasOcupa.Text = "Dias de ocupación";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // nudHospedaje
            // 
            this.nudHospedaje.Location = new System.Drawing.Point(154, 69);
            this.nudHospedaje.Name = "nudHospedaje";
            this.nudHospedaje.Size = new System.Drawing.Size(54, 20);
            this.nudHospedaje.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(506, 27);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(506, 69);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAcerdaDe
            // 
            this.btnAcerdaDe.Location = new System.Drawing.Point(506, 115);
            this.btnAcerdaDe.Name = "btnAcerdaDe";
            this.btnAcerdaDe.Size = new System.Drawing.Size(75, 23);
            this.btnAcerdaDe.TabIndex = 6;
            this.btnAcerdaDe.Text = "Acerca de";
            this.btnAcerdaDe.UseVisualStyleBackColor = true;
            this.btnAcerdaDe.Click += new System.EventHandler(this.btnAcerdaDe_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(506, 160);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rbNegocio);
            this.grpTipo.Controls.Add(this.rbTurista);
            this.grpTipo.Location = new System.Drawing.Point(32, 115);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(200, 100);
            this.grpTipo.TabIndex = 8;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo";
            // 
            // rbNegocio
            // 
            this.rbNegocio.AutoSize = true;
            this.rbNegocio.Location = new System.Drawing.Point(42, 60);
            this.rbNegocio.Name = "rbNegocio";
            this.rbNegocio.Size = new System.Drawing.Size(65, 17);
            this.rbNegocio.TabIndex = 1;
            this.rbNegocio.TabStop = true;
            this.rbNegocio.Text = "Negocio";
            this.rbNegocio.UseVisualStyleBackColor = true;
            // 
            // rbTurista
            // 
            this.rbTurista.AutoSize = true;
            this.rbTurista.Location = new System.Drawing.Point(42, 36);
            this.rbTurista.Name = "rbTurista";
            this.rbTurista.Size = new System.Drawing.Size(57, 17);
            this.rbTurista.TabIndex = 0;
            this.rbTurista.TabStop = true;
            this.rbTurista.Text = "Turista";
            this.rbTurista.UseVisualStyleBackColor = true;
            // 
            // grpServicios
            // 
            this.grpServicios.Controls.Add(this.cbBar);
            this.grpServicios.Controls.Add(this.cbTelFax);
            this.grpServicios.Controls.Add(this.cbTV);
            this.grpServicios.Location = new System.Drawing.Point(261, 115);
            this.grpServicios.Name = "grpServicios";
            this.grpServicios.Size = new System.Drawing.Size(200, 100);
            this.grpServicios.TabIndex = 9;
            this.grpServicios.TabStop = false;
            this.grpServicios.Text = "Servicios";
            // 
            // cbBar
            // 
            this.cbBar.AutoSize = true;
            this.cbBar.Location = new System.Drawing.Point(31, 67);
            this.cbBar.Name = "cbBar";
            this.cbBar.Size = new System.Drawing.Size(68, 17);
            this.cbBar.TabIndex = 2;
            this.cbBar.Text = "Bar Libre";
            this.cbBar.UseVisualStyleBackColor = true;
            // 
            // cbTelFax
            // 
            this.cbTelFax.AutoSize = true;
            this.cbTelFax.Location = new System.Drawing.Point(31, 43);
            this.cbTelFax.Name = "cbTelFax";
            this.cbTelFax.Size = new System.Drawing.Size(96, 17);
            this.cbTelFax.TabIndex = 1;
            this.cbTelFax.Text = "Telefono / Fax";
            this.cbTelFax.UseVisualStyleBackColor = true;
            // 
            // cbTV
            // 
            this.cbTV.AutoSize = true;
            this.cbTV.Location = new System.Drawing.Point(31, 19);
            this.cbTV.Name = "cbTV";
            this.cbTV.Size = new System.Drawing.Size(70, 17);
            this.cbTV.TabIndex = 0;
            this.cbTV.Text = "TV Cable";
            this.cbTV.UseVisualStyleBackColor = true;
            // 
            // lbTotalHospedaje
            // 
            this.lbTotalHospedaje.AutoSize = true;
            this.lbTotalHospedaje.Location = new System.Drawing.Point(29, 241);
            this.lbTotalHospedaje.Name = "lbTotalHospedaje";
            this.lbTotalHospedaje.Size = new System.Drawing.Size(85, 13);
            this.lbTotalHospedaje.TabIndex = 10;
            this.lbTotalHospedaje.Text = "Total Hospedaje";
            // 
            // lbTotalExtras
            // 
            this.lbTotalExtras.AutoSize = true;
            this.lbTotalExtras.Location = new System.Drawing.Point(51, 269);
            this.lbTotalExtras.Name = "lbTotalExtras";
            this.lbTotalExtras.Size = new System.Drawing.Size(63, 13);
            this.lbTotalExtras.TabIndex = 11;
            this.lbTotalExtras.Text = "Total Extras";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(83, 298);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(31, 13);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Text = "Total";
            // 
            // lbIVA
            // 
            this.lbIVA.AutoSize = true;
            this.lbIVA.Location = new System.Drawing.Point(286, 241);
            this.lbIVA.Name = "lbIVA";
            this.lbIVA.Size = new System.Drawing.Size(47, 13);
            this.lbIVA.TabIndex = 13;
            this.lbIVA.Text = "IVA 21%";
            // 
            // lbTotalPagar
            // 
            this.lbTotalPagar.AutoSize = true;
            this.lbTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPagar.Location = new System.Drawing.Point(250, 269);
            this.lbTotalPagar.Name = "lbTotalPagar";
            this.lbTotalPagar.Size = new System.Drawing.Size(83, 13);
            this.lbTotalPagar.TabIndex = 14;
            this.lbTotalPagar.Text = "Total a pagar";
            // 
            // txtTotalHospedaje
            // 
            this.txtTotalHospedaje.Enabled = false;
            this.txtTotalHospedaje.Location = new System.Drawing.Point(120, 238);
            this.txtTotalHospedaje.Name = "txtTotalHospedaje";
            this.txtTotalHospedaje.Size = new System.Drawing.Size(100, 20);
            this.txtTotalHospedaje.TabIndex = 15;
            // 
            // txtTotalExtras
            // 
            this.txtTotalExtras.Enabled = false;
            this.txtTotalExtras.Location = new System.Drawing.Point(120, 269);
            this.txtTotalExtras.Name = "txtTotalExtras";
            this.txtTotalExtras.Size = new System.Drawing.Size(100, 20);
            this.txtTotalExtras.TabIndex = 16;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(120, 298);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 17;
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Location = new System.Drawing.Point(339, 238);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 18;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Location = new System.Drawing.Point(339, 269);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPagar.TabIndex = 19;
            // 
            // sistemaFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 328);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTotalExtras);
            this.Controls.Add(this.txtTotalHospedaje);
            this.Controls.Add(this.lbTotalPagar);
            this.Controls.Add(this.lbIVA);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbTotalExtras);
            this.Controls.Add(this.lbTotalHospedaje);
            this.Controls.Add(this.grpServicios);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAcerdaDe);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nudHospedaje);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbDiasOcupa);
            this.Controls.Add(this.lbNombreApellidos);
            this.Name = "sistemaFacturacion";
            this.Text = "Sistema de Facturación";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.sistemaFacturacion_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudHospedaje)).EndInit();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.grpServicios.ResumeLayout(false);
            this.grpServicios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombreApellidos;
        private System.Windows.Forms.Label lbDiasOcupa;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nudHospedaje;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAcerdaDe;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rbNegocio;
        private System.Windows.Forms.RadioButton rbTurista;
        private System.Windows.Forms.GroupBox grpServicios;
        private System.Windows.Forms.CheckBox cbBar;
        private System.Windows.Forms.CheckBox cbTelFax;
        private System.Windows.Forms.CheckBox cbTV;
        private System.Windows.Forms.Label lbTotalHospedaje;
        private System.Windows.Forms.Label lbTotalExtras;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbIVA;
        private System.Windows.Forms.Label lbTotalPagar;
        private System.Windows.Forms.TextBox txtTotalHospedaje;
        private System.Windows.Forms.TextBox txtTotalExtras;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtTotalPagar;
    }
}

