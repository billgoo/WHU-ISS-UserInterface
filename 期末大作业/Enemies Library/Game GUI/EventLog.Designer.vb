<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventLog
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
        Me.listEvents = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'listEvents
        '
        Me.listEvents.BackColor = System.Drawing.Color.Black
        Me.listEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listEvents.ForeColor = System.Drawing.Color.Lime
        Me.listEvents.FormattingEnabled = True
        Me.listEvents.ItemHeight = 12
        Me.listEvents.Location = New System.Drawing.Point(0, 0)
        Me.listEvents.Name = "listEvents"
        Me.listEvents.Size = New System.Drawing.Size(603, 300)
        Me.listEvents.TabIndex = 0
        '
        'EventLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(603, 300)
        Me.Controls.Add(Me.listEvents)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EventLog"
        Me.Text = "EventLog"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listEvents As System.Windows.Forms.ListBox
End Class
