Imports System.Threading
Imports System.Console
Imports Microsoft.VisualBasic.CompilerServices

Module Program
    Dim PlayerCard1 As Integer
    Dim PlayerCard2 As Integer
    Dim PlayerTotal As Integer
    Dim BankCard1 As Integer
    Dim BankCard2 As Integer
    Dim BankExtra As Integer
    Dim BankTotal As Integer
    Dim Random As New Random
    Dim Playing As Char = "y"
    Dim Balance As Integer = 50
    Dim countdown As Integer
    Dim Bet As Integer
    Sub Main(args As String())
        While Playing = "y"
            WriteLine("Welcome to the Pontoon Game!")
            WriteLine("------- -- --- ------- -----")
            WriteLine("Your bank balance: £" & Balance)
            WriteLine("How much do you want to bet?")
            Bet = ReadLine()
            PlayerCard1 = Random.Next(1, 12)
            Thread.Sleep(1000)
            Clear()
            For i = 1 To 3
                WriteLine("Your 1st Card: .")
                WriteLine("Your 2nd Card: ???")
                Thread.Sleep(500)
                Clear()
                WriteLine("Your 1st Card: ..")
                WriteLine("Your 2nd Card: ???")
                Thread.Sleep(500)
                Clear()
                WriteLine("Your 1st Card: ...")
                WriteLine("Your 2nd Card: ???")
                Thread.Sleep(500)
                Clear()
            Next
            WriteLine("Your 1st Card: " & PlayerCard1)
            WriteLine("Your 2nd Card: ???")

            PlayerCard2 = Random.Next(1, 12)
            Clear()
            Thread.Sleep(50)
            For i = 1 To 3
                WriteLine("Your 1st Card: " & PlayerCard1)
                WriteLine("Your 2nd Card: .")
                Thread.Sleep(500)
                Clear()
                WriteLine("Your 1st Card: " & PlayerCard1)
                WriteLine("Your 2nd Card: ..")
                Thread.Sleep(500)
                Clear()
                WriteLine("Your 1st Card: " & PlayerCard1)
                WriteLine("Your 2nd Card: ...")
                Thread.Sleep(500)
                Clear()
            Next
            WriteLine("Your 1st Card: " & PlayerCard1)
            WriteLine("Your 2nd Card: " & PlayerCard2)
            Thread.Sleep(1000)
            PlayerTotal = PlayerCard1 + PlayerCard2
            WriteLine("Your cards total to " & PlayerTotal & " .")


            Thread.Sleep(3000)
            Clear()
            BankCard1 = Random.Next(1, 12)
            For i = 1 To 3
                WriteLine("Bank's 1st Card: .")
                WriteLine("Bank's 2nd Card: ???")
                Thread.Sleep(500)
                Clear()
                WriteLine("Bank's 1st Card: ..")
                WriteLine("Bank's 2nd Card: ???")
                Thread.Sleep(500)
                Clear()
                WriteLine("Bank's 1st Card: ...")
                WriteLine("Bank's 2nd Card: ???")
                Thread.Sleep(500)
                Clear()
            Next
            WriteLine("Bank's 1st Card: " & BankCard1)
            WriteLine("Bank's 2nd Card: ???")

            PlayerCard2 = Random.Next(1, 12)
            Thread.Sleep(1500)
            Clear()


            BankCard2 = Random.Next(1, 12)
            For i = 1 To 3
                WriteLine("Bank's 1st Card: " & BankCard1)
                WriteLine("Bank's 2nd Card: .")
                Thread.Sleep(500)
                Clear()
                WriteLine("Bank's 1st Card: " & BankCard1)
                WriteLine("Bank's 2nd Card: ..")
                Thread.Sleep(500)
                Clear()
                WriteLine("Bank's 1st Card: " & BankCard1)
                WriteLine("Bank's 2nd Card: ...")
                Thread.Sleep(500)
                Clear()
            Next
            WriteLine("Bank's 1st Card: " & BankCard1)
            WriteLine("Bank's 2nd Card: " & BankCard2)
            Thread.Sleep(1000)
            BankTotal = BankCard1 + BankCard2
            WriteLine("Bank's cards total to " & BankTotal & " .")
            If Random.Next(1, 3) = 5 And PlayerTotal > BankTotal Then 'Bank has 1/2 chance of twisting if bank is losing
                WriteLine("Banker twisted!")
                BankExtra = Random.Next(1, 12)
                WriteLine("Banker got card " & BankExtra & " !")
                BankTotal = BankTotal + BankExtra

                If BankTotal > 21 Then
                    WriteLine("Banker is bust! You win.")
                    BankTotal = 0
                End If
            Else
                WriteLine("Banker did not twist!")
            End If
            WriteLine("Your total Is " & PlayerTotal)
            If BankTotal >= PlayerTotal Then
                WriteLine("You lost.")
                Balance = Balance - Bet
            Else
                WriteLine("You won!")
                Balance = Balance + Bet
            End If

            WriteLine("You now have £" & Balance)
            If Balance <= 0 Then
                WriteLine("You ran out of money! Game over.")
                End
            End If
            countdown = 5
            Thread.Sleep(2500)
            Clear()
            WriteLine("You have £" & Balance)
            WriteLine("Would you Like to continue? (y/n)")
            Thread.Sleep(5000)
            Playing = ReadLine()









        End While
    End Sub
End Module
