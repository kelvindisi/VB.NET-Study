Imports System
Module Module1

    Sub Main()
        Dim num1, num2, output As Integer
        Dim proceed As Boolean = True

        Do
            Try
                Console.WriteLine("Enter first value")
                num1 = CInt(Console.ReadLine())
                Console.WriteLine("Enter second value")
                num2 = CInt(Console.ReadLine())

                output = num1 \ num2
                Console.WriteLine("The output is: {0}", output)
                proceed = False

            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Your input is not correct because: " & ex.Message)
                Console.ForegroundColor = ConsoleColor.White
            Finally
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("Division of two numbers")
                Console.ForegroundColor = ConsoleColor.White
            End Try
        Loop While proceed = True

        Console.ReadKey()
    End Sub

End Module
