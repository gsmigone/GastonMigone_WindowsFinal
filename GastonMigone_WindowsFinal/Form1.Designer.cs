namespace GastonMigone_WindowsFinal
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
            this.btnVal = new System.Windows.Forms.Button();
            this.btnMos = new System.Windows.Forms.Button();
            this.btnHor = new System.Windows.Forms.Button();
            this.btnLim = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtSue = new System.Windows.Forms.TextBox();
            this.txtPue = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVal
            // 
            this.btnVal.Location = new System.Drawing.Point(285, 37);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(87, 23);
            this.btnVal.TabIndex = 0;
            this.btnVal.Text = "Validaciones";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            // 
            // btnMos
            // 
            this.btnMos.Location = new System.Drawing.Point(285, 90);
            this.btnMos.Name = "btnMos";
            this.btnMos.Size = new System.Drawing.Size(87, 23);
            this.btnMos.TabIndex = 1;
            this.btnMos.Text = "Mostrar";
            this.btnMos.UseVisualStyleBackColor = true;
            this.btnMos.Click += new System.EventHandler(this.btnMos_Click);
            // 
            // btnHor
            // 
            this.btnHor.Location = new System.Drawing.Point(285, 146);
            this.btnHor.Name = "btnHor";
            this.btnHor.Size = new System.Drawing.Size(87, 23);
            this.btnHor.TabIndex = 2;
            this.btnHor.Text = "Ingresar horas";
            this.btnHor.UseVisualStyleBackColor = true;
            this.btnHor.Click += new System.EventHandler(this.btnHor_Click);
            // 
            // btnLim
            // 
            this.btnLim.Location = new System.Drawing.Point(285, 198);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(87, 23);
            this.btnLim.TabIndex = 3;
            this.btnLim.Text = "Limpiar";
            this.btnLim.UseVisualStyleBackColor = true;
            this.btnLim.Click += new System.EventHandler(this.btnLim_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(135, 37);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 4;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(135, 90);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(100, 20);
            this.txtApe.TabIndex = 5;
            // 
            // txtSue
            // 
            this.txtSue.Location = new System.Drawing.Point(135, 146);
            this.txtSue.Name = "txtSue";
            this.txtSue.Size = new System.Drawing.Size(100, 20);
            this.txtSue.TabIndex = 6;
            // 
            // txtPue
            // 
            this.txtPue.Location = new System.Drawing.Point(135, 198);
            this.txtPue.Name = "txtPue";
            this.txtPue.Size = new System.Drawing.Size(100, 20);
            this.txtPue.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(51, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(51, 90);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 13);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "APELLIDO:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(51, 146);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(54, 13);
            this.lblSueldo.TabIndex = 10;
            this.lblSueldo.Text = "SUELDO:";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(51, 198);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(54, 13);
            this.lblPuesto.TabIndex = 11;
            this.lblPuesto.Text = "PUESTO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 268);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtPue);
            this.Controls.Add(this.txtSue);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnLim);
            this.Controls.Add(this.btnHor);
            this.Controls.Add(this.btnMos);
            this.Controls.Add(this.btnVal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.Button btnMos;
        private System.Windows.Forms.Button btnHor;
        private System.Windows.Forms.Button btnLim;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.TextBox txtSue;
        private System.Windows.Forms.TextBox txtPue;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblPuesto;
    }
}

