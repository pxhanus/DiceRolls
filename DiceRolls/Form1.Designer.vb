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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumRolls = New System.Windows.Forms.TextBox()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.btnRollDice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of rolls:"
        '
        'txtNumRolls
        '
        Me.txtNumRolls.Location = New System.Drawing.Point(98, 24)
        Me.txtNumRolls.Name = "txtNumRolls"
        Me.txtNumRolls.Size = New System.Drawing.Size(67, 20)
        Me.txtNumRolls.TabIndex = 1
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(15, 67)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(120, 147)
        Me.lstResults.TabIndex = 2
        '
        'btnRollDice
        '
        Me.btnRollDice.Location = New System.Drawing.Point(172, 22)
        Me.btnRollDice.Name = "btnRollDice"
        Me.btnRollDice.Size = New System.Drawing.Size(75, 23)
        Me.btnRollDice.TabIndex = 3
        Me.btnRollDice.Text = "Roll Dice"
        Me.btnRollDice.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 228)
        Me.Controls.Add(Me.btnRollDice)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.txtNumRolls)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Dice Rolls"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumRolls As System.Windows.Forms.TextBox
    Friend WithEvents lstResults As System.Windows.Forms.ListBox
    Friend WithEvents btnRollDice As System.Windows.Forms.Button

End Class
