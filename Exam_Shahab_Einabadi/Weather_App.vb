'---------------------------------------------------------------------------------------------
'Project Name: The Weather Application
'
'The Weather Application is a Windows GUI application that presents current weather information at a
'selected canadian city, based On a service provided by OpenWeatherMap.
'The program sends a request To the OpenWeatherMap website, asking For weather information Of a
'city selected by the user. The website will Then answer the request sending back To the program the
'requested information, which will be processed and presented To the user.
'
'Copyright(C) 2018 Shahab Einabadi
'Email: 1895065@edu.vaniercollege.qc.ca
'
'This program Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'any later version.
'
'This program Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty Of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.
'
'See <https://www.gnu.org/licenses/> to receive a copy of the GNU General Public License.
'---------------------------------------------------------------------------------------------

Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net

Public Class Weather_App

    Dim cityProvince(,) As String
    Dim upperBound As Integer
    Dim cities() As String
    Dim provinces() As String
    Dim provinceSelected As String
    Dim txtCity As String
    Dim language As String = "en"

    ' grab the information from the jason file received from the API
    Dim grabHumidity As String
    Dim grabWeather As String
    Dim grabDetailed As String
    Dim grabTemp As String
    Dim grabPressure As String
    Dim grabMaxTemp As String
    Dim grabMinTemp As String
    Dim grabLat As String
    Dim grabLon As String
    Dim grabWindSpeed As String
    Dim grabCloudiness As String
    Dim grabIcon As String

    'after loading the app, the matrix data will be uploaded and the province combo box is populated
    Private Sub Exam_Shahab_Einabadi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Read all the provinces and cities from json file
        cityProvince = GetCitiesAndProvincesFromFile()

        ' PopulateComboProvince(provinces)
        PopulateComboProvince(findProvinces(cityProvince))

        ' Detailed information will be checked, at start up all the information will be shown
        DetailedInformationToolStripMenuItem.Checked = True
        EnglishToolStripMenuItem.Checked = True
    End Sub

    ' This function will find all the provinces of the canada 
    Private Function findProvinces(arr) As String()

        upperBound = cityProvince.GetUpperBound(0)
        Dim provinces(upperBound) As String
        For I As Integer = 0 To upperBound
            provinces(I) = cityProvince(I, 1)
        Next I

        'remove duplicate from the province
        provinces = RemoveDuplicates(provinces)
        Return provinces
    End Function

    'populate province combo box
    Private Sub PopulateComboProvince(arrInput)
        cmbProvince.Text = ""
        cmbProvince.Items.Clear()

        For Each element As String In arrInput
            cmbProvince.Items.Add(element)
        Next element
    End Sub

    'populate city combo box
    Private Sub PopulateComboCity(arrInput)
        cmbCity.Text = ""
        cmbCity.Items.Clear()

        For Each element As String In arrInput
            cmbCity.Items.Add(element)
        Next element
    End Sub

    ' selecting a province, clear the combo box of the city and then populate it
    Private Sub cmbProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProvince.SelectedIndexChanged
        cmbCity.Items.Clear()
        cmbCity.Text = ""
        provinceSelected = cmbProvince.Text
        PopulateComboCityFromProvince()
        AscendingToolStripMenuItem.Checked = False
        DescendingToolStripMenuItem.Checked = False
    End Sub

    ' populate the city combo box according to province combobox
    Private Sub PopulateComboCityFromProvince()
        cmbCity.Items.Clear()
        Dim cities(upperBound) As String

        Dim counter As Integer = 0
        For I As Integer = 0 To upperBound
            If (cityProvince(I, 1).Equals(provinceSelected)) Then
                cities(counter) = cityProvince(I, 0)
                counter = counter + 1
            End If
        Next I
        For Each element As String In cities
            If element <> Nothing Then
                cmbCity.Items.Add(element)
            End If

        Next element
    End Sub

    ' a funciton to remove duplicate values from an array of strings
    Public Function RemoveDuplicates(ByVal items As String()) As String()
        Dim noDupsArrList As New ArrayList()
        For i As Integer = 0 To items.Length - 1
            If Not noDupsArrList.Contains(items(i).Trim()) Then
                noDupsArrList.Add(items(i).Trim())
            End If
        Next

        Dim uniqueItems As String() = New String(noDupsArrList.Count - 1) {}
        noDupsArrList.CopyTo(uniqueItems)
        Return uniqueItems
    End Function

    Function GetCitiesAndProvincesFromFile() As String(,)
        ' Read the json file 
        Dim jsonstring = IO.File.ReadAllText("ca.json.txt")

        ' Create an array of Jason class
        Dim jsonArray As JArray = JArray.Parse(jsonstring)
        Dim citiesProvinces(jsonArray.Count - 1, 1) As String

        For n As Integer = 0 To jsonArray.Count - 1
            ' Each element of the array will be saved as a jason object
            Dim json As JObject = JObject.Parse(jsonArray(n).ToString)

            ' The first elemnt is city, and the second is the province
            citiesProvinces(n, 0) = json.SelectToken("city")
            citiesProvinces(n, 1) = json.SelectToken("admin")
        Next n

        Return citiesProvinces
    End Function

    Private Sub ascendingtoolstripmenuitem_click(sender As Object, e As EventArgs) Handles AscendingToolStripMenuItem.Click
        If AscendingToolStripMenuItem.Checked Then
            ' read the information from the combo boxes
            Dim itemsCity() As String = (From item As String In cmbCity.Items Select item).ToArray
            Dim itemsProvince() As String = (From item As String In cmbProvince.Items Select item).ToArray

            ' sorting ascending
            System.Array.Sort(itemsCity)
            System.Array.Sort(itemsProvince)

            ' populating the comboboxes
            PopulateComboCity(itemsCity)
            PopulateComboProvince(itemsProvince)
        End If
        DescendingToolStripMenuItem.Checked = False
    End Sub

    Private Sub DescendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescendingToolStripMenuItem.Click
        If DescendingToolStripMenuItem.Checked Then
            ' read the information from the combo boxes
            Dim itemsCity() As String = (From item As String In cmbCity.Items Select item).ToArray
            Dim itemsProvince() As String = (From item As String In cmbProvince.Items Select item).ToArray

            ' sorting descending
            System.Array.Sort(itemsCity)
            System.Array.Reverse(itemsCity)
            System.Array.Sort(itemsProvince)
            System.Array.Reverse(itemsProvince)

            ' populating the comboboxes
            PopulateComboCity(itemsCity)
            PopulateComboProvince(itemsProvince)
        End If
        AscendingToolStripMenuItem.Checked = False
    End Sub

    Private Sub btnShowWeather_Click(sender As Object, e As EventArgs) Handles btnShowWeather.Click
        If cmbCity.Text = "" Or cmbProvince.Text = "" Then
            MessageBox.Show("Please select city and province")
        Else
            ' Connect to the openweathermap.com and take the jason file 
            Dim appId As String = "ee173a7fa8660783edf9b9a0d8365386"
            Dim url As String = String.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&cnt=1&APPID={1}&lang={2}", cmbCity.Text.Trim(), appId, language)
            Dim webClient As New System.Net.WebClient
            Dim jsonstring As String = webClient.DownloadString(url)

            Dim json As JObject = JObject.Parse(jsonstring)

            ' main part contains information like humidity, temp, temp min, temp max
            Dim jsonMain As JObject = json.SelectToken("main")
            grabTemp = jsonMain.SelectToken("temp")
            grabPressure = jsonMain.SelectToken("pressure")
            grabHumidity = jsonMain.SelectToken("humidity")
            grabMaxTemp = jsonMain.SelectToken("temp_max")
            grabMinTemp = jsonMain.SelectToken("temp_min")

            ' weather part contains information like main weather and description
            Dim jsonWeather As JObject = json.SelectToken("weather")(0)
            grabWeather = jsonWeather.SelectToken("main")
            grabDetailed = jsonWeather.SelectToken("description")
            grabIcon = jsonWeather.SelectToken("icon")

            ' weather part contains information like lattitide and longtitude
            Dim jsonLocation As JObject = json.SelectToken("coord")
            grabLat = jsonLocation.SelectToken("lat")
            grabLon = jsonLocation.SelectToken("lon")

            ' weather part contains information like wind speed
            Dim jsonWind As JObject = json.SelectToken("wind")
            grabWindSpeed = jsonWind.SelectToken("speed")

            ' weather part contains information like wind speed
            Dim jsonCloud As JObject = json.SelectToken("clouds")
            grabCloudiness = jsonCloud.SelectToken("all")

            ' feed the combo boxes with the grabbed information
            lblCity.Text = cmbCity.Text & ", " & cmbProvince.Text
            txtbWeather.Text = grabWeather
            txtbTemp.Text = grabTemp
            txtbPressure.Text = grabPressure
            txtbHumidity.Text = grabHumidity
            txtbTempMax.Text = grabMaxTemp
            txtbTempMin.Text = grabMinTemp
            txtbDetailed.Text = grabDetailed
            txtbLat.Text = grabLat
            txtbLon.Text = grabLon
            txtbWindSpeed.Text = grabWindSpeed
            txtbCloudiness.Text = grabCloudiness

            ' loading image
            Dim ImageUrl As String = String.Format("http://openweathermap.org/img/w/{0}.png", grabIcon)
            Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(webClient.DownloadData(ImageUrl)))
            picbWeather.Image = tImage

        End If
    End Sub

    Private Sub DetailedInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailedInformationToolStripMenuItem.Click
        ' if detailed information is checked all the fields will be shown, if not some will not be shown
        If DetailedInformationToolStripMenuItem.Checked Then
            txtbDetailed.Visible = True
            lblDetailed.Visible = True
            txtbLat.Visible = True
            lblLat.Visible = True
            txtbLon.Visible = True
            lblLon.Visible = True
            txtbWindSpeed.Visible = True
            lblWindSpeed.Visible = True
            txtbCloudiness.Visible = True
            lblCloudiness.Visible = True
        Else
            txtbDetailed.Visible = False
            lblDetailed.Visible = False
            txtbLat.Visible = False
            lblLat.Visible = False
            txtbLon.Visible = False
            lblLon.Visible = False
            txtbWindSpeed.Visible = False
            lblWindSpeed.Visible = False
            txtbCloudiness.Visible = False
            lblCloudiness.Visible = False
        End If
    End Sub

    ' Open the about box
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    ' closing the application
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click
        If EnglishToolStripMenuItem.Checked Then
            EnglishToolStripMenuItem.Checked = True
            FrenchToolStripMenuItem.Checked = False
            PersianToolStripMenuItem.Checked = False
            language = "en"
        End If
    End Sub

    Private Sub FrenchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrenchToolStripMenuItem.Click
        If FrenchToolStripMenuItem.Checked Then
            EnglishToolStripMenuItem.Checked = False
            FrenchToolStripMenuItem.Checked = True
            PersianToolStripMenuItem.Checked = False
            language = "fr"
        End If
    End Sub

    Private Sub PersianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersianToolStripMenuItem.Click
        If PersianToolStripMenuItem.Checked Then
            EnglishToolStripMenuItem.Checked = False
            FrenchToolStripMenuItem.Checked = False
            PersianToolStripMenuItem.Checked = True
            language = "sp"
        End If
    End Sub
End Class