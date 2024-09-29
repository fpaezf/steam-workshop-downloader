Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If WorkShopID.Text = "" Or AppID.Text = "" Or DownloadFolder.Text = "" Then
            MsgBox("Please fill all fields!", vbExclamation, "Missing parameters")
            Exit Sub
        End If

        If Not IO.File.Exists(IO.Path.Combine(Application.StartupPath, "steamcmd.exe")) Then
            MsgBox("Steamcmd.exe not found!", vbExclamation, "Missing file")
            Exit Sub
        End If

        Dim cmd As String = "+force_install_dir """ & DownloadFolder.Text & """ +login anonymous +workshop_download_item " & AppID.Text & " " & WorkShopID.Text
        If CloseSteamCMD.Checked = True Then
            cmd = cmd & " +quit"
        End If

        Try
            Dim DownloadProcess As Process = Process.Start(IO.Path.Combine(Application.StartupPath, "steamcmd.exe"), cmd)
            DownloadProcess.WaitForExit()
        Catch ex As Exception
            MsgBox("Error starting SteamCMD: " & vbCrLf & vbCrLf & ex.Message, vbCritical, "Error")
            Exit Sub
        End Try


        If OpenFolderAfterDownload.Checked = True Then
            Try
                Process.Start(IO.Path.Combine(DownloadFolder.Text, "steamapps", "workshop", "content", AppID.Text, WorkShopID.Text))
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FLDdlg As New FolderBrowserDialog
        FLDdlg.ShowNewFolderButton = True
        If FLDdlg.ShowDialog() = DialogResult.OK Then
            DownloadFolder.Text = FLDdlg.SelectedPath
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DownloadFolder.Text = My.Computer.FileSystem.SpecialDirectories.Desktop
    End Sub
End Class
