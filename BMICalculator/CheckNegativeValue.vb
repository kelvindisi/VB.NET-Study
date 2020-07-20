Public Class CheckNegativeValue
    Public Sub check(ByVal value As Double)
        If value < 0 Then
            Throw New NegativeValueException("Value entered should not be a negative value")
        End If
    End Sub
End Class
