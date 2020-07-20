Public Class Student
    Inherits Person

    Public Overrides Sub getName()
        Console.WriteLine(“Enter name”)
        name = Console.ReadLine()
    End Sub
End Class
