Imports System

Module Program
    Sub Main(args As String())
        Console.Write("What is your age: ")
        Dim ageText As String = Console.ReadLine()

        'Console.WriteLine(ageText + 15)

        'Dim age As Integer = Integer.Parse(ageText)

        'Dim age As Integer

        Dim age As Integer
        Dim isValidInt As Boolean = Integer.TryParse(ageText, age)

        Console.WriteLine($"This is valid: {isValidInt}. The number was {age}.")

        Console.WriteLine(age + 15)

        Dim testDouble As Double = age
        Dim testDecimal As Decimal = CType(testDouble, Decimal)

    End Sub
End Module
