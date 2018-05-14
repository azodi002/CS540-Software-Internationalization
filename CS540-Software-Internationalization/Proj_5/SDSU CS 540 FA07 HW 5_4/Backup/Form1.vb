' SDSU Fall 2009
' CS 540 Example Program 5.4
' RTL Localization Version 4
' VB.NET/VISUAL STUDIO .NET 2003

Imports System
Imports System.Resources
Imports System.ComponentModel

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
    Dim english_resource_set As New ResXResourceSet("english resources.resx")
    Dim spanish_resource_set As New ResXResourceSet("spanish resources.resx")
    Dim arabic_resource_set As New ResXResourceSet("arabic resources.resx")
    Dim current_message As String

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
    Friend WithEvents yesB As System.Windows.Forms.Button
    Friend WithEvents noB As System.Windows.Forms.Button
    Friend WithEvents maybeB As System.Windows.Forms.Button
    Friend WithEvents exitB As System.Windows.Forms.Button
    Friend WithEvents messageL As System.Windows.Forms.Label
    Friend WithEvents american_flagP As System.Windows.Forms.PictureBox
    Friend WithEvents spanish_flagP As System.Windows.Forms.PictureBox
    Friend WithEvents saudi_arabian_flagP As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.yesB = New System.Windows.Forms.Button
        Me.noB = New System.Windows.Forms.Button
        Me.maybeB = New System.Windows.Forms.Button
        Me.messageL = New System.Windows.Forms.Label
        Me.american_flagP = New System.Windows.Forms.PictureBox
        Me.spanish_flagP = New System.Windows.Forms.PictureBox
        Me.saudi_arabian_flagP = New System.Windows.Forms.PictureBox
        Me.exitB = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'yesB
        '
        Me.yesB.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yesB.Location = New System.Drawing.Point(16, 96)
        Me.yesB.Name = "yesB"
        Me.yesB.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.yesB.Size = New System.Drawing.Size(80, 40)
        Me.yesB.TabIndex = 0
        '
        'noB
        '
        Me.noB.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noB.Location = New System.Drawing.Point(104, 96)
        Me.noB.Name = "noB"
        Me.noB.Size = New System.Drawing.Size(80, 40)
        Me.noB.TabIndex = 1
        '
        'maybeB
        '
        Me.maybeB.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maybeB.Location = New System.Drawing.Point(192, 96)
        Me.maybeB.Name = "maybeB"
        Me.maybeB.Size = New System.Drawing.Size(80, 40)
        Me.maybeB.TabIndex = 2
        '
        'messageL
        '
        Me.messageL.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.messageL.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.messageL.Location = New System.Drawing.Point(16, 16)
        Me.messageL.Name = "messageL"
        Me.messageL.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.messageL.Size = New System.Drawing.Size(392, 64)
        Me.messageL.TabIndex = 3
        Me.messageL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'american_flagP
        '
        Me.american_flagP.Image = CType(resources.GetObject("american_flagP.Image"), System.Drawing.Image)
        Me.american_flagP.Location = New System.Drawing.Point(24, 152)
        Me.american_flagP.Name = "american_flagP"
        Me.american_flagP.Size = New System.Drawing.Size(104, 56)
        Me.american_flagP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.american_flagP.TabIndex = 4
        Me.american_flagP.TabStop = False
        '
        'spanish_flagP
        '
        Me.spanish_flagP.Image = CType(resources.GetObject("spanish_flagP.Image"), System.Drawing.Image)
        Me.spanish_flagP.Location = New System.Drawing.Point(152, 152)
        Me.spanish_flagP.Name = "spanish_flagP"
        Me.spanish_flagP.Size = New System.Drawing.Size(120, 56)
        Me.spanish_flagP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.spanish_flagP.TabIndex = 5
        Me.spanish_flagP.TabStop = False
        '
        'saudi_arabian_flagP
        '
        Me.saudi_arabian_flagP.Image = CType(resources.GetObject("saudi_arabian_flagP.Image"), System.Drawing.Image)
        Me.saudi_arabian_flagP.Location = New System.Drawing.Point(296, 152)
        Me.saudi_arabian_flagP.Name = "saudi_arabian_flagP"
        Me.saudi_arabian_flagP.Size = New System.Drawing.Size(112, 56)
        Me.saudi_arabian_flagP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.saudi_arabian_flagP.TabIndex = 6
        Me.saudi_arabian_flagP.TabStop = False
        '
        'exitB
        '
        Me.exitB.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitB.Location = New System.Drawing.Point(320, 96)
        Me.exitB.Name = "exitB"
        Me.exitB.Size = New System.Drawing.Size(88, 40)
        Me.exitB.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 222)
        Me.Controls.Add(Me.exitB)
        Me.Controls.Add(Me.saudi_arabian_flagP)
        Me.Controls.Add(Me.spanish_flagP)
        Me.Controls.Add(Me.american_flagP)
        Me.Controls.Add(Me.messageL)
        Me.Controls.Add(Me.maybeB)
        Me.Controls.Add(Me.noB)
        Me.Controls.Add(Me.yesB)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub exitB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitB.Click
        End
    End Sub

    Private Sub MyRefresh()
        Me.Text = current_resource_set.GetString("FormTitle")
        yesB.Text = current_resource_set.GetString("Yes")
        noB.Text = current_resource_set.GetString("No")
        maybeB.Text = current_resource_set.GetString("Maybe")
        exitB.Text = current_resource_set.GetString("Exit")
        messageL.Text = ""
    End Sub

    Private Sub SetArabic()
        current_resource_set = arabic_resource_set
        Me.Mirrored() = True
        yesB.RightToLeft = RightToLeft.No
        noB.RightToLeft = RightToLeft.No
        MyRefresh()
    End Sub

    Private Sub SetSpanish()
        current_resource_set = spanish_resource_set
        Me.Mirrored() = False
        MyRefresh()
    End Sub

    Private Sub SetEnglish()
        current_resource_set = english_resource_set
        Me.Mirrored() = False
        MyRefresh()
    End Sub

    Private Sub us_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles american_flagP.Click
        SetEnglish()
    End Sub

    Private Sub mx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spanish_flagP.Click
        SetSpanish()
    End Sub

    Private Sub arab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saudi_arabian_flagP.Click
        SetArabic()
    End Sub

    Private Sub yesB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yesB.Click
        messageL.Text = current_resource_set.GetString("YesMessage")
    End Sub

    Private Sub noB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noB.Click
        messageL.Text = current_resource_set.GetString("NoMessage")
    End Sub

    Private Sub maybeB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maybeB.Click
        messageL.Text = current_resource_set.GetString("MaybeMessage")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        current_resource_set = english_resource_set
        MyRefresh()
    End Sub
End Class

