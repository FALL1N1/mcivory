Public Class info

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Dim Programm As New System.Diagnostics.Process()
        Programm = New System.Diagnostics.Process()
        Programm.StartInfo.FileName = "firefox.exe"
        Programm.StartInfo.FileName = "iexplore.exe"
        Programm.StartInfo.Arguments = "http://www.ivory-online.de.tt/"
        Programm.Start()
    End Sub

    Private Sub Label4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim Programm As New System.Diagnostics.Process()
        Programm = New System.Diagnostics.Process()
        Programm.StartInfo.FileName = "firefox.exe"
        Programm.StartInfo.FileName = "iexplore.exe"
        Programm.StartInfo.Arguments = "http://www.mcmultigaming.de/"
        Programm.Start()
    End Sub
End Class