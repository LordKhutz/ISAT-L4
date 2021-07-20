<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeigh_In
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWeigh_In))
        Me.lblMembername = New System.Windows.Forms.Label()
        Me.btnCalcBMI = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblBMI_Stat = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txt_IdealBMI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtActBMI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtVO2max = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHRmax = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtHRrest = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCalc_VO2max_HRmax = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMembername
        '
        Me.lblMembername.AutoSize = True
        Me.lblMembername.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembername.Location = New System.Drawing.Point(12, 81)
        Me.lblMembername.Name = "lblMembername"
        Me.lblMembername.Size = New System.Drawing.Size(192, 35)
        Me.lblMembername.TabIndex = 0
        Me.lblMembername.Text = "surname and name"
        '
        'btnCalcBMI
        '
        Me.btnCalcBMI.Enabled = False
        Me.btnCalcBMI.Location = New System.Drawing.Point(12, 399)
        Me.btnCalcBMI.Name = "btnCalcBMI"
        Me.btnCalcBMI.Size = New System.Drawing.Size(82, 43)
        Me.btnCalcBMI.TabIndex = 40
        Me.btnCalcBMI.Text = "Calculate BMI"
        Me.btnCalcBMI.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(139, 399)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 43)
        Me.btnSave.TabIndex = 41
        Me.btnSave.Text = "DONE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 119)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(336, 274)
        Me.TabControl1.TabIndex = 42
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblBMI_Stat)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.txt_IdealBMI)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtActBMI)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtWeight)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(328, 248)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "BMI related"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblBMI_Stat
        '
        Me.lblBMI_Stat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBMI_Stat.Location = New System.Drawing.Point(130, 161)
        Me.lblBMI_Stat.Name = "lblBMI_Stat"
        Me.lblBMI_Stat.Size = New System.Drawing.Size(139, 23)
        Me.lblBMI_Stat.TabIndex = 22
        Me.lblBMI_Stat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(130, 13)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 21
        '
        'txt_IdealBMI
        '
        Me.txt_IdealBMI.Location = New System.Drawing.Point(130, 198)
        Me.txt_IdealBMI.Name = "txt_IdealBMI"
        Me.txt_IdealBMI.ReadOnly = True
        Me.txt_IdealBMI.Size = New System.Drawing.Size(139, 20)
        Me.txt_IdealBMI.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Ideal BMI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "BMI Status"
        '
        'txtActBMI
        '
        Me.txtActBMI.Location = New System.Drawing.Point(130, 110)
        Me.txtActBMI.Name = "txtActBMI"
        Me.txtActBMI.ReadOnly = True
        Me.txtActBMI.Size = New System.Drawing.Size(139, 20)
        Me.txtActBMI.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "BMI"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(130, 65)
        Me.txtWeight.MaxLength = 5
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ReadOnly = True
        Me.txtWeight.Size = New System.Drawing.Size(139, 20)
        Me.txtWeight.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Weight (kgs)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Date"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtVO2max)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtHRmax)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtHRrest)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(328, 248)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CardioVasculer related"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtVO2max
        '
        Me.txtVO2max.Location = New System.Drawing.Point(135, 119)
        Me.txtVO2max.Name = "txtVO2max"
        Me.txtVO2max.ReadOnly = True
        Me.txtVO2max.Size = New System.Drawing.Size(139, 20)
        Me.txtVO2max.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "VO₂ max"
        '
        'txtHRmax
        '
        Me.txtHRmax.Location = New System.Drawing.Point(135, 75)
        Me.txtHRmax.Name = "txtHRmax"
        Me.txtHRmax.ReadOnly = True
        Me.txtHRmax.Size = New System.Drawing.Size(139, 20)
        Me.txtHRmax.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "HRmax"
        '
        'txtHRrest
        '
        Me.txtHRrest.Location = New System.Drawing.Point(135, 30)
        Me.txtHRrest.MaxLength = 5
        Me.txtHRrest.Name = "txtHRrest"
        Me.txtHRrest.Size = New System.Drawing.Size(139, 20)
        Me.txtHRrest.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "HRrest"
        '
        'btnCalc_VO2max_HRmax
        '
        Me.btnCalc_VO2max_HRmax.Enabled = False
        Me.btnCalc_VO2max_HRmax.Location = New System.Drawing.Point(248, 399)
        Me.btnCalc_VO2max_HRmax.Name = "btnCalc_VO2max_HRmax"
        Me.btnCalc_VO2max_HRmax.Size = New System.Drawing.Size(100, 43)
        Me.btnCalc_VO2max_HRmax.TabIndex = 43
        Me.btnCalc_VO2max_HRmax.Text = "Calculate HRmax and VO2max"
        Me.btnCalc_VO2max_HRmax.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'frmWeigh_In
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 447)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCalc_VO2max_HRmax)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCalcBMI)
        Me.Controls.Add(Me.lblMembername)
        Me.Name = "frmWeigh_In"
        Me.Text = "Weigh In"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMembername As System.Windows.Forms.Label
    Friend WithEvents btnCalcBMI As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblBMI_Stat As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_IdealBMI As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtActBMI As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtVO2max As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtHRmax As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtHRrest As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnCalc_VO2max_HRmax As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
