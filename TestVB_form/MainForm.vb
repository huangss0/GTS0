Imports System.IO.Compression
Imports System.IO

Imports HssUtility.General

Public Class MainForm
    Private Sub gridButton_Click(sender As Object, e As EventArgs) Handles gridButton.Click
        Dim fm = New UltraGridForm()
        fm.Show()
    End Sub

    Private Sub ribbon_Button_Click(sender As Object, e As EventArgs) Handles ribbon_Button.Click
        Dim rf As RibbonForm = New RibbonForm()
        rf.Show()
    End Sub

    Private Sub zip_Button_Click(sender As Object, e As EventArgs) Handles zip_Button.Click
        Dim start_from_path As String = Nothing
        Dim zip_to_path As String = Me.zip_TextBox.Text

        Dim fbd As FolderBrowserDialog = New FolderBrowserDialog()
        If fbd.ShowDialog() = DialogResult.OK Then start_from_path = fbd.SelectedPath

        If Directory.Exists(start_from_path) Then
            ZipFile.CreateFromDirectory(start_from_path, zip_to_path, CompressionLevel.Fastest, False)
        Else
            MessageBox.Show("Folder:" + start_from_path + " not exist")
        End If
    End Sub

    Private Sub test_Button_Click(sender As Object, e As EventArgs) Handles test_Button.Click

    End Sub
End Class