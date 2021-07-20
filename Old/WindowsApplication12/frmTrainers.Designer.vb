<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrainers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrainers))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SearchForTrainerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTrainerID = New System.Windows.Forms.TextBox()
        Me.txtTrainerName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTrainerSurname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTrainerCintect_NO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboTrainerClass = New System.Windows.Forms.ComboBox()
        Me.txtTrainerSalary = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnFire = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCalcSalary = New System.Windows.Forms.Button()
        Me.lstMembers = New System.Windows.Forms.ListBox()
        Me.TrainersNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.FitnessClub_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TrainersNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TrainersNavigator.SuspendLayout()
        CType(Me.FitnessClub_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(674, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchForTrainerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(674, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SearchForTrainerToolStripMenuItem
        '
        Me.SearchForTrainerToolStripMenuItem.Name = "SearchForTrainerToolStripMenuItem"
        Me.SearchForTrainerToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.SearchForTrainerToolStripMenuItem.Text = "Search For Trainer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 155)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID Number"
        '
        'txtTrainerID
        '
        Me.txtTrainerID.Enabled = False
        Me.txtTrainerID.Location = New System.Drawing.Point(81, 152)
        Me.txtTrainerID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTrainerID.MaxLength = 13
        Me.txtTrainerID.Name = "txtTrainerID"
        Me.txtTrainerID.Size = New System.Drawing.Size(151, 21)
        Me.txtTrainerID.TabIndex = 3
        '
        'txtTrainerName
        '
        Me.txtTrainerName.Enabled = False
        Me.txtTrainerName.Location = New System.Drawing.Point(81, 207)
        Me.txtTrainerName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTrainerName.MaxLength = 30
        Me.txtTrainerName.Name = "txtTrainerName"
        Me.txtTrainerName.Size = New System.Drawing.Size(151, 21)
        Me.txtTrainerName.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 210)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name"
        '
        'txtTrainerSurname
        '
        Me.txtTrainerSurname.Enabled = False
        Me.txtTrainerSurname.Location = New System.Drawing.Point(81, 255)
        Me.txtTrainerSurname.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTrainerSurname.MaxLength = 30
        Me.txtTrainerSurname.Name = "txtTrainerSurname"
        Me.txtTrainerSurname.Size = New System.Drawing.Size(151, 21)
        Me.txtTrainerSurname.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 258)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Surname"
        '
        'txtTrainerCintect_NO
        '
        Me.txtTrainerCintect_NO.Enabled = False
        Me.txtTrainerCintect_NO.Location = New System.Drawing.Point(81, 305)
        Me.txtTrainerCintect_NO.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTrainerCintect_NO.MaxLength = 10
        Me.txtTrainerCintect_NO.Name = "txtTrainerCintect_NO"
        Me.txtTrainerCintect_NO.Size = New System.Drawing.Size(151, 21)
        Me.txtTrainerCintect_NO.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 308)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Contect #"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(399, 150)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 25)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Members Under Trainer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Class"
        '
        'cboTrainerClass
        '
        Me.cboTrainerClass.Enabled = False
        Me.cboTrainerClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboTrainerClass.FormattingEnabled = True
        Me.cboTrainerClass.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cboTrainerClass.Location = New System.Drawing.Point(81, 340)
        Me.cboTrainerClass.Name = "cboTrainerClass"
        Me.cboTrainerClass.Size = New System.Drawing.Size(46, 22)
        Me.cboTrainerClass.TabIndex = 20
        '
        'txtTrainerSalary
        '
        Me.txtTrainerSalary.Location = New System.Drawing.Point(81, 375)
        Me.txtTrainerSalary.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTrainerSalary.Name = "txtTrainerSalary"
        Me.txtTrainerSalary.ReadOnly = True
        Me.txtTrainerSalary.Size = New System.Drawing.Size(151, 21)
        Me.txtTrainerSalary.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 379)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Salary"
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(251, 440)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(50, 51)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "SA&VE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnFire
        '
        Me.btnFire.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFire.Location = New System.Drawing.Point(173, 440)
        Me.btnFire.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(50, 51)
        Me.btnFire.TabIndex = 25
        Me.btnFire.Text = "F&IRE"
        Me.btnFire.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(93, 440)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(50, 51)
        Me.btnEdit.TabIndex = 24
        Me.btnEdit.Text = "E&DIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(13, 440)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(50, 51)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "A&DD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCalcSalary
        '
        Me.btnCalcSalary.Enabled = False
        Me.btnCalcSalary.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcSalary.Location = New System.Drawing.Point(324, 440)
        Me.btnCalcSalary.Name = "btnCalcSalary"
        Me.btnCalcSalary.Size = New System.Drawing.Size(75, 51)
        Me.btnCalcSalary.TabIndex = 27
        Me.btnCalcSalary.Text = "Calculate SALARY"
        Me.btnCalcSalary.UseVisualStyleBackColor = True
        '
        'lstMembers
        '
        Me.lstMembers.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMembers.FormattingEnabled = True
        Me.lstMembers.ItemHeight = 20
        Me.lstMembers.Location = New System.Drawing.Point(404, 179)
        Me.lstMembers.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lstMembers.Name = "lstMembers"
        Me.lstMembers.Size = New System.Drawing.Size(270, 304)
        Me.lstMembers.TabIndex = 28
        '
        'TrainersNavigator
        '
        Me.TrainersNavigator.AddNewItem = Nothing
        Me.TrainersNavigator.BindingSource = Me.FitnessClub_BindingSource
        Me.TrainersNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TrainersNavigator.DeleteItem = Nothing
        Me.TrainersNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TrainersNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TrainersNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem})
        Me.TrainersNavigator.Location = New System.Drawing.Point(14, 399)
        Me.TrainersNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TrainersNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TrainersNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TrainersNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TrainersNavigator.Name = "TrainersNavigator"
        Me.TrainersNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TrainersNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TrainersNavigator.Size = New System.Drawing.Size(194, 25)
        Me.TrainersNavigator.TabIndex = 29
        Me.TrainersNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'frmTrainers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(4.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 503)
        Me.Controls.Add(Me.TrainersNavigator)
        Me.Controls.Add(Me.lstMembers)
        Me.Controls.Add(Me.btnCalcSalary)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnFire)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtTrainerSalary)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboTrainerClass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTrainerCintect_NO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTrainerSurname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTrainerName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTrainerID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Agency FB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmTrainers"
        Me.Text = "Trainers"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TrainersNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TrainersNavigator.ResumeLayout(False)
        Me.TrainersNavigator.PerformLayout()
        CType(Me.FitnessClub_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SearchForTrainerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTrainerID As System.Windows.Forms.TextBox
    Friend WithEvents txtTrainerName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTrainerSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTrainerCintect_NO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboTrainerClass As System.Windows.Forms.ComboBox
    Friend WithEvents txtTrainerSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnFire As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCalcSalary As System.Windows.Forms.Button
    Friend WithEvents lstMembers As System.Windows.Forms.ListBox
    Friend WithEvents TrainersNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FitnessClub_BindingSource As System.Windows.Forms.BindingSource
End Class
