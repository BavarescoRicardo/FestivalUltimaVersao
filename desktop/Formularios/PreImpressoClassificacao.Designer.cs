
namespace Festival.desktop.Formularios
{
    partial class PreImpressoClassificacao
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
            this.pnlGeral = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCat = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkAlfabeto = new DevExpress.XtraEditors.CheckEdit();
            this.pnlGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAlfabeto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGeral
            // 
            this.pnlGeral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlGeral.Controls.Add(this.chkAlfabeto);
            this.pnlGeral.Controls.Add(this.button1);
            this.pnlGeral.Controls.Add(this.btnSair);
            this.pnlGeral.Controls.Add(this.label1);
            this.pnlGeral.Controls.Add(this.cmbCat);
            this.pnlGeral.Location = new System.Drawing.Point(12, 12);
            this.pnlGeral.Name = "pnlGeral";
            this.pnlGeral.Size = new System.Drawing.Size(420, 157);
            this.pnlGeral.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(33, 102);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 28);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione a categoria";
            // 
            // cmbCat
            // 
            this.cmbCat.EditValue = "";
            this.cmbCat.Location = new System.Drawing.Point(33, 38);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Properties.AutoHeight = false;
            this.cmbCat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCat.Size = new System.Drawing.Size(254, 20);
            this.cmbCat.TabIndex = 0;
            // 
            // chkAlfabeto
            // 
            this.chkAlfabeto.Location = new System.Drawing.Point(294, 41);
            this.chkAlfabeto.MaximumSize = new System.Drawing.Size(120, 40);
            this.chkAlfabeto.Name = "chkAlfabeto";
            this.chkAlfabeto.Properties.Caption = "Ordem Alfabética";
            this.chkAlfabeto.Size = new System.Drawing.Size(120, 20);
            this.chkAlfabeto.TabIndex = 4;
            // 
            // PreImpressoClassificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 181);
            this.ControlBox = false;
            this.Controls.Add(this.pnlGeral);
            this.Name = "PreImpressoClassificacao";
            this.Text = "Classificação";
            this.pnlGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAlfabeto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeral;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.CheckEdit chkAlfabeto;
    }
}