<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class showData
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtShow = New System.Windows.Forms.TextBox()
        Me.btAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtShow
        '
        Me.txtShow.Location = New System.Drawing.Point(150, 27)
        Me.txtShow.Multiline = True
        Me.txtShow.Name = "txtShow"
        Me.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtShow.Size = New System.Drawing.Size(405, 250)
        Me.txtShow.TabIndex = 1
        '
        'btAll
        '
        Me.btAll.Location = New System.Drawing.Point(36, 40)
        Me.btAll.Name = "btAll"
        Me.btAll.Size = New System.Drawing.Size(75, 23)
        Me.btAll.TabIndex = 0
        Me.btAll.Text = "Show"
        Me.btAll.UseVisualStyleBackColor = True
        '
        'showData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 336)
        Me.Controls.Add(Me.txtShow)
        Me.Controls.Add(Me.btAll)
        Me.Name = "showData"
        Me.Text = "showData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtShow As System.Windows.Forms.TextBox
    Friend WithEvents btAll As System.Windows.Forms.Button
End Class
