Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base

Namespace Q131966
	Public Class MyGridView
		Inherits GridView

		Public Sub New(ByVal control As GridControl)
			MyBase.New(control)
		End Sub
		Public Sub New()
			Me.New(Nothing)
		End Sub

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property

		Protected Overrides Function GenerateColumnName(ByVal fieldName As String) As String
			Dim s As String = MyBase.GenerateColumnName(fieldName)
			Return s.Replace("col", String.Empty)
		End Function
	End Class

	Public Class MyGridInfoRegistrator
		Inherits GridInfoRegistrator

		Public Sub New()
			MyBase.New()
		End Sub

		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property

		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyGridView(grid)
		End Function
	End Class

	Public Class MyGridControl
		Inherits GridControl

		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyGridInfoRegistrator())
		End Sub
	End Class
End Namespace
