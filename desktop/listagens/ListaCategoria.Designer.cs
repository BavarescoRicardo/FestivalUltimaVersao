namespace Festival.listagens
{
    partial class ListaCategoria
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colSequencial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldia = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bindingSource;
            this.gridControl.Location = new System.Drawing.Point(12, -2);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(776, 335);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSequencial,
            this.colcategoria,
            this.coldia});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSequencial, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Festival.or.Categoria);
            // 
            // colSequencial
            // 
            this.colSequencial.Caption = "Codigo";
            this.colSequencial.FieldName = "id_categoria";
            this.colSequencial.Name = "colSequencial";
            this.colSequencial.Visible = true;
            this.colSequencial.VisibleIndex = 0;
            this.colSequencial.Width = 96;
            // 
            // colcategoria
            // 
            this.colcategoria.FieldName = "categoria";
            this.colcategoria.Name = "colcategoria";
            this.colcategoria.Visible = true;
            this.colcategoria.VisibleIndex = 1;
            this.colcategoria.Width = 355;
            // 
            // coldia
            // 
            this.coldia.FieldName = "dia";
            this.coldia.Name = "coldia";
            this.coldia.Visible = true;
            this.coldia.VisibleIndex = 2;
            this.coldia.Width = 234;
            // 
            // ListaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 367);
            this.Controls.Add(this.gridControl);
            this.Name = "ListaCategoria";
            this.Text = "ListaCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSequencial;
        private DevExpress.XtraGrid.Columns.GridColumn colcategoria;
        private DevExpress.XtraGrid.Columns.GridColumn coldia;
    }
}