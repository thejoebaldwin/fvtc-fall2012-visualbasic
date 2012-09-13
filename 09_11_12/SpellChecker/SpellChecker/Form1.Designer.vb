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
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.btnSpellCheck = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtWord
        '
        Me.txtWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWord.Location = New System.Drawing.Point(17, 32)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(100, 29)
        Me.txtWord.TabIndex = 0
        '
        'btnSpellCheck
        '
        Me.btnSpellCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpellCheck.Location = New System.Drawing.Point(123, 32)
        Me.btnSpellCheck.Name = "btnSpellCheck"
        Me.btnSpellCheck.Size = New System.Drawing.Size(134, 29)
        Me.btnSpellCheck.TabIndex = 1
        Me.btnSpellCheck.Text = "Spell Check"
        Me.btnSpellCheck.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(49, 82)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(103, 24)
        Me.lblResult.TabIndex = 2
        Me.lblResult.Text = "<lblResult>"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(277, 135)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(10, 10)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(30, 146)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(199, 147)
        Me.ListBox1.TabIndex = 4
        '
        'Form1
        '
        Me.AcceptButton = Me.btnSpellCheck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(288, 331)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnSpellCheck)
        Me.Controls.Add(Me.txtWord)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents btnSpellCheck As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
