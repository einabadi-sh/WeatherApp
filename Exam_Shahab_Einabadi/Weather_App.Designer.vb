<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Weather_App
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailedInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrenchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortLocationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AscendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbProvince = New System.Windows.Forms.ComboBox()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.btnShowWeather = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.picbWeather = New System.Windows.Forms.PictureBox()
        Me.txtbCloudiness = New System.Windows.Forms.TextBox()
        Me.txtbWindSpeed = New System.Windows.Forms.TextBox()
        Me.txtbLon = New System.Windows.Forms.TextBox()
        Me.txtbLat = New System.Windows.Forms.TextBox()
        Me.txtbDetailed = New System.Windows.Forms.TextBox()
        Me.txtbTempMin = New System.Windows.Forms.TextBox()
        Me.txtbTempMax = New System.Windows.Forms.TextBox()
        Me.txtbHumidity = New System.Windows.Forms.TextBox()
        Me.txtbPressure = New System.Windows.Forms.TextBox()
        Me.txtbTemp = New System.Windows.Forms.TextBox()
        Me.txtbWeather = New System.Windows.Forms.TextBox()
        Me.lblCloudiness = New System.Windows.Forms.Label()
        Me.lblWindSpeed = New System.Windows.Forms.Label()
        Me.lblLon = New System.Windows.Forms.Label()
        Me.lblLat = New System.Windows.Forms.Label()
        Me.lblDetailed = New System.Windows.Forms.Label()
        Me.lblMinTemp = New System.Windows.Forms.Label()
        Me.lblMaxTemp = New System.Windows.Forms.Label()
        Me.lblHumidity = New System.Windows.Forms.Label()
        Me.lblPressure = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.lblWeather = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picbWeather, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1049, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 36)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(139, 36)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(67, 36)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailedInformationToolStripMenuItem, Me.LanguageToolStripMenuItem, Me.SortLocationsToolStripMenuItem})
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(252, 36)
        Me.PreferencesToolStripMenuItem.Text = "Preferences"
        '
        'DetailedInformationToolStripMenuItem
        '
        Me.DetailedInformationToolStripMenuItem.CheckOnClick = True
        Me.DetailedInformationToolStripMenuItem.Name = "DetailedInformationToolStripMenuItem"
        Me.DetailedInformationToolStripMenuItem.Size = New System.Drawing.Size(323, 36)
        Me.DetailedInformationToolStripMenuItem.Text = "Detailed information"
        '
        'LanguageToolStripMenuItem
        '
        Me.LanguageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglishToolStripMenuItem, Me.FrenchToolStripMenuItem, Me.PersianToolStripMenuItem})
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        Me.LanguageToolStripMenuItem.Size = New System.Drawing.Size(323, 36)
        Me.LanguageToolStripMenuItem.Text = "Language"
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.CheckOnClick = True
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        Me.EnglishToolStripMenuItem.Size = New System.Drawing.Size(252, 36)
        Me.EnglishToolStripMenuItem.Text = "English"
        '
        'FrenchToolStripMenuItem
        '
        Me.FrenchToolStripMenuItem.CheckOnClick = True
        Me.FrenchToolStripMenuItem.Name = "FrenchToolStripMenuItem"
        Me.FrenchToolStripMenuItem.Size = New System.Drawing.Size(252, 36)
        Me.FrenchToolStripMenuItem.Text = "French"
        '
        'PersianToolStripMenuItem
        '
        Me.PersianToolStripMenuItem.CheckOnClick = True
        Me.PersianToolStripMenuItem.Name = "PersianToolStripMenuItem"
        Me.PersianToolStripMenuItem.Size = New System.Drawing.Size(252, 36)
        Me.PersianToolStripMenuItem.Text = "Spanish"
        '
        'SortLocationsToolStripMenuItem
        '
        Me.SortLocationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AscendingToolStripMenuItem, Me.DescendingToolStripMenuItem})
        Me.SortLocationsToolStripMenuItem.Name = "SortLocationsToolStripMenuItem"
        Me.SortLocationsToolStripMenuItem.Size = New System.Drawing.Size(323, 36)
        Me.SortLocationsToolStripMenuItem.Text = "Sort Locations"
        '
        'AscendingToolStripMenuItem
        '
        Me.AscendingToolStripMenuItem.CheckOnClick = True
        Me.AscendingToolStripMenuItem.Name = "AscendingToolStripMenuItem"
        Me.AscendingToolStripMenuItem.Size = New System.Drawing.Size(228, 36)
        Me.AscendingToolStripMenuItem.Text = "Ascending"
        '
        'DescendingToolStripMenuItem
        '
        Me.DescendingToolStripMenuItem.CheckOnClick = True
        Me.DescendingToolStripMenuItem.Name = "DescendingToolStripMenuItem"
        Me.DescendingToolStripMenuItem.Size = New System.Drawing.Size(228, 36)
        Me.DescendingToolStripMenuItem.Text = "Descending"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(77, 36)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(167, 36)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Province"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "City"
        '
        'cmbProvince
        '
        Me.cmbProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProvince.FormattingEnabled = True
        Me.cmbProvince.Location = New System.Drawing.Point(56, 99)
        Me.cmbProvince.Name = "cmbProvince"
        Me.cmbProvince.Size = New System.Drawing.Size(250, 40)
        Me.cmbProvince.TabIndex = 3
        '
        'cmbCity
        '
        Me.cmbCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Location = New System.Drawing.Point(390, 99)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(250, 40)
        Me.cmbCity.TabIndex = 4
        '
        'btnShowWeather
        '
        Me.btnShowWeather.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowWeather.Location = New System.Drawing.Point(724, 104)
        Me.btnShowWeather.Name = "btnShowWeather"
        Me.btnShowWeather.Size = New System.Drawing.Size(250, 40)
        Me.btnShowWeather.TabIndex = 5
        Me.btnShowWeather.Text = "Show Weather"
        Me.btnShowWeather.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.picbWeather)
        Me.GroupBox1.Controls.Add(Me.txtbCloudiness)
        Me.GroupBox1.Controls.Add(Me.txtbWindSpeed)
        Me.GroupBox1.Controls.Add(Me.txtbLon)
        Me.GroupBox1.Controls.Add(Me.txtbLat)
        Me.GroupBox1.Controls.Add(Me.txtbDetailed)
        Me.GroupBox1.Controls.Add(Me.txtbTempMin)
        Me.GroupBox1.Controls.Add(Me.txtbTempMax)
        Me.GroupBox1.Controls.Add(Me.txtbHumidity)
        Me.GroupBox1.Controls.Add(Me.txtbPressure)
        Me.GroupBox1.Controls.Add(Me.txtbTemp)
        Me.GroupBox1.Controls.Add(Me.txtbWeather)
        Me.GroupBox1.Controls.Add(Me.lblCloudiness)
        Me.GroupBox1.Controls.Add(Me.lblWindSpeed)
        Me.GroupBox1.Controls.Add(Me.lblLon)
        Me.GroupBox1.Controls.Add(Me.lblLat)
        Me.GroupBox1.Controls.Add(Me.lblDetailed)
        Me.GroupBox1.Controls.Add(Me.lblMinTemp)
        Me.GroupBox1.Controls.Add(Me.lblMaxTemp)
        Me.GroupBox1.Controls.Add(Me.lblHumidity)
        Me.GroupBox1.Controls.Add(Me.lblPressure)
        Me.GroupBox1.Controls.Add(Me.lblTemp)
        Me.GroupBox1.Controls.Add(Me.lblWeather)
        Me.GroupBox1.Controls.Add(Me.lblCity)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(56, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(951, 478)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Weather Information"
        '
        'picbWeather
        '
        Me.picbWeather.Location = New System.Drawing.Point(679, 29)
        Me.picbWeather.Name = "picbWeather"
        Me.picbWeather.Size = New System.Drawing.Size(150, 150)
        Me.picbWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbWeather.TabIndex = 24
        Me.picbWeather.TabStop = False
        '
        'txtbCloudiness
        '
        Me.txtbCloudiness.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbCloudiness.Enabled = False
        Me.txtbCloudiness.Location = New System.Drawing.Point(676, 425)
        Me.txtbCloudiness.Name = "txtbCloudiness"
        Me.txtbCloudiness.Size = New System.Drawing.Size(250, 28)
        Me.txtbCloudiness.TabIndex = 23
        '
        'txtbWindSpeed
        '
        Me.txtbWindSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbWindSpeed.Enabled = False
        Me.txtbWindSpeed.Location = New System.Drawing.Point(684, 370)
        Me.txtbWindSpeed.Name = "txtbWindSpeed"
        Me.txtbWindSpeed.Size = New System.Drawing.Size(250, 28)
        Me.txtbWindSpeed.TabIndex = 22
        '
        'txtbLon
        '
        Me.txtbLon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbLon.Enabled = False
        Me.txtbLon.Location = New System.Drawing.Point(668, 315)
        Me.txtbLon.Name = "txtbLon"
        Me.txtbLon.Size = New System.Drawing.Size(250, 28)
        Me.txtbLon.TabIndex = 21
        '
        'txtbLat
        '
        Me.txtbLat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbLat.Enabled = False
        Me.txtbLat.Location = New System.Drawing.Point(640, 260)
        Me.txtbLat.Name = "txtbLat"
        Me.txtbLat.Size = New System.Drawing.Size(250, 28)
        Me.txtbLat.TabIndex = 20
        '
        'txtbDetailed
        '
        Me.txtbDetailed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbDetailed.Enabled = False
        Me.txtbDetailed.Location = New System.Drawing.Point(645, 205)
        Me.txtbDetailed.Name = "txtbDetailed"
        Me.txtbDetailed.Size = New System.Drawing.Size(250, 28)
        Me.txtbDetailed.TabIndex = 19
        '
        'txtbTempMin
        '
        Me.txtbTempMin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbTempMin.Enabled = False
        Me.txtbTempMin.Location = New System.Drawing.Point(266, 425)
        Me.txtbTempMin.Name = "txtbTempMin"
        Me.txtbTempMin.Size = New System.Drawing.Size(250, 28)
        Me.txtbTempMin.TabIndex = 18
        '
        'txtbTempMax
        '
        Me.txtbTempMax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbTempMax.Enabled = False
        Me.txtbTempMax.Location = New System.Drawing.Point(271, 370)
        Me.txtbTempMax.Name = "txtbTempMax"
        Me.txtbTempMax.Size = New System.Drawing.Size(250, 28)
        Me.txtbTempMax.TabIndex = 17
        '
        'txtbHumidity
        '
        Me.txtbHumidity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbHumidity.Enabled = False
        Me.txtbHumidity.Location = New System.Drawing.Point(184, 315)
        Me.txtbHumidity.Name = "txtbHumidity"
        Me.txtbHumidity.Size = New System.Drawing.Size(250, 28)
        Me.txtbHumidity.TabIndex = 16
        '
        'txtbPressure
        '
        Me.txtbPressure.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbPressure.Enabled = False
        Me.txtbPressure.Location = New System.Drawing.Point(188, 260)
        Me.txtbPressure.Name = "txtbPressure"
        Me.txtbPressure.Size = New System.Drawing.Size(250, 28)
        Me.txtbPressure.TabIndex = 15
        '
        'txtbTemp
        '
        Me.txtbTemp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbTemp.Enabled = False
        Me.txtbTemp.Location = New System.Drawing.Point(231, 205)
        Me.txtbTemp.Name = "txtbTemp"
        Me.txtbTemp.Size = New System.Drawing.Size(250, 28)
        Me.txtbTemp.TabIndex = 14
        '
        'txtbWeather
        '
        Me.txtbWeather.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbWeather.Enabled = False
        Me.txtbWeather.Location = New System.Drawing.Point(194, 150)
        Me.txtbWeather.Name = "txtbWeather"
        Me.txtbWeather.Size = New System.Drawing.Size(250, 28)
        Me.txtbWeather.TabIndex = 13
        '
        'lblCloudiness
        '
        Me.lblCloudiness.AutoSize = True
        Me.lblCloudiness.Location = New System.Drawing.Point(530, 425)
        Me.lblCloudiness.Name = "lblCloudiness"
        Me.lblCloudiness.Size = New System.Drawing.Size(140, 29)
        Me.lblCloudiness.TabIndex = 12
        Me.lblCloudiness.Text = "Cloudiness:"
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.Location = New System.Drawing.Point(530, 370)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(148, 29)
        Me.lblWindSpeed.TabIndex = 11
        Me.lblWindSpeed.Text = "Wind speed:"
        '
        'lblLon
        '
        Me.lblLon.AutoSize = True
        Me.lblLon.Location = New System.Drawing.Point(530, 315)
        Me.lblLon.Name = "lblLon"
        Me.lblLon.Size = New System.Drawing.Size(132, 29)
        Me.lblLon.TabIndex = 10
        Me.lblLon.Text = "Longtitude:"
        '
        'lblLat
        '
        Me.lblLat.AutoSize = True
        Me.lblLat.Location = New System.Drawing.Point(530, 260)
        Me.lblLat.Name = "lblLat"
        Me.lblLat.Size = New System.Drawing.Size(104, 29)
        Me.lblLat.TabIndex = 9
        Me.lblLat.Text = "Latitude:"
        '
        'lblDetailed
        '
        Me.lblDetailed.AutoSize = True
        Me.lblDetailed.Location = New System.Drawing.Point(530, 205)
        Me.lblDetailed.Name = "lblDetailed"
        Me.lblDetailed.Size = New System.Drawing.Size(109, 29)
        Me.lblDetailed.TabIndex = 8
        Me.lblDetailed.Text = "Detailed:"
        '
        'lblMinTemp
        '
        Me.lblMinTemp.AutoSize = True
        Me.lblMinTemp.Location = New System.Drawing.Point(66, 425)
        Me.lblMinTemp.Name = "lblMinTemp"
        Me.lblMinTemp.Size = New System.Drawing.Size(194, 29)
        Me.lblMinTemp.TabIndex = 6
        Me.lblMinTemp.Text = "MIn temperature:"
        '
        'lblMaxTemp
        '
        Me.lblMaxTemp.AutoSize = True
        Me.lblMaxTemp.Location = New System.Drawing.Point(66, 370)
        Me.lblMaxTemp.Name = "lblMaxTemp"
        Me.lblMaxTemp.Size = New System.Drawing.Size(199, 29)
        Me.lblMaxTemp.TabIndex = 5
        Me.lblMaxTemp.Text = "Max temperature:"
        '
        'lblHumidity
        '
        Me.lblHumidity.AutoSize = True
        Me.lblHumidity.Location = New System.Drawing.Point(66, 315)
        Me.lblHumidity.Name = "lblHumidity"
        Me.lblHumidity.Size = New System.Drawing.Size(112, 29)
        Me.lblHumidity.TabIndex = 4
        Me.lblHumidity.Text = "Humidity:"
        '
        'lblPressure
        '
        Me.lblPressure.AutoSize = True
        Me.lblPressure.Location = New System.Drawing.Point(66, 260)
        Me.lblPressure.Name = "lblPressure"
        Me.lblPressure.Size = New System.Drawing.Size(116, 29)
        Me.lblPressure.TabIndex = 3
        Me.lblPressure.Text = "Pressure:"
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Location = New System.Drawing.Point(66, 205)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(159, 29)
        Me.lblTemp.TabIndex = 2
        Me.lblTemp.Text = "Temperature:"
        '
        'lblWeather
        '
        Me.lblWeather.AutoSize = True
        Me.lblWeather.Location = New System.Drawing.Point(66, 150)
        Me.lblWeather.Name = "lblWeather"
        Me.lblWeather.Size = New System.Drawing.Size(115, 29)
        Me.lblWeather.TabIndex = 1
        Me.lblWeather.Text = "Weather: "
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(20, 63)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(0, 46)
        Me.lblCity.TabIndex = 0
        '
        'Exam_Shahab_Einabadi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 680)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnShowWeather)
        Me.Controls.Add(Me.cmbCity)
        Me.Controls.Add(Me.cmbProvince)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Exam_Shahab_Einabadi"
        Me.Text = "The Weather Guru"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picbWeather, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailedInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanguageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortLocationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnglishToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FrenchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AscendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbProvince As ComboBox
    Friend WithEvents cmbCity As ComboBox
    Friend WithEvents btnShowWeather As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCity As Label
    Friend WithEvents lblWeather As Label
    Friend WithEvents lblCloudiness As Label
    Friend WithEvents lblWindSpeed As Label
    Friend WithEvents lblLon As Label
    Friend WithEvents lblLat As Label
    Friend WithEvents lblDetailed As Label
    Friend WithEvents lblMinTemp As Label
    Friend WithEvents lblMaxTemp As Label
    Friend WithEvents lblHumidity As Label
    Friend WithEvents lblPressure As Label
    Friend WithEvents lblTemp As Label
    Friend WithEvents txtbWeather As TextBox
    Friend WithEvents txtbCloudiness As TextBox
    Friend WithEvents txtbWindSpeed As TextBox
    Friend WithEvents txtbLon As TextBox
    Friend WithEvents txtbLat As TextBox
    Friend WithEvents txtbDetailed As TextBox
    Friend WithEvents txtbTempMin As TextBox
    Friend WithEvents txtbTempMax As TextBox
    Friend WithEvents txtbHumidity As TextBox
    Friend WithEvents txtbPressure As TextBox
    Friend WithEvents txtbTemp As TextBox
    Friend WithEvents picbWeather As PictureBox
End Class
