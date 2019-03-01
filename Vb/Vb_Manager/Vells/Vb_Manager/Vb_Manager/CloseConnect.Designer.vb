<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CloseConnect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.btDisconnect = New System.Windows.Forms.Button()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(175, 36)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(151, 20)
        Me.txtState.TabIndex = 2
        '
        'btDisconnect
        '
        Me.btDisconnect.Location = New System.Drawing.Point(30, 33)
        Me.btDisconnect.Name = "btDisconnect"
        Me.btDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btDisconnect.TabIndex = 1
        Me.btDisconnect.Text = "Disconnect"
        Me.btDisconnect.UseVisualStyleBackColor = True
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(27, 86)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(61, 13)
        Me.lblPort.TabIndex = 12
        Me.lblPort.Text = "Disconnect"
        '
        'CloseConnect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 269)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.btDisconnect)
        Me.Name = "CloseConnect"
        Me.Text = "DISCONNECT TO SENSOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents btDisconnect As System.Windows.Forms.Button
    Friend WithEvents lblPort As System.Windows.Forms.Label

End Class
