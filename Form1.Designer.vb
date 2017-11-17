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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.txtScoreOne = New System.Windows.Forms.TextBox()
        Me.txtScore2 = New System.Windows.Forms.TextBox()
        Me.txtScore3 = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExt = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Test Score 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Test Score 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Test Score 3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Average"
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(132, 134)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(100, 19)
        Me.lblAverage.TabIndex = 6
        '
        'txtScoreOne
        '
        Me.txtScoreOne.Location = New System.Drawing.Point(132, 16)
        Me.txtScoreOne.Name = "txtScoreOne"
        Me.txtScoreOne.Size = New System.Drawing.Size(100, 20)
        Me.txtScoreOne.TabIndex = 7
        '
        'txtScore2
        '
        Me.txtScore2.Location = New System.Drawing.Point(132, 51)
        Me.txtScore2.Name = "txtScore2"
        Me.txtScore2.Size = New System.Drawing.Size(100, 20)
        Me.txtScore2.TabIndex = 8
        '
        'txtScore3
        '
        Me.txtScore3.Location = New System.Drawing.Point(132, 86)
        Me.txtScore3.Name = "txtScore3"
        Me.txtScore3.Size = New System.Drawing.Size(100, 20)
        Me.txtScore3.TabIndex = 9
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(23, 242)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 37)
        Me.btnCalc.TabIndex = 12
        Me.btnCalc.Text = "Calculate Average"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(121, 242)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExt
        '
        Me.btnExt.Location = New System.Drawing.Point(214, 242)
        Me.btnExt.Name = "btnExt"
        Me.btnExt.Size = New System.Drawing.Size(75, 37)
        Me.btnExt.TabIndex = 14
        Me.btnExt.Text = "Exit"
        Me.btnExt.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(96, 205)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(100, 23)
        Me.lblMessage.TabIndex = 15
        '
        'lblGrade
        '
        Me.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrade.Location = New System.Drawing.Point(132, 170)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(100, 25)
        Me.lblGrade.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Grade:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 300)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnExt)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtScore3)
        Me.Controls.Add(Me.txtScore2)
        Me.Controls.Add(Me.txtScoreOne)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Test Score Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents txtScoreOne As System.Windows.Forms.TextBox
    Friend WithEvents txtScore2 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore3 As System.Windows.Forms.TextBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExt As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
