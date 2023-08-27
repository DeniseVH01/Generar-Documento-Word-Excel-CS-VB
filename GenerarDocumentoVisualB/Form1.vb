Imports System.IO
Imports Microsoft.Office.Interop
Imports Word = Microsoft.Office.Interop.Word
Public Class Form1

    Private Sub BTNWord_Click(sender As Object, e As EventArgs) Handles BTNWord.Click
        Dim dialogo As SaveFileDialog = New SaveFileDialog()

        If dialogo.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        ' Dim ruta As String = dialogo.FileName
        'Dim wordApp = New Word.Application()
        'wordApp.Visible = True
        'wordApp.Documents.Add()
        'Dim dato As String = TXTtexto.Text
        'wordApp.Selection.TypeText(dato)
        'wordApp.ActiveDocument.SaveAs2(ruta)
        'MessageBox.Show("WORD CREADO EXITOSAMENTE")
        'wordApp.Visible = True
    End Sub

    Private Sub BTNexcel_Click(sender As Object, e As EventArgs) Handles BTNexcel.Click

    End Sub
End Class
