namespace Proyecto_Tecnicas
{
    partial class InsertarAsignatura
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
            this.ClaveAsignatura = new System.Windows.Forms.Label();
            this.NombreAsignatura = new System.Windows.Forms.Label();
            this.CreditosAsignatura = new System.Windows.Forms.Label();
            this.textBoxClaveAsig1 = new System.Windows.Forms.TextBox();
            this.textBoxNombreAsig = new System.Windows.Forms.TextBox();
            this.textBoxCreditosAsig = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.textBoxClaveAsig2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Asignatura";
            // 
            // ClaveAsignatura
            // 
            this.ClaveAsignatura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClaveAsignatura.AutoSize = true;
            this.ClaveAsignatura.Location = new System.Drawing.Point(55, 55);
            this.ClaveAsignatura.Name = "ClaveAsignatura";
            this.ClaveAsignatura.Size = new System.Drawing.Size(34, 13);
            this.ClaveAsignatura.TabIndex = 1;
            this.ClaveAsignatura.Text = "Clave";
            // 
            // NombreAsignatura
            // 
            this.NombreAsignatura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreAsignatura.AutoSize = true;
            this.NombreAsignatura.Location = new System.Drawing.Point(45, 109);
            this.NombreAsignatura.Name = "NombreAsignatura";
            this.NombreAsignatura.Size = new System.Drawing.Size(44, 13);
            this.NombreAsignatura.TabIndex = 2;
            this.NombreAsignatura.Text = "Nombre";
            // 
            // CreditosAsignatura
            // 
            this.CreditosAsignatura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditosAsignatura.AutoSize = true;
            this.CreditosAsignatura.Location = new System.Drawing.Point(44, 164);
            this.CreditosAsignatura.Name = "CreditosAsignatura";
            this.CreditosAsignatura.Size = new System.Drawing.Size(45, 13);
            this.CreditosAsignatura.TabIndex = 3;
            this.CreditosAsignatura.Text = "Creditos";
            // 
            // textBoxClaveAsig1
            // 
            this.textBoxClaveAsig1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClaveAsig1.Location = new System.Drawing.Point(112, 52);
            this.textBoxClaveAsig1.MaxLength = 3;
            this.textBoxClaveAsig1.Name = "textBoxClaveAsig1";
            this.textBoxClaveAsig1.Size = new System.Drawing.Size(50, 20);
            this.textBoxClaveAsig1.TabIndex = 4;
            this.textBoxClaveAsig1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxClaveAsig1_KeyPress);
            // 
            // textBoxNombreAsig
            // 
            this.textBoxNombreAsig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombreAsig.Location = new System.Drawing.Point(112, 102);
            this.textBoxNombreAsig.Name = "textBoxNombreAsig";
            this.textBoxNombreAsig.Size = new System.Drawing.Size(116, 20);
            this.textBoxNombreAsig.TabIndex = 5;
            // 
            // textBoxCreditosAsig
            // 
            this.textBoxCreditosAsig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCreditosAsig.Location = new System.Drawing.Point(112, 157);
            this.textBoxCreditosAsig.MaxLength = 1;
            this.textBoxCreditosAsig.Name = "textBoxCreditosAsig";
            this.textBoxCreditosAsig.Size = new System.Drawing.Size(116, 20);
            this.textBoxCreditosAsig.TabIndex = 6;
            this.textBoxCreditosAsig.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCreditosAsig_KeyPress);
            // 
            // Agregar
            // 
            this.Agregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Agregar.Location = new System.Drawing.Point(92, 220);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 7;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // textBoxClaveAsig2
            // 
            this.textBoxClaveAsig2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClaveAsig2.Location = new System.Drawing.Point(178, 52);
            this.textBoxClaveAsig2.MaxLength = 3;
            this.textBoxClaveAsig2.Name = "textBoxClaveAsig2";
            this.textBoxClaveAsig2.Size = new System.Drawing.Size(50, 20);
            this.textBoxClaveAsig2.TabIndex = 9;
            this.textBoxClaveAsig2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxClaveAsig2_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "-";
            // 
            // InsertarAsignatura
            // 
            this.AcceptButton = this.Agregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxClaveAsig2);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.textBoxCreditosAsig);
            this.Controls.Add(this.textBoxNombreAsig);
            this.Controls.Add(this.textBoxClaveAsig1);
            this.Controls.Add(this.CreditosAsignatura);
            this.Controls.Add(this.NombreAsignatura);
            this.Controls.Add(this.ClaveAsignatura);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(298, 294);
            this.Name = "InsertarAsignatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InsertarAsignatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClaveAsignatura;
        private System.Windows.Forms.Label NombreAsignatura;
        private System.Windows.Forms.Label CreditosAsignatura;
        private System.Windows.Forms.TextBox textBoxClaveAsig1;
        private System.Windows.Forms.TextBox textBoxNombreAsig;
        private System.Windows.Forms.TextBox textBoxCreditosAsig;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.TextBox textBoxClaveAsig2;
        private System.Windows.Forms.Label label2;
    }
}