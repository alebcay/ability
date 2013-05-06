Imports System.Console

Module Module1

    Sub Main()
        Dim argc As Integer
        Dim argv As System.Collections.ObjectModel.ReadOnlyCollection(Of String)

        argv = My.Application.CommandLineArgs
        argc = argv.Count

        If argc > 0 AndAlso argv(0) = "?" Then
            Write("Ability v0.5")
            Write(Environment.NewLine & "USAGE:")
            Write(Environment.NewLine & "Install package (parameters given afterwards): 'ability install'")
            Write(Environment.NewLine & "Remove package: 'ability remove (parameters given afterwards): [package]'")
            End
        End If
        If argc > 0 AndAlso argv(0) = "install" Then
            Write(Environment.NewLine & "[1] Repository server address (do NOT end with a forward OR backward slash): ")
            Dim repo As String
            repo = Console.ReadLine
            ' Write(Environment.NewLine & "[3] Checking status of remote server")
            ' Try
            ' If My.Computer.Network.Ping(repo) Then
            ' Write(Environment.NewLine & "[3] Server response OK")
            ' Else
            ' Write(Environment.NewLine & "[2] Server did not respond in time or did not respond at all")
            ' End If
            ' Catch
            ' Write(Environment.NewLine & "[2] Unknown error")
            ' End
            ' End Try
            End
            ' Write(Environment.NewLine & "[3] Connection established successfully to " & repo)
            Write(Environment.NewLine & "[1] Package name: ")
            Dim package As String
            package = Console.ReadLine
            Write(Environment.NewLine & "[3] Creating installation directory")
            If My.Computer.FileSystem.DirectoryExists("C:\Ability\Packages\" & package) Then
                Write(Environment.NewLine & "[3] Package with the same name already exists, please remove it before continuing")
                End
            End If
            My.Computer.FileSystem.CreateDirectory("C:\Ability\Packages\" & package)
            Write(Environment.NewLine & "[3] Downloading installation package")
            Try
                My.Computer.Network.DownloadFile(repo & "/" & package & ".exe", "C:\Ability\Packages\" & package & ".exe")
            Catch ex As Exception
                Write(Environment.NewLine & "[2] Failed to download installation package")
                End
            End Try

            Write(Environment.NewLine & "[3] Downloading removal package")
            Try
                My.Computer.Network.DownloadFile(repo & "/" & package & ".rmv", "C:\Ability\Packages\" & package & ".rmv")
            Catch
                Write(Environment.NewLine & "[2] Failed to download removal package")
            End Try

        End If
    End Sub

End Module
