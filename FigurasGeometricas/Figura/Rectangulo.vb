Public Class Rectangulo
    Inherits Figura

    Public Overrides Function CalcularArea() As Single
        Return Base * Altura
    End Function

    Public Sub New()
        Nombre = "Rectangulo"
        Me.Base = 0
        Me.Altura = 0
    End Sub

    Public Property Base As Integer
    Public Property Altura As Integer
End Class