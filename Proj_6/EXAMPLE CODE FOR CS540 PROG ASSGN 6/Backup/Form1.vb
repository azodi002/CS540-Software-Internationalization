Imports System
Imports System.Globalization
Imports System.Threading

Public Class Form1

    Inherits System.Windows.Forms.Form

    Dim currentCulture As CultureInfo

    Dim usaCulture As CultureInfo = New CultureInfo("en-US")
    Dim ukCulture As CultureInfo = New CultureInfo("en-GB")
    Dim indiaCulture As CultureInfo = New CultureInfo("hi-In")
    Dim saudiCulture As CultureInfo = New CultureInfo("ar-SA")
    Dim germanCulture As CultureInfo = New CultureInfo("de-DE")
    Dim pirateCulture As CultureInfo = New CultureInfo("")  'note use of invariant culture as constructor argument

    Dim dateTime As DateTime = New DateTime(0)

    Dim displayMode As String

    Dim arabic_digits As Char() = {"۰"c, "١"c, "٢"c, "٣"c, "٤"c, "٥"c, "٦"c, "٧"c, "٨"c, "٩"c}
    Dim hindi_digits As Char() = {"०"c, "१"c, "२"c, "३"c, "४"c, "५"c, "६"c, "७"c, "८"c, "९"c}
    Dim latin_digits As Char() = {"0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c}
    Dim arabic_digits_enabled As Boolean
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
    Friend WithEvents asCurrencyButton As System.Windows.Forms.Button
    Friend WithEvents asNumberButton As System.Windows.Forms.Button
    Friend WithEvents asDisplayedCaptionLabel As System.Windows.Forms.Label
    Friend WithEvents valueEnteredCaptionLabel As System.Windows.Forms.Label
    Friend WithEvents valueEnteredTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ukFlagPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents saudiFlagPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents germanFlagPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents dateTimeLabel As System.Windows.Forms.Label
    Friend WithEvents dateTimeCaptionLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents hindiButton As System.Windows.Forms.Button
    Friend WithEvents latinButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.usaFlagPictureBox = New System.Windows.Forms.PictureBox
        Me.indiaFlagPictureBox = New System.Windows.Forms.PictureBox
        Me.pirateFlagPictureBox = New System.Windows.Forms.PictureBox
        Me.asDisplayedLabel = New System.Windows.Forms.Label
        Me.valueEnteredTextBox = New System.Windows.Forms.TextBox
        Me.asCurrencyButton = New System.Windows.Forms.Button
        Me.asNumberButton = New System.Windows.Forms.Button
        Me.asDisplayedCaptionLabel = New System.Windows.Forms.Label
        Me.valueEnteredCaptionLabel = New System.Windows.Forms.Label
        Me.ukFlagPictureBox = New System.Windows.Forms.PictureBox
        Me.saudiFlagPictureBox = New System.Windows.Forms.PictureBox
        Me.germanFlagPictureBox = New System.Windows.Forms.PictureBox
        Me.dateTimeLabel = New System.Windows.Forms.Label
        Me.dateTimeCaptionLabel = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.hindiButton = New System.Windows.Forms.Button
        Me.latinButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'usaFlagPictureBox
        '
        Me.usaFlagPictureBox.Image = CType(resources.GetObject("usaFlagPictureBox.Image"), System.Drawing.Image)
        Me.usaFlagPictureBox.Location = New System.Drawing.Point(77, 286)
        Me.usaFlagPictureBox.Name = "usaFlagPictureBox"
        Me.usaFlagPictureBox.Size = New System.Drawing.Size(134, 83)
        Me.usaFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.usaFlagPictureBox.TabIndex = 0
        Me.usaFlagPictureBox.TabStop = False
        '
        'indiaFlagPictureBox
        '
        Me.indiaFlagPictureBox.Image = CType(resources.GetObject("indiaFlagPictureBox.Image"), System.Drawing.Image)
        Me.indiaFlagPictureBox.Location = New System.Drawing.Point(230, 286)
        Me.indiaFlagPictureBox.Name = "indiaFlagPictureBox"
        Me.indiaFlagPictureBox.Size = New System.Drawing.Size(135, 83)
        Me.indiaFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.indiaFlagPictureBox.TabIndex = 1
        Me.indiaFlagPictureBox.TabStop = False
        '
        'pirateFlagPictureBox
        '
        Me.pirateFlagPictureBox.Image = CType(resources.GetObject("pirateFlagPictureBox.Image"), System.Drawing.Image)
        Me.pirateFlagPictureBox.Location = New System.Drawing.Point(384, 286)
        Me.pirateFlagPictureBox.Name = "pirateFlagPictureBox"
        Me.pirateFlagPictureBox.Size = New System.Drawing.Size(134, 83)
        Me.pirateFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pirateFlagPictureBox.TabIndex = 2
        Me.pirateFlagPictureBox.TabStop = False
        '
        'asDisplayedLabel
        '
        Me.asDisplayedLabel.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
        Me.asDisplayedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.asDisplayedLabel.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.asDisplayedLabel.Location = New System.Drawing.Point(77, 28)
        Me.asDisplayedLabel.Name = "asDisplayedLabel"
        Me.asDisplayedLabel.Size = New System.Drawing.Size(441, 46)
        Me.asDisplayedLabel.TabIndex = 3
        Me.asDisplayedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'valueEnteredTextBox
        '
        Me.valueEnteredTextBox.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueEnteredTextBox.Location = New System.Drawing.Point(86, 111)
        Me.valueEnteredTextBox.Name = "valueEnteredTextBox"
        Me.valueEnteredTextBox.Size = New System.Drawing.Size(432, 56)
        Me.valueEnteredTextBox.TabIndex = 4
        Me.valueEnteredTextBox.Text = ""
        Me.valueEnteredTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'asCurrencyButton
        '
        Me.asCurrencyButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asCurrencyButton.Location = New System.Drawing.Point(307, 212)
        Me.asCurrencyButton.Name = "asCurrencyButton"
        Me.asCurrencyButton.Size = New System.Drawing.Size(211, 28)
        Me.asCurrencyButton.TabIndex = 5
        Me.asCurrencyButton.Text = "AS CURRENCY (C)"
        '
        'asNumberButton
        '
        Me.asNumberButton.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asNumberButton.Location = New System.Drawing.Point(77, 212)
        Me.asNumberButton.Name = "asNumberButton"
        Me.asNumberButton.Size = New System.Drawing.Size(221, 28)
        Me.asNumberButton.TabIndex = 6
        Me.asNumberButton.Text = "AS NUMBER (N)"
        '
        'asDisplayedCaptionLabel
        '
        Me.asDisplayedCaptionLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asDisplayedCaptionLabel.Location = New System.Drawing.Point(211, 74)
        Me.asDisplayedCaptionLabel.Name = "asDisplayedCaptionLabel"
        Me.asDisplayedCaptionLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.asDisplayedCaptionLabel.Size = New System.Drawing.Size(183, 28)
        Me.asDisplayedCaptionLabel.TabIndex = 7
        Me.asDisplayedCaptionLabel.Text = "AS DISPLAYED"
        Me.asDisplayedCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'valueEnteredCaptionLabel
        '
        Me.valueEnteredCaptionLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueEnteredCaptionLabel.Location = New System.Drawing.Point(208, 168)
        Me.valueEnteredCaptionLabel.Name = "valueEnteredCaptionLabel"
        Me.valueEnteredCaptionLabel.Size = New System.Drawing.Size(183, 28)
        Me.valueEnteredCaptionLabel.TabIndex = 8
        Me.valueEnteredCaptionLabel.Text = "VALUE ENTERED"
        Me.valueEnteredCaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ukFlagPictureBox
        '
        Me.ukFlagPictureBox.Image = CType(resources.GetObject("ukFlagPictureBox.Image"), System.Drawing.Image)
        Me.ukFlagPictureBox.Location = New System.Drawing.Point(77, 406)
        Me.ukFlagPictureBox.Name = "ukFlagPictureBox"
        Me.ukFlagPictureBox.Size = New System.Drawing.Size(134, 83)
        Me.ukFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ukFlagPictureBox.TabIndex = 9
        Me.ukFlagPictureBox.TabStop = False
        '
        'saudiFlagPictureBox
        '
        Me.saudiFlagPictureBox.Image = CType(resources.GetObject("saudiFlagPictureBox.Image"), System.Drawing.Image)
        Me.saudiFlagPictureBox.Location = New System.Drawing.Point(230, 406)
        Me.saudiFlagPictureBox.Name = "saudiFlagPictureBox"
        Me.saudiFlagPictureBox.Size = New System.Drawing.Size(135, 83)
        Me.saudiFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.saudiFlagPictureBox.TabIndex = 10
        Me.saudiFlagPictureBox.TabStop = False
        '
        'germanFlagPictureBox
        '
        Me.germanFlagPictureBox.Image = CType(resources.GetObject("germanFlagPictureBox.Image"), System.Drawing.Image)
        Me.germanFlagPictureBox.Location = New System.Drawing.Point(384, 406)
        Me.germanFlagPictureBox.Name = "germanFlagPictureBox"
        Me.germanFlagPictureBox.Size = New System.Drawing.Size(134, 83)
        Me.germanFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.germanFlagPictureBox.TabIndex = 11
        Me.germanFlagPictureBox.TabStop = False
        '
        'dateTimeLabel
        '
        Me.dateTimeLabel.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
        Me.dateTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dateTimeLabel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimeLabel.Location = New System.Drawing.Point(77, 517)
        Me.dateTimeLabel.Name = "dateTimeLabel"
        Me.dateTimeLabel.Size = New System.Drawing.Size(441, 55)
        Me.dateTimeLabel.TabIndex = 12
        Me.dateTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dateTimeCaptionLabel
        '
        Me.dateTimeCaptionLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimeCaptionLabel.Location = New System.Drawing.Point(202, 572)
        Me.dateTimeCaptionLabel.Name = "dateTimeCaptionLabel"
        Me.dateTimeCaptionLabel.Size = New System.Drawing.Size(182, 28)
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
        Me.hindiButton.Location = New System.Drawing.Point(298, 378)
        Me.hindiButton.Name = "hindiButton"
        Me.hindiButton.Size = New System.Drawing.Size(67, 19)
        Me.hindiButton.TabIndex = 14
        Me.hindiButton.Text = "HINDI"
        '
        'latinButton
        '
        Me.latinButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.latinButton.Location = New System.Drawing.Point(230, 378)
        Me.latinButton.Name = "latinButton"
        Me.latinButton.Size = New System.Drawing.Size(68, 19)
        Me.latinButton.TabIndex = 15
        Me.latinButton.Text = "LATIN"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(595, 614)
        Me.Controls.Add(Me.latinButton)
        Me.Controls.Add(Me.hindiButton)
        Me.Controls.Add(Me.dateTimeCaptionLabel)
        Me.Controls.Add(Me.dateTimeLabel)
        Me.Controls.Add(Me.germanFlagPictureBox)
        Me.Controls.Add(Me.saudiFlagPictureBox)
        Me.Controls.Add(Me.ukFlagPictureBox)
        Me.Controls.Add(Me.valueEnteredCaptionLabel)
        Me.Controls.Add(Me.asDisplayedCaptionLabel)
        Me.Controls.Add(Me.asNumberButton)
        Me.Controls.Add(Me.asCurrencyButton)
        Me.Controls.Add(Me.valueEnteredTextBox)
        Me.Controls.Add(Me.asDisplayedLabel)
        Me.Controls.Add(Me.pirateFlagPictureBox)
        Me.Controls.Add(Me.indiaFlagPictureBox)
        Me.Controls.Add(Me.usaFlagPictureBox)
        Me.Name = "Form1"
        Me.Text = "SDSU CS-596 Software Globalization     Number Formatting Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub xlt_digits_to_A(ByRef latin As String)
        Dim i As Integer
        For i = 0 To 9
            latin = latin.Replace(latin_digits(i), arabic_digits(i))
        Next i
    End Sub

    Private Sub xlt_digits_to_H(ByRef latin As String)
        Dim i As Integer
        For i = 0 To 9
            latin = latin.Replace(latin_digits(i), hindi_digits(i))
        Next i
    End Sub

    Private Sub definePirateCulture()
        Dim pirateCurrencyGroupSizes As Integer() = {1, 2}
        Dim pirateNumberGroupSizes As Integer() = {3, 1}
        pirateCulture.NumberFormat.CurrencyDecimalDigits = 2
        pirateCulture.NumberFormat.CurrencyDecimalSeparator = "?"
        pirateCulture.NumberFormat.CurrencyGroupSizes = pirateCurrencyGroupSizes
        pirateCulture.NumberFormat.CurrencyGroupSeparator = ":"
        pirateCulture.NumberFormat.CurrencySymbol = "฿"
        pirateCulture.NumberFormat.CurrencyPositivePattern = 1
        pirateCulture.NumberFormat.NumberDecimalDigits = 3
        pirateCulture.NumberFormat.NumberDecimalSeparator = "%"
        pirateCulture.NumberFormat.NumberGroupSizes = pirateNumberGroupSizes
        pirateCulture.NumberFormat.NumberGroupSeparator = "#"
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
        Dim i As Integer
        Thread.CurrentThread.CurrentUICulture = currentCulture
        If valueEnteredTextBox.Text <> "" Then asDisplayedLabel.Text = CDbl(valueEnteredTextBox.Text).ToString(displayMode, currentCulture)
        If hindi_digits_enabled Then
            xlt_digits_to_H(asDisplayedLabel.Text)
            xlt_digits_to_H(dateTimeLabel.Text)
        ElseIf arabic_digits_enabled Then
            xlt_digits_to_A(asDisplayedLabel.Text)
            xlt_digits_to_A(dateTimeLabel.Text)
        End If
    End Sub

    Private Sub usaFlagPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usaFlagPictureBox.Click
        currentCulture = usaCulture
        myRefresh()
    End Sub

    Private Sub indiaFlagPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles indiaFlagPictureBox.Click
        currentCulture = indiaCulture
        indiaCulture.NumberFormat.CurrencySymbol = latin_India_currency_symbol
        arabic_digits_enabled = False
        hindi_digits_enabled = False
        latin_digits_enabled = True
        myRefresh()
    End Sub

    Private Sub latinButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles latinButton.Click
        indiaCulture.NumberFormat.CurrencySymbol = latin_India_currency_symbol
        arabic_digits_enabled = False
        hindi_digits_enabled = False
        latin_digits_enabled = True
        myRefresh()
    End Sub

    Private Sub hindiButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hindiButton.Click
        indiaCulture.NumberFormat.CurrencySymbol = hindi_India_currency_symbol
        arabic_digits_enabled = False
        hindi_digits_enabled = True
        latin_digits_enabled = False
        myRefresh()
    End Sub

    Private Sub pirateFlagPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pirateFlagPictureBox.Click
        currentCulture = pirateCulture
        arabic_digits_enabled = False
        hindi_digits_enabled = False
        latin_digits_enabled = True
        myRefresh()
    End Sub

    Private Sub ukFlagPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ukFlagPictureBox.Click
        currentCulture = ukCulture
        arabic_digits_enabled = False
        hindi_digits_enabled = False
        latin_digits_enabled = True
        myRefresh()
    End Sub

    Private Sub saudiFlagPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saudiFlagPictureBox.Click
        currentCulture = saudiCulture
        arabic_digits_enabled = True
        hindi_digits_enabled = False
        latin_digits_enabled = False
        myRefresh()
    End Sub

    Private Sub germanFlagPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles germanFlagPictureBox.Click
        currentCulture = germanCulture
        arabic_digits_enabled = False
        hindi_digits_enabled = False
        latin_digits_enabled = True
        myRefresh()
    End Sub

    Private Sub asNumberButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles asNumberButton.Click
        displayMode = "N"
        myRefresh()
    End Sub

    Private Sub asCurrencyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles asCurrencyButton.Click
        displayMode = "C"
        myRefresh()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        dateTimeLabel.Text = dateTime.Now().ToString("F", currentCulture)
        myRefresh()
    End Sub

End Class
