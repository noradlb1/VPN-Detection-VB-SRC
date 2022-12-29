Imports System.Net.NetworkInformation

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NetworkInterface.GetIsNetworkAvailable() Then
            Dim interfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()

            For Each [Interface] As NetworkInterface In interfaces

                If [Interface].OperationalStatus = OperationalStatus.Up Then

                    If ([Interface].NetworkInterfaceType = NetworkInterfaceType.Ppp) AndAlso ([Interface].NetworkInterfaceType <> NetworkInterfaceType.Loopback) Then
                        Dim statistics As IPv4InterfaceStatistics = [Interface].GetIPv4Statistics()
                        'PictureBox1.Image = My.Resources.spoofer
                        MessageBox.Show([Interface].Name & " " + [Interface].NetworkInterfaceType.ToString() & " " + [Interface].Description)
                    Else
                        'PictureBox2.Image = My.Resources.al_jazeera_icon
                        'MessageBox.Show("VPN Connection is lost!")
                    End If
                End If
            Next
        End If
        Process.Start("https://discord.gg/r8FBRrAheE")
        Process.Start("https://t.me/MONSTERMCSY")
        Process.Start("https://www.youtube.com/channel/UC7ivSe-x-Epqs6WngpAMIIQ")
        Process.Start("https://github.com/noradlb1")
    End Sub
End Class
