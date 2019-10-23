Public Class Circulo
    Inherits Figura

    Public Overrides Function CalcularArea() As Single
        Return Math.PI * Math.Pow(Radio, 2)
    End Function

    Public Sub New()
        Nombre = "Circulo"
        Me.Radio = 0
    End Sub

    Public Property Radio As Integer

End Class
