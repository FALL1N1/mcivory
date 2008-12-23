Imports MySql.Data
Imports MySql



Public Class bugtracker

    Private dbConnection As New MySqlClient.MySqlConnection
    Private dbCommand As New MySqlClient.MySqlCommand
    Private sql As String
    Private mysql As String
    Private dbConnected As Boolean = False

    Private Sub Connect(ByVal server As String, ByVal user As String, ByVal password As String, ByVal database As String)

        dbConnection.ConnectionString = _
        "server=" & server & ";" & "uid=" & user & ";" & "pwd=" & password & ";" & "database=" & database & ";"
        Try
            dbConnection.Open()
            dbConnected = True

        Catch ex As MySqlClient.MySqlException

            Select Case ex.Number

                Case 0
                    lblerrormessage.Text = My.Resources.ConError_2
                    dbConnected = False

                Case 1045
                    lblerrormessage.Text = My.Resources.ConError_1
                    dbConnected = False

            End Select

        End Try
    End Sub

    Private Sub bugtracker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect(My.Resources.server, My.Resources.user, My.Resources.password, My.Resources.database)
        If dbConnected Then
            With lblConnectionStatus

                .Text = "Connected"
                .ForeColor = Color.Green

            End With
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sendtiket()
    End Sub
    Private Function sendtiket() As Boolean

        Try

            dbCommand.Connection = dbConnection

            mysql = "INSERT INTO Bugtracker (Realm, Fehler, Name, Beschreibung) VALUES ('" & Servertyp.Text & " ', '" & fehlerart.Text & "', '" & fehlername.Text & "' , '" & beschreibung.Text & "' )"

            dbCommand.CommandText = mysql
            dbCommand.ExecuteNonQuery()

            MsgBox("Danke das du uns einen Bug mitgeteilt hast. Wir werden uns so schnell wie möglich drum kümmern", MsgBoxStyle.Information, "Danke fürs Bugmelden")

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString & vbCrLf)

        End Try
    End Function
End Class