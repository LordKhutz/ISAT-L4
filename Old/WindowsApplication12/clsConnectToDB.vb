Public Class clsConnectToDB


    Dim db_Connection As New OleDb.OleDbConnection
    Public Shared FitnessClub_DataSet As New Data.DataSet
    Dim strSQL_CommandText As String
    Dim strTableName As String
    Dim strConnectionString As String


    Public Sub Connect()
        'this will try to connect to the database and fill the datasat
        Try
            strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\KHUTHADZO\Desktop\ISATLvl4\Fitness Club.mdb"
            db_Connection.ConnectionString = strConnectionString
            'create new tables
            FitnessClub_DataSet.Tables.Add("Members")
            FitnessClub_DataSet.Tables.Add("PersonalTrainers")
            FitnessClub_DataSet.Tables.Add("ClassSalary")
            FitnessClub_DataSet.Tables.Add("MembershipFee")
            FitnessClub_DataSet.Tables.Add("WeighSessions")
            FitnessClub_DataSet.Tables.Add("temp")
            'open connection to database
            db_Connection.Open()

            'fill the dataSat with table values from table
            For i As Integer = 0 To 5
                Select Case i
                    Case 0
                        strSQL_CommandText = "SELECT * FROM Members"
                        strTableName = "Members"
                    Case 1
                        strSQL_CommandText = "SELECT * FROM PersonalTrainers"
                        strTableName = "PersonalTrainers"
                    Case 2
                        strSQL_CommandText = "SELECT * FROM ClassSalary"
                        strTableName = "ClassSalary"
                    Case 3
                        strSQL_CommandText = "SELECT * FROM MembershipFee"
                        strTableName = "MembershipFee"
                    Case 4
                        strSQL_CommandText = "SELECT * FROM WeighSessions"
                        strTableName = "WeighSessions"

                        'temporary table to hold the members under a single trainer
                    Case 5
                        strSQL_CommandText = "SELECT * FROM temp"
                        strTableName = "temp"
                End Select
                Dim db_Adapter As New OleDb.OleDbDataAdapter(strSQL_CommandText, db_Connection)
                Dim Command_Builder As New OleDb.OleDbCommandBuilder(db_Adapter)
                db_Adapter.Fill(FitnessClub_DataSet.Tables(strTableName))
            Next
            db_Connection.Close()

            'catch any exceptions that might occur in the above code segment
        Catch ex As Exception
            'show exception error message
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub ADD_EDIT_DELETE()
        Try

            strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\KHUTHADZO\Desktop\ISATLvl4\Fitness Club.mdb"
            db_Connection.ConnectionString = strConnectionString
            'open connection to database
            db_Connection.Open()

            'fill the dataSat with table values from table
            For i As Integer = 0 To 2
                Select Case i
                    Case 0
                        strSQL_CommandText = "SELECT * FROM Members"
                        strTableName = "Members"
                    Case 1
                        strSQL_CommandText = "SELECT * FROM PersonalTrainers"
                        strTableName = "PersonalTrainers"
                    Case 2
                        strSQL_CommandText = "SELECT * FROM WeighSessions"
                        strTableName = "WeighSessions"

                End Select
                Dim db_Adapter As New OleDb.OleDbDataAdapter(strSQL_CommandText, db_Connection)
                Dim Command_Builder As New OleDb.OleDbCommandBuilder(db_Adapter)
                db_Adapter.Update(FitnessClub_DataSet.Tables(strTableName))
            Next
            db_Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
