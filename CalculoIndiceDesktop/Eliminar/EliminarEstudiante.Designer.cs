﻿namespace Proyecto_Tecnicas
{
    partial class EliminarEstudiante
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
            this.label2 = new System.Windows.Forms.Label();
            this.listViewEstudiantes = new System.Windows.Forms.ListView();
            this.textBoxBuscarEst = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Borrar = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrar Estudiantes";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione los estudiantes";
            // 
            // listViewEstudiantes
            // 
            this.listViewEstudiantes.CheckBoxes = true;
            this.listViewEstudiantes.GridLines = true;
            this.listViewEstudiantes.Location = new System.Drawing.Point(148, 80);
            this.listViewEstudiantes.Name = "listViewEstudiantes";
            this.listViewEstudiantes.Size = new System.Drawing.Size(495, 307);
            this.listViewEstudiantes.TabIndex = 2;
            this.listViewEstudiantes.UseCompatibleStateImageBehavior = false;
            this.listViewEstudiantes.View = System.Windows.Forms.View.Details;
            // 
            // textBoxBuscarEst
            // 
            this.textBoxBuscarEst.Location = new System.Drawing.Point(473, 54);
            this.textBoxBuscarEst.Name = "textBoxBuscarEst";
            this.textBoxBuscarEst.Size = new System.Drawing.Size(170, 20);
            this.textBoxBuscarEst.TabIndex = 3;
            this.textBoxBuscarEst.TextChanged += new System.EventHandler(this.textBoxBuscarEst_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Buscar";
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(251, 404);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 5;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(365, 404);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 6;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // EliminarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 457);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBuscarEst);
            this.Controls.Add(this.listViewEstudiantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EliminarEstudiante";
            this.Text = "EliminarEstudiante";
            this.Load += new System.EventHandler(this.EliminarEstudiante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewEstudiantes;
        private System.Windows.Forms.TextBox textBoxBuscarEst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Volver;
    }
}