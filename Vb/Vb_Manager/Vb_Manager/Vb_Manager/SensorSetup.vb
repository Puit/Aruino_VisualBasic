Public Class SensorSetup

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        cbAnlg1.Checked = True
        cbAnlg2.Checked = True
        cbDig1.Checked = True
        txtAnlg1Pin.Text = "1"
        txtAnlg2Pin.Text = "2"
        txtDig1Pin.Text = "47"
    End Sub

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


    ' Control of pin setup 
    Private Sub cbAnlg1_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbAnlg1.CheckedChanged
        If cbAnlg1.Checked = True Then
            gpAnl1Alerts.Enabled = True
            txtAnlg1Pin.Enabled = True
        Else
            gpAnl1Alerts.Enabled = False
            txtAnlg1Pin.Enabled = False
        End If
    End Sub

    Private Sub cbAnlg1bet_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbAnlg1bet.CheckedChanged
        If cbAnlg1bet.Checked = True Then
            cbAnlg1min.Checked = False
            cbAnlg1max.Checked = False
        End If
    End Sub

    Private Sub cbAnlg1min_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbAnlg1min.CheckedChanged
        If cbAnlg1min.Checked = True Then
            cbAnlg1bet.Checked = False
        End If
    End Sub

    Private Sub cbAnlg1max_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbAnlg1max.CheckedChanged
        If cbAnlg1max.Checked = True Then
            cbAnlg1bet.Checked = False
        End If
    End Sub


    Private Sub cbAnlg2_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbAnlg2.CheckedChanged
        If cbAnlg2.Checked = True Then
            gpAnl2Alerts.Enabled = True
            txtAnlg2Pin.Enabled = True
        Else
            gpAnl2Alerts.Enabled = False
            txtAnlg2Pin.Enabled = False
        End If
    End Sub


    Private Sub cbAnlg2bet_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbAnlg2bet.CheckedChanged
        If cbAnlg2bet.Checked = True Then
            cbAnlg2min.Checked = False
            cbAnlg2max.Checked = False
        End If
    End Sub

    Private Sub cbAnlg2min_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbAnlg2min.CheckedChanged
        If cbAnlg2min.Checked = True Then
            cbAnlg2bet.Checked = False
        End If
    End Sub

    Private Sub cbAnlg2max_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbAnlg2max.CheckedChanged
        If cbAnlg2max.Checked = True Then
            cbAnlg2bet.Checked = False
        End If
    End Sub

    Private Sub cbDig1_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbDig1.CheckedChanged
        If cbDig1.Checked = True Then
            txtDig1Pin.Enabled = True
        Else
            txtDig1Pin.Enabled = False
        End If
    End Sub


    'Buttons control.....

    Private Sub btClear_Click(sender As System.Object, e As System.EventArgs) Handles btClear.Click
        cbAnlg1.Checked = False
        cbAnlg1min.Checked = False
        cbAnlg1bet.Checked = False
        cbAnlg1max.Checked = False
        txtAnlg1min.Text = ""
        txtAnlg1max.Text = ""
        txtAnlg1Pin.Text = ""

        cbAnlg2.Checked = False
        cbAnlg2min.Checked = False
        cbAnlg2bet.Checked = False
        cbAnlg2max.Checked = False
        txtAnlg2min.Text = ""
        txtAnlg2max.Text = ""
        txtAnlg2Pin.Text = ""

        cbDig1.Checked = False
        txtDig1Pin.Text = ""

    End Sub

    Private Function checkSetupIntegrity() As Boolean
        Dim result As Boolean

        result = True
        'check for the first analog input
        If cbAnlg1.Checked = True And Not IsNumeric(txtAnlg1Pin.Text) Then
            result = False
            MsgBox("ERROR - analog 1 pin incorrect", 16)
            checkSetupIntegrity = result
            Exit Function
        End If

        If cbAnlg1.Checked = True And cbAnlg1min.Checked = True And Not IsNumeric(txtAnlg1min.Text) Then
            result = False
            MsgBox("ERROR - analog 1 alert minim value incorrect", 16)
            checkSetupIntegrity = result
            Exit Function
        End If

        If cbAnlg1.Checked = True And cbAnlg1max.Checked = True And Not IsNumeric(txtAnlg1max.Text) Then
            result = False
            MsgBox("ERROR - analog 1 alert max value incorrect", 16)
            checkSetupIntegrity = result
            Exit Function
        End If

        If cbAnlg1.Checked = True And cbAnlg1bet.Checked = True Then
            If Not IsNumeric(txtAnlg1min.Text) Or Not IsNumeric(txtAnlg1max.Text) Then
                result = False
                MsgBox("ERROR - analog 1 alert between values incorrects", 16)
                checkSetupIntegrity = result
                Exit Function
            End If
        End If
        'check for the second analog input
        If cbAnlg2.Checked = True And Not IsNumeric(txtAnlg2Pin.Text) Then
            result = False
            MsgBox("ERROR - analog 2 pin incorrect", 16)
            checkSetupIntegrity = result
            Exit Function
        End If

        If cbAnlg2.Checked = True And cbAnlg2min.Checked = True And Not IsNumeric(txtAnlg2min.Text) Then
            result = False
            MsgBox("ERROR - analog 2 alert minim value incorrect", 16)
            checkSetupIntegrity = result
            Exit Function
        End If

        If cbAnlg2.Checked = True And cbAnlg2max.Checked = True And Not IsNumeric(txtAnlg2max.Text) Then
            result = False
            MsgBox("ERROR - analog 1 alert max value incorrect", 16)
            checkSetupIntegrity = result
            Exit Function
        End If

        If cbAnlg2.Checked = True And cbAnlg2bet.Checked = True Then
            If Not IsNumeric(txtAnlg2min.Text) Or Not IsNumeric(txtAnlg2max.Text) Then
                result = False
                MsgBox("ERROR - analog 2 alert between values incorrects", 16)
                checkSetupIntegrity = result
                Exit Function
            End If
            If CInt(txtAnlg2min.Text) > CInt(txtAnlg2max.Text) Then
                result = False
                MsgBox("ERROR - analog 2 alert minimum is bigger than maximum", 16)
                checkSetupIntegrity = result
                Exit Function
            End If
        End If

        'check for the Digital input
        If cbDig1.Checked = True And Not IsNumeric(txtDig1Pin.Text) Then
            result = False
            MsgBox("ERROR - digital 1 pin incorrect", 16)
            checkSetupIntegrity = result
            Exit Function
        End If
        checkSetupIntegrity = result
    End Function


    ' Convert the setup to the correct estructure for the main aplication
    Private Sub SetupToStructure()
        If cbAnlg1.Checked = True Then
            mainMenu.Setup.A1.enable = True
            mainMenu.Setup.A1.pin = CInt(txtAnlg1Pin.Text)
            If Not cbAnlg1min.Checked And Not cbAnlg1bet.Checked And Not cbAnlg1max.Checked Then
                mainMenu.Setup.A1.alert = "NONE"
                mainMenu.Setup.A1.min = -1
                mainMenu.Setup.A1.max = -1
            ElseIf cbAnlg1bet.Checked Then
                mainMenu.Setup.A1.alert = "IN"
                mainMenu.Setup.A1.min = CInt(txtAnlg1min.Text)
                mainMenu.Setup.A1.max = CInt(txtAnlg1max.Text)
            ElseIf cbAnlg1min.Checked And Not cbAnlg1max.Checked Then
                mainMenu.Setup.A1.alert = "LOWER"
                mainMenu.Setup.A1.min = CInt(txtAnlg1min.Text)
                mainMenu.Setup.A1.max = -1
            ElseIf Not cbAnlg1min.Checked And cbAnlg1max.Checked Then
                mainMenu.Setup.A1.alert = "HIGHER"
                mainMenu.Setup.A1.min = -1
                mainMenu.Setup.A1.max = CInt(txtAnlg1max.Text)
            Else
                mainMenu.Setup.A1.alert = "OUT"
                mainMenu.Setup.A1.min = CInt(txtAnlg1min.Text)
                mainMenu.Setup.A1.max = CInt(txtAnlg1max.Text)
            End If
        End If
        If cbAnlg2.Checked = True Then
            mainMenu.Setup.A2.enable = True
            mainMenu.Setup.A2.pin = CInt(txtAnlg1Pin.Text)
            If Not cbAnlg2min.Checked And Not cbAnlg2bet.Checked And Not cbAnlg2max.Checked Then
                mainMenu.Setup.A2.alert = "NONE"
                mainMenu.Setup.A2.min = -1
                mainMenu.Setup.A2.max = -1
            ElseIf cbAnlg2bet.Checked Then
                mainMenu.Setup.A2.alert = "IN"
                mainMenu.Setup.A2.min = CInt(txtAnlg2min.Text)
                mainMenu.Setup.A2.max = CInt(txtAnlg2max.Text)
            ElseIf cbAnlg2min.Checked And Not cbAnlg2max.Checked Then
                mainMenu.Setup.A2.alert = "LOWER"
                mainMenu.Setup.A2.min = CInt(txtAnlg2min.Text)
                mainMenu.Setup.A2.max = -1
            ElseIf Not cbAnlg2min.Checked And cbAnlg2max.Checked Then
                mainMenu.Setup.A2.alert = "HIGHER"
                mainMenu.Setup.A2.min = -1
                mainMenu.Setup.A2.max = CInt(txtAnlg2max.Text)
            Else
                mainMenu.Setup.A2.alert = "OUT"
                mainMenu.Setup.A2.min = CInt(txtAnlg2min.Text)
                mainMenu.Setup.A2.max = CInt(txtAnlg2max.Text)
            End If
        End If
        If cbDig1.Checked = True Then
            mainMenu.Setup.D1.enable = True
            mainMenu.Setup.D1.pin = CInt(txtDig1Pin.Text)
        End If
    End Sub


    ' Convert the setup structure to string
    Private Function StructureToString() As String

        Dim str As String

        str = ""

        If mainMenu.Setup.A1.enable Then
            str = str & "ANALOG1: " & CStr(mainMenu.Setup.A1.pin) & vbCrLf
            str = str & vbTab & "ALERT: " & mainMenu.Setup.A1.alert & vbCrLf
            If mainMenu.Setup.A1.min <> -1 Then
                str = str & vbTab & vbTab & "min: " & CStr(mainMenu.Setup.A1.min) & vbCrLf
            End If
            If mainMenu.Setup.A1.max <> -1 Then
                str = str & vbTab & vbTab & "max: " & CStr(mainMenu.Setup.A1.max) & vbCrLf
            End If
        End If

        If mainMenu.Setup.A2.enable Then
            str = str & "ANALOG2: " & CStr(mainMenu.Setup.A2.pin) & vbCrLf
            str = str & vbTab & "ALERT: " & mainMenu.Setup.A2.alert & vbCrLf
            If mainMenu.Setup.A2.min <> -1 Then
                str = str & vbTab & vbTab & "min: " & CStr(mainMenu.Setup.A2.min) & vbCrLf
            End If
            If mainMenu.Setup.A2.max <> -1 Then
                str = str & vbTab & vbTab & "max: " & CStr(mainMenu.Setup.A2.max) & vbCrLf
            End If
        End If

        If mainMenu.Setup.D1.enable Then
            str = str & "DIGITAL1: " & CStr(mainMenu.Setup.D1.pin) & vbCrLf
        End If

        StructureToString = str

    End Function

    Private Sub btSend_Click(sender As System.Object, e As System.EventArgs) Handles btSend.Click

        If checkSetupIntegrity() = True Then
            SetupToStructure()
            MsgBox(StructureToString(), 64, "SENSOR SETUP")
        End If
        

    End Sub

    Private Sub btSave_Click(sender As System.Object, e As System.EventArgs) Handles btSave.Click

    End Sub

    Private Sub btLoad_Click(sender As System.Object, e As System.EventArgs) Handles btLoad.Click

    End Sub


End Class