Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim soucet As Integer = 0

        Console.WriteLine("Zadej èíslo:")
        cislo = Console.ReadLine

        For x = 0 To cislo Step 1 + Math.Sign(cislo)
            soucet = soucet + x
        Next

        Console.WriteLine($"Souèet èísel od 1 do {cislo} je {soucet}")

    End Sub
End Module
