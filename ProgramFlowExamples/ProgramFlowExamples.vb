Option Explicit On
Option Strict On
Option Compare Text

Module ProgramFlowExamples

    Sub Main()
        'selectCaseExample()
        DoUntilExample()

        Console.ReadLine()
    End Sub

    'Sub selectCaseExample()
    '    Dim userInput As String = "Yabber"
    '    Dim userNumber As Integer
    '    Dim message As String

    ''examine or test a single variable
    'Select Case userInput
    '    Case "Q"
    '        Console.WriteLine("Are you sure you want to quit?")
    '    Case "X"
    '        Console.WriteLine("I found X!")
    '    Case Else
    '        Console.WriteLine($"You typed: {userInput}")
    'End Select

    'Do While userInput <> "Q"
    '    userInput = Console.ReadLine
    '    Try
    '        userNumber = CInt(userInput)
    '    Catch ex As Exception
    '        message = $"{userInput} is not a number"
    '    End Try

    '    Select Case userNumber
    '        Case < 0
    '            message = "Must be a negative Number"
    '        Case 0 To 3
    '            message = "Welcome to the Toddler Free Range!"
    '        Case 4 To 10
    '            message = "You must be at least this tall to ride"
    '        Case 11 To 50
    '            message = "If you need to spew, Spew in this..."
    '        Case > 65
    '            message = "Please sign this release of liability"
    '        Case Else
    '            MsgBox($"Uh not sure what to do with {userInput}")
    '    End Select
    '    Console.WriteLine(message)
    'Loop

    Sub DoUntilExample()

        Dim runAgain As Boolean = False
        Dim userInput As String

        Do
            Console.WriteLine("The thing happens")

            userInput = Console.ReadLine()

            Select Case userInput
                Case "Y"
                    runAgain = True
                Case "N"
                    runAgain = False
                Case Else
                    Console.WriteLine("I'll take that as a no...")
                    runAgain = False

            End Select

        Loop Until runAgain = False

    End Sub

End Module
