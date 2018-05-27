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
        Me.usa_box = New System.Windows.Forms.PictureBox()
        Me.mex_box = New System.Windows.Forms.PictureBox()
        Me.image = New System.Windows.Forms.PictureBox()
        CType(Me.usa_box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mex_box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'greeting_label
        '
        Me.greeting_label.Font = New System.Drawing.Font("Lucida Sans Unicode", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.greeting_label.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.greeting_label.Location = New System.Drawing.Point(211, 61)
        Me.greeting_label.Name = "greeting_label"
        Me.greeting_label.Size = New System.Drawing.Size(237, 76)
        Me.greeting_label.TabIndex = 0
        Me.greeting_label.Text = "Good Day"
        Me.greeting_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exit_button
        '
        Me.exit_button.Font = New System.Drawing.Font("Lucida Sans Unicode", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_button.Location = New System.Drawing.Point(460, 289)
        Me.exit_button.Name = "exit_button"
        Me.exit_button.Size = New System.Drawing.Size(135, 64)
        Me.exit_button.TabIndex = 1
        Me.exit_button.Text = "Exit"
        Me.exit_button.UseVisualStyleBackColor = True
        '
        'usa_box
        '
        Me.usa_box.Image = CType(resources.GetObject("usa_box.Image"), System.Drawing.Image)
        Me.usa_box.InitialImage = Nothing
        Me.usa_box.Location = New System.Drawing.Point(186, 196)
        Me.usa_box.Name = "usa_box"
        Me.usa_box.Size = New System.Drawing.Size(140, 75)
        Me.usa_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.usa_box.TabIndex = 2
        Me.usa_box.TabStop = False
        '
        'mex_box
        '
        Me.mex_box.Image = CType(resources.GetObject("mex_box.Image"), System.Drawing.Image)
        Me.mex_box.Location = New System.Drawing.Point(332, 196)
        Me.mex_box.Name = "mex_box"
        Me.mex_box.Size = New System.Drawing.Size(140, 75)
        Me.mex_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mex_box.TabIndex = 3
        Me.mex_box.TabStop = False
        '
        'image
        '
        Me.image.Location = New System.Drawing.Point(476, 61)
        Me.image.Name = "image"
        Me.image.Size = New System.Drawing.Size(140, 75)
        Me.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.image.TabIndex = 4
        Me.image.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 385)
        Me.Controls.Add(Me.image)
        Me.Controls.Add(Me.mex_box)
        Me.Controls.Add(Me.usa_box)
        Me.Controls.Add(Me.exit_button)
        Me.Controls.Add(Me.greeting_label)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.usa_box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mex_box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents greeting_label As Label
    Friend WithEvents exit_button As Button
    Friend WithEvents usa_box As PictureBox
    Friend WithEvents mex_box As PictureBox
    Friend WithEvents image As PictureBox
End Class
