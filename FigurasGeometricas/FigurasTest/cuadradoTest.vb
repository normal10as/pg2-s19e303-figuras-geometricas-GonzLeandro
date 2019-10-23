Imports FigurasGeometricas
Module cuadradoTest

    Sub cuadrado()

        Dim cuadrado1 As New Cuadrado()

        cuadrado1.Lado = 2

        Console.WriteLine("La lado es: " & cuadrado1.Lado &
                           " Se llama: " & cuadrado1.Nombre)

        Console.WriteLine("El area es: " & cuadrado1.CalcularArea())

    End Sub
End Module
