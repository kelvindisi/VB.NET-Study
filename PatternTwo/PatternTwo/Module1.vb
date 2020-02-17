Module Module1
    Sub Main()
        For y = 1 To 9 Step 1
            For x = 1 To 9 Step 1
                If (y = 1 And x = 1) Then
                    For l = 1 To 9
                        Console.Write(vbTab & l)
                    Next
                    Console.WriteLine()
                End If
                Dim multi As Integer
                multi = y * x
                If (x = 1) Then
                    Console.Write(y & vbTab)
                End If
                Console.Write(multi & vbTab)
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
