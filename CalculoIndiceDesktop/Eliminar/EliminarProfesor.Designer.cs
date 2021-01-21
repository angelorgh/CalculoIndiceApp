namespace Proyecto_Tecnicas
{
    partial class EliminarProfesor
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
            this.listViewProfesores = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBuscarProf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewProfesores
            // 
            this.listViewProfesores.CheckBoxes = true;
            this.listViewProfesores.FullRowSelect = true;
            this.listViewProfesores.GridLines = true;
            this.listViewProfesores.HideSelection = false;
            this.listViewProfesores.Location = new System.Drawing.Point(156, 95);
            this.listViewProfesores.Name = "listViewProfesores";
            this.listViewProfesores.Size = new System.Drawing.Size(506, 286);
            this.listViewProfesores.TabIndex = 0;
            this.listViewProfesores.UseCompatibleStateImageBehavior = false;
            this.listViewProfesores.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrar Profesores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione profesores";
            // 
            // textBoxBuscarProf
            // 
            this.textBoxBuscarProf.Location = new System.Drawing.Point(509, 69);
            this.textBoxBuscarProf.Name = "textBoxBuscarProf";
            this.textBoxBuscarProf.Size = new System.Drawing.Size(153, 20);
            this.textBoxBuscarProf.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buscar";
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(351, 436);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 5;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // EliminarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBuscarProf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewProfesores);
            this.Name = "EliminarProfesor";
            this.Text = "EliminarProfesor";
            this.Load += new System.EventHandler(this.EliminarProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProfesores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBuscarProf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Borrar;
    }
}