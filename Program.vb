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

        Dim miArrayMulti(2, 2) As String
        miArrayMulti(0, 0) = "Antonio"
        miArrayMulti(0, 1) = "35"
        miArrayMulti(0, 2) = "65465321321"

        miArrayMulti(1, 0) = "Francisco"
        miArrayMulti(1, 1) = "30"
        miArrayMulti(1, 2) = "5654654"

        miArrayMulti(2, 0) = "Juan"
        miArrayMulti(2, 1) = "20"
        miArrayMulti(2, 2) = "0000000"

        'Mostramos el valor en la consola
        Console.WriteLine(miArrayMulti(2, 0) & " " &
            miArrayMulti(2, 1) & " " &
            miArrayMulti(2, 2))
        Console.ReadKey()
    End Sub
End Module
