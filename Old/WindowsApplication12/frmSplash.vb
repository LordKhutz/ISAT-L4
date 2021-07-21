Public NotInheritable Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display the application version
        Label1.Text = My.Application.SplashScreen.ProductVersion
    End Sub
End Class
