Public Class Dragon
    Inherits Enemy
   
    Sub New()
        strName = "Dragon"
        Attacks(0) = "Blow Fire"
        Attacks(1) = "Claw"
        Attacks(2) = "Tail Smash"
        AttackDamages(0) = 15
        AttackDamages(1) = 8
        AttackDamages(2) = 10
    End Sub '
    Public Overrides Sub Attack(ByRef userHealth As Integer)
        Dim gen As New Random
        attackNum = gen.Next(0, 3)
        Select Case attackNum
            Case 0
                userHealth -= 15
            Case 1
                userHealth -= 8
            Case 2
                userHealth -= 10
        End Select
    End Sub
End Class
