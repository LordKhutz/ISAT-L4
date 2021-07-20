Public Class clsFemaleBMI
    Inherits clsBMI
    Private intAge As Integer
    Public Property Age As Integer
        Get
            Return intAge
        End Get
        Set(value As Integer)
            intAge = value
        End Set
    End Property
    Public Sub New()
        MyBase.New()
        intAge = 1
    End Sub
    Public Sub New(ByVal Weight As Decimal, ByVal height As Decimal, ByVal _Age As Integer)
        MyBase.New(Weight, height)
        Age = _Age
    End Sub
    Public Overrides Function OptimalBmi() As Decimal
        Dim decOptimalBmi As Decimal
        decOptimalBmi = 0.5 * Weight() / (Height() / 100) ^ 2 + 0.03 * Age() + 11
        Return decOptimalBmi
    End Function
End Class
