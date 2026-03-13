Imports System

Module Program
    Sub Main(args As String())
        'Declaración de variable
        Dim miVariable As String = "Hola Mundo"

        'Mostramos el mensaje en consola
        Console.WriteLine(miVariable)
        Console.ReadKey()

        'Declaración de Array
        Dim miArray(2) As String
        miArray(0) = "Antonio"
        miArray(1) = "Francisco"
        miArray(2) = "Juan"

        ReDim Preserve miArray(3)
        miArray(3) = "Schiapparelli"
        'Mostramos el valor en la consola
        Console.WriteLine(miArray(3))
        Console.Read()
    End Sub
End Module
