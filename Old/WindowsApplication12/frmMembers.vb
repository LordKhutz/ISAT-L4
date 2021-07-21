Imports Fitness_Manager.clsConnectToDB
Public Class frmMembers
    Dim blnEdit, blnAdd As Boolean
    Dim newRow As Data.DataRow
    Public Shared i As Integer
    Dim intTrainerID(500) As Decimal

    Public Sub PopulateInterFace()

        'this will populate the database with field values of the current record
        txtID_Number.Text = FitnessClub_DataSet.Tables("Members").Rows(i).Item(0)
        txtName.Text = FitnessClub_DataSet.Tables("Members").Rows(i).Item(1)
        txtSurname.Text = FitnessClub_DataSet.Tables("Members").Rows(i).Item(2)
        cboJoinDate.Value = FitnessClub_DataSet.Tables("Members").Rows(i).Item(3)
        txtContectNumb.Text = FitnessClub_DataSet.Tables("Members").Rows(i).Item(4)
        txtAges.Text = FitnessClub_DataSet.Tables("Members").Rows(i).Item(5)
        txtHeight.Text = FitnessClub_DataSet.Tables("Members").Rows(i).Item(6)
        cboGender.SelectedItem = FitnessClub_DataSet.Tables("Members").Rows(i).Item(7)
        cboMembershipType.SelectedItem = FitnessClub_DataSet.Tables("Members").Rows(i).Item(8)
        txtHRmax.Text = FitnessClub_DataSet.Tables("Members").Rows(i).Item(9)
        txtHRrest.Text = FitnessClub_DataSet.Tables("Members").Rows(i).Item(10)
        txtVO2max.Text = FitnessClub_DataSet.Tables("Members").Rows(i).Item(11)
    End Sub

    Private Sub frmMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateInterFace()
        FitnessClub_BindingSource.DataSource = FitnessClub_DataSet.Tables("Members")
    End Sub

    Private Sub UpdatefitnessClub_dataset()
        'this will put any changes made on the current record in the database
        FitnessClub_DataSet.Tables("Members").Rows(i).Item(0) = txtID_Number.Text
        FitnessClub_DataSet.Tables("Members").Rows(i).Item(1) = txtName.Text
        FitnessClub_DataSet.Tables("Members").Rows(i).Item(2) = txtSurname.Text
        FitnessClub_DataSet.Tables("Members").Rows(i).Item(3) = cboJoinDate.Value
        FitnessClub_DataSet.Tables("Members").Rows(i).Item(4) = txtContectNumb.Text
        FitnessClub_DataSet.Tables("Members").Rows(i).Item(5) = txtAges.Text
        FitnessClub_DataSet.Tables("Members").Rows(i).Item(6) = txtHeight.Text
        FitnessClub_DataSet.Tables("Members").Rows(i).Item(7) = cboGender.SelectedItem
        FitnessClub_DataSet.Tables("Members").Rows(i).Item(8) = cboMembershipType.SelectedItem
        FitnessClub_DataSet.Tables("Members").Rows(i).Item(9) = CDec(txtHRmax.Text)
        FitnessClub_DataSet.Tables("Members").Rows(i).Item(10) = CDec(txtHRrest.Text)
        FitnessClub_DataSet.Tables("Members").Rows(i).Item(11) = CDec(txtVO2max.Text)
        FitnessClub_DataSet.Tables("Members").Rows(i).Item(12) = CInt(intTrainerID(cboTrainer.SelectedIndex))
    End Sub
    Public Sub addNewRow()

        FitnessClub_DataSet.Tables("Members").Rows(FitnessClub_DataSet.Tables("Members").Rows.Count - 1).Delete()

        'this will create a new row into the database and populate with what ever has been inputed in the interface
        newRow = FitnessClub_DataSet.Tables("Members").NewRow

        newRow.Item(0) = txtID_Number.Text
        newRow.Item(1) = txtName.Text
        newRow.Item(2) = txtSurname.Text
        newRow.Item(3) = cboJoinDate.Value
        newRow.Item(4) = txtContectNumb.Text
        newRow.Item(5) = CInt(txtAges.Text)
        newRow.Item(6) = CInt(txtHeight.Text)
        newRow.Item(7) = cboGender.SelectedItem
        newRow.Item(8) = cboMembershipType.SelectedItem
        newRow.Item(9) = CDec(txtHRmax.Text)
        newRow.Item(10) = CDec(txtHRrest.Text)
        newRow.Item(11) = CDec(txtVO2max.Text)
        newRow.Item(12) = CInt(intTrainerID(cboTrainer.SelectedIndex))
        FitnessClub_DataSet.Tables("Members").Rows.Add(newRow)
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intValidate As Integer

        'validate inPutes
        If Integer.TryParse(txtContectNumb.Text, intValidate) = False Or txtContectNumb.Text.Count < 10 Then
            MsgBox("You have entered an invalide Phone Number", MsgBoxStyle.Critical, "INvalid Phone Number")
            frmMain.lblStatus.Text = "You have entered an invalide Phone number"
            txtContectNumb.Text = Nothing
            txtContectNumb.Focus()
            Exit Sub
            If Integer.TryParse(txtAges.Text, intValidate) = False Then
                MsgBox("You have entered an invalide AGE", MsgBoxStyle.Critical, "INvalid AGE")
                frmMain.lblStatus.Text = "You have entered an invalide Age"
                txtAges.Text = Nothing
                txtAges.Focus()
                Exit Sub
            End If
            If txtName.Text = "" Then
                MsgBox("You have not entered a name", MsgBoxStyle.Critical, "No name entered")
                frmMain.lblStatus.Text = "You have not entered a name"
                txtAges.Text = Nothing
                txtAges.Focus()
            End If
            If txtSurname.Text = "" Then
                MsgBox("You have not entered a surename", MsgBoxStyle.Critical, "No surename entered")
                frmMain.lblStatus.Text = "You have not entered a surename"
                txtAges.Text = Nothing
                txtAges.Focus()
            End If

        End If

        'this will save the changes made to a record into the mdb database

        Dim objConnectTodb As clsConnectToDB
        objConnectTodb = New clsConnectToDB
        If blnAdd = True Then
            'validate the id number
            If Integer.TryParse(txtID_Number.Text, intValidate) = False Or txtID_Number.Text.Count < 13 Then
                MsgBox("You have entered an invalide id number", MsgBoxStyle.Critical, "INvalid ID")
                frmMain.lblStatus.Text = "You have entered an invalide id number"
                txtID_Number.Text = Nothing
                txtID_Number.Focus()
                Exit Sub
            End If
            addNewRow()
        ElseIf blnEdit = True Then
            UpdatefitnessClub_dataset()
        End If

        objConnectTodb.ADD_EDIT_DELETE()
        objConnectTodb = Nothing

        btnAdd.Enabled = True
        btnDelete.Enabled = True
        btnEdit.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False

        blnAdd = False
        blnEdit = False

        'desable user changable input fields
        txtID_Number.Enabled = False
        txtName.Enabled = False
        txtSurname.Enabled = False
        txtContectNumb.Enabled = False
        txtAges.Enabled = False
        txtHeight.Enabled = False
        cboGender.Enabled = False
        cboMembershipType.Enabled = False
        cboTrainer.Enabled = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'enable the user to Edit a record
        blnEdit = True
        btnCancel.Enabled = True
        btnStats.Enabled = True
        btnSave.Enabled = True
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False


        txtContectNumb.Enabled = True
        txtAges.Enabled = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        cboMembershipType.SelectedIndex = 0
        newRow = FitnessClub_DataSet.Tables("Members").NewRow
        FitnessClub_DataSet.Tables("Members").Rows.Add(newRow)

        FitnessClub_BindingSource.ResetBindings(True)
        MembersNavigator.Refresh()
        'enable the user to add a record into the database
        blnAdd = True
        btnCancel.Enabled = True
        btnStats.Enabled = True
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False

        ClearInterFace()

        'enable user changable input fields
        txtID_Number.Enabled = True
        txtName.Enabled = True
        txtSurname.Enabled = True
        txtContectNumb.Enabled = True
        txtAges.Enabled = True
        txtHeight.Enabled = True
        cboGender.Enabled = True
        cboMembershipType.Enabled = True
        cboTrainer.Enabled = True
        cboMembershipType.SelectedIndex = 0
    End Sub

    Private Sub ClearInterFace()
        'clear the interface
        txtID_Number.Text = Nothing
        txtName.Text = Nothing
        txtSurname.Text = Nothing
        cboJoinDate.Value = Today
        txtContectNumb.Text = Nothing
        txtAges.Text = Nothing
        txtHeight.Text = Nothing
        cboGender.SelectedItem = Nothing
        cboMembershipType.SelectedItem = Nothing
        txtHRmax.Text = Nothing
        txtHRrest.Text = Nothing
        txtVO2max.Text = Nothing
        cboTrainer.Text = Nothing
    End Sub
    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        'this will move to the next record in the database
        i = i + 1
        PopulateInterFace()
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        'this will move to the previous record in the database
        PopulateInterFace()
        i = i - 1
        PopulateInterFace()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        'this will delete the record that you are currently viewing
        If MessageBox.Show("Are you sure", "Remove member", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            FitnessClub_DataSet.Tables("Members").Rows(i).Delete()
            Dim objConnectTodb As clsConnectToDB
            objConnectTodb = New clsConnectToDB
            objConnectTodb.ADD_EDIT_DELETE()
            objConnectTodb = Nothing
            If FitnessClub_DataSet.Tables("Members").Rows.Count > 0 Then
                If i > 0 Then
                    i = i - 1
                End If
                frmMain.lblStatus.Text = "The Member has been successfully removed from the database"

                PopulateInterFace()
            Else
                ClearInterFace()
                MsgBox("There are no records in your database", MessageBoxIcon.Information, "Empty database")
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click

        'move to the very last record in your database
        i = FitnessClub_DataSet.Tables("Members").Rows.Count - 1
        PopulateInterFace()
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click

        'move to the very first record in your database
        i = 0
        PopulateInterFace()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        frmWeigh_In.ShowDialog()
    End Sub

    Private Sub cboMembershipType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMembershipType.SelectedIndexChanged


        cboTrainer.Items.Clear()
        Dim strClass As String
        If cboMembershipType.Items.Count > 0 Then
            Select Case cboMembershipType.SelectedItem
                Case "Basic"
                    strClass = "C"
                Case "Standard"
                    strClass = "B"
                Case "Premium"
                    strClass = "A"
            End Select

            Dim intLast As Integer = FitnessClub_DataSet.Tables("PersonalTrainers").Rows.Count - 1
            For i As Integer = 0 To intLast
                If FitnessClub_DataSet.Tables("PersonalTrainers").Rows(i).Item(4) = strClass Then
                    intTrainerID(i) = FitnessClub_DataSet.Tables("PersonalTrainers").Rows(i).Item(0)
                    cboTrainer.Items.Add(FitnessClub_DataSet.Tables("PersonalTrainers").Rows(i).Item(2) + ", " + FitnessClub_DataSet.Tables("PersonalTrainers").Rows(i).Item(1))
                    cboTrainer.SelectedIndex = 0
                End If

            Next
        End If
       
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If blnAdd = True Then
            FitnessClub_DataSet.Tables("Members").Rows(FitnessClub_DataSet.Tables("Members").Rows.Count - 1).Delete()
        End If
        btnAdd.Enabled = True
        btnDelete.Enabled = True
        btnEdit.Enabled = True
        btnSave.Enabled = False

        blnAdd = False
        blnEdit = False

        'desable user changable input fields
        txtID_Number.Enabled = False
        txtName.Enabled = False
        txtSurname.Enabled = False
        txtContectNumb.Enabled = False
        txtAges.Enabled = False
        txtHeight.Enabled = False
        cboGender.Enabled = False
        cboMembershipType.Enabled = False
        cboTrainer.Enabled = False
        PopulateInterFace()
    End Sub

    Private Sub SearchForMember_Click(sender As Object, e As EventArgs) Handles SearchForMember.Click
        Dim strIdSearch As String
        strIdSearch = InputBox("Please enter the id number of the club member", "Member Search", 0)
        Dim count As Integer = 0
        'search for a specific club member
        'this will scan through all the records in the database to find the record requersted
        For j As Integer = 0 To FitnessClub_DataSet.Tables("Members").Rows.Count - 1
            If FitnessClub_DataSet.Tables("Members").Rows(j).Item(0) = strIdSearch Then
                frmMain.lblStatus.Text = "Search Complete"
                count = count + 1
                i = j
                PopulateInterFace()
                Exit For
            End If
        Next
        If count = 0 Then
            MsgBox("The Member You have searched for does not exist" + vbNewLine + _
                   "Please try again with a different ID number", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "No Record Found")
            frmMain.lblStatus.Text = "The Member You have searched for does not exist Please try again with a different ID number"
        End If
        FitnessClub_BindingSource.Position = i
        MembersNavigator.Refresh()
    End Sub
End Class
