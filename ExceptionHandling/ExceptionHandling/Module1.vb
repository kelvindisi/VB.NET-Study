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

                output = num1 / num2
                Console.WriteLine("The output is: {0}", output)
                proceed = False

            Catch ex As OverflowException
                Console.WriteLine(ex.Message)
            Catch ex2 As DivideByZeroException
                Console.WriteLine(ex2.Message)
            Catch ex3 As InvalidCastException
                Console.WriteLine("The value you entered is not an integer")
            Finally
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("Division of two numbers")
                Console.ForegroundColor = ConsoleColor.White
            End Try
        Loop While proceed = True

        Console.ReadKey()
    End Sub

End Module
