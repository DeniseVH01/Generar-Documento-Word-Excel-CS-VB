<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TXTtexto = New System.Windows.Forms.TextBox()
        Me.BTNword = New System.Windows.Forms.Button()
        Me.BTNexcel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TXTtexto
        '
        Me.TXTtexto.Location = New System.Drawing.Point(27, 46)
        Me.TXTtexto.Multiline = True
        Me.TXTtexto.Name = "TXTtexto"
        Me.TXTtexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXTtexto.Size = New System.Drawing.Size(338, 212)
        Me.TXTtexto.TabIndex = 0
        '
        'BTNword
        '
        Me.BTNword.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNword.Location = New System.Drawing.Point(27, 274)
        Me.BTNword.Name = "BTNword"
        Me.BTNword.Size = New System.Drawing.Size(75, 36)
        Me.BTNword.TabIndex = 1
        Me.BTNword.Text = "Word"
        Me.BTNword.UseVisualStyleBackColor = True
        '
        'BTNexcel
        '
        Me.BTNexcel.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNexcel.Location = New System.Drawing.Point(290, 274)
        Me.BTNexcel.Name = "BTNexcel"
        Me.BTNexcel.Size = New System.Drawing.Size(75, 36)
        Me.BTNexcel.TabIndex = 2
        Me.BTNexcel.Text = "Excel"
        Me.BTNexcel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "GUARDAR DOCUMENTO"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(391, 322)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNexcel)
        Me.Controls.Add(Me.BTNword)
        Me.Controls.Add(Me.TXTtexto)
        Me.Name = "Form1"
        Me.Text = "Guardar Documento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTtexto As TextBox
    Friend WithEvents BTNword As Button
    Friend WithEvents BTNexcel As Button
    Friend WithEvents Label1 As Label
End Class
