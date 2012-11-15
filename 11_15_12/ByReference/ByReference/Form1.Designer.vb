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
        Me.btnByValue = New System.Windows.Forms.Button()
        Me.btnByReference = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAfterValue = New System.Windows.Forms.Label()
        Me.lblBeforeValue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnByValue
        '
        Me.btnByValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnByValue.Location = New System.Drawing.Point(235, 141)
        Me.btnByValue.Name = "btnByValue"
        Me.btnByValue.Size = New System.Drawing.Size(119, 45)
        Me.btnByValue.TabIndex = 0
        Me.btnByValue.Text = "Value"
        Me.btnByValue.UseVisualStyleBackColor = True
        '
        'btnByReference
        '
        Me.btnByReference.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnByReference.Location = New System.Drawing.Point(108, 141)
        Me.btnByReference.Name = "btnByReference"
        Me.btnByReference.Size = New System.Drawing.Size(119, 45)
        Me.btnByReference.TabIndex = 2
        Me.btnByReference.Text = "Reference"
        Me.btnByReference.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "After Button Click myValue = "
        '
        'lblAfterValue
        '
        Me.lblAfterValue.AutoSize = True
        Me.lblAfterValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfterValue.Location = New System.Drawing.Point(284, 91)
        Me.lblAfterValue.Name = "lblAfterValue"
        Me.lblAfterValue.Size = New System.Drawing.Size(138, 24)
        Me.lblAfterValue.TabIndex = 4
        Me.lblAfterValue.Text = "<lblAfterValue>"
        '
        'lblBeforeValue
        '
        Me.lblBeforeValue.AutoSize = True
        Me.lblBeforeValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeforeValue.Location = New System.Drawing.Point(286, 35)
        Me.lblBeforeValue.Name = "lblBeforeValue"
        Me.lblBeforeValue.Size = New System.Drawing.Size(155, 24)
        Me.lblBeforeValue.TabIndex = 5
        Me.lblBeforeValue.Text = "<lblBeforeValue>"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Before Button Click myValue = "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 237)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBeforeValue)
        Me.Controls.Add(Me.lblAfterValue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnByReference)
        Me.Controls.Add(Me.btnByValue)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnByValue As System.Windows.Forms.Button
    Friend WithEvents btnByReference As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAfterValue As System.Windows.Forms.Label
    Friend WithEvents lblBeforeValue As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
