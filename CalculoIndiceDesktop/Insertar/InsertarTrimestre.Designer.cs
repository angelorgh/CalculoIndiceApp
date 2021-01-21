namespace Proyecto_Tecnicas
{
    partial class InsertarTrimestre
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBuscarEst = new System.Windows.Forms.TextBox();
            this.comboBoxMeses = new System.Windows.Forms.ComboBox();
            this.comboBoxAñoFin = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listViewAsignaturas = new System.Windows.Forms.ListView();
            this.textBoxCreditos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxBuscarAsig = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAñoInicio = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione los estudiantes";
            // 
            // listViewEstudiantes
            // 
            this.listViewEstudiantes.CheckBoxes = true;
            this.listViewEstudiantes.FullRowSelect = true;
            this.listViewEstudiantes.GridLines = true;
            this.listViewEstudiantes.Location = new System.Drawing.Point(148, 67);
            this.listViewEstudiantes.Name = "listViewEstudiantes";
            this.listViewEstudiantes.Size = new System.Drawing.Size(538, 216);
            this.listViewEstudiantes.TabIndex = 1;
            this.listViewEstudiantes.UseCompatibleStateImageBehavior = false;
            this.listViewEstudiantes.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Meses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Años";
            // 
            // textBoxBuscarEst
            // 
            this.textBoxBuscarEst.Location = new System.Drawing.Point(515, 41);
            this.textBoxBuscarEst.Name = "textBoxBuscarEst";
            this.textBoxBuscarEst.Size = new System.Drawing.Size(171, 20);
            this.textBoxBuscarEst.TabIndex = 4;
            // 
            // comboBoxMeses
            // 
            this.comboBoxMeses.FormattingEnabled = true;
            this.comboBoxMeses.Location = new System.Drawing.Point(215, 320);
            this.comboBoxMeses.Name = "comboBoxMeses";
            this.comboBoxMeses.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMeses.TabIndex = 5;
            // 
            // comboBoxAñoFin
            // 
            this.comboBoxAñoFin.FormattingEnabled = true;
            this.comboBoxAñoFin.Location = new System.Drawing.Point(480, 390);
            this.comboBoxAñoFin.Name = "comboBoxAñoFin";
            this.comboBoxAñoFin.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAñoFin.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 516);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Seleccione las asignaturas";
            // 
            // listViewAsignaturas
            // 
            this.listViewAsignaturas.CheckBoxes = true;
            this.listViewAsignaturas.FullRowSelect = true;
            this.listViewAsignaturas.GridLines = true;
            this.listViewAsignaturas.Location = new System.Drawing.Point(148, 446);
            this.listViewAsignaturas.Name = "listViewAsignaturas";
            this.listViewAsignaturas.Size = new System.Drawing.Size(538, 216);
            this.listViewAsignaturas.TabIndex = 14;
            this.listViewAsignaturas.UseCompatibleStateImageBehavior = false;
            this.listViewAsignaturas.View = System.Windows.Forms.View.Details;
            // 
            // textBoxCreditos
            // 
            this.textBoxCreditos.Location = new System.Drawing.Point(606, 668);
            this.textBoxCreditos.Name = "textBoxCreditos";
            this.textBoxCreditos.ReadOnly = true;
            this.textBoxCreditos.Size = new System.Drawing.Size(80, 20);
            this.textBoxCreditos.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(496, 671);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cantidad de Creditos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(624, 691);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "MAX 21";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(469, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Buscar";
            // 
            // textBoxBuscarAsig
            // 
            this.textBoxBuscarAsig.Location = new System.Drawing.Point(515, 420);
            this.textBoxBuscarAsig.Name = "textBoxBuscarAsig";
            this.textBoxBuscarAsig.Size = new System.Drawing.Size(171, 20);
            this.textBoxBuscarAsig.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(469, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Buscar";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(266, 736);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 22;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.ButtonAgregar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(372, 736);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 23;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.ButtonVolver_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(313, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Agregar Trimestre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Inicio";
            // 
            // comboBoxAñoInicio
            // 
            this.comboBoxAñoInicio.FormattingEnabled = true;
            this.comboBoxAñoInicio.Location = new System.Drawing.Point(215, 390);
            this.comboBoxAñoInicio.Name = "comboBoxAñoInicio";
            this.comboBoxAñoInicio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAñoInicio.TabIndex = 6;
            // 
            // InsertarTrimestre
            // 
            this.AcceptButton = this.buttonAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 771);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxBuscarAsig);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCreditos);
            this.Controls.Add(this.listViewAsignaturas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxAñoFin);
            this.Controls.Add(this.comboBoxAñoInicio);
            this.Controls.Add(this.comboBoxMeses);
            this.Controls.Add(this.textBoxBuscarEst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewEstudiantes);
            this.Controls.Add(this.label1);
            this.Name = "InsertarTrimestre";
            this.Text = "InsertarTrimestre";
            this.Load += new System.EventHandler(this.InsertarTrimestre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewEstudiantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBuscarEst;
        private System.Windows.Forms.ComboBox comboBoxMeses;
        private System.Windows.Forms.ComboBox comboBoxAñoFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listViewAsignaturas;
        private System.Windows.Forms.TextBox textBoxCreditos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxBuscarAsig;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAñoInicio;
    }
}