<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class start_app
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(start_app))
        Me.greeting_label = New System.Windows.Forms.Label()
        Me.exit_button = New System.Windows.Forms.Button()
        Me.usa_pic_box = New System.Windows.Forms.PictureBox()
        Me.mex_pic_box = New System.Windows.Forms.PictureBox()
        CType(Me.usa_pic_box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mex_pic_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'greeting_label
        '
        Me.greeting_label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.greeting_label.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.greeting_label.Font = New System.Drawing.Font("Lucida Sans Unicode", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.greeting_label.Location = New System.Drawing.Point(292, 104)
        Me.greeting_label.Name = "greeting_label"
        Me.greeting_label.Size = New System.Drawing.Size(440, 166)
        Me.greeting_label.TabIndex = 0
        Me.greeting_label.Text = "Good Day!"
        Me.greeting_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exit_button
        '
        Me.exit_button.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.exit_button.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_button.Location = New System.Drawing.Point(790, 406)
        Me.exit_button.Name = "exit_button"
        Me.exit_button.Size = New System.Drawing.Size(167, 60)
        Me.exit_button.TabIndex = 1
        Me.exit_button.Text = "Exit"
        Me.exit_button.UseVisualStyleBackColor = False
        '
        'usa_pic_box
        '
        Me.usa_pic_box.Image = CType(resources.GetObject("usa_pic_box.Image"), System.Drawing.Image)
        Me.usa_pic_box.Location = New System.Drawing.Point(280, 308)
        Me.usa_pic_box.Name = "usa_pic_box"
        Me.usa_pic_box.Size = New System.Drawing.Size(218, 129)
        Me.usa_pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.usa_pic_box.TabIndex = 2
        Me.usa_pic_box.TabStop = False
        '
        'mex_pic_box
        '
        Me.mex_pic_box.Image = CType(resources.GetObject("mex_pic_box.Image"), System.Drawing.Image)
        Me.mex_pic_box.Location = New System.Drawing.Point(514, 308)
        Me.mex_pic_box.Name = "mex_pic_box"
        Me.mex_pic_box.Size = New System.Drawing.Size(218, 129)
        Me.mex_pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mex_pic_box.TabIndex = 3
        Me.mex_pic_box.TabStop = False
        '
        'start_app
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 499)
        Me.Controls.Add(Me.mex_pic_box)
        Me.Controls.Add(Me.usa_pic_box)
        Me.Controls.Add(Me.exit_button)
        Me.Controls.Add(Me.greeting_label)
        Me.Name = "start_app"
        Me.Text = "Form1"
        CType(Me.usa_pic_box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mex_pic_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents greeting_label As Label
    Friend WithEvents exit_button As Button
    Friend WithEvents usa_pic_box As PictureBox
    Friend WithEvents mex_pic_box As PictureBox
End Class
