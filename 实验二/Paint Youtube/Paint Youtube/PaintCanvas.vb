Public Class PaintCanvas
    'public Enumerations
    Public Enum GraphicsSizes As Integer
        Small = 5
        Medium = 10
        Large = 50
    End Enum

    Public Enum GraphicsTools As Integer
        CirclePen = 0
    End Enum

    'public variables
    Public GraphicsItems As New ArrayList()
    Public GraphicsTool As GraphicsTools = GraphicsTools.CirclePen
    Public GraphicsSize As GraphicsSizes = GraphicsSizes.Large
    Public GraphicsColor As Color = Color.Black

    'private methods
    Private Sub DoMousePaint(ByVal e As MouseEventArgs)
        Dim objGraphicsItem As GraphicsItem

        Select Case GraphicsTool
            Case GraphicsTools.CirclePen
                Dim objGraphicsCircle As New GraphicsCircle()
                objGraphicsCircle.SetPoint(e.X, e.Y, GraphicsSize, GraphicsColor, True)
                objGraphicsItem = objGraphicsCircle
        End Select
        If objGraphicsItem IsNot Nothing Then
            GraphicsItems.Add(objGraphicsItem)
            Me.Invalidate(objGraphicsItem.Rectangle)
        End If
    End Sub

    Private Sub PaintCanvas_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            DoMousePaint(e)
        End If
    End Sub

    Private Sub PaintCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            DoMousePaint(e)
        End If
    End Sub

    Private Sub PaintCanvas_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        For Each objGraphicsItem As GraphicsItem In GraphicsItems
            objGraphicsItem.Draw(e.Graphics)
        Next
    End Sub

    Public Sub clearCanvas()
        GraphicsItems.Clear()
        Me.Invalidate()
    End Sub
End Class
