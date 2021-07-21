Imports System.Windows.Forms

Public Class frmMain

    Private Sub MEMBERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEMBERSToolStripMenuItem.Click

        'make this form the container of the members form
        frmMembers.MdiParent = Me
        'show the form
        frmMembers.Show()

        'focus on the form if it has already been activated
        frmMembers.Focus()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'connect to the database
        'using the following object
        Dim objConnectTodb As clsConnectToDB
        objConnectTodb = New clsConnectToDB
        objConnectTodb.Connect()

        'dispose the object
        objConnectTodb = Nothing

    End Sub

    Private Sub PERSONALTRAINERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PERSONALTRAINERSToolStripMenuItem.Click
        'make this form the container of the Trainers form
        frmTrainers.MdiParent = Me
        frmTrainers.Show()
        'focus on the form if it has already been activated
        frmTrainers.Focus()
    End Sub

    Private Sub AboutProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutProgramToolStripMenuItem.Click
        'Show the about box
        frmAbout.ShowDialog()


    End Sub
End Class
