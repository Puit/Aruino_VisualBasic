Imports System
Imports System.IO
Imports System.Text

Public Class LoadFile
    Dim path As String

    Private Sub btPath_Click(sender As System.Object, e As System.EventArgs) Handles btPath.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            path = FolderBrowserDialog1.SelectedPath
            lblPath.Text = path & "\" & txtName.Text & ".txt"
        End If
    End Sub

    Private Sub btSave_Click(sender As System.Object, e As System.EventArgs) Handles btLoad.Click

        Dim filename As String
        Dim result As Boolean
        Dim fileReader As String
        Dim words() As String

        filename = lblPath.Text
        result = True
        If Not (System.IO.File.Exists(lblPath.Text)) Then
            MsgBox("File don't exist")
        Else
            fileReader = My.Computer.FileSystem.ReadAllText(filename)
            MsgBox(fileReader)
            words = Split(fileReader, vbTab)

            txtResult.Text = ""
            For i = 0 To words.GetUpperBound(0)
                txtResult.Text = txtResult.Text & words(i) & vbCrLf
            Next

        End If
    End Sub

    Private Sub btCancel_Click(sender As System.Object, e As System.EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As System.EventArgs) Handles txtName.TextChanged
        lblPath.Text = path & "\" & txtName.Text & ".txt"
    End Sub


End Class