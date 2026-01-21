Public Class ProgramInheritance
    Inherits ProgramEncapsulation

    Public Property StudentID As String

    Public Sub DisplayStudentInfo()
        Console.WriteLine("Student ID: " & StudentID)
        Greet()
    End Sub

End Class
