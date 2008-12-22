Imports System.IO

Public Class download

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If File.Exists("InstallWoW_de.exe") Then
            If MsgBox("der Installer ist schon vorhanden möchten sie nun mit dem Instalieren beginnen?", MsgBoxStyle.YesNo, "Downloader vorhanden") = MsgBoxResult.Yes Then
                Shell("InstallWoW_de.exe")
                Me.Close()
            Else

                Try
                    My.Computer.Network.DownloadFile("http://system.mcmultigaming.de/~a_ivory/downloads/de/InstallWoW.exe", "InstallWoW_de.exe")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                If File.Exists("InstallWoW_de.exe") Then
                    If MsgBox("der Download war erfolgreich. Möchten sie jetzt mit dem installieren beginnen?", MsgBoxStyle.YesNo, "Download WoWinstaller") = MsgBoxResult.Yes Then
                        Shell("InstallWoW_de.exe")
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If File.Exists("InstallWoW_en.exe") Then
            If MsgBox("der Installer ist schon vorhanden möchten sie nun mit dem Instalieren beginnen?", MsgBoxStyle.YesNo, "Downloader vorhanden") = MsgBoxResult.Yes Then
                Shell("InstallWoW_en.exe")
                Me.Close()
            Else

                Try
                    My.Computer.Network.DownloadFile("http://system.mcmultigaming.de/~a_ivory/downloads/en/InstallWoW.exe", "InstallWoW_en.exe")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                If File.Exists("InstallWoW_en.exe") Then
                    If MsgBox("der Download war erfolgreich. Möchten sie jetzt mit dem installlieren beginnen?", MsgBoxStyle.YesNo, "Download WoWinstaller") = MsgBoxResult.Yes Then
                        Shell("InstallWoW_en.exe")
                        Me.Close()
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If File.Exists("ts_install.exe") Then
            If MsgBox("der Installer ist schon vorhanden möchten sie nun mit dem Instalieren beginnen?", MsgBoxStyle.YesNo, "Downloader vorhanden") = MsgBoxResult.Yes Then
                Shell("ts_install.exe")
                Me.Close()
            Else

                Try
                    My.Computer.Network.DownloadFile("http://system.mcmultigaming.de/~a_ivory/downloads/ts2_client_rc2_2032.exe", "ts_install.exe")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                If File.Exists("ts_install.exe") Then
                    If MsgBox("der Download war erfolgreich. Möchten sie jetzt mit dem installieren beginnen?", MsgBoxStyle.YesNo, "Download Teamspeak Installer") = MsgBoxResult.Yes Then
                        Shell("ts_install.exe")
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MsgBox("möchten sie alle Install.exen löschen?", MsgBoxStyle.YesNo, "löschen") = MsgBoxResult.Yes Then
            If File.Exists("InstallWoW_de.exe") Then
                File.Delete("InstallWoW_de.exe")
                MsgBox("InstallWoW_de.exe wurde erfolgreich gelöschst", MsgBoxStyle.Information)
                If File.Exists("InstallWoW_en.exe") Then
                    File.Delete("InstallWoW_en.exe")
                    MsgBox("InstallWoW_en.exe wurde erfolgreich gelöschst", MsgBoxStyle.Information)
                    If File.Exists("ts_install.exe") Then
                        File.Delete("ts_install.exe")
                        MsgBox("ts_install.exe wurde erfolgreich gelöschst", MsgBoxStyle.Information)
                    Else
                        MsgBox("keine Datei gefunden!", MsgBoxStyle.Information, "Fehler")
                    End If
                End If
            End If
        End If
    End Sub
End Class