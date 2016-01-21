<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Appointmentform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Appointmentform))
        Me.LabelP = New System.Windows.Forms.Label()
        Me.LabelD = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EndLabel = New System.Windows.Forms.Label()
        Me.StartLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.DoctorComboBox = New System.Windows.Forms.ComboBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.PatientComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FU = New System.Windows.Forms.RadioButton()
        Me.FT = New System.Windows.Forms.RadioButton()
        Me.NPBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelP
        '
        Me.LabelP.AutoSize = True
        Me.LabelP.Location = New System.Drawing.Point(12, 118)
        Me.LabelP.Name = "LabelP"
        Me.LabelP.Size = New System.Drawing.Size(40, 13)
        Me.LabelP.TabIndex = 0
        Me.LabelP.Text = "Patient"
        '
        'LabelD
        '
        Me.LabelD.AutoSize = True
        Me.LabelD.Location = New System.Drawing.Point(12, 192)
        Me.LabelD.Name = "LabelD"
        Me.LabelD.Size = New System.Drawing.Size(39, 13)
        Me.LabelD.TabIndex = 1
        Me.LabelD.Text = "Doctor"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.EndLabel)
        Me.Panel1.Controls.Add(Me.StartLabel)
        Me.Panel1.Controls.Add(Me.DateLabel)
        Me.Panel1.Location = New System.Drawing.Point(15, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 70)
        Me.Panel1.TabIndex = 2
        '
        'EndLabel
        '
        Me.EndLabel.AutoSize = True
        Me.EndLabel.Location = New System.Drawing.Point(230, 42)
        Me.EndLabel.Name = "EndLabel"
        Me.EndLabel.Size = New System.Drawing.Size(55, 13)
        Me.EndLabel.TabIndex = 5
        Me.EndLabel.Text = "EndTime: "
        '
        'StartLabel
        '
        Me.StartLabel.AutoSize = True
        Me.StartLabel.Location = New System.Drawing.Point(230, 12)
        Me.StartLabel.Name = "StartLabel"
        Me.StartLabel.Size = New System.Drawing.Size(58, 13)
        Me.StartLabel.TabIndex = 4
        Me.StartLabel.Text = "StartTime: "
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Location = New System.Drawing.Point(29, 12)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(36, 13)
        Me.DateLabel.TabIndex = 3
        Me.DateLabel.Text = "Date: "
        '
        'DoctorComboBox
        '
        Me.DoctorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DoctorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DoctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DoctorComboBox.FormattingEnabled = True
        Me.DoctorComboBox.Location = New System.Drawing.Point(74, 192)
        Me.DoctorComboBox.Name = "DoctorComboBox"
        Me.DoctorComboBox.Size = New System.Drawing.Size(134, 21)
        Me.DoctorComboBox.TabIndex = 4
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(230, 260)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 5
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(313, 260)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 6
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'PatientComboBox
        '
        Me.PatientComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PatientComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PatientComboBox.FormattingEnabled = True
        Me.PatientComboBox.Location = New System.Drawing.Point(74, 115)
        Me.PatientComboBox.Name = "PatientComboBox"
        Me.PatientComboBox.Size = New System.Drawing.Size(134, 21)
        Me.PatientComboBox.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FU)
        Me.GroupBox1.Controls.Add(Me.FT)
        Me.GroupBox1.Location = New System.Drawing.Point(292, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 100)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type"
        '
        'FU
        '
        Me.FU.AutoSize = True
        Me.FU.Location = New System.Drawing.Point(6, 60)
        Me.FU.Name = "FU"
        Me.FU.Size = New System.Drawing.Size(72, 17)
        Me.FU.TabIndex = 1
        Me.FU.TabStop = True
        Me.FU.Text = "Follow Up"
        Me.FU.UseVisualStyleBackColor = True
        '
        'FT
        '
        Me.FT.AutoSize = True
        Me.FT.Location = New System.Drawing.Point(6, 26)
        Me.FT.Name = "FT"
        Me.FT.Size = New System.Drawing.Size(70, 17)
        Me.FT.TabIndex = 0
        Me.FT.TabStop = True
        Me.FT.Text = "First Time"
        Me.FT.UseVisualStyleBackColor = True
        '
        'NPBtn
        '
        Me.NPBtn.Location = New System.Drawing.Point(214, 115)
        Me.NPBtn.Name = "NPBtn"
        Me.NPBtn.Size = New System.Drawing.Size(57, 23)
        Me.NPBtn.TabIndex = 9
        Me.NPBtn.Text = "New"
        Me.NPBtn.UseVisualStyleBackColor = True
        '
        'Appointmentform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 290)
        Me.Controls.Add(Me.NPBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PatientComboBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.DoctorComboBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelD)
        Me.Controls.Add(Me.LabelP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Appointmentform"
        Me.Text = "Appointment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelP As Label
    Friend WithEvents LabelD As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EndLabel As Label
    Friend WithEvents StartLabel As Label
    Friend WithEvents DateLabel As Label
    Friend WithEvents DoctorComboBox As ComboBox
    Friend WithEvents OKButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents PatientComboBox As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FU As RadioButton
    Friend WithEvents FT As RadioButton
    Friend WithEvents NPBtn As Button
End Class
