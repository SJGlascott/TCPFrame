Public Class Start

    Private Sub btnHost_Click(sender As Object, e As EventArgs) Handles btnHost.Click
        Dim server As New Server
        server.Show()
        'Me.Hide()

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim client As New Client
        client.Show()
    End Sub
End Class
