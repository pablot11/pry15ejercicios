namespace pry.COLEGIO.PracticaParcial
{
    partial class frmListarTodasLasFrutas
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
            this.dgvFrutas = new System.Windows.Forms.DataGridView();
            this.brnListar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrutas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFrutas
            // 
            this.dgvFrutas.AllowUserToAddRows = false;
            this.dgvFrutas.AllowUserToDeleteRows = false;
            this.dgvFrutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvFrutas.Location = new System.Drawing.Point(21, 12);
            this.dgvFrutas.Name = "dgvFrutas";
            this.dgvFrutas.ReadOnly = true;
            this.dgvFrutas.RowHeadersWidth = 51;
            this.dgvFrutas.RowTemplate.Height = 24;
            this.dgvFrutas.Size = new System.Drawing.Size(240, 150);
            this.dgvFrutas.TabIndex = 0;
            // 
            // brnListar
            // 
            this.brnListar.Location = new System.Drawing.Point(186, 168);
            this.brnListar.Name = "brnListar";
            this.brnListar.Size = new System.Drawing.Size(75, 23);
            this.brnListar.TabIndex = 1;
            this.brnListar.Text = "Listar";
            this.brnListar.UseVisualStyleBackColor = true;
            this.brnListar.Click += new System.EventHandler(this.brnListar_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Frutas";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // frmListarTodasLasFrutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 202);
            this.Controls.Add(this.brnListar);
            this.Controls.Add(this.dgvFrutas);
            this.Name = "frmListarTodasLasFrutas";
            this.Text = "frmListarTodasLasFrutas";
            this.Load += new System.EventHandler(this.frmListarTodasLasFrutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrutas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFrutas;
        private System.Windows.Forms.Button brnListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}