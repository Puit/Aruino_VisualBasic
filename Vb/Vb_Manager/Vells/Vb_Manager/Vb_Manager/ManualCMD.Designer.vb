<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManualCMD
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
        Me.txtCMD = New System.Windows.Forms.TextBox()
        Me.txtArg1 = New System.Windows.Forms.TextBox()
        Me.txtArg2 = New System.Windows.Forms.TextBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btSend = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btClear = New System.Windows.Forms.Button()
        Me.lstCMDs = New System.Windows.Forms.ListBox()
        Me.btClearHistory = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCMD
        '
        Me.txtCMD.Location = New System.Drawing.Point(80, 33)
        Me.txtCMD.Name = "txtCMD"
        Me.txtCMD.Size = New System.Drawing.Size(100, 20)
        Me.txtCMD.TabIndex = 0
        '
        'txtArg1
        '
        Me.txtArg1.Location = New System.Drawing.Point(80, 80)
        Me.txtArg1.Name = "txtArg1"
        Me.txtArg1.Size = New System.Drawing.Size(100, 20)
        Me.txtArg1.TabIndex = 1
        '
        'txtArg2
        '
        Me.txtArg2.Location = New System.Drawing.Point(80, 121)
        Me.txtArg2.Name = "txtArg2"
        Me.txtArg2.Size = New System.Drawing.Size(100, 20)
        Me.txtArg2.TabIndex = 2
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(303, 33)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(38, 13)
        Me.lblMsg.TabIndex = 3
        Me.lblMsg.Text = "#$@#"
        '
        'btSend
        '
        Me.btSend.Location = New System.Drawing.Point(397, 159)
        Me.btSend.Name = "btSend"
        Me.btSend.Size = New System.Drawing.Size(56, 23)
        Me.btSend.TabIndex = 4
        Me.btSend.Text = "SEND"
        Me.btSend.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(141, 204)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(25, 13)
        Me.lblInfo.TabIndex = 5
        Me.lblInfo.Text = "Info"
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtAnswer.Location = New System.Drawing.Point(138, 231)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(292, 20)
        Me.txtAnswer.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "COM: Answer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CMD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ARG1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ARG2"
        '
        'btClear
        '
        Me.btClear.Location = New System.Drawing.Point(99, 159)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(56, 23)
        Me.btClear.TabIndex = 11
        Me.btClear.Text = "CLEAR"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'lstCMDs
        '
        Me.lstCMDs.FormattingEnabled = True
        Me.lstCMDs.Items.AddRange(New Object() {"#ADQUIRE$@#", "#SETUP$@#", "#TIME$DY@5#"})
        Me.lstCMDs.Location = New System.Drawing.Point(215, 65)
        Me.lstCMDs.Name = "lstCMDs"
        Me.lstCMDs.ScrollAlwaysVisible = True
        Me.lstCMDs.Size = New System.Drawing.Size(238, 69)
        Me.lstCMDs.TabIndex = 12
        '
        'btClearHistory
        '
        Me.btClearHistory.Location = New System.Drawing.Point(236, 159)
        Me.btClearHistory.Name = "btClearHistory"
        Me.btClearHistory.Size = New System.Drawing.Size(72, 23)
        Me.btClearHistory.TabIndex = 13
        Me.btClearHistory.Text = "CLR. HIST"
        Me.btClearHistory.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "MSG TO SEND:"
        '
        'ManualCMD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 289)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btClearHistory)
        Me.Controls.Add(Me.lstCMDs)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btSend)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.txtArg2)
        Me.Controls.Add(Me.txtArg1)
        Me.Controls.Add(Me.txtCMD)
        Me.Name = "ManualCMD"
        Me.Text = "ManualCMD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCMD As System.Windows.Forms.TextBox
    Friend WithEvents txtArg1 As System.Windows.Forms.TextBox
    Friend WithEvents txtArg2 As System.Windows.Forms.TextBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents btSend As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btClear As System.Windows.Forms.Button
    Friend WithEvents lstCMDs As System.Windows.Forms.ListBox
    Friend WithEvents btClearHistory As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
