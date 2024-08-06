Imports Microsoft.VisualBasic


Module Program
    Sub Main()
        Dim L As Double
        Dim F As Double
        Dim XL As Double
        Console.WriteLine("ingrese el valor de la inductancia")
        L = Console.ReadLine()
        Console.WriteLine("ingrese el valor de la frecuencia")
        F = Console.ReadLine()
        XL = 2 * 3.14 * F * L
        Console.WriteLine("la reactancia inductiva es," & XL)
        Console.ReadLine()
    End Sub
End Module