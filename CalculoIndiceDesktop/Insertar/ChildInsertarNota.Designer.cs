namespace Proyecto_Tecnicas
{
    partial class ChildInsertarNota
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
            this.AgregarNota = new System.Windows.Forms.Label();
            this.dataGridViewAsignaturas = new System.Windows.Forms.DataGridView();
            this.listViewTrimestre = new System.Windows.Forms.ListView();
            this.listViewEstudiante = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarNota
            // 
            this.AgregarNota.AutoSize = true;
            this.AgregarNota.Location = new System.Drawing.Point(290, 9);
            this.AgregarNota.Name = "AgregarNota";
            this.AgregarNota.Size = new System.Drawing.Size(75, 13);
            this.AgregarNota.TabIndex = 0;
            this.AgregarNota.Text = "Agregar Notas";
            // 
            // dataGridViewAsignaturas
            // 
            this.dataGridViewAsignaturas.AllowUserToAddRows = false;
            this.dataGridViewAsignaturas.AllowUserToDeleteRows = false;
            this.dataGridViewAsignaturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsignaturas.Location = new System.Drawing.Point(60, 160);
            this.dataGridViewAsignaturas.MultiSelect = false;
            this.dataGridViewAsignaturas.Name = "dataGridViewAsignaturas";
            this.dataGridViewAsignaturas.Size = new System.Drawing.Size(570, 368);
            this.dataGridViewAsignaturas.TabIndex = 1;
            // 
            // listViewTrimestre
            // 
            this.listViewTrimestre.GridLines = true;
            this.listViewTrimestre.Location = new System.Drawing.Point(220, 83);
            this.listViewTrimestre.Name = "listViewTrimestre";
            this.listViewTrimestre.Size = new System.Drawing.Size(409, 71);
            this.listViewTrimestre.TabIndex = 2;
            this.listViewTrimestre.UseCompatibleStateImageBehavior = false;
            this.listViewTrimestre.View = System.Windows.Forms.View.Details;
            // 
            // listViewEstudiante
            // 
            this.listViewEstudiante.GridLines = true;
            this.listViewEstudiante.Location = new System.Drawing.Point(220, 31);
            this.listViewEstudiante.Name = "listViewEstudiante";
            this.listViewEstudiante.Size = new System.Drawing.Size(409, 46);
            this.listViewEstudiante.TabIndex = 3;
            this.listViewEstudiante.UseCompatibleStateImageBehavior = false;
            this.listViewEstudiante.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trimestre";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(227, 543);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 6;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(324, 543);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 7;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // ChildInsertarNota
            // 
            this.AcceptButton = this.Guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 578);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewEstudiante);
            this.Controls.Add(this.listViewTrimestre);
            this.Controls.Add(this.dataGridViewAsignaturas);
            this.Controls.Add(this.AgregarNota);
            this.Name = "ChildInsertarNota";
            this.Text = "ChildInsertarNota";
            this.Load += new System.EventHandler(this.ChildInsertarNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AgregarNota;
        private System.Windows.Forms.DataGridView dataGridViewAsignaturas;
        private System.Windows.Forms.ListView listViewTrimestre;
        private System.Windows.Forms.ListView listViewEstudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Volver;
    }
}