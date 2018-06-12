<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionForm
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBoxSize = New System.Windows.Forms.ComboBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.ColorDialogBrush = New System.Windows.Forms.ColorDialog()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.butClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxSize
        '
        Me.ComboBoxSize.FormattingEnabled = True
        Me.ComboBoxSize.Items.AddRange(New Object() {"Small", "Medium", "Large"})
        Me.ComboBoxSize.Location = New System.Drawing.Point(41, 47)
        Me.ComboBoxSize.Name = "ComboBoxSize"
        Me.ComboBoxSize.Size = New System.Drawing.Size(186, 23)
        Me.ComboBoxSize.TabIndex = 0
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(38, 18)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(87, 15)
        Me.lblSize.TabIndex = 1
        Me.lblSize.Text = "Brush Size"
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(41, 87)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(186, 23)
        Me.btnColor.TabIndex = 2
        Me.btnColor.Text = "Change Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(38, 127)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(55, 15)
        Me.lblColor.TabIndex = 3
        Me.lblColor.Text = "Label1"
        '
        'butClear
        '
        Me.butClear.Location = New System.Drawing.Point(41, 160)
        Me.butClear.Name = "butClear"
        Me.butClear.Size = New System.Drawing.Size(186, 23)
        Me.butClear.TabIndex = 4
        Me.butClear.Text = "New Canvas"
        Me.butClear.UseVisualStyleBackColor = True
        '
        'OptionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 235)
        Me.Controls.Add(Me.butClear)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.ComboBoxSize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OptionForm"
        Me.Text = "OptionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxSize As ComboBox
    Friend WithEvents lblSize As Label
    Friend WithEvents btnColor As Button
    Friend WithEvents ColorDialogBrush As ColorDialog
    Friend WithEvents lblColor As Label
    Friend WithEvents butClear As Button
End Class
