Imports System

Module Program
    Sub Main(args As String())

        'Variable Declarations and Data Types

        'Dim myNumber As Integer = 42
        'Dim myText As String = "Hello, World!"
        'Dim myDecimal As Decimal = 3.14D
        'Dim myBoolean As Boolean = True
        'Console.WriteLine("Integer: " & myNumber)
        'Console.WriteLine("String: " & myText)
        'Console.WriteLine("Decimal: " & myDecimal)
        'Console.WriteLine("Boolean: " & myBoolean)

        'Arithmetic Operations
        'Dim a As Integer = 10
        'Dim b As Integer = 3

        'Dim sum As Integer = a + b
        'Dim difference As Integer = a - b
        'Dim product As Integer = a * b
        'Dim quotient As Double = a / b

        'Console.WriteLine("Sum: " & sum)
        'Console.WriteLine("Difference: " & difference)
        'Console.WriteLine("Product: " & product)
        'Console.WriteLine("Quotient: " & quotient)

        'Comparison Operators
        'Dim a As Integer = 10
        'Dim b As Integer = 20

        'Console.WriteLine("Is a equal to b? " & (a = b))
        'Console.WriteLine("Is a not equal to b? " & (a <> b))
        'Console.WriteLine("Is a greater than b? " & (a > b))
        'Console.WriteLine("Is a less than b? " & (a < b))
        'Console.WriteLine("Is a greater than or equal to b? " & (a >= b))
        'Console.WriteLine("Is a less than or equal to b? " & (a <= b))

        'Logical Operators
        'Dim x As Boolean = True
        'Dim y As Boolean = False

        '' Using And - both must be True
        'Console.WriteLine("x And y: " & (x And y))  ' This will print False

        '' Using Or - at least one must be True
        'Console.WriteLine("x Or y: " & (x Or y))  ' This will print True

        'Dim a As Boolean = True
        'Dim b As Boolean = False

        '' Using AndAlso - stops if the first condition is False
        'Console.WriteLine("a AndAlso b: " & (a AndAlso b))  ' This will print False, and b won't be evaluated

        '' Using OrElse - stops if the first condition is True
        'Console.WriteLine("a OrElse b: " & (a OrElse b))  ' This will print True, and b won't be evaluated

        'Assignment Operators
        'Dim num As Integer = 10

        '' Using the addition assignment operator
        'num += 5  ' Now num is 15
        'Console.WriteLine("After num += 5: " & num)

        '' Using the subtraction assignment operator
        'num -= 3  ' Now num is 12
        'Console.WriteLine("After num -= 3: " & num)

        '' Using the multiplication assignment operator
        'num *= 2  ' Now num is 24
        'Console.WriteLine("After num *= 2: " & num)

        '' Using the division assignment operator
        'num /= 4  ' Now num is 6
        'Console.WriteLine("After num /= 4: " & num)


        'Bitwise Operators
        'Dim a As Integer = 12  ' In binary: 1100
        'Dim b As Integer = 5   ' In binary: 0101

        '' Bitwise AND
        'Dim resultAnd As Integer = a And b  ' 1100 & 0101 = 0100 (4 in decimal)
        'Console.WriteLine("Bitwise AND: " & resultAnd)

        '' Bitwise OR
        'Dim resultOr As Integer = a Or b  ' 1100 | 0101 = 1101 (13 in decimal)
        'Console.WriteLine("Bitwise OR: " & resultOr)

        '' Bitwise XOR
        'Dim resultXor As Integer = a Xor b  ' 1100 ^ 0101 = 1001 (9 in decimal)
        'Console.WriteLine("Bitwise XOR: " & resultXor)

        '' Bitwise NOT
        'Dim resultNot As Integer = Not a  ' Inverts all bits of a
        'Console.WriteLine("Bitwise NOT of a: " & resultNot)

        '' Left shift
        'Dim leftShift As Integer = a << 1  ' Shifts bits to the left by one position
        'Console.WriteLine("Left shift (a << 1): " & leftShift)

        '' Right shift
        'Dim rightShift As Integer = a >> 1  ' Shifts bits to the right by one position
        'Console.WriteLine("Right shift (a >> 1): " & rightShift)


        'Control Flow Statements
        'If-Else Statement
        'Dim number As Integer = 15
        'If number Mod 2 = 0 Then
        '    Console.WriteLine(number & " is even.")
        'Else
        '    Console.WriteLine(number & " is odd.")
        'End If

        'If-ElseIf-Else Statement
        'Dim number As Integer = 10
        'If number > 0 Then
        '    Console.WriteLine("The number is positive.")
        'ElseIf number < 0 Then
        '    Console.WriteLine("The number is negative.")
        'Else
        '    Console.WriteLine("The number is zero.")
        'End If

        'Select Case Statement
        'Dim grade As Char = "B"

        'Select Case grade
        '    Case "A"
        '        Console.WriteLine("Excellent!")
        '    Case "B"
        '        Console.WriteLine("Good!")
        '    Case "C"
        '        Console.WriteLine("Average!")
        '    Case "D"
        '        Console.WriteLine("Below Average!")
        '    Case "F"
        '        Console.WriteLine("Failed!")
        '    Case Else
        '        Console.WriteLine("Invalid grade.")
        'End Select

        'looping Statements
        'For Loop
        'For i As Integer = 1 To 5
        '    Console.WriteLine("Number: " & i)
        'Next

        'While Loop
        'Dim number As Integer = 1

        'While number <= 5
        '    Console.WriteLine("Number: " & number)
        '    number += 1
        'End While

        'Do While Loop
        'Dim count As Integer = 1

        'Do
        '    Console.WriteLine("Count: " & count)
        '    count += 1
        'Loop While count <= 5

        'Do Until Loop
        'Dim count As Integer = 1

        'Do
        '    Console.WriteLine("Count: " & count)
        '    count += 1
        'Loop Until count > 5

        'Functions and Subroutines

        'Calling a Subroutine
        'PrintGreeting()

        ''Calling a Function
        'Dim sum As Integer = AddNumbers(5, 7)
        'Console.WriteLine("Sum: " & sum)

        'Exception Handling
        'Try
        '    Dim numerator As Integer = 10
        '    Dim denominator As Integer = 0
        '    Dim result As Integer = numerator / denominator  ' This will cause a divide-by-zero exception
        'Catch ex As DivideByZeroException
        '    Console.WriteLine("Error: Cannot divide by zero.")
        'Catch ex As Exception
        '    Console.WriteLine("An unexpected error occurred: " & ex.Message)
        'Finally
        '    Console.WriteLine("This block runs regardless of an error.")
        'End Try

        'Oops Concepts
        'Encapsulation Example
        'Created class in ProgramEncapsulation.vb
        'Dim person As New ProgramEncapsulation()
        'person.Name = "Alice"
        'person.Age = 30
        'person.Greet()

        'Inheritance Example
        'Created class in ProgramInheritance.vb
        'Dim student As New ProgramInheritance()
        'student.Name = "Bob"
        'student.Age = 20
        'student.StudentID = "S12345"
        'student.DisplayStudentInfo()

        'Polymorphism Example
        'Created class in ProgramPolymorphism.vb
        'Dim polyStudent As ProgramEncapsulation = New ProgramPolymorphism()
        'polyStudent.Name = "Charlie"
        'polyStudent.Age = 22
        'CType(polyStudent, ProgramPolymorphism).StudentID = "S67890"
        'polyStudent.Greet()


    End Sub

    'Defining a Subroutine
    Sub PrintGreeting()
        Console.WriteLine("Hello, welcome to VB.NET!")
    End Sub

    'Defining a Function
    Function AddNumbers(a As Integer, b As Integer) As Integer
        Return a + b
    End Function

End Module
