namespace Actividad_Desempeño_1._2
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRegistro = new System.Windows.Forms.Button();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.Registro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registro y Consulta de Personas Empadronadas en guatemala";
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.Location = new System.Drawing.Point(178, 147);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Size = new System.Drawing.Size(97, 58);
            this.BtnRegistro.TabIndex = 7;
            this.BtnRegistro.Text = "Ingresar";
            this.BtnRegistro.UseVisualStyleBackColor = true;
            this.BtnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Location = new System.Drawing.Point(342, 147);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(97, 58);
            this.BtnConsulta.TabIndex = 8;
            this.BtnConsulta.Text = "Ingresar";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.Location = new System.Drawing.Point(178, 109);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(46, 13);
            this.Registro.TabIndex = 9;
            this.Registro.Text = "Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Consulta";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(501, 147);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(97, 58);
            this.BtnCerrar.TabIndex = 11;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 271);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.BtnConsulta);
            this.Controls.Add(this.BtnRegistro);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRegistro;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Label Registro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCerrar;
    }
}

