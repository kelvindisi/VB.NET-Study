Option Compare Text

Module Module1

    Sub Main()
        Dim dob As Date
        Dim age As Integer

        Console.WriteLine("Enter the date of birth")
        dob = CDate(Console.ReadLine())

        If dob > Now Then
            Console.WriteLine("Invalid date")
        Else
            age = Now.Year - dob.Year

            Select Case age
                Case Is <= 12
                    Console.WriteLine("You are a child of " & age & " years old")
                Case Is <= 19
                    Console.WriteLine("You are a teenager of " & age & " years old")
                Case Is <= 35
                    Console.WriteLine("You are a youth of " & age & " years old")
                Case Else
                    Console.WriteLine("You are a mzee of " & age & " years old")
            End Select
        End If

        Console.ReadKey()
    End Sub

End Module
