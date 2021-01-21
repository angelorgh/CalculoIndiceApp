namespace Proyecto_Tecnicas
{
    partial class EliminarTrimestre
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
            this.listViewEstudiantes = new System.Windows.Forms.ListView();
            this.textBoxBuscarEst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewTrimestres = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.Borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewEstudiantes
            // 
            this.listViewEstudiantes.CheckBoxes = true;
            this.listViewEstudiantes.FullRowSelect = true;
            this.listViewEstudiantes.GridLines = true;
            this.listViewEstudiantes.HideSelection = false;
            this.listViewEstudiantes.Location = new System.Drawing.Point(166, 82);
            this.listViewEstudiantes.Name = "listViewEstudiantes";
            this.listViewEstudiantes.Size = new System.Drawing.Size(578, 267);
            this.listViewEstudiantes.TabIndex = 0;
            this.listViewEstudiantes.UseCompatibleStateImageBehavior = false;
            this.listViewEstudiantes.View = System.Windows.Forms.View.Details;
            // 
            // textBoxBuscarEst
            // 
            this.textBoxBuscarEst.Location = new System.Drawing.Point(566, 56);
            this.textBoxBuscarEst.Name = "textBoxBuscarEst";
            this.textBoxBuscarEst.Size = new System.Drawing.Size(178, 20);
            this.textBoxBuscarEst.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione un estudiante";
            // 
            // listViewTrimestres
            // 
            this.listViewTrimestres.CheckBoxes = true;
            this.listViewTrimestres.FullRowSelect = true;
            this.listViewTrimestres.GridLines = true;
            this.listViewTrimestres.HideSelection = false;
            this.listViewTrimestres.Location = new System.Drawing.Point(166, 411);
            this.listViewTrimestres.Name = "listViewTrimestres";
            this.listViewTrimestres.Size = new System.Drawing.Size(578, 249);
            this.listViewTrimestres.TabIndex = 4;
            this.listViewTrimestres.UseCompatibleStateImageBehavior = false;
            this.listViewTrimestres.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione los trimestres";
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(375, 692);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 6;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // EliminarTrimestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 752);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewTrimestres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBuscarEst);
            this.Controls.Add(this.listViewEstudiantes);
            this.Name = "EliminarTrimestre";
            this.Text = "EliminarTrimestre";
            this.Load += new System.EventHandler(this.EliminarTrimestre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEstudiantes;
        private System.Windows.Forms.TextBox textBoxBuscarEst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewTrimestres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Borrar;
    }
}