<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VitalSignsform
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VitalSignsform))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PatientGroupBox = New System.Windows.Forms.GroupBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HWGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.weightLB = New System.Windows.Forms.Label()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.HeightLB = New System.Windows.Forms.Label()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.VSGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ResTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.B1TextBox = New System.Windows.Forms.TextBox()
        Me.B2TextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PRtxtbox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Temptxtbox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TempLB = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SymptTextBox = New System.Windows.Forms.RichTextBox()
        Me.TUchkbox = New System.Windows.Forms.CheckBox()
        Me.TULB = New System.Windows.Forms.Label()
        Me.Submitbtn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.PatientGroupBox.SuspendLayout()
        Me.HWGroupBox.SuspendLayout()
        Me.VSGroupBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(398, 46)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vital Signs"
        '
        'PatientGroupBox
        '
        Me.PatientGroupBox.Controls.Add(Me.IDTextBox)
        Me.PatientGroupBox.Controls.Add(Me.Label3)
        Me.PatientGroupBox.Controls.Add(Me.NameTextBox)
        Me.PatientGroupBox.Controls.Add(Me.Label2)
        Me.PatientGroupBox.Location = New System.Drawing.Point(12, 68)
        Me.PatientGroupBox.Name = "PatientGroupBox"
        Me.PatientGroupBox.Size = New System.Drawing.Size(398, 56)
        Me.PatientGroupBox.TabIndex = 1
        Me.PatientGroupBox.TabStop = False
        Me.PatientGroupBox.Text = "Patient information"
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(274, 23)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(227, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(64, 23)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        '
        'HWGroupBox
        '
        Me.HWGroupBox.Controls.Add(Me.Label15)
        Me.HWGroupBox.Controls.Add(Me.Label14)
        Me.HWGroupBox.Controls.Add(Me.weightLB)
        Me.HWGroupBox.Controls.Add(Me.WeightTextBox)
        Me.HWGroupBox.Controls.Add(Me.HeightLB)
        Me.HWGroupBox.Controls.Add(Me.HeightTextBox)
        Me.HWGroupBox.Location = New System.Drawing.Point(12, 130)
        Me.HWGroupBox.Name = "HWGroupBox"
        Me.HWGroupBox.Size = New System.Drawing.Size(398, 58)
        Me.HWGroupBox.TabIndex = 2
        Me.HWGroupBox.TabStop = False
        Me.HWGroupBox.Text = "Height and Weight"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(316, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "KG"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(129, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(23, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "CM"
        '
        'weightLB
        '
        Me.weightLB.AutoSize = True
        Me.weightLB.Location = New System.Drawing.Point(227, 25)
        Me.weightLB.Name = "weightLB"
        Me.weightLB.Size = New System.Drawing.Size(41, 13)
        Me.weightLB.TabIndex = 5
        Me.weightLB.Text = "Weight"
        '
        'WeightTextBox
        '
        Me.WeightTextBox.Location = New System.Drawing.Point(274, 22)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(40, 20)
        Me.WeightTextBox.TabIndex = 4
        '
        'HeightLB
        '
        Me.HeightLB.AutoSize = True
        Me.HeightLB.Location = New System.Drawing.Point(36, 25)
        Me.HeightLB.Name = "HeightLB"
        Me.HeightLB.Size = New System.Drawing.Size(38, 13)
        Me.HeightLB.TabIndex = 2
        Me.HeightLB.Text = "Height"
        '
        'HeightTextBox
        '
        Me.HeightTextBox.Location = New System.Drawing.Point(80, 22)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(46, 20)
        Me.HeightTextBox.TabIndex = 1
        '
        'VSGroupBox
        '
        Me.VSGroupBox.Controls.Add(Me.Label13)
        Me.VSGroupBox.Controls.Add(Me.ResTextBox)
        Me.VSGroupBox.Controls.Add(Me.Label12)
        Me.VSGroupBox.Controls.Add(Me.B1TextBox)
        Me.VSGroupBox.Controls.Add(Me.B2TextBox)
        Me.VSGroupBox.Controls.Add(Me.Label11)
        Me.VSGroupBox.Controls.Add(Me.PRtxtbox)
        Me.VSGroupBox.Controls.Add(Me.Label10)
        Me.VSGroupBox.Controls.Add(Me.Temptxtbox)
        Me.VSGroupBox.Controls.Add(Me.Label9)
        Me.VSGroupBox.Controls.Add(Me.Label8)
        Me.VSGroupBox.Controls.Add(Me.Label7)
        Me.VSGroupBox.Controls.Add(Me.TempLB)
        Me.VSGroupBox.Location = New System.Drawing.Point(12, 192)
        Me.VSGroupBox.Name = "VSGroupBox"
        Me.VSGroupBox.Size = New System.Drawing.Size(398, 94)
        Me.VSGroupBox.TabIndex = 3
        Me.VSGroupBox.TabStop = False
        Me.VSGroupBox.Text = "Vital Signs"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(328, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "BPM"
        '
        'ResTextBox
        '
        Me.ResTextBox.Location = New System.Drawing.Point(282, 55)
        Me.ResTextBox.Name = "ResTextBox"
        Me.ResTextBox.Size = New System.Drawing.Size(40, 20)
        Me.ResTextBox.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(326, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "/"
        '
        'B1TextBox
        '
        Me.B1TextBox.Location = New System.Drawing.Point(282, 17)
        Me.B1TextBox.Name = "B1TextBox"
        Me.B1TextBox.Size = New System.Drawing.Size(40, 20)
        Me.B1TextBox.TabIndex = 9
        '
        'B2TextBox
        '
        Me.B2TextBox.Location = New System.Drawing.Point(342, 17)
        Me.B2TextBox.Name = "B2TextBox"
        Me.B2TextBox.Size = New System.Drawing.Size(40, 20)
        Me.B2TextBox.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(140, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "PPM"
        '
        'PRtxtbox
        '
        Me.PRtxtbox.Location = New System.Drawing.Point(96, 55)
        Me.PRtxtbox.Name = "PRtxtbox"
        Me.PRtxtbox.Size = New System.Drawing.Size(40, 20)
        Me.PRtxtbox.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(140, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "°C"
        '
        'Temptxtbox
        '
        Me.Temptxtbox.Location = New System.Drawing.Point(96, 17)
        Me.Temptxtbox.Name = "Temptxtbox"
        Me.Temptxtbox.Size = New System.Drawing.Size(40, 20)
        Me.Temptxtbox.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(190, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Respiration Rate"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(190, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Blood Pressure"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Pulse Rate"
        '
        'TempLB
        '
        Me.TempLB.AutoSize = True
        Me.TempLB.Location = New System.Drawing.Point(20, 20)
        Me.TempLB.Name = "TempLB"
        Me.TempLB.Size = New System.Drawing.Size(67, 13)
        Me.TempLB.TabIndex = 0
        Me.TempLB.Text = "Temperature"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SymptTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 299)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 97)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Symptoms"
        '
        'SymptTextBox
        '
        Me.SymptTextBox.Location = New System.Drawing.Point(7, 20)
        Me.SymptTextBox.Name = "SymptTextBox"
        Me.SymptTextBox.Size = New System.Drawing.Size(226, 71)
        Me.SymptTextBox.TabIndex = 0
        Me.SymptTextBox.Text = ""
        '
        'TUchkbox
        '
        Me.TUchkbox.AutoSize = True
        Me.TUchkbox.Location = New System.Drawing.Point(367, 311)
        Me.TUchkbox.Name = "TUchkbox"
        Me.TUchkbox.Size = New System.Drawing.Size(15, 14)
        Me.TUchkbox.TabIndex = 6
        Me.TUchkbox.UseVisualStyleBackColor = True
        '
        'TULB
        '
        Me.TULB.AutoSize = True
        Me.TULB.Location = New System.Drawing.Point(289, 311)
        Me.TULB.Name = "TULB"
        Me.TULB.Size = New System.Drawing.Size(72, 13)
        Me.TULB.TabIndex = 7
        Me.TULB.Text = "Tobacco Use"
        '
        'Submitbtn
        '
        Me.Submitbtn.Location = New System.Drawing.Point(286, 366)
        Me.Submitbtn.Name = "Submitbtn"
        Me.Submitbtn.Size = New System.Drawing.Size(108, 23)
        Me.Submitbtn.TabIndex = 8
        Me.Submitbtn.Text = "Submit"
        Me.Submitbtn.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'VitalSignsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 419)
        Me.Controls.Add(Me.Submitbtn)
        Me.Controls.Add(Me.TULB)
        Me.Controls.Add(Me.TUchkbox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.VSGroupBox)
        Me.Controls.Add(Me.HWGroupBox)
        Me.Controls.Add(Me.PatientGroupBox)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VitalSignsform"
        Me.Text = "VitalSignsform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PatientGroupBox.ResumeLayout(False)
        Me.PatientGroupBox.PerformLayout()
        Me.HWGroupBox.ResumeLayout(False)
        Me.HWGroupBox.PerformLayout()
        Me.VSGroupBox.ResumeLayout(False)
        Me.VSGroupBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PatientGroupBox As GroupBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents HWGroupBox As GroupBox
    Friend WithEvents weightLB As Label
    Friend WithEvents WeightTextBox As TextBox
    Friend WithEvents HeightLB As Label
    Friend WithEvents HeightTextBox As TextBox
    Friend WithEvents VSGroupBox As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TempLB As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents B1TextBox As TextBox
    Friend WithEvents B2TextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PRtxtbox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Temptxtbox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ResTextBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SymptTextBox As RichTextBox
    Friend WithEvents TUchkbox As CheckBox
    Friend WithEvents TULB As Label
    Friend WithEvents Submitbtn As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
