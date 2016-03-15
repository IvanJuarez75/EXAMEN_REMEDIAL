namespace REM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtArch = new System.Windows.Forms.TextBox();
            this.btnArch1 = new System.Windows.Forms.Button();
            this.btnArch2 = new System.Windows.Forms.Button();
            this.btnCombi = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtGuardar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvCombinar = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArch
            // 
            this.txtArch.Location = new System.Drawing.Point(23, 60);
            this.txtArch.Multiline = true;
            this.txtArch.Name = "txtArch";
            this.txtArch.Size = new System.Drawing.Size(131, 236);
            this.txtArch.TabIndex = 0;
            // 
            // btnArch1
            // 
            this.btnArch1.Location = new System.Drawing.Point(23, 11);
            this.btnArch1.Name = "btnArch1";
            this.btnArch1.Size = new System.Drawing.Size(75, 43);
            this.btnArch1.TabIndex = 2;
            this.btnArch1.Text = "Escribir Archivo 1";
            this.btnArch1.UseVisualStyleBackColor = true;
            this.btnArch1.Click += new System.EventHandler(this.btnArch1_Click);
            // 
            // btnArch2
            // 
            this.btnArch2.Location = new System.Drawing.Point(104, 12);
            this.btnArch2.Name = "btnArch2";
            this.btnArch2.Size = new System.Drawing.Size(75, 42);
            this.btnArch2.TabIndex = 3;
            this.btnArch2.Text = "Escribir Archivo 2";
            this.btnArch2.UseVisualStyleBackColor = true;
            this.btnArch2.Click += new System.EventHandler(this.btnArch2_Click);
            // 
            // btnCombi
            // 
            this.btnCombi.Location = new System.Drawing.Point(221, 11);
            this.btnCombi.Name = "btnCombi";
            this.btnCombi.Size = new System.Drawing.Size(75, 43);
            this.btnCombi.TabIndex = 4;
            this.btnCombi.Text = "Combinar y mostrar";
            this.btnCombi.UseVisualStyleBackColor = true;
            this.btnCombi.Click += new System.EventHandler(this.btnCombi_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(333, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtGuardar
            // 
            this.txtGuardar.Location = new System.Drawing.Point(345, 41);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(100, 20);
            this.txtGuardar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Se debe seleccionar la ruta para el guardado";
            // 
            // lvCombinar
            // 
            this.lvCombinar.Location = new System.Drawing.Point(184, 60);
            this.lvCombinar.Name = "lvCombinar";
            this.lvCombinar.Size = new System.Drawing.Size(144, 236);
            this.lvCombinar.TabIndex = 1;
            this.lvCombinar.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "No es necesario la extension .txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 304);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCombi);
            this.Controls.Add(this.btnArch2);
            this.Controls.Add(this.btnArch1);
            this.Controls.Add(this.lvCombinar);
            this.Controls.Add(this.txtArch);
            this.Name = "Form1";
            this.Text = "Archivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArch;
        private System.Windows.Forms.Button btnArch1;
        private System.Windows.Forms.Button btnArch2;
        private System.Windows.Forms.Button btnCombi;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvCombinar;
        private System.Windows.Forms.Label label2;
    }
}

