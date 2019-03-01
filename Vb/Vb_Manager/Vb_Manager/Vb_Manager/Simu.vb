Public Class Simu


    Private Sub bt_StartSimu_Click(sender As System.Object, e As System.EventArgs) Handles bt_StartSimu.Click
        Dim nValues As Integer
        Dim DelaySimu As Integer

        Randomize()

        nValues = CInt(txt_NumAdq.Text)
        If nValues > 100 Then
            nValues = 100
            txt_NumAdq.Text = "100"
        End If
        pb_Progres.Maximum = nValues
        DelaySimu = CInt(txt_Delay.Text)

        For i = 0 To nValues - 1

            pb_Progres.Value = i + 1
            mainMenu.AdqList(i).id = i + 1
            mainMenu.AdqList(i).A1 = CInt(Rnd() * 10000) / 100
            mainMenu.AdqList(i).A2 = CInt(Rnd() * 10000) / 100
            If CInt(Rnd() * 10000) / 100 > 50 Then
                mainMenu.AdqList(i).D1 = 0
            Else
                mainMenu.AdqList(i).D1 = 1
            End If

            mainMenu.AdqList(i).T = TimeString
            System.Threading.Thread.Sleep(DelaySimu * 1000)

        Next
        MsgBox("data generated")
        Me.Close()
    End Sub

End Class