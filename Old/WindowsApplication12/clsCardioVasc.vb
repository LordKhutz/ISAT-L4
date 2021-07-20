Public Class clsCardioVasc
    Private decHRmax As Decimal
    Private decHRrest As Decimal
    Private intAge As Integer

    Public ReadOnly Property HRmax() As Decimal
        Get
            Return decHRmax
        End Get
    End Property
    Public Property HRrest() As Decimal
        Get
            Return decHRrest
        End Get
        Set(value As Decimal)
            decHRrest = value
        End Set
    End Property
    Public Property Age() As Integer
        Get
            Return intAge
        End Get
        Set(value As Integer)
            intAge = value
        End Set
    End Property
    Public Sub New()
        HRrest() = 0
        Age() = 1
    End Sub
    Public Sub New(ByVal _HRrest As Decimal, ByVal _age As Integer)
        HRrest() = _HRrest
        Age() = _age
    End Sub
    Public Function CalcVO2max() As Decimal
        CalcHRmax()
        'Calculate the VO2max
        Dim decVO2max As Decimal
        decVO2max = 15 * (HRmax() / HRrest())
        Return decVO2max
    End Function
    Private Function CalcHRmax() As Decimal
        'Calculate the HRmax
        decHRmax = 205.8 - (0.685 * Age())
        Return HRmax
    End Function
End Class
