namespace Festival.listagens
{
    partial class ListaOrdem
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
            this.components = new System.ComponentModel.Container();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCantor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtista = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrdem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbFiltro = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltro.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bindingSource1;
            this.gridControl.Location = new System.Drawing.Point(13, 8);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1055, 381);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Festival.or.Apresentacao);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCantor,
            this.coldia,
            this.colMusica,
            this.colArtista,
            this.colOrdem});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.GroupPanelText = "Notas";
            this.gridView1.Name = "gridView1";
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // colCantor
            // 
            this.colCantor.Caption = "Cantor";
            this.colCantor.FieldName = "nomeartistico";
            this.colCantor.Name = "colCantor";
            this.colCantor.OptionsColumn.AllowEdit = false;
            this.colCantor.OptionsFilter.AllowAutoFilter = false;
            this.colCantor.OptionsFilter.AllowFilter = false;
            this.colCantor.Visible = true;
            this.colCantor.VisibleIndex = 0;
            this.colCantor.Width = 227;
            // 
            // coldia
            // 
            this.coldia.Caption = "Categoria";
            this.coldia.FieldName = "categoria.id_categoria";
            this.coldia.Name = "coldia";
            this.coldia.OptionsColumn.AllowEdit = false;
            this.coldia.OptionsFilter.AllowAutoFilter = false;
            this.coldia.OptionsFilter.AllowFilter = false;
            this.coldia.Visible = true;
            this.coldia.VisibleIndex = 1;
            this.coldia.Width = 156;
            // 
            // colMusica
            // 
            this.colMusica.Caption = "Música";
            this.colMusica.FieldName = "musica";
            this.colMusica.Name = "colMusica";
            this.colMusica.OptionsColumn.AllowEdit = false;
            this.colMusica.OptionsFilter.AllowAutoFilter = false;
            this.colMusica.OptionsFilter.AllowFilter = false;
            this.colMusica.Visible = true;
            this.colMusica.VisibleIndex = 2;
            this.colMusica.Width = 149;
            // 
            // colArtista
            // 
            this.colArtista.Caption = "Artista";
            this.colArtista.FieldName = "artista";
            this.colArtista.Name = "colArtista";
            this.colArtista.OptionsColumn.AllowEdit = false;
            this.colArtista.OptionsFilter.AllowAutoFilter = false;
            this.colArtista.OptionsFilter.AllowFilter = false;
            this.colArtista.Visible = true;
            this.colArtista.VisibleIndex = 3;
            this.colArtista.Width = 149;
            // 
            // colOrdem
            // 
            this.colOrdem.Caption = "Ordem";
            this.colOrdem.FieldName = "ordem";
            this.colOrdem.Name = "colOrdem";
            this.colOrdem.OptionsFilter.AllowAutoFilter = false;
            this.colOrdem.OptionsFilter.AllowFilter = false;
            this.colOrdem.Visible = true;
            this.colOrdem.VisibleIndex = 4;
            this.colOrdem.Width = 97;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbFiltro.Location = new System.Drawing.Point(198, 18);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFiltro.Size = new System.Drawing.Size(161, 20);
            this.cmbFiltro.TabIndex = 1;
            this.cmbFiltro.SelectedValueChanged += new System.EventHandler(this.cmbFiltro_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 394);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(122, 22);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(946, 394);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(122, 22);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "Salvar ordem";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ListaOrdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 431);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.gridControl);
            this.Name = "ListaOrdem";
            this.Text = "Ordem de apresentações";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltro.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCantor;
        private DevExpress.XtraGrid.Columns.GridColumn coldia;
        private DevExpress.XtraGrid.Columns.GridColumn colMusica;
        private DevExpress.XtraGrid.Columns.GridColumn colArtista;
        private DevExpress.XtraGrid.Columns.GridColumn colOrdem;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.SimpleButton btnSair;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}