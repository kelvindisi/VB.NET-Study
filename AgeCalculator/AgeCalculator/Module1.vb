Module Module1
    Sub Main()
        Dim person As New Person()
        Console.WriteLine("Enter first name: ")
        person.FirstName = person.getName()
        Console.WriteLine("Enter last name: ")
        person.LastName = person.getName()
        Console.WriteLine("Enter the date of birth: ")
        person.dob = person.getDob()

        Console.WriteLine(person.ToString())
        Console.ReadKey()
    End Sub

End Module
