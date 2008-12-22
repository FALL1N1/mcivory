Imports System.IO

Module Module1

    Sub Main()
        System.Console.WriteLine("Update wird ausgeführt....")
        If File.Exists("tmp.exe") Then
            File.Delete("tmp.exe")
        End If


        Try
            My.Computer.Network.DownloadFile("http://mcivory.mc.funpic.de/launcher/wow-starter.exe", "tmp.exe")
            System.Console.WriteLine("Update wurde erfolgreich durchgeführt")
        Catch ex As Exception
            System.Console.WriteLine(ex.Message)
        End Try
        If File.Exists("wow-starter.exe") Then
            File.Delete("wow-starter")
            File.Copy("tmp.exe", "wow-starter.exe")
            File.Delete("tmp.exe")
        Else
            File.Copy("tmp.exe", "wow-starter.exe")
            File.Delete("tmp.exe")
        End If
        System.Console.Read()
        If File.Exists("wow-starter.exe") Then
            Process.Start("wow-starter.exe")
        End If
    End Sub

End Module
