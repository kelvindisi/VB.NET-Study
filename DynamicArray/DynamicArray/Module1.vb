Module Module1

    Sub Main()
        Dim myArray(,) As Integer = {{1, 2, 3, 4, 5}, {10, 11, 12, 13, 14}, {21, 22, 23, 24, 25}}
        Dim row, col As Integer

        Console.WriteLine("Content in array before Resizing")
        For row = LBound(myArray, 1) To UBound(myArray, 1) Step 1
            For col = LBound(myArray, 2) To UBound(myArray, 2) Step 1
                Console.Write(myArray(row, col) & vbTab)
            Next
            Console.WriteLine()
        Next
        ReDim Preserve myArray(2, 6)
        Console.WriteLine("Content in array after Resizing")
        For row = LBound(myArray, 1) To UBound(myArray, 1) Step 1
            For col = LBound(myArray, 2) To UBound(myArray, 2) Step 1
                Console.Write(myArray(row, col) & vbTab)
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
