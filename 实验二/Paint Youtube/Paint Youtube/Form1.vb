﻿Public Class Form1
    Public Sub setSize(ByVal size As Integer)
        If size = 0 Then
            PaintCanvas1.GraphicsSize = PaintCanvas.GraphicsSizes.Small
        ElseIf size = 1 Then
            PaintCanvas1.GraphicsSize = PaintCanvas.GraphicsSizes.Medium
        ElseIf size = 2 Then
            PaintCanvas1.GraphicsSize = PaintCanvas.GraphicsSizes.Large
        End If
    End Sub

    Public Sub setColor(ByVal color As Color)
        PaintCanvas1.GraphicsColor = color
    End Sub
End Class
