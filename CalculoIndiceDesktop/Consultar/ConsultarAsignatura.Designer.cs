namespace Proyecto_Tecnicas
{
    partial class ConsultarAsignatura
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
            this.listViewAsignaturas = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignaturas";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // listViewAsignaturas
            // 
            this.listViewAsignaturas.FullRowSelect = true;
            this.listViewAsignaturas.GridLines = true;
            this.listViewAsignaturas.HideSelection = false;
            this.listViewAsignaturas.Location = new System.Drawing.Point(26, 49);
            this.listViewAsignaturas.Margin = new System.Windows.Forms.Padding(2);
            this.listViewAsignaturas.Name = "listViewAsignaturas";
            this.listViewAsignaturas.Size = new System.Drawing.Size(359, 223);
            this.listViewAsignaturas.TabIndex = 1;
            this.listViewAsignaturas.UseCompatibleStateImageBehavior = false;
            this.listViewAsignaturas.View = System.Windows.Forms.View.Details;
            // 
            // ConsultarAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 340);
            this.Controls.Add(this.listViewAsignaturas);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultarAsignatura";
            this.Text = "ConsultarAsignatura";
            this.Load += new System.EventHandler(this.ListViewAsignaturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewAsignaturas;
    }
}