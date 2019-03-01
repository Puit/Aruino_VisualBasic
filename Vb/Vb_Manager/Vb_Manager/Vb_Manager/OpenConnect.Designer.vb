<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenConnect
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
        Me.btConnect = New System.Windows.Forms.Button()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Online = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.lblState = New System.Windows.Forms.Label()
        Me.btPorts = New System.Windows.Forms.Button()
        Me.lstPorts = New System.Windows.Forms.ListBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btConnect
        '
        Me.btConnect.Location = New System.Drawing.Point(54, 28)
        Me.btConnect.Name = "btConnect"
        Me.btConnect.Size = New System.Drawing.Size(75, 23)
        Me.btConnect.TabIndex = 0
        Me.btConnect.Text = "Connect"
        Me.btConnect.UseVisualStyleBackColor = True
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(212, 68)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(151, 20)
        Me.txtState.TabIndex = 2
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Online})
        Me.ShapeContainer1.Size = New System.Drawing.Size(396, 228)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'Online
        '
        Me.Online.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Online.FillGradientColor = System.Drawing.Color.DarkRed
        Me.Online.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.Online.Location = New System.Drawing.Point(335, 28)
        Me.Online.Name = "Online"
        Me.Online.Size = New System.Drawing.Size(24, 24)
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(209, 33)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(109, 13)
        Me.lblState.TabIndex = 6
        Me.lblState.Text = "ConnectionState OFF"
        '
        'btPorts
        '
        Me.btPorts.Location = New System.Drawing.Point(54, 66)
        Me.btPorts.Name = "btPorts"
        Me.btPorts.Size = New System.Drawing.Size(75, 23)
        Me.btPorts.TabIndex = 7
        Me.btPorts.Text = "Ports"
        Me.btPorts.UseVisualStyleBackColor = True
        '
        'lstPorts
        '
        Me.lstPorts.FormattingEnabled = True
        Me.lstPorts.Location = New System.Drawing.Point(54, 107)
        Me.lstPorts.Name = "lstPorts"
        Me.lstPorts.Size = New System.Drawing.Size(75, 95)
        Me.lstPorts.TabIndex = 8
        Me.lstPorts.Visible = False
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(150, 33)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(37, 13)
        Me.lblPort.TabIndex = 12
        Me.lblPort.Text = "COM4"
        '
        'OpenConnect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 228)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lstPorts)
        Me.Controls.Add(Me.btPorts)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.btConnect)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "OpenConnect"
        Me.Text = "CONNECT TO SENSOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btConnect As System.Windows.Forms.Button
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Online As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents btPorts As System.Windows.Forms.Button
    Friend WithEvents lstPorts As System.Windows.Forms.ListBox
    Friend WithEvents lblPort As System.Windows.Forms.Label

End Class
