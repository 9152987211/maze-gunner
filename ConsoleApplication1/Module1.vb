Module Module1

    Const width As Integer = 120
    Const height As Integer = 30
    Dim fullPath As String
    Dim mazeName As String
    Dim username As String = "Guest"
    Dim password As String


    Structure position
        Dim x As Integer
        Dim y As Integer
    End Structure
    Structure user
        Dim pos As position
        Dim health As Integer
        Dim dir As String
    End Structure

    Sub Main()

        'SETUP
        Console.WindowWidth = width
        Console.WindowHeight = height
        Console.Title = "Maze Gunner"

        Randomize() 'Generates a new random seed.
        resetConole()
        intro()
        startScreen()
        menu()

    End Sub
    Sub resetConole()

        Console.Clear()
        Console.SetCursorPosition(0, 0)
        Console.ForegroundColor = ConsoleColor.White
        Console.BackgroundColor = ConsoleColor.Black
        Console.CursorVisible = False

    End Sub
    Sub intro()

        Const introSpeed As Integer = 150 '(miliseconds)
        'Starting X and Y positions of the intro.
        Const x As Integer = 50
        Const y As Integer = 10

        resetConole()
        Threading.Thread.Sleep(introSpeed)
        Console.SetCursorPosition(x, y)
        Console.Write("A")
        Threading.Thread.Sleep(introSpeed)
        Console.SetCursorPosition(x + 1, y)
        Console.Write("d")
        Threading.Thread.Sleep(introSpeed)
        Console.SetCursorPosition(x + 2, y)
        Console.Write("a")
        Threading.Thread.Sleep(introSpeed)
        Console.SetCursorPosition(x + 3, y)
        Console.Write("m")
        Threading.Thread.Sleep(introSpeed)
        Console.SetCursorPosition(x + 4, y)
        Console.Write(" ")
        Threading.Thread.Sleep(introSpeed)
        Console.SetCursorPosition(x + 5, y)
        Console.Write("P")
        Threading.Thread.Sleep(introSpeed)
        Console.SetCursorPosition(x + 6, y)
        Console.Write("r")
        Threading.Thread.Sleep(introSpeed)
        Console.SetCursorPosition(x + 7, y)
        Console.Write("e")
        Threading.Thread.Sleep(introSpeed)
        Console.SetCursorPosition(x + 8, y)
        Console.Write("s")
        Threading.Thread.Sleep(introSpeed)
        Console.SetCursorPosition(x + 9, y)
        Console.Write("e")
        Threading.Thread.Sleep(introSpeed)
        Console.SetCursorPosition(x + 10, y)
        Console.Write("n")
        Threading.Thread.Sleep(introSpeed)
        Console.SetCursorPosition(x + 11, y)
        Console.Write("t")
        Threading.Thread.Sleep(introSpeed)
        Console.SetCursorPosition(x + 12, y)
        Console.Write("s")
        Threading.Thread.Sleep(introSpeed)

        Console.SetCursorPosition(x + 13, y)
        Console.Write(".")
        Threading.Thread.Sleep(introSpeed)
        Console.SetCursorPosition(x + 14, y)
        Console.Write(".")
        Threading.Thread.Sleep(introSpeed)
        Console.SetCursorPosition(x + 15, y)
        Console.Write(".")
        Threading.Thread.Sleep(introSpeed)

    End Sub
    Sub startScreen()


        resetConole()

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")

        Console.WriteLine("                                            ███▄ ▄███▓ ▄▄▄      ▒███████▒▓█████ ")
        Console.WriteLine("                                           ▓██▒▀█▀ ██▒▒████▄    ▒ ▒ ▒ ▄▀░▓█   ▀ ")
        Console.WriteLine("                                           ▓██    ▓██░▒██  ▀█▄  ░ ▒ ▄▀▒░ ▒███   ")
        Console.WriteLine("                                           ▒██    ▒██ ░██▄▄▄▄██   ▄▀▒   ░▒▓█  ▄ ")
        Console.WriteLine("                                           ▒██▒   ░██▒ ▓█   ▓██▒▒███████▒░▒████▒")
        Console.WriteLine("                                           ▒██▒   ░██▒ ▓█   ▓██▒▒███████▒░▒████▒")
        Console.WriteLine("                                           ░  ░      ░  ▒   ▒▒ ░░░▒ ▒ ░ ▒ ░ ░  ░")
        Console.WriteLine("                                           ░      ░     ░   ▒   ░ ░ ░ ░ ░   ░   ")
        Console.WriteLine("                                                  ░         ░  ░  ░ ░       ░  ░")
        Console.WriteLine("                                                                ░               ")

        Console.WriteLine("                                    ▄████  █    ██  ███▄    █  ███▄    █ ▓█████  ██▀███  ")
        Console.WriteLine("                                   ██▒ ▀█▒ ██  ▓██▒ ██ ▀█   █  ██ ▀█   █ ▓█   ▀ ▓██ ▒ ██▒")
        Console.WriteLine("                                  ▒██░▄▄▄░▓██  ▒██░▓██  ▀█ ██▒▓██  ▀█ ██▒▒███   ▓██ ░▄█ ▒")
        Console.WriteLine("                                  ░▓█  ██▓▓▓█  ░██░▓██▒  ▐▌██▒▓██▒  ▐▌██▒▒▓█  ▄ ▒██▀▀█▄  ")
        Console.WriteLine("                                  ░▒▓███▀▒▒▒█████▓ ▒██░   ▓██░▒██░   ▓██░░▒████▒░██▓ ▒██▒")
        Console.WriteLine("                                   ░▒   ▒ ░▒▓▒ ▒ ▒ ░ ▒░   ▒ ▒ ░ ▒░   ▒ ▒ ░░ ▒░ ░░ ▒▓ ░▒▓░")
        Console.WriteLine("                                    ░   ░ ░░▒░ ░ ░ ░ ░░   ░ ▒░░ ░░   ░ ▒░ ░ ░  ░  ░▒ ░ ▒░")
        Console.WriteLine("                                  ░ ░   ░  ░░░ ░ ░    ░   ░ ░    ░   ░ ░    ░     ░░   ░ ")
        Console.WriteLine("                                        ░    ░              ░          ░    ░  ░   ░     ")

        Console.ForegroundColor = ConsoleColor.Yellow
        Console.SetCursorPosition(51, 25)
        Console.Write("Press ENTER to Start")

        Console.ReadLine()


    End Sub
    Sub menu()

        Dim line As Integer = 1
        Dim colour(3) As ConsoleColor
        Dim x As Integer = 56
        Dim y As Integer = 10
        Dim key As ConsoleKey

        For i = 1 To 3
            colour(i) = ConsoleColor.Black
        Next
        colour(line) = ConsoleColor.DarkGray


        resetConole()


        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("                                                         MAIN MENU")


        Do
            Console.SetCursorPosition(x, y)
            Console.BackgroundColor = colour(1)
            Console.Write("PLAY [as " & username & "]")

            Console.SetCursorPosition(x, y + 2)
            Console.BackgroundColor = colour(2)
            Console.Write("LOGIN")

            Console.SetCursorPosition(x, y + 4)
            Console.BackgroundColor = colour(3)
            Console.Write("SIGN UP")

            Console.BackgroundColor = ConsoleColor.Black
            key = Console.ReadKey().Key

            If key = ConsoleKey.UpArrow And line > 1 Then
                colour(line) = ConsoleColor.Black
                line -= 1
                colour(line) = ConsoleColor.DarkGray
            ElseIf key = ConsoleKey.DownArrow And line < 3 Then
                colour(line) = ConsoleColor.Black
                line += 1
                colour(line) = ConsoleColor.DarkGray
            End If

            If key = ConsoleKey.Enter Then
                Select Case line
                    Case 1
                        chooseMap()
                    Case 2
                        login()
                    Case 3
                        signUp()
                End Select
            End If
        Loop


        Console.ReadLine()



    End Sub
    Sub signUp()

        Dim temp As String

        resetConole()
        Console.WriteLine()
        Console.WriteLine()
        Console.Write("        Enter in a username: ")
        temp = Console.ReadLine()

        If System.IO.File.Exists("Users/" & temp & ".txt") Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine()
            Console.WriteLine("         Invalid Username")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("   Press ENTER to Return to the Menu.")
            Console.ReadLine()
        Else
            username = temp
            Console.WriteLine()
            Console.Write("        Enter in a password: ")
            password = Console.ReadLine()

            Dim userFile As New System.IO.StreamWriter("Users/" & username & ".txt")
            userFile.WriteLine(password)
            userFile.Close()
        End If

        resetConole()
        menu()


    End Sub
    Sub login()

        Dim tempU As String
        Dim tempP As String

        resetConole()
        Console.WriteLine()
        Console.WriteLine()
        Console.Write("        Enter in your username: ")
        tempU = Console.ReadLine()

        If System.IO.File.Exists("Users/" & tempU & ".txt") Then
            Console.WriteLine()
            Console.Write("        Enter in your password: ")
            tempP = Console.ReadLine()
            Dim userFile As New System.IO.StreamReader("Users/" & tempU & ".txt")
            If tempP = userFile.ReadLine() Then
                password = tempP
                username = tempU
            Else
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine()
                Console.WriteLine("         Incorrect Password.")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("   Press ENTER to Return to the Menu.")
                Console.ReadLine()
            End If
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine()
            Console.WriteLine("         User Does Not Exist")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("   Press ENTER to Return to the Menu.")
            Console.ReadLine()
        End If

        resetConole()
        menu()


    End Sub
    Sub chooseMap()



        Dim name As String
        Dim valid As Boolean = False

        Do
            resetConole()
            Console.WriteLine()
            Console.WriteLine()
            Console.Write("         Enter the name of the maze [Without '.txt']: ")
            name = Console.ReadLine()

            If System.IO.File.Exists("mazes/" & name & ".txt") And UCase(name) <> "README" Then
                valid = True
            Else
                valid = False
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("        Invalid Maze Name.")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("        Press Enter to Try again.")
                Console.ReadLine()
            End If
        Loop Until valid

        fullPath = "mazes/" & name & ".txt"
        mazeName = name

        chooseStartingNumberOFEnemies()

    End Sub
    Sub chooseStartingNumberOFEnemies()

        resetConole()

        Dim num As Integer
        Dim temp
        Dim valid As Boolean = False

        Do
            resetConole()
            Console.WriteLine()
            Console.WriteLine()
            Console.Write("         Enter the Number of Enemies you Want to Start with: ")
            temp = Console.ReadLine()

            If IsNumeric(temp) Then
                If temp > 0 Then
                    valid = True
                Else
                    valid = False
                End If
            Else
                valid = False

            End If

            If Not valid Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("             Invalid Entry.")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("        Press Enter to Try again.")
                Console.ReadLine()
            End If

        Loop Until valid
        num = temp
        GameLoop(num)

    End Sub
    Sub GameLoop(ByVal numOfEnemies As Integer)

        Const enemyMoveSpeed As Integer = 400
        Dim startingNumberOfEnemies As Integer = numOfEnemies
        Dim enemy(startingNumberOfEnemies) As user
        Dim grid(90, 25) As Char
        Dim gameOver As Boolean = False
        Dim player As user
        Dim key As ConsoleKey
        Dim enemySpawnValid As Boolean = False
        Dim tempW As Integer
        Dim tempH As Integer
        Dim tempx(startingNumberOfEnemies) As Integer
        Dim tempy(startingNumberOfEnemies) As Integer
        Dim temphp(startingNumberOfEnemies) As Integer
        Dim enemyDir As Integer
        Dim loopCounter As Long = 0
        Dim shooting As Boolean = False
        Dim shootCounter As Long = True
        Dim bx As Integer
        Dim by As Integer
        Dim bd As String
        Dim bSpeed As Integer = 100
        Dim bulletOrientation As String
        Dim tempTimer As Decimal
        Dim aliveNumber As Integer
        Dim finalTimeTaken As Integer


        player.health = 100
        player.pos.x = 2
        player.pos.y = 2
        player.dir = "right"


        For i = 1 To startingNumberOfEnemies
            Do
                enemySpawnValid = False
                tempW = CInt(Rnd() * 70) + 2
                tempH = CInt(Rnd() * 22) + 2

                If grid(tempW, tempH) <> "#" Then
                    If tempW <> player.pos.x Or tempH <> player.pos.y Then
                        enemySpawnValid = True
                    End If
                End If
            Loop Until enemySpawnValid
            enemy(i).pos.x = tempW
            enemy(i).pos.y = tempH
            enemy(i).health = 100
        Next


        resetConole()
        loadMaze(grid)
        drawMaze(grid)


        Console.SetCursorPosition(97, 2)
        Console.Write("HEALTH: " & player.health)


        tempTimer = Timer()


        Do
            loopCounter += 1

            Console.ForegroundColor = ConsoleColor.White
            Console.SetCursorPosition(97, 4)
            Console.Write("  TIME: " & CInt(Timer() - tempTimer))

            If Console.KeyAvailable Then
                key = Console.ReadKey().Key

                If key = ConsoleKey.RightArrow Or key = ConsoleKey.D Then
                    If grid(player.pos.x + 1, player.pos.y) <> "#" Then
                        clearPlayer(player.pos.x, player.pos.y)
                        player.pos.x += 1
                        player.dir = "right"
                    End If

                ElseIf key = ConsoleKey.LeftArrow Or key = ConsoleKey.A Then
                    If grid(player.pos.x - 1, player.pos.y) <> "#" Then
                        clearPlayer(player.pos.x, player.pos.y)
                        player.pos.x -= 1
                        player.dir = "left"
                    End If

                ElseIf key = ConsoleKey.UpArrow Or key = ConsoleKey.W Then
                    If grid(player.pos.x, player.pos.y - 1) <> "#" Then
                        clearPlayer(player.pos.x, player.pos.y)
                        player.pos.y -= 1
                        player.dir = "up"
                    End If

                ElseIf key = ConsoleKey.DownArrow Or key = ConsoleKey.S Then
                    If grid(player.pos.x, player.pos.y + 1) <> "#" Then
                        clearPlayer(player.pos.x, player.pos.y)
                        player.pos.y += 1
                        player.dir = "down"
                    End If
                ElseIf key = ConsoleKey.Spacebar And shooting = False Then
                    shooting = True
                    shootCounter = 0
                    bx = player.pos.x
                    by = player.pos.y
                    bd = player.dir

                    If bd = "left" Or bd = "right" Then
                        bulletOrientation = "horizontal"
                    ElseIf bd = "up" Or bd = "down" Then
                        bulletOrientation = "vertical"
                    End If
                End If
            End If


            For i = 1 To startingNumberOfEnemies
                If enemy(i).health > 0 Then
                    If enemy(i).pos.x = player.pos.x And enemy(i).pos.y = player.pos.y Then
                        player.health -= 50
                        enemy(i).health = 0

                        Console.SetCursorPosition(97, 2)
                        Console.Write("           ")

                        Console.SetCursorPosition(97, 2)
                        Console.Write("HEALTH: " & player.health)

                    End If
                End If
            Next


            If shooting = True Then
                shootCounter += 1




                If shootCounter Mod bSpeed = 0 Then
                    For i = 1 To startingNumberOfEnemies
                        If enemy(i).health > 0 Then
                            If enemy(i).pos.x = bx And enemy(i).pos.y = by Then
                                enemy(i).health = 0
                                shooting = False
                            End If
                        End If
                    Next

                    clearPlayer(bx, by)

                    If shooting Then
                        Select Case bd
                            Case "up"

                                If grid(bx, by - 1) <> "#" Then
                                    by -= 1
                                Else
                                    shooting = False
                                End If

                            Case "down"

                                If grid(bx, by + 1) <> "#" Then
                                    by += 1
                                Else
                                    shooting = False
                                End If

                            Case "right"

                                If grid(bx + 1, by) <> "#" Then
                                    bx += 1
                                Else
                                    shooting = False
                                End If

                            Case "left"

                                If grid(bx - 1, by) <> "#" Then
                                    bx -= 1
                                Else
                                    shooting = False
                                End If

                        End Select
                    End If

                    If shooting Then
                        drawBulet(bx, by, bulletOrientation)
                    End If
                End If

            End If

            drawPlayer(player.pos.x, player.pos.y)
            For i = 1 To startingNumberOfEnemies
                tempx(i) = enemy(i).pos.x
                tempy(i) = enemy(i).pos.y
                temphp(i) = enemy(i).health
            Next
            drawEnemies(tempx, tempy, startingNumberOfEnemies, temphp)

            'Moving the enemies with inteligent AI:
            If loopCounter Mod enemyMoveSpeed = 0 Then
                For i = 1 To startingNumberOfEnemies
                    enemyDir = Rnd() * 100 '       0 = up, 1 = right, 2 = down, 3 = left.

                    If enemyDir < 27 Then
                        enemyDir = 0
                    ElseIf enemyDir >= 27 And enemyDir < 48 Then
                        enemyDir = 1
                    ElseIf enemyDir >= 48 And enemyDir < 70 Then
                        enemyDir = 2
                    ElseIf enemyDir >= 70 And enemyDir <= 100 Then
                        enemyDir = 3
                    End If


                    If enemyDir = 0 Then
                        If grid(enemy(i).pos.x, enemy(i).pos.y - 1) <> "#" Then
                            clearPlayer(enemy(i).pos.x, enemy(i).pos.y)
                            enemy(i).pos.y = enemy(i).pos.y - 1
                        End If

                    ElseIf enemyDir = 1 Then

                        If grid(enemy(i).pos.x + 1, enemy(i).pos.y) <> "#" Then
                            clearPlayer(enemy(i).pos.x, enemy(i).pos.y)
                            enemy(i).pos.x = enemy(i).pos.x + 1
                        End If

                    ElseIf enemyDir = 2 Then

                        If grid(enemy(i).pos.x, enemy(i).pos.y + 1) <> "#" Then
                            clearPlayer(enemy(i).pos.x, enemy(i).pos.y)
                            enemy(i).pos.y = enemy(i).pos.y + 1
                        End If

                    ElseIf enemyDir = 3 Then

                        If grid(enemy(i).pos.x - 1, enemy(i).pos.y) <> "#" Then
                            clearPlayer(enemy(i).pos.x, enemy(i).pos.y)
                            enemy(i).pos.x = enemy(i).pos.x - 1
                        End If

                    End If

                Next
            End If

            aliveNumber = 0
            For i = 1 To startingNumberOfEnemies
                If enemy(i).health > 0 Then
                    aliveNumber += 1
                End If
            Next

            If aliveNumber = 0 Then
                gameOver = True
            End If

            If player.health <= 0 Then
                gameOver = True
            End If

        Loop Until gameOver

        finalTimeTaken = CInt(Timer() - tempTimer)

        resetConole()

        If player.health > 0 Then
            GameOverScreen(finalTimeTaken, startingNumberOfEnemies)
        Else
            Died()
        End If


    End Sub
    Sub loadMaze(ByRef grid(,) As Char)


        Dim maze As New System.IO.StreamReader(fullPath)
        Dim line As String
        Dim temp As Char

        For j = 1 To 25
            line = maze.ReadLine()
            For i = 1 To 90
                temp = Mid(line, i, 1)
                grid(i, j) = temp
            Next
        Next

        maze.Close()


    End Sub
    Sub drawMaze(ByVal grid(,) As Char)

        Console.WriteLine()
        Console.WriteLine()
        For j = 1 To 25
            Console.Write("      ")
            For i = 1 To 90
                If grid(i, j) = "#" Then
                    Console.Write("█")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next

    End Sub
    Sub drawPlayer(ByVal x As Integer, ByVal y As Integer)

        Console.SetCursorPosition(x + 5, y + 1)
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.Write("█")
        resetCursor()

    End Sub
    Sub drawEnemies(ByVal x() As Integer, ByVal y() As Integer, ByRef n As Integer, ByVal hp() As Integer)

        Console.ForegroundColor = ConsoleColor.Red
        For i = 1 To n
            If hp(i) > 0 Then
                Console.SetCursorPosition(x(i) + 5, y(i) + 1)
                Console.Write("█")
            End If
        Next
        resetCursor()

    End Sub
    Sub drawBulet(ByVal x As Integer, ByVal y As Integer, ByVal o As String)

        Console.SetCursorPosition(x + 5, y + 1)
        Console.ForegroundColor = ConsoleColor.Yellow
        Select Case o
            Case "horizontal"
                Console.Write("─")
            Case "vertical"
                Console.Write("│")
        End Select
        resetCursor()

    End Sub
    Sub clearPlayer(ByVal x As Integer, ByVal y As Integer)

        Console.SetCursorPosition(x + 5, y + 1)
        Console.Write(" ")
        resetCursor()

    End Sub
    Sub GameOverScreen(ByVal timeTaken As Integer, ByVal num As Integer)


        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()

        Console.WriteLine("                       ██████╗ ██████╗ ███╗   ███╗██████╗ ██╗     ███████╗████████╗███████╗██████╗ ")
        Console.WriteLine("                      ██╔════╝██╔═══██╗████╗ ████║██╔══██╗██║     ██╔════╝╚══██╔══╝██╔════╝██╔══██╗")
        Console.WriteLine("                      ██║     ██║   ██║██╔████╔██║██████╔╝██║     █████╗     ██║   █████╗  ██║  ██║")
        Console.WriteLine("                      ██║     ██║   ██║██║╚██╔╝██║██╔═══╝ ██║     ██╔══╝     ██║   ██╔══╝  ██║  ██║")
        Console.WriteLine("                      ╚██████╗╚██████╔╝██║ ╚═╝ ██║██║     ███████╗███████╗   ██║   ███████╗██████╔╝")
        Console.WriteLine("                       ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝     ╚══════╝╚══════╝   ╚═╝   ╚══════╝╚═════╝ ")

        Console.ForegroundColor = ConsoleColor.White

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()

        Console.WriteLine("                                             YOUR TIME TAKEN WAS " & timeTaken & " SECONDS!")
        Console.WriteLine("                                                    ON MAP: " & mazeName)
        Console.WriteLine("                                                     WITH " & num & " ENEMIES")
        Console.WriteLine()
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("                                             Press ENTER to Return to the Menu")

        Console.ReadLine()

        menu()

    End Sub
    Sub Died()

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Red

        Console.WriteLine("    ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄       ▄▄  ▄▄▄▄▄▄▄▄▄▄▄      ▄▄▄▄▄▄▄▄▄▄▄  ▄               ▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄ ")
        Console.WriteLine("   ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌     ▐░░▌▐░░░░░░░░░░░▌    ▐░░░░░░░░░░░▌▐░▌             ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌")
        Console.WriteLine("   ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░▌░▌   ▐░▐░▌▐░█▀▀▀▀▀▀▀▀▀     ▐░█▀▀▀▀▀▀▀█░▌ ▐░▌           ▐░▌ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌")
        Console.WriteLine("   ▐░▌          ▐░▌       ▐░▌▐░▌▐░▌ ▐░▌▐░▌▐░▌              ▐░▌       ▐░▌  ▐░▌         ▐░▌  ▐░▌          ▐░▌       ▐░▌")
        Console.WriteLine("   ▐░▌ ▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄█░▌▐░▌ ▐░▐░▌ ▐░▌▐░█▄▄▄▄▄▄▄▄▄     ▐░▌       ▐░▌   ▐░▌       ▐░▌   ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄█░▌")
        Console.WriteLine("   ▐░▌▐░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌    ▐░▌       ▐░▌    ▐░▌     ▐░▌    ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌")
        Console.WriteLine("   ▐░▌ ▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░▌   ▀   ▐░▌▐░█▀▀▀▀▀▀▀▀▀     ▐░▌       ▐░▌     ▐░▌   ▐░▌     ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀█░█▀▀ ")
        Console.WriteLine("   ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░▌              ▐░▌       ▐░▌      ▐░▌ ▐░▌      ▐░▌          ▐░▌     ▐░▌  ")
        Console.WriteLine("   ▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄▄▄     ▐░█▄▄▄▄▄▄▄█░▌       ▐░▐░▌       ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌      ▐░▌ ")
        Console.WriteLine("   ▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌    ▐░░░░░░░░░░░▌        ▐░▌        ▐░░░░░░░░░░░▌▐░▌       ▐░▌")
        Console.WriteLine("    ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀  ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀      ▀▀▀▀▀▀▀▀▀▀▀          ▀          ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀ ")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("                                             Press ENTER to Return to the Menu")

        Console.ReadLine()

        menu()

    End Sub
    Sub resetCursor()

        Console.ForegroundColor = ConsoleColor.Black
        Console.SetCursorPosition(1, 28)

    End Sub

End Module
