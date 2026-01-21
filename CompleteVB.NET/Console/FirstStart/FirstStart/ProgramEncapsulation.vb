Public Class ProgramEncapsulation
    Private _name As String
    Private _age As Integer

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Age() As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            _age = value
        End Set
    End Property

    Public Overridable Sub Greet()
        Console.WriteLine("Hello, my name is " & _name & " and I am " & _age & " years old.")
    End Sub
End Class
