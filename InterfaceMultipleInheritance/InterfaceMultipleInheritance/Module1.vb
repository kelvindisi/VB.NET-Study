Module Module1

    Sub Main()
        Dim worker As Worker = New Worker()
        worker.getFirstName()
        worker.getLastName()
        worker.print()

        Console.ReadKey()
    End Sub

End Module
