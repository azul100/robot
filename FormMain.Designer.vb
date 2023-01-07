<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GaugeCircularScale1 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale()
        Dim GaugePointer1 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer()
        Dim GaugeRange1 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange()
        Dim GaugeSection1 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection()
        Dim GradientFillColor1 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor()
        Dim GradientFillColor2 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 255.0R)
        Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 0.0R)
        Me.TimerReceive = New System.Windows.Forms.Timer(Me.components)
        Me.TextBoxCh0 = New System.Windows.Forms.TextBox()
        Me.TextBoxCh1 = New System.Windows.Forms.TextBox()
        Me.LabelCh0 = New System.Windows.Forms.Label()
        Me.LabelCh1 = New System.Windows.Forms.Label()
        Me.ButtonSubscribe = New System.Windows.Forms.Button()
        Me.ButtonUnsubscribe = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GaugeControl1 = New DevComponents.Instrumentation.GaugeControl()
        Me.DigitalPanelMeterBlue1 = New MfgControl.AdvancedHMI.Controls.DigitalPanelMeterBlue()
        Me.KnobControl1 = New DevComponents.Instrumentation.KnobControl()
        Me.SelectorSwitch1 = New MfgControl.AdvancedHMI.Controls.SelectorSwitch()
        Me.PushButton1 = New MfgControl.AdvancedHMI.Controls.PushButton()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TimerCourbe = New System.Windows.Forms.Timer(Me.components)
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PilotLight1 = New MfgControl.AdvancedHMI.Controls.PilotLight()
        Me.IP_Address = New System.Windows.Forms.TextBox()
        Me.connect = New System.Windows.Forms.Button()
        Me.disconnect = New System.Windows.Forms.Button()
        Me.Port = New System.Windows.Forms.TextBox()
        CType(Me.GaugeControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerReceive
        '
        Me.TimerReceive.Enabled = True
        Me.TimerReceive.Interval = 300
        '
        'TextBoxCh0
        '
        Me.TextBoxCh0.Location = New System.Drawing.Point(89, 66)
        Me.TextBoxCh0.Name = "TextBoxCh0"
        Me.TextBoxCh0.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxCh0.TabIndex = 0
        '
        'TextBoxCh1
        '
        Me.TextBoxCh1.Location = New System.Drawing.Point(197, 66)
        Me.TextBoxCh1.Name = "TextBoxCh1"
        Me.TextBoxCh1.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxCh1.TabIndex = 0
        '
        'LabelCh0
        '
        Me.LabelCh0.AutoSize = True
        Me.LabelCh0.Location = New System.Drawing.Point(105, 50)
        Me.LabelCh0.Name = "LabelCh0"
        Me.LabelCh0.Size = New System.Drawing.Size(65, 13)
        Me.LabelCh0.TabIndex = 1
        Me.LabelCh0.Text = "Trame reçue"
        '
        'LabelCh1
        '
        Me.LabelCh1.AutoSize = True
        Me.LabelCh1.Location = New System.Drawing.Point(217, 50)
        Me.LabelCh1.Name = "LabelCh1"
        Me.LabelCh1.Size = New System.Drawing.Size(78, 13)
        Me.LabelCh1.TabIndex = 1
        Me.LabelCh1.Text = "Trame envoyée"
        '
        'ButtonSubscribe
        '
        Me.ButtonSubscribe.Location = New System.Drawing.Point(137, 93)
        Me.ButtonSubscribe.Name = "ButtonSubscribe"
        Me.ButtonSubscribe.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSubscribe.TabIndex = 3
        Me.ButtonSubscribe.Text = "Subscribe"
        Me.ButtonSubscribe.UseVisualStyleBackColor = True
        '
        'ButtonUnsubscribe
        '
        Me.ButtonUnsubscribe.Location = New System.Drawing.Point(56, 93)
        Me.ButtonUnsubscribe.Name = "ButtonUnsubscribe"
        Me.ButtonUnsubscribe.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUnsubscribe.TabIndex = 4
        Me.ButtonUnsubscribe.Text = "Start"
        Me.ButtonUnsubscribe.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 5
        '
        'GaugeControl1
        '
        GaugeCircularScale1.MajorTickMarks.Interval = 100.0R
        GaugeCircularScale1.MaxPin.Name = "MaxPin"
        GaugeCircularScale1.MaxValue = 1000.0R
        GaugeCircularScale1.MinorTickMarks.Interval = 10.0R
        GaugeCircularScale1.MinPin.Name = "MinPin"
        GaugeCircularScale1.Name = "Scale1"
        GaugePointer1.CapFillColor.BorderColor = System.Drawing.Color.DimGray
        GaugePointer1.CapFillColor.BorderWidth = 1
        GaugePointer1.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
        GaugePointer1.CapFillColor.Color2 = System.Drawing.Color.DimGray
        GaugePointer1.FillColor.BorderColor = System.Drawing.Color.DimGray
        GaugePointer1.FillColor.BorderWidth = 1
        GaugePointer1.FillColor.Color1 = System.Drawing.Color.WhiteSmoke
        GaugePointer1.FillColor.Color2 = System.Drawing.Color.Red
        GaugePointer1.Length = 0.358!
        GaugePointer1.Name = "Pointer1"
        GaugePointer1.Style = DevComponents.Instrumentation.PointerStyle.Needle
        GaugeCircularScale1.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer1})
        GaugeRange1.FillColor.BorderColor = System.Drawing.Color.DimGray
        GaugeRange1.FillColor.BorderWidth = 1
        GaugeRange1.FillColor.Color1 = System.Drawing.Color.Lime
        GaugeRange1.FillColor.Color2 = System.Drawing.Color.Red
        GaugeRange1.Name = "Range1"
        GaugeRange1.ScaleOffset = 0.3!
        GaugeRange1.StartValue = 700.0R
        GaugeCircularScale1.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange1})
        GaugeSection1.FillColor.Color1 = System.Drawing.Color.CornflowerBlue
        GaugeSection1.FillColor.Color2 = System.Drawing.Color.Purple
        GaugeSection1.Name = "Section1"
        GaugeCircularScale1.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection1})
        Me.GaugeControl1.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale1})
        GradientFillColor1.Color1 = System.Drawing.Color.Gainsboro
        GradientFillColor1.Color2 = System.Drawing.Color.DarkGray
        Me.GaugeControl1.Frame.BackColor = GradientFillColor1
        GradientFillColor2.BorderColor = System.Drawing.Color.Gainsboro
        GradientFillColor2.BorderWidth = 1
        GradientFillColor2.Color1 = System.Drawing.Color.White
        GradientFillColor2.Color2 = System.Drawing.Color.DimGray
        Me.GaugeControl1.Frame.FrameColor = GradientFillColor2
        Me.GaugeControl1.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular
        Me.GaugeControl1.Location = New System.Drawing.Point(322, 111)
        Me.GaugeControl1.Name = "GaugeControl1"
        Me.GaugeControl1.Size = New System.Drawing.Size(229, 213)
        Me.GaugeControl1.TabIndex = 6
        Me.GaugeControl1.Text = "GaugeControl1"
        '
        'DigitalPanelMeterBlue1
        '
        Me.DigitalPanelMeterBlue1.DecimalPosition = 0
        Me.DigitalPanelMeterBlue1.ForeColor = System.Drawing.Color.Black
        Me.DigitalPanelMeterBlue1.Location = New System.Drawing.Point(499, 420)
        Me.DigitalPanelMeterBlue1.Maximum = 0.0R
        Me.DigitalPanelMeterBlue1.Minimum = 0.0R
        Me.DigitalPanelMeterBlue1.Name = "DigitalPanelMeterBlue1"
        Me.DigitalPanelMeterBlue1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeterBlue1.Size = New System.Drawing.Size(399, 102)
        Me.DigitalPanelMeterBlue1.TabIndex = 7
        Me.DigitalPanelMeterBlue1.Text = "Position de l'axe en points"
        Me.DigitalPanelMeterBlue1.Value = 0.0R
        Me.DigitalPanelMeterBlue1.ValueScaleFactor = 1.0R
        '
        'KnobControl1
        '
        Me.KnobControl1.KnobStyle = DevComponents.Instrumentation.eKnobStyle.Style4
        Me.KnobControl1.Location = New System.Drawing.Point(15, 287)
        Me.KnobControl1.MajorTickAmount = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.KnobControl1.MaxValue = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.KnobControl1.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.KnobControl1.Name = "KnobControl1"
        Me.KnobControl1.Size = New System.Drawing.Size(306, 272)
        Me.KnobControl1.StartAngle = 50
        Me.KnobControl1.SweepAngle = -280
        Me.KnobControl1.TabIndex = 8
        Me.KnobControl1.Text = "Consigne de position"
        '
        'SelectorSwitch1
        '
        Me.SelectorSwitch1.LegendPlate = MfgControl.AdvancedHMI.Controls.SelectorSwitch.LegendPlates.Large
        Me.SelectorSwitch1.Location = New System.Drawing.Point(15, 140)
        Me.SelectorSwitch1.Name = "SelectorSwitch1"
        Me.SelectorSwitch1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.SelectorSwitch1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SelectorSwitch1.Size = New System.Drawing.Size(83, 122)
        Me.SelectorSwitch1.TabIndex = 9
        Me.SelectorSwitch1.Text = "SelectorSwitch1"
        Me.SelectorSwitch1.Value = True
        '
        'PushButton1
        '
        Me.PushButton1.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green
        Me.PushButton1.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large
        Me.PushButton1.Location = New System.Drawing.Point(129, 140)
        Me.PushButton1.Name = "PushButton1"
        Me.PushButton1.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.Toggle
        Me.PushButton1.Size = New System.Drawing.Size(83, 122)
        Me.PushButton1.TabIndex = 12
        Me.PushButton1.Text = "PushButton1"
        '
        'Chart1
        '
        ChartArea1.AxisX.IsStartedFromZero = False
        ChartArea1.AxisX.LabelStyle.Format = "00:01"
        ChartArea1.AxisX.MaximumAutoSize = 90.0!
        ChartArea1.AxisX.ScaleBreakStyle.Spacing = 1.0R
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(513, 14)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Legend = "Legend1"
        Series1.Name = "Valeur 2"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(457, 78)
        Me.Chart1.TabIndex = 13
        Me.Chart1.Text = "Chart1"
        '
        'TimerCourbe
        '
        Me.TimerCourbe.Enabled = True
        Me.TimerCourbe.Interval = 1000
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.Color.Transparent
        Me.Chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Me.Chart2.BackSecondaryColor = System.Drawing.Color.LightGray
        Me.Chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.Chart2.BorderSkin.BackColor = System.Drawing.Color.Maroon
        ChartArea2.AxisX.LineColor = System.Drawing.Color.Maroon
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea2.AxisY.LineColor = System.Drawing.Color.Maroon
        ChartArea2.AxisY.MajorGrid.Interval = 0.0R
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea2.AxisY.MajorTickMark.Interval = 0.0R
        ChartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea2.BackColor = System.Drawing.Color.White
        ChartArea2.BorderColor = System.Drawing.Color.Maroon
        ChartArea2.Name = "ChartArea1"
        ChartArea2.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Enabled = False
        Legend2.ForeColor = System.Drawing.Color.DimGray
        Legend2.HeaderSeparatorColor = System.Drawing.Color.Silver
        Legend2.ItemColumnSeparatorColor = System.Drawing.Color.Silver
        Legend2.Name = "Legend1"
        Legend2.TitleForeColor = System.Drawing.Color.Maroon
        Legend2.TitleSeparatorColor = System.Drawing.Color.DarkRed
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(743, 155)
        Me.Chart2.Margin = New System.Windows.Forms.Padding(0)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series2.Color = System.Drawing.Color.Black
        Series2.EmptyPointStyle.LabelForeColor = System.Drawing.Color.DimGray
        Series2.IsXValueIndexed = True
        Series2.LabelForeColor = System.Drawing.Color.Gray
        Series2.Legend = "Legend1"
        Series2.MarkerBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Series2.MarkerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square
        Series2.Name = "Series1"
        DataPoint1.AxisLabel = "Time"
        DataPoint1.Label = ""
        DataPoint1.LegendText = ""
        Series2.Points.Add(DataPoint1)
        Series2.Points.Add(DataPoint2)
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Single]
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(230, 169)
        Me.Chart2.TabIndex = 25
        Me.Chart2.Text = "Chart2"
        '
        'PilotLight1
        '
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.Location = New System.Drawing.Point(578, 128)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight1.Size = New System.Drawing.Size(133, 195)
        Me.PilotLight1.TabIndex = 27
        Me.PilotLight1.Text = "PilotLight1"
        Me.PilotLight1.Value = False
        '
        'IP_Address
        '
        Me.IP_Address.Location = New System.Drawing.Point(12, 14)
        Me.IP_Address.Name = "IP_Address"
        Me.IP_Address.Size = New System.Drawing.Size(137, 21)
        Me.IP_Address.TabIndex = 28
        Me.IP_Address.Text = "Enter IP Address Here"
        '
        'connect
        '
        Me.connect.Location = New System.Drawing.Point(164, 12)
        Me.connect.Name = "connect"
        Me.connect.Size = New System.Drawing.Size(131, 23)
        Me.connect.TabIndex = 29
        Me.connect.Text = "Connect"
        Me.connect.UseVisualStyleBackColor = True
        '
        'disconnect
        '
        Me.disconnect.Location = New System.Drawing.Point(313, 10)
        Me.disconnect.Name = "disconnect"
        Me.disconnect.Size = New System.Drawing.Size(133, 25)
        Me.disconnect.TabIndex = 30
        Me.disconnect.Text = "Disconnect"
        Me.disconnect.UseVisualStyleBackColor = True
        '
        'Port
        '
        Me.Port.Location = New System.Drawing.Point(12, 39)
        Me.Port.Name = "Port"
        Me.Port.Size = New System.Drawing.Size(75, 21)
        Me.Port.TabIndex = 31
        Me.Port.Text = "Port"
        '
        'FormMain
        '
        Me.AcceptButton = Me.ButtonSubscribe
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 571)
        Me.Controls.Add(Me.PilotLight1)
        Me.Controls.Add(Me.KnobControl1)
        Me.Controls.Add(Me.Port)
        Me.Controls.Add(Me.disconnect)
        Me.Controls.Add(Me.connect)
        Me.Controls.Add(Me.IP_Address)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.PushButton1)
        Me.Controls.Add(Me.SelectorSwitch1)
        Me.Controls.Add(Me.DigitalPanelMeterBlue1)
        Me.Controls.Add(Me.GaugeControl1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonUnsubscribe)
        Me.Controls.Add(Me.ButtonSubscribe)
        Me.Controls.Add(Me.LabelCh1)
        Me.Controls.Add(Me.LabelCh0)
        Me.Controls.Add(Me.TextBoxCh1)
        Me.Controls.Add(Me.TextBoxCh0)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormMain"
        Me.Text = "ROBOT 6 AXES"
        CType(Me.GaugeControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerReceive As System.Windows.Forms.Timer
    Friend WithEvents TextBoxCh0 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCh1 As System.Windows.Forms.TextBox
    Friend WithEvents LabelCh0 As System.Windows.Forms.Label
    Friend WithEvents LabelCh1 As System.Windows.Forms.Label
    Friend WithEvents ButtonSubscribe As System.Windows.Forms.Button
    Friend WithEvents ButtonUnsubscribe As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GaugeControl1 As DevComponents.Instrumentation.GaugeControl
    Friend WithEvents DigitalPanelMeterBlue1 As MfgControl.AdvancedHMI.Controls.DigitalPanelMeterBlue
    Friend WithEvents KnobControl1 As DevComponents.Instrumentation.KnobControl
    Friend WithEvents SelectorSwitch1 As MfgControl.AdvancedHMI.Controls.SelectorSwitch
    Friend WithEvents PushButton1 As MfgControl.AdvancedHMI.Controls.PushButton
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TimerCourbe As System.Windows.Forms.Timer
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents PilotLight1 As MfgControl.AdvancedHMI.Controls.PilotLight
    Friend WithEvents IP_Address As System.Windows.Forms.TextBox
    Friend WithEvents connect As System.Windows.Forms.Button
    Friend WithEvents disconnect As System.Windows.Forms.Button
    Friend WithEvents Port As System.Windows.Forms.TextBox



End Class
