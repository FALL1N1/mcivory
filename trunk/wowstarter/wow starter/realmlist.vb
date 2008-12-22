Imports System.IO

Public Class realmlist

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub schreibedaten()
        Dim writer As StreamWriter = New StreamWriter(My.Application.Info.DirectoryPath & "\Data\deDE\realmlist.wtf", False)

        writer.WriteLine("set realmlist " & TextBox2.Text)


        writer.Close()


    End Sub

    Private Sub ladedaten()
        Dim reader As StreamReader = New StreamReader(My.Application.Info.DirectoryPath & "\Data\deDE\realmlist.wtf")
        Dim zeile As String

        Try

            Do
                zeile = reader.ReadLine


                If Mid(zeile, 1, 14) = "set realmlist " Then
                    TextBox1.Text = Mid(zeile, 15)



                End If


            Loop Until reader.Peek = -1

        Catch ex As Exception

            MsgBox("keine Realmlist gefunden! Bitte überbrüfe ob der Starter im WoW Hauptordner ist")
        Finally
            reader.Close()

        End Try


    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Dir("Data\emGB\realmlist.wtf") <> "" Then
            Kill("Data\enGB\realmlist.wtf")
            FileOpen(1, "Data\enGB\realmlist.wtf", OpenMode.Append)
            Print(1, "set realmlist eu.logon.worldofwarcraft.com")
            PrintLine(1)
            Print(1, "set patchlist eu.version.worldofwarcraft.com")
            PrintLine(1)
            Print(1, "set portal eu")
            FileClose(1)
        End If
        If Dir("Data\deDE\realmlist.wtf") <> "" Then
            Kill("Data\deDE\realmlist.wtf")
            FileOpen(1, "Data\deDE\realmlist.wtf", OpenMode.Append)
            Print(1, "set realmlist eu.logon.worldofwarcraft.com")
            PrintLine(1)
            Print(1, "set patchlist eu.version.worldofwarcraft.com")
            PrintLine(1)
            Print(1, "set portal eu")
            FileClose(1)
        End If
        ladedaten()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Dir("Data\emGB\realmlist.wtf") <> "" Then
            Kill("Data\enGB\realmlist.wtf")
            FileOpen(1, "Data\enGB\realmlist.wtf", OpenMode.Append)
            Print(1, "set realmlist 87.106.178.113")
            PrintLine(1)
            Print(1, "set patchlist eu.version.worldofwarcraft.com")
            PrintLine(1)
            Print(1, "set portal eu")
            FileClose(1)
        End If
        If Dir("Data\deDE\realmlist.wtf") <> "" Then
            Kill("Data\deDE\realmlist.wtf")
            FileOpen(1, "Data\deDE\realmlist.wtf", OpenMode.Append)
            Print(1, "set realmlist 87.106.178.113")
            PrintLine(1)
            Print(1, "set patchlist eu.version.worldofwarcraft.com")
            PrintLine(1)
            Print(1, "set portal eu")
            FileClose(1)
        End If
        ladedaten()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ladedaten()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        schreibedaten()
        ladedaten()
    End Sub
End Class