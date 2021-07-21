<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMembers))
        Me.txtID_Number = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtContectNumb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAges = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtHRmax = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtHRrest = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtVO2max = New System.Windows.Forms.TextBox()
        Me.MembersNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.FitnessClub_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboTrainer = New System.Windows.Forms.ComboBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.cboJoinDate = New System.Windows.Forms.DateTimePicker()
        Me.cboMembershipType = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SearchForMember = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.MembersNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MembersNavigator.SuspendLayout()
        CType(Me.FitnessClub_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtID_Number
        '
        Me.txtID_Number.Enabled = False
        Me.txtID_Number.Location = New System.Drawing.Point(108, 95)
        Me.txtID_Number.MaxLength = 13
        Me.txtID_Number.Name = "txtID_Number"
        Me.txtID_Number.Size = New System.Drawing.Size(138, 20)
        Me.txtID_Number.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(108, 130)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(161, 20)
        Me.txtName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Surname"
        '
        'txtSurname
        '
        Me.txtSurname.Enabled = False
        Me.txtSurname.Location = New System.Drawing.Point(108, 166)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(161, 20)
        Me.txtSurname.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Join Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Contect Number"
        '
        'txtContectNumb
        '
        Me.txtContectNumb.Enabled = False
        Me.txtContectNumb.Location = New System.Drawing.Point(108, 238)
        Me.txtContectNumb.MaxLength = 10
        Me.txtContectNumb.Name = "txtContectNumb"
        Me.txtContectNumb.Size = New System.Drawing.Size(161, 20)
        Me.txtContectNumb.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Age"
        '
        'txtAges
        '
        Me.txtAges.Enabled = False
        Me.txtAges.Location = New System.Drawing.Point(108, 269)
        Me.txtAges.MaxLength = 2
        Me.txtAges.Name = "txtAges"
        Me.txtAges.Size = New System.Drawing.Size(45, 20)
        Me.txtAges.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Hight (CM)"
        '
        'txtHeight
        '
        Me.txtHeight.Enabled = False
        Me.txtHeight.Location = New System.Drawing.Point(108, 304)
        Me.txtHeight.MaxLength = 4
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(45, 20)
        Me.txtHeight.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(312, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(312, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Membership Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(312, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "HRmax"
        '
        'txtHRmax
        '
        Me.txtHRmax.Enabled = False
        Me.txtHRmax.Location = New System.Drawing.Point(416, 163)
        Me.txtHRmax.MaxLength = 5
        Me.txtHRmax.Name = "txtHRmax"
        Me.txtHRmax.Size = New System.Drawing.Size(73, 20)
        Me.txtHRmax.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(312, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "HRrest"
        '
        'txtHRrest
        '
        Me.txtHRrest.Enabled = False
        Me.txtHRrest.Location = New System.Drawing.Point(416, 198)
        Me.txtHRrest.MaxLength = 5
        Me.txtHRrest.Name = "txtHRrest"
        Me.txtHRrest.Size = New System.Drawing.Size(73, 20)
        Me.txtHRrest.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(312, 241)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "VO₂ max"
        '
        'txtVO2max
        '
        Me.txtVO2max.Enabled = False
        Me.txtVO2max.Location = New System.Drawing.Point(416, 238)
        Me.txtVO2max.MaxLength = 5
        Me.txtVO2max.Name = "txtVO2max"
        Me.txtVO2max.Size = New System.Drawing.Size(73, 20)
        Me.txtVO2max.TabIndex = 22
        '
        'MembersNavigator
        '
        Me.MembersNavigator.AddNewItem = Nothing
        Me.MembersNavigator.BindingSource = Me.FitnessClub_BindingSource
        Me.MembersNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MembersNavigator.DeleteItem = Nothing
        Me.MembersNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.MembersNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MembersNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem})
        Me.MembersNavigator.Location = New System.Drawing.Point(7, 336)
        Me.MembersNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MembersNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MembersNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MembersNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MembersNavigator.Name = "MembersNavigator"
        Me.MembersNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MembersNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MembersNavigator.Size = New System.Drawing.Size(194, 25)
        Me.MembersNavigator.TabIndex = 26
        Me.MembersNavigator.Text = "BindingNavigator1"
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
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(7, 364)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 43)
        Me.btnAdd.TabIndex = 27
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(137, 364)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(82, 43)
        Me.btnEdit.TabIndex = 28
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(269, 364)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(82, 43)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(312, 276)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Trainer"
        '
        'cboTrainer
        '
        Me.cboTrainer.Enabled = False
        Me.cboTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTrainer.FormattingEnabled = True
        Me.cboTrainer.Location = New System.Drawing.Point(416, 272)
        Me.cboTrainer.Name = "cboTrainer"
        Me.cboTrainer.Size = New System.Drawing.Size(156, 21)
        Me.cboTrainer.TabIndex = 36
        '
        'cboGender
        '
        Me.cboGender.Enabled = False
        Me.cboGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cboGender.Location = New System.Drawing.Point(416, 94)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(121, 21)
        Me.cboGender.TabIndex = 37
        '
        'cboJoinDate
        '
        Me.cboJoinDate.Enabled = False
        Me.cboJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cboJoinDate.Location = New System.Drawing.Point(108, 200)
        Me.cboJoinDate.Name = "cboJoinDate"
        Me.cboJoinDate.Size = New System.Drawing.Size(111, 20)
        Me.cboJoinDate.TabIndex = 38
        Me.cboJoinDate.Value = New Date(2013, 9, 12, 22, 54, 31, 0)
        '
        'cboMembershipType
        '
        Me.cboMembershipType.Enabled = False
        Me.cboMembershipType.FormattingEnabled = True
        Me.cboMembershipType.Items.AddRange(New Object() {"Basic", "Standard", "Premium"})
        Me.cboMembershipType.Location = New System.Drawing.Point(416, 129)
        Me.cboMembershipType.Name = "cboMembershipType"
        Me.cboMembershipType.Size = New System.Drawing.Size(164, 21)
        Me.cboMembershipType.TabIndex = 40
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(401, 364)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 43)
        Me.btnSave.TabIndex = 41
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnStats
        '
        Me.btnStats.Enabled = False
        Me.btnStats.Location = New System.Drawing.Point(494, 364)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(86, 43)
        Me.btnStats.TabIndex = 42
        Me.btnStats.Text = "Member Stats"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(592, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(401, 326)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 35)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchForMember})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(592, 24)
        Me.MenuStrip1.TabIndex = 45
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SearchForMember
        '
        Me.SearchForMember.Name = "SearchForMember"
        Me.SearchForMember.Size = New System.Drawing.Size(122, 20)
        Me.SearchForMember.Text = "Search For Member"
        '
        'frmMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(592, 413)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboMembershipType)
        Me.Controls.Add(Me.cboJoinDate)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.cboTrainer)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.MembersNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtVO2max)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtHRrest)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtHRmax)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAges)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtContectNumb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID_Number)
        Me.Name = "frmMembers"
        CType(Me.MembersNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MembersNavigator.ResumeLayout(False)
        Me.MembersNavigator.PerformLayout()
        CType(Me.FitnessClub_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID_Number As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtContectNumb As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtHRmax As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtVO2max As System.Windows.Forms.TextBox
    Friend WithEvents MembersNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboTrainer As System.Windows.Forms.ComboBox
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents cboJoinDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboMembershipType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents FitnessClub_BindingSource As System.Windows.Forms.BindingSource
    Public WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents btnStats As System.Windows.Forms.Button
    Friend WithEvents txtHRrest As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SearchForMember As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents txtAges As System.Windows.Forms.TextBox

End Class
