namespace Proyecto_Tecnicas
{
    partial class ConsultarEstudiante
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
            this.LabelEstudiante = new System.Windows.Forms.Label();
            this.listViewEstudiantes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // LabelEstudiante
            // 
            this.LabelEstudiante.AutoSize = true;
            this.LabelEstudiante.Location = new System.Drawing.Point(201, 40);
            this.LabelEstudiante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelEstudiante.Name = "LabelEstudiante";
            this.LabelEstudiante.Size = new System.Drawing.Size(57, 13);
            this.LabelEstudiante.TabIndex = 0;
            this.LabelEstudiante.Text = "Estudiante";
            // 
            // listViewEstudiantes
            // 
            this.listViewEstudiantes.FullRowSelect = true;
            this.listViewEstudiantes.GridLines = true;
            this.listViewEstudiantes.HideSelection = false;
            this.listViewEstudiantes.Location = new System.Drawing.Point(47, 55);
            this.listViewEstudiantes.Margin = new System.Windows.Forms.Padding(2);
            this.listViewEstudiantes.Name = "listViewEstudiantes";
            this.listViewEstudiantes.Size = new System.Drawing.Size(385, 219);
            this.listViewEstudiantes.TabIndex = 1;
            this.listViewEstudiantes.UseCompatibleStateImageBehavior = false;
            this.listViewEstudiantes.View = System.Windows.Forms.View.Details;
            // 
            // ConsultarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 366);
            this.Controls.Add(this.listViewEstudiantes);
            this.Controls.Add(this.LabelEstudiante);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultarEstudiante";
            this.Text = "ConsultarEstudiante";
            this.Load += new System.EventHandler(this.InsertarEstudiante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelEstudiante;
        private System.Windows.Forms.ListView listViewEstudiantes;
    }
}