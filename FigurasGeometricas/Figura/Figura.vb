Public MustInherit Class Figura

    Public Sub New()
        Me.Nombre = ""
    End Sub
    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public MustOverride Function CalcularArea() As Single

End Class

