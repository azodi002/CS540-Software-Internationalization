' SDSU Fall 2018
' CS 540 Homework Prog. Assignment. 10

Imports System
Imports System.Resources
Imports System.ComponentModel
Imports System.IO
Imports System.Reflection
Imports System.Threading
Imports System.Windows.Forms
Imports System.Collections

Public Class Form1
    Inherits System.Windows.Forms.Form
    Const WS_EX_LAYOUTRTL = &H400000
    Const WS_EX_NOINHERITLAYOUT = &H100000

    '========================================================================================
    'code to implement on-the-fly whole-form mirroring with no inheritance
    '========================================================================================

    Private _mirrored As Boolean = False
    <Description("Change to the right-to-left layout."), _
    DefaultValue(False), Localizable(True), _
    Category("Appearance"), Browsable(True)> _
    Public Property Mirrored() As Boolean
        Get
            Return _mirrored
        End Get
        Set(ByVal Value As Boolean)
            If _mirrored <> Value Then
                _mirrored = Value
                MyBase.OnRightToLeftChanged(EventArgs.Empty)
            End If
        End Set
    End Property

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim CP As System.Windows.Forms.CreateParams = MyBase.CreateParams
            If Mirrored Then
                CP.ExStyle = CP.ExStyle Or WS_EX_LAYOUTRTL Or WS_EX_NOINHERITLAYOUT
            End If
            Return CP
        End Get
    End Property

    '========================================================================================
    '========================================================================================
    '========================================================================================

    Dim current_resource_set As ResXResourceSet
    Dim english_resource_set As New ResXResourceSet("mx.resx")
    Dim arabic_resource_set As New ResXResourceSet("ar.resx")
    Dim mex_resource_set As New ResXResourceSet("mexican.resx")
    Dim canada_resource_set As New ResXResourceSet("canada.resx")
    Friend WithEvents pic_box As PictureBox
    Friend WithEvents greeting_label As Label
    Friend WithEvents mex_box As PictureBox
    Friend WithEvents canada As PictureBox
    Dim current_message As String


    Dim files_in_directory As String() = Directory.GetFiles(Application.StartupPath)
    Dim file As String


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
    Friend WithEvents exitB As System.Windows.Forms.Button
    Friend WithEvents american_flagP As System.Windows.Forms.PictureBox
    Friend WithEvents saudi_arabian_flagP As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.american_flagP = New System.Windows.Forms.PictureBox()
        Me.saudi_arabian_flagP = New System.Windows.Forms.PictureBox()
        Me.exitB = New System.Windows.Forms.Button()
        Me.pic_box = New System.Windows.Forms.PictureBox()
        Me.greeting_label = New System.Windows.Forms.Label()
        Me.mex_box = New System.Windows.Forms.PictureBox()
        Me.canada = New System.Windows.Forms.PictureBox()
        CType(Me.american_flagP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.saudi_arabian_flagP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mex_box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.canada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'american_flagP
        '
        Me.american_flagP.Image = CType(resources.GetObject("american_flagP.Image"), System.Drawing.Image)
        Me.american_flagP.Location = New System.Drawing.Point(4, 404)
        Me.american_flagP.Name = "american_flagP"
        Me.american_flagP.Size = New System.Drawing.Size(166, 94)
        Me.american_flagP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.american_flagP.TabIndex = 4
        Me.american_flagP.TabStop = False
        '
        'saudi_arabian_flagP
        '
        Me.saudi_arabian_flagP.Image = CType(resources.GetObject("saudi_arabian_flagP.Image"), System.Drawing.Image)
        Me.saudi_arabian_flagP.Location = New System.Drawing.Point(7, 301)
        Me.saudi_arabian_flagP.Name = "saudi_arabian_flagP"
        Me.saudi_arabian_flagP.Size = New System.Drawing.Size(163, 97)
        Me.saudi_arabian_flagP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.saudi_arabian_flagP.TabIndex = 6
        Me.saudi_arabian_flagP.TabStop = False
        '
        'exitB
        '
        Me.exitB.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitB.Location = New System.Drawing.Point(236, 443)
        Me.exitB.Name = "exitB"
        Me.exitB.Size = New System.Drawing.Size(196, 49)
        Me.exitB.TabIndex = 7
        '
        'pic_box
        '
        Me.pic_box.Location = New System.Drawing.Point(183, 154)
        Me.pic_box.Name = "pic_box"
        Me.pic_box.Size = New System.Drawing.Size(336, 229)
        Me.pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_box.TabIndex = 8
        Me.pic_box.TabStop = False
        '
        'greeting_label
        '
        Me.greeting_label.BackColor = System.Drawing.SystemColors.ControlDark
        Me.greeting_label.Font = New System.Drawing.Font("Lucida Sans Unicode", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.greeting_label.Location = New System.Drawing.Point(183, 33)
        Me.greeting_label.Name = "greeting_label"
        Me.greeting_label.Size = New System.Drawing.Size(306, 72)
        Me.greeting_label.TabIndex = 9
        Me.greeting_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mex_box
        '
        Me.mex_box.Image = CType(resources.GetObject("mex_box.Image"), System.Drawing.Image)
        Me.mex_box.Location = New System.Drawing.Point(7, 193)
        Me.mex_box.Name = "mex_box"
        Me.mex_box.Size = New System.Drawing.Size(163, 102)
        Me.mex_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mex_box.TabIndex = 10
        Me.mex_box.TabStop = False
        '
        'canada
        '
        Me.canada.Image = CType(resources.GetObject("canada.Image"), System.Drawing.Image)
        Me.canada.Location = New System.Drawing.Point(7, 86)
        Me.canada.Name = "canada"
        Me.canada.Size = New System.Drawing.Size(163, 101)
        Me.canada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.canada.TabIndex = 11
        Me.canada.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(553, 504)
        Me.Controls.Add(Me.canada)
        Me.Controls.Add(Me.mex_box)
        Me.Controls.Add(Me.greeting_label)
        Me.Controls.Add(Me.pic_box)
        Me.Controls.Add(Me.exitB)
        Me.Controls.Add(Me.saudi_arabian_flagP)
        Me.Controls.Add(Me.american_flagP)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        CType(Me.american_flagP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.saudi_arabian_flagP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mex_box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.canada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub exitB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitB.Click
        End
    End Sub

    Private Sub MyRefresh()
        Me.Text = current_resource_set.GetString("FormTitle")
        exitB.Text = current_resource_set.GetString("Exit")
        greeting_label.Text = current_resource_set.GetString("greeting_label")
        pic_box.Image = current_resource_set.GetObject("pic_box", True)
    End Sub

    Private Sub SetArabic()
        For Each file In files_in_directory
            If file.EndsWith(".resX") Then
                Dim Resources As ResXResourceSet = New ResXResourceSet(file)
                'pic_box.Image = Image.FromFile(Resources.GetString("pic_box"))
                If Resources.GetString("greeting_label") <> "" Then
                    greeting_label.Text = Resources.GetString("greeting_label")
                Else
                    greeting_label.Text = "our default"
                End If
                If Resources.GetString("Exit") <> "" Then
                    exitB.Text = Resources.GetString("Exit")
                Else
                    exitB.Text = "our default"
                End If
            End If
        Next file
        current_resource_set = arabic_resource_set
        Me.Mirrored() = True
        'MyRefresh()
    End Sub


    Private Sub SetEnglish()
        current_resource_set = english_resource_set
        Me.Mirrored() = False
        MyRefresh()
    End Sub

    Private Sub SetMexican()
        current_resource_set = mex_resource_set
        Me.Mirrored() = False
        MyRefresh()
    End Sub

    Private Sub SetMapleBacon()
        current_resource_set = canada_resource_set
        Me.Mirrored() = False
        MyRefresh()
    End Sub


    Private Sub us_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles american_flagP.Click
        SetEnglish()
    End Sub


    Private Sub arab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saudi_arabian_flagP.Click
        SetArabic()
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        current_resource_set = english_resource_set
        SetEnglish()
    End Sub

    Private Sub mex_box_Click(sender As Object, e As EventArgs) Handles mex_box.Click
        SetMexican()
    End Sub

    Private Sub canada_Click(sender As Object, e As EventArgs) Handles canada.Click
        SetMapleBacon()
    End Sub
End Class

