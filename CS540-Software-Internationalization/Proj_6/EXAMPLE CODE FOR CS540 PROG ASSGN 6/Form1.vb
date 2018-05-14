Imports System
Imports System.Globalization
Imports System.Threading
Imports System.Resources

Public Class Form1

    Inherits System.Windows.Forms.Form

    Dim currentCulture As CultureInfo

    Dim usaCulture As CultureInfo = New CultureInfo("en-US")
    Dim ukCulture As CultureInfo = New CultureInfo("es-MX")
    Dim indiaCulture As CultureInfo = New CultureInfo("hi-In")
    Dim pirateCulture As CultureInfo = New CultureInfo("")  'note use of invariant culture as constructor argument
    Dim currencyConvert As ResXResourceSet = New ResXResourceSet("currencyConverter.resx")

    Dim convert_rate As Double = 1.0

    Dim pirate_clicked As Boolean = False

    Dim dateTime As DateTime = New DateTime(0)
    Dim starting_date_time As DateTime = New DateTime(2017, 1, 1)
    Dim starting_fish_taco_sales As ULong = New Decimal(63208417.0) '63,208,417

    Dim displayMode As String

    Dim hindi_digits As Char() = {"०"c, "१"c, "२"c, "३"c, "४"c, "५"c, "६"c, "७"c, "८"c, "९"c}
    Dim latin_digits As Char() = {"0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c}
    Dim hindi_digits_enabled As Boolean
    Dim latin_digits_enabled As Boolean
    Dim latin_India_currency_symbol As String
    Dim hindi_India_currency_symbol As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents usaFlagPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents indiaFlagPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents pirateFlagPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents asDisplayedLabel As System.Windows.Forms.Label
    Friend WithEvents asDisplayedCaptionLabel As System.Windows.Forms.Label
    Friend WithEvents valueEnteredCaptionLabel As System.Windows.Forms.Label
    Friend WithEvents valueEnteredTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ukFlagPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dateTimeLabel As System.Windows.Forms.Label
    Friend WithEvents dateTimeCaptionLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents hindiButton As System.Windows.Forms.Button
    Friend WithEvents latinButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.usaFlagPictureBox = New System.Windows.Forms.PictureBox()
        Me.indiaFlagPictureBox = New System.Windows.Forms.PictureBox()
        Me.pirateFlagPictureBox = New System.Windows.Forms.PictureBox()
        Me.asDisplayedLabel = New System.Windows.Forms.Label()
        Me.valueEnteredTextBox = New System.Windows.Forms.TextBox()
        Me.asDisplayedCaptionLabel = New System.Windows.Forms.Label()
        Me.valueEnteredCaptionLabel = New System.Windows.Forms.Label()
        Me.ukFlagPictureBox = New System.Windows.Forms.PictureBox()
        Me.dateTimeLabel = New System.Windows.Forms.Label()
        Me.dateTimeCaptionLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.hindiButton = New System.Windows.Forms.Button()
        Me.latinButton = New System.Windows.Forms.Button()
        CType(Me.usaFlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.indiaFlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pirateFlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ukFlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usaFlagPictureBox
        '
        Me.usaFlagPictureBox.Image = CType(resources.GetObject("usaFlagPictureBox.Image"), System.Drawing.Image)
        Me.usaFlagPictureBox.Location = New System.Drawing.Point(64, 248)
        Me.usaFlagPictureBox.Name = "usaFlagPictureBox"
        Me.usaFlagPictureBox.Size = New System.Drawing.Size(112, 72)
        Me.usaFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.usaFlagPictureBox.TabIndex = 0
        Me.usaFlagPictureBox.TabStop = False
        '
        'indiaFlagPictureBox
        '
        Me.indiaFlagPictureBox.Image = CType(resources.GetObject("indiaFlagPictureBox.Image"), System.Drawing.Image)
        Me.indiaFlagPictureBox.Location = New System.Drawing.Point(192, 248)
        Me.indiaFlagPictureBox.Name = "indiaFlagPictureBox"
        Me.indiaFlagPictureBox.Size = New System.Drawing.Size(112, 72)
        Me.indiaFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.indiaFlagPictureBox.TabIndex = 1
        Me.indiaFlagPictureBox.TabStop = False
        '
        'pirateFlagPictureBox
        '
        Me.pirateFlagPictureBox.Image = CType(resources.GetObject("pirateFlagPictureBox.Image"), System.Drawing.Image)
        Me.pirateFlagPictureBox.Location = New System.Drawing.Point(478, 248)
        Me.pirateFlagPictureBox.Name = "pirateFlagPictureBox"
        Me.pirateFlagPictureBox.Size = New System.Drawing.Size(112, 72)
        Me.pirateFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pirateFlagPictureBox.TabIndex = 2
        Me.pirateFlagPictureBox.TabStop = False
        '
        'asDisplayedLabel
        '
        Me.asDisplayedLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.asDisplayedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.asDisplayedLabel.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.asDisplayedLabel.Location = New System.Drawing.Point(28, 24)
        Me.asDisplayedLabel.Name = "asDisplayedLabel"
        Me.asDisplayedLabel.Size = New System.Drawing.Size(614, 40)
        Me.asDisplayedLabel.TabIndex = 3
        Me.asDisplayedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'valueEnteredTextBox
        '
        Me.valueEnteredTextBox.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueEnteredTextBox.Location = New System.Drawing.Point(28, 120)
        Me.valueEnteredTextBox.Name = "valueEnteredTextBox"
        Me.valueEnteredTextBox.Size = New System.Drawing.Size(614, 46)
        Me.valueEnteredTextBox.TabIndex = 4
        Me.valueEnteredTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'asDisplayedCaptionLabel
        '
        Me.asDisplayedCaptionLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asDisplayedCaptionLabel.Location = New System.Drawing.Point(179, 64)
        Me.asDisplayedCaptionLabel.Name = "asDisplayedCaptionLabel"
        Me.asDisplayedCaptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.asDisplayedCaptionLabel.Size = New System.Drawing.Size(278, 38)
        Me.asDisplayedCaptionLabel.TabIndex = 7
        Me.asDisplayedCaptionLabel.Text = "Total Dollar Amount Sold"
        Me.asDisplayedCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'valueEnteredCaptionLabel
        '
        Me.valueEnteredCaptionLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueEnteredCaptionLabel.Location = New System.Drawing.Point(189, 169)
        Me.valueEnteredCaptionLabel.Name = "valueEnteredCaptionLabel"
        Me.valueEnteredCaptionLabel.Size = New System.Drawing.Size(265, 36)
        Me.valueEnteredCaptionLabel.TabIndex = 8
        Me.valueEnteredCaptionLabel.Text = "Number of Fish Tacos Sold"
        Me.valueEnteredCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ukFlagPictureBox
        '
        Me.ukFlagPictureBox.Image = CType(resources.GetObject("ukFlagPictureBox.Image"), System.Drawing.Image)
        Me.ukFlagPictureBox.Location = New System.Drawing.Point(329, 248)
        Me.ukFlagPictureBox.Name = "ukFlagPictureBox"
        Me.ukFlagPictureBox.Size = New System.Drawing.Size(112, 72)
        Me.ukFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ukFlagPictureBox.TabIndex = 9
        Me.ukFlagPictureBox.TabStop = False
        '
        'dateTimeLabel
        '
        Me.dateTimeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dateTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dateTimeLabel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimeLabel.Location = New System.Drawing.Point(28, 373)
        Me.dateTimeLabel.Name = "dateTimeLabel"
        Me.dateTimeLabel.Size = New System.Drawing.Size(596, 46)
        Me.dateTimeLabel.TabIndex = 12
        Me.dateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dateTimeCaptionLabel
        '
        Me.dateTimeCaptionLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimeCaptionLabel.Location = New System.Drawing.Point(207, 419)
        Me.dateTimeCaptionLabel.Name = "dateTimeCaptionLabel"
        Me.dateTimeCaptionLabel.Size = New System.Drawing.Size(194, 38)
        Me.dateTimeCaptionLabel.TabIndex = 13
        Me.dateTimeCaptionLabel.Text = "DATE / TIME"
        Me.dateTimeCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'hindiButton
        '
        Me.hindiButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hindiButton.Location = New System.Drawing.Point(248, 328)
        Me.hindiButton.Name = "hindiButton"
        Me.hindiButton.Size = New System.Drawing.Size(56, 29)
        Me.hindiButton.TabIndex = 14
        Me.hindiButton.Text = "HINDI"
        '
        'latinButton
        '
        Me.latinButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.latinButton.Location = New System.Drawing.Point(192, 328)
        Me.latinButton.Name = "latinButton"
        Me.latinButton.Size = New System.Drawing.Size(56, 29)
        Me.latinButton.TabIndex = 15
        Me.latinButton.Text = "LATIN"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(719, 578)
        Me.Controls.Add(Me.latinButton)
        Me.Controls.Add(Me.hindiButton)
        Me.Controls.Add(Me.dateTimeCaptionLabel)
        Me.Controls.Add(Me.dateTimeLabel)
        Me.Controls.Add(Me.ukFlagPictureBox)
        Me.Controls.Add(Me.valueEnteredCaptionLabel)
        Me.Controls.Add(Me.asDisplayedCaptionLabel)
        Me.Controls.Add(Me.valueEnteredTextBox)
        Me.Controls.Add(Me.asDisplayedLabel)
        Me.Controls.Add(Me.pirateFlagPictureBox)
        Me.Controls.Add(Me.indiaFlagPictureBox)
        Me.Controls.Add(Me.usaFlagPictureBox)
        Me.Name = "Form1"
        Me.Text = "Programming Assignment 6"
        CType(Me.usaFlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.indiaFlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pirateFlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ukFlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub xlt_digits_to_H(ByRef latin As String)
        Dim i As Integer
        For i = 0 To 9
            latin = latin.Replace(latin_digits(i), hindi_digits(i))
        Next i
    End Sub

    Private Sub definePirateCulture()
        Dim pirateCurrencyGroupSizes As Integer() = {3, 3}
        Dim pirateNumberGroupSizes As Integer() = {4, 3}
        pirateCulture.NumberFormat.CurrencyDecimalDigits = 2
        pirateCulture.NumberFormat.CurrencyDecimalSeparator = "."
        pirateCulture.NumberFormat.CurrencyGroupSizes = pirateCurrencyGroupSizes
        pirateCulture.NumberFormat.CurrencyGroupSeparator = ","
        pirateCulture.NumberFormat.CurrencySymbol = "ஜ"
        pirateCulture.NumberFormat.CurrencyPositivePattern = 3

        pirateCulture.NumberFormat.NumberDecimalDigits = 0
        pirateCulture.NumberFormat.NumberDecimalSeparator = "."
        pirateCulture.NumberFormat.NumberGroupSizes = pirateNumberGroupSizes
        pirateCulture.NumberFormat.NumberGroupSeparator = "*"
    End Sub

    Private Sub initializeDualIndiaCulture()
        hindi_India_currency_symbol = indiaCulture.NumberFormat.CurrencySymbol
        latin_India_currency_symbol = "Rs"
        latin_digits_enabled = True
        hindi_digits_enabled = False
        indiaCulture.NumberFormat.CurrencySymbol = latin_India_currency_symbol
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        displayMode = "N"
        currentCulture = usaCulture
        definePirateCulture()
        initializeDualIndiaCulture()
    End Sub

    Private Sub myRefresh()
        Thread.CurrentThread.CurrentUICulture = currentCulture
        Try
            valueEnteredTextBox.Text = CDbl(valueEnteredTextBox.Text).ToString("N", currentCulture)
            asDisplayedLabel.Text = CDbl(asDisplayedLabel.Text).ToString("C", currentCulture)
        Catch
        End Try
        If hindi_digits_enabled Then
            xlt_digits_to_H(asDisplayedLabel.Text)
            xlt_digits_to_H(dateTimeLabel.Text)
        End If
    End Sub

    Private Sub usaFlagPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usaFlagPictureBox.Click
        currentCulture = usaCulture
        pirate_clicked = False
        convert_rate = 1.0
        myRefresh()
    End Sub

    Private Sub indiaFlagPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles indiaFlagPictureBox.Click
        currentCulture = indiaCulture
        indiaCulture.NumberFormat.CurrencySymbol = latin_India_currency_symbol
        hindi_digits_enabled = False
        latin_digits_enabled = True
        pirate_clicked = False
        convert_rate = CDbl(currencyConvert.GetString("india"))
        myRefresh()
    End Sub

    Private Sub latinButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles latinButton.Click
        indiaCulture.NumberFormat.CurrencySymbol = latin_India_currency_symbol
        hindi_digits_enabled = False
        latin_digits_enabled = True
        pirate_clicked = False
        myRefresh()
    End Sub

    Private Sub hindiButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hindiButton.Click
        indiaCulture.NumberFormat.CurrencySymbol = hindi_India_currency_symbol
        hindi_digits_enabled = True
        latin_digits_enabled = False
        pirate_clicked = False
        myRefresh()
    End Sub

    Private Sub pirateFlagPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pirateFlagPictureBox.Click
        currentCulture = pirateCulture
        hindi_digits_enabled = False
        latin_digits_enabled = True
        pirate_clicked = True
        convert_rate = 2.0
        myRefresh()
    End Sub

    Private Sub ukFlagPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ukFlagPictureBox.Click
        currentCulture = ukCulture
        hindi_digits_enabled = False
        latin_digits_enabled = True
        pirate_clicked = False
        convert_rate = CDbl(currencyConvert.GetString("mexico"))
        myRefresh()
    End Sub

    Private Sub parseDisneyDate()
        Dim myString As String = dateTimeLabel.Text
        Dim rest_of_string As String = ""
        Dim startParse As Boolean = False
        For Each c As Char In myString
            If c = " " And startParse = False Then
                startParse = True
            End If
            If startParse = True Then
                rest_of_string += c
            End If
        Next

        Dim get_no_spaces As String = ""
        For Each c As Char In rest_of_string
            If c <> " " Then
                get_no_spaces += c
            End If
        Next

        Dim DD As String = ""
        Dim Month As String = ""
        Dim YYYY As String = ""
        Dim Time As String = ""
        DD = get_no_spaces.Chars(0) + get_no_spaces.Chars(1)
        Month = get_no_spaces.Chars(2) + get_no_spaces.Chars(3) + get_no_spaces.Chars(4) + get_no_spaces.Chars(5) + get_no_spaces.Chars(6)
        YYYY = get_no_spaces.Chars(7) + get_no_spaces.Chars(8) + get_no_spaces.Chars(9) + get_no_spaces.Chars(10)
        Time = get_no_spaces.Chars(11) + get_no_spaces.Chars(12) + get_no_spaces.Chars(14) + get_no_spaces.Chars(15)

        If Month = "March" Then
            Month = "03"
        End If

        Dim final_string As String = ""
        final_string = YYYY + ":" + Month + ":" + DD + "   " + Time
        dateTimeLabel.Text = final_string

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim current_year As ULong = DateTime.Now().Year
        Dim current_month As ULong = DateTime.Now().Month
        Dim current_day As ULong = DateTime.Now().Day
        Dim current_hours As ULong = DateTime.Now().Hour
        Dim current_minute As ULong = DateTime.Now().Minute
        Dim current_seconds As ULong = DateTime.Now().Second

        Dim old_year As ULong = starting_date_time.Year
        Dim old_month As ULong = starting_date_time.Month
        Dim old_day As ULong = starting_date_time.Day
        Dim old_hours As ULong = starting_date_time.Hour
        Dim old_minute As ULong = starting_date_time.Minute
        Dim old_seconds As ULong = starting_date_time.Second

        Dim difference_year As ULong = Math.Abs(current_year - old_year)
        Dim difference_month As ULong = Math.Abs(current_month - old_month)
        Dim difference_day As ULong = Math.Abs(current_day - old_day)
        Dim difference_hour As ULong = Math.Abs(current_hours - old_hours)
        Dim difference_minute As ULong = Math.Abs(current_minute - old_minute)
        Dim difference_seconds As ULong = Math.Abs(current_seconds - old_seconds)

        Dim year_to_seconds As ULong = (difference_year * 365) * 86400
        Dim month_to_seconds As ULong = (difference_month * 30) * 86400
        Dim day_to_seconds As ULong = difference_day * 86400
        Dim hour_to_seconds As ULong = difference_hour * 3600
        Dim minute_to_seconds As ULong = difference_minute * 60

        Dim total_seconds_passed As ULong = difference_seconds + (year_to_seconds + month_to_seconds + day_to_seconds + hour_to_seconds + minute_to_seconds)

        Dim total_fish_tacos_sold As ULong = (total_seconds_passed * 600) + starting_fish_taco_sales
        Dim total_cost_fish_tacos As ULong = (total_fish_tacos_sold * 4.95) * convert_rate

        dateTimeLabel.Text = DateTime.Now().ToString("F", currentCulture)
        If pirate_clicked = True Then
            parseDisneyDate()

        End If
        valueEnteredTextBox.Text = total_fish_tacos_sold.ToString()
        asDisplayedLabel.Text = total_cost_fish_tacos.ToString()
        myRefresh()
    End Sub

End Class
