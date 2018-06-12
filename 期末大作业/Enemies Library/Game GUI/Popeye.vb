Public Class Popeye
    Public Const Name As String = "Popeye"
    Public attackNum As Integer
    Public Shared StartHealth As Integer = 250
    Private intHealth As Integer = StartHealth
    Public hasSpinach As Boolean = False
    Public ReadOnly Attacks() As String = {"Punch", "Kick", "Anchor"}
    Public ReadOnly AttackDamage() As Integer = {5, 10, 15}
    Public Sub Attack(ByRef enemyHealth As Integer)
        Dim gen As New Random
        attackNum = gen.Next(3)
        Select Case attackNum
            Case 0
                If hasSpinach Then
                    enemyHealth -= (AttackDamage(attackNum) * 2)
                Else
                    enemyHealth -= AttackDamage(attackNum)
                End If
            Case 1
                If hasSpinach Then
                    enemyHealth -= (AttackDamage(attackNum) * 2)
                Else
                    enemyHealth -= AttackDamage(attackNum)
                End If
            Case 2
                If hasSpinach Then
                    enemyHealth -= (AttackDamage(attackNum) * 2)
                Else
                    enemyHealth -= AttackDamage(attackNum)
                End If
        End Select
    End Sub
    Public Property Health() As Integer
        Set(ByVal value As Integer)
            intHealth = value
        End Set
        Get
            Return intHealth
        End Get
    End Property
End Class
