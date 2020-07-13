Imports System

Public Class Person
    Public Property FirstName As String
    Public Property LastName As String
    Public Property dob As Date

    Public Function ComputeteAge() As Integer
        Return TotalAge()
    End Function
    Public Function totalDaysLived() As Integer
        Dim timeSpan As TimeSpan = Date.Now.Subtract(dob)

        Return timeSpan.TotalDays()
    End Function
    Private Function TotalAge() As Integer
        Dim leapYrs As Integer = TotalLeapYears()
        Dim daysLived As Integer = totalDaysLived()
        Dim nonLeapDays, leapDays As Integer
        Dim _totalAge As Integer

        leapDays = 366 * leapYrs
        nonLeapDays = daysLived - leapDays
        _totalAge = leapYrs + (nonLeapDays \ 365)

        Return _totalAge
    End Function
    Private Function TotalLeapYears() As Integer
        Dim leapYr As Integer = 0

        For counter = dob.Year To Date.Now.Year Step 1
            If (counter Mod 4 = 0) Then
                leapYr += 1
            End If
        Next counter

        Return leapYr
    End Function

    Private Function ComputeExtraDays() As Integer
        Dim leaps As Integer = TotalLeapYears()
        Dim remainingDays As Integer
        remainingDays = (totalDaysLived() - (366 * leaps)) Mod 365
        Return remainingDays
    End Function
    Public Overrides Function ToString() As String
        Return String.Format("You were born on {0:dd-MM-yyyy} and your age is {1} yrs and {2} days",
                             dob, ComputeteAge, ComputeExtraDays())
    End Function
    Public Function getName() As String
        Dim input As String
        Dim correct As Boolean = False

        Do
            input = Console.ReadLine().Trim()
            If (input.Length > 0) Then
                correct = True
            Else
                MsgBox("You did not enter your name, again", 0, "Message")
            End If
        Loop Until (correct)

        Return input
    End Function
    Public Function getDob() As Date
        Dim dobDate As Date
        Dim correct As Boolean
        Do
            correct = Date.TryParse(Console.ReadLine(), dobDate)
            If (correct) Then
                Exit Do
            Else
                Console.WriteLine("Invalid date input")
            End If
        Loop
        Return dobDate
    End Function
End Class
