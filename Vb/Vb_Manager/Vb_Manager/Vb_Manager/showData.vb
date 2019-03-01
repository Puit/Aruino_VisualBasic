Public Class showData

    Private Sub btAll_Click(sender As System.Object, e As System.EventArgs) Handles btAll.Click
        txtShow.Text = mainMenu.DataToString()
    End Sub



End Class