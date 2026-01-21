# VB.NET Fundamentals - Learning Project

This project contains comprehensive examples of VB.NET fundamentals, from basic data types to object-oriented programming concepts.

## Table of Contents
- [Variable Declarations and Data Types](#variable-declarations-and-data-types)
- [Operators](#operators)
  - [Arithmetic Operators](#arithmetic-operators)
  - [Comparison Operators](#comparison-operators)
  - [Logical Operators](#logical-operators)
  - [Assignment Operators](#assignment-operators)
  - [Bitwise Operators](#bitwise-operators)
- [Control Flow Statements](#control-flow-statements)
- [Looping Statements](#looping-statements)
- [Functions and Subroutines](#functions-and-subroutines)
- [Exception Handling](#exception-handling)
- [Object-Oriented Programming (OOP)](#object-oriented-programming-oop)

---

## Variable Declarations and Data Types

### Definition
Variables are containers for storing data values. In VB.NET, every variable has a data type that determines what kind of data it can hold.

### Common Data Types
- **Integer**: Whole numbers (32-bit) ranging from -2,147,483,648 to 2,147,483,647
- **String**: Text data, enclosed in double quotes
- **Decimal**: High-precision decimal numbers, ideal for financial calculations
- **Boolean**: True or False values
- **Double**: Floating-point numbers (64-bit)
- **Date**: Date and time values

### Syntax
```vb
Dim variableName As DataType = value
```

### Example
```vb
Dim myNumber As Integer = 42
Dim myText As String = "Hello, World!"
Dim myDecimal As Decimal = 3.14D
Dim myBoolean As Boolean = True
```

---

## Operators

### Arithmetic Operators

#### Definition
Arithmetic operators are used to perform mathematical calculations on numeric values.

#### Available Operators
- **+** : Addition
- **-** : Subtraction
- **\*** : Multiplication
- **/** : Division (returns a double)
- **\\** : Integer division (returns an integer)
- **Mod** : Modulus (returns the remainder)
- **^** : Exponentiation

#### Example
```vb
Dim a As Integer = 10
Dim b As Integer = 3
Dim sum As Integer = a + b        ' Result: 13
Dim product As Integer = a * b    ' Result: 30
Dim quotient As Double = a / b    ' Result: 3.333...
```

---

### Comparison Operators

#### Definition
Comparison operators are used to compare two values and return a Boolean result (True or False).

#### Available Operators
- **=** : Equal to
- **<>** : Not equal to
- **>** : Greater than
- **<** : Less than
- **>=** : Greater than or equal to
- **<=** : Less than or equal to

#### Example
```vb
Dim a As Integer = 10
Dim b As Integer = 20
Console.WriteLine(a = b)   ' False
Console.WriteLine(a < b)   ' True
```

---

### Logical Operators

#### Definition
Logical operators are used to combine conditional statements and return Boolean results.

#### Available Operators
- **And** : Returns True if both operands are True (evaluates both conditions)
- **Or** : Returns True if at least one operand is True (evaluates both conditions)
- **Not** : Reverses the Boolean value
- **AndAlso** : Short-circuit AND (stops evaluation if first condition is False)
- **OrElse** : Short-circuit OR (stops evaluation if first condition is True)
- **Xor** : Exclusive OR (True if operands are different)

#### Difference between And/Or and AndAlso/OrElse
- **And/Or**: Always evaluates both conditions
- **AndAlso/OrElse**: Short-circuit evaluation - stops as soon as the result is determined (more efficient)

#### Example
```vb
Dim x As Boolean = True
Dim y As Boolean = False
Console.WriteLine(x And y)      ' False
Console.WriteLine(x Or y)       ' True
Console.WriteLine(x AndAlso y)  ' False (y not evaluated)
```

---

### Assignment Operators

#### Definition
Assignment operators are used to assign values to variables. Compound assignment operators combine an operation with assignment.

#### Available Operators
- **=** : Simple assignment
- **+=** : Add and assign
- **-=** : Subtract and assign
- **\*=** : Multiply and assign
- **/=** : Divide and assign
- **\\=** : Integer divide and assign
- **^=** : Exponentiate and assign
- **&=** : Concatenate and assign (for strings)

#### Example
```vb
Dim num As Integer = 10
num += 5  ' Equivalent to: num = num + 5 (Result: 15)
num -= 3  ' Equivalent to: num = num - 3 (Result: 12)
num *= 2  ' Equivalent to: num = num * 2 (Result: 24)
```

---

### Bitwise Operators

#### Definition
Bitwise operators perform operations on individual bits of integer values.

#### Available Operators
- **And** : Bitwise AND (1 if both bits are 1)
- **Or** : Bitwise OR (1 if at least one bit is 1)
- **Xor** : Bitwise XOR (1 if bits are different)
- **Not** : Bitwise NOT (inverts all bits)
- **<<** : Left shift (shifts bits to the left)
- **>>** : Right shift (shifts bits to the right)

#### Example
```vb
Dim a As Integer = 12  ' Binary: 1100
Dim b As Integer = 5   ' Binary: 0101
Dim result As Integer = a And b  ' Binary: 0100 (Decimal: 4)
Dim leftShift As Integer = a << 1  ' Binary: 11000 (Decimal: 24)
```

---

## Control Flow Statements

### Definition
Control flow statements determine the order in which code is executed based on conditions.

### If-Else Statement
Executes code based on whether a condition is True or False.

#### Syntax
```vb
If condition Then
    ' Code to execute if condition is True
Else
    ' Code to execute if condition is False
End If
```

### If-ElseIf-Else Statement
Allows testing multiple conditions in sequence.

#### Syntax
```vb
If condition1 Then
    ' Code for condition1
ElseIf condition2 Then
    ' Code for condition2
Else
    ' Code if no conditions are met
End If
```

### Select Case Statement
Provides a cleaner way to test a variable against multiple values.

#### Syntax
```vb
Select Case variable
    Case value1
        ' Code for value1
    Case value2
        ' Code for value2
    Case Else
        ' Default code
End Select
```

#### Example
```vb
Dim grade As Char = "B"
Select Case grade
    Case "A"
        Console.WriteLine("Excellent!")
    Case "B"
        Console.WriteLine("Good!")
    Case Else
        Console.WriteLine("Invalid grade.")
End Select
```

---

## Looping Statements

### Definition
Loops allow you to execute a block of code repeatedly based on a condition or for a specified number of times.

### For Loop
Executes code a specific number of times.

#### Syntax
```vb
For counter = start To end [Step increment]
    ' Code to execute
Next
```

#### Example
```vb
For i As Integer = 1 To 5
    Console.WriteLine("Number: " & i)
Next
```

---

### While Loop
Executes code as long as a condition is True (checks condition before execution).

#### Syntax
```vb
While condition
    ' Code to execute
End While
```

#### Example
```vb
Dim number As Integer = 1
While number <= 5
    Console.WriteLine("Number: " & number)
    number += 1
End While
```

---

### Do While Loop
Executes code at least once, then continues while a condition is True (checks condition after execution).

#### Syntax
```vb
Do
    ' Code to execute
Loop While condition
```

---

### Do Until Loop
Executes code until a condition becomes True.

#### Syntax
```vb
Do
    ' Code to execute
Loop Until condition
```

#### Example
```vb
Dim count As Integer = 1
Do
    Console.WriteLine("Count: " & count)
    count += 1
Loop Until count > 5
```

---

## Functions and Subroutines

### Subroutines (Sub)

#### Definition
A subroutine is a block of code that performs a task but does not return a value.

#### Syntax
```vb
Sub SubroutineName(parameters)
    ' Code to execute
End Sub
```

#### Example
```vb
Sub PrintGreeting()
    Console.WriteLine("Hello, welcome to VB.NET!")
End Sub

' Calling the subroutine
PrintGreeting()
```

---

### Functions

#### Definition
A function is a block of code that performs a task and returns a value.

#### Syntax
```vb
Function FunctionName(parameters) As ReturnType
    ' Code to execute
    Return value
End Function
```

#### Example
```vb
Function AddNumbers(a As Integer, b As Integer) As Integer
    Return a + b
End Function

' Calling the function
Dim sum As Integer = AddNumbers(5, 7)
Console.WriteLine("Sum: " & sum)
```

#### Key Difference
- **Subroutines**: No return value (use when you just want to perform actions)
- **Functions**: Return a value (use when you need to calculate and return a result)

---

## Exception Handling

### Definition
Exception handling allows you to gracefully handle runtime errors and prevent your application from crashing.

### Try-Catch-Finally Block

#### Syntax
```vb
Try
    ' Code that might cause an error
Catch ex As SpecificException
    ' Handle specific exception
Catch ex As Exception
    ' Handle any other exception
Finally
    ' Code that always runs (cleanup code)
End Try
```

#### Components
- **Try**: Contains code that might throw an exception
- **Catch**: Handles specific types of exceptions
- **Finally**: Executes regardless of whether an exception occurred (optional)

#### Example
```vb
Try
    Dim numerator As Integer = 10
    Dim denominator As Integer = 0
    Dim result As Integer = numerator / denominator
Catch ex As DivideByZeroException
    Console.WriteLine("Error: Cannot divide by zero.")
Catch ex As Exception
    Console.WriteLine("An unexpected error occurred: " & ex.Message)
Finally
    Console.WriteLine("This block runs regardless of an error.")
End Try
```

---

## Object-Oriented Programming (OOP)

### Definition
OOP is a programming paradigm based on the concept of "objects" that contain data (properties) and code (methods).

### The Four Pillars of OOP

#### 1. Encapsulation

##### Definition
Encapsulation is the bundling of data (fields) and methods that operate on that data within a single unit (class). It also involves hiding the internal state and requiring all interaction to be performed through an object's methods.

##### Key Concepts
- **Private fields**: Data is hidden from outside access
- **Public properties**: Controlled access to data through Get/Set accessors
- **Data hiding**: Internal implementation details are hidden

##### Example
```vb
Public Class Person
    Private _name As String
    Private _age As Integer
    
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    
    Public Sub Greet()
        Console.WriteLine("Hello, my name is " & _name)
    End Sub
End Class
```

---

#### 2. Inheritance

##### Definition
Inheritance allows a class (child/derived class) to inherit properties and methods from another class (parent/base class), promoting code reuse.

##### Key Concepts
- **Base class**: The class being inherited from
- **Derived class**: The class that inherits
- **Inherits keyword**: Used to specify inheritance
- **Protected**: Accessible in the class and its derived classes

##### Example
```vb
Public Class Person
    Public Property Name As String
    Public Property Age As Integer
End Class

Public Class Student
    Inherits Person
    Public Property StudentID As String
    
    Public Sub DisplayStudentInfo()
        Console.WriteLine("Student: " & Name & ", Age: " & Age)
    End Sub
End Class
```

---

#### 3. Polymorphism

##### Definition
Polymorphism allows objects of different classes to be treated as objects of a common base class. It enables the same interface to be used for different data types.

##### Types
- **Method Overriding**: Derived class provides a specific implementation of a method defined in the base class
- **Method Overloading**: Multiple methods with the same name but different parameters

##### Key Keywords
- **Overridable**: Marks a base class method that can be overridden
- **Overrides**: Overrides a base class method in the derived class
- **Overloads**: Defines multiple methods with the same name

##### Example
```vb
Public Class Person
    Public Overridable Sub Greet()
        Console.WriteLine("Hello, I am a person.")
    End Sub
End Class

Public Class Student
    Inherits Person
    
    Public Overrides Sub Greet()
        Console.WriteLine("Hello, I am a student.")
    End Sub
End Class

' Usage
Dim person As Person = New Student()
person.Greet()  ' Outputs: "Hello, I am a student."
```

---

#### 4. Abstraction

##### Definition
Abstraction means hiding complex implementation details and showing only the necessary features of an object.

##### Key Concepts
- **Abstract classes**: Cannot be instantiated, used as base classes
- **MustInherit**: Keyword to create abstract classes
- **MustOverride**: Keyword to create abstract methods that must be implemented by derived classes
- **Interfaces**: Contracts that define methods without implementation

##### Example
```vb
Public MustInherit Class Shape
    Public MustOverride Function CalculateArea() As Double
End Class

Public Class Circle
    Inherits Shape
    Public Property Radius As Double
    
    Public Overrides Function CalculateArea() As Double
        Return Math.PI * Radius * Radius
    End Function
End Class
```

---

## Project Structure

This project contains the following files:
- **Program.vb**: Main file with examples of all concepts
- **ProgramEncapsulation.vb**: Example class demonstrating encapsulation
- **ProgramInheritance.vb**: Example class demonstrating inheritance
- **ProgramPolymorphism.vb**: Example class demonstrating polymorphism

---

## How to Use This Project

1. Open the `Program.vb` file
2. Uncomment the section you want to run
3. Build and run the project to see the output
4. Experiment by modifying values and observing the results

---

## Additional Resources

- [Microsoft VB.NET Documentation](https://docs.microsoft.com/en-us/dotnet/visual-basic/)
- [VB.NET Language Reference](https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/)
- [.NET API Browser](https://docs.microsoft.com/en-us/dotnet/api/)

---

## Notes

- All examples in `Program.vb` are commented out to prevent conflicts
- Uncomment only the sections you want to test
- Remember to comment out previous examples before testing new ones
- This project serves as a reference guide for VB.NET fundamentals

---

**Created for learning and reference purposes**
