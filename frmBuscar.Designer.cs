namespace GestionClientes_archivoCSV_
{
    partial class frmBuscar
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblDeu = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblLim = new System.Windows.Forms.Label();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(22, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(91, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo del cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(319, 72);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpDatos.Controls.Add(this.lblLim);
            this.grpDatos.Controls.Add(this.lblDeu);
            this.grpDatos.Controls.Add(this.lblNom);
            this.grpDatos.Controls.Add(this.lblLimite);
            this.grpDatos.Controls.Add(this.lblDeuda);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Location = new System.Drawing.Point(29, 122);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(365, 161);
            this.grpDatos.TabIndex = 4;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del cliente";
            // 
            // lblDeu
            // 
            this.lblDeu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeu.Location = new System.Drawing.Point(201, 74);
            this.lblDeu.Name = "lblDeu";
            this.lblDeu.Size = new System.Drawing.Size(98, 14);
            this.lblDeu.TabIndex = 5;
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNom.Location = new System.Drawing.Point(201, 32);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(98, 15);
            this.lblNom.TabIndex = 4;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(11, 121);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(84, 13);
            this.lblLimite.TabIndex = 3;
            this.lblLimite.Text = "Limite de credito";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(11, 75);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(39, 13);
            this.lblDeuda.TabIndex = 2;
            this.lblDeuda.Text = "Deuda";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(25, 301);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(319, 301);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(171, 301);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(164, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(106, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // lblLim
            // 
            this.lblLim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLim.Location = new System.Drawing.Point(201, 121);
            this.lblLim.Name = "lblLim";
            this.lblLim.Size = new System.Drawing.Size(98, 14);
            this.lblLim.TabIndex = 6;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(416, 338);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmBuscar";
            this.Text = "Buscar";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblDeu;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblLim;
    }
}