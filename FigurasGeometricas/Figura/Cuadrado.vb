Public Class Cuadrado
    Inherits Figura

    Public Overrides Function CalcularArea() As Single
        Return lado * lado
    End Function

    Public Sub New()
        Nombre = "Cuadrado"
        Me.Lado = 0
    End Sub

    Public Property Lado As Integer
End Class
