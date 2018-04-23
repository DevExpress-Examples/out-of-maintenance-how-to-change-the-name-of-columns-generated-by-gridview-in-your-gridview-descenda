namespace Q131966 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsDBDataSet = new Q131966.CarsDBDataSet();
            this.carsTableAdapter = new Q131966.CarsDBDataSetTableAdapters.CarsTableAdapter();
            this.myGridControl1 = new Q131966.MyGridControl();
            this.myGridView1 = new Q131966.MyGridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Trademark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Model = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HP = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.carsDBDataSet;
            // 
            // carsDBDataSet
            // 
            this.carsDBDataSet.DataSetName = "CarsDBDataSet";
            this.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // myGridControl1
            // 
            this.myGridControl1.DataSource = this.carsBindingSource;
            this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl1.EmbeddedNavigator.Name = "";
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(871, 460);
            this.myGridControl1.TabIndex = 0;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1,
            this.gridView2});
            // 
            // myGridView1
            // 
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Trademark,
            this.Model,
            this.HP});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.myGridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // Trademark
            // 
            this.Trademark.Caption = "Trademark";
            this.Trademark.FieldName = "Trademark";
            this.Trademark.Name = "Trademark";
            this.Trademark.Visible = true;
            this.Trademark.VisibleIndex = 1;
            // 
            // Model
            // 
            this.Model.Caption = "Model";
            this.Model.FieldName = "Model";
            this.Model.Name = "Model";
            this.Model.Visible = true;
            this.Model.VisibleIndex = 2;
            // 
            // HP
            // 
            this.HP.Caption = "HP";
            this.HP.FieldName = "HP";
            this.HP.Name = "HP";
            this.HP.Visible = true;
            this.HP.VisibleIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 460);
            this.Controls.Add(this.myGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CarsDBDataSet carsDBDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private Q131966.CarsDBDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private MyGridControl myGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private MyGridView myGridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Trademark;
        private DevExpress.XtraGrid.Columns.GridColumn Model;
        private DevExpress.XtraGrid.Columns.GridColumn HP;
    }
}

