Module Module1

    Sub Main()
        Dim weight, price As Double

        Console.Write("Enter the weight of the package: ")
        weight = CDbl(Console.ReadLine())

        If (weight > 0 And weight >= 10) Then
            price = 3500
        ElseIf (weight > 10 And weight <= 30) Then
            price = 5500
        ElseIf (weight > 30 And weight <= 100) Then
            price = 10500
        End If

        If (price.CompareTo(0)) Then
            Console.WriteLine("Package can be shipped at {0}", FormatCurrency(price, 2))
        Else
            Console.WriteLine("package cannot be shipped")
        End If

        Console.ReadKey()
    End Sub

End Module
