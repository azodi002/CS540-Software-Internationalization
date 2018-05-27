<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.greeting_label = New System.Windows.Forms.Label()
        Me.exit_button = New System.Windows.Forms.Button()
        Me.us_box = New System.Windows.Forms.PictureBox()
        Me.mex_box = New System.Windows.Forms.PictureBox()
        CType(Me.us_box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mex_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'greeting_label
        '
        resources.ApplyResources(Me.greeting_label, "greeting_label")
        Me.greeting_label.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.greeting_label.Name = "greeting_label"
        '
        'exit_button
        '
        resources.ApplyResources(Me.exit_button, "exit_button")
        Me.exit_button.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.exit_button.Name = "exit_button"
        Me.exit_button.TabStop = False
        Me.exit_button.UseVisualStyleBackColor = False
        '
        'us_box
        '
        resources.ApplyResources(Me.us_box, "us_box")
        Me.us_box.Name = "us_box"
        Me.us_box.TabStop = False
        '
        'mex_box
        '
        resources.ApplyResources(Me.mex_box, "mex_box")
        Me.mex_box.Name = "mex_box"
        Me.mex_box.TabStop = False
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.mex_box)
        Me.Controls.Add(Me.us_box)
        Me.Controls.Add(Me.exit_button)
        Me.Controls.Add(Me.greeting_label)
        Me.Name = "Form1"
        CType(Me.us_box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mex_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents greeting_label As Label
    Friend WithEvents exit_button As Button
    Friend WithEvents us_box As PictureBox
    Friend WithEvents mex_box As PictureBox
End Class
