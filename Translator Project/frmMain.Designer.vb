<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.gbEnglish = New System.Windows.Forms.GroupBox()
        Me.radMother = New System.Windows.Forms.RadioButton()
        Me.radFather = New System.Windows.Forms.RadioButton()
        Me.radSister = New System.Windows.Forms.RadioButton()
        Me.radBrother = New System.Windows.Forms.RadioButton()
        Me.cbL = New System.Windows.Forms.ComboBox()
        Me.lblTranslate = New System.Windows.Forms.Label()
        Me.btnTranslate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbEnglish.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbEnglish
        '
        Me.gbEnglish.Controls.Add(Me.radMother)
        Me.gbEnglish.Controls.Add(Me.radFather)
        Me.gbEnglish.Controls.Add(Me.radSister)
        Me.gbEnglish.Controls.Add(Me.radBrother)
        Me.gbEnglish.Location = New System.Drawing.Point(41, 41)
        Me.gbEnglish.Name = "gbEnglish"
        Me.gbEnglish.Size = New System.Drawing.Size(163, 170)
        Me.gbEnglish.TabIndex = 0
        Me.gbEnglish.TabStop = False
        Me.gbEnglish.Text = "English"
        '
        'radMother
        '
        Me.radMother.AutoSize = True
        Me.radMother.Location = New System.Drawing.Point(6, 21)
        Me.radMother.Name = "radMother"
        Me.radMother.Size = New System.Drawing.Size(69, 20)
        Me.radMother.TabIndex = 1
        Me.radMother.TabStop = True
        Me.radMother.Text = "&Mother"
        Me.radMother.UseVisualStyleBackColor = True
        '
        'radFather
        '
        Me.radFather.AutoSize = True
        Me.radFather.Location = New System.Drawing.Point(6, 59)
        Me.radFather.Name = "radFather"
        Me.radFather.Size = New System.Drawing.Size(66, 20)
        Me.radFather.TabIndex = 2
        Me.radFather.TabStop = True
        Me.radFather.Text = "&Father"
        Me.radFather.UseVisualStyleBackColor = True
        '
        'radSister
        '
        Me.radSister.AutoSize = True
        Me.radSister.Location = New System.Drawing.Point(6, 99)
        Me.radSister.Name = "radSister"
        Me.radSister.Size = New System.Drawing.Size(62, 20)
        Me.radSister.TabIndex = 3
        Me.radSister.TabStop = True
        Me.radSister.Text = "&Sister"
        Me.radSister.UseVisualStyleBackColor = True
        '
        'radBrother
        '
        Me.radBrother.AutoSize = True
        Me.radBrother.Location = New System.Drawing.Point(6, 139)
        Me.radBrother.Name = "radBrother"
        Me.radBrother.Size = New System.Drawing.Size(71, 20)
        Me.radBrother.TabIndex = 4
        Me.radBrother.TabStop = True
        Me.radBrother.Text = "&Brother"
        Me.radBrother.UseVisualStyleBackColor = True
        '
        'cbL
        '
        Me.cbL.FormattingEnabled = True
        Me.cbL.Items.AddRange(New Object() {"French ", "Italian ", "English"})
        Me.cbL.Location = New System.Drawing.Point(230, 61)
        Me.cbL.Name = "cbL"
        Me.cbL.Size = New System.Drawing.Size(121, 24)
        Me.cbL.TabIndex = 5
        '
        'lblTranslate
        '
        Me.lblTranslate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTranslate.Location = New System.Drawing.Point(227, 114)
        Me.lblTranslate.Name = "lblTranslate"
        Me.lblTranslate.Size = New System.Drawing.Size(124, 65)
        Me.lblTranslate.TabIndex = 6
        '
        'btnTranslate
        '
        Me.btnTranslate.Location = New System.Drawing.Point(407, 62)
        Me.btnTranslate.Name = "btnTranslate"
        Me.btnTranslate.Size = New System.Drawing.Size(124, 41)
        Me.btnTranslate.TabIndex = 7
        Me.btnTranslate.Text = "&Translate"
        Me.btnTranslate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(407, 130)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 41)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "T&ranslate to:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTranslate)
        Me.Controls.Add(Me.lblTranslate)
        Me.Controls.Add(Me.cbL)
        Me.Controls.Add(Me.gbEnglish)
        Me.Name = "frmMain"
        Me.Text = "Translator Solution"
        Me.gbEnglish.ResumeLayout(False)
        Me.gbEnglish.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbEnglish As GroupBox
    Friend WithEvents radMother As RadioButton
    Friend WithEvents radFather As RadioButton
    Friend WithEvents radSister As RadioButton
    Friend WithEvents radBrother As RadioButton
    Friend WithEvents cbL As ComboBox
    Friend WithEvents lblTranslate As Label
    Friend WithEvents btnTranslate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
End Class
