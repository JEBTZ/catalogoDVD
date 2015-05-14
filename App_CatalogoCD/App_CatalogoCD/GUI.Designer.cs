namespace App_CatalogoCD
{
    partial class GUI
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.tbxVarios = new System.Windows.Forms.TextBox();
            this.lblAccion = new System.Windows.Forms.Label();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnPaises = new System.Windows.Forms.Button();
            this.btnVolcar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAlAzar = new System.Windows.Forms.Button();
            this.btnLeerAXml = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(342, 420);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 25;
            // 
            // tbxVarios
            // 
            this.tbxVarios.Enabled = false;
            this.tbxVarios.Location = new System.Drawing.Point(345, 94);
            this.tbxVarios.Name = "tbxVarios";
            this.tbxVarios.Size = new System.Drawing.Size(402, 20);
            this.tbxVarios.TabIndex = 24;
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(342, 64);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(0, 13);
            this.lblAccion.TabIndex = 23;
            // 
            // rtbResultado
            // 
            this.rtbResultado.Location = new System.Drawing.Point(345, 123);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(528, 277);
            this.rtbResultado.TabIndex = 22;
            this.rtbResultado.Text = "";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(743, 16);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(64, 25);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnPaises
            // 
            this.btnPaises.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnPaises.FlatAppearance.BorderSize = 5;
            this.btnPaises.Location = new System.Drawing.Point(24, 382);
            this.btnPaises.Name = "btnPaises";
            this.btnPaises.Size = new System.Drawing.Size(213, 25);
            this.btnPaises.TabIndex = 20;
            this.btnPaises.Text = "Listar DVD por pais";
            this.btnPaises.UseVisualStyleBackColor = true;
            this.btnPaises.Click += new System.EventHandler(this.btnPaises_Click);
            // 
            // btnVolcar
            // 
            this.btnVolcar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnVolcar.FlatAppearance.BorderSize = 5;
            this.btnVolcar.Location = new System.Drawing.Point(24, 327);
            this.btnVolcar.Name = "btnVolcar";
            this.btnVolcar.Size = new System.Drawing.Size(213, 25);
            this.btnVolcar.TabIndex = 19;
            this.btnVolcar.Text = "Volcar XML a fichero";
            this.btnVolcar.UseVisualStyleBackColor = true;
            this.btnVolcar.Click += new System.EventHandler(this.btnVolcar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnModificar.FlatAppearance.BorderSize = 5;
            this.btnModificar.Location = new System.Drawing.Point(24, 272);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(213, 25);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar un DVD";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnEliminar.FlatAppearance.BorderSize = 5;
            this.btnEliminar.Location = new System.Drawing.Point(24, 217);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(213, 25);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar un DVD";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnAlAzar
            // 
            this.btnAlAzar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAlAzar.FlatAppearance.BorderSize = 5;
            this.btnAlAzar.Location = new System.Drawing.Point(24, 162);
            this.btnAlAzar.Name = "btnAlAzar";
            this.btnAlAzar.Size = new System.Drawing.Size(213, 25);
            this.btnAlAzar.TabIndex = 16;
            this.btnAlAzar.Text = "Añadir un DVD con datos al azar";
            this.btnAlAzar.UseVisualStyleBackColor = true;
            this.btnAlAzar.Click += new System.EventHandler(this.btnAlAzar_Click_1);
            // 
            // btnLeerAXml
            // 
            this.btnLeerAXml.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnLeerAXml.FlatAppearance.BorderSize = 5;
            this.btnLeerAXml.Location = new System.Drawing.Point(24, 107);
            this.btnLeerAXml.Name = "btnLeerAXml";
            this.btnLeerAXml.Size = new System.Drawing.Size(213, 25);
            this.btnLeerAXml.TabIndex = 15;
            this.btnLeerAXml.Text = "Leer todos los DVD\'s en XML";
            this.btnLeerAXml.UseVisualStyleBackColor = true;
            this.btnLeerAXml.Click += new System.EventHandler(this.btnLeerAXml_Click_1);
            // 
            // btnLeer
            // 
            this.btnLeer.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnLeer.FlatAppearance.BorderSize = 5;
            this.btnLeer.Location = new System.Drawing.Point(24, 54);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(213, 23);
            this.btnLeer.TabIndex = 14;
            this.btnLeer.Text = "Leer todos los DVD\'s";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Azure;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(21, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(311, 17);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Lectura y modificación del listado de DVD";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(904, 442);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.tbxVarios);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnPaises);
            this.Controls.Add(this.btnVolcar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAlAzar);
            this.Controls.Add(this.btnLeerAXml);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.lblTitulo);
            this.Name = "GUI";
            this.Text = "GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox tbxVarios;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnPaises;
        private System.Windows.Forms.Button btnVolcar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAlAzar;
        private System.Windows.Forms.Button btnLeerAXml;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Label lblTitulo;
    }
}