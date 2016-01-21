<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patientform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patientform))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FNtextbox = New System.Windows.Forms.TextBox()
        Me.LNtextbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IDtextbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BDPicker = New System.Windows.Forms.DateTimePicker()
        Me.Phonetextbox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Addtextbox = New System.Windows.Forms.RichTextBox()
        Me.Passwordtextbox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BloodComboBox = New System.Windows.Forms.ComboBox()
        Me.Submitbtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MRB = New System.Windows.Forms.RadioButton()
        Me.FRB = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 44)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patient Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'FNtextbox
        '
        Me.FNtextbox.Location = New System.Drawing.Point(89, 90)
        Me.FNtextbox.Name = "FNtextbox"
        Me.FNtextbox.Size = New System.Drawing.Size(100, 20)
        Me.FNtextbox.TabIndex = 3
        '
        'LNtextbox
        '
        Me.LNtextbox.Location = New System.Drawing.Point(302, 90)
        Me.LNtextbox.Name = "LNtextbox"
        Me.LNtextbox.Size = New System.Drawing.Size(100, 20)
        Me.LNtextbox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name"
        '
        'IDtextbox
        '
        Me.IDtextbox.Location = New System.Drawing.Point(89, 149)
        Me.IDtextbox.Name = "IDtextbox"
        Me.IDtextbox.Size = New System.Drawing.Size(100, 20)
        Me.IDtextbox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ID Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(242, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Birth Date"
        '
        'BDPicker
        '
        Me.BDPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BDPicker.Location = New System.Drawing.Point(302, 150)
        Me.BDPicker.Name = "BDPicker"
        Me.BDPicker.Size = New System.Drawing.Size(100, 20)
        Me.BDPicker.TabIndex = 9
        '
        'Phonetextbox
        '
        Me.Phonetextbox.Location = New System.Drawing.Point(89, 254)
        Me.Phonetextbox.Name = "Phonetextbox"
        Me.Phonetextbox.Size = New System.Drawing.Size(100, 20)
        Me.Phonetextbox.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Phone"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(239, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Address"
        '
        'Addtextbox
        '
        Me.Addtextbox.Location = New System.Drawing.Point(302, 208)
        Me.Addtextbox.Name = "Addtextbox"
        Me.Addtextbox.Size = New System.Drawing.Size(100, 54)
        Me.Addtextbox.TabIndex = 13
        Me.Addtextbox.Text = ""
        '
        'Passwordtextbox
        '
        Me.Passwordtextbox.Location = New System.Drawing.Point(89, 300)
        Me.Passwordtextbox.Name = "Passwordtextbox"
        Me.Passwordtextbox.Size = New System.Drawing.Size(100, 20)
        Me.Passwordtextbox.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(239, 291)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Blood Type"
        '
        'BloodComboBox
        '
        Me.BloodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BloodComboBox.FormattingEnabled = True
        Me.BloodComboBox.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.BloodComboBox.Location = New System.Drawing.Point(302, 288)
        Me.BloodComboBox.Name = "BloodComboBox"
        Me.BloodComboBox.Size = New System.Drawing.Size(100, 21)
        Me.BloodComboBox.TabIndex = 17
        '
        'Submitbtn
        '
        Me.Submitbtn.Location = New System.Drawing.Point(313, 346)
        Me.Submitbtn.Name = "Submitbtn"
        Me.Submitbtn.Size = New System.Drawing.Size(75, 23)
        Me.Submitbtn.TabIndex = 18
        Me.Submitbtn.Text = "Submit"
        Me.Submitbtn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Gender"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FRB)
        Me.GroupBox1.Controls.Add(Me.MRB)
        Me.GroupBox1.Location = New System.Drawing.Point(89, 181)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 64)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'MRB
        '
        Me.MRB.AutoSize = True
        Me.MRB.Location = New System.Drawing.Point(16, 15)
        Me.MRB.Name = "MRB"
        Me.MRB.Size = New System.Drawing.Size(48, 17)
        Me.MRB.TabIndex = 0
        Me.MRB.TabStop = True
        Me.MRB.Text = "Male"
        Me.MRB.UseVisualStyleBackColor = True
        '
        'FRB
        '
        Me.FRB.AutoSize = True
        Me.FRB.Location = New System.Drawing.Point(16, 35)
        Me.FRB.Name = "FRB"
        Me.FRB.Size = New System.Drawing.Size(59, 17)
        Me.FRB.TabIndex = 1
        Me.FRB.TabStop = True
        Me.FRB.Text = "Female"
        Me.FRB.UseVisualStyleBackColor = True
        '
        'Patientform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 381)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Submitbtn)
        Me.Controls.Add(Me.BloodComboBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Passwordtextbox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Addtextbox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Phonetextbox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BDPicker)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IDtextbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LNtextbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FNtextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Patientform"
        Me.Text = "Patientform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FNtextbox As TextBox
    Friend WithEvents LNtextbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents IDtextbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BDPicker As DateTimePicker
    Friend WithEvents Phonetextbox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Addtextbox As RichTextBox
    Friend WithEvents Passwordtextbox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BloodComboBox As ComboBox
    Friend WithEvents Submitbtn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FRB As RadioButton
    Friend WithEvents MRB As RadioButton
End Class
