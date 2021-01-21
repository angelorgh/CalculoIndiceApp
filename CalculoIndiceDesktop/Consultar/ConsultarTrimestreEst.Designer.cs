namespace Proyecto_Tecnicas
{
    partial class ConsultarTrimestreEst
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
            this.label3 = new System.Windows.Forms.Label();
            this.listViewTrimestres = new System.Windows.Forms.ListView();
            this.Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Trimestre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccionar Trimestre";
            // 
            // listViewTrimestres
            // 
            this.listViewTrimestres.FullRowSelect = true;
            this.listViewTrimestres.GridLines = true;
            this.listViewTrimestres.Location = new System.Drawing.Point(143, 94);
            this.listViewTrimestres.Name = "listViewTrimestres";
            this.listViewTrimestres.Size = new System.Drawing.Size(600, 254);
            this.listViewTrimestres.TabIndex = 6;
            this.listViewTrimestres.UseCompatibleStateImageBehavior = false;
            this.listViewTrimestres.View = System.Windows.Forms.View.Details;
            this.listViewTrimestres.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewTrimestres_MouseDoubleClick);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(367, 396);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 7;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // ConsultarTrimestreEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 448);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.listViewTrimestres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarTrimestreEst";
            this.Text = "ConsultarTrimestre";
            this.Load += new System.EventHandler(this.ConsultarTrimestre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewTrimestres;
        private System.Windows.Forms.Button Volver;
    }
}