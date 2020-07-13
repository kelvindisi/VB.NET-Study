Public Class Rectangle
    Inherits Shape

    Private height, width As Double

    Public Overrides Sub computeArea()
        areas = height * width
    End Sub

    Public Overrides Sub computePer()
        perimeter = (height * width) * 2
    End Sub

    Public Overrides Sub getDimensions()
        Throw New NotImplementedException()
    End Sub
End Class
