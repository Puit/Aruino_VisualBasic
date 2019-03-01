Imports System.IO
Imports System.IO.Ports
Imports System.Threading

Public Class CloseConnect
    Shared _continue As Boolean
    Shared serialport As SerialPort

    Dim salida As Boolean
    Dim SelectedPin As Integer
    Dim Input As Boolean

    Delegate Sub SetCheckCallback([dat] As Boolean)
    Dim connection As Thread


    '***************************** SUBRUTINES AND FUNCTIONS ******************



    Private Sub btDisconnect_Click(sender As System.Object, e As System.EventArgs) Handles btDisconnect.Click
        Dim respuesta As String

        Try
            If mainMenu.serialport.IsOpen Then
                mainMenu.serialport.Write("#CLOSE$@#")  'arduino board command for upload on restart
                respuesta = mainMenu.serialport.ReadLine()
                txtState.Text = respuesta

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
                    Me.Close()

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message) 'cant connect to port
        End Try
    End Sub



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If mainMenu.Conect Then
            lblPort.Text = "You are going to close the follow port: " & mainMenu.serialport.PortName
        End If
    End Sub
End Class
