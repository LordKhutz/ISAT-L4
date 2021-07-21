<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MEMBERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PERSONALTRAINERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.AboutProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MEMBERSToolStripMenuItem, Me.PERSONALTRAINERSToolStripMenuItem, Me.AboutProgramToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(765, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MEMBERSToolStripMenuItem
        '
        Me.MEMBERSToolStripMenuItem.Name = "MEMBERSToolStripMenuItem"
        Me.MEMBERSToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.MEMBERSToolStripMenuItem.Text = "MEMBERS"
        '
        'PERSONALTRAINERSToolStripMenuItem
        '
        Me.PERSONALTRAINERSToolStripMenuItem.Name = "PERSONALTRAINERSToolStripMenuItem"
        Me.PERSONALTRAINERSToolStripMenuItem.Size = New System.Drawing.Size(133, 20)
        Me.PERSONALTRAINERSToolStripMenuItem.Text = "PERSONAL TRAINERS"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 450)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(765, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 17)
        Me.lblStatus.Text = "Status"
        '
        'AboutProgramToolStripMenuItem
        '
        Me.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem"
        Me.AboutProgramToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.AboutProgramToolStripMenuItem.Text = "About Program"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(765, 472)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMain"
        Me.Text = "Fitness Club"
        Me.TransparencyKey = System.Drawing.Color.Gray
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MEMBERSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PERSONALTRAINERSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AboutProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
