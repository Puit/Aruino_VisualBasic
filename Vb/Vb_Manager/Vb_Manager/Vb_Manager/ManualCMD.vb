Public Class ManualCMD

    Private Sub txtCMD_TextChanged(sender As Object, e As System.EventArgs) Handles txtCMD.TextChanged, txtArg1.TextChanged, txtArg2.TextChanged
        lblMsg.Text = "#" & txtCMD.Text & "$" & txtArg1.Text & "@" & txtArg2.Text & "#"
        lblMsg.Text = UCase(lblMsg.Text)
    End Sub

    Private Sub btClear_Click(sender As System.Object, e As System.EventArgs) Handles btClear.Click
        lblMsg.Text = "#$@#"
        txtCMD.Text = ""
        txtArg1.Text = ""
        txtArg2.Text = ""
    End Sub

    Private Sub btSend_Click(sender As System.Object, e As System.EventArgs) Handles btSend.Click
        Dim answer As String
        Try

            If txtCMD.Text.Equals("CONNECT") Or txtCMD.Text.Equals("CLOSE") Then
                MsgBox("The command of connection and disconnection musn't be sended from here")
                'ElseIf txtCMD.Text.Equals("TIME") Then
                '    lstCMDs.Items.Insert(0, lblMsg.Text)
                '    mainMenu.serialport.Write(lblMsg.Text)
            Else
                lstCMDs.Items.Insert(0, lblMsg.Text)
                mainMenu.serialport.Write(lblMsg.Text)
                answer = mainMenu.serialport.ReadLine()
                txtAnswer.Text = answer

            End If
        Catch ex As Exception
            MsgBox(ex.Message) 'cant connect to port
        End Try




    End Sub

    Private Sub btClearHistory_Click(sender As System.Object, e As System.EventArgs) Handles btClearHistory.Click
        lstCMDs.Items.Clear()
    End Sub

    Private Sub lstCMDs_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles lstCMDs.SelectedValueChanged
        lblMsg.Text = lstCMDs.SelectedItem
    End Sub

End Class