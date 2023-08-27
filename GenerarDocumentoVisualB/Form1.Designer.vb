<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TXTtexto = New TextBox()
        BTNWord = New Button()
        BTNexcel = New Button()
        SuspendLayout()
        ' 
        ' TXTtexto
        ' 
        TXTtexto.Location = New Point(67, 46)
        TXTtexto.Multiline = True
        TXTtexto.Name = "TXTtexto"
        TXTtexto.Size = New Size(335, 146)
        TXTtexto.TabIndex = 0
        ' 
        ' BTNWord
        ' 
        BTNWord.Location = New Point(67, 247)
        BTNWord.Name = "BTNWord"
        BTNWord.Size = New Size(75, 23)
        BTNWord.TabIndex = 1
        BTNWord.Text = "Word"
        BTNWord.UseVisualStyleBackColor = True
        ' 
        ' BTNexcel
        ' 
        BTNexcel.Location = New Point(327, 247)
        BTNexcel.Name = "BTNexcel"
        BTNexcel.Size = New Size(75, 23)
        BTNexcel.TabIndex = 2
        BTNexcel.Text = "Excel"
        BTNexcel.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(465, 313)
        Controls.Add(BTNexcel)
        Controls.Add(BTNWord)
        Controls.Add(TXTtexto)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TXTtexto As TextBox
    Friend WithEvents BTNWord As Button
    Friend WithEvents BTNexcel As Button
End Class
