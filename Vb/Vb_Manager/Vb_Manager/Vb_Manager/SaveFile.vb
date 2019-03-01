Imports System
Imports System.IO
Imports System.Text

Public Class SaveFile
    Dim path As String

    Private Sub btPath_Click(sender As System.Object, e As System.EventArgs) Handles btPath.Click

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            path = FolderBrowserDialog1.SelectedPath
            lblPath.Text = path & "\" & txtName.Text & ".txt"
        End If
    End Sub

    Private Sub btSave_Click(sender As System.Object, e As System.EventArgs) Handles btSave.Click

        Dim filename As String
        Dim result As Integer
        Dim exist As Boolean
        Dim str As String

        filename = lblPath.Text
        exist = False

        If System.IO.File.Exists(lblPath.Text) Then
            result = MsgBox("The file file exists, do you want to continue?", MsgBoxStyle.DefaultButton2 Or _
                     MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "CONFIRMATION MSG")
            exist = True
        End If

        If (Not exist) Or (result = System.Windows.Forms.DialogResult.Yes) Then

            str = mainMenu.DataToString()

            My.Computer.FileSystem.WriteAllText(filename, str, False)

            MsgBox("The file has been saved")
            Me.Close()
        Else
            MsgBox("Change name and continue")
        End If

    End Sub

    Private Sub btCancel_Click(sender As System.Object, e As System.EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As System.EventArgs) Handles txtName.TextChanged
        lblPath.Text = path & "\" & txtName.Text & ".txt"
    End Sub


End Class