<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SensorSetup
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
        Me.cbAnlg1 = New System.Windows.Forms.CheckBox()
        Me.txtAnlg1Pin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btLoad = New System.Windows.Forms.Button()
        Me.btClear = New System.Windows.Forms.Button()
        Me.btSend = New System.Windows.Forms.Button()
        Me.gpAnl2Alerts = New System.Windows.Forms.GroupBox()
        Me.txtAnlg2max = New System.Windows.Forms.TextBox()
        Me.cbAnlg2max = New System.Windows.Forms.CheckBox()
        Me.cbAnlg2bet = New System.Windows.Forms.CheckBox()
        Me.txtAnlg2min = New System.Windows.Forms.TextBox()
        Me.cbAnlg2min = New System.Windows.Forms.CheckBox()
        Me.txtAnlg2Pin = New System.Windows.Forms.TextBox()
        Me.cbAnlg2 = New System.Windows.Forms.CheckBox()
        Me.txtDig1Pin = New System.Windows.Forms.TextBox()
        Me.cbDig1 = New System.Windows.Forms.CheckBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.cbAnlg1min = New System.Windows.Forms.CheckBox()
        Me.txtAnlg1min = New System.Windows.Forms.TextBox()
        Me.cbAnlg1bet = New System.Windows.Forms.CheckBox()
        Me.cbAnlg1max = New System.Windows.Forms.CheckBox()
        Me.txtAnlg1max = New System.Windows.Forms.TextBox()
        Me.gpAnl1Alerts = New System.Windows.Forms.GroupBox()
        Me.lbl_C = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gpAnl2Alerts.SuspendLayout()
        Me.gpAnl1Alerts.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbAnlg1
        '
        Me.cbAnlg1.AutoSize = True
        Me.cbAnlg1.Location = New System.Drawing.Point(42, 69)
        Me.cbAnlg1.Name = "cbAnlg1"
        Me.cbAnlg1.Size = New System.Drawing.Size(86, 17)
        Me.cbAnlg1.TabIndex = 1
        Me.cbAnlg1.Text = "Temperature"
        Me.cbAnlg1.UseVisualStyleBackColor = True
        '
        'txtAnlg1Pin
        '
        Me.txtAnlg1Pin.Enabled = False
        Me.txtAnlg1Pin.Location = New System.Drawing.Point(134, 66)
        Me.txtAnlg1Pin.Name = "txtAnlg1Pin"
        Me.txtAnlg1Pin.Size = New System.Drawing.Size(36, 20)
        Me.txtAnlg1Pin.TabIndex = 2
        Me.txtAnlg1Pin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PIN"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(53, 345)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 23)
        Me.btSave.TabIndex = 17
        Me.btSave.Text = "SAVE"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btLoad
        '
        Me.btLoad.Location = New System.Drawing.Point(157, 345)
        Me.btLoad.Name = "btLoad"
        Me.btLoad.Size = New System.Drawing.Size(75, 23)
        Me.btLoad.TabIndex = 18
        Me.btLoad.Text = "LOAD"
        Me.btLoad.UseVisualStyleBackColor = True
        '
        'btClear
        '
        Me.btClear.Location = New System.Drawing.Point(261, 345)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(75, 23)
        Me.btClear.TabIndex = 19
        Me.btClear.Text = "CLEAR"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'btSend
        '
        Me.btSend.Location = New System.Drawing.Point(365, 345)
        Me.btSend.Name = "btSend"
        Me.btSend.Size = New System.Drawing.Size(75, 23)
        Me.btSend.TabIndex = 20
        Me.btSend.Text = "SEND"
        Me.btSend.UseVisualStyleBackColor = True
        '
        'gpAnl2Alerts
        '
        Me.gpAnl2Alerts.Controls.Add(Me.Label4)
        Me.gpAnl2Alerts.Controls.Add(Me.Label3)
        Me.gpAnl2Alerts.Controls.Add(Me.txtAnlg2max)
        Me.gpAnl2Alerts.Controls.Add(Me.cbAnlg2max)
        Me.gpAnl2Alerts.Controls.Add(Me.cbAnlg2bet)
        Me.gpAnl2Alerts.Controls.Add(Me.txtAnlg2min)
        Me.gpAnl2Alerts.Controls.Add(Me.cbAnlg2min)
        Me.gpAnl2Alerts.Enabled = False
        Me.gpAnl2Alerts.Location = New System.Drawing.Point(202, 129)
        Me.gpAnl2Alerts.Name = "gpAnl2Alerts"
        Me.gpAnl2Alerts.Size = New System.Drawing.Size(223, 66)
        Me.gpAnl2Alerts.TabIndex = 19
        Me.gpAnl2Alerts.TabStop = False
        Me.gpAnl2Alerts.Text = "ALERTS"
        '
        'txtAnlg2max
        '
        Me.txtAnlg2max.Location = New System.Drawing.Point(121, 42)
        Me.txtAnlg2max.Name = "txtAnlg2max"
        Me.txtAnlg2max.Size = New System.Drawing.Size(49, 20)
        Me.txtAnlg2max.TabIndex = 14
        Me.txtAnlg2max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbAnlg2max
        '
        Me.cbAnlg2max.AutoSize = True
        Me.cbAnlg2max.Location = New System.Drawing.Point(129, 19)
        Me.cbAnlg2max.Name = "cbAnlg2max"
        Me.cbAnlg2max.Size = New System.Drawing.Size(46, 17)
        Me.cbAnlg2max.TabIndex = 12
        Me.cbAnlg2max.Text = "Max"
        Me.cbAnlg2max.UseVisualStyleBackColor = True
        '
        'cbAnlg2bet
        '
        Me.cbAnlg2bet.AutoSize = True
        Me.cbAnlg2bet.Location = New System.Drawing.Point(55, 19)
        Me.cbAnlg2bet.Name = "cbAnlg2bet"
        Me.cbAnlg2bet.Size = New System.Drawing.Size(68, 17)
        Me.cbAnlg2bet.TabIndex = 11
        Me.cbAnlg2bet.Text = "Between"
        Me.cbAnlg2bet.UseVisualStyleBackColor = True
        '
        'txtAnlg2min
        '
        Me.txtAnlg2min.Location = New System.Drawing.Point(6, 42)
        Me.txtAnlg2min.Name = "txtAnlg2min"
        Me.txtAnlg2min.Size = New System.Drawing.Size(49, 20)
        Me.txtAnlg2min.TabIndex = 13
        Me.txtAnlg2min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbAnlg2min
        '
        Me.cbAnlg2min.AutoSize = True
        Me.cbAnlg2min.Location = New System.Drawing.Point(6, 19)
        Me.cbAnlg2min.Name = "cbAnlg2min"
        Me.cbAnlg2min.Size = New System.Drawing.Size(43, 17)
        Me.cbAnlg2min.TabIndex = 10
        Me.cbAnlg2min.Text = "Min"
        Me.cbAnlg2min.UseVisualStyleBackColor = True
        '
        'txtAnlg2Pin
        '
        Me.txtAnlg2Pin.Enabled = False
        Me.txtAnlg2Pin.Location = New System.Drawing.Point(134, 155)
        Me.txtAnlg2Pin.Name = "txtAnlg2Pin"
        Me.txtAnlg2Pin.Size = New System.Drawing.Size(36, 20)
        Me.txtAnlg2Pin.TabIndex = 9
        Me.txtAnlg2Pin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbAnlg2
        '
        Me.cbAnlg2.AutoSize = True
        Me.cbAnlg2.Location = New System.Drawing.Point(42, 158)
        Me.cbAnlg2.Name = "cbAnlg2"
        Me.cbAnlg2.Size = New System.Drawing.Size(75, 17)
        Me.cbAnlg2.TabIndex = 8
        Me.cbAnlg2.Text = "Brightness"
        Me.cbAnlg2.UseVisualStyleBackColor = True
        '
        'txtDig1Pin
        '
        Me.txtDig1Pin.Enabled = False
        Me.txtDig1Pin.Location = New System.Drawing.Point(134, 232)
        Me.txtDig1Pin.Name = "txtDig1Pin"
        Me.txtDig1Pin.Size = New System.Drawing.Size(36, 20)
        Me.txtDig1Pin.TabIndex = 16
        Me.txtDig1Pin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbDig1
        '
        Me.cbDig1.AutoSize = True
        Me.cbDig1.Location = New System.Drawing.Point(42, 235)
        Me.cbDig1.Name = "cbDig1"
        Me.cbDig1.Size = New System.Drawing.Size(71, 17)
        Me.cbDig1.TabIndex = 15
        Me.cbDig1.Text = "Presence"
        Me.cbDig1.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(53, 304)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(41, 15)
        Me.lblMsg.TabIndex = 0
        Me.lblMsg.Text = "Label4"
        Me.lblMsg.Visible = False
        '
        'cbAnlg1min
        '
        Me.cbAnlg1min.AutoSize = True
        Me.cbAnlg1min.Location = New System.Drawing.Point(6, 19)
        Me.cbAnlg1min.Name = "cbAnlg1min"
        Me.cbAnlg1min.Size = New System.Drawing.Size(43, 17)
        Me.cbAnlg1min.TabIndex = 3
        Me.cbAnlg1min.Text = "Min"
        Me.cbAnlg1min.UseVisualStyleBackColor = True
        '
        'txtAnlg1min
        '
        Me.txtAnlg1min.Location = New System.Drawing.Point(6, 42)
        Me.txtAnlg1min.Name = "txtAnlg1min"
        Me.txtAnlg1min.Size = New System.Drawing.Size(49, 20)
        Me.txtAnlg1min.TabIndex = 6
        Me.txtAnlg1min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbAnlg1bet
        '
        Me.cbAnlg1bet.AutoSize = True
        Me.cbAnlg1bet.Location = New System.Drawing.Point(55, 19)
        Me.cbAnlg1bet.Name = "cbAnlg1bet"
        Me.cbAnlg1bet.Size = New System.Drawing.Size(68, 17)
        Me.cbAnlg1bet.TabIndex = 4
        Me.cbAnlg1bet.Text = "Between"
        Me.cbAnlg1bet.UseVisualStyleBackColor = True
        '
        'cbAnlg1max
        '
        Me.cbAnlg1max.AutoSize = True
        Me.cbAnlg1max.Location = New System.Drawing.Point(129, 19)
        Me.cbAnlg1max.Name = "cbAnlg1max"
        Me.cbAnlg1max.Size = New System.Drawing.Size(46, 17)
        Me.cbAnlg1max.TabIndex = 5
        Me.cbAnlg1max.Text = "Max"
        Me.cbAnlg1max.UseVisualStyleBackColor = True
        '
        'txtAnlg1max
        '
        Me.txtAnlg1max.Location = New System.Drawing.Point(121, 42)
        Me.txtAnlg1max.Name = "txtAnlg1max"
        Me.txtAnlg1max.Size = New System.Drawing.Size(49, 20)
        Me.txtAnlg1max.TabIndex = 7
        Me.txtAnlg1max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gpAnl1Alerts
        '
        Me.gpAnl1Alerts.Controls.Add(Me.Label2)
        Me.gpAnl1Alerts.Controls.Add(Me.lbl_C)
        Me.gpAnl1Alerts.Controls.Add(Me.txtAnlg1max)
        Me.gpAnl1Alerts.Controls.Add(Me.cbAnlg1max)
        Me.gpAnl1Alerts.Controls.Add(Me.cbAnlg1bet)
        Me.gpAnl1Alerts.Controls.Add(Me.txtAnlg1min)
        Me.gpAnl1Alerts.Controls.Add(Me.cbAnlg1min)
        Me.gpAnl1Alerts.Enabled = False
        Me.gpAnl1Alerts.Location = New System.Drawing.Point(202, 40)
        Me.gpAnl1Alerts.Name = "gpAnl1Alerts"
        Me.gpAnl1Alerts.Size = New System.Drawing.Size(223, 66)
        Me.gpAnl1Alerts.TabIndex = 11
        Me.gpAnl1Alerts.TabStop = False
        Me.gpAnl1Alerts.Text = "ALERTS"
        '
        'lbl_C
        '
        Me.lbl_C.AutoSize = True
        Me.lbl_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_C.Location = New System.Drawing.Point(61, 42)
        Me.lbl_C.Name = "lbl_C"
        Me.lbl_C.Size = New System.Drawing.Size(22, 16)
        Me.lbl_C.TabIndex = 29
        Me.lbl_C.Text = "ºC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "ºC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Cd"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(176, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Cd"
        '
        'SensorSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 407)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.txtDig1Pin)
        Me.Controls.Add(Me.cbDig1)
        Me.Controls.Add(Me.gpAnl2Alerts)
        Me.Controls.Add(Me.txtAnlg2Pin)
        Me.Controls.Add(Me.cbAnlg2)
        Me.Controls.Add(Me.btSend)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.btLoad)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.gpAnl1Alerts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAnlg1Pin)
        Me.Controls.Add(Me.cbAnlg1)
        Me.Name = "SensorSetup"
        Me.Text = "SensorSetup"
        Me.gpAnl2Alerts.ResumeLayout(False)
        Me.gpAnl2Alerts.PerformLayout()
        Me.gpAnl1Alerts.ResumeLayout(False)
        Me.gpAnl1Alerts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbAnlg1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtAnlg1Pin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btLoad As System.Windows.Forms.Button
    Friend WithEvents btClear As System.Windows.Forms.Button
    Friend WithEvents btSend As System.Windows.Forms.Button
    Friend WithEvents gpAnl2Alerts As System.Windows.Forms.GroupBox
    Friend WithEvents txtAnlg2max As System.Windows.Forms.TextBox
    Friend WithEvents cbAnlg2max As System.Windows.Forms.CheckBox
    Friend WithEvents cbAnlg2bet As System.Windows.Forms.CheckBox
    Friend WithEvents txtAnlg2min As System.Windows.Forms.TextBox
    Friend WithEvents cbAnlg2min As System.Windows.Forms.CheckBox
    Friend WithEvents txtAnlg2Pin As System.Windows.Forms.TextBox
    Friend WithEvents cbAnlg2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtDig1Pin As System.Windows.Forms.TextBox
    Friend WithEvents cbDig1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents cbAnlg1min As System.Windows.Forms.CheckBox
    Friend WithEvents txtAnlg1min As System.Windows.Forms.TextBox
    Friend WithEvents cbAnlg1bet As System.Windows.Forms.CheckBox
    Friend WithEvents cbAnlg1max As System.Windows.Forms.CheckBox
    Friend WithEvents txtAnlg1max As System.Windows.Forms.TextBox
    Friend WithEvents gpAnl1Alerts As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_C As System.Windows.Forms.Label
End Class
