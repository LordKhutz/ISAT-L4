Public Class clsTrainerSalary
    Private decBasicSalary As Decimal
    Private decMemberShipPrice As Decimal
    Private intMembers As Integer

    Public Property BasicSalary As Decimal
        Get
            Return decBasicSalary
        End Get
        Set(value As Decimal)
            decBasicSalary = value
        End Set
    End Property
    Public Property MembershipPrice As Decimal
        Get
            Return decMemberShipPrice
        End Get
        Set(value As Decimal)
            decMemberShipPrice = value
        End Set
    End Property
    Public Property Members_No As Integer
        Get
            Return intMembers
        End Get
        Set(value As Integer)
            intMembers = value
        End Set
    End Property
    Public Sub New()
        BasicSalary = 0
        MembershipPrice = 0
        Members_No = 0
    End Sub
    Public Sub New(ByVal _BS As Decimal, ByVal _MP As Decimal, ByVal _MNo As Integer)
        BasicSalary = _BS
        MembershipPrice = _MP
        Members_No = _MNo
    End Sub
    Public Function calcSalary() As Decimal
        Dim decSalary As Decimal
        Dim decCommision As Decimal

        'calculate the commision
        decCommision = 0.05 * (MembershipPrice * Members_No)

        'calculate the total salary of trainer
        decSalary = BasicSalary + decCommision

        'return the total salary
        Return decSalary
    End Function
End Class
