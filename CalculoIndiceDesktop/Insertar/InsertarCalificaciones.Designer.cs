namespace Proyecto_Tecnicas
{
    partial class InsertarCalificaciones
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
            this.label3 = new System.Windows.Forms.Label();
            this.listViewTrimestres = new System.Windows.Forms.ListView();
            this.textBoxBuscarEst = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insertar o Modificar Calificaciones";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione un Estudiante";
            // 
            // listViewEstudiantes
            // 
            this.listViewEstudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEstudiantes.CheckBoxes = true;
            this.listViewEstudiantes.FullRowSelect = true;
            this.listViewEstudiantes.GridLines = true;
            this.listViewEstudiantes.HideSelection = false;
            this.listViewEstudiantes.Location = new System.Drawing.Point(139, 80);
            this.listViewEstudiantes.Name = "listViewEstudiantes";
            this.listViewEstudiantes.Size = new System.Drawing.Size(493, 196);
            this.listViewEstudiantes.TabIndex = 2;
            this.listViewEstudiantes.UseCompatibleStateImageBehavior = false;
            this.listViewEstudiantes.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione un Trimestre";
            // 
            // listViewTrimestres
            // 
            this.listViewTrimestres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTrimestres.CausesValidation = false;
            this.listViewTrimestres.FullRowSelect = true;
            this.listViewTrimestres.GridLines = true;
            this.listViewTrimestres.HideSelection = false;
            this.listViewTrimestres.Location = new System.Drawing.Point(139, 356);
            this.listViewTrimestres.Name = "listViewTrimestres";
            this.listViewTrimestres.Size = new System.Drawing.Size(493, 213);
            this.listViewTrimestres.TabIndex = 7;
            this.listViewTrimestres.UseCompatibleStateImageBehavior = false;
            this.listViewTrimestres.View = System.Windows.Forms.View.Details;
            this.listViewTrimestres.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewTrimestres_MouseDoubleClick);
            // 
            // textBoxBuscarEst
            // 
            this.textBoxBuscarEst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscarEst.Location = new System.Drawing.Point(478, 54);
            this.textBoxBuscarEst.Name = "textBoxBuscarEst";
            this.textBoxBuscarEst.Size = new System.Drawing.Size(154, 20);
            this.textBoxBuscarEst.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Buscar";
            // 
            // InsertarCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 682);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBuscarEst);
            this.Controls.Add(this.listViewTrimestres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewEstudiantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertarCalificaciones";
            this.Text = "InsertarCalificaciones";
            this.Load += new System.EventHandler(this.InsertarCalificaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewEstudiantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewTrimestres;
        private System.Windows.Forms.TextBox textBoxBuscarEst;
        private System.Windows.Forms.Label label4;
    }
}