namespace pry.COLEGIO.PracticaParcial
{
    partial class frmQueFrutaLeGustanAUnAlumno
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
            this.lstDniAlumno = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvFrutas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrutas)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDniAlumno
            // 
            this.lstDniAlumno.FormattingEnabled = true;
            this.lstDniAlumno.Location = new System.Drawing.Point(12, 12);
            this.lstDniAlumno.Name = "lstDniAlumno";
            this.lstDniAlumno.Size = new System.Drawing.Size(514, 24);
            this.lstDniAlumno.TabIndex = 0;
            this.lstDniAlumno.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 222);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(514, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvFrutas
            // 
            this.dgvFrutas.AllowUserToAddRows = false;
            this.dgvFrutas.AllowUserToDeleteRows = false;
            this.dgvFrutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvFrutas.Location = new System.Drawing.Point(12, 51);
            this.dgvFrutas.Name = "dgvFrutas";
            this.dgvFrutas.ReadOnly = true;
            this.dgvFrutas.RowHeadersWidth = 51;
            this.dgvFrutas.RowTemplate.Height = 24;
            this.dgvFrutas.Size = new System.Drawing.Size(514, 165);
            this.dgvFrutas.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Frutas";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // frmQueFrutaLeGustanAUnAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 282);
            this.Controls.Add(this.dgvFrutas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lstDniAlumno);
            this.Name = "frmQueFrutaLeGustanAUnAlumno";
            this.Text = "frmQueFrutaLeGustanAUnAlumno";
            this.Load += new System.EventHandler(this.frmQueFrutaLeGustanAUnAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrutas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox lstDniAlumno;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvFrutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}