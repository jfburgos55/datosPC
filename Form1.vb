Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add(My.Computer.Name.ToString)
        ListBox1.Items.Add(My.Computer.Network.IsAvailable())
        ListBox1.Items.Add(My.Computer.Info.OSFullName.ToString)
        ListBox1.Items.Add(My.Computer.Info.InstalledUICulture.ToString)
        Dim a As Single = (My.Computer.Info.TotalPhysicalMemory / 1024)
        ListBox1.Items.Add(Format(a, "###, ###, ###") + " Megabytes")
        ListBox1.Items.Add(My.Computer.Info.OSPlatform.ToString)
    End Sub
End Class
