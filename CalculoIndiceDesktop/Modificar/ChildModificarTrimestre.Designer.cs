﻿namespace Proyecto_Tecnicas
{
    partial class ChildModificarTrimestre
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
            this.label1 = new System.Windows.Forms.Label();
            this.Modificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAsignaturas
            // 
            this.listViewAsignaturas.CheckBoxes = true;
            this.listViewAsignaturas.FullRowSelect = true;
            this.listViewAsignaturas.GridLines = true;
            this.listViewAsignaturas.HideSelection = false;
            this.listViewAsignaturas.Location = new System.Drawing.Point(68, 74);
            this.listViewAsignaturas.Name = "listViewAsignaturas";
            this.listViewAsignaturas.Size = new System.Drawing.Size(519, 364);
            this.listViewAsignaturas.TabIndex = 0;
            this.listViewAsignaturas.UseCompatibleStateImageBehavior = false;
            this.listViewAsignaturas.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modificar Trimestre";
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(278, 512);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 2;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // ChildModificarTrimestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 579);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewAsignaturas);
            this.Name = "ChildModificarTrimestre";
            this.Text = "ChildModificarTrimestre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAsignaturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Modificar;
    }
}