Module Module1

    Sub Main()
        Dim status As Integer
        Dim income, tax As Double

        Console.WriteLine("Chooses: 0. Single 1. Married Filing Jointly 2. Married Filing Separately")
        status = CInt(Console.ReadLine())
        Console.Write("Enter taxable amount: ")
        income = CDbl(Console.ReadLine())

        Select Case status
            Case 0
                If (income <= 8350) Then
                    tax = income * 0.1
                ElseIf (income <= 33950) Then
                    tax = (8350 * 0.1) + ((income - 8350) * 0.15)
                ElseIf (income <= 82250) Then
                    tax = (8350 * 0.1) + ((33950 - 8350) * 0.15) +
                        ((income - (33950 - 8350) + 8350) * 0.25)
                ElseIf (income <= 171500) Then
                    tax = (8350 * 0.1) + ((33950 - 8350) * 0.15) + ((82250 - 33950) * 0.25) + (income - ((82250 - 33950) + (33950 - 8300) + 8350)) * 0.28
                Else
                    tax = (8350 * 0.1) + ((33950 - 8350) * 0.15) + ((82250 - 33950) * 0.25) + ((171500 - 82250) * 0.28) + ((income - (171500 - 82250) + (82250 - 33950) + (33950 - 8350) + 8350) * 0.3)
                End If
        End Select

        Console.WriteLine("Personal Income Tax= " & tax)
        Console.ReadKey()

    End Sub

End Module
