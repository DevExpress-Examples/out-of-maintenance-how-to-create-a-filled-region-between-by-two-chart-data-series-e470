Imports Microsoft.VisualBasic
Imports System
Namespace ChartFunctionTube
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (CObj(10))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (CObj(20))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (CObj(30))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (CObj(40))})
			Dim stackedAreaSeriesView1 As New DevExpress.XtraCharts.StackedAreaSeriesView()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (CObj(20))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (CObj(30))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (CObj(40))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (CObj(50))})
			Dim stackedAreaSeriesView2 As New DevExpress.XtraCharts.StackedAreaSeriesView()
			Dim pointSeriesLabel2 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (CObj(15))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (CObj(25))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (CObj(35))})
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (CObj(45))})
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedAreaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stackedAreaSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Location = New System.Drawing.Point(15, 15)
			Me.chartControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.chartControl1.Name = "chartControl1"
			series1.Name = "Series 2"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4})
			stackedAreaSeriesView1.Color = System.Drawing.Color.Transparent
			series1.View = stackedAreaSeriesView1
			pointSeriesLabel1.Visible = False
			series1.Label = pointSeriesLabel1
			series2.Name = "Series 3"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
			series2.View = stackedAreaSeriesView2
			pointSeriesLabel2.Visible = False
			series2.Label = pointSeriesLabel2
			series3.Name = "Series 1"
			series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12})
			series3.View = lineSeriesView1
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3}
			Me.chartControl1.SeriesTemplate.View = lineSeriesView2
			Me.chartControl1.Size = New System.Drawing.Size(869, 403)
			Me.chartControl1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(901, 634)
			Me.Controls.Add(Me.chartControl1)
			Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedAreaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stackedAreaSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

