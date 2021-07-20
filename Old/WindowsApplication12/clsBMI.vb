Public Class clsBMI

    '~The Base BMI Class

    Private decWeight As Decimal
    Private decHeight As Decimal

    Public Property Weight() As Decimal
        Get
            Return decWeight
        End Get
        Set(value As Decimal)
            decWeight = value
        End Set
    End Property
    Public Property Height() As Decimal
        Get
            Return decHeight
        End Get
        Set(value As Decimal)
            decHeight = value
        End Set
    End Property
    Public Sub New()
        Weight() = 0
        Height = 0
    End Sub
    Public Sub New(ByVal _weight As Decimal, ByVal _height As Decimal)
        Weight = _weight
        Height = _height
    End Sub
    Public Overridable Function OptimalBmi() As Decimal
        Dim decOptimalBmi As Decimal
        decOptimalBmi = (0.5 * Weight()) / ((Height() / 100) ^ 2) + 11.5
        Return decOptimalBmi
    End Function
    Public Function ActualBmi() As Decimal
        Dim decBMI_Actual As Decimal
        decBMI_Actual = Weight / (Height / 100) ^ 2
        Return decBMI_Actual
    End Function
    Public Function BmiStatus() As String

        Dim strBmiStatus As String

        Select Case ActualBmi()
            Case Is > 31
                strBmiStatus = "OBESE"
            Case Is >= 26
                strBmiStatus = "OVERWEIGHT"

            Case Is >= 18.5
                strBmiStatus = "NORMAL"
            Case Is <= 18.4
                strBmiStatus = "UNDERWEIGHT"
        End Select

        Return strBmiStatus

    End Function
End Class
