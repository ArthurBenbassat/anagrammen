Module Module1
    Dim woord, letter(99), tijdelijk, random, prima As String
    Private rnd As New Random()
    Sub Main()
        Console.Write("Geef een woord: ")
        woord = Console.ReadLine()

        For teller As Integer = 0 To woord.Length - 1
            letter(teller) = woord.Substring(teller, 1)
        Next

        tijdelijk = woord.Length - 1
        If tijdelijk < 4 Then
            Console.Write("Dit woord bevat te weinig caraters")
        Else
            For teller As Integer = 0 To 10
                For teller2 As Integer = 0 To tijdelijk
                    Dim j As Int32
                    Dim temp As String

                    For n As Int32 = woord.Length - 1 To 0 Step -1
                        j = rnd.Next(0, n + 1)

                        temp = letter(n)
                        letter(n) = letter(j)
                        letter(j) = temp
                    Next n
                Next
                For teller2 As Integer = 0 To tijdelijk
                    prima &= letter(teller2)
                Next
                Console.WriteLine(prima)
                prima = ""
            Next

        End If

        Console.ReadLine()
    End Sub
End Module
