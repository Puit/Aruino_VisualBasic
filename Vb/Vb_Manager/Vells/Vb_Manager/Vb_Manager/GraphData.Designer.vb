<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphData
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.btA1id = New System.Windows.Forms.Button()
        Me.chr = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btA2id = New System.Windows.Forms.Button()
        Me.btD1id = New System.Windows.Forms.Button()
        CType(Me.chr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btA1id
        '
        Me.btA1id.Location = New System.Drawing.Point(46, 49)
        Me.btA1id.Name = "btA1id"
        Me.btA1id.Size = New System.Drawing.Size(75, 23)
        Me.btA1id.TabIndex = 5
        Me.btA1id.Text = "A1 > Id"
        Me.btA1id.UseVisualStyleBackColor = True
        '
        'chr
        '
        Me.chr.BorderlineColor = System.Drawing.Color.DimGray
        ChartArea1.Name = "ChartArea1"
        Me.chr.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chr.Legends.Add(Legend1)
        Me.chr.Location = New System.Drawing.Point(175, 34)
        Me.chr.Name = "chr"
        Me.chr.Size = New System.Drawing.Size(549, 300)
        Me.chr.TabIndex = 6
        '
        'btA2id
        '
        Me.btA2id.Location = New System.Drawing.Point(46, 90)
        Me.btA2id.Name = "btA2id"
        Me.btA2id.Size = New System.Drawing.Size(75, 23)
        Me.btA2id.TabIndex = 7
        Me.btA2id.Text = "A2 > Id"
        Me.btA2id.UseVisualStyleBackColor = True
        '
        'btD1id
        '
        Me.btD1id.Location = New System.Drawing.Point(46, 134)
        Me.btD1id.Name = "btD1id"
        Me.btD1id.Size = New System.Drawing.Size(75, 23)
        Me.btD1id.TabIndex = 8
        Me.btD1id.Text = "D1 > Id"
        Me.btD1id.UseVisualStyleBackColor = True
        '
        'GraphData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 376)
        Me.Controls.Add(Me.btD1id)
        Me.Controls.Add(Me.btA2id)
        Me.Controls.Add(Me.chr)
        Me.Controls.Add(Me.btA1id)
        Me.Name = "GraphData"
        Me.Text = "GraphData"
        CType(Me.chr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btA1id As System.Windows.Forms.Button
    Friend WithEvents chr As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btA2id As System.Windows.Forms.Button
    Friend WithEvents btD1id As System.Windows.Forms.Button
End Class
