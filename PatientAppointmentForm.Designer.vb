<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientAppointmentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientAppointmentForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PatientID = New System.Windows.Forms.Label()
        Me.pidlabel = New System.Windows.Forms.Label()
        Me.PatientName = New System.Windows.Forms.Label()
        Me.Pnamelabel = New System.Windows.Forms.Label()
        Me.patientappointmenthelp = New System.Windows.Forms.Label()
        Me.AppDTP = New System.Windows.Forms.DateTimePicker()
        Me.HourNUP = New System.Windows.Forms.NumericUpDown()
        Me.MinNUP = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DoctorsCB = New System.Windows.Forms.ComboBox()
        Me.Schedulebtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.HourNUP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinNUP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 48)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(84, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Schedule Appointment"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.PatientID)
        Me.Panel2.Controls.Add(Me.pidlabel)
        Me.Panel2.Controls.Add(Me.PatientName)
        Me.Panel2.Controls.Add(Me.Pnamelabel)
        Me.Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(382, 30)
        Me.Panel2.TabIndex = 1
        '
        'PatientID
        '
        Me.PatientID.AutoSize = True
        Me.PatientID.Location = New System.Drawing.Point(284, 9)
        Me.PatientID.Name = "PatientID"
        Me.PatientID.Size = New System.Drawing.Size(0, 13)
        Me.PatientID.TabIndex = 5
        '
        'pidlabel
        '
        Me.pidlabel.AutoSize = True
        Me.pidlabel.Location = New System.Drawing.Point(217, 9)
        Me.pidlabel.Name = "pidlabel"
        Me.pidlabel.Size = New System.Drawing.Size(57, 13)
        Me.pidlabel.TabIndex = 4
        Me.pidlabel.Text = "Patient ID:"
        '
        'PatientName
        '
        Me.PatientName.AutoSize = True
        Me.PatientName.Location = New System.Drawing.Point(81, 9)
        Me.PatientName.Name = "PatientName"
        Me.PatientName.Size = New System.Drawing.Size(0, 13)
        Me.PatientName.TabIndex = 3
        '
        'Pnamelabel
        '
        Me.Pnamelabel.AutoSize = True
        Me.Pnamelabel.Location = New System.Drawing.Point(12, 9)
        Me.Pnamelabel.Name = "Pnamelabel"
        Me.Pnamelabel.Size = New System.Drawing.Size(72, 13)
        Me.Pnamelabel.TabIndex = 2
        Me.Pnamelabel.Text = "Patient name:"
        '
        'patientappointmenthelp
        '
        Me.patientappointmenthelp.AutoSize = True
        Me.patientappointmenthelp.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patientappointmenthelp.ForeColor = System.Drawing.SystemColors.Highlight
        Me.patientappointmenthelp.Location = New System.Drawing.Point(14, 92)
        Me.patientappointmenthelp.Name = "patientappointmenthelp"
        Me.patientappointmenthelp.Size = New System.Drawing.Size(290, 19)
        Me.patientappointmenthelp.TabIndex = 36
        Me.patientappointmenthelp.Text = "Select required appointment time and doctor."
        '
        'AppDTP
        '
        Me.AppDTP.CustomFormat = "HH:MM "
        Me.AppDTP.Location = New System.Drawing.Point(18, 148)
        Me.AppDTP.Name = "AppDTP"
        Me.AppDTP.Size = New System.Drawing.Size(200, 20)
        Me.AppDTP.TabIndex = 38
        '
        'HourNUP
        '
        Me.HourNUP.Location = New System.Drawing.Point(244, 148)
        Me.HourNUP.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.HourNUP.Name = "HourNUP"
        Me.HourNUP.Size = New System.Drawing.Size(52, 20)
        Me.HourNUP.TabIndex = 40
        '
        'MinNUP
        '
        Me.MinNUP.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.MinNUP.Location = New System.Drawing.Point(302, 148)
        Me.MinNUP.Maximum = New Decimal(New Integer() {45, 0, 0, 0})
        Me.MinNUP.Name = "MinNUP"
        Me.MinNUP.Size = New System.Drawing.Size(52, 20)
        Me.MinNUP.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(241, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Hour:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(299, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Min:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Doctor"
        '
        'DoctorsCB
        '
        Me.DoctorsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DoctorsCB.FormattingEnabled = True
        Me.DoctorsCB.Location = New System.Drawing.Point(18, 222)
        Me.DoctorsCB.Name = "DoctorsCB"
        Me.DoctorsCB.Size = New System.Drawing.Size(200, 21)
        Me.DoctorsCB.TabIndex = 46
        '
        'Schedulebtn
        '
        Me.Schedulebtn.Location = New System.Drawing.Point(263, 282)
        Me.Schedulebtn.Name = "Schedulebtn"
        Me.Schedulebtn.Size = New System.Drawing.Size(75, 23)
        Me.Schedulebtn.TabIndex = 47
        Me.Schedulebtn.Text = "Schedule"
        Me.Schedulebtn.UseVisualStyleBackColor = True
        '
        'PatientAppointmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 337)
        Me.Controls.Add(Me.Schedulebtn)
        Me.Controls.Add(Me.DoctorsCB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MinNUP)
        Me.Controls.Add(Me.HourNUP)
        Me.Controls.Add(Me.AppDTP)
        Me.Controls.Add(Me.patientappointmenthelp)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PatientAppointmentForm"
        Me.Text = "Schedule Appointment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.HourNUP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinNUP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PatientID As Label
    Friend WithEvents pidlabel As Label
    Friend WithEvents PatientName As Label
    Friend WithEvents Pnamelabel As Label
    Friend WithEvents patientappointmenthelp As Label
    Friend WithEvents AppDTP As DateTimePicker
    Friend WithEvents HourNUP As NumericUpDown
    Friend WithEvents MinNUP As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DoctorsCB As ComboBox
    Friend WithEvents Schedulebtn As Button
End Class
