Imports FigurasGeometricas
Module rectanguloTest

    Sub rectangulo()

        Dim rectangulo1 As New Rectangulo()
        rectangulo1.Base = 2
        rectangulo1.Altura = 6

        Console.WriteLine("La base es: " & rectangulo1.Base & " La altura: " &
                          rectangulo1.Altura & " Se llama: " & rectangulo1.Nombre)

        Console.WriteLine("El area es: " & rectangulo1.CalcularArea())

    End Sub
End Module
