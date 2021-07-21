
Public Class frmWeigh_In
    Dim objDataBase As New clsConnectToDB
    Private Sub btnCalcBMI_Click(sender As Object, e As EventArgs) Handles btnCalcBMI.Click
        'call the BMI Calculator
        frmCalcBMI.ShowDialog()

    End Sub

    Private Sub frmWeigh_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMembername.Text = frmMembers.txtSurname.Text + ", " + frmMembers.txtName.Text
        btnCalcBMI.Enabled = True
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            btnCalcBMI.Enabled = True
            btnCalc_VO2max_HRmax.Enabled = False
        End If
        If TabControl1.SelectedIndex = 1 Then
            btnCalcBMI.Enabled = False
            btnCalc_VO2max_HRmax.Enabled = True
        End If
    End Sub

    Private Sub btnCalc_VO2max_HRmax_Click(sender As Object, e As EventArgs) Handles btnCalc_VO2max_HRmax.Click

        Dim decHRrest, decVO2max As Decimal
        Dim objCardio As clsCardioVasc

        decHRrest = CDec(txtHRrest.Text)

        objCardio = New clsCardioVasc(decHRrest, CInt(frmMembers.txtAges.Text))
        If Decimal.TryParse(txtHRrest.Text, decHRrest) = True Then

            'calculate the VO2max
            decVO2max = objCardio.CalcVO2max()

        Else
            MsgBox("you have not entered a value for HRrest", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical)
            txtHRrest.Focus()
            Exit Sub
        End If

        'display the output values
        txtHRmax.Text = objCardio.HRmax.ToString("N2")
        txtVO2max.Text = decVO2max.ToString("N2")

        'update the values in the members form
        frmMembers.txtHRmax.Text = objCardio.HRmax.ToString("N2")
        frmMembers.txtVO2max.Text = decVO2max.ToString("N2")

    End Sub

    Private Sub lblBMI_Stat_Click(sender As Object, e As EventArgs) Handles lblBMI_Stat.TextChanged

        'change the color of the label according to the bmi status
        Select Case lblBMI_Stat.Text
            Case "UNDERWEIGHT"
                lblBMI_Stat.ForeColor = Color.Orange
            Case "NORMAL"
                lblBMI_Stat.ForeColor = Color.Aqua
            Case "OVERWEIGHT"
                lblBMI_Stat.ForeColor = Color.OrangeRed
            Case "OBESE"
                lblBMI_Stat.ForeColor = Color.DarkRed
        End Select
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'save the session
        Dim NewRow As Data.DataRow

        NewRow = objDataBase.FitnessClub_DataSet.Tables("WeighSessions").NewRow()
        NewRow.Item(1) = DateTimePicker1.Value
        NewRow.Item(2) = CDec(txtWeight.Text)
        NewRow.Item(3) = CDec(txtActBMI.Text)
        NewRow.Item(4) = lblBMI_Stat.Text
        NewRow.Item(5) = CDec(txt_IdealBMI.Text)
        NewRow.Item(6) = frmMembers.txtID_Number.Text

        objDataBase.FitnessClub_DataSet.Tables("WeighSessions").Rows.Add(NewRow)

        frmMembers.txtHRmax.Text = txtHRmax.Text
        frmMembers.txtHRrest.Text = txtHRrest.Text
        frmMembers.txtVO2max.Text = txtVO2max.Text

        frmMembers.Focus()
        frmMembers.btnSave.Enabled = True
        Me.Close()
    End Sub
End Class