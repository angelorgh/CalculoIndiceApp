namespace Proyecto_Tecnicas
{
    partial class ModificarTrimestre
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
            this.listViewTrimestres = new System.Windows.Forms.ListView();
            this.textBoxBuscarEst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewEstudiantes
            // 
            this.listViewEstudiantes.CheckBoxes = true;
            this.listViewEstudiantes.FullRowSelect = true;
            this.listViewEstudiantes.GridLines = true;
            this.listViewEstudiantes.Location = new System.Drawing.Point(172, 72);
            this.listViewEstudiantes.Name = "listViewEstudiantes";
            this.listViewEstudiantes.Size = new System.Drawing.Size(496, 200);
            this.listViewEstudiantes.TabIndex = 0;
            this.listViewEstudiantes.UseCompatibleStateImageBehavior = false;
            this.listViewEstudiantes.View = System.Windows.Forms.View.Details;
            // 
            // listViewTrimestres
            // 
            this.listViewTrimestres.FullRowSelect = true;
            this.listViewTrimestres.GridLines = true;
            this.listViewTrimestres.Location = new System.Drawing.Point(172, 344);
            this.listViewTrimestres.Name = "listViewTrimestres";
            this.listViewTrimestres.Size = new System.Drawing.Size(496, 200);
            this.listViewTrimestres.TabIndex = 1;
            this.listViewTrimestres.UseCompatibleStateImageBehavior = false;
            this.listViewTrimestres.View = System.Windows.Forms.View.Details;
            this.listViewTrimestres.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewTrimestres_MouseDoubleClick);
            // 
            // textBoxBuscarEst
            // 
            this.textBoxBuscarEst.Location = new System.Drawing.Point(521, 46);
            this.textBoxBuscarEst.Name = "textBoxBuscarEst";
            this.textBoxBuscarEst.Size = new System.Drawing.Size(147, 20);
            this.textBoxBuscarEst.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione un Estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione un trimestre";
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(340, 612);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 6;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // ModificarTrimestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 672);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBuscarEst);
            this.Controls.Add(this.listViewTrimestres);
            this.Controls.Add(this.listViewEstudiantes);
            this.Name = "ModificarTrimestre";
            this.Text = "ModificarTrimestre";
            this.Load += new System.EventHandler(this.ModificarTrimestre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEstudiantes;
        private System.Windows.Forms.ListView listViewTrimestres;
        private System.Windows.Forms.TextBox textBoxBuscarEst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Volver;
    }
}