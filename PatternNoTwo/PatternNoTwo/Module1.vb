Module Module1

    Sub Main()
        For col = 1 To 5 Step 1
            For row = 1 To 5 Step 1
                Dim multi As Integer
                multi = row * col
                If (Not col = 1 And Not row = 1) Then
                    If (24 Mod multi = 0 And multi > 4) Then
                        Console.Write("#" + vbTab)
                    Else
                        Console.Write("$" + vbTab)
                    End If
                Else
                    Console.Write("$" + vbTab)
                End If

            Next
            Console.WriteLine()
        Next

        Console.ReadKey()
    End Sub

End Module
