Module Module1

    Sub Main()
        Dim name() As String = {"Humphrey", "Kathure", "Kelvin", "Caleno", "Mawut"}
        Dim marks(,) As Integer = {{55, 49, 70, 53, 59}, {43, 45, 69, 70, 51}, {72, 76, 29, 51, 80}, {70, 70, 46, 63, 85}, {58, 60, 48, 69, 72}}
        Dim i, j As Integer
        Dim avg As Double
        Dim sum As Integer
        Dim grade As Char

        Console.WriteLine("Name" & vbTab & vbTab & "BIT 2118" & vbTab & "ICS 2201" & vbTab & "BIT 2205" & vbTab & "ICS 2206" & vbTab & "BIT 2301" & vbTab & "Grade")

        For i = LBound(marks, 1) To UBound(marks, 1) Step 1
            Console.Write(name(i) & vbTab & vbTab)
            sum = 0
            For j = LBound(marks, 2) To UBound(marks, 2) Step 1
                Console.Write(marks(i, j) & vbTab)
                sum += marks(i, j)
            Next j
            avg = sum / 5
            If (avg <= 39) Then
                grade = CChar("E")
            ElseIf (avg <= 49) Then
                grade = CChar("D")
            ElseIf (avg <= 59) Then
                grade = CChar("C")
            ElseIf (avg <= 69) Then
                grade = CChar("B")
            Else
                grade = CChar("A")
            End If
            Console.Write(grade)
            Console.WriteLine()
        Next i

        Console.ReadKey()
    End Sub

End Module
