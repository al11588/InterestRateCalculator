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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.txtPrincipals = New System.Windows.Forms.TextBox()
        Me.txtBoxInterestRate = New System.Windows.Forms.TextBox()
        Me.yearUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.yearUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(211, 48)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(73, 127)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(213, 160)
        Me.lstResults.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Principals:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Interest Rate:"
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Location = New System.Drawing.Point(27, 104)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(37, 13)
        Me.lblYears.TabIndex = 4
        Me.lblYears.Text = "Years:"
        '
        'txtPrincipals
        '
        Me.txtPrincipals.Location = New System.Drawing.Point(96, 48)
        Me.txtPrincipals.Name = "txtPrincipals"
        Me.txtPrincipals.Size = New System.Drawing.Size(100, 20)
        Me.txtPrincipals.TabIndex = 5
        '
        'txtBoxInterestRate
        '
        Me.txtBoxInterestRate.Location = New System.Drawing.Point(96, 74)
        Me.txtBoxInterestRate.Name = "txtBoxInterestRate"
        Me.txtBoxInterestRate.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxInterestRate.TabIndex = 6
        '
        'yearUpDown
        '
        Me.yearUpDown.Location = New System.Drawing.Point(96, 101)
        Me.yearUpDown.Name = "yearUpDown"
        Me.yearUpDown.Size = New System.Drawing.Size(120, 20)
        Me.yearUpDown.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 373)
        Me.Controls.Add(Me.yearUpDown)
        Me.Controls.Add(Me.txtBoxInterestRate)
        Me.Controls.Add(Me.txtPrincipals)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Interest Calculator"
        CType(Me.yearUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lstResults As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblYears As System.Windows.Forms.Label
    Friend WithEvents txtPrincipals As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxInterestRate As System.Windows.Forms.TextBox
    Friend WithEvents yearUpDown As System.Windows.Forms.NumericUpDown

End Class
