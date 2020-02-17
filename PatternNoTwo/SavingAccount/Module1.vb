Module Module1

    Sub Main()
        Dim amount, rate, monthlyRate As Double
        Dim months As Integer

        Console.WriteLine("Enter the amount to save")
        amount = CDbl(Console.ReadLine())
        Console.WriteLine("Enter the no of months to save")
        months = CInt(Console.ReadLine())
        Console.WriteLine("Enter annual interest rate")
        rate = CDbl(Console.ReadLine())

        monthlyRate = rate / (100 * 12)


        For counter = 1 To months Step 1
            amount += amount * (1 * monthlyRate)
        Next counter

        Console.WriteLine("Your total amount after {0} is {1}", months, amount)
        Console.ReadKey()
    End Sub

End Module
