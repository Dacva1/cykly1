Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim pocet As Integer = 0

        Do
            Console.WriteLine("Zadej èíslo:")
            cislo = Console.ReadLine
            pocet = pocet + 1
            Console.WriteLine($"Zadané èíslo je: {cislo}")
        Loop Until pocet < 10

    End Sub
End Module
