<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveFile
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
        Me.btPath = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btSave = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btPath
        '
        Me.btPath.Location = New System.Drawing.Point(22, 112)
        Me.btPath.Name = "btPath"
        Me.btPath.Size = New System.Drawing.Size(62, 23)
        Me.btPath.TabIndex = 1
        Me.btPath.Text = "Path"
        Me.btPath.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(22, 160)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(62, 23)
        Me.btCancel.TabIndex = 2
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(60, 53)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(142, 20)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = "name"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(22, 209)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(62, 23)
        Me.btSave.TabIndex = 3
        Me.btSave.Text = "Save"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(19, 56)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(35, 13)
        Me.lblMsg.TabIndex = 4
        Me.lblMsg.Text = "Name"
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(90, 117)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(55, 13)
        Me.lblPath.TabIndex = 5
        Me.lblPath.Text = ".\name.txt"
        '
        'SaveFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 261)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btPath)
        Me.Name = "SaveFile"
        Me.Text = "Save File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btPath As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents lblPath As System.Windows.Forms.Label
End Class
