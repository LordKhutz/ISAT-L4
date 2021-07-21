' fcalculates the BMI
Public Class frmCalcBMI

    Dim objMale_BMI As clsMaleBmi
    Dim objFemle_BMI As clsFemaleBMI

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim strBMIstatus As String
        Dim decWeight, decHight As Decimal
        Dim intAge As Decimal
        Dim decActualBMI As Decimal
        Dim decBMI As Decimal


        If Decimal.TryParse(txtWeight.Text, decWeight) = False Then
            MsgBox("Please enter your Weight in KG's", MsgBoxStyle.Exclamation, "incorrect format")
            txtWeight.Focus()
            Exit Sub
        End If
        If Decimal.TryParse(txtHight.Text, decHight) = False Then
            MsgBox("Please enter your hight in cm's", MsgBoxStyle.Exclamation, "incorrect format")
            txtHight.Focus()
            Exit Sub
        End If
        
       
        If radMale.Checked = True Then
            objMale_BMI = New clsMaleBmi(decWeight, decHight)

            decActualBMI = objMale_BMI.ActualBmi.ToString("C2")
            strBMIstatus = objMale_BMI.BmiStatus
            decBMI = objMale_BMI.OptimalBmi


        Else

            If Decimal.TryParse(txtAge.Text, intAge) = False Then

                MsgBox("Please enter your age in years", MsgBoxStyle.Exclamation, "incorrect format")
                txtAge.Focus()
                Exit Sub

            End If
            objFemle_BMI = New clsFemaleBMI(decWeight, decHight, intAge)
            decActualBMI = objFemle_BMI.ActualBmi.ToString("C2")
            strBMIstatus = objFemle_BMI.BmiStatus
            decBMI = objFemle_BMI.OptimalBmi

        End If

        'Display tha answers
        frmWeigh_In.txtWeight.Text = txtWeight.Text
        frmWeigh_In.txtActBMI.Text = decActualBMI.ToString("N2")
        frmWeigh_In.txt_IdealBMI.Text = decBMI.ToString("N2")
        frmWeigh_In.lblBMI_Stat.Text = strBMIstatus
        Me.Close()

    End Sub

    Private Sub frmCalcBMI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Check for the gender of the member
        If frmMembers.cboGender.Text = "MALE" Then
            radMale.Checked = True
        Else
            radFemale.Checked = True
        End If
        txtHight.Text = CDec(frmMembers.txtHeight.Text)
        txtAge.Text = CDec(frmMembers.txtAges.Text)
    End Sub
End Class