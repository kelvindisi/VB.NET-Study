Public Class Patient
    Inherits Person

    Private weight As Double
    Private height As Double
    Private checker As CheckNegativeValue = New CheckNegativeValue()

    Property BMI As Double



    Property weightProperty As Double
        Set(value As Double)
            checker.check(value)
            weight = value
        End Set
        Get
            Return weight
        End Get
    End Property
    Property heightProperty As Double
        Set(value As Double)
            checker.check(value)
            height = value
        End Set
        Get
            Return height
        End Get
    End Property


    Private finishLoop As Boolean = True

    Public Overrides Sub getDetails()
        ' Cannot throw error
        Console.WriteLine("Enter name")
        name = Console.ReadLine()
        Console.WriteLine("Enter address")
        address = Console.ReadLine()
        Console.WriteLine("Enter contacts")
        contacts = Console.ReadLine()

        Do
            Try
                Console.WriteLine("Enter weight")
                weightProperty = CDbl(Console.ReadLine())
                Console.WriteLine("Enter height")
                heightProperty = CDbl(Console.ReadLine())

                finishLoop = False
            Catch ex As InvalidCastException
                setForeground(ConsoleColor.Red)
                Console.WriteLine("Please enter a number")
                setForeground(ConsoleColor.White)
            Catch ex2 As NegativeValueException
                setForeground(ConsoleColor.Red)
                Console.WriteLine(ex2.Message)
                setForeground(ConsoleColor.White)
            Catch ex3 As Exception
                setForeground(ConsoleColor.Red)
                Console.WriteLine("Error occcured, {0}", ex3.Message)
                setForeground(ConsoleColor.White)
            End Try
        Loop While finishLoop
    End Sub

    Public Overrides Function computeBMI() As String
        Dim status As String = ""

        Try
            BMI = weightProperty / heightProperty

            If BMI > 30 Then
                status = "Obese"
            ElseIf BMI >= 25 And BMI <= 29.99 Then
                status = "Overweight"
            ElseIf BMI >= 18.5 And BMI <= 24.99 Then
                status = "Normal"
            Else
                status = "Underweight"
            End If

        Catch ex As ArithmeticException
            setForeground(ConsoleColor.Red)
            Console.WriteLine(ex.Message)
        Catch ex2 As Exception
            setForeground(ConsoleColor.Red)
            Console.WriteLine(ex2.Message)
        End Try

        Return status
    End Function

    Public Sub print()
        Console.ForegroundColor = ConsoleColor.Green
        Dim outputStr As String
        outputStr = String.Format(
            "Name: {0} " & vbNewLine & "Address: {1}" & vbNewLine & "Contact: {2} " & vbNewLine & "BMI: {3} - {4}",
            name, address, contacts, BMI, computeBMI())

        Console.WriteLine("-------------------------------------------")
        Console.WriteLine(outputStr)
        Console.WriteLine("-------------------------------------------")
    End Sub

    Private Sub setForeground(ByVal color As ConsoleColor)
        Console.ForegroundColor = color
    End Sub
End Class
