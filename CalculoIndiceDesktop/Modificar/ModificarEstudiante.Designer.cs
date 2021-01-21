namespace Proyecto_Tecnicas
{
    partial class ModificarEstudiante
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
            this.listViewEstudiantes = new System.Windows.Forms.ListView();
            this.textBoxBuscarEst = new System.Windows.Forms.TextBox();
            this.Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Estudiante";
            // 
            // listViewEstudiantes
            // 
            this.listViewEstudiantes.FullRowSelect = true;
            this.listViewEstudiantes.GridLines = true;
            this.listViewEstudiantes.HideSelection = false;
            this.listViewEstudiantes.Location = new System.Drawing.Point(82, 84);
            this.listViewEstudiantes.Name = "listViewEstudiantes";
            this.listViewEstudiantes.Size = new System.Drawing.Size(589, 306);
            this.listViewEstudiantes.TabIndex = 1;
            this.listViewEstudiantes.UseCompatibleStateImageBehavior = false;
            this.listViewEstudiantes.View = System.Windows.Forms.View.Details;
            this.listViewEstudiantes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewEstudiantes_MouseDoubleClick);
            // 
            // textBoxBuscarEst
            // 
            this.textBoxBuscarEst.Location = new System.Drawing.Point(520, 58);
            this.textBoxBuscarEst.Name = "textBoxBuscarEst";
            this.textBoxBuscarEst.Size = new System.Drawing.Size(151, 20);
            this.textBoxBuscarEst.TabIndex = 2;
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(328, 445);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 3;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            //this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // ModificarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 531);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.textBoxBuscarEst);
            this.Controls.Add(this.listViewEstudiantes);
            this.Controls.Add(this.label1);
            this.Name = "ModificarEstudiante";
            this.Text = "ModificarEstudiante";
            this.Load += new System.EventHandler(this.ModificarEstudiante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewEstudiantes;
        private System.Windows.Forms.TextBox textBoxBuscarEst;
        private System.Windows.Forms.Button Volver;
    }
}