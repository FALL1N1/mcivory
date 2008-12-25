Imports MySql.Data

Public Class adminbereich

    Private dbConnection As New MySqlClient.MySqlConnection
    Private dbCommand As New MySqlClient.MySqlCommand
    Private sql As String
    Private mysql As String
    Private dbConnected As Boolean = False
    Private Sub ladenreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ladenreport.Click
        MessageBox.Show(ladebug("bugtracker", "Beschreibung", 1))

    End Sub

    Private Function ladebug(ByVal table As String, ByVal row As String, ByVal Realm As Integer) As String

        Try

            dbCommand.Connection = dbConnection
            sql = "SELECT" & row & "FROM" & table & "WHERE Realm" & Realm
            dbCommand.CommandText = sql
            Return dbCommand.ExecuteScalar

        Catch ex As Exception

            Return ex.Message.ToString & vbCrLf

        End Try


    End Function
    Private Sub Connect(ByVal server As String, ByVal user As String, ByVal password As String, ByVal database As String)

        dbConnection.ConnectionString = _
        "server=" & server & ";" & "uid=" & user & ";" & "pwd=" & password & ";" & "database=" & database & ";"
        Try
            dbConnection.Open()
            dbConnected = True

        Catch ex As MySqlClient.MySqlException

            MessageBox.Show(ex.Message.ToString & vbCrLf)

        End Try
    End Sub

    Private Sub adminbereich_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect(My.Resources.server, My.Resources.user, My.Resources.password, My.Resources.database)
    End Sub
End Class