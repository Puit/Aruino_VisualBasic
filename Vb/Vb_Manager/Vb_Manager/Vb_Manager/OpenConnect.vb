Imports System.IO
Imports System.IO.Ports
Imports System.Threading

Public Class OpenConnect

    Shared _continue As Boolean


    '***************************** SUBRUTINES AND FUNCTIONS ******************

    Private Sub btConnect_Click(sender As System.Object, e As System.EventArgs) Handles btConnect.Click
        Dim respuesta As String
        Dim str As String
        Dim values(6) As String
        Dim names(6) As String

        names = {"DY", "MH", "YR", "HR", "MN", "SC"}

        Try
            mainMenu.serialport = New SerialPort()

            mainMenu.serialport.PortName = lblPort.Text   'sets up vb for communicating
            'mainMenu.serialport.BaudRate = 19200 
            mainMenu.serialport.BaudRate = 9600

            mainMenu.serialport.Encoding = System.Text.Encoding.Default
            mainMenu.serialport.ReadTimeout = 5000
            mainMenu.serialport.WriteTimeout = 5000
            mainMenu.serialport.Open()
            mainMenu.serialport.Write("#CONNECT$@#")  'arduino board command for upload on restart
            respuesta = mainMenu.serialport.ReadLine()
            txtState.Text = respuesta
            If respuesta.Contains("ACK-ON") Then
                Me.Online.FillColor = Color.Green
                Me.lblState.Text = "ConnectionState ON"
                mainMenu.PcMenu.Image = My.Resources._on

                Dim subitem As ToolStripMenuItem
                subitem = mainMenu.MenuMDI.Items.Item(3)
                subitem.DropDownItems.Item(1).Enabled = True
                subitem = mainMenu.MenuMDI.Items.Item(3)
                subitem.DropDownItems.Item(2).Enabled = False
                MsgBox("Connection have been extablished whit " & lblPort.Text, 64)

                'Start Sincronitation phase
                mainMenu.Conect = True
                str = Sincronize()
                values = Split(str, ",")
                For i = 0 To 5 Step 1
                    str = "#TIME$" & names(i) & "@" & values(i) & "#"
                    mainMenu.serialport.Write(str)
                    System.Threading.Thread.Sleep(700) 'Si no el posem, l'arduino es perd
                Next
                'Threading.ThreadPool.QueueUserWorkItem(AddressOf Tancar)
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message) 'cant connect to port
        End Try

    End Sub
    Private Sub Tancar()
        Dim respuesta As String


        While mainMenu.Conect = True
            respuesta = mainMenu.serialport.ReadLine()

            If respuesta.Contains("ACK-OFF") Then
                mainMenu.serialport.Close()
                txtState.Text = respuesta
                mainMenu.PcMenu.Image = My.Resources.off

                Dim subitem As ToolStripMenuItem
                subitem = mainMenu.MenuMDI.Items.Item(3)
                subitem.DropDownItems.Item(1).Enabled = False
                subitem = mainMenu.MenuMDI.Items.Item(3)
                subitem.DropDownItems.Item(2).Enabled = True

                MsgBox("Connection have been closed", 64)
                mainMenu.Conect = False
            End If


        End While


    End Sub


    Private Sub lstPorts_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstPorts.SelectedIndexChanged
        lblPort.Text = lstPorts.SelectedItem
        lstPorts.Visible = False
    End Sub

    Private Sub btPorts_Click(sender As System.Object, e As System.EventArgs) Handles btPorts.Click
        ' Show all available COM ports.
        lstPorts.Visible = True
        lstPorts.Items.Clear()

        For Each sp As String In My.Computer.Ports.SerialPortNames
            lstPorts.Items.Add(sp)
        Next
    End Sub

    Private Function Sincronize() As String
        Dim data As Integer
        Dim str As String
        str = ""
        data = Microsoft.VisualBasic.DateAndTime.Day(Now)
        str = str & data & ","
        data = Microsoft.VisualBasic.DateAndTime.Month(Now)
        str = str & data & ","
        data = Microsoft.VisualBasic.DateAndTime.Year(Now)
        str = str & data & ","
        data = Microsoft.VisualBasic.DateAndTime.Hour(Now)
        str = str & data & ","
        data = Microsoft.VisualBasic.DateAndTime.Minute(Now)
        str = str & data & ","
        data = Microsoft.VisualBasic.DateAndTime.Second(Now)
        str = str & data & ","
        Sincronize = str
    End Function
End Class
