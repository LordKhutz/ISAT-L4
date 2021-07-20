Public Class clsMaleBmi
    Inherits clsBMI
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal Weight As Decimal, ByVal height As Decimal)
        MyBase.New(Weight, height)
    End Sub
End Class
