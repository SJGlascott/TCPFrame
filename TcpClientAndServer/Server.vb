Imports System.Net
Imports System.Net.Sockets
Imports System.Threading


Public Class Server

    Dim TCPServer As Socket
    Dim TCPListenerz As TcpListener
    Dim Connection As Boolean = False

    Private Sub Main_Load(ByVal sender As System.Object, _
                ByVal e As System.EventArgs) Handles MyBase.Load
        Dim IPHost As IPHostEntry
        IPHost = Dns.GetHostByName(Dns.GetHostName())
        lblStatus.Text = "My IP address is " + _
        IPHost.AddressList(0).ToString()
        
    End Sub


    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    '    Dim sendbytes() As Byte = System.Text.Encoding.ASCII.GetBytes(txtSend.Text)
    '    TCPServer.Send(sendbytes)

    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        TCPListenerz = New TcpListener(IPAddress.Any, 1000) 'change port here
        TCPListenerz.Start()
        TCPServer = TCPListenerz.AcceptSocket()
        TCPServer.Blocking = False
        TimerRec.Enabled = True
        Connection = True
        grpCnct.Visible = False

    End Sub

    Private Sub TimerRec_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRec.Tick
        Dim recieved As String = ""
        Try
            Dim rcvbytes(TCPServer.ReceiveBufferSize) As Byte
            TCPServer.Receive(rcvbytes)
            recieved = System.Text.Encoding.ASCII.GetString(rcvbytes)
        Catch ex As Exception
        End Try

        Dim x As Integer = pbIcon.Location.X
        Dim y As Integer = pbIcon.Location.Y

        If recieved IsNot "" Then
            lbCommands.Items.Add(recieved)
        End If
        If recieved = "up" Then
            y = y - 25
        End If

        pbIcon.Location = New Point(x, y)
    End Sub

    Private Sub keyEvent(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim sendbytes() As Byte
        If Connection = True Then
            If e.KeyCode = Keys.Left Then
                sendbytes = System.Text.Encoding.ASCII.GetBytes("left")
                TCPServer.Send(sendbytes)
            ElseIf e.KeyCode = Keys.Right Then
                sendbytes = System.Text.Encoding.ASCII.GetBytes("right")
                TCPServer.Send(sendbytes)
            ElseIf e.KeyCode = Keys.Up Then
                sendbytes = System.Text.Encoding.ASCII.GetBytes("up")
                TCPServer.Send(sendbytes)
            ElseIf e.KeyCode = Keys.Down Then
                sendbytes = System.Text.Encoding.ASCII.GetBytes("down")
                TCPServer.Send(sendbytes)
            End If
        End If
    End Sub

End Class