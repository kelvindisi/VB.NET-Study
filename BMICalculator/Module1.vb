Module Module1

    Sub Main()
        Dim patient As Patient = New Patient()
        patient.getDetails()
        patient.computeBMI()
        patient.print()

        Console.ReadKey()
    End Sub

End Module
