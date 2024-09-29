<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WorkShopID = New System.Windows.Forms.TextBox()
        Me.AppID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DownloadFolder = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CloseSteamCMD = New System.Windows.Forms.CheckBox()
        Me.OpenFolderAfterDownload = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'WorkShopID
        '
        Me.WorkShopID.Location = New System.Drawing.Point(6, 16)
        Me.WorkShopID.Name = "WorkShopID"
        Me.WorkShopID.Size = New System.Drawing.Size(182, 20)
        Me.WorkShopID.TabIndex = 0
        '
        'AppID
        '
        Me.AppID.Location = New System.Drawing.Point(6, 18)
        Me.AppID.Name = "AppID"
        Me.AppID.Size = New System.Drawing.Size(114, 20)
        Me.AppID.TabIndex = 1
        Me.AppID.Text = "730"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.WorkShopID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 42)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Workshop item ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AppID)
        Me.GroupBox2.Location = New System.Drawing.Point(213, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(126, 44)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Application ID"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.DownloadFolder)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(327, 42)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Download folder"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(296, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 20)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DownloadFolder
        '
        Me.DownloadFolder.Location = New System.Drawing.Point(6, 16)
        Me.DownloadFolder.Name = "DownloadFolder"
        Me.DownloadFolder.ReadOnly = True
        Me.DownloadFolder.Size = New System.Drawing.Size(284, 20)
        Me.DownloadFolder.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(262, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 39)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Download"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CloseSteamCMD
        '
        Me.CloseSteamCMD.AutoSize = True
        Me.CloseSteamCMD.Checked = True
        Me.CloseSteamCMD.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CloseSteamCMD.Location = New System.Drawing.Point(12, 108)
        Me.CloseSteamCMD.Name = "CloseSteamCMD"
        Me.CloseSteamCMD.Size = New System.Drawing.Size(182, 17)
        Me.CloseSteamCMD.TabIndex = 5
        Me.CloseSteamCMD.Text = "Close SteamCMD after download"
        Me.CloseSteamCMD.UseVisualStyleBackColor = True
        '
        'OpenFolderAfterDownload
        '
        Me.OpenFolderAfterDownload.AutoSize = True
        Me.OpenFolderAfterDownload.Checked = True
        Me.OpenFolderAfterDownload.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OpenFolderAfterDownload.Location = New System.Drawing.Point(12, 131)
        Me.OpenFolderAfterDownload.Name = "OpenFolderAfterDownload"
        Me.OpenFolderAfterDownload.Size = New System.Drawing.Size(154, 17)
        Me.OpenFolderAfterDownload.TabIndex = 6
        Me.OpenFolderAfterDownload.Text = "Open folder after download"
        Me.OpenFolderAfterDownload.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 159)
        Me.Controls.Add(Me.OpenFolderAfterDownload)
        Me.Controls.Add(Me.CloseSteamCMD)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Steam Workshop downloader"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WorkShopID As TextBox
    Friend WithEvents AppID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DownloadFolder As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents CloseSteamCMD As CheckBox
    Friend WithEvents OpenFolderAfterDownload As CheckBox
End Class
