Option Compare Text

Module Module1

    Sub Main()
        Dim grade As String
        Console.WriteLine("Enter the grade")
        grade = Console.ReadLine()

        Select Case grade
            Case "A"
                Console.WriteLine("1st class Honours")
            Case "B"
                Console.WriteLine("2nd class Upper Division")
            Case "C"
                Console.WriteLine("2nd class Lower Division")
            Case "D"
                Console.WriteLine("Pass")
            Case "E"
                Console.WriteLine("Fail")
            Case Else
                Console.WriteLine("Invalid entries")

        End Select

        Console.ReadKey()
    End Sub

End Module
