<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MRTracer
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
        Me.DataTree = New System.Windows.Forms.TreeView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpenNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataTree
        '
        Me.DataTree.Location = New System.Drawing.Point(13, 45)
        Me.DataTree.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataTree.Name = "DataTree"
        Me.DataTree.Size = New System.Drawing.Size(356, 735)
        Me.DataTree.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenNewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1476, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpenNewToolStripMenuItem
        '
        Me.OpenNewToolStripMenuItem.Name = "OpenNewToolStripMenuItem"
        Me.OpenNewToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.OpenNewToolStripMenuItem.Text = "Open New"
        '
        'MRTracer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1476, 767)
        Me.Controls.Add(Me.DataTree)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MRTracer"
        Me.Text = "Morning Report Tracer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataTree As TreeView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpenNewToolStripMenuItem As ToolStripMenuItem
End Class
