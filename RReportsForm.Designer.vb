<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RReportsForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PatientGroupBox = New System.Windows.Forms.GroupBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.reportsdgv = New System.Windows.Forms.DataGridView()
        Me.submitrrbtn = New System.Windows.Forms.Button()
        Me.rType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.rReport = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.PatientGroupBox.SuspendLayout()
        CType(Me.reportsdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(7, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(398, 46)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Request Reports"
        '
        'PatientGroupBox
        '
        Me.PatientGroupBox.Controls.Add(Me.IDTextBox)
        Me.PatientGroupBox.Controls.Add(Me.Label3)
        Me.PatientGroupBox.Controls.Add(Me.NameTextBox)
        Me.PatientGroupBox.Controls.Add(Me.Label2)
        Me.PatientGroupBox.Location = New System.Drawing.Point(7, 58)
        Me.PatientGroupBox.Name = "PatientGroupBox"
        Me.PatientGroupBox.Size = New System.Drawing.Size(398, 56)
        Me.PatientGroupBox.TabIndex = 4
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
        'reportsdgv
        '
        Me.reportsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.reportsdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rType, Me.rReport})
        Me.reportsdgv.Location = New System.Drawing.Point(38, 130)
        Me.reportsdgv.Name = "reportsdgv"
        Me.reportsdgv.Size = New System.Drawing.Size(330, 155)
        Me.reportsdgv.TabIndex = 6
        '
        'submitrrbtn
        '
        Me.submitrrbtn.Location = New System.Drawing.Point(315, 304)
        Me.submitrrbtn.Name = "submitrrbtn"
        Me.submitrrbtn.Size = New System.Drawing.Size(75, 23)
        Me.submitrrbtn.TabIndex = 9
        Me.submitrrbtn.Text = "Submit"
        Me.submitrrbtn.UseVisualStyleBackColor = True
        '
        'rType
        '
        Me.rType.HeaderText = "Report Type"
        Me.rType.Items.AddRange(New Object() {"X-Ray", "CT", "MRI", "Labratory"})
        Me.rType.Name = "rType"
        Me.rType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.rType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.rType.Width = 130
        '
        'rReport
        '
        Me.rReport.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.rReport.HeaderText = "Report"
        Me.rReport.Name = "rReport"
        Me.rReport.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.rReport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.rReport.Width = 150
        '
        'RReportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 339)
        Me.Controls.Add(Me.submitrrbtn)
        Me.Controls.Add(Me.reportsdgv)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PatientGroupBox)
        Me.Name = "RReportsForm"
        Me.Text = "RReportsdgvForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PatientGroupBox.ResumeLayout(False)
        Me.PatientGroupBox.PerformLayout()
        CType(Me.reportsdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PatientGroupBox As GroupBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents reportsdgv As DataGridView
    Friend WithEvents submitrrbtn As Button
    Friend WithEvents rType As DataGridViewComboBoxColumn
    Friend WithEvents rReport As DataGridViewComboBoxColumn
End Class
