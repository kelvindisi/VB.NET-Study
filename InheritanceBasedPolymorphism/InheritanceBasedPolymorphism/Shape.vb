Public MustInherit Class Shape
    Protected areas, perimeter As Double

    Public MustOverride Sub getDimensions()
    Public MustOverride Sub computeArea()
    Public MustOverride Sub computePer()
    Public Sub print()
        MsgBox(("Area=" & areas & vbNewLine & "Perimeter=" & perimeter))
    End Sub
End Class
