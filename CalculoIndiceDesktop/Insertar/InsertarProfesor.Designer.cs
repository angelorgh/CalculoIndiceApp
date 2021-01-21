namespace Proyecto_Tecnicas
{
    partial class InsertarProfesor
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
            this.NombreProfesor = new System.Windows.Forms.Label();
            this.textBoxNombreProf = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Profesor";
            // 
            // NombreProfesor
            // 
            this.NombreProfesor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreProfesor.AutoSize = true;
            this.NombreProfesor.Location = new System.Drawing.Point(32, 58);
            this.NombreProfesor.Name = "NombreProfesor";
            this.NombreProfesor.Size = new System.Drawing.Size(44, 13);
            this.NombreProfesor.TabIndex = 3;
            this.NombreProfesor.Text = "Nombre";
            // 
            // textBoxNombreProf
            // 
            this.textBoxNombreProf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombreProf.Location = new System.Drawing.Point(99, 55);
            this.textBoxNombreProf.Name = "textBoxNombreProf";
            this.textBoxNombreProf.Size = new System.Drawing.Size(131, 20);
            this.textBoxNombreProf.TabIndex = 4;
            this.textBoxNombreProf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreProf_KeyPress);
            // 
            // Agregar
            // 
            this.Agregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Agregar.Location = new System.Drawing.Point(99, 174);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 5;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Location = new System.Drawing.Point(99, 113);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(131, 20);
            this.textBoxPassword.TabIndex = 8;
            // 
            // InsertarProfesor
            // 
            this.AcceptButton = this.Agregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 209);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.textBoxNombreProf);
            this.Controls.Add(this.NombreProfesor);
            this.Controls.Add(this.label1);
            this.Name = "InsertarProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InsertarProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NombreProfesor;
        private System.Windows.Forms.TextBox textBoxNombreProf;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}