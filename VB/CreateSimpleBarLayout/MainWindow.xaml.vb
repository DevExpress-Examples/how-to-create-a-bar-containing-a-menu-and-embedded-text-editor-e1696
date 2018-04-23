Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Bars

Namespace CreateSimpleBarLayout
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
			MessageBox.Show("The " & e.Item.Content.ToString() & " item has been clicked")
		End Sub

		Private Sub barCheckItem1_CheckedChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
			MessageBox.Show("The " & e.Item.Content.ToString() & " item has been toggled")
		End Sub

		Private Sub barEditItem1_EditValueChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim item As BarEditItem = TryCast(sender, BarEditItem)
			Dim newValue As Object = item.EditValue
			'...
		End Sub
	End Class
End Namespace
