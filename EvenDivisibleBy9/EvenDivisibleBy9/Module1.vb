Module Module1

    Sub Main()
        Dim i As Integer
        Dim sum As Integer = 0


        For i = 25 To 70 Step 1
            If (i Mod 9 = 0) And (i Mod 2 = 0) Then
                sum = sum + i
            End If
        Next
        'While (i <= 70)
        '    If (i Mod 9 = 0) And (i Mod 2 = 0) Then
        '        sum = sum + i
        '    End If
        '    i = i + 1
        'End While
        'Do While (i <= 70)
        '    If (i Mod 9 = 0) And (i Mod 2 = 0) Then
        '        sum = sum + i
        '    End If
        '    i = i + 1
        'Loop
        'Do Until (i > 70)
        '    If (i Mod 9 = 0) And (i Mod 2 = 0) Then
        '        sum = sum + i
        '    End If
        '    i = i + 1
        'Loop
        'Do
        '    If (i Mod 9 = 0) And (i Mod 2 = 0) Then
        '        sum = sum + i
        '    End If
        '    i = i + 1
        'Loop While (i <= 70)
        'Do
        '    If (i Mod 9 = 0) And (i Mod 2 = 0) Then
        '        sum = sum + i
        '    End If
        '    i = i + 1
        'Loop Until (i > 70)

        Console.WriteLine("The sum is " & sum)
        Console.ReadKey()
    End Sub

End Module
