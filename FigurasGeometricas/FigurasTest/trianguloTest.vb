Imports FigurasGeometricas
Module trianguloTest

    Sub triangulo()

        Dim triangulo1 As New Triangulo()

        triangulo1.Base = 4
        triangulo1.Altura = 3

        Console.WriteLine("La base es: " & triangulo1.Base & " La altura: " &
                          triangulo1.Altura & " Se llama: " & triangulo1.Nombre)

        Console.WriteLine("El area es: " & triangulo1.CalcularArea())

    End Sub

End Module
