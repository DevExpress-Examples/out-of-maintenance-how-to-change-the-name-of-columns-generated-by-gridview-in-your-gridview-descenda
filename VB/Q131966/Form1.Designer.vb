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
			Me.myGridControl1 = New Q131966.MyGridControl()
			Me.myGridView1 = New Q131966.MyGridView()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myGridControl1
			' 
			Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myGridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
			Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.myGridControl1.MainView = Me.myGridView1
			Me.myGridControl1.Margin = New System.Windows.Forms.Padding(2)
			Me.myGridControl1.Name = "myGridControl1"
			Me.myGridControl1.Size = New System.Drawing.Size(653, 374)
			Me.myGridControl1.TabIndex = 0
			Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myGridView1, Me.gridView2})
			' 
			' myGridView1
			' 
			Me.myGridView1.DetailHeight = 284
			Me.myGridView1.GridControl = Me.myGridControl1
			Me.myGridView1.Name = "myGridView1"
			' 
			' gridView2
			' 
			Me.gridView2.DetailHeight = 284
			Me.gridView2.GridControl = Me.myGridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(653, 374)
			Me.Controls.Add(Me.myGridControl1)
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private myGridControl1 As MyGridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private myGridView1 As MyGridView
	End Class
End Namespace

