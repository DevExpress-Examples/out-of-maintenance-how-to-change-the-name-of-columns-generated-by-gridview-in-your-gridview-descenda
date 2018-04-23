Imports Microsoft.VisualBasic
Imports System
Namespace Q131966
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.carsDBDataSet = New Q131966.CarsDBDataSet()
			Me.carsTableAdapter = New Q131966.CarsDBDataSetTableAdapters.CarsTableAdapter()
			Me.myGridControl1 = New Q131966.MyGridControl()
			Me.myGridView1 = New Q131966.MyGridView()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.Trademark = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.Model = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.HP = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' carsBindingSource
			' 
			Me.carsBindingSource.DataMember = "Cars"
			Me.carsBindingSource.DataSource = Me.carsDBDataSet
			' 
			' carsDBDataSet
			' 
			Me.carsDBDataSet.DataSetName = "CarsDBDataSet"
			Me.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' carsTableAdapter
			' 
			Me.carsTableAdapter.ClearBeforeFill = True
			' 
			' myGridControl1
			' 
			Me.myGridControl1.DataSource = Me.carsBindingSource
			Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myGridControl1.EmbeddedNavigator.Name = ""
			Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.myGridControl1.MainView = Me.myGridView1
			Me.myGridControl1.Name = "myGridControl1"
			Me.myGridControl1.Size = New System.Drawing.Size(871, 460)
			Me.myGridControl1.TabIndex = 0
			Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myGridView1, Me.gridView2})
			' 
			' myGridView1
			' 
			Me.myGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.ID, Me.Trademark, Me.Model, Me.HP})
			Me.myGridView1.GridControl = Me.myGridControl1
			Me.myGridView1.Name = "myGridView1"
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.myGridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' ID
			' 
			Me.ID.Caption = "ID"
			Me.ID.FieldName = "ID"
			Me.ID.Name = "ID"
			Me.ID.Visible = True
			Me.ID.VisibleIndex = 0
			' 
			' Trademark
			' 
			Me.Trademark.Caption = "Trademark"
			Me.Trademark.FieldName = "Trademark"
			Me.Trademark.Name = "Trademark"
			Me.Trademark.Visible = True
			Me.Trademark.VisibleIndex = 1
			' 
			' Model
			' 
			Me.Model.Caption = "Model"
			Me.Model.FieldName = "Model"
			Me.Model.Name = "Model"
			Me.Model.Visible = True
			Me.Model.VisibleIndex = 2
			' 
			' HP
			' 
			Me.HP.Caption = "HP"
			Me.HP.FieldName = "HP"
			Me.HP.Name = "HP"
			Me.HP.Visible = True
			Me.HP.VisibleIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(871, 460)
			Me.Controls.Add(Me.myGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private carsDBDataSet As CarsDBDataSet
		Private carsBindingSource As System.Windows.Forms.BindingSource
		Private carsTableAdapter As Q131966.CarsDBDataSetTableAdapters.CarsTableAdapter
		Private myGridControl1 As MyGridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private myGridView1 As MyGridView
		Private ID As DevExpress.XtraGrid.Columns.GridColumn
		Private Trademark As DevExpress.XtraGrid.Columns.GridColumn
		Private Model As DevExpress.XtraGrid.Columns.GridColumn
		Private HP As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

