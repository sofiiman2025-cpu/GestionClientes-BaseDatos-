namespace GestionClientes_archivoCSV_
{
    partial class frmAgregar
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.Ciudad = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.grpCarga = new System.Windows.Forms.GroupBox();
            this.grpCarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(91, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre y apellido";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(20, 97);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(84, 13);
            this.lblLimite.TabIndex = 1;
            this.lblLimite.Text = "Limite de credito";
            // 
            // Ciudad
            // 
            this.Ciudad.AutoSize = true;
            this.Ciudad.Location = new System.Drawing.Point(20, 152);
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Size = new System.Drawing.Size(40, 13);
            this.Ciudad.TabIndex = 2;
            this.Ciudad.Text = "Ciudad";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(154, 152);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudad.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(154, 97);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(121, 20);
            this.txtLimite.TabIndex = 6;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(260, 208);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // grpCarga
            // 
            this.grpCarga.Controls.Add(this.txtLimite);
            this.grpCarga.Controls.Add(this.btnCargar);
            this.grpCarga.Controls.Add(this.lblNombre);
            this.grpCarga.Controls.Add(this.lblLimite);
            this.grpCarga.Controls.Add(this.txtNombre);
            this.grpCarga.Controls.Add(this.Ciudad);
            this.grpCarga.Controls.Add(this.cmbCiudad);
            this.grpCarga.Location = new System.Drawing.Point(12, 12);
            this.grpCarga.Name = "grpCarga";
            this.grpCarga.Size = new System.Drawing.Size(339, 255);
            this.grpCarga.TabIndex = 8;
            this.grpCarga.TabStop = false;
            this.grpCarga.Text = "Carga de datos";
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 275);
            this.Controls.Add(this.grpCarga);
            this.Name = "frmAgregar";
            this.Text = "frmAgregar";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            this.grpCarga.ResumeLayout(false);
            this.grpCarga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label Ciudad;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox grpCarga;
    }
}