Public Class About
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles AboutTitle.Click

    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles AboutYouTubeClick.Click
        Dim webAddress As String = "http://bit.ly/computersandstuff"
        Process.Start(webAddress)
    End Sub
End Class