Imports Enemies_Library
Public Class Form1
    Private currentEnemy As Enemies_Library.Enemy
    Private Hero As New Popeye
    Private intSpinach As Integer = 3
    Dim newLog As New EventLog
    Private logShown As Boolean = True

    Public Sub GenerateEnemy()
        Dim generator As New Random
        Dim enemyType As Integer = generator.Next(1, 4)
        Select Case enemyType
            Case 1
                currentEnemy = New Enemies_Library.Zombie
                ProgressEnemy.Value = Enemy.StartHealth
                pictureEnemy.Image = My.Resources.zombie
            Case 2
                currentEnemy = New Enemies_Library.Dragon
                ProgressEnemy.Value = Enemy.StartHealth
                pictureEnemy.Image = My.Resources.dragon
            Case 3
                currentEnemy = New Enemies_Library.Villainvb
                ProgressEnemy.Value = Enemy.StartHealth
                pictureEnemy.Image = My.Resources.villain
        End Select
        UpdateEnemyHealth()
    End Sub
    Private Sub btnSpawn_Click(sender As Object, e As EventArgs) Handles btnSpawn.Click
        Dim generator As New Random
        Dim enemyType As Integer = generator.Next(1, 4)
        Select Case enemyType
            Case 1
                currentEnemy = New Enemies_Library.Zombie
                ProgressEnemy.Value = currentEnemy.Health
                pictureEnemy.Image = My.Resources.zombie
            Case 2
                currentEnemy = New Enemies_Library.Dragon
                ProgressEnemy.Value = currentEnemy.Health
                pictureEnemy.Image = My.Resources.dragon
            Case 3
                currentEnemy = New Enemies_Library.Villainvb
                ProgressEnemy.Value = currentEnemy.Health
                pictureEnemy.Image = My.Resources.villain
        End Select
    End Sub

    Private Sub btnAttack_Click(sender As Object, e As EventArgs) Handles btnAttack.Click
        If intSpinach = 0 Then
            radioSpinach.Enabled = False
            radioSpinach.Checked = False
        End If
        If radioSpinach.Checked = True And intSpinach > 0 Then
            Hero.hasSpinach = True
            intSpinach -= 1
            labelSpinachLeft.Text = "Spinach Left:" & intSpinach.ToString
        ElseIf intSpinach = 0 Then
            radioSpinach.Enabled = False
        End If
        Hero.Attack(currentEnemy.Health)
        newLog.AddEvent(CreateEvent(Popeye.Name))
        Hero.hasSpinach = False
        Try
            UpdateEnemyHealth()
            timerDelay.Start()
        Catch
            ProgressEnemy.Value = 0
            MessageBox.Show("Popeye has won!")
            newLog.AddEvent("----------------")
            newLog.AddEvent("Popeye has won!")
            newLog.AddEvent("----------------")
            GenerateEnemy()
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        newLog.Show()
        newLog.Location = New Point(Me.Location.X, Me.Location.Y + 412)
        UpdatePopHealth()
        GenerateEnemy()
    End Sub

    Private Sub timerDelay_Tick(sender As Object, e As EventArgs) Handles timerDelay.Tick
        EnemyAttack()
    End Sub
    Private Sub EnemyAttack()
        currentEnemy.Attack(Hero.Health)
        newLog.AddEvent(CreateEvent(currentEnemy.strName))
        timerDelay.Stop()
        Try
            UpdatePopHealth()
        Catch
            ProgressBarPopeye.Value = 0
            MessageBox.Show("Popeye has lost!")
            newLog.AddEvent("----------------")
            newLog.AddEvent("Popeye has lost!")
            newLog.AddEvent("----------------")
            Hero.Health = Popeye.StartHealth
            UpdatePopHealth()
        End Try



    End Sub
    Private Sub UpdateEnemyHealth()
        ProgressEnemy.Value = currentEnemy.Health
        lblEnemyHealth.Text = "Health:" & currentEnemy.Health
    End Sub
    Private Sub UpdatePopHealth()
        If Hero.Health = 0 Then
            Throw New Exception
        End If
        ProgressBarPopeye.Value = Hero.Health
        lblPopHealth.Text = "Health:" & Hero.Health
    End Sub
    Private Function CreateEvent(ByVal strName As String) As String
        If strName = Popeye.Name Then
            Dim damage As Integer = Hero.AttackDamage(Hero.attackNum)
            If Hero.hasSpinach Then
                damage = Hero.AttackDamage(Hero.attackNum) * 2
            End If
            Return strName + " has used " + "[" + Hero.Attacks(Hero.attackNum) + "] for [" + damage.ToString + "] damage"
        Else
            Return strName + " has used " + "[" + currentEnemy.Attacks(currentEnemy.attackNum) + "] for [" + currentEnemy.AttackDamages(currentEnemy.attackNum).ToString + "] damage"
        End If

    End Function

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        newLog.Location = New Point(Me.Location.X, Me.Location.Y + 412)
    End Sub

    Private Sub btnHideAndShow_Click(sender As Object, e As EventArgs) Handles btnHideAndShow.Click
        If logShown Then
            newLog.Hide()
            btnHideAndShow.Text = "Show Log"
            logShown = Not logShown
        Else
            newLog.Show()
            btnHideAndShow.Text = "Hide Log"
            logShown = Not logShown
        End If
    End Sub
End Class
