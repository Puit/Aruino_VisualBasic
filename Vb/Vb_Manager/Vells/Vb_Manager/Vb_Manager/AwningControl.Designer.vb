<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AwningControl
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_Cd = New System.Windows.Forms.Label()
        Me.txtBx_Temp = New System.Windows.Forms.TextBox()
        Me.lbl_Temp = New System.Windows.Forms.Label()
        Me.btSend = New System.Windows.Forms.Button()
        Me.btClear = New System.Windows.Forms.Button()
        Me.btLoad = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbt_Off = New System.Windows.Forms.RadioButton()
        Me.rbt_On = New System.Windows.Forms.RadioButton()
        Me.pctBx_Awning = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pctBx_Awning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(247, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Information"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblMsg)
        Me.Panel3.Location = New System.Drawing.Point(250, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(118, 75)
        Me.Panel3.TabIndex = 33
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(12, 12)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(90, 50)
        Me.lblMsg.TabIndex = 21
        Me.lblMsg.Text = "Label4"
        Me.lblMsg.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.btSend)
        Me.Panel2.Controls.Add(Me.btClear)
        Me.Panel2.Controls.Add(Me.btLoad)
        Me.Panel2.Controls.Add(Me.btSave)
        Me.Panel2.Location = New System.Drawing.Point(12, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(365, 84)
        Me.Panel2.TabIndex = 32
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lbl_Cd)
        Me.Panel4.Controls.Add(Me.txtBx_Temp)
        Me.Panel4.Controls.Add(Me.lbl_Temp)
        Me.Panel4.Location = New System.Drawing.Point(0, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(122, 46)
        Me.Panel4.TabIndex = 29
        '
        'lbl_Cd
        '
        Me.lbl_Cd.AutoSize = True
        Me.lbl_Cd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cd.Location = New System.Drawing.Point(86, 20)
        Me.lbl_Cd.Name = "lbl_Cd"
        Me.lbl_Cd.Size = New System.Drawing.Size(25, 16)
        Me.lbl_Cd.TabIndex = 28
        Me.lbl_Cd.Text = "Cd"
        '
        'txtBx_Temp
        '
        Me.txtBx_Temp.Location = New System.Drawing.Point(14, 20)
        Me.txtBx_Temp.Name = "txtBx_Temp"
        Me.txtBx_Temp.Size = New System.Drawing.Size(66, 20)
        Me.txtBx_Temp.TabIndex = 27
        '
        'lbl_Temp
        '
        Me.lbl_Temp.AutoSize = True
        Me.lbl_Temp.Location = New System.Drawing.Point(13, 4)
        Me.lbl_Temp.Name = "lbl_Temp"
        Me.lbl_Temp.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Temp.TabIndex = 26
        Me.lbl_Temp.Text = "Brightness"
        '
        'btSend
        '
        Me.btSend.Location = New System.Drawing.Point(281, 48)
        Me.btSend.Name = "btSend"
        Me.btSend.Size = New System.Drawing.Size(75, 23)
        Me.btSend.TabIndex = 25
        Me.btSend.Text = "SEND"
        Me.btSend.UseVisualStyleBackColor = True
        '
        'btClear
        '
        Me.btClear.Location = New System.Drawing.Point(192, 48)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(75, 23)
        Me.btClear.TabIndex = 24
        Me.btClear.Text = "CLEAR"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'btLoad
        '
        Me.btLoad.Location = New System.Drawing.Point(103, 48)
        Me.btLoad.Name = "btLoad"
        Me.btLoad.Size = New System.Drawing.Size(75, 23)
        Me.btLoad.TabIndex = 23
        Me.btLoad.Text = "LOAD"
        Me.btLoad.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(14, 48)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 23)
        Me.btSave.TabIndex = 22
        Me.btSave.Text = "SAVE"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbt_Off)
        Me.Panel1.Controls.Add(Me.rbt_On)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(69, 67)
        Me.Panel1.TabIndex = 31
        '
        'rbt_Off
        '
        Me.rbt_Off.AutoSize = True
        Me.rbt_Off.Location = New System.Drawing.Point(16, 37)
        Me.rbt_Off.Name = "rbt_Off"
        Me.rbt_Off.Size = New System.Drawing.Size(45, 17)
        Me.rbt_Off.TabIndex = 1
        Me.rbt_Off.TabStop = True
        Me.rbt_Off.Text = "OFF"
        Me.rbt_Off.UseVisualStyleBackColor = True
        '
        'rbt_On
        '
        Me.rbt_On.AutoSize = True
        Me.rbt_On.Location = New System.Drawing.Point(16, 14)
        Me.rbt_On.Name = "rbt_On"
        Me.rbt_On.Size = New System.Drawing.Size(41, 17)
        Me.rbt_On.TabIndex = 0
        Me.rbt_On.TabStop = True
        Me.rbt_On.Text = "ON"
        Me.rbt_On.UseVisualStyleBackColor = True
        '
        'pctBx_Awning
        '
        Me.pctBx_Awning.Image = Global.Vb_Manager.My.Resources.Resources.Toldo
        Me.pctBx_Awning.Location = New System.Drawing.Point(160, 20)
        Me.pctBx_Awning.Name = "pctBx_Awning"
        Me.pctBx_Awning.Size = New System.Drawing.Size(70, 70)
        Me.pctBx_Awning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBx_Awning.TabIndex = 35
        Me.pctBx_Awning.TabStop = False
        '
        'AwningControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 185)
        Me.Controls.Add(Me.pctBx_Awning)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AwningControl"
        Me.Text = "AwningControl"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pctBx_Awning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Cd As System.Windows.Forms.Label
    Friend WithEvents txtBx_Temp As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Temp As System.Windows.Forms.Label
    Friend WithEvents btSend As System.Windows.Forms.Button
    Friend WithEvents btClear As System.Windows.Forms.Button
    Friend WithEvents btLoad As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbt_Off As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_On As System.Windows.Forms.RadioButton
    Friend WithEvents pctBx_Awning As System.Windows.Forms.PictureBox
End Class
