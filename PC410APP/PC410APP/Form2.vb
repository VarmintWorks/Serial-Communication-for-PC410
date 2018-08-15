Imports System
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Form2
    Dim SeriesPV As New Series
    Dim seriesSV As New Series

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim ChartAreas1 As New ChartArea
        Chart1.ChartAreas.Clear()
        Chart1.Series.Clear()
        Chart1.ChartAreas.Add(ChartAreas1)
        Chart1.Series.Add(SeriesPV)
        Chart1.Series.Add(seriesSV)
        Chart1.ChartAreas(0).AxisX.Title = "时间(s)"
        Chart1.ChartAreas(0).AxisY.Title = "温度(℃)"
        SeriesPV.ChartType = SeriesChartType.Line
        SeriesPV.LegendText = "PV曲线"
        seriesSV.ChartType = SeriesChartType.Line
        seriesSV.LegendText = "SV曲线"
    End Sub
    '画PV曲线
    Public Sub PaintPV(ByVal i, ByVal j)
        SeriesPV.Points.AddXY(i, j)
    End Sub
    '画SV曲线
    Public Sub PaintSV(ByVal i, ByVal j)
        seriesSV.Points.AddXY(i, j)
    End Sub
End Class