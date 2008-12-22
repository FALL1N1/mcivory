Imports MySql.Data

Public Class Form1

    Private dbConnection As New MySqlClient.MySqlConnection
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

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Connect(My.Resources.server, My.Resources.user, My.Resources.password, My.Resources.database)
        If dbConnected Then
            With lblConnectionStatus

                .Text = "Connected"
                .ForeColor = Color.Green

            End With
        End If
    End Sub
End Class
