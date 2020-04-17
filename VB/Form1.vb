Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports DevExpress.XtraRichEdit
Imports DevExpress.Portable.Input

Namespace RichEditNavigation
	Partial Public Class Form1
		Inherits Form

		Private basePath As String = "Documents"
		Private startPage As String = "Index.html"
		Private historyItems As New List(Of String)()
		Private currentHistoryItemIndex As Integer = 0

		Public Sub New()
			InitializeComponent()
			richEditControl1.ReadOnly = True
			richEditControl1.Options.Hyperlinks.ModifierKeys = PortableKeys.None
			NavigateTo(startPage, True)
		End Sub

		Private Sub richEditControl1_HyperlinkClick(ByVal sender As Object, ByVal e As HyperlinkClickEventArgs) Handles richEditControl1.HyperlinkClick
			BeginInvoke(CType(Sub()
				NavigateTo(e.Hyperlink.NavigateUri, True)
			End Sub, MethodInvoker))
			e.Handled = True
		End Sub

		Private Sub richEditControl1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles richEditControl1.KeyDown
			If currentHistoryItemIndex <> 0 AndAlso e.KeyCode = Keys.Back Then
				btnBackward_Click(btnBackward, EventArgs.Empty)
			End If
		End Sub

		Private Sub btnBackward_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBackward.Click
			If Not Me.btnBackward.IsHandleCreated Then Return

			currentHistoryItemIndex -= 1
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: NavigateTo(historyItems[--currentHistoryItemIndex], false);
			NavigateTo(historyItems(currentHistoryItemIndex), False)
		End Sub

		Private Sub btnForward_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnForward.Click
			If Not Me.btnForward.IsHandleCreated Then Return

			currentHistoryItemIndex += 1
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: NavigateTo(historyItems[++currentHistoryItemIndex], false);
			NavigateTo(historyItems(currentHistoryItemIndex), False)
		End Sub

		Private Sub NavigateTo(ByVal page As String, ByVal addToHistory As Boolean)
			If addToHistory Then
				Do While historyItems.Count > currentHistoryItemIndex + 1
					historyItems.RemoveAt(historyItems.Count - 1)
				Loop

				historyItems.Add(page)
				currentHistoryItemIndex = historyItems.Count - 1
			End If
			richEditControl1.LoadDocument(Path.Combine(basePath, page))
			UpdateUI()
		End Sub

		Private Sub UpdateUI()
			btnBackward.Enabled = currentHistoryItemIndex <> 0
			btnForward.Enabled = currentHistoryItemIndex <> historyItems.Count - 1
		End Sub
	End Class
End Namespace