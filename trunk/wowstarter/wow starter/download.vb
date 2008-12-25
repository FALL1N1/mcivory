Imports System.IO

Public Class download

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        start.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Try
            My.Computer.Network.DownloadFile("http://mcivory.mc.funpic.de/launcher/InstallWoW_de.exe", "InstallWoW_de.exe")
            If MsgBox("der Download war erfolgreich. Möchten sie jetzt mit dem installieren beginnen?", MsgBoxStyle.YesNo, "Download WoWinstaller") = MsgBoxResult.Yes Then
                Shell("InstallWoW_de.exe")
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            If MsgBox("Möchten sie den Install Starten?", MsgBoxStyle.YesNo, "Download WoWinstaller") = MsgBoxResult.Yes Then
                Shell("InstallWoW_de.exe")
                Me.Close()
            End If
        End Try

        


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            My.Computer.Network.DownloadFile("http://mcivory.mc.funpic.de/launcher/InstallWoW_en.exe", "InstallWoW_en.exe")

            If MsgBox("der Download war erfolgreich. Möchten sie jetzt mit dem installlieren beginnen?", MsgBoxStyle.YesNo, "Download WoWinstaller") = MsgBoxResult.Yes Then
                Shell("InstallWoW_en.exe")
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            If MsgBox("Möchten sie den Install Starten?", MsgBoxStyle.YesNo, "Download WoWinstaller") = MsgBoxResult.Yes Then
                Shell("InstallWoW_de.exe")
                Me.Close()
            End If
        End Try




    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Try
            My.Computer.Network.DownloadFile("http://dl99.chip.de/download/d4dbc83a0a6238a3e46b7c7b5e344d45/495412be/3063466/ts2_client_rc2_2032.exe", "ts_install.exe")
            If MsgBox("der Download war erfolgreich. Möchten sie jetzt mit dem installieren beginnen?", MsgBoxStyle.YesNo, "Download Teamspeak Installer") = MsgBoxResult.Yes Then
                Shell("ts_install.exe")
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            If MsgBox("Möchten sie den Install Starten?", MsgBoxStyle.YesNo, "Download WoWinstaller") = MsgBoxResult.Yes Then
                Shell("InstallWoW_de.exe")
                Me.Close()
            End If
        End Try




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