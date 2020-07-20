Public Class NegativeValueException
    Inherits Exception

    Public Sub New(ByVal strMessage As String)
        MyBase.New(strMessage)
    End Sub
End Class
