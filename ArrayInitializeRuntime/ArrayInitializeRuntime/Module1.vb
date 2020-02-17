Module Module1

    Sub Main()
        Dim marks(9) As Integer
        Dim i, passed, failed As Integer

        For i = LBound(marks) To UBound(marks) Step 1
            Console.WriteLine("Enter the mark of student: " & (i + 1))
            marks(i) = CInt(Console.ReadLine())
        Next
        Console.WriteLine()

        For i = 0 To 9 Step 1
            Console.Write(marks(i) & vbTab)
        Next
        Console.WriteLine()
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
        Console.WriteLine("Passed student=" & passed & " And failed students=" & failed)
        Console.ReadKey()
    End Sub

End Module
