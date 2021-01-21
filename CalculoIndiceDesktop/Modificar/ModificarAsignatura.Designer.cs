namespace Proyecto_Tecnicas
{
    partial class ModificarAsignatura
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
            this.listViewAsignaturas = new System.Windows.Forms.ListView();
            this.textBoxBuscarAsig = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAsignaturas
            // 
            this.listViewAsignaturas.FullRowSelect = true;
            this.listViewAsignaturas.GridLines = true;
            this.listViewAsignaturas.HideSelection = false;
            this.listViewAsignaturas.Location = new System.Drawing.Point(75, 102);
            this.listViewAsignaturas.Name = "listViewAsignaturas";
            this.listViewAsignaturas.Size = new System.Drawing.Size(589, 306);
            this.listViewAsignaturas.TabIndex = 2;
            this.listViewAsignaturas.UseCompatibleStateImageBehavior = false;
            this.listViewAsignaturas.View = System.Windows.Forms.View.Details;
            this.listViewAsignaturas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewAsignaturas_MouseDoubleClick);
            // 
            // textBoxBuscarAsig
            // 
            this.textBoxBuscarAsig.Location = new System.Drawing.Point(506, 69);
            this.textBoxBuscarAsig.Name = "textBoxBuscarAsig";
            this.textBoxBuscarAsig.Size = new System.Drawing.Size(151, 20);
            this.textBoxBuscarAsig.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modificar Asignatura";
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(305, 447);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 5;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            //this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // ModificarAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 498);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBuscarAsig);
            this.Controls.Add(this.listViewAsignaturas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificarAsignatura";
            this.Text = "ModificarAsignatura";
            this.Load += new System.EventHandler(this.ListViewAsignaturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAsignaturas;
        private System.Windows.Forms.TextBox textBoxBuscarAsig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Volver;
    }
}