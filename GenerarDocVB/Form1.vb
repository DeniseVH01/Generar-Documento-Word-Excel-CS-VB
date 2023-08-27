Imports System.IO
Imports Microsoft.Office.Interop
Imports Word = Microsoft.Office.Interop.Word
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1
    Private Sub BTNword_Click(sender As Object, e As EventArgs) Handles BTNword.Click
        Dim dialogo As SaveFileDialog = New SaveFileDialog()

        If dialogo.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim ruta As String = dialogo.FileName
        Dim wordApp = New Word.Application()
        wordApp.Visible = True
        wordApp.Documents.Add()
        Dim dato As String = TXTtexto.Text
        wordApp.Selection.TypeText(dato)
        wordApp.ActiveDocument.SaveAs2(ruta)
        MessageBox.Show("WORD CREADO EXITOSAMENTE")
        wordApp.Visible = True
    End Sub

    Private Sub BTNexcel_Click(sender As Object, e As EventArgs) Handles BTNexcel.Click
        Dim dialogo As SaveFileDialog = New SaveFileDialog()

        If dialogo.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim ruta As String = dialogo.FileName
        Dim excelApp = New Excel.Application()
        excelApp.Workbooks.Add()
        Dim workSheet As Excel._Worksheet = CType(excelApp.ActiveSheet, Excel.Worksheet)
        Dim dato As String = TXTtexto.Text
        workSheet.Cells(4, "H") = dato
        workSheet.Columns(8).AutoFit()
        excelApp.ActiveWorkbook.SaveAs(ruta)
        MessageBox.Show("EXCEL CREADO EXITOSAMENTE")
        excelApp.Visible = True
    End Sub

End Class
