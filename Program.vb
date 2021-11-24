Imports System.Threading
Imports System.Console
Imports Microsoft.VisualBasic.CompilerServices

Module Program
    Dim PlayerCard1 As Integer
    Dim PlayerCard2 As Integer
    Dim PlayerTotal As Integer
    Dim PlayerExtra As Integer
    Dim BankCard1 As Integer
    Dim BankCard2 As Integer
    Dim BankExtra As Integer
    Dim BankTotal As Integer
    Dim Random As New Random
    Dim Playing As Char = "y"
    Dim Balance As Integer = 50
    Dim countdown As Integer
    Dim Bet As Integer
    Dim CanTwist As Boolean = True
    Dim PictureCard As Boolean

    Private Function Namecard(ByVal CardNumber As Integer) As String
        Dim cardname As String
        Select Case CardNumber
            Case 1
                cardname = "Ace"
            Case 11
                cardname = "Jack"
            Case 12
                cardname = "King"
            Case 13
                cardname = "Queen"
            Case Else
                cardname = CardNumber
        End Select
        Return cardname
    End Function
    Sub Main(args As String())


        While Playing = "y"
            WriteLine("Pontoon")
            WriteLine("-------")

            WriteLine("Your bank balance: £" & Balance)
            WriteLine("How much do you want to bet?")
            Bet = ReadLine()
            Title = False
            PlayerCard1 = Random.Next(1, 14)
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

            PlayerCard2 = Random.Next(1, 14)
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
            BankCard1 = Random.Next(1, 14)
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

            PlayerCard2 = Random.Next(1, 14)
            Thread.Sleep(1500)
            Clear()


            BankCard2 = Random.Next(1, 14)
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
            WriteLine("Your total: " & PlayerTotal)
            BankTotal = BankCard1 + BankCard2
            WriteLine("Bank's cards total to " & BankTotal & " .")
            Thread.Sleep(1000)
            If Random.Next(1, 3) = 2 And PlayerTotal > BankTotal Then 'Bank has 1/2 chance of twisting if bank is losing
                WriteLine("Banker twisted!")
                BankExtra = Random.Next(1, 14)
                WriteLine("Choosing a extra card for the banker...")
                Thread.Sleep(3000)
                WriteLine("Banker got card " & BankExtra & " !")
                WriteLine("Your total: " & PlayerTotal)
                BankTotal = BankTotal + BankExtra
                WriteLine("Bank total: " & BankTotal)

                If BankTotal > 21 Then
                    WriteLine("Banker bust! You win.")
                    BankTotal = 0
                End If
            Else
                WriteLine("Banker did not twist!")
            End If

            If PlayerTotal + 11 > BankTotal Or BankTotal >= 21 Then
            Else

            End If

            If BankTotal >= PlayerTotal And CanTwist = True Then
                WriteLine("Would you like to twist? (y/n)")
                If ReadLine() = "y" Then
                    WriteLine("Twisting...")
                    Thread.Sleep(5000)
                    PlayerExtra = Random.Next(1, 14)
                    WriteLine("You got " & PlayerExtra & " .")
                    PlayerTotal = PlayerTotal + PlayerExtra
                    WriteLine("Your new total: " & PlayerTotal)
                    WriteLine("Bank's Total: " & BankTotal)

                    If PlayerTotal > 21 Then
                        WriteLine("You bust! You lose.")
                        PlayerTotal = 0
                    End If
                    If BankTotal > 21 Then
                        WriteLine("Banker bust! You win.")
                        BankTotal = 0
                    End If
                End If

            Else
                WriteLine("You cannot twist as there really is no point. Trust me, I'm a computer.")
            End If
            WriteLine("Your total Is " & PlayerTotal)
            If PlayerTotal > 2000000000 Then
                WriteLine("Due to limitations with Visual Basic, we have stopped the program to avoid a crash.")
                WriteLine("Ending game...")
                WriteLine("You ended the game with " & PlayerTotal)
                End
            End If
            If BankTotal > 21 Then
                WriteLine("Banker bust! You win.")
                BankTotal = 0
            End If

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
                If Balance < 0 Then
                    WriteLine("You owe " & Balance & " to the game!")
                    WriteLine("if u no pay computer will take u 2 court")
                    WriteLine("Enter your card number below to pay the bank £" & Balance & " .")
                    ReadLine()
                    WriteLine("Enter your Security Number to prove your purchase.")
                    ReadLine()
                    WriteLine("Enter expiry date")
                    ReadLine()
                    WriteLine("Enter cardholder name")
                    ReadLine()
                    WriteLine("Done! You now owe the game £0.")
                    WriteLine("Your court appearance is the 12th October 2022 when Sam is 16")
                End If
                End
            End If
            countdown = 5
            Thread.Sleep(2500)
            Clear()
            WriteLine("You have £" & Balance)
            WriteLine("Would you Like to continue? (y/n)")
            Playing = ReadLine()









        End While
    End Sub
End Module
