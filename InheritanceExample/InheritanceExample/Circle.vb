Public Class Circle
    Inherits Shape
    Private radius As Integer

    Public Sub getRadius()
        Console.WriteLine("Enter your radius")
        radius = CInt(Console.ReadLine())
    End Sub
    Public Sub computeArea()
        area = Math.PI * Math.Pow(radius, 2)
    End Sub
    Public Sub computePer()
        perimeter = Math.PI * 2 * radius
    End Sub
    Public Overrides Sub print()
        MsgBox(("Area=" & area & vbNewLine & "Perimeter=" & perimeter))
    End Sub
End Class
