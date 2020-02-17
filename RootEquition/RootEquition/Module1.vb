Module Module1

    Sub Main()
        Dim a, b, c, discriminant, denom, root1, root2, sqRoot As Double

        Console.WriteLine("Enter the values Of the following coefficients")

        Console.Write("a: ")
        a = CDbl(Console.ReadLine())
        Console.Write("b: ")
        b = CDbl(Console.ReadLine())
        Console.Write("c: ")
        c = CDbl(Console.ReadLine())

        'Find the discriminant using b^2 - 4ac
        discriminant = Math.Pow(b, 2) - (4 * a * c)
        denom = (2 * a)

        If (discriminant > 0) Then
            'positive value display two roots
            sqRoot = Math.Sqrt(discriminant)
            root1 = (-b + sqRoot) / denom
            root2 = (-b - sqRoot) / denom

            Console.WriteLine("x = {0} OR x = {1}", root1, root2)

        ElseIf (discriminant = 0) Then
            'display single root
            root1 = (-b) / denom

            Console.WriteLine("x = {0}", root1)
        Else
            'discrimant is negative display complext roots
            sqRoot = Math.Sqrt(Math.Abs(discriminant))
            Dim tempB As Double
            tempB = -1 * b
            Console.WriteLine("x = ({0} +- {1}i) / {2}", tempB, sqRoot, denom)
        End If
        Console.ReadKey()
    End Sub

End Module
