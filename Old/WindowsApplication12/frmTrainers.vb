
'import the class that handles connections to the database
Imports Fitness_Manager.clsConnectToDB

Public Class frmTrainers

    'declare my variables
    Dim inti As Integer
    Dim tblMembers As New DataTable
    Dim intMembercount As Integer = 0
    Dim objADD_EDIT_DELETE As clsConnectToDB
    Dim blnEdit, blnAdd As Boolean
    Dim strName As Decimal
    Dim strSurname As Decimal
    Dim rowMember As DataRow
    Dim NewRow As DataRow
    Dim intMemberID(500) As Decimal

    Public Sub GetMembers()

        'get the members that fall under the current trainer
        ReDim intMemberID(500)
        lstMembers.Items.Clear()
        intMembercount = 0
        Dim intLast As Integer = FitnessClub_DataSet.Tables("Members").Rows.Count - 1

        'search the database for the members
        For i As Integer = 0 To intLast
            If FitnessClub_DataSet.Tables("Members").Rows(i).Item(12) = txtTrainerID.Text Then
                intMembercount = intMembercount + 1
                intMemberID(i) = FitnessClub_DataSet.Tables("Members").Rows(i).Item(0)
                lstMembers.Items.Add(FitnessClub_DataSet.Tables("Members").Rows(i).Item(2) + ", " + FitnessClub_DataSet.Tables("Members").Rows(i).Item(1))
            End If
        Next

        'take apropriate action if trainer has no members
        If intMembercount = 0 Then
            lstMembers.Items.Add("This trainer Currently has No members to train")
        End If
    End Sub
    Private Sub PopulateFields()

        'populate the form with values of the current trainer
        txtTrainerID.Text = FitnessClub_DataSet.Tables("PersonalTrainers").Rows(inti).Item(0)
        txtTrainerName.Text = FitnessClub_DataSet.Tables("PersonalTrainers").Rows(inti).Item(1)
        txtTrainerSurname.Text = FitnessClub_DataSet.Tables("PersonalTrainers").Rows(inti).Item(2)
        txtTrainerCintect_NO.Text = FitnessClub_DataSet.Tables("PersonalTrainers").Rows(inti).Item(3)
        cboTrainerClass.SelectedItem = FitnessClub_DataSet.Tables("PersonalTrainers").Rows(inti).Item(4)
        txtTrainerSalary.Text = CDec(FitnessClub_DataSet.Tables("PersonalTrainers").Rows(inti).Item(5)).ToString("C2")
    End Sub
    Private Sub btnCalcSalary_Click(sender As Object, e As EventArgs) Handles btnCalcSalary.Click
        'calculate the salary of the currently selected trainer

        Dim objCalcSalary As clsTrainerSalary

        Dim decMembshipPrice As Decimal
        Dim decBasicSalary As Decimal

        'check to see what class the current trainer belongs to
        Select Case cboTrainerClass.SelectedItem
            Case "A"
                decBasicSalary = 10000
                decMembshipPrice = 500
            Case "B"
                decBasicSalary = 7500
                decMembshipPrice = 375

            Case "C"
                decBasicSalary = 5000
                decMembshipPrice = 250
            Case Else
                MsgBox("Please do not enter your own Value in the class combobox" + ControlChars.NewLine _
                       + "Please choose from the Values Provided instead", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, _
                       "INPUT ERROR")
                cboTrainerClass.SelectedIndex = 0
                cboTrainerClass.Focus()
                Exit Sub
        End Select

        'create the calculate salary object
        objCalcSalary = New clsTrainerSalary(decBasicSalary, decMembshipPrice, intMembercount)

        'get the calculated salary from the object
        txtTrainerSalary.Text = CDec(objCalcSalary.calcSalary).ToString("C2")

        'dispose the object
        objCalcSalary = Nothing
    End Sub

    Private Sub frmTrainers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'load the first record of the database when this form is loaded
        cboTrainerClass.SelectedIndex = 0
        FitnessClub_BindingSource.DataSource = FitnessClub_DataSet.Tables("PersonalTrainers")
        PopulateFields()
        GetMembers()
        blnAdd = False
        blnEdit = False

    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        'move to the very last record in your database


        inti = FitnessClub_DataSet.Tables("PersonalTrainers").Rows.Count - 1


        PopulateFields()

        GetMembers()
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click

        'move to the very first record in your database


        inti = 0
        PopulateFields()

        GetMembers()
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        'this will move to the next record in the database

        inti = inti + 1
        PopulateFields()

        GetMembers()
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click

        'this will move to the previous record in the database
        PopulateFields()
        inti = inti - 1
        PopulateFields()

        GetMembers()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'enable the user to Edit a record
        blnEdit = True
        btnCalcSalary.Enabled = True
        btnSave.Enabled = True
        btnAdd.Enabled = False
        btnFire.Enabled = False
        btnEdit.Enabled = False


        txtTrainerCintect_NO.Enabled = True
    End Sub
    Private Sub ClearFields()

        'clear input fields
        txtTrainerName.Text = Nothing
        txtTrainerSurname.Text = Nothing
        txtTrainerCintect_NO.Text = Nothing
        cboTrainerClass.SelectedIndex = 0
        txtTrainerSalary.Text = Nothing
        txtTrainerName.Focus()
    End Sub
    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click

        If MsgBox("Are you sure", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Fire Trainer") = MsgBoxResult.Yes Then

            'delete th current record
            FitnessClub_DataSet.Tables("PersonalTrainers").Rows(inti).Delete()
            objADD_EDIT_DELETE = New clsConnectToDB
            objADD_EDIT_DELETE.ADD_EDIT_DELETE()
            objADD_EDIT_DELETE = Nothing

            'this will check if there are any records left in the database
            If FitnessClub_DataSet.Tables("Members").Rows.Count > 0 Then
                If inti > 0 Then
                    inti = inti - 1
                End If
                frmMain.lblStatus.Text = "The Trainer has been successfully removed from the database"

                PopulateFields()
            Else
                ClearFields()
            End If
        Else
            txtTrainerName.Focus()

        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'add a new row to the database
        NewRow = FitnessClub_DataSet.Tables("PersonalTrainers").NewRow
        FitnessClub_DataSet.Tables("PersonalTrainers").Rows.Add(NewRow)
        FitnessClub_BindingSource.ResetBindings(True)
        TrainersNavigator.Refresh()
        ClearFields()
        blnAdd = True
        btnCalcSalary.Enabled = True
        btnSave.Enabled = True
        btnFire.Enabled = False
        btnEdit.Enabled = False
        btnAdd.Enabled = False

        'this will add a 1 to the last id in the database and save it as the new id
        txtTrainerID.Text = (FitnessClub_DataSet.Tables("PersonalTrainers").Rows(FitnessClub_DataSet.Tables("PersonalTrainers") _
                                                                               .Rows.Count - 2).Item(0)) + 1

        txtTrainerName.Enabled = True
        txtTrainerSurname.Enabled = True
        txtTrainerCintect_NO.Enabled = True
        cboTrainerClass.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim blnValidated As Boolean
        blnValidated = ValidateInput()

        If blnValidated = False Then
            Exit Sub
        End If
        'this will save the changes you have made
        If blnAdd = True Then

            'only execuded when a new record is made
            FitnessClub_DataSet.Tables("PersonalTrainers").Rows(FitnessClub_DataSet.Tables("PersonalTrainers") _
       .Rows.Count - 1).Delete()
            NewRow = FitnessClub_DataSet.Tables("PersonalTrainers").NewRow
            NewRow.Item(0) = txtTrainerID.Text
            NewRow.Item(1) = txtTrainerName.Text
            NewRow.Item(2) = txtTrainerSurname.Text
            NewRow.Item(3) = txtTrainerCintect_NO.Text
            NewRow.Item(4) = cboTrainerClass.SelectedItem
            NewRow.Item(5) = CDec(txtTrainerSalary.Text)

            FitnessClub_DataSet.Tables("PersonalTrainers").Rows.Add(NewRow)

        ElseIf blnEdit = True Then
            'only executed when you edit a record
            FitnessClub_DataSet.Tables("PersonalTrainers").Rows(inti).Item(0) = txtTrainerID.Text
            FitnessClub_DataSet.Tables("PersonalTrainers").Rows(inti).Item(1) = txtTrainerName.Text
            FitnessClub_DataSet.Tables("PersonalTrainers").Rows(inti).Item(2) = txtTrainerSurname.Text
            FitnessClub_DataSet.Tables("PersonalTrainers").Rows(inti).Item(3) = txtTrainerCintect_NO.Text
            FitnessClub_DataSet.Tables("PersonalTrainers").Rows(inti).Item(4) = cboTrainerClass.SelectedItem
            FitnessClub_DataSet.Tables("PersonalTrainers").Rows(inti).Item(5) = CDec(txtTrainerSalary.Text)
        End If
        frmMain.lblStatus.Text = "Data Saved Successfully"

        'calls the the saving object
        objADD_EDIT_DELETE = New clsConnectToDB
        objADD_EDIT_DELETE.ADD_EDIT_DELETE()

        'dispose the saving object
        objADD_EDIT_DELETE = Nothing

        blnEdit = False
        btnCalcSalary.Enabled = False
        btnSave.Enabled = False
        btnAdd.Enabled = True
        btnFire.Enabled = True
        btnEdit.Enabled = True

        txtTrainerID.Enabled = False
        txtTrainerName.Enabled = False
        txtTrainerSurname.Enabled = False
        txtTrainerCintect_NO.Enabled = False
        cboTrainerClass.Enabled = False
    End Sub

    Private Sub lstMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMembers.DoubleClick

        'this allows you to view all the weigh in sessions of the member you have selected
        For i As Integer = 0 To FitnessClub_DataSet.Tables("Members").Rows.Count - 1
            If FitnessClub_DataSet.Tables("Members").Rows(i).Item(0) = intMemberID(lstMembers.SelectedIndex) Then
                frmPreviousSessions.MdiParent = frmMain
                frmPreviousSessions.Show()
                frmPreviousSessions.strName = lstMembers.SelectedItem
                frmPreviousSessions.strID = intMemberID(i)
                frmPreviousSessions.Fill()
                frmMembers.FitnessClub_BindingSource.Position = i
                frmMembers.MembersNavigator.Refresh()

            End If
        Next
    End Sub

    Private Sub SearchForTrainerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchForTrainerToolStripMenuItem.Click

        'search for a specific Trainer
        Dim strIdSearch As String
        strIdSearch = InputBox("Please enter the id number of the Trainer", "Member Search", 0)

        Dim count As Integer
        'search for a specific club member
        'this will scan through all the records in the database to find the record requersted
        For j As Integer = 0 To FitnessClub_DataSet.Tables("PersonalTrainers").Rows.Count - 1
            If FitnessClub_DataSet.Tables("PersonalTrainers").Rows(j).Item(0) = strIdSearch Then

                frmMain.lblStatus.Text = "Search Complete"
                inti = j
                PopulateFields()
                GetMembers()
                Exit For
            End If
        Next

        'display a message if the trainer does not exist
        If count = 0 Then
            MsgBox("The Member You have searched for does not exist" + vbNewLine + _
                   "Please try again with a different ID number", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "No Record Found")
            frmMain.lblStatus.Text = "The Member You have searched for does not exist Please try again with a different ID number"
        End If

        FitnessClub_BindingSource.Position = inti
        TrainersNavigator.Refresh()
    End Sub
    Private Function ValidateInput() As Boolean
        Dim intNumb As Integer
        Dim blnValue As Boolean

        'Validates the contect number
        If Integer.TryParse(txtTrainerCintect_NO.Text, intNumb) = False Or txtTrainerCintect_NO.Text.Count < 10 Then
            MsgBox("You have entered an invalid Phone number", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Invalide Phone Number")
            frmMain.lblStatus.Text = "You have entered an invalid Phone number"
            txtTrainerCintect_NO.Text = Nothing
            txtTrainerCintect_NO.Focus()
            blnValue = False
        Else
            blnValue = True
        End If
        Return blnValue
    End Function
End Class