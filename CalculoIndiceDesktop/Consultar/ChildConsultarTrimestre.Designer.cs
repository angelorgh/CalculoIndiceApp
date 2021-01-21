namespace Proyecto_Tecnicas
{
    partial class ChildConsultarTrimestre
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
            this.textBoxCreditos = new System.Windows.Forms.TextBox();
            this.textBoxIndice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewAsignaturas
            // 
            this.listViewAsignaturas.FullRowSelect = true;
            this.listViewAsignaturas.GridLines = true;
            this.listViewAsignaturas.HideSelection = false;
            this.listViewAsignaturas.Location = new System.Drawing.Point(95, 75);
            this.listViewAsignaturas.Name = "listViewAsignaturas";
            this.listViewAsignaturas.Size = new System.Drawing.Size(583, 369);
            this.listViewAsignaturas.TabIndex = 0;
            this.listViewAsignaturas.UseCompatibleStateImageBehavior = false;
            this.listViewAsignaturas.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultar Trimestre";
            // 
            // textBoxCreditos
            // 
            this.textBoxCreditos.Location = new System.Drawing.Point(578, 459);
            this.textBoxCreditos.Name = "textBoxCreditos";
            this.textBoxCreditos.ReadOnly = true;
            this.textBoxCreditos.Size = new System.Drawing.Size(100, 20);
            this.textBoxCreditos.TabIndex = 2;
            // 
            // textBoxIndice
            // 
            this.textBoxIndice.Location = new System.Drawing.Point(578, 502);
            this.textBoxIndice.Name = "textBoxIndice";
            this.textBoxIndice.ReadOnly = true;
            this.textBoxIndice.Size = new System.Drawing.Size(100, 20);
            this.textBoxIndice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Creditos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Indice Trimestral";
            // 
            // ChildConsultarTrimestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 598);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIndice);
            this.Controls.Add(this.textBoxCreditos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewAsignaturas);
            this.Name = "ChildConsultarTrimestre";
            this.Text = "ChildConsultarTrimestre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAsignaturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCreditos;
        private System.Windows.Forms.TextBox textBoxIndice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}