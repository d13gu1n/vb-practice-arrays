Imports System

Module Program
    Sub Main(args As String())
        'Declaración de variable
        Dim miVariable As String = "Hola Mundo"

        'Mostramos el mensaje en consola
        Console.WriteLine(miVariable)
        Console.ReadKey()

        'Declaración de Array
        Dim miArray() As String = {"Antonio", "Francisco", "Juan"}

        'Mostramos el valor en la consola
        Console.WriteLine(miArray(1))
        Console.Read()
    End Sub
End Module
