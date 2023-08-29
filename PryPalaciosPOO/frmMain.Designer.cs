namespace PryPalaciosPOO
{
    partial class frmMain
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFuerza = new System.Windows.Forms.TextBox();
            this.txtDestreza = new System.Windows.Forms.TextBox();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDestreza = new System.Windows.Forms.Label();
            this.gbPersonaje = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbPersonaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(190, 182);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtFuerza
            // 
            this.txtFuerza.Location = new System.Drawing.Point(125, 88);
            this.txtFuerza.Name = "txtFuerza";
            this.txtFuerza.Size = new System.Drawing.Size(100, 20);
            this.txtFuerza.TabIndex = 1;
            // 
            // txtDestreza
            // 
            this.txtDestreza.Location = new System.Drawing.Point(125, 141);
            this.txtDestreza.Name = "txtDestreza";
            this.txtDestreza.Size = new System.Drawing.Size(100, 20);
            this.txtDestreza.TabIndex = 2;
            // 
            // lblFuerza
            // 
            this.lblFuerza.Location = new System.Drawing.Point(3, 88);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(100, 23);
            this.lblFuerza.TabIndex = 4;
            this.lblFuerza.Text = "Fuerza";
            this.lblFuerza.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(3, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDestreza
            // 
            this.lblDestreza.Location = new System.Drawing.Point(3, 141);
            this.lblDestreza.Name = "lblDestreza";
            this.lblDestreza.Size = new System.Drawing.Size(100, 23);
            this.lblDestreza.TabIndex = 6;
            this.lblDestreza.Text = "Destreza";
            this.lblDestreza.Click += new System.EventHandler(this.label3_Click);
            // 
            // gbPersonaje
            // 
            this.gbPersonaje.Controls.Add(this.btnCrear);
            this.gbPersonaje.Controls.Add(this.lblNombre);
            this.gbPersonaje.Controls.Add(this.lblDestreza);
            this.gbPersonaje.Controls.Add(this.lblFuerza);
            this.gbPersonaje.Controls.Add(this.txtDestreza);
            this.gbPersonaje.Controls.Add(this.txtFuerza);
            this.gbPersonaje.Controls.Add(this.txtNombre);
            this.gbPersonaje.Location = new System.Drawing.Point(12, 26);
            this.gbPersonaje.Name = "gbPersonaje";
            this.gbPersonaje.Size = new System.Drawing.Size(292, 221);
            this.gbPersonaje.TabIndex = 7;
            this.gbPersonaje.TabStop = false;
            this.gbPersonaje.Text = "Seleccion personaje";
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(40, 269);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(264, 81);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "aqui los datos que creamos...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 368);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.gbPersonaje);
            this.Name = "frmMain";
            this.Text = "Creacion de Personajes";
            this.gbPersonaje.ResumeLayout(false);
            this.gbPersonaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFuerza;
        private System.Windows.Forms.TextBox txtDestreza;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDestreza;
        private System.Windows.Forms.GroupBox gbPersonaje;
        private System.Windows.Forms.Label lblInfo;
    }
}

