<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Simu
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
        Me.txt_Delay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_StartSimu = New System.Windows.Forms.Button()
        Me.pb_Progres = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.txt_NumAdq = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_Delay
        '
        Me.txt_Delay.Location = New System.Drawing.Point(118, 49)
        Me.txt_Delay.Name = "txt_Delay"
        Me.txt_Delay.Size = New System.Drawing.Size(51, 20)
        Me.txt_Delay.TabIndex = 0
        Me.txt_Delay.Text = "1"
        Me.txt_Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Adq Periode"
        '
        'bt_StartSimu
        '
        Me.bt_StartSimu.Location = New System.Drawing.Point(59, 95)
        Me.bt_StartSimu.Name = "bt_StartSimu"
        Me.bt_StartSimu.Size = New System.Drawing.Size(75, 23)
        Me.bt_StartSimu.TabIndex = 2
        Me.bt_StartSimu.Text = "START"
        Me.bt_StartSimu.UseVisualStyleBackColor = True
        '
        'pb_Progres
        '
        Me.pb_Progres.Location = New System.Drawing.Point(59, 134)
        Me.pb_Progres.Name = "pb_Progres"
        Me.pb_Progres.Size = New System.Drawing.Size(183, 23)
        Me.pb_Progres.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "seconds"
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.Location = New System.Drawing.Point(34, 22)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(78, 13)
        Me.Label0.TabIndex = 7
        Me.Label0.Text = "Number of Adq"
        '
        'txt_NumAdq
        '
        Me.txt_NumAdq.Location = New System.Drawing.Point(118, 19)
        Me.txt_NumAdq.Name = "txt_NumAdq"
        Me.txt_NumAdq.Size = New System.Drawing.Size(51, 20)
        Me.txt_NumAdq.TabIndex = 6
        Me.txt_NumAdq.Text = "10"
        Me.txt_NumAdq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "(1-100)"
        '
        'Simu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 182)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label0)
        Me.Controls.Add(Me.txt_NumAdq)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pb_Progres)
        Me.Controls.Add(Me.bt_StartSimu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Delay)
        Me.Name = "Simu"
        Me.Text = "Simulate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Delay As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_StartSimu As System.Windows.Forms.Button
    Friend WithEvents pb_Progres As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label0 As System.Windows.Forms.Label
    Friend WithEvents txt_NumAdq As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
