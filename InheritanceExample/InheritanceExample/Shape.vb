Public Class Shape
    Protected area, perimeter As Double

    Public Overridable Sub print()
        Console.WriteLine("Area=" & area & vbNewLine & "Perimeter=" & perimeter)
    End Sub
End Class
