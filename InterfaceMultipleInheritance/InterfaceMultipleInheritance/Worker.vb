Imports InterfaceMultipleInheritance

Public Class Worker
    Implements Staff, Person
    Private firstName, lastName As String

    Public Sub getFirstName() Implements Person.getFirstName
        Console.WriteLine("Enter first name")
        firstName = Console.ReadLine()
    End Sub

    Public Sub getLastName() Implements Person.getLastName
        Console.WriteLine("Enter last name")
        lastName = Console.ReadLine
    End Sub

    Public Sub print() Implements Staff.print
        Console.WriteLine("Full name: {0} {1}", firstName, lastName)
    End Sub
End Class
