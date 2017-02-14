Imports System.Net



Public Class Client
    Dim connection As Boolean = False
    Dim TCPClientz As Sockets.TcpClient
    Dim TCPClientStream As Sockets.NetworkStream

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim sendbytes() As Byte = System.Text.Encoding.ASCII.GetBytes(txtSend.Text)
        TCPClientz.Client.Send(sendbytes)
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        TCPClientz = New Sockets.TcpClient(txtIP.Text, 1000) 'Change port here
        TimerRec.Enabled = True
        TCPClientStream = TCPClientz.GetStream()
        grpCnct.Visible = False
        connection = True
    End Sub

    Private Sub TimerRec_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRec.Tick

        If TCPClientStream.DataAvailable = True Then
            Dim rcvbytes(TCPClientz.ReceiveBufferSize) As Byte
            TCPClientStream.Read(rcvbytes, 0, CInt(TCPClientz.ReceiveBufferSize))
            txtRec.Text = System.Text.Encoding.ASCII.GetString(rcvbytes)
        End If

    End Sub

    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIP.Text = "192.168.1.105"
    End Sub

    Private Sub keyEvent(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim sendbytes() As Byte
        If connection = True Then
            If e.KeyCode = Keys.Left Then
                sendbytes = System.Text.Encoding.ASCII.GetBytes("left")
                TCPClientz.Client.Send(sendbytes)
            ElseIf e.KeyCode = Keys.Right Then
                sendbytes = System.Text.Encoding.ASCII.GetBytes("right")
                TCPClientz.Client.Send(sendbytes)
            ElseIf e.KeyCode = Keys.Up Then
                sendbytes = System.Text.Encoding.ASCII.GetBytes("up")
                TCPClientz.Client.Send(sendbytes)
            ElseIf e.KeyCode = Keys.Down Then
                sendbytes = System.Text.Encoding.ASCII.GetBytes("down")
                TCPClientz.Client.Send(sendbytes)
            End If
        End If
    End Sub
End Class