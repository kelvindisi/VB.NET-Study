Public MustInherit Class Person
    Protected name, address, contacts As String
    Protected age As Integer

    MustOverride Sub getDetails()
    MustOverride Function computeBMI() As String


End Class
