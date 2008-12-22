Imports System.IO

Public Class start


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        realmlist.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Dim Programm As New System.Diagnostics.Process()
        Programm = New System.Diagnostics.Process()
        Programm.StartInfo.FileName = "firefox.exe"
        Programm.StartInfo.FileName = "iexplore.exe"
        Programm.StartInfo.Arguments = "http://www.ivory-online.de.tt"
        Programm.Start()
    End Sub

    Private Sub updatecheck()
        Try
            My.Computer.Network.DownloadFile("http://mcivory.mc.funpic.de/launcher/version.txt", "version.txt")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Update - Fehler")
        End Try
        If File.Exists("version.txt") Then
            Dim sr As StreamReader = New StreamReader("version.txt")

            Select Case sr.ReadLine().ToString()
                Case My.Application.Info.Version.ToString

                Case Else
                    If MsgBox("Es ist eine neue Version verfügbar!", MsgBoxStyle.Information, "updater - Launcher") = MsgBoxResult.Ok Then
                        If MsgBox("Möchten sie das Update ausführen?", MsgBoxStyle.YesNo, "updater - Launcher") = MsgBoxResult.Yes Then
                            My.Computer.Network.DownloadFile("http://mcivory.mc.funpic.de/launcher/updater.exe", "updater.exe")
                            Process.Start("updater.exe")
                            Me.Close()
                        End If
                    End If
            End Select
            sr.Close()
            File.Delete("version.txt")
        Else
            MsgBox("Resourcen für den Updater nicht verfügbar", MsgBoxStyle.Exclamation, "Launcher updater")
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Dir("Cache\WDB\enGB\*.*") <> "" Then
            Kill("Cache\WDB\enGB\*.*")
            MsgBox("Cache-Ordner erfolgreich gelöscht", vbExclamation)
        End If
        If Dir("Cache\WDB\deDE\*.*") <> "" Then
            Kill("Cache\WDB\deDE\*.*")
            MsgBox("Cache-Ordner erfolgreich gelöscht", vbExclamation)
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If File.Exists("Wow.exe") Then
            Shell("Wow.exe")
            Me.Close()
        Else
            MsgBox("Der wow-starter muss sich im World of Warcraft befinden!", MsgBoxStyle.Information, "Fehler")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If File.Exists("BackgroundDownloader.exe") Then

            Shell("BackgroundDownloader.exe")
            Me.Close()
        Else
            If MsgBox("der BackgroundDownloader wurde nicht gefunden, bitte lass deine repair.exe laufen!", MsgBoxStyle.Information, "Fehler") = MsgBoxResult.Ok Then
                If File.Exists("repair.exe") Then
                    Shell("repair.exe")
                    Me.Close()
                Else
                    MsgBox("Der wow-starter muss sich im World of Warcraft befinden!", MsgBoxStyle.Information, "Fehler")
                End If
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If File.Exists("updater.exe") Then
            File.Delete("updater.exe")
        End If
        If File.Exists("version.txt") Then
            File.Delete("version.txt")
        End If
        updatecheck()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        info.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        download.Show()
    End Sub

    Private Sub VersionsinfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        versioninfo.Show()
    End Sub

    Private Sub ErstellerInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErstellerInfoToolStripMenuItem.Click
        info.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        web.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        admin.Show()
    End Sub
    Private Sub mcdown()
        If MsgBox("McM Down was ist passiert, Wollt ihr es wissen?", MsgBoxStyle.YesNo, "McM down") = MsgBoxResult.Yes Then
            Form1.Show()
        End If
    End Sub
End Class