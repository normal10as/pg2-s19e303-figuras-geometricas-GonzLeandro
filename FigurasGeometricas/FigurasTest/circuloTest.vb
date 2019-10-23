Imports FigurasGeometricas
Module circuloTest

    Sub circulo()
        Dim circulo1 As New Circulo()

        circulo1.Radio = 3

        Console.WriteLine("El radio es: " & circulo1.Radio &
                           " Se llama: " & circulo1.Nombre)

        Console.WriteLine("El area es: " & circulo1.CalcularArea())

    End Sub
End Module
