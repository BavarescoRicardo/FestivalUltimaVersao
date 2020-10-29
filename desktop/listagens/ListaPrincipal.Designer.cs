namespace Festival.listagens
{
    partial class ListaPrincipal
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
            this.pnlListaPrincipal = new System.Windows.Forms.Panel();
            this.grdviewListaPrincipal = new System.Windows.Forms.DataGridView();
            this.pnlListaPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewListaPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlListaPrincipal
            // 
            this.pnlListaPrincipal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlListaPrincipal.Controls.Add(this.grdviewListaPrincipal);
            this.pnlListaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlListaPrincipal.Name = "pnlListaPrincipal";
            this.pnlListaPrincipal.Size = new System.Drawing.Size(800, 450);
            this.pnlListaPrincipal.TabIndex = 0;
            // 
            // grdviewListaPrincipal
            // 
            this.grdviewListaPrincipal.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdviewListaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdviewListaPrincipal.Location = new System.Drawing.Point(12, 12);
            this.grdviewListaPrincipal.Name = "grdviewListaPrincipal";
            this.grdviewListaPrincipal.Size = new System.Drawing.Size(776, 355);
            this.grdviewListaPrincipal.TabIndex = 0;
            this.grdviewListaPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdviewListaPrincipal_CellContentClick);
            // 
            // ListaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlListaPrincipal);
            this.Name = "ListaPrincipal";
            this.Text = "ListaPrincipal";
            this.pnlListaPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdviewListaPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlListaPrincipal;
        private System.Windows.Forms.DataGridView grdviewListaPrincipal;
    }
}