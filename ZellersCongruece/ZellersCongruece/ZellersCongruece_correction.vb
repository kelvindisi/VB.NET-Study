Module Module1

    Sub Main()
        Dim theDate As Date
        Dim h, q, k, m, j, yr As Integer

        Console.Write("Enter the date (mm/dd/yyyy): ")
        theDate = CDate(Console.ReadLine())


        'Set Year
        yr = theDate.Year
        'day of the month
        q = theDate.Day
        'setting the month and re initializing year
        If (theDate.Month >= 3 And theDate.Month < 12) Then
            m = theDate.Month
        Else
            yr -= 1
            If (theDate.Month.Equals(1)) Then
                m = 13
            Else
                m = 14
            End If

        End If

        'Century
        j = yr \ 100
        'Year of Century
        k = yr Mod 100


        h = (q + (26 * (m + 1)) \ 10 + k + (k \ 4) + (j \ 4) + (5 * j)) Mod 7

        Select Case h
            Case 1
                Console.WriteLine("Sunday")
            Case 2
                Console.WriteLine("Monday")
            Case 3
                Console.WriteLine("Tuesday")
            Case 4
                Console.WriteLine("Wednesday")
            Case 5
                Console.WriteLine("Thursday")
            Case 6
                Console.WriteLine("Friday")
            Case 0
                Console.WriteLine("Saturday")
            Case Else
                Console.WriteLine("Invalid day of the week")
        End Select

        Console.ReadKey()
    End Sub

End Module
