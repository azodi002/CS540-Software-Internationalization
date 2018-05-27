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
        Me.input_text = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.unsort_text = New System.Windows.Forms.TextBox()
        Me.sort_text = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sort_button = New System.Windows.Forms.Button()
        Me.exit_button = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'input_text
        '
        Me.input_text.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_text.Location = New System.Drawing.Point(132, 65)
        Me.input_text.Name = "input_text"
        Me.input_text.Size = New System.Drawing.Size(430, 44)
        Me.input_text.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Path to Input Text File"
        '
        'unsort_text
        '
        Me.unsort_text.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unsort_text.Location = New System.Drawing.Point(36, 184)
        Me.unsort_text.Multiline = True
        Me.unsort_text.Name = "unsort_text"
        Me.unsort_text.Size = New System.Drawing.Size(290, 313)
        Me.unsort_text.TabIndex = 2
        '
        'sort_text
        '
        Me.sort_text.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sort_text.Location = New System.Drawing.Point(378, 194)
        Me.sort_text.Multiline = True
        Me.sort_text.Name = "sort_text"
        Me.sort_text.Size = New System.Drawing.Size(291, 313)
        Me.sort_text.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Unsorted Text"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(423, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sorted Text"
        '
        'sort_button
        '
        Me.sort_button.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sort_button.Location = New System.Drawing.Point(219, 513)
        Me.sort_button.Name = "sort_button"
        Me.sort_button.Size = New System.Drawing.Size(246, 44)
        Me.sort_button.TabIndex = 6
        Me.sort_button.Text = "Read and Sort"
        Me.sort_button.UseVisualStyleBackColor = True
        '
        'exit_button
        '
        Me.exit_button.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_button.Location = New System.Drawing.Point(569, 567)
        Me.exit_button.Name = "exit_button"
        Me.exit_button.Size = New System.Drawing.Size(146, 44)
        Me.exit_button.TabIndex = 7
        Me.exit_button.Text = "Exit"
        Me.exit_button.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(375, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(294, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Language/Locale-Sensitive Sort Order Used"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 623)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.exit_button)
        Me.Controls.Add(Me.sort_button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sort_text)
        Me.Controls.Add(Me.unsort_text)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.input_text)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents input_text As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents unsort_text As TextBox
    Friend WithEvents sort_text As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents sort_button As Button
    Friend WithEvents exit_button As Button
    Friend WithEvents Label4 As Label
End Class
