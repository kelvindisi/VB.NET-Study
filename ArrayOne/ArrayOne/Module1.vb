Module Module1

    Sub Main()
        Dim marks() As Integer = {56, 78, 32, 64, 29, 56, 49, 39, 80, 59}
        Dim i As Integer
        Dim failed, passed As Integer

        For i = 0 To 9 Step 1
            marks(i) = marks(i) + 2
            marks(4) = 63
            Console.Write(marks(i) & vbTab)

        Next
        Console.WriteLine()
        passed = 0
        failed = 0
        For i = 0 To 9 Step 1
            If (marks(i) >= 50) Then
                passed += 1
            Else
                failed += 1
            End If
        Next
        Console.WriteLine("Passed students=" & passed & " And Failed students=" & failed)
        Console.ReadKey()
    End Sub

End Module
