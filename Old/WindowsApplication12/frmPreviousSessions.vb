Imports Fitness_Manager.clsConnectToDB
Public Class frmPreviousSessions
    Public strName As String
    Public strID As String
    Dim objDataBase As New clsConnectToDB
    Public Sub Fill()

        'load the weigh in sessions of the selected member
        lstHistory.Items.Clear()
        lstHistory.Items.Add("Member Name:")
        lstHistory.Items.Add(strName)
        For i As Integer = 0 To objDataBase.FitnessClub_DataSet.Tables("WeighSessions").Rows.Count - 1
            If objDataBase.FitnessClub_DataSet.Tables("WeighSessions").Rows(i).Item(6) = strID Then
                lstHistory.Items.Add("")
                lstHistory.Items.Add("----------------------------------------------------------------------------")
                lstHistory.Items.Add("Session Date: " + vbTab + CStr(objDataBase.FitnessClub_DataSet.Tables("WeighSessions").Rows(i).Item(1)))
                lstHistory.Items.Add("Weight (Kgs): " + vbTab + CStr(objDataBase.FitnessClub_DataSet.Tables("WeighSessions").Rows(i).Item(2)))
                lstHistory.Items.Add("BMI         : " + vbTab + CStr(objDataBase.FitnessClub_DataSet.Tables("WeighSessions").Rows(i).Item(3)))
                lstHistory.Items.Add("BMI Status: " + vbTab + CStr(objDataBase.FitnessClub_DataSet.Tables("WeighSessions").Rows(i).Item(4)))
                lstHistory.Items.Add("Ideal BMI: " + vbTab + CStr(objDataBase.FitnessClub_DataSet.Tables("WeighSessions").Rows(i).Item(5)))
            End If
        Next
    End Sub
End Class