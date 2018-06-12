<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnAttack = New System.Windows.Forms.Button()
        Me.ProgressBarPopeye = New System.Windows.Forms.ProgressBar()
        Me.ProgressEnemy = New System.Windows.Forms.ProgressBar()
        Me.btnSpawn = New System.Windows.Forms.Button()
        Me.radioSpinach = New System.Windows.Forms.RadioButton()
        Me.labelSpinachLeft = New System.Windows.Forms.Label()
        Me.timerDelay = New System.Windows.Forms.Timer(Me.components)
        Me.lblPopHealth = New System.Windows.Forms.Label()
        Me.lblEnemyHealth = New System.Windows.Forms.Label()
        Me.btnHideAndShow = New System.Windows.Forms.Button()
        Me.pictureEnemy = New System.Windows.Forms.PictureBox()
        Me.picturePopeye = New System.Windows.Forms.PictureBox()
        CType(Me.pictureEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picturePopeye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAttack
        '
        Me.btnAttack.Location = New System.Drawing.Point(44, 35)
        Me.btnAttack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAttack.Name = "btnAttack"
        Me.btnAttack.Size = New System.Drawing.Size(144, 37)
        Me.btnAttack.TabIndex = 2
        Me.btnAttack.Text = "Attack"
        Me.btnAttack.UseVisualStyleBackColor = True
        '
        'ProgressBarPopeye
        '
        Me.ProgressBarPopeye.Location = New System.Drawing.Point(44, 366)
        Me.ProgressBarPopeye.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressBarPopeye.Maximum = 250
        Me.ProgressBarPopeye.Name = "ProgressBarPopeye"
        Me.ProgressBarPopeye.Size = New System.Drawing.Size(291, 29)
        Me.ProgressBarPopeye.TabIndex = 3
        '
        'ProgressEnemy
        '
        Me.ProgressEnemy.Location = New System.Drawing.Point(494, 366)
        Me.ProgressEnemy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressEnemy.Name = "ProgressEnemy"
        Me.ProgressEnemy.Size = New System.Drawing.Size(272, 29)
        Me.ProgressEnemy.TabIndex = 4
        '
        'btnSpawn
        '
        Me.btnSpawn.Location = New System.Drawing.Point(494, 35)
        Me.btnSpawn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSpawn.Name = "btnSpawn"
        Me.btnSpawn.Size = New System.Drawing.Size(272, 37)
        Me.btnSpawn.TabIndex = 5
        Me.btnSpawn.Text = "Spawn Enemy"
        Me.btnSpawn.UseVisualStyleBackColor = True
        '
        'radioSpinach
        '
        Me.radioSpinach.AutoSize = True
        Me.radioSpinach.Location = New System.Drawing.Point(216, 35)
        Me.radioSpinach.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioSpinach.Name = "radioSpinach"
        Me.radioSpinach.Size = New System.Drawing.Size(116, 19)
        Me.radioSpinach.TabIndex = 6
        Me.radioSpinach.TabStop = True
        Me.radioSpinach.Text = "Use Spinach"
        Me.radioSpinach.UseVisualStyleBackColor = True
        '
        'labelSpinachLeft
        '
        Me.labelSpinachLeft.AutoSize = True
        Me.labelSpinachLeft.Location = New System.Drawing.Point(216, 64)
        Me.labelSpinachLeft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelSpinachLeft.Name = "labelSpinachLeft"
        Me.labelSpinachLeft.Size = New System.Drawing.Size(119, 15)
        Me.labelSpinachLeft.TabIndex = 7
        Me.labelSpinachLeft.Text = "Spinach Left:3"
        '
        'timerDelay
        '
        Me.timerDelay.Interval = 1000
        '
        'lblPopHealth
        '
        Me.lblPopHealth.AutoSize = True
        Me.lblPopHealth.Location = New System.Drawing.Point(41, 411)
        Me.lblPopHealth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPopHealth.Name = "lblPopHealth"
        Me.lblPopHealth.Size = New System.Drawing.Size(87, 15)
        Me.lblPopHealth.TabIndex = 8
        Me.lblPopHealth.Text = "Health:100"
        '
        'lblEnemyHealth
        '
        Me.lblEnemyHealth.AutoSize = True
        Me.lblEnemyHealth.Location = New System.Drawing.Point(524, 411)
        Me.lblEnemyHealth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEnemyHealth.Name = "lblEnemyHealth"
        Me.lblEnemyHealth.Size = New System.Drawing.Size(87, 15)
        Me.lblEnemyHealth.TabIndex = 9
        Me.lblEnemyHealth.Text = "Health:100"
        '
        'btnHideAndShow
        '
        Me.btnHideAndShow.Location = New System.Drawing.Point(44, 430)
        Me.btnHideAndShow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnHideAndShow.Name = "btnHideAndShow"
        Me.btnHideAndShow.Size = New System.Drawing.Size(721, 29)
        Me.btnHideAndShow.TabIndex = 10
        Me.btnHideAndShow.Text = "Hide Log"
        Me.btnHideAndShow.UseVisualStyleBackColor = True
        '
        'pictureEnemy
        '
        Me.pictureEnemy.Location = New System.Drawing.Point(494, 80)
        Me.pictureEnemy.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureEnemy.Name = "pictureEnemy"
        Me.pictureEnemy.Size = New System.Drawing.Size(272, 278)
        Me.pictureEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureEnemy.TabIndex = 1
        Me.pictureEnemy.TabStop = False
        '
        'picturePopeye
        '
        Me.picturePopeye.Image = Global.Game_GUI.My.Resources.Resources.popeye
        Me.picturePopeye.Location = New System.Drawing.Point(73, 92)
        Me.picturePopeye.Margin = New System.Windows.Forms.Padding(4)
        Me.picturePopeye.Name = "picturePopeye"
        Me.picturePopeye.Size = New System.Drawing.Size(231, 266)
        Me.picturePopeye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picturePopeye.TabIndex = 0
        Me.picturePopeye.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 466)
        Me.Controls.Add(Me.btnHideAndShow)
        Me.Controls.Add(Me.lblEnemyHealth)
        Me.Controls.Add(Me.lblPopHealth)
        Me.Controls.Add(Me.labelSpinachLeft)
        Me.Controls.Add(Me.radioSpinach)
        Me.Controls.Add(Me.btnSpawn)
        Me.Controls.Add(Me.ProgressEnemy)
        Me.Controls.Add(Me.ProgressBarPopeye)
        Me.Controls.Add(Me.btnAttack)
        Me.Controls.Add(Me.pictureEnemy)
        Me.Controls.Add(Me.picturePopeye)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pictureEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picturePopeye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picturePopeye As System.Windows.Forms.PictureBox
    Friend WithEvents pictureEnemy As System.Windows.Forms.PictureBox
    Friend WithEvents btnAttack As System.Windows.Forms.Button
    Friend WithEvents ProgressBarPopeye As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressEnemy As System.Windows.Forms.ProgressBar
    Friend WithEvents btnSpawn As System.Windows.Forms.Button
    Friend WithEvents radioSpinach As System.Windows.Forms.RadioButton
    Friend WithEvents labelSpinachLeft As System.Windows.Forms.Label
    Friend WithEvents timerDelay As System.Windows.Forms.Timer
    Friend WithEvents lblPopHealth As System.Windows.Forms.Label
    Friend WithEvents lblEnemyHealth As System.Windows.Forms.Label
    Friend WithEvents btnHideAndShow As System.Windows.Forms.Button

End Class
