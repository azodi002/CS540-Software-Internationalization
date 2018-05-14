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
        Me.control_label = New System.Windows.Forms.Label()
        Me.font_label = New System.Windows.Forms.Label()
        Me.next_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'control_label
        '
        Me.control_label.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.control_label.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.control_label.Location = New System.Drawing.Point(59, 35)
        Me.control_label.Name = "control_label"
        Me.control_label.Size = New System.Drawing.Size(299, 125)
        Me.control_label.TabIndex = 0
        Me.control_label.Text = "resizeControlLabel"
        Me.control_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'font_label
        '
        Me.font_label.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.font_label.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.font_label.Location = New System.Drawing.Point(404, 35)
        Me.font_label.Name = "font_label"
        Me.font_label.Size = New System.Drawing.Size(270, 125)
        Me.font_label.TabIndex = 1
        Me.font_label.Text = "resizeFontLabel"
        Me.font_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'next_button
        '
        Me.next_button.Location = New System.Drawing.Point(146, 255)
        Me.next_button.Name = "next_button"
        Me.next_button.Size = New System.Drawing.Size(425, 63)
        Me.next_button.TabIndex = 2
        Me.next_button.Text = "NEXT"
        Me.next_button.UseCompatibleTextRendering = True
        Me.next_button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 557)
        Me.Controls.Add(Me.next_button)
        Me.Controls.Add(Me.font_label)
        Me.Controls.Add(Me.control_label)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents control_label As Label
    Friend WithEvents font_label As Label
    Friend WithEvents next_button As Button
End Class
