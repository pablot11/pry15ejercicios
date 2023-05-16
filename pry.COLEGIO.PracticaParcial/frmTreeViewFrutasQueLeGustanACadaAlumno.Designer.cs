namespace pry.COLEGIO.PracticaParcial
{
    partial class frmTreeViewFrutasQueLeGustanACadaAlumno
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
            this.tvMostrar = new System.Windows.Forms.TreeView();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvMostrar
            // 
            this.tvMostrar.Location = new System.Drawing.Point(12, 12);
            this.tvMostrar.Name = "tvMostrar";
            this.tvMostrar.Size = new System.Drawing.Size(279, 173);
            this.tvMostrar.TabIndex = 0;
            this.tvMostrar.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMostrar_AfterSelect);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(216, 191);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmTreeViewFrutasQueLeGustanACadaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 306);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.tvMostrar);
            this.Name = "frmTreeViewFrutasQueLeGustanACadaAlumno";
            this.Text = "frmTreeViewFrutas";
            this.Load += new System.EventHandler(this.frmTreeViewFrutas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvMostrar;
        private System.Windows.Forms.Button btnListar;
    }
}