Public Class Circle
    Inherits Shape

    Private radius As Integer

    Public Overrides Sub computeArea()
        areas = Math.PI * Math.Pow(radius, 2)
    End Sub

    Public Overrides Sub computePer()
        perimeter = Math.PI * 2 * radius
    End Sub

    Public Overrides Sub getDimensions()
        radius = CInt(InputBox("Enter value for radius"))
    End Sub
End Class
