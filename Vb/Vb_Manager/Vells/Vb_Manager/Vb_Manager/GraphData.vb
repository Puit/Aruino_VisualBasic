Public Class GraphData

    Friend A1_id As Boolean
    Friend A2_id As Boolean
    Friend D1_id As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        A1_id = False
        A2_id = False
        D1_id = False


    End Sub



    Private Sub btGraph_Click(sender As System.Object, e As System.EventArgs) Handles btA1id.Click
        A1_id = Not A1_id
        D1_id = False
        DrawGraph()
    End Sub

    Private Sub btA2id_Click(sender As System.Object, e As System.EventArgs) Handles btA2id.Click
        A2_id = Not A2_id
        D1_id = False
        DrawGraph()
    End Sub

    Private Sub btD1id_Click(sender As System.Object, e As System.EventArgs) Handles btD1id.Click
        D1_id = Not D1_id
        A2_id = False
        A1_id = False
        DrawGraph()
    End Sub



    Private Sub DrawGraph()
        Dim i As Integer
        Dim x As String
        Dim y As String

        chr.Series.Clear()
        If A1_id Then
            chr.Series.Add("A1")
            chr.Series("A1").Color = Color.Green
            chr.Series("A1").ChartType = DataVisualization.Charting.SeriesChartType.Line
            i = 0
            chr.Series("A1").Points.AddXY("0", "0")
            Do While mainMenu.AdqList(i).id <> 0
                x = CStr(mainMenu.AdqList(i).id)
                y = CStr(CInt(mainMenu.AdqList(i).A1))
                chr.Series("A1").Points.AddXY(x, y)
                i = i + 1
            Loop
        End If

        If A2_id Then
            chr.Series.Add("A2")
            chr.Series("A2").Color = Color.Red
            chr.Series("A2").ChartType = DataVisualization.Charting.SeriesChartType.Line
            i = 0
            chr.Series("A2").Points.AddXY("0", "0")
            Do While mainMenu.AdqList(i).id <> 0
                x = CStr(mainMenu.AdqList(i).id)
                y = CStr(CInt(mainMenu.AdqList(i).A2))
                chr.Series("A2").Points.AddXY(x, y)
                i = i + 1
            Loop
        End If

        If D1_id Then
            chr.Series.Add("D1")
            chr.Series("D1").Color = Color.Red
            chr.Series("D1").ChartType = DataVisualization.Charting.SeriesChartType.Line
            i = 0
            chr.Series("D1").Points.AddXY("0", "0")
            Do While mainMenu.AdqList(i).id <> 0
                x = CStr(mainMenu.AdqList(i).id)
                y = CStr(mainMenu.AdqList(i).D1)
                chr.Series("D1").Points.AddXY(x, y)
                i = i + 1
            Loop
        End If


    End Sub


End Class