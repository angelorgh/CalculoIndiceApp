namespace Proyecto_Tecnicas
{
    partial class ChildModificarAsignatura
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
            this.label1 = new System.Windows.Forms.Label();
            this.Modificar = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCreditos = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modificar Asignatura";
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(170, 360);
            this.Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(100, 28);
            this.Modificar.TabIndex = 17;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(298, 360);
            this.Volver.Margin = new System.Windows.Forms.Padding(4);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(100, 28);
            this.Volver.TabIndex = 16;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Creditos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre";
            // 
            // textBoxCreditos
            // 
            this.textBoxCreditos.Location = new System.Drawing.Point(165, 292);
            this.textBoxCreditos.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCreditos.Name = "textBoxCreditos";
            this.textBoxCreditos.Size = new System.Drawing.Size(332, 22);
            this.textBoxCreditos.TabIndex = 12;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(165, 175);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(332, 22);
            this.textBoxNombre.TabIndex = 11;
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(165, 62);
            this.textBoxClave.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.ReadOnly = true;
            this.textBoxClave.Size = new System.Drawing.Size(332, 22);
            this.textBoxClave.TabIndex = 10;
            // 
            // ChildModificarAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCreditos);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.label1);
            this.Name = "ChildModificarAsignatura";
            this.Text = "ChildModificarAsignatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCreditos;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxClave;
    }
}