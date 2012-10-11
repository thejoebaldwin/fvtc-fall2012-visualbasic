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
        Me.btnDrive = New System.Windows.Forms.Button()
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDrive
        '
        Me.btnDrive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrive.Location = New System.Drawing.Point(158, 34)
        Me.btnDrive.Name = "btnDrive"
        Me.btnDrive.Size = New System.Drawing.Size(163, 64)
        Me.btnDrive.TabIndex = 0
        Me.btnDrive.Text = "Drive 20 miles"
        Me.btnDrive.UseVisualStyleBackColor = True
        '
        'lblMiles
        '
        Me.lblMiles.AutoSize = True
        Me.lblMiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiles.Location = New System.Drawing.Point(255, 135)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(95, 24)
        Me.lblMiles.TabIndex = 1
        Me.lblMiles.Text = "<lblMiles>"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Miles:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 262)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMiles)
        Me.Controls.Add(Me.btnDrive)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDrive As System.Windows.Forms.Button
    Friend WithEvents lblMiles As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
