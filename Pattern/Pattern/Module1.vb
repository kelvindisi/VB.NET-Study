Module Module1

    Sub Main()
        Dim i As Integer
        Dim c As Integer = 1

        Do
            i = 1
            Do While (i <= c)
                Console.Write(i & vbTab)
                i += 1
            Loop
            c += 1
            Console.WriteLine()
        Loop While (c <= 5)
        Console.ReadKey()
    End Sub

End Module
