Public Class Form1
    Dim result As Double '储存结果
    Dim argu1 As Double = 0
    Dim argu2 As Double = 0 '运算数
    Dim op As String = "=" '运算符
    '0-9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim b As Button
        b = sender
        If TextBox1.Text = "0" Then
            TextBox1.Text = b.Text
        Else
            TextBox1.Text += b.Text
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim b As Button
        b = sender
        If TextBox1.Text = "0" Then
            TextBox1.Text = b.Text
        Else
            TextBox1.Text += b.Text
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim b As Button
        b = sender
        If TextBox1.Text = "0" Then
            TextBox1.Text = b.Text
        Else
            TextBox1.Text += b.Text
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim b As Button
        b = sender
        If TextBox1.Text = "0" Then
            TextBox1.Text = b.Text
        Else
            TextBox1.Text += b.Text
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim b As Button
        b = sender
        If TextBox1.Text = "0" Then
            TextBox1.Text = b.Text
        Else
            TextBox1.Text += b.Text
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim b As Button
        b = sender
        If TextBox1.Text = "0" Then
            TextBox1.Text = b.Text
        Else
            TextBox1.Text += b.Text
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim b As Button
        b = sender
        If TextBox1.Text = "0" Then
            TextBox1.Text = b.Text
        Else
            TextBox1.Text += b.Text
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim b As Button
        b = sender
        If TextBox1.Text = "0" Then
            TextBox1.Text = b.Text
        Else
            TextBox1.Text += b.Text
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim b As Button
        b = sender
        If TextBox1.Text = "0" Then
            TextBox1.Text = b.Text
        Else
            TextBox1.Text += b.Text
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim b As Button
        b = sender
        If TextBox1.Text = "0" Then
            TextBox1.Text = b.Text
        Else
            TextBox1.Text += b.Text
        End If
    End Sub
    '.
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim b As Button
        b = sender
        '处理异常
        Dim st As String = Str(TextBox1.Text)
        Dim dot As Integer = st.IndexOf(".")
        If dot = -1 Then
            TextBox1.Text += b.Text
        Else
            MsgBox("There is an existent . at " & st.IndexOf("."))
        End If
    End Sub
    'CE
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = "0"
        result = 0
        argu1 = 0
        argu2 = 0
        op = "="
    End Sub
    '+ - * / are the same
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim b As Button
        b = sender
        Select Case op'运行一步算一步
            Case "+"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 + argu2
                TextBox1.Text = Str(argu1)
            Case "-"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 - argu2
                TextBox1.Text = Str(argu1)
            Case "*"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 * argu2
                TextBox1.Text = Str(argu1)
            Case "/"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 / argu2
                TextBox1.Text = Str(argu1)
            Case "=" : argu1 = Val(TextBox1.Text)
        End Select
        op = "+"
        TextBox1.Text = "0"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim b As Button
        b = sender
        Select Case op'运行一步算一步
            Case "+"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 + argu2
                TextBox1.Text = Str(argu1)
            Case "-"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 - argu2
                TextBox1.Text = Str(argu1)
            Case "*"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 * argu2
                TextBox1.Text = Str(argu1)
            Case "/"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 / argu2
                TextBox1.Text = Str(argu1)
            Case "=" : argu1 = Val(TextBox1.Text)
        End Select
        op = "-"
        TextBox1.Text = "0"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim b As Button
        b = sender
        Select Case op'运行一步算一步
            Case "+"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 + argu2
                TextBox1.Text = Str(argu1)
            Case "-"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 - argu2
                TextBox1.Text = Str(argu1)
            Case "*"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 * argu2
                TextBox1.Text = Str(argu1)
            Case "/"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 / argu2
                TextBox1.Text = Str(argu1)
            Case "=" : argu1 = Val(TextBox1.Text)
        End Select
        op = "*"
        TextBox1.Text = "0"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim b As Button
        b = sender
        Select Case op'运行一步算一步
            Case "+"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 + argu2
                TextBox1.Text = Str(argu1)
            Case "-"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 - argu2
                TextBox1.Text = Str(argu1)
            Case "*"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 * argu2
                TextBox1.Text = Str(argu1)
            Case "/"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 / argu2
                TextBox1.Text = Str(argu1)
            Case "=" : argu1 = Val(TextBox1.Text)
        End Select
        op = "/"
        TextBox1.Text = "0"
    End Sub
    '=
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim b As Button
        b = sender
        Select Case op'运行一步算一步
            Case "+"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 + argu2
            Case "-"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 - argu2
            Case "*"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 * argu2
            Case "/"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 / argu2
            Case "="
                argu1 = Val(TextBox1.Text)
        End Select
        result = argu1
        TextBox1.Text = Str(result)
        op = "="
    End Sub
    'sin  cos tan 的实现
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim b As Button
        b = sender
        Select Case op'运行一步算一步
            Case "+"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 + argu2
            Case "-"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 - argu2
            Case "*"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 * argu2
            Case "/"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 / argu2
            Case "=" : argu1 = Val(TextBox1.Text)
        End Select
        argu1 = Math.Sin(argu1)
        TextBox1.Text = Str(argu1)
        op = "="
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim b As Button
        b = sender
        Select Case op'运行一步算一步
            Case "+"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 + argu2
            Case "-"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 - argu2
            Case "*"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 * argu2
            Case "/"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 / argu2
            Case "=" : argu1 = Val(TextBox1.Text)
        End Select
        argu1 = Math.Cos(argu1)
        TextBox1.Text = Str(argu1)
        op = "="
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim b As Button
        b = sender
        Select Case op'运行一步算一步
            Case "+"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 + argu2
            Case "-"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 - argu2
            Case "*"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 * argu2
            Case "/"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 / argu2
            Case "=" : argu1 = Val(TextBox1.Text)
        End Select
        argu1 = Math.Tan(argu1)
        TextBox1.Text = Str(argu1)
        op = "="
    End Sub
    '绝对值
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim b As Button
        b = sender
        Select Case op'运行一步算一步
            Case "+"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 + argu2
            Case "-"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 - argu2
            Case "*"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 * argu2
            Case "/"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 / argu2
            Case "=" : argu1 = Val(TextBox1.Text)
        End Select
        argu1 = Math.Abs(argu1)
        TextBox1.Text = Str(argu1)
        op = "="
    End Sub
    '求平方
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim b As Button
        b = sender
        Select Case op'运行一步算一步
            Case "+"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 + argu2
            Case "-"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 - argu2
            Case "*"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 * argu2
            Case "/"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 / argu2
            Case "=" : argu1 = Val(TextBox1.Text)
        End Select
        argu1 = argu1 ^ 2
        TextBox1.Text = Str(argu1)
        op = "="
    End Sub
    '开方求根号
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim b As Button
        b = sender
        Select Case op'运行一步算一步
            Case "+"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 + argu2
            Case "-"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 - argu2
            Case "*"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 * argu2
            Case "/"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 / argu2
            Case "=" : argu1 = Val(TextBox1.Text)
        End Select
        If argu1 < 0 Then
            MsgBox("Error! The number is negative!")
        End If
        argu1 = Math.Sqrt(argu1)
        TextBox1.Text = Str(argu1)
        op = "="
    End Sub
    '指数倍，e^x 次方
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim b As Button
        b = sender
        Select Case op'运行一步算一步
            Case "+"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 + argu2
            Case "-"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 - argu2
            Case "*"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 * argu2
            Case "/"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 / argu2
            Case "=" : argu1 = Val(TextBox1.Text)
        End Select
        argu1 = Math.Exp(argu1)
        TextBox1.Text = Str(argu1)
        op = "="
    End Sub
    '阶乘
    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim b As Button
        Dim i, x, n As Double
        b = sender
        Select Case op'运行一步算一步
            Case "+"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 + argu2
            Case "-"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 - argu2
            Case "*"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 * argu2
            Case "/"
                argu2 = Val(TextBox1.Text)
                argu1 = argu1 / argu2
            Case "=" : argu1 = Val(TextBox1.Text)
        End Select
        n = argu1
        x = 1
        For i = 1 To n
            x = x * i
        Next
        argu1 = x
        TextBox1.Text = Str(argu1)
        op = "="
    End Sub
    '圆周率PI
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TextBox1.Text = Str(Math.PI)
    End Sub
    '自然对数e
    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        TextBox1.Text = Str(Math.E)
    End Sub

End Class
