namespace Festival.listagens
{
    partial class ListaEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaEvento));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.fonteDadosBinding = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSequencial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBotao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fonteDadosBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.fonteDadosBinding;
            this.gridControl.Location = new System.Drawing.Point(3, 3);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemCheckEdit2});
            this.gridControl.Size = new System.Drawing.Size(671, 267);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // fonteDadosBinding
            // 
            this.fonteDadosBinding.DataSource = typeof(Festival.or.Evento);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSequencial,
            this.colTitulo,
            this.colDescricao,
            this.colDataInicial,
            this.colDataFinal,
            this.colBotao});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDataInicial, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colSequencial
            // 
            this.colSequencial.AppearanceCell.Options.UseTextOptions = true;
            this.colSequencial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSequencial.AppearanceHeader.Options.UseTextOptions = true;
            this.colSequencial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSequencial.Caption = "Codigo";
            this.colSequencial.FieldName = "id_evento";
            this.colSequencial.Name = "colSequencial";
            this.colSequencial.OptionsColumn.AllowEdit = false;
            this.colSequencial.OptionsColumn.AllowFocus = false;
            this.colSequencial.OptionsFilter.AllowAutoFilter = false;
            this.colSequencial.OptionsFilter.AllowFilter = false;
            this.colSequencial.Visible = true;
            this.colSequencial.VisibleIndex = 0;
            this.colSequencial.Width = 85;
            // 
            // colTitulo
            // 
            this.colTitulo.Caption = "Titulo";
            this.colTitulo.FieldName = "titulo";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.Visible = true;
            this.colTitulo.VisibleIndex = 1;
            this.colTitulo.Width = 174;
            // 
            // colDescricao
            // 
            this.colDescricao.Caption = "Descrição";
            this.colDescricao.FieldName = "descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Visible = true;
            this.colDescricao.VisibleIndex = 2;
            this.colDescricao.Width = 192;
            // 
            // colDataInicial
            // 
            this.colDataInicial.Caption = "Data Inicial";
            this.colDataInicial.FieldName = "dataInicial";
            this.colDataInicial.Name = "colDataInicial";
            this.colDataInicial.Visible = true;
            this.colDataInicial.VisibleIndex = 3;
            this.colDataInicial.Width = 91;
            // 
            // colDataFinal
            // 
            this.colDataFinal.Caption = "Data Final";
            this.colDataFinal.FieldName = "dataFinal";
            this.colDataFinal.Name = "colDataFinal";
            this.colDataFinal.Visible = true;
            this.colDataFinal.VisibleIndex = 4;
            this.colDataFinal.Width = 90;
            // 
            // colBotao
            // 
            this.colBotao.Caption = "Botao";
            this.colBotao.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colBotao.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.colBotao.ImageOptions.Image = global::Festival.Properties.Resources.icons8_delete_48px;
            this.colBotao.Name = "colBotao";
            this.colBotao.Visible = true;
            this.colBotao.VisibleIndex = 5;
            this.colBotao.Width = 53;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // ListaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 298);
            this.Controls.Add(this.gridControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaEvento";
            this.Text = "Lista de Eventos";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fonteDadosBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSequencial;
        private DevExpress.XtraGrid.Columns.GridColumn colTitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInicial;
        private DevExpress.XtraGrid.Columns.GridColumn colDataFinal;
        private System.Windows.Forms.BindingSource fonteDadosBinding;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        public DevExpress.XtraGrid.Columns.GridColumn colBotao;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
    }
}