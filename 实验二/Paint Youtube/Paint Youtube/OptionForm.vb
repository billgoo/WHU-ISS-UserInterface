Public Class OptionForm
    Private myPaint As New Form1
    Private Sub ComboBoxSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSize.SelectedIndexChanged
        myPaint.setSize(ComboBoxSize.SelectedIndex)
    End Sub

    Private Sub OptionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxSize.SelectedIndex = 0
        myPaint.Show()
        lblColor.Text = myPaint.PaintCanvas1.GraphicsColor.ToString()
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        ColorDialogBrush.ShowDialog()
        Try
            myPaint.setColor(ColorDialogBrush.Color)
            lblColor.Text = myPaint.PaintCanvas1.GraphicsColor.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub butClear_Click(sender As Object, e As EventArgs) Handles butClear.Click
        myPaint.PaintCanvas1.clearCanvas()
    End Sub
End Class