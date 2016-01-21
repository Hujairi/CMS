<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim DrawTool4 As Calendar.DrawTool = New Calendar.DrawTool()
        Dim IdMedicineLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim UserTypeLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DayView1 = New Calendar.DayView()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabMain = New System.Windows.Forms.TabPage()
        Me.MainHelpNote = New System.Windows.Forms.Label()
        Me.AppLabel = New System.Windows.Forms.Label()
        Me.AdminPB = New System.Windows.Forms.PictureBox()
        Me.ReportsPB = New System.Windows.Forms.PictureBox()
        Me.PayPB = New System.Windows.Forms.PictureBox()
        Me.DigPB = New System.Windows.Forms.PictureBox()
        Me.QuePB = New System.Windows.Forms.PictureBox()
        Me.AppPB = New System.Windows.Forms.PictureBox()
        Me.AdminLabel = New System.Windows.Forms.Label()
        Me.ReportLabel = New System.Windows.Forms.Label()
        Me.PayLabel = New System.Windows.Forms.Label()
        Me.QueLabel = New System.Windows.Forms.Label()
        Me.DigLabel = New System.Windows.Forms.Label()
        Me.TabAppointment = New System.Windows.Forms.TabPage()
        Me.AppointmentsHelpNote = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.TabQueue = New System.Windows.Forms.TabPage()
        Me.NPBtn = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DoctorComboBox = New System.Windows.Forms.ComboBox()
        Me.QueueHelpNote = New System.Windows.Forms.Label()
        Me.ATWQbtn = New System.Windows.Forms.Button()
        Me.PatientSearchComboBox = New System.Windows.Forms.ComboBox()
        Me.QueueDataGridView = New System.Windows.Forms.DataGridView()
        Me.app_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VS = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dig = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabDiagnose = New System.Windows.Forms.TabPage()
        Me.DiagnoseDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diagnose = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabPayment = New System.Windows.Forms.TabPage()
        Me.Paybtn = New System.Windows.Forms.Button()
        Me.insuranceidtxtbox = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.apptotaltxtbox = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.insurancerb = New System.Windows.Forms.RadioButton()
        Me.cashrb = New System.Windows.Forms.RadioButton()
        Me.patientnametxtbox = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.apptypetxtbox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.patientidtxtbox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.appidtxtbox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.appdatetxtbox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PaymentDGV = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabReports = New System.Windows.Forms.TabPage()
        Me.ReportsTabControl = New System.Windows.Forms.TabControl()
        Me.patientRTab = New System.Windows.Forms.TabPage()
        Me.PatientReportDGV = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Report = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Attachment = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.appidsebox = New System.Windows.Forms.TextBox()
        Me.patRcombobox = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.searchPatienRepBtn = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.digHTab = New System.Windows.Forms.TabPage()
        Me.DgRepsDataGridView = New System.Windows.Forms.DataGridView()
        Me.appointmentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.appDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Doctor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genbtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.DoctComboBox = New System.Windows.Forms.ComboBox()
        Me.PatComboBox = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.searchDgHisBtn = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.PatientLTab = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.BTCB = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.GenderCB = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.maxagetxtbox = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.minagetxtbox = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.keywordtxtbox = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Filterbtn = New System.Windows.Forms.Button()
        Me.ShowAllbtn = New System.Windows.Forms.Button()
        Me.exportbtn = New System.Windows.Forms.Button()
        Me.PatientsDGV = New System.Windows.Forms.DataGridView()
        Me.Pname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.page = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pgender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bloodtype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TabAdmin = New System.Windows.Forms.TabPage()
        Me.TabControlAdmin = New System.Windows.Forms.TabControl()
        Me.TabUdb = New System.Windows.Forms.TabPage()
        Me.UserTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmsDataSet1 = New CMS.CMSDataSet()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.MUsersHelpNote = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsersDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginPasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabMed = New System.Windows.Forms.TabPage()
        Me.TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.MedicineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescriptionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.IdMedicineTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.MmedicinesHelpNote = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MedicineDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdMedicineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TabSettings = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToCB = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.FromCB = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FUtxtbox = New System.Windows.Forms.TextBox()
        Me.FTtxtbox = New System.Windows.Forms.TextBox()
        Me.FULabel = New System.Windows.Forms.Label()
        Me.FTLabel = New System.Windows.Forms.Label()
        Me.CSHelpNote = New System.Windows.Forms.Label()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Chk6 = New System.Windows.Forms.CheckBox()
        Me.Chk5 = New System.Windows.Forms.CheckBox()
        Me.Chk4 = New System.Windows.Forms.CheckBox()
        Me.Chk3 = New System.Windows.Forms.CheckBox()
        Me.Chk2 = New System.Windows.Forms.CheckBox()
        Me.Chk1 = New System.Windows.Forms.CheckBox()
        Me.Chk0 = New System.Windows.Forms.CheckBox()
        Me.Clinictxt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.MainHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.MedicalHistoryTableAdapter = New CMS.CMSDataSetTableAdapters.MedicalHistoryTableAdapter()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicalHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrescriptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrescriptionTableAdapter = New CMS.CMSDataSetTableAdapters.PrescriptionTableAdapter()
        Me.ReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportsTableAdapter = New CMS.CMSDataSetTableAdapters.ReportsTableAdapter()
        Me.AppointmentTableAdapter = New CMS.CMSDataSetTableAdapters.AppointmentTableAdapter()
        Me.InvoiceTableAdapter = New CMS.CMSDataSetTableAdapters.InvoiceTableAdapter()
        Me.MedicineTableAdapter = New CMS.CMSDataSetTableAdapters.MedicineTableAdapter()
        Me.PatientTableAdapter = New CMS.CMSDataSetTableAdapters.PatientTableAdapter()
        Me.UserTableAdapter = New CMS.CMSDataSetTableAdapters.UserTableAdapter()
        Me.TableAdapterManager = New CMS.CMSDataSetTableAdapters.TableAdapterManager()
        Me.DiagnoseTabHelpNote = New System.Windows.Forms.Label()
        Me.PaymentTabHelpNote = New System.Windows.Forms.Label()
        Me.PatientsRTabHelpNote = New System.Windows.Forms.Label()
        Me.DigHistabHelpNote = New System.Windows.Forms.Label()
        Me.PatientsListTabHelpNote = New System.Windows.Forms.Label()
        IdMedicineLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        UserTypeLabel = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.TabMain.SuspendLayout()
        CType(Me.AdminPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuePB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAppointment.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabQueue.SuspendLayout()
        CType(Me.QueueDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.TabDiagnose.SuspendLayout()
        CType(Me.DiagnoseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.TabPayment.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PaymentDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabReports.SuspendLayout()
        Me.ReportsTabControl.SuspendLayout()
        Me.patientRTab.SuspendLayout()
        CType(Me.PatientReportDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.digHTab.SuspendLayout()
        CType(Me.DgRepsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.PatientLTab.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.PatientsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.TabAdmin.SuspendLayout()
        Me.TabControlAdmin.SuspendLayout()
        Me.TabUdb.SuspendLayout()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMed.SuspendLayout()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.MedicineDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSettings.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicalHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrescriptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DayView1
        '
        DrawTool4.DayView = Me.DayView1
        Me.DayView1.ActiveTool = DrawTool4
        Me.DayView1.AmPmDisplay = True
        Me.DayView1.AppHeightMode = Calendar.DayView.AppHeightDrawMode.TrueHeightAll
        Me.DayView1.DaysToShow = 5
        Me.DayView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DayView1.DrawAllAppBorder = True
        Me.DayView1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.DayView1.HalfHourHeight = 30
        Me.MainHelpProvider.SetHelpString(Me.DayView1, "Add Appointment: Double click. Delete Appointment:Right click")
        Me.DayView1.Location = New System.Drawing.Point(0, 250)
        Me.DayView1.MinHalfHourApp = False
        Me.DayView1.Name = "DayView1"
        Me.DayView1.SelectionEnd = New Date(CType(0, Long))
        Me.DayView1.SelectionStart = New Date(CType(0, Long))
        Me.MainHelpProvider.SetShowHelp(Me.DayView1, True)
        Me.DayView1.Size = New System.Drawing.Size(992, 401)
        Me.DayView1.StartDate = New Date(CType(0, Long))
        Me.DayView1.StartHour = 9
        Me.DayView1.TabIndex = 0
        Me.DayView1.Text = "DayView1"
        Me.DayView1.WorkingHourEnd = 16
        Me.DayView1.WorkingHourStart = 9
        Me.DayView1.WorkingMinuteEnd = 0
        Me.DayView1.WorkingMinuteStart = 0
        '
        'IdMedicineLabel
        '
        IdMedicineLabel.AutoSize = True
        IdMedicineLabel.Location = New System.Drawing.Point(51, 156)
        IdMedicineLabel.Name = "IdMedicineLabel"
        IdMedicineLabel.Size = New System.Drawing.Size(65, 13)
        IdMedicineLabel.TabIndex = 38
        IdMedicineLabel.Text = "Medicine Id:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(51, 195)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 39
        NameLabel.Text = "Name:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(51, 235)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 40
        DescriptionLabel.Text = "Description:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(51, 346)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(34, 13)
        TypeLabel.TabIndex = 41
        TypeLabel.Text = "Type:"
        '
        'UserTypeLabel
        '
        UserTypeLabel.AutoSize = True
        UserTypeLabel.Location = New System.Drawing.Point(39, 402)
        UserTypeLabel.Name = "UserTypeLabel"
        UserTypeLabel.Size = New System.Drawing.Size(59, 13)
        UserTypeLabel.TabIndex = 36
        UserTypeLabel.Text = "User Type:"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabMain)
        Me.TabControl.Controls.Add(Me.TabAppointment)
        Me.TabControl.Controls.Add(Me.TabQueue)
        Me.TabControl.Controls.Add(Me.TabDiagnose)
        Me.TabControl.Controls.Add(Me.TabPayment)
        Me.TabControl.Controls.Add(Me.TabReports)
        Me.TabControl.Controls.Add(Me.TabAdmin)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainHelpProvider.SetHelpString(Me.TabControl, "")
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.MainHelpProvider.SetShowHelp(Me.TabControl, True)
        Me.TabControl.Size = New System.Drawing.Size(1000, 677)
        Me.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl.TabIndex = 0
        '
        'TabMain
        '
        Me.TabMain.Controls.Add(Me.MainHelpNote)
        Me.TabMain.Controls.Add(Me.AppLabel)
        Me.TabMain.Controls.Add(Me.AdminPB)
        Me.TabMain.Controls.Add(Me.ReportsPB)
        Me.TabMain.Controls.Add(Me.PayPB)
        Me.TabMain.Controls.Add(Me.DigPB)
        Me.TabMain.Controls.Add(Me.QuePB)
        Me.TabMain.Controls.Add(Me.AppPB)
        Me.TabMain.Controls.Add(Me.AdminLabel)
        Me.TabMain.Controls.Add(Me.ReportLabel)
        Me.TabMain.Controls.Add(Me.PayLabel)
        Me.TabMain.Controls.Add(Me.QueLabel)
        Me.TabMain.Controls.Add(Me.DigLabel)
        Me.MainHelpProvider.SetHelpString(Me.TabMain, "")
        Me.TabMain.Location = New System.Drawing.Point(4, 22)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.Padding = New System.Windows.Forms.Padding(3)
        Me.MainHelpProvider.SetShowHelp(Me.TabMain, True)
        Me.TabMain.Size = New System.Drawing.Size(992, 651)
        Me.TabMain.TabIndex = 0
        Me.TabMain.Text = "Main"
        Me.TabMain.UseVisualStyleBackColor = True
        '
        'MainHelpNote
        '
        Me.MainHelpNote.AutoSize = True
        Me.MainHelpNote.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainHelpNote.ForeColor = System.Drawing.SystemColors.Highlight
        Me.MainHelpNote.Location = New System.Drawing.Point(220, 513)
        Me.MainHelpNote.Name = "MainHelpNote"
        Me.MainHelpNote.Size = New System.Drawing.Size(52, 21)
        Me.MainHelpNote.TabIndex = 17
        Me.MainHelpNote.Text = "Note:"
        '
        'AppLabel
        '
        Me.AppLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AppLabel.AutoSize = True
        Me.AppLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AppLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.AppLabel.Location = New System.Drawing.Point(265, 290)
        Me.AppLabel.Name = "AppLabel"
        Me.AppLabel.Size = New System.Drawing.Size(94, 17)
        Me.AppLabel.TabIndex = 5
        Me.AppLabel.Text = "Appointments"
        '
        'AdminPB
        '
        Me.AdminPB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AdminPB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminPB.Image = Global.CMS.My.Resources.Resources.Admin
        Me.AdminPB.Location = New System.Drawing.Point(628, 347)
        Me.AdminPB.Name = "AdminPB"
        Me.AdminPB.Size = New System.Drawing.Size(120, 120)
        Me.AdminPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AdminPB.TabIndex = 15
        Me.AdminPB.TabStop = False
        '
        'ReportsPB
        '
        Me.ReportsPB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ReportsPB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReportsPB.Image = Global.CMS.My.Resources.Resources.Reports
        Me.ReportsPB.Location = New System.Drawing.Point(448, 347)
        Me.ReportsPB.Name = "ReportsPB"
        Me.ReportsPB.Size = New System.Drawing.Size(120, 120)
        Me.ReportsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ReportsPB.TabIndex = 14
        Me.ReportsPB.TabStop = False
        '
        'PayPB
        '
        Me.PayPB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PayPB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PayPB.Image = Global.CMS.My.Resources.Resources.Payment
        Me.PayPB.Location = New System.Drawing.Point(252, 347)
        Me.PayPB.Name = "PayPB"
        Me.PayPB.Size = New System.Drawing.Size(120, 120)
        Me.PayPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PayPB.TabIndex = 13
        Me.PayPB.TabStop = False
        '
        'DigPB
        '
        Me.DigPB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DigPB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DigPB.Image = Global.CMS.My.Resources.Resources.Diagnose
        Me.DigPB.Location = New System.Drawing.Point(628, 161)
        Me.DigPB.Name = "DigPB"
        Me.DigPB.Size = New System.Drawing.Size(120, 120)
        Me.DigPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DigPB.TabIndex = 12
        Me.DigPB.TabStop = False
        '
        'QuePB
        '
        Me.QuePB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.QuePB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QuePB.Image = Global.CMS.My.Resources.Resources.queue
        Me.QuePB.Location = New System.Drawing.Point(448, 161)
        Me.QuePB.Name = "QuePB"
        Me.QuePB.Size = New System.Drawing.Size(120, 120)
        Me.QuePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QuePB.TabIndex = 11
        Me.QuePB.TabStop = False
        '
        'AppPB
        '
        Me.AppPB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AppPB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AppPB.Image = Global.CMS.My.Resources.Resources.appointment
        Me.AppPB.Location = New System.Drawing.Point(252, 161)
        Me.AppPB.Name = "AppPB"
        Me.AppPB.Size = New System.Drawing.Size(120, 120)
        Me.AppPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AppPB.TabIndex = 10
        Me.AppPB.TabStop = False
        '
        'AdminLabel
        '
        Me.AdminLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AdminLabel.AutoSize = True
        Me.AdminLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLabel.Location = New System.Drawing.Point(663, 478)
        Me.AdminLabel.Name = "AdminLabel"
        Me.AdminLabel.Size = New System.Drawing.Size(46, 16)
        Me.AdminLabel.TabIndex = 9
        Me.AdminLabel.Text = "Admin"
        '
        'ReportLabel
        '
        Me.ReportLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ReportLabel.AutoSize = True
        Me.ReportLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReportLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportLabel.Location = New System.Drawing.Point(478, 477)
        Me.ReportLabel.Name = "ReportLabel"
        Me.ReportLabel.Size = New System.Drawing.Size(56, 16)
        Me.ReportLabel.TabIndex = 8
        Me.ReportLabel.Text = "Reports"
        '
        'PayLabel
        '
        Me.PayLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PayLabel.AutoSize = True
        Me.PayLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.PayLabel.Location = New System.Drawing.Point(281, 477)
        Me.PayLabel.Name = "PayLabel"
        Me.PayLabel.Size = New System.Drawing.Size(63, 17)
        Me.PayLabel.TabIndex = 7
        Me.PayLabel.Text = "Payment"
        '
        'QueLabel
        '
        Me.QueLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.QueLabel.AutoSize = True
        Me.QueLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.QueLabel.Location = New System.Drawing.Point(483, 290)
        Me.QueLabel.Name = "QueLabel"
        Me.QueLabel.Size = New System.Drawing.Size(51, 17)
        Me.QueLabel.TabIndex = 3
        Me.QueLabel.Text = "Queue"
        '
        'DigLabel
        '
        Me.DigLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DigLabel.AutoSize = True
        Me.DigLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DigLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.DigLabel.Location = New System.Drawing.Point(653, 290)
        Me.DigLabel.Name = "DigLabel"
        Me.DigLabel.Size = New System.Drawing.Size(68, 17)
        Me.DigLabel.TabIndex = 1
        Me.DigLabel.Text = "Diagnose"
        '
        'TabAppointment
        '
        Me.TabAppointment.Controls.Add(Me.AppointmentsHelpNote)
        Me.TabAppointment.Controls.Add(Me.Panel5)
        Me.TabAppointment.Controls.Add(Me.MonthCalendar1)
        Me.TabAppointment.Controls.Add(Me.DayView1)
        Me.TabAppointment.Location = New System.Drawing.Point(4, 22)
        Me.TabAppointment.Name = "TabAppointment"
        Me.TabAppointment.Size = New System.Drawing.Size(992, 651)
        Me.TabAppointment.TabIndex = 4
        Me.TabAppointment.Text = "Appointments"
        Me.TabAppointment.UseVisualStyleBackColor = True
        '
        'AppointmentsHelpNote
        '
        Me.AppointmentsHelpNote.AutoSize = True
        Me.AppointmentsHelpNote.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppointmentsHelpNote.ForeColor = System.Drawing.SystemColors.Highlight
        Me.AppointmentsHelpNote.Location = New System.Drawing.Point(265, 55)
        Me.AppointmentsHelpNote.Name = "AppointmentsHelpNote"
        Me.AppointmentsHelpNote.Size = New System.Drawing.Size(52, 21)
        Me.AppointmentsHelpNote.TabIndex = 35
        Me.AppointmentsHelpNote.Text = "Note:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(992, 39)
        Me.Panel5.TabIndex = 34
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(406, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(126, 24)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Appointments"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Sunday
        Me.MainHelpProvider.SetHelpString(Me.MonthCalendar1, "Change the week dispalyed in the DayView by choosing the start of the week")
        Me.MonthCalendar1.Location = New System.Drawing.Point(14, 65)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MainHelpProvider.SetShowHelp(Me.MonthCalendar1, True)
        Me.MonthCalendar1.TabIndex = 1
        '
        'TabQueue
        '
        Me.TabQueue.Controls.Add(Me.NPBtn)
        Me.TabQueue.Controls.Add(Me.Label22)
        Me.TabQueue.Controls.Add(Me.Label21)
        Me.TabQueue.Controls.Add(Me.DoctorComboBox)
        Me.TabQueue.Controls.Add(Me.QueueHelpNote)
        Me.TabQueue.Controls.Add(Me.ATWQbtn)
        Me.TabQueue.Controls.Add(Me.PatientSearchComboBox)
        Me.TabQueue.Controls.Add(Me.QueueDataGridView)
        Me.TabQueue.Controls.Add(Me.Panel6)
        Me.TabQueue.Location = New System.Drawing.Point(4, 22)
        Me.TabQueue.Name = "TabQueue"
        Me.TabQueue.Padding = New System.Windows.Forms.Padding(3)
        Me.TabQueue.Size = New System.Drawing.Size(992, 651)
        Me.TabQueue.TabIndex = 1
        Me.TabQueue.Text = "Queue"
        Me.TabQueue.UseVisualStyleBackColor = True
        '
        'NPBtn
        '
        Me.NPBtn.Location = New System.Drawing.Point(410, 70)
        Me.NPBtn.Name = "NPBtn"
        Me.NPBtn.Size = New System.Drawing.Size(89, 23)
        Me.NPBtn.TabIndex = 43
        Me.NPBtn.Text = "New Patient"
        Me.NPBtn.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(164, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 13)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Doctors"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(28, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "Patients"
        '
        'DoctorComboBox
        '
        Me.DoctorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DoctorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DoctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DoctorComboBox.FormattingEnabled = True
        Me.DoctorComboBox.Location = New System.Drawing.Point(167, 72)
        Me.DoctorComboBox.Name = "DoctorComboBox"
        Me.DoctorComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DoctorComboBox.TabIndex = 40
        '
        'QueueHelpNote
        '
        Me.QueueHelpNote.AutoSize = True
        Me.QueueHelpNote.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QueueHelpNote.ForeColor = System.Drawing.SystemColors.Highlight
        Me.QueueHelpNote.Location = New System.Drawing.Point(22, 434)
        Me.QueueHelpNote.Name = "QueueHelpNote"
        Me.QueueHelpNote.Size = New System.Drawing.Size(48, 21)
        Me.QueueHelpNote.TabIndex = 39
        Me.QueueHelpNote.Text = "Note"
        '
        'ATWQbtn
        '
        Me.ATWQbtn.Location = New System.Drawing.Point(304, 70)
        Me.ATWQbtn.Name = "ATWQbtn"
        Me.ATWQbtn.Size = New System.Drawing.Size(99, 23)
        Me.ATWQbtn.TabIndex = 38
        Me.ATWQbtn.Text = "Add To Queue"
        Me.ATWQbtn.UseVisualStyleBackColor = True
        '
        'PatientSearchComboBox
        '
        Me.PatientSearchComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.PatientSearchComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PatientSearchComboBox.FormattingEnabled = True
        Me.PatientSearchComboBox.Location = New System.Drawing.Point(31, 72)
        Me.PatientSearchComboBox.Name = "PatientSearchComboBox"
        Me.PatientSearchComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PatientSearchComboBox.TabIndex = 37
        '
        'QueueDataGridView
        '
        Me.QueueDataGridView.AllowUserToAddRows = False
        Me.QueueDataGridView.AllowUserToDeleteRows = False
        Me.QueueDataGridView.AllowUserToResizeColumns = False
        Me.QueueDataGridView.AllowUserToResizeRows = False
        Me.QueueDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.QueueDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.QueueDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.QueueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QueueDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.app_id, Me.P_id, Me.P_name, Me.Gender, Me.Age, Me.D_name, Me.Time, Me.status, Me.VS, Me.dig})
        Me.MainHelpProvider.SetHelpString(Me.QueueDataGridView, "Display List of Today appointments")
        Me.QueueDataGridView.Location = New System.Drawing.Point(24, 110)
        Me.QueueDataGridView.MultiSelect = False
        Me.QueueDataGridView.Name = "QueueDataGridView"
        Me.QueueDataGridView.ReadOnly = True
        Me.QueueDataGridView.ShowEditingIcon = False
        Me.MainHelpProvider.SetShowHelp(Me.QueueDataGridView, True)
        Me.QueueDataGridView.Size = New System.Drawing.Size(940, 307)
        Me.QueueDataGridView.TabIndex = 36
        '
        'app_id
        '
        Me.app_id.HeaderText = "Appointment ID"
        Me.app_id.Name = "app_id"
        Me.app_id.ReadOnly = True
        Me.app_id.Width = 105
        '
        'P_id
        '
        Me.P_id.HeaderText = "Patient ID"
        Me.P_id.Name = "P_id"
        Me.P_id.ReadOnly = True
        Me.P_id.Width = 90
        '
        'P_name
        '
        Me.P_name.HeaderText = "Patient"
        Me.P_name.Name = "P_name"
        Me.P_name.ReadOnly = True
        Me.P_name.Width = 130
        '
        'Gender
        '
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        Me.Gender.ReadOnly = True
        Me.Gender.Width = 50
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.ReadOnly = True
        Me.Age.Width = 30
        '
        'D_name
        '
        Me.D_name.HeaderText = "Doctor"
        Me.D_name.Name = "D_name"
        Me.D_name.ReadOnly = True
        Me.D_name.Width = 130
        '
        'Time
        '
        Me.Time.HeaderText = "Time"
        Me.Time.Name = "Time"
        Me.Time.ReadOnly = True
        '
        'status
        '
        Me.status.HeaderText = "status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 60
        '
        'VS
        '
        Me.VS.HeaderText = ""
        Me.VS.Name = "VS"
        Me.VS.ReadOnly = True
        Me.VS.Text = "Vital Signs"
        '
        'dig
        '
        Me.dig.HeaderText = ""
        Me.dig.Name = "dig"
        Me.dig.ReadOnly = True
        Me.dig.Text = "Diagnose"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(986, 39)
        Me.Panel6.TabIndex = 35
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(403, 8)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 24)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Queue"
        '
        'TabDiagnose
        '
        Me.TabDiagnose.Controls.Add(Me.DiagnoseTabHelpNote)
        Me.TabDiagnose.Controls.Add(Me.DiagnoseDataGridView)
        Me.TabDiagnose.Controls.Add(Me.Panel7)
        Me.TabDiagnose.Location = New System.Drawing.Point(4, 22)
        Me.TabDiagnose.Name = "TabDiagnose"
        Me.TabDiagnose.Size = New System.Drawing.Size(992, 651)
        Me.TabDiagnose.TabIndex = 2
        Me.TabDiagnose.Text = "Diagnose"
        Me.TabDiagnose.UseVisualStyleBackColor = True
        '
        'DiagnoseDataGridView
        '
        Me.DiagnoseDataGridView.AllowUserToAddRows = False
        Me.DiagnoseDataGridView.AllowUserToDeleteRows = False
        Me.DiagnoseDataGridView.AllowUserToResizeColumns = False
        Me.DiagnoseDataGridView.AllowUserToResizeRows = False
        Me.DiagnoseDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DiagnoseDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DiagnoseDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.DiagnoseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DiagnoseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.Diagnose})
        Me.MainHelpProvider.SetHelpString(Me.DiagnoseDataGridView, "Display List of Today appointments")
        Me.DiagnoseDataGridView.Location = New System.Drawing.Point(121, 76)
        Me.DiagnoseDataGridView.MultiSelect = False
        Me.DiagnoseDataGridView.Name = "DiagnoseDataGridView"
        Me.DiagnoseDataGridView.ReadOnly = True
        Me.DiagnoseDataGridView.ShowEditingIcon = False
        Me.MainHelpProvider.SetShowHelp(Me.DiagnoseDataGridView, True)
        Me.DiagnoseDataGridView.Size = New System.Drawing.Size(660, 307)
        Me.DiagnoseDataGridView.TabIndex = 37
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Appointment ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 105
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Patient"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 130
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 30
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Diagnose
        '
        Me.Diagnose.HeaderText = "Diagnose"
        Me.Diagnose.Name = "Diagnose"
        Me.Diagnose.ReadOnly = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel7.Controls.Add(Me.Label20)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(992, 39)
        Me.Panel7.TabIndex = 35
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(406, 8)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 24)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Diagnose"
        '
        'TabPayment
        '
        Me.TabPayment.Controls.Add(Me.PaymentTabHelpNote)
        Me.TabPayment.Controls.Add(Me.Paybtn)
        Me.TabPayment.Controls.Add(Me.insuranceidtxtbox)
        Me.TabPayment.Controls.Add(Me.Label25)
        Me.TabPayment.Controls.Add(Me.apptotaltxtbox)
        Me.TabPayment.Controls.Add(Me.Label24)
        Me.TabPayment.Controls.Add(Me.GroupBox4)
        Me.TabPayment.Controls.Add(Me.patientnametxtbox)
        Me.TabPayment.Controls.Add(Me.Label23)
        Me.TabPayment.Controls.Add(Me.apptypetxtbox)
        Me.TabPayment.Controls.Add(Me.Label12)
        Me.TabPayment.Controls.Add(Me.patientidtxtbox)
        Me.TabPayment.Controls.Add(Me.Label11)
        Me.TabPayment.Controls.Add(Me.appidtxtbox)
        Me.TabPayment.Controls.Add(Me.Label10)
        Me.TabPayment.Controls.Add(Me.appdatetxtbox)
        Me.TabPayment.Controls.Add(Me.Label7)
        Me.TabPayment.Controls.Add(Me.Panel1)
        Me.TabPayment.Controls.Add(Me.PaymentDGV)
        Me.TabPayment.Location = New System.Drawing.Point(4, 22)
        Me.TabPayment.Name = "TabPayment"
        Me.TabPayment.Size = New System.Drawing.Size(992, 651)
        Me.TabPayment.TabIndex = 5
        Me.TabPayment.Text = "Payment"
        Me.TabPayment.UseVisualStyleBackColor = True
        '
        'Paybtn
        '
        Me.Paybtn.Enabled = False
        Me.MainHelpProvider.SetHelpNavigator(Me.Paybtn, System.Windows.Forms.HelpNavigator.Index)
        Me.Paybtn.Location = New System.Drawing.Point(784, 527)
        Me.Paybtn.Name = "Paybtn"
        Me.MainHelpProvider.SetShowHelp(Me.Paybtn, True)
        Me.Paybtn.Size = New System.Drawing.Size(131, 41)
        Me.Paybtn.TabIndex = 55
        Me.Paybtn.Text = "Confirm Payment"
        Me.Paybtn.UseVisualStyleBackColor = True
        '
        'insuranceidtxtbox
        '
        Me.insuranceidtxtbox.Enabled = False
        Me.insuranceidtxtbox.Location = New System.Drawing.Point(335, 513)
        Me.insuranceidtxtbox.Name = "insuranceidtxtbox"
        Me.insuranceidtxtbox.Size = New System.Drawing.Size(152, 20)
        Me.insuranceidtxtbox.TabIndex = 54
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(256, 516)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 13)
        Me.Label25.TabIndex = 53
        Me.Label25.Text = "Insurance ID:"
        '
        'apptotaltxtbox
        '
        Me.apptotaltxtbox.Location = New System.Drawing.Point(763, 395)
        Me.apptotaltxtbox.Name = "apptotaltxtbox"
        Me.apptotaltxtbox.ReadOnly = True
        Me.apptotaltxtbox.Size = New System.Drawing.Size(152, 20)
        Me.apptotaltxtbox.TabIndex = 52
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(683, 398)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(31, 13)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Total"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.insurancerb)
        Me.GroupBox4.Controls.Add(Me.cashrb)
        Me.GroupBox4.Location = New System.Drawing.Point(67, 453)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(160, 96)
        Me.GroupBox4.TabIndex = 50
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Payment method"
        '
        'insurancerb
        '
        Me.insurancerb.AutoSize = True
        Me.insurancerb.Location = New System.Drawing.Point(32, 63)
        Me.insurancerb.Name = "insurancerb"
        Me.insurancerb.Size = New System.Drawing.Size(72, 17)
        Me.insurancerb.TabIndex = 1
        Me.insurancerb.Text = "Insurance"
        Me.insurancerb.UseVisualStyleBackColor = True
        '
        'cashrb
        '
        Me.cashrb.AutoSize = True
        Me.cashrb.Location = New System.Drawing.Point(32, 28)
        Me.cashrb.Name = "cashrb"
        Me.cashrb.Size = New System.Drawing.Size(49, 17)
        Me.cashrb.TabIndex = 0
        Me.cashrb.Text = "Cash"
        Me.cashrb.UseVisualStyleBackColor = True
        '
        'patientnametxtbox
        '
        Me.patientnametxtbox.Location = New System.Drawing.Point(763, 329)
        Me.patientnametxtbox.Name = "patientnametxtbox"
        Me.patientnametxtbox.ReadOnly = True
        Me.patientnametxtbox.Size = New System.Drawing.Size(152, 20)
        Me.patientnametxtbox.TabIndex = 49
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(683, 332)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 13)
        Me.Label23.TabIndex = 48
        Me.Label23.Text = "Patient name:"
        '
        'apptypetxtbox
        '
        Me.apptypetxtbox.Location = New System.Drawing.Point(473, 392)
        Me.apptypetxtbox.Name = "apptypetxtbox"
        Me.apptypetxtbox.ReadOnly = True
        Me.apptypetxtbox.Size = New System.Drawing.Size(152, 20)
        Me.apptypetxtbox.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(363, 395)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Appointment type:"
        '
        'patientidtxtbox
        '
        Me.patientidtxtbox.Location = New System.Drawing.Point(473, 329)
        Me.patientidtxtbox.Name = "patientidtxtbox"
        Me.patientidtxtbox.ReadOnly = True
        Me.patientidtxtbox.Size = New System.Drawing.Size(152, 20)
        Me.patientidtxtbox.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(363, 332)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Patient ID:"
        '
        'appidtxtbox
        '
        Me.appidtxtbox.Location = New System.Drawing.Point(174, 329)
        Me.appidtxtbox.Name = "appidtxtbox"
        Me.appidtxtbox.ReadOnly = True
        Me.appidtxtbox.Size = New System.Drawing.Size(152, 20)
        Me.appidtxtbox.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(64, 332)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Appointment ID:"
        '
        'appdatetxtbox
        '
        Me.appdatetxtbox.Location = New System.Drawing.Point(174, 392)
        Me.appdatetxtbox.Name = "appdatetxtbox"
        Me.appdatetxtbox.ReadOnly = True
        Me.appdatetxtbox.Size = New System.Drawing.Size(152, 20)
        Me.appdatetxtbox.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 395)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Appointment date:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 39)
        Me.Panel1.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(406, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Payment"
        '
        'PaymentDGV
        '
        Me.PaymentDGV.AllowUserToAddRows = False
        Me.PaymentDGV.AllowUserToDeleteRows = False
        Me.PaymentDGV.AllowUserToResizeColumns = False
        Me.PaymentDGV.AllowUserToResizeRows = False
        Me.PaymentDGV.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PaymentDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PaymentDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.PaymentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PaymentDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewButtonColumn1})
        Me.MainHelpProvider.SetHelpString(Me.PaymentDGV, "Display List of Today appointments")
        Me.PaymentDGV.Location = New System.Drawing.Point(207, 68)
        Me.PaymentDGV.MultiSelect = False
        Me.PaymentDGV.Name = "PaymentDGV"
        Me.PaymentDGV.ReadOnly = True
        Me.PaymentDGV.ShowEditingIcon = False
        Me.MainHelpProvider.SetShowHelp(Me.PaymentDGV, True)
        Me.PaymentDGV.Size = New System.Drawing.Size(536, 189)
        Me.PaymentDGV.TabIndex = 38
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Appointment ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 105
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 90
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Patient"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 110
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 50
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 30
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.HeaderText = "Payment"
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.ReadOnly = True
        '
        'TabReports
        '
        Me.TabReports.Controls.Add(Me.ReportsTabControl)
        Me.TabReports.Location = New System.Drawing.Point(4, 22)
        Me.TabReports.Name = "TabReports"
        Me.TabReports.Size = New System.Drawing.Size(992, 651)
        Me.TabReports.TabIndex = 6
        Me.TabReports.Text = "Reports"
        Me.TabReports.UseVisualStyleBackColor = True
        '
        'ReportsTabControl
        '
        Me.ReportsTabControl.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.ReportsTabControl.Controls.Add(Me.patientRTab)
        Me.ReportsTabControl.Controls.Add(Me.digHTab)
        Me.ReportsTabControl.Controls.Add(Me.PatientLTab)
        Me.ReportsTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportsTabControl.Location = New System.Drawing.Point(0, 0)
        Me.ReportsTabControl.Multiline = True
        Me.ReportsTabControl.Name = "ReportsTabControl"
        Me.ReportsTabControl.SelectedIndex = 0
        Me.ReportsTabControl.Size = New System.Drawing.Size(992, 651)
        Me.ReportsTabControl.TabIndex = 1
        '
        'patientRTab
        '
        Me.patientRTab.Controls.Add(Me.PatientsRTabHelpNote)
        Me.patientRTab.Controls.Add(Me.PatientReportDGV)
        Me.patientRTab.Controls.Add(Me.Panel13)
        Me.patientRTab.Controls.Add(Me.Panel9)
        Me.patientRTab.Location = New System.Drawing.Point(23, 4)
        Me.patientRTab.Name = "patientRTab"
        Me.patientRTab.Padding = New System.Windows.Forms.Padding(3)
        Me.patientRTab.Size = New System.Drawing.Size(965, 643)
        Me.patientRTab.TabIndex = 1
        Me.patientRTab.Text = "Patient reports"
        Me.patientRTab.UseVisualStyleBackColor = True
        '
        'PatientReportDGV
        '
        Me.PatientReportDGV.AllowUserToAddRows = False
        Me.PatientReportDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PatientReportDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.PatientReportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientReportDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.Report, Me.PatientName, Me.DataGridViewTextBoxColumn16, Me.DataGridViewButtonColumn2, Me.Attachment})
        Me.PatientReportDGV.Location = New System.Drawing.Point(6, 146)
        Me.PatientReportDGV.Name = "PatientReportDGV"
        Me.PatientReportDGV.ReadOnly = True
        Me.PatientReportDGV.Size = New System.Drawing.Size(953, 398)
        Me.PatientReportDGV.TabIndex = 39
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Medical History ID"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Document ID"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn15.Width = 180
        '
        'Report
        '
        Me.Report.HeaderText = "Report"
        Me.Report.Name = "Report"
        Me.Report.ReadOnly = True
        Me.Report.Width = 120
        '
        'PatientName
        '
        Me.PatientName.HeaderText = "Patient"
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Doctor"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewButtonColumn2
        '
        Me.DataGridViewButtonColumn2.HeaderText = "Print Request"
        Me.DataGridViewButtonColumn2.Name = "DataGridViewButtonColumn2"
        Me.DataGridViewButtonColumn2.ReadOnly = True
        Me.DataGridViewButtonColumn2.Text = "Print Request"
        Me.DataGridViewButtonColumn2.UseColumnTextForButtonValue = True
        '
        'Attachment
        '
        Me.Attachment.HeaderText = "Attachment"
        Me.Attachment.Name = "Attachment"
        Me.Attachment.ReadOnly = True
        Me.Attachment.Text = ""
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel13.Controls.Add(Me.appidsebox)
        Me.Panel13.Controls.Add(Me.patRcombobox)
        Me.Panel13.Controls.Add(Me.Label34)
        Me.Panel13.Controls.Add(Me.Label35)
        Me.Panel13.Controls.Add(Me.searchPatienRepBtn)
        Me.Panel13.Location = New System.Drawing.Point(6, 100)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(953, 44)
        Me.Panel13.TabIndex = 38
        '
        'appidsebox
        '
        Me.appidsebox.Location = New System.Drawing.Point(325, 13)
        Me.appidsebox.Name = "appidsebox"
        Me.appidsebox.Size = New System.Drawing.Size(100, 20)
        Me.appidsebox.TabIndex = 48
        '
        'patRcombobox
        '
        Me.patRcombobox.FormattingEnabled = True
        Me.patRcombobox.Location = New System.Drawing.Point(87, 11)
        Me.patRcombobox.Name = "patRcombobox"
        Me.patRcombobox.Size = New System.Drawing.Size(121, 21)
        Me.patRcombobox.TabIndex = 38
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(236, 15)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(83, 13)
        Me.Label34.TabIndex = 46
        Me.Label34.Text = "Appointment ID:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(7, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(74, 13)
        Me.Label35.TabIndex = 39
        Me.Label35.Text = "Patient Name:"
        '
        'searchPatienRepBtn
        '
        Me.searchPatienRepBtn.Location = New System.Drawing.Point(866, 9)
        Me.searchPatienRepBtn.Name = "searchPatienRepBtn"
        Me.searchPatienRepBtn.Size = New System.Drawing.Size(75, 23)
        Me.searchPatienRepBtn.TabIndex = 36
        Me.searchPatienRepBtn.Text = "Search"
        Me.searchPatienRepBtn.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel9.Controls.Add(Me.Label39)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(3, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(959, 39)
        Me.Panel9.TabIndex = 32
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(406, 8)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(129, 24)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "Patient reports"
        '
        'digHTab
        '
        Me.digHTab.AutoScroll = True
        Me.digHTab.Controls.Add(Me.DigHistabHelpNote)
        Me.digHTab.Controls.Add(Me.DgRepsDataGridView)
        Me.digHTab.Controls.Add(Me.Panel12)
        Me.digHTab.Controls.Add(Me.Panel8)
        Me.digHTab.Location = New System.Drawing.Point(23, 4)
        Me.digHTab.Name = "digHTab"
        Me.digHTab.Padding = New System.Windows.Forms.Padding(3)
        Me.digHTab.Size = New System.Drawing.Size(965, 643)
        Me.digHTab.TabIndex = 0
        Me.digHTab.Text = "Diagnose history"
        Me.digHTab.UseVisualStyleBackColor = True
        '
        'DgRepsDataGridView
        '
        Me.DgRepsDataGridView.AllowUserToAddRows = False
        Me.DgRepsDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgRepsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.DgRepsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgRepsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.appointmentID, Me.appDate, Me.DataGridViewTextBoxColumn12, Me.Doctor, Me.Genbtn})
        Me.DgRepsDataGridView.Location = New System.Drawing.Point(104, 139)
        Me.DgRepsDataGridView.Name = "DgRepsDataGridView"
        Me.DgRepsDataGridView.ReadOnly = True
        Me.DgRepsDataGridView.Size = New System.Drawing.Size(755, 398)
        Me.DgRepsDataGridView.TabIndex = 37
        '
        'appointmentID
        '
        Me.appointmentID.HeaderText = "Medical History ID"
        Me.appointmentID.Name = "appointmentID"
        Me.appointmentID.ReadOnly = True
        Me.appointmentID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.appointmentID.Width = 130
        '
        'appDate
        '
        Me.appDate.HeaderText = "Date"
        Me.appDate.Name = "appDate"
        Me.appDate.ReadOnly = True
        Me.appDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.appDate.Width = 150
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Diagnose"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn12.Width = 200
        '
        'Doctor
        '
        Me.Doctor.HeaderText = "Doctor"
        Me.Doctor.Name = "Doctor"
        Me.Doctor.ReadOnly = True
        Me.Doctor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Doctor.Width = 130
        '
        'Genbtn
        '
        Me.Genbtn.HeaderText = "Generate Report"
        Me.Genbtn.Name = "Genbtn"
        Me.Genbtn.ReadOnly = True
        Me.Genbtn.Text = "Generate Report"
        Me.Genbtn.UseColumnTextForButtonValue = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel12.Controls.Add(Me.DoctComboBox)
        Me.Panel12.Controls.Add(Me.PatComboBox)
        Me.Panel12.Controls.Add(Me.Label33)
        Me.Panel12.Controls.Add(Me.Label38)
        Me.Panel12.Controls.Add(Me.searchDgHisBtn)
        Me.Panel12.Location = New System.Drawing.Point(104, 94)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(755, 44)
        Me.Panel12.TabIndex = 36
        '
        'DoctComboBox
        '
        Me.DoctComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DoctComboBox.FormattingEnabled = True
        Me.DoctComboBox.Location = New System.Drawing.Point(315, 11)
        Me.DoctComboBox.Name = "DoctComboBox"
        Me.DoctComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DoctComboBox.TabIndex = 47
        '
        'PatComboBox
        '
        Me.PatComboBox.FormattingEnabled = True
        Me.PatComboBox.Location = New System.Drawing.Point(87, 11)
        Me.PatComboBox.Name = "PatComboBox"
        Me.PatComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PatComboBox.TabIndex = 38
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(236, 15)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(73, 13)
        Me.Label33.TabIndex = 46
        Me.Label33.Text = "Doctor Name:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(7, 16)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(74, 13)
        Me.Label38.TabIndex = 39
        Me.Label38.Text = "Patient Name:"
        '
        'searchDgHisBtn
        '
        Me.searchDgHisBtn.Location = New System.Drawing.Point(668, 11)
        Me.searchDgHisBtn.Name = "searchDgHisBtn"
        Me.searchDgHisBtn.Size = New System.Drawing.Size(75, 23)
        Me.searchDgHisBtn.TabIndex = 36
        Me.searchDgHisBtn.Text = "Search"
        Me.searchDgHisBtn.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel8.Controls.Add(Me.Label28)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(3, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(959, 39)
        Me.Panel8.TabIndex = 33
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(409, 8)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(149, 24)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Diagnose history"
        '
        'PatientLTab
        '
        Me.PatientLTab.Controls.Add(Me.PatientsListTabHelpNote)
        Me.PatientLTab.Controls.Add(Me.Panel11)
        Me.PatientLTab.Controls.Add(Me.PatientsDGV)
        Me.PatientLTab.Controls.Add(Me.Panel10)
        Me.PatientLTab.Location = New System.Drawing.Point(23, 4)
        Me.PatientLTab.Name = "PatientLTab"
        Me.PatientLTab.Size = New System.Drawing.Size(965, 643)
        Me.PatientLTab.TabIndex = 2
        Me.PatientLTab.Text = "Patient list"
        Me.PatientLTab.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel11.Controls.Add(Me.BTCB)
        Me.Panel11.Controls.Add(Me.Label32)
        Me.Panel11.Controls.Add(Me.GenderCB)
        Me.Panel11.Controls.Add(Me.Label31)
        Me.Panel11.Controls.Add(Me.Label30)
        Me.Panel11.Controls.Add(Me.maxagetxtbox)
        Me.Panel11.Controls.Add(Me.Label29)
        Me.Panel11.Controls.Add(Me.minagetxtbox)
        Me.Panel11.Controls.Add(Me.Label27)
        Me.Panel11.Controls.Add(Me.keywordtxtbox)
        Me.Panel11.Controls.Add(Me.Label26)
        Me.Panel11.Controls.Add(Me.Filterbtn)
        Me.Panel11.Controls.Add(Me.ShowAllbtn)
        Me.Panel11.Controls.Add(Me.exportbtn)
        Me.Panel11.Location = New System.Drawing.Point(39, 95)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(888, 44)
        Me.Panel11.TabIndex = 35
        '
        'BTCB
        '
        Me.BTCB.FormattingEnabled = True
        Me.BTCB.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.BTCB.Location = New System.Drawing.Point(565, 13)
        Me.BTCB.Name = "BTCB"
        Me.BTCB.Size = New System.Drawing.Size(47, 21)
        Me.BTCB.TabIndex = 49
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(498, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(64, 13)
        Me.Label32.TabIndex = 48
        Me.Label32.Text = "Blood Type:"
        '
        'GenderCB
        '
        Me.GenderCB.FormattingEnabled = True
        Me.GenderCB.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderCB.Location = New System.Drawing.Point(402, 13)
        Me.GenderCB.Name = "GenderCB"
        Me.GenderCB.Size = New System.Drawing.Size(79, 21)
        Me.GenderCB.TabIndex = 47
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(355, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(45, 13)
        Me.Label31.TabIndex = 46
        Me.Label31.Text = "Gender:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(286, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(20, 13)
        Me.Label30.TabIndex = 45
        Me.Label30.Text = "To"
        '
        'maxagetxtbox
        '
        Me.maxagetxtbox.Location = New System.Drawing.Point(308, 13)
        Me.maxagetxtbox.Name = "maxagetxtbox"
        Me.maxagetxtbox.Size = New System.Drawing.Size(38, 20)
        Me.maxagetxtbox.TabIndex = 44
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(215, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(30, 13)
        Me.Label29.TabIndex = 43
        Me.Label29.Text = "From"
        '
        'minagetxtbox
        '
        Me.minagetxtbox.Location = New System.Drawing.Point(245, 13)
        Me.minagetxtbox.Name = "minagetxtbox"
        Me.minagetxtbox.Size = New System.Drawing.Size(38, 20)
        Me.minagetxtbox.TabIndex = 42
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(190, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 13)
        Me.Label27.TabIndex = 41
        Me.Label27.Text = "Age:"
        '
        'keywordtxtbox
        '
        Me.keywordtxtbox.Location = New System.Drawing.Point(85, 13)
        Me.keywordtxtbox.Name = "keywordtxtbox"
        Me.keywordtxtbox.Size = New System.Drawing.Size(100, 20)
        Me.keywordtxtbox.TabIndex = 40
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(7, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(77, 13)
        Me.Label26.TabIndex = 39
        Me.Label26.Text = "Name Contain:"
        '
        'Filterbtn
        '
        Me.Filterbtn.Location = New System.Drawing.Point(636, 11)
        Me.Filterbtn.Name = "Filterbtn"
        Me.Filterbtn.Size = New System.Drawing.Size(75, 23)
        Me.Filterbtn.TabIndex = 38
        Me.Filterbtn.Text = "Filter"
        Me.Filterbtn.UseVisualStyleBackColor = True
        '
        'ShowAllbtn
        '
        Me.ShowAllbtn.Location = New System.Drawing.Point(717, 11)
        Me.ShowAllbtn.Name = "ShowAllbtn"
        Me.ShowAllbtn.Size = New System.Drawing.Size(75, 23)
        Me.ShowAllbtn.TabIndex = 37
        Me.ShowAllbtn.Text = "Show All"
        Me.ShowAllbtn.UseVisualStyleBackColor = True
        '
        'exportbtn
        '
        Me.exportbtn.Location = New System.Drawing.Point(798, 11)
        Me.exportbtn.Name = "exportbtn"
        Me.exportbtn.Size = New System.Drawing.Size(75, 23)
        Me.exportbtn.TabIndex = 36
        Me.exportbtn.Text = "Export"
        Me.exportbtn.UseVisualStyleBackColor = True
        '
        'PatientsDGV
        '
        Me.PatientsDGV.AllowUserToAddRows = False
        Me.PatientsDGV.AllowUserToDeleteRows = False
        Me.PatientsDGV.AllowUserToResizeColumns = False
        Me.PatientsDGV.AllowUserToResizeRows = False
        Me.PatientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Pname, Me.Pid, Me.Bdate, Me.page, Me.pgender, Me.Phone, Me.Address, Me.bloodtype})
        Me.PatientsDGV.Location = New System.Drawing.Point(39, 139)
        Me.PatientsDGV.Name = "PatientsDGV"
        Me.PatientsDGV.ReadOnly = True
        Me.PatientsDGV.Size = New System.Drawing.Size(888, 412)
        Me.PatientsDGV.TabIndex = 35
        '
        'Pname
        '
        Me.Pname.HeaderText = "Patient Name"
        Me.Pname.Name = "Pname"
        Me.Pname.ReadOnly = True
        Me.Pname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Pname.Width = 130
        '
        'Pid
        '
        Me.Pid.HeaderText = "Patient ID"
        Me.Pid.Name = "Pid"
        Me.Pid.ReadOnly = True
        Me.Pid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Pid.Width = 110
        '
        'Bdate
        '
        Me.Bdate.HeaderText = "Birth Date"
        Me.Bdate.Name = "Bdate"
        Me.Bdate.ReadOnly = True
        Me.Bdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'page
        '
        Me.page.HeaderText = "Age"
        Me.page.Name = "page"
        Me.page.ReadOnly = True
        Me.page.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.page.Width = 50
        '
        'pgender
        '
        Me.pgender.HeaderText = "Gender"
        Me.pgender.Name = "pgender"
        Me.pgender.ReadOnly = True
        Me.pgender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.pgender.Width = 70
        '
        'Phone
        '
        Me.Phone.HeaderText = "Phone No."
        Me.Phone.Name = "Phone"
        Me.Phone.ReadOnly = True
        Me.Phone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Phone.Width = 110
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Address.Width = 185
        '
        'bloodtype
        '
        Me.bloodtype.HeaderText = "Blood Type"
        Me.bloodtype.Name = "bloodtype"
        Me.bloodtype.ReadOnly = True
        Me.bloodtype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.bloodtype.Width = 85
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel10.Controls.Add(Me.Label47)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(965, 39)
        Me.Panel10.TabIndex = 34
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.White
        Me.Label47.Location = New System.Drawing.Point(406, 8)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(92, 24)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "Patient list"
        '
        'TabAdmin
        '
        Me.TabAdmin.Controls.Add(Me.TabControlAdmin)
        Me.TabAdmin.Location = New System.Drawing.Point(4, 22)
        Me.TabAdmin.Name = "TabAdmin"
        Me.TabAdmin.Size = New System.Drawing.Size(992, 651)
        Me.TabAdmin.TabIndex = 3
        Me.TabAdmin.Text = "Administration"
        Me.TabAdmin.UseVisualStyleBackColor = True
        '
        'TabControlAdmin
        '
        Me.TabControlAdmin.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControlAdmin.Controls.Add(Me.TabUdb)
        Me.TabControlAdmin.Controls.Add(Me.TabMed)
        Me.TabControlAdmin.Controls.Add(Me.TabSettings)
        Me.TabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlAdmin.Location = New System.Drawing.Point(0, 0)
        Me.TabControlAdmin.Multiline = True
        Me.TabControlAdmin.Name = "TabControlAdmin"
        Me.TabControlAdmin.SelectedIndex = 0
        Me.TabControlAdmin.Size = New System.Drawing.Size(992, 651)
        Me.TabControlAdmin.TabIndex = 0
        '
        'TabUdb
        '
        Me.TabUdb.AutoScroll = True
        Me.TabUdb.Controls.Add(UserTypeLabel)
        Me.TabUdb.Controls.Add(Me.UserTypeComboBox)
        Me.TabUdb.Controls.Add(Me.BindingNavigator1)
        Me.TabUdb.Controls.Add(Me.MUsersHelpNote)
        Me.TabUdb.Controls.Add(Me.Panel3)
        Me.TabUdb.Controls.Add(Me.TextBox1)
        Me.TabUdb.Controls.Add(Me.Label1)
        Me.TabUdb.Controls.Add(Me.UsersDataGridView)
        Me.TabUdb.Controls.Add(Me.TextBox5)
        Me.TabUdb.Controls.Add(Me.Label5)
        Me.TabUdb.Controls.Add(Me.TextBox4)
        Me.TabUdb.Controls.Add(Me.Label4)
        Me.TabUdb.Controls.Add(Me.TextBox3)
        Me.TabUdb.Controls.Add(Me.Label3)
        Me.TabUdb.Controls.Add(Me.TextBox2)
        Me.TabUdb.Controls.Add(Me.Label2)
        Me.TabUdb.Location = New System.Drawing.Point(23, 4)
        Me.TabUdb.Name = "TabUdb"
        Me.TabUdb.Padding = New System.Windows.Forms.Padding(3)
        Me.TabUdb.Size = New System.Drawing.Size(965, 643)
        Me.TabUdb.TabIndex = 0
        Me.TabUdb.Text = "Modify users"
        Me.TabUdb.UseVisualStyleBackColor = True
        '
        'UserTypeComboBox
        '
        Me.UserTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "UserType", True))
        Me.UserTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserTypeComboBox.FormattingEnabled = True
        Me.UserTypeComboBox.Items.AddRange(New Object() {"A", "D", "N", "R"})
        Me.UserTypeComboBox.Location = New System.Drawing.Point(127, 399)
        Me.UserTypeComboBox.Name = "UserTypeComboBox"
        Me.UserTypeComboBox.Size = New System.Drawing.Size(75, 21)
        Me.UserTypeComboBox.TabIndex = 37
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.CmsDataSet1
        '
        'CmsDataSet1
        '
        Me.CmsDataSet1.DataSetName = "CMSDataSet"
        Me.CmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.UserBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 42)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(959, 25)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'MUsersHelpNote
        '
        Me.MUsersHelpNote.AutoSize = True
        Me.MUsersHelpNote.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MUsersHelpNote.ForeColor = System.Drawing.SystemColors.Highlight
        Me.MUsersHelpNote.Location = New System.Drawing.Point(28, 547)
        Me.MUsersHelpNote.Name = "MUsersHelpNote"
        Me.MUsersHelpNote.Size = New System.Drawing.Size(52, 21)
        Me.MUsersHelpNote.TabIndex = 36
        Me.MUsersHelpNote.Text = "Note:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(959, 39)
        Me.Panel3.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(409, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Modify Usres"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "idUser", True))
        Me.TextBox1.Location = New System.Drawing.Point(127, 164)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 20)
        Me.TextBox1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "User ID"
        '
        'UsersDataGridView
        '
        Me.UsersDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UsersDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUserDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.LoginPasswordDataGridViewTextBoxColumn, Me.UserTypeDataGridViewTextBoxColumn})
        Me.UsersDataGridView.DataSource = Me.UserBindingSource
        Me.UsersDataGridView.Location = New System.Drawing.Point(315, 120)
        Me.UsersDataGridView.Name = "UsersDataGridView"
        Me.UsersDataGridView.Size = New System.Drawing.Size(644, 398)
        Me.UsersDataGridView.TabIndex = 14
        '
        'IdUserDataGridViewTextBoxColumn
        '
        Me.IdUserDataGridViewTextBoxColumn.DataPropertyName = "idUser"
        Me.IdUserDataGridViewTextBoxColumn.HeaderText = "idUser"
        Me.IdUserDataGridViewTextBoxColumn.Name = "IdUserDataGridViewTextBoxColumn"
        Me.IdUserDataGridViewTextBoxColumn.Width = 80
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "E-mail"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "E-mail"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 150
        '
        'LoginPasswordDataGridViewTextBoxColumn
        '
        Me.LoginPasswordDataGridViewTextBoxColumn.DataPropertyName = "LoginPassword"
        Me.LoginPasswordDataGridViewTextBoxColumn.HeaderText = "LoginPassword"
        Me.LoginPasswordDataGridViewTextBoxColumn.Name = "LoginPasswordDataGridViewTextBoxColumn"
        '
        'UserTypeDataGridViewTextBoxColumn
        '
        Me.UserTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType"
        Me.UserTypeDataGridViewTextBoxColumn.HeaderText = "UserType"
        Me.UserTypeDataGridViewTextBoxColumn.Items.AddRange(New Object() {"A", "D", "N", "R"})
        Me.UserTypeDataGridViewTextBoxColumn.Name = "UserTypeDataGridViewTextBoxColumn"
        Me.UserTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.UserTypeDataGridViewTextBoxColumn.Width = 60
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "LoginPassword", True))
        Me.TextBox5.Location = New System.Drawing.Point(127, 356)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(174, 20)
        Me.TextBox5.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Password"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "E-mail", True))
        Me.TextBox4.Location = New System.Drawing.Point(127, 310)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(174, 20)
        Me.TextBox4.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "E-Mail"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "LastName", True))
        Me.TextBox3.Location = New System.Drawing.Point(127, 264)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(174, 20)
        Me.TextBox3.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Last Name"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "FirstName", True))
        Me.TextBox2.Location = New System.Drawing.Point(127, 215)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(174, 20)
        Me.TextBox2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Name"
        '
        'TabMed
        '
        Me.TabMed.Controls.Add(TypeLabel)
        Me.TabMed.Controls.Add(Me.TypeComboBox)
        Me.TabMed.Controls.Add(DescriptionLabel)
        Me.TabMed.Controls.Add(Me.DescriptionRichTextBox)
        Me.TabMed.Controls.Add(NameLabel)
        Me.TabMed.Controls.Add(Me.NameTextBox)
        Me.TabMed.Controls.Add(IdMedicineLabel)
        Me.TabMed.Controls.Add(Me.IdMedicineTextBox)
        Me.TabMed.Controls.Add(Me.BindingNavigator2)
        Me.TabMed.Controls.Add(Me.MmedicinesHelpNote)
        Me.TabMed.Controls.Add(Me.Panel2)
        Me.TabMed.Controls.Add(Me.MedicineDataGridView)
        Me.TabMed.Location = New System.Drawing.Point(23, 4)
        Me.TabMed.Name = "TabMed"
        Me.TabMed.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMed.Size = New System.Drawing.Size(965, 643)
        Me.TabMed.TabIndex = 1
        Me.TabMed.Text = "Modify Medicines"
        Me.TabMed.UseVisualStyleBackColor = True
        '
        'TypeComboBox
        '
        Me.TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "Type", True))
        Me.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Items.AddRange(New Object() {"T", "C", "I", "L", "O", "D", "A"})
        Me.TypeComboBox.Location = New System.Drawing.Point(143, 343)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(54, 21)
        Me.TypeComboBox.TabIndex = 42
        '
        'MedicineBindingSource
        '
        Me.MedicineBindingSource.DataMember = "Medicine"
        Me.MedicineBindingSource.DataSource = Me.CmsDataSet1
        '
        'DescriptionRichTextBox
        '
        Me.DescriptionRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "Description", True))
        Me.DescriptionRichTextBox.Location = New System.Drawing.Point(143, 232)
        Me.DescriptionRichTextBox.Name = "DescriptionRichTextBox"
        Me.DescriptionRichTextBox.Size = New System.Drawing.Size(172, 96)
        Me.DescriptionRichTextBox.TabIndex = 41
        Me.DescriptionRichTextBox.Text = ""
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(143, 192)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(172, 20)
        Me.NameTextBox.TabIndex = 40
        '
        'IdMedicineTextBox
        '
        Me.IdMedicineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicineBindingSource, "idMedicine", True))
        Me.IdMedicineTextBox.Location = New System.Drawing.Point(143, 153)
        Me.IdMedicineTextBox.Name = "IdMedicineTextBox"
        Me.IdMedicineTextBox.Size = New System.Drawing.Size(172, 20)
        Me.IdMedicineTextBox.TabIndex = 39
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator2.BindingSource = Me.MedicineBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator2.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.ToolStripButton1})
        Me.BindingNavigator2.Location = New System.Drawing.Point(3, 42)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator2.Size = New System.Drawing.Size(959, 25)
        Me.BindingNavigator2.TabIndex = 38
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'MmedicinesHelpNote
        '
        Me.MmedicinesHelpNote.AutoSize = True
        Me.MmedicinesHelpNote.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MmedicinesHelpNote.ForeColor = System.Drawing.SystemColors.Highlight
        Me.MmedicinesHelpNote.Location = New System.Drawing.Point(50, 511)
        Me.MmedicinesHelpNote.Name = "MmedicinesHelpNote"
        Me.MmedicinesHelpNote.Size = New System.Drawing.Size(52, 21)
        Me.MmedicinesHelpNote.TabIndex = 37
        Me.MmedicinesHelpNote.Text = "Note:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(959, 39)
        Me.Panel2.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(406, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Modify Medicines"
        '
        'MedicineDataGridView
        '
        Me.MedicineDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MedicineDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.MedicineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MedicineDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMedicineDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn})
        Me.MedicineDataGridView.DataSource = Me.MedicineBindingSource
        Me.MedicineDataGridView.Location = New System.Drawing.Point(381, 102)
        Me.MedicineDataGridView.Name = "MedicineDataGridView"
        Me.MedicineDataGridView.Size = New System.Drawing.Size(540, 396)
        Me.MedicineDataGridView.TabIndex = 27
        '
        'IdMedicineDataGridViewTextBoxColumn
        '
        Me.IdMedicineDataGridViewTextBoxColumn.DataPropertyName = "idMedicine"
        Me.IdMedicineDataGridViewTextBoxColumn.HeaderText = "idMedicine"
        Me.IdMedicineDataGridViewTextBoxColumn.Name = "IdMedicineDataGridViewTextBoxColumn"
        Me.IdMedicineDataGridViewTextBoxColumn.Width = 70
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 150
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Width = 200
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Items.AddRange(New Object() {"T", "C", "I", "L", "O", "D", "A"})
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TypeDataGridViewTextBoxColumn.Width = 60
        '
        'TabSettings
        '
        Me.TabSettings.Controls.Add(Me.GroupBox3)
        Me.TabSettings.Controls.Add(Me.GroupBox2)
        Me.TabSettings.Controls.Add(Me.CSHelpNote)
        Me.TabSettings.Controls.Add(Me.SubmitBtn)
        Me.TabSettings.Controls.Add(Me.GroupBox1)
        Me.TabSettings.Controls.Add(Me.Clinictxt)
        Me.TabSettings.Controls.Add(Me.Label15)
        Me.TabSettings.Controls.Add(Me.Label14)
        Me.TabSettings.Controls.Add(Me.Panel4)
        Me.TabSettings.Location = New System.Drawing.Point(23, 4)
        Me.TabSettings.Name = "TabSettings"
        Me.TabSettings.Size = New System.Drawing.Size(965, 643)
        Me.TabSettings.TabIndex = 2
        Me.TabSettings.Text = "Clinic Settings"
        Me.TabSettings.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ToCB)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.FromCB)
        Me.GroupBox3.Location = New System.Drawing.Point(78, 155)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(230, 96)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Working Time"
        '
        'ToCB
        '
        Me.ToCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToCB.FormattingEnabled = True
        Me.ToCB.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.ToCB.Location = New System.Drawing.Point(108, 59)
        Me.ToCB.Name = "ToCB"
        Me.ToCB.Size = New System.Drawing.Size(73, 21)
        Me.ToCB.TabIndex = 41
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(54, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 16)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "To:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(54, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 16)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "From:"
        '
        'FromCB
        '
        Me.FromCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FromCB.FormattingEnabled = True
        Me.FromCB.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.FromCB.Location = New System.Drawing.Point(108, 24)
        Me.FromCB.Name = "FromCB"
        Me.FromCB.Size = New System.Drawing.Size(73, 21)
        Me.FromCB.TabIndex = 40
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FUtxtbox)
        Me.GroupBox2.Controls.Add(Me.FTtxtbox)
        Me.GroupBox2.Controls.Add(Me.FULabel)
        Me.GroupBox2.Controls.Add(Me.FTLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(75, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 109)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Clinic Fees"
        '
        'FUtxtbox
        '
        Me.FUtxtbox.Location = New System.Drawing.Point(119, 61)
        Me.FUtxtbox.Name = "FUtxtbox"
        Me.FUtxtbox.Size = New System.Drawing.Size(100, 20)
        Me.FUtxtbox.TabIndex = 45
        '
        'FTtxtbox
        '
        Me.FTtxtbox.Location = New System.Drawing.Point(119, 27)
        Me.FTtxtbox.Name = "FTtxtbox"
        Me.FTtxtbox.Size = New System.Drawing.Size(100, 20)
        Me.FTtxtbox.TabIndex = 44
        '
        'FULabel
        '
        Me.FULabel.AutoSize = True
        Me.FULabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FULabel.Location = New System.Drawing.Point(15, 62)
        Me.FULabel.Name = "FULabel"
        Me.FULabel.Size = New System.Drawing.Size(94, 16)
        Me.FULabel.TabIndex = 42
        Me.FULabel.Text = "Follow-up Visit"
        '
        'FTLabel
        '
        Me.FTLabel.AutoSize = True
        Me.FTLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FTLabel.Location = New System.Drawing.Point(15, 28)
        Me.FTLabel.Name = "FTLabel"
        Me.FTLabel.Size = New System.Drawing.Size(98, 16)
        Me.FTLabel.TabIndex = 43
        Me.FTLabel.Text = "First Time Visit:"
        '
        'CSHelpNote
        '
        Me.CSHelpNote.AutoSize = True
        Me.CSHelpNote.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CSHelpNote.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CSHelpNote.Location = New System.Drawing.Point(101, 519)
        Me.CSHelpNote.Name = "CSHelpNote"
        Me.CSHelpNote.Size = New System.Drawing.Size(52, 21)
        Me.CSHelpNote.TabIndex = 44
        Me.CSHelpNote.Text = "Note:"
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SubmitBtn.Location = New System.Drawing.Point(396, 415)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(113, 51)
        Me.SubmitBtn.TabIndex = 43
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Chk6)
        Me.GroupBox1.Controls.Add(Me.Chk5)
        Me.GroupBox1.Controls.Add(Me.Chk4)
        Me.GroupBox1.Controls.Add(Me.Chk3)
        Me.GroupBox1.Controls.Add(Me.Chk2)
        Me.GroupBox1.Controls.Add(Me.Chk1)
        Me.GroupBox1.Controls.Add(Me.Chk0)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(611, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 250)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Working Days:"
        '
        'Chk6
        '
        Me.Chk6.AutoSize = True
        Me.Chk6.Location = New System.Drawing.Point(19, 198)
        Me.Chk6.Name = "Chk6"
        Me.Chk6.Size = New System.Drawing.Size(84, 21)
        Me.Chk6.TabIndex = 6
        Me.Chk6.Text = "Saturday"
        Me.Chk6.UseVisualStyleBackColor = True
        '
        'Chk5
        '
        Me.Chk5.AutoSize = True
        Me.Chk5.Location = New System.Drawing.Point(19, 171)
        Me.Chk5.Name = "Chk5"
        Me.Chk5.Size = New System.Drawing.Size(66, 21)
        Me.Chk5.TabIndex = 5
        Me.Chk5.Text = "Friday"
        Me.Chk5.UseVisualStyleBackColor = True
        '
        'Chk4
        '
        Me.Chk4.AutoSize = True
        Me.Chk4.Location = New System.Drawing.Point(19, 144)
        Me.Chk4.Name = "Chk4"
        Me.Chk4.Size = New System.Drawing.Size(87, 21)
        Me.Chk4.TabIndex = 4
        Me.Chk4.Text = "Thursday"
        Me.Chk4.UseVisualStyleBackColor = True
        '
        'Chk3
        '
        Me.Chk3.AutoSize = True
        Me.Chk3.Location = New System.Drawing.Point(19, 117)
        Me.Chk3.Name = "Chk3"
        Me.Chk3.Size = New System.Drawing.Size(102, 21)
        Me.Chk3.TabIndex = 3
        Me.Chk3.Text = "Wednesday"
        Me.Chk3.UseVisualStyleBackColor = True
        '
        'Chk2
        '
        Me.Chk2.AutoSize = True
        Me.Chk2.Location = New System.Drawing.Point(19, 90)
        Me.Chk2.Name = "Chk2"
        Me.Chk2.Size = New System.Drawing.Size(82, 21)
        Me.Chk2.TabIndex = 2
        Me.Chk2.Text = "Tuesday"
        Me.Chk2.UseVisualStyleBackColor = True
        '
        'Chk1
        '
        Me.Chk1.AutoSize = True
        Me.Chk1.Location = New System.Drawing.Point(19, 63)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(77, 21)
        Me.Chk1.TabIndex = 1
        Me.Chk1.Text = "Monday"
        Me.Chk1.UseVisualStyleBackColor = True
        '
        'Chk0
        '
        Me.Chk0.AutoSize = True
        Me.Chk0.Location = New System.Drawing.Point(19, 36)
        Me.Chk0.Name = "Chk0"
        Me.Chk0.Size = New System.Drawing.Size(75, 21)
        Me.Chk0.TabIndex = 0
        Me.Chk0.Text = "Sunday"
        Me.Chk0.UseVisualStyleBackColor = True
        '
        'Clinictxt
        '
        Me.Clinictxt.Location = New System.Drawing.Point(165, 96)
        Me.Clinictxt.Name = "Clinictxt"
        Me.Clinictxt.Size = New System.Drawing.Size(232, 20)
        Me.Clinictxt.TabIndex = 37
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(72, 145)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 16)
        Me.Label15.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(72, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 16)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Clinic Name:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(965, 39)
        Me.Panel4.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(406, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 24)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Clinic Settings"
        '
        'LogoutBtn
        '
        Me.LogoutBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoutBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.LogoutBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LogoutBtn.Location = New System.Drawing.Point(924, 0)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(71, 22)
        Me.LogoutBtn.TabIndex = 1
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.UseVisualStyleBackColor = True
        '
        'UserNameLabel
        '
        Me.UserNameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Location = New System.Drawing.Point(863, 4)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.UserNameLabel.TabIndex = 2
        Me.UserNameLabel.Text = "UserName"
        '
        'MedicalHistoryTableAdapter
        '
        Me.MedicalHistoryTableAdapter.ClearBeforeFill = True
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "Patient"
        Me.PatientBindingSource.DataSource = Me.CmsDataSet1
        '
        'AppointmentBindingSource
        '
        Me.AppointmentBindingSource.DataMember = "Appointment"
        Me.AppointmentBindingSource.DataSource = Me.CmsDataSet1
        '
        'InvoiceBindingSource
        '
        Me.InvoiceBindingSource.DataMember = "Invoice"
        Me.InvoiceBindingSource.DataSource = Me.CmsDataSet1
        '
        'MedicalHistoryBindingSource
        '
        Me.MedicalHistoryBindingSource.DataMember = "MedicalHistory"
        Me.MedicalHistoryBindingSource.DataSource = Me.CmsDataSet1
        '
        'PrescriptionBindingSource
        '
        Me.PrescriptionBindingSource.DataMember = "Prescription"
        Me.PrescriptionBindingSource.DataSource = Me.CmsDataSet1
        '
        'PrescriptionTableAdapter
        '
        Me.PrescriptionTableAdapter.ClearBeforeFill = True
        '
        'ReportsBindingSource
        '
        Me.ReportsBindingSource.DataMember = "Reports"
        Me.ReportsBindingSource.DataSource = Me.CmsDataSet1
        '
        'ReportsTableAdapter
        '
        Me.ReportsTableAdapter.ClearBeforeFill = True
        '
        'AppointmentTableAdapter
        '
        Me.AppointmentTableAdapter.ClearBeforeFill = True
        '
        'InvoiceTableAdapter
        '
        Me.InvoiceTableAdapter.ClearBeforeFill = True
        '
        'MedicineTableAdapter
        '
        Me.MedicineTableAdapter.ClearBeforeFill = True
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AppointmentTableAdapter = Me.AppointmentTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.InvoiceTableAdapter = Me.InvoiceTableAdapter
        Me.TableAdapterManager.MedicalHistoryTableAdapter = Me.MedicalHistoryTableAdapter
        Me.TableAdapterManager.MedicineTableAdapter = Me.MedicineTableAdapter
        Me.TableAdapterManager.PatientTableAdapter = Me.PatientTableAdapter
        Me.TableAdapterManager.PrescriptionTableAdapter = Me.PrescriptionTableAdapter
        Me.TableAdapterManager.ReportsTableAdapter = Me.ReportsTableAdapter
        Me.TableAdapterManager.UpdateOrder = CMS.CMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Me.UserTableAdapter
        '
        'DiagnoseTabHelpNote
        '
        Me.DiagnoseTabHelpNote.AutoSize = True
        Me.DiagnoseTabHelpNote.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiagnoseTabHelpNote.ForeColor = System.Drawing.SystemColors.Highlight
        Me.DiagnoseTabHelpNote.Location = New System.Drawing.Point(117, 451)
        Me.DiagnoseTabHelpNote.Name = "DiagnoseTabHelpNote"
        Me.DiagnoseTabHelpNote.Size = New System.Drawing.Size(52, 21)
        Me.DiagnoseTabHelpNote.TabIndex = 38
        Me.DiagnoseTabHelpNote.Text = "Note:"
        '
        'PaymentTabHelpNote
        '
        Me.PaymentTabHelpNote.AutoSize = True
        Me.PaymentTabHelpNote.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentTabHelpNote.ForeColor = System.Drawing.SystemColors.Highlight
        Me.PaymentTabHelpNote.Location = New System.Drawing.Point(8, 573)
        Me.PaymentTabHelpNote.Name = "PaymentTabHelpNote"
        Me.PaymentTabHelpNote.Size = New System.Drawing.Size(52, 21)
        Me.PaymentTabHelpNote.TabIndex = 56
        Me.PaymentTabHelpNote.Text = "Note:"
        '
        'PatientsRTabHelpNote
        '
        Me.PatientsRTabHelpNote.AutoSize = True
        Me.PatientsRTabHelpNote.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientsRTabHelpNote.ForeColor = System.Drawing.SystemColors.Highlight
        Me.PatientsRTabHelpNote.Location = New System.Drawing.Point(12, 559)
        Me.PatientsRTabHelpNote.Name = "PatientsRTabHelpNote"
        Me.PatientsRTabHelpNote.Size = New System.Drawing.Size(52, 21)
        Me.PatientsRTabHelpNote.TabIndex = 40
        Me.PatientsRTabHelpNote.Text = "Note:"
        '
        'DigHistabHelpNote
        '
        Me.DigHistabHelpNote.AutoSize = True
        Me.DigHistabHelpNote.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigHistabHelpNote.ForeColor = System.Drawing.SystemColors.Highlight
        Me.DigHistabHelpNote.Location = New System.Drawing.Point(6, 563)
        Me.DigHistabHelpNote.Name = "DigHistabHelpNote"
        Me.DigHistabHelpNote.Size = New System.Drawing.Size(52, 21)
        Me.DigHistabHelpNote.TabIndex = 38
        Me.DigHistabHelpNote.Text = "Note:"
        '
        'PatientsListTabHelpNote
        '
        Me.PatientsListTabHelpNote.AutoSize = True
        Me.PatientsListTabHelpNote.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientsListTabHelpNote.ForeColor = System.Drawing.SystemColors.Highlight
        Me.PatientsListTabHelpNote.Location = New System.Drawing.Point(35, 565)
        Me.PatientsListTabHelpNote.Name = "PatientsListTabHelpNote"
        Me.PatientsListTabHelpNote.Size = New System.Drawing.Size(52, 21)
        Me.PatientsListTabHelpNote.TabIndex = 36
        Me.PatientsListTabHelpNote.Text = "Note:"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 677)
        Me.Controls.Add(Me.UserNameLabel)
        Me.Controls.Add(Me.LogoutBtn)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CMS"
        Me.TabControl.ResumeLayout(False)
        Me.TabMain.ResumeLayout(False)
        Me.TabMain.PerformLayout()
        CType(Me.AdminPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuePB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAppointment.ResumeLayout(False)
        Me.TabAppointment.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabQueue.ResumeLayout(False)
        Me.TabQueue.PerformLayout()
        CType(Me.QueueDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.TabDiagnose.ResumeLayout(False)
        Me.TabDiagnose.PerformLayout()
        CType(Me.DiagnoseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TabPayment.ResumeLayout(False)
        Me.TabPayment.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PaymentDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabReports.ResumeLayout(False)
        Me.ReportsTabControl.ResumeLayout(False)
        Me.patientRTab.ResumeLayout(False)
        Me.patientRTab.PerformLayout()
        CType(Me.PatientReportDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.digHTab.ResumeLayout(False)
        Me.digHTab.PerformLayout()
        CType(Me.DgRepsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.PatientLTab.ResumeLayout(False)
        Me.PatientLTab.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.PatientsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.TabAdmin.ResumeLayout(False)
        Me.TabControlAdmin.ResumeLayout(False)
        Me.TabUdb.ResumeLayout(False)
        Me.TabUdb.PerformLayout()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMed.ResumeLayout(False)
        Me.TabMed.PerformLayout()
        CType(Me.MedicineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.MedicineDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSettings.ResumeLayout(False)
        Me.TabSettings.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicalHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrescriptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabQueue As TabPage
    Friend WithEvents CmsDataSet1 As CMSDataSet
    Friend WithEvents MedicalHistoryTableAdapter As CMSDataSetTableAdapters.MedicalHistoryTableAdapter
    Friend WithEvents TabDiagnose As TabPage
    Friend WithEvents TabAdmin As TabPage
    Friend WithEvents TabAppointment As TabPage
    Friend WithEvents TabPayment As TabPage
    Friend WithEvents TabReports As TabPage
    Friend WithEvents TabMain As TabPage
    Friend WithEvents AdminLabel As Label
    Friend WithEvents ReportLabel As Label
    Friend WithEvents PayLabel As Label
    Friend WithEvents AppLabel As Label
    Friend WithEvents QueLabel As Label
    Friend WithEvents DigLabel As Label
    Friend WithEvents PayPB As PictureBox
    Friend WithEvents DigPB As PictureBox
    Friend WithEvents QuePB As PictureBox
    Friend WithEvents AppPB As PictureBox
    Friend WithEvents AdminPB As PictureBox
    Friend WithEvents ReportsPB As PictureBox
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents TabControlAdmin As TabControl
    Friend WithEvents TabMed As TabPage
    Friend WithEvents TabSettings As TabPage
    Friend WithEvents DayView1 As Calendar.DayView
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents TabUdb As TabPage
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UsersDataGridView As DataGridView
    Friend WithEvents MedicineBindingSource As BindingSource
    Friend WithEvents MedicineDataGridView As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Clinictxt As TextBox
    Friend WithEvents ToCB As ComboBox
    Friend WithEvents FromCB As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Chk6 As CheckBox
    Friend WithEvents Chk5 As CheckBox
    Friend WithEvents Chk4 As CheckBox
    Friend WithEvents Chk3 As CheckBox
    Friend WithEvents Chk2 As CheckBox
    Friend WithEvents Chk1 As CheckBox
    Friend WithEvents Chk0 As CheckBox
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents AppointmentBindingSource As BindingSource
    Friend WithEvents QueueDataGridView As DataGridView
    Friend WithEvents InvoiceBindingSource As BindingSource
    Friend WithEvents AppointmentNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicalHistoryBindingSource As BindingSource
    Friend WithEvents PrescriptionBindingSource As BindingSource
    Friend WithEvents PrescriptionTableAdapter As CMSDataSetTableAdapters.PrescriptionTableAdapter
    Friend WithEvents ReportsBindingSource As BindingSource
    Friend WithEvents ReportsTableAdapter As CMSDataSetTableAdapters.ReportsTableAdapter
    Friend WithEvents AppointmentTableAdapter As CMSDataSetTableAdapters.AppointmentTableAdapter
    Friend WithEvents InvoiceTableAdapter As CMSDataSetTableAdapters.InvoiceTableAdapter
    Friend WithEvents MedicineTableAdapter As CMSDataSetTableAdapters.MedicineTableAdapter
    Friend WithEvents PatientTableAdapter As CMSDataSetTableAdapters.PatientTableAdapter
    Friend WithEvents UserTableAdapter As CMSDataSetTableAdapters.UserTableAdapter
    Friend WithEvents PatientSearchComboBox As ComboBox
    Friend WithEvents ATWQbtn As Button
    Friend WithEvents MainHelpProvider As HelpProvider
    Friend WithEvents MainHelpNote As Label
    Friend WithEvents AppointmentsHelpNote As Label
    Friend WithEvents QueueHelpNote As Label
    Friend WithEvents DoctorComboBox As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents NPBtn As Button
    Friend WithEvents app_id As DataGridViewTextBoxColumn
    Friend WithEvents P_id As DataGridViewTextBoxColumn
    Friend WithEvents P_name As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents D_name As DataGridViewTextBoxColumn
    Friend WithEvents Time As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents VS As DataGridViewButtonColumn
    Friend WithEvents dig As DataGridViewButtonColumn
    Friend WithEvents MUsersHelpNote As Label
    Friend WithEvents MmedicinesHelpNote As Label
    Friend WithEvents CSHelpNote As Label
    Friend WithEvents TableAdapterManager As CMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TypeComboBox As ComboBox
    Friend WithEvents DescriptionRichTextBox As RichTextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents IdMedicineTextBox As TextBox
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents IdMedicineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents UserTypeComboBox As ComboBox
    Friend WithEvents IdUserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoginPasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents DiagnoseDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Diagnose As DataGridViewButtonColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents PaymentDGV As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FULabel As Label
    Friend WithEvents FTLabel As Label
    Friend WithEvents FUtxtbox As TextBox
    Friend WithEvents FTtxtbox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents patientnametxtbox As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents apptypetxtbox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents appidtxtbox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents appdatetxtbox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents apptotaltxtbox As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents insurancerb As RadioButton
    Friend WithEvents cashrb As RadioButton
    Friend WithEvents insuranceidtxtbox As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Paybtn As Button
    Friend WithEvents patientidtxtbox As TextBox
    Friend WithEvents ReportsTabControl As TabControl
    Friend WithEvents patientRTab As TabPage
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents digHTab As TabPage
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents PatientLTab As TabPage
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label47 As Label
    Friend WithEvents PatientsDGV As DataGridView
    Friend WithEvents exportbtn As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents keywordtxtbox As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Filterbtn As Button
    Friend WithEvents ShowAllbtn As Button
    Friend WithEvents Label30 As Label
    Friend WithEvents maxagetxtbox As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents minagetxtbox As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents BTCB As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents GenderCB As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Pname As DataGridViewTextBoxColumn
    Friend WithEvents Pid As DataGridViewTextBoxColumn
    Friend WithEvents Bdate As DataGridViewTextBoxColumn
    Friend WithEvents page As DataGridViewTextBoxColumn
    Friend WithEvents pgender As DataGridViewTextBoxColumn
    Friend WithEvents Phone As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents bloodtype As DataGridViewTextBoxColumn
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents searchDgHisBtn As Button
    Friend WithEvents DoctComboBox As ComboBox
    Friend WithEvents PatComboBox As ComboBox
    Friend WithEvents DgRepsDataGridView As DataGridView
    Friend WithEvents appointmentID As DataGridViewTextBoxColumn
    Friend WithEvents appDate As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents Doctor As DataGridViewTextBoxColumn
    Friend WithEvents Genbtn As DataGridViewButtonColumn
    Friend WithEvents PatientReportDGV As DataGridView
    Friend WithEvents Panel13 As Panel
    Friend WithEvents patRcombobox As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents searchPatienRepBtn As Button
    Friend WithEvents appidsebox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents Report As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn2 As DataGridViewButtonColumn
    Friend WithEvents Attachment As DataGridViewButtonColumn
    Friend WithEvents DiagnoseTabHelpNote As Label
    Friend WithEvents PaymentTabHelpNote As Label
    Friend WithEvents PatientsRTabHelpNote As Label
    Friend WithEvents DigHistabHelpNote As Label
    Friend WithEvents PatientsListTabHelpNote As Label
End Class
