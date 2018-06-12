Public Class Villainvb
    Inherits Enemy
    Sub New()
        strName = "Villain"
        Attacks(0) = "Shoot"
        Attacks(1) = "Stab"
        Attacks(2) = "Throw Grenade"
        AttackDamages(0) = 10
        AttackDamages(1) = 8
        AttackDamages(2) = 12
    End Sub '
    Public Overrides Sub Attack(ByRef userHealth As Integer)
        Dim gen As New Random
        attackNum = gen.Next(0, 3)
        Select Case attackNum
            Case 0
                userHealth -= 10
            Case 1
                userHealth -= 8
            Case 2
                userHealth -= 12
        End Select
    End Sub
End Class
