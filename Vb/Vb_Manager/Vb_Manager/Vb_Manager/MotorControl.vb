Public Class MotorControl


    Private Sub btClear_MouseEnter(sender As Object, e As System.EventArgs) Handles btClear.MouseEnter
        lblMsg.Text = "Clear the setup value from all inputs"
        lblMsg.Visible = True
    End Sub



    Private Sub btLoad_MouseEnter(sender As Object, e As System.EventArgs) Handles btLoad.MouseEnter
        lblMsg.Text = "Load setup from file"
        lblMsg.Visible = True
    End Sub


    Private Sub btSave_MouseEnter(sender As Object, e As System.EventArgs) Handles btSave.MouseEnter
        lblMsg.Text = "Save current setup to file"
        lblMsg.Visible = True
    End Sub


    Private Sub btSend_MouseEnter(sender As Object, e As System.EventArgs) Handles btSend.MouseEnter
        lblMsg.Text = "Send current setup to Arduino board"
        lblMsg.Visible = True
    End Sub

    Private Sub btClear_MouseLeave(sender As Object, e As System.EventArgs) Handles btClear.MouseLeave, btLoad.MouseLeave, btSave.MouseLeave, btSend.MouseLeave
        lblMsg.Text = ""
        lblMsg.Visible = False
    End Sub

    Private Sub rbt_On_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt_On.CheckedChanged

    End Sub

    Private Sub rbt_Off_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbt_Off.CheckedChanged

    End Sub

    Private Sub btLoad_Click(sender As System.Object, e As System.EventArgs) Handles btLoad.Click

    End Sub

    Private Sub txtBx_Temp_MouseHover(sender As Object, e As System.EventArgs) Handles txtBx_Temp.MouseHover
        lblMsg.Text = "Temperature at motors must activate"
        lblMsg.Visible = True
    End Sub

    Private Sub txtBx_Temp_MouseLeave(sender As Object, e As System.EventArgs) Handles txtBx_Temp.MouseLeave
        lblMsg.Text = ""
        lblMsg.Visible = False
    End Sub

    Private Sub lbl_Temp_MouseHover(sender As Object, e As System.EventArgs) Handles lbl_Temp.MouseHover
        lblMsg.Text = "Temperature at motors must activate"
        lblMsg.Visible = True
    End Sub

    Private Sub lbl_Temp_MouseLeave(sender As Object, e As System.EventArgs) Handles lbl_Temp.MouseLeave
        lblMsg.Text = ""
        lblMsg.Visible = False
    End Sub

    Private Sub lbl_C_MouseHover(sender As Object, e As System.EventArgs) Handles lbl_C.MouseHover
        lblMsg.Text = "Temperature at motors must activate"
        lblMsg.Visible = True
    End Sub

    Private Sub lbl_C_MouseLeave(sender As Object, e As System.EventArgs) Handles lbl_C.MouseLeave
        lblMsg.Text = ""
        lblMsg.Visible = False
    End Sub

    Private Sub Panel4_MouseHover(sender As Object, e As System.EventArgs) Handles Panel4.MouseHover
        lblMsg.Text = "Temperature at motors must activate"
        lblMsg.Visible = True
    End Sub

    Private Sub Panel4_MouseLeave(sender As Object, e As System.EventArgs) Handles Panel4.MouseLeave
        lblMsg.Text = ""
        lblMsg.Visible = False
    End Sub

    Private Sub Panel1_MouseHover(sender As Object, e As System.EventArgs) Handles Panel1.MouseHover
        lblMsg.Text = "Sets the motor ON of OFF"
        lblMsg.Visible = True
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As System.EventArgs) Handles Panel1.MouseLeave
        lblMsg.Text = ""
        lblMsg.Visible = False
    End Sub
End Class