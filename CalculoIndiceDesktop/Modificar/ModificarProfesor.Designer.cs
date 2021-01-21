namespace Proyecto_Tecnicas
{
    partial class ModificarProfesor
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
            this.textBoxBuscarProf = new System.Windows.Forms.TextBox();
            this.listViewProfesores = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxBuscarProf
            // 
            this.textBoxBuscarProf.Location = new System.Drawing.Point(494, 82);
            this.textBoxBuscarProf.Name = "textBoxBuscarProf";
            this.textBoxBuscarProf.Size = new System.Drawing.Size(151, 20);
            this.textBoxBuscarProf.TabIndex = 5;
            // 
            // listViewProfesores
            // 
            this.listViewProfesores.FullRowSelect = true;
            this.listViewProfesores.GridLines = true;
            this.listViewProfesores.HideSelection = false;
            this.listViewProfesores.Location = new System.Drawing.Point(56, 108);
            this.listViewProfesores.Name = "listViewProfesores";
            this.listViewProfesores.Size = new System.Drawing.Size(589, 306);
            this.listViewProfesores.TabIndex = 4;
            this.listViewProfesores.UseCompatibleStateImageBehavior = false;
            this.listViewProfesores.View = System.Windows.Forms.View.Details;
            this.listViewProfesores.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewProfesores_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modificar Profesores";
            // 
            // ModificarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 505);
            this.Controls.Add(this.textBoxBuscarProf);
            this.Controls.Add(this.listViewProfesores);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificarProfesor";
            this.Text = "ModificarProfesor";
            this.Load += new System.EventHandler(this.ModificarProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBuscarProf;
        private System.Windows.Forms.ListView listViewProfesores;
        private System.Windows.Forms.Label label1;
    }
}