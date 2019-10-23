Public Class Triangulo
    Inherits Figura

    Public Overrides Function CalcularArea() As Single
        'Throw New NotImplementedException()
        Return Base * Altura / 2
    End Function

    Public Sub New()
        Nombre = "Triangulo"
        Me.Altura = 0
        Me.Base = 0
    End Sub

    Public Property Base As Integer
    Public Property Altura As Integer
End Class
