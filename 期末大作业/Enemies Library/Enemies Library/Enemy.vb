Public Class Enemy
    Public Shared StartHealth As Integer = 100
    Public strName As String
    Private IntHealth As Integer
    Public attackNum As Integer
    Public ReadOnly Attacks(3) As String
    Public ReadOnly AttackDamages(3) As String
    Sub New()
        IntHealth = StartHealth
    End Sub

    Public Overridable Sub Attack(ByRef userHealth As Integer)
        Dim gen As New Random
        attackNum = gen.Next(0, 2)
        Select Case attackNum
            Case 0
                userHealth -= 1
            Case 1
                userHealth -= 2
        End Select

    End Sub
    Public Property Health() As Integer
        Get
            Return IntHealth
        End Get
        Set(ByVal value As Integer)
            IntHealth = value
        End Set
    End Property
End Class
