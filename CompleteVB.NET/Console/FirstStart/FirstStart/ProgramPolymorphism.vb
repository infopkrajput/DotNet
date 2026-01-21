Public Class ProgramPolymorphism
    Inherits ProgramEncapsulation
    Public Property StudentID As String

    Public Overrides Sub Greet()
        Console.WriteLine("Hello, my name is " & Name & " and I am a student with ID: " & StudentID)
    End Sub
End Class
