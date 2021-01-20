namespace Proyecto_Tecnicas
{
    partial class ConsultarProfesor
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
            this.listViewProfesores = new System.Windows.Forms.ListView();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profesores:";
            // 
            // listViewProfesores
            // 
            this.listViewProfesores.FullRowSelect = true;
            this.listViewProfesores.GridLines = true;
            this.listViewProfesores.Location = new System.Drawing.Point(60, 51);
            this.listViewProfesores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewProfesores.Name = "listViewProfesores";
            this.listViewProfesores.Size = new System.Drawing.Size(349, 256);
            this.listViewProfesores.TabIndex = 1;
            this.listViewProfesores.UseCompatibleStateImageBehavior = false;
            this.listViewProfesores.View = System.Windows.Forms.View.Details;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(199, 320);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(72, 35);
            this.buttonVolver.TabIndex = 2;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.ButtonVolver_Click);
            // 
            // ConsultarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 366);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.listViewProfesores);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultarProfesor";
            this.Text = "ConsultarProfesor";
            this.Load += new System.EventHandler(this.ListProfesores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewProfesores;
        private System.Windows.Forms.Button buttonVolver;
    }
}