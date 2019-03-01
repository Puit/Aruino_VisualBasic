<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuMDI = New System.Windows.Forms.MenuStrip()
        Me.PcMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadFileItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewConnectionItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseConnectionItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SensorItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdquireItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimulateItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AwningControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MotorControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualCMDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraphDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuMDI.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuMDI
        '
        Me.MenuMDI.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PcMenu, Me.FileMenu, Me.ConnectionItem, Me.SensorItem, Me.DataToolStripMenuItem})
        Me.MenuMDI.Location = New System.Drawing.Point(0, 0)
        Me.MenuMDI.Name = "MenuMDI"
        Me.MenuMDI.Size = New System.Drawing.Size(1055, 24)
        Me.MenuMDI.TabIndex = 5
        Me.MenuMDI.Text = "MenuStrip"
        '
        'PcMenu
        '
        Me.PcMenu.Image = Global.Vb_Manager.My.Resources.Resources.off
        Me.PcMenu.Name = "PcMenu"
        Me.PcMenu.Size = New System.Drawing.Size(38, 20)
        Me.PcMenu.Text = " "
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadFileItem, Me.SaveFileItem, Me.ExitItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "File"
        '
        'LoadFileItem
        '
        Me.LoadFileItem.Name = "LoadFileItem"
        Me.LoadFileItem.Size = New System.Drawing.Size(152, 22)
        Me.LoadFileItem.Text = "Load File"
        '
        'SaveFileItem
        '
        Me.SaveFileItem.Name = "SaveFileItem"
        Me.SaveFileItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveFileItem.Text = "Save File"
        '
        'ExitItem
        '
        Me.ExitItem.Name = "ExitItem"
        Me.ExitItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitItem.Text = "Exit"
        '
        'ConnectionItem
        '
        Me.ConnectionItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewConnectionItem, Me.CloseConnectionItem})
        Me.ConnectionItem.Name = "ConnectionItem"
        Me.ConnectionItem.Size = New System.Drawing.Size(81, 20)
        Me.ConnectionItem.Text = "Connection"
        '
        'NewConnectionItem
        '
        Me.NewConnectionItem.Name = "NewConnectionItem"
        Me.NewConnectionItem.Size = New System.Drawing.Size(168, 22)
        Me.NewConnectionItem.Text = "Open Connection"
        '
        'CloseConnectionItem
        '
        Me.CloseConnectionItem.Name = "CloseConnectionItem"
        Me.CloseConnectionItem.Size = New System.Drawing.Size(168, 22)
        Me.CloseConnectionItem.Text = "Close Connection"
        '
        'SensorItem
        '
        Me.SensorItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupItem, Me.AdquireItem, Me.SimulateItem, Me.AwningControlToolStripMenuItem, Me.MotorControlToolStripMenuItem, Me.ManualCMDToolStripMenuItem})
        Me.SensorItem.Name = "SensorItem"
        Me.SensorItem.Size = New System.Drawing.Size(50, 20)
        Me.SensorItem.Text = "Board"
        '
        'SetupItem
        '
        Me.SetupItem.Name = "SetupItem"
        Me.SetupItem.Size = New System.Drawing.Size(158, 22)
        Me.SetupItem.Text = "Sensor Setup"
        '
        'AdquireItem
        '
        Me.AdquireItem.Enabled = False
        Me.AdquireItem.Name = "AdquireItem"
        Me.AdquireItem.Size = New System.Drawing.Size(158, 22)
        Me.AdquireItem.Text = "Adquire"
        '
        'SimulateItem
        '
        Me.SimulateItem.Name = "SimulateItem"
        Me.SimulateItem.Size = New System.Drawing.Size(158, 22)
        Me.SimulateItem.Text = "Simulate"
        '
        'AwningControlToolStripMenuItem
        '
        Me.AwningControlToolStripMenuItem.Name = "AwningControlToolStripMenuItem"
        Me.AwningControlToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.AwningControlToolStripMenuItem.Text = "Awning Control"
        '
        'MotorControlToolStripMenuItem
        '
        Me.MotorControlToolStripMenuItem.Name = "MotorControlToolStripMenuItem"
        Me.MotorControlToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.MotorControlToolStripMenuItem.Text = "Motor Control"
        '
        'ManualCMDToolStripMenuItem
        '
        Me.ManualCMDToolStripMenuItem.Name = "ManualCMDToolStripMenuItem"
        Me.ManualCMDToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ManualCMDToolStripMenuItem.Text = "Manual CMD"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowDataToolStripMenuItem, Me.GraphDataToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'ShowDataToolStripMenuItem
        '
        Me.ShowDataToolStripMenuItem.Name = "ShowDataToolStripMenuItem"
        Me.ShowDataToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ShowDataToolStripMenuItem.Text = "Show Data"
        '
        'GraphDataToolStripMenuItem
        '
        Me.GraphDataToolStripMenuItem.Name = "GraphDataToolStripMenuItem"
        Me.GraphDataToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GraphDataToolStripMenuItem.Text = "Graph Data"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 576)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1055, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 598)
        Me.Controls.Add(Me.MenuMDI)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuMDI
        Me.Name = "mainMenu"
        Me.Text = "Sensor Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuMDI.ResumeLayout(False)
        Me.MenuMDI.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuMDI As System.Windows.Forms.MenuStrip
    Friend WithEvents SensorItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadFileItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectionItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewConnectionItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseConnectionItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdquireItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimulateItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MotorControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GraphDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PcMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualCMDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AwningControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
