Imports System.Windows.Forms
Imports System.IO
Imports System.IO.Ports
Imports System.Threading

Public Class mainMenu

    Structure Adq
        Dim id As Integer
        Dim A1 As Double
        Dim A2 As Double
        Dim D1 As Integer
        Dim T As String
    End Structure

    Structure AnalogPinSetup
        Dim enable As Boolean
        Dim pin As Integer
        Dim alert As String
        Dim min As String
        Dim max As String
    End Structure

    Structure DigitalPinSetup
        Dim enable As Boolean
        Dim pin As Integer
    End Structure

    Structure SensorConfigutaion
        Dim A1 As AnalogPinSetup
        Dim A2 As AnalogPinSetup
        Dim D1 As DigitalPinSetup
    End Structure

    Friend serialport As SerialPort
    Friend indexPort As Integer

    Friend AdqList(100) As Adq
    Friend DelaySimu As Integer
    Friend Setup As SensorConfigutaion

    Friend Conect As Boolean = False

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        indexPort = 0
        PcMenu.Image = My.Resources.off
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub LaodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadFile.MdiParent = Me
        m_ChildFormNumber += 1
        LoadFile.Text = "LOAD"
        LoadFile.Show()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        SaveFile.MdiParent = Me
        m_ChildFormNumber += 1
        SaveFile.Text = "SAVE"
        SaveFile.Show()
    End Sub



    ' Personal function
    Friend Function DataToString() As String
        Dim i As Integer
        Dim str As String

        str = "Adquire" & vbCrLf & "─────────────────" & vbCrLf
        str = str & "Id"
        str = str & vbTab & "A1"
        str = str & vbTab & "A2"
        str = str & vbTab & "D1"
        str = str & vbTab & "Time" & vbCrLf

        i = 0
        Do While AdqList(i).id <> 0
            str = str & AdqList(i).id
            str = str & vbTab & AdqList(i).A1
            str = str & vbTab & AdqList(i).A2
            If AdqList(i).D1 = 1 Then
                str = str & vbTab & "ON"
            Else
                str = str & vbTab & "OFF"
            End If
            str = str & vbTab & AdqList(i).T & vbCrLf
            i = i + 1
        Loop
        DataToString = str
    End Function




    Private Sub NewConnectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewConnectionItem.Click
        Dim nW = New OpenConnect
        nW.MdiParent = Me
        m_ChildFormNumber += 1
        nW.Text = "OPEN CONNECTION"
        nW.Show()
    End Sub

    Private Sub CloseConnectionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseConnectionItem.Click
        Dim nW = New CloseConnect

        nW.MdiParent = Me
        m_ChildFormNumber += 1
        nW.Text = "CLOSE CONNECTION"
        nW.Show()
    End Sub


    Private Sub SimulateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SimulateItem.Click
        Simu.MdiParent = Me
        m_ChildFormNumber += 1
        Simu.Text = "SIMULATE"
        Simu.Show()
    End Sub


    Private Sub SetupItem_Click(sender As System.Object, e As System.EventArgs) Handles SetupItem.Click

        SensorSetup.MdiParent = Me
        m_ChildFormNumber += 1
        SensorSetup.Text = "SENSOR SETUP"
        SensorSetup.Show()
    End Sub

    Private Sub MotorControlToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MotorControlToolStripMenuItem.Click
        MotorControl.MdiParent = Me
        m_ChildFormNumber += 1
        MotorControl.Text = "MOTOR CONTROL"
        MotorControl.Show()
    End Sub

    Private Sub ShowDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowDataToolStripMenuItem.Click
        Dim nW = New showData

        nW.MdiParent = Me
        m_ChildFormNumber += 1
        nW.Text = "SHOW DATA"
        nW.Show()
    End Sub

    Private Sub GraphDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GraphDataToolStripMenuItem.Click
        Dim nW = New GraphData

        nW.MdiParent = Me
        m_ChildFormNumber += 1
        nW.Text = "GRAPH DATA"
        nW.Show()
    End Sub

    Private Sub ManualCMDToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ManualCMDToolStripMenuItem.Click
        Dim nW = New ManualCMD
        nW.MdiParent = Me
        m_ChildFormNumber += 1
        nW.Text = "SEND MANUAL COMMANDS"
        nW.Show()
    End Sub

    Private Sub PcMenu_Click(sender As System.Object, e As System.EventArgs) Handles PcMenu.Click
        Dim respuesta As String

        Try
            If Conect Then
                serialport.Write("#CLOSE$@#")  'arduino board command for upload on restart
                respuesta = serialport.ReadLine()

                If respuesta.Contains("ACK-OFF") Then
                    serialport.Close()
                    PcMenu.Image = My.Resources.off

                    Dim subitem As ToolStripMenuItem
                    subitem = MenuMDI.Items.Item(3)
                    subitem.DropDownItems.Item(1).Enabled = False
                    subitem = MenuMDI.Items.Item(3)
                    subitem.DropDownItems.Item(2).Enabled = True

                    MsgBox("Connection have been closed", 64)
                    Conect = False

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message) 'cant connect to port
        End Try
    End Sub

    Private Sub FileMenu_Click(sender As System.Object, e As System.EventArgs) Handles FileMenu.Click

    End Sub

    Private Sub AwningControlToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AwningControlToolStripMenuItem.Click
        AwningControl.MdiParent = Me
        m_ChildFormNumber += 1
        AwningControl.Text = "AWNING CONTROL"
        AwningControl.Show()
    End Sub

    Private Sub AdquireItem_Click(sender As System.Object, e As System.EventArgs) Handles AdquireItem.Click
        Dim answer As String
        serialport.Write("#ADQUIRE$@#")
        answer = serialport.ReadLine()
        '= Split(answer, ",")

    End Sub
End Class
