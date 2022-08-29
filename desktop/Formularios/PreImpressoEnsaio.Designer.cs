
namespace Festival.desktop.Formularios
{
    partial class PreImpressoEnsaio
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
            this.chkEnsaio = new DevExpress.XtraEditors.CheckEdit();
            this.rdGrupo = new DevExpress.XtraEditors.RadioGroup();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCat = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pnlGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnsaio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGeral
            // 
            this.pnlGeral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlGeral.Controls.Add(this.chkEnsaio);
            this.pnlGeral.Controls.Add(this.rdGrupo);
            this.pnlGeral.Controls.Add(this.button1);
            this.pnlGeral.Controls.Add(this.btnSair);
            this.pnlGeral.Controls.Add(this.label1);
            this.pnlGeral.Controls.Add(this.cmbCat);
            this.pnlGeral.Location = new System.Drawing.Point(12, 12);
            this.pnlGeral.Name = "pnlGeral";
            this.pnlGeral.Size = new System.Drawing.Size(455, 157);
            this.pnlGeral.TabIndex = 0;
            // 
            // chkEnsaio
            // 
            this.chkEnsaio.Location = new System.Drawing.Point(36, 76);
            this.chkEnsaio.Name = "chkEnsaio";
            this.chkEnsaio.Properties.Caption = "Participaram dos ensaios";
            this.chkEnsaio.Size = new System.Drawing.Size(147, 20);
            this.chkEnsaio.TabIndex = 5;
            // 
            // rdGrupo
            // 
            this.rdGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdGrupo.Location = new System.Drawing.Point(310, 34);
            this.rdGrupo.Name = "rdGrupo";
            this.rdGrupo.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rdGrupo.Properties.Appearance.Options.UseBackColor = true;
            this.rdGrupo.Properties.Columns = 1;
            this.rdGrupo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Com nome"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Sem nome")});
            this.rdGrupo.Size = new System.Drawing.Size(127, 96);
            this.rdGrupo.TabIndex = 4;
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
            // PreImpressoEnsaio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 181);
            this.ControlBox = false;
            this.Controls.Add(this.pnlGeral);
            this.Name = "PreImpressoEnsaio";
            this.Text = "Aprovar";
            this.pnlGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkEnsaio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCat.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeral;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.RadioGroup rdGrupo;
        private DevExpress.XtraEditors.CheckEdit chkEnsaio;
    }
}