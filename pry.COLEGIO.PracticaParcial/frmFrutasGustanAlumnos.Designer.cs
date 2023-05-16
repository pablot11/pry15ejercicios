namespace pry.COLEGIO.PracticaParcial
{
    partial class frmFrutasGustanAlumnos
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
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.lstFrutas = new System.Windows.Forms.ComboBox();
            this.lstDniAlumno = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese DNI Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione la Fruta que le gusta:";
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(19, 110);
            this.cmdRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(181, 28);
            this.cmdRegistrar.TabIndex = 2;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // lstFrutas
            // 
            this.lstFrutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstFrutas.FormattingEnabled = true;
            this.lstFrutas.Location = new System.Drawing.Point(241, 62);
            this.lstFrutas.Margin = new System.Windows.Forms.Padding(4);
            this.lstFrutas.Name = "lstFrutas";
            this.lstFrutas.Size = new System.Drawing.Size(115, 24);
            this.lstFrutas.TabIndex = 4;
            this.lstFrutas.SelectedIndexChanged += new System.EventHandler(this.lstFrutas_SelectedIndexChanged);
            // 
            // lstDniAlumno
            // 
            this.lstDniAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDniAlumno.FormattingEnabled = true;
            this.lstDniAlumno.Location = new System.Drawing.Point(241, 13);
            this.lstDniAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.lstDniAlumno.Name = "lstDniAlumno";
            this.lstDniAlumno.Size = new System.Drawing.Size(115, 24);
            this.lstDniAlumno.TabIndex = 5;
            this.lstDniAlumno.SelectedIndexChanged += new System.EventHandler(this.lstDniAlumno_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(252, 110);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(181, 28);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmFrutasGustanAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 175);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lstDniAlumno);
            this.Controls.Add(this.lstFrutas);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFrutasGustanAlumnos";
            this.Text = "frmFrutasGustanAlumnos";
            this.Load += new System.EventHandler(this.frmFrutasGustanAlumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.ComboBox lstFrutas;
        private System.Windows.Forms.ComboBox lstDniAlumno;
        private System.Windows.Forms.Button btnEliminar;
    }
}