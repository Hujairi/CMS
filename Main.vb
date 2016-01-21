Imports System.Globalization
Imports System.IO
Imports Calendar
Public Class Main
    'list of scheduled appointments
    Dim appointments As New List(Of Appointment)
    'get the information of the selected time cell in the DayView calendar and use it in the Appointment form
    Public selected As Appointment

    'S:Main tab
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not System.IO.Directory.Exists("c:\cms")) Then
            System.IO.Directory.CreateDirectory("c:\cms")
        End If
        'TODO: This line of code loads data into the 'CmsDataSet1.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.CmsDataSet1.User)
        'TODO: This line of code loads data into the 'CmsDataSet1.Prescription' table. You can move, or remove it, as needed.
        Me.PrescriptionTableAdapter.Fill(Me.CmsDataSet1.Prescription)
        'TODO: This line of code loads data into the 'CmsDataSet1.Reports' table. You can move, or remove it, as needed.
        Me.ReportsTableAdapter.Fill(Me.CmsDataSet1.Reports)
        'TODO: This line of code loads data into the 'CmsDataSet1.Patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me.CmsDataSet1.Patient)
        'TODO: This line of code loads data into the 'CmsDataSet1.Medicine' table. You can move, or remove it, as needed.
        Me.MedicineTableAdapter.Fill(Me.CmsDataSet1.Medicine)
        'TODO: This line of code loads data into the 'CmsDataSet1.MedicalHistory' table. You can move, or remove it, as needed.
        Me.MedicalHistoryTableAdapter.Fill(Me.CmsDataSet1.MedicalHistory)
        'TODO: This line of code loads data into the 'CmsDataSet1.Invoice' table. You can move, or remove it, as needed.
        Me.InvoiceTableAdapter.Fill(Me.CmsDataSet1.Invoice)
        'TODO: This line of code loads data into the 'CmsDataSet1.Appointment' table. You can move, or remove it, as needed.
        Me.AppointmentTableAdapter.Fill(Me.CmsDataSet1.Appointment)


        Dim query = From user In CmsDataSet1.User
                    Where user.idUser.ToUpper = Login.getUserID().ToUpper
                    Select user

        UserNameLabel.Text = query.First.idUser.ToUpper

        'customize the view according to user type'
        'every user has unique view'
        Select Case query.First.UserType
            Case "D"
                TabControl.TabPages.Remove(TabPayment)

                ReportsPB.Location = PayPB.Location
                ReportLabel.Location = PayLabel.Location
                PayPB.Hide()
                PayLabel.Hide()

                TabControlAdmin.TabPages.Remove(TabUdb)
                TabControlAdmin.TabPages.Remove(TabSettings)



            Case "R"
                TabControl.TabPages.Remove(TabDiagnose)
                TabControl.TabPages.Remove(TabAdmin)

                QuePB.Location = DigPB.Location
                QueLabel.Location = DigLabel.Location

                DigPB.Hide()
                DigLabel.Hide()

                ReportsPB.Location = AdminPB.Location
                ReportLabel.Location = AdminLabel.Location

                AdminPB.Hide()
                AdminLabel.Hide()

            Case "N"
                TabControl.TabPages.Remove(TabDiagnose)
                TabControl.TabPages.Remove(TabAdmin)
                TabControl.TabPages.Remove(TabPayment)

                ReportsPB.Location = DigPB.Location
                ReportLabel.Location = DigLabel.Location

                DigPB.Hide()
                DigLabel.Hide()
                AdminPB.Hide()
                AdminLabel.Hide()
                PayPB.Hide()
                PayLabel.Hide()
        End Select
        'retrieve appointment at the start of the application
        DayView1.StartDate = DateTime.Now
        Dim d As Date = System.DateTime.Now
        Dim d2 As Date = d.AddDays(6)
        retrive_apps(d, d2)


        'help notes to guide users
        displayHelpNotes()



    End Sub
    '.._Click subs to make images and labels of sections click-able 
    Private Sub App_Click(sender As Object, e As EventArgs) Handles AppPB.Click, AppLabel.Click
        TabControl.SelectedTab = TabAppointment

    End Sub
    Private Sub Que_Click(sender As Object, e As EventArgs) Handles QuePB.Click, QueLabel.Click
        TabControl.SelectedTab = TabQueue
    End Sub
    Private Sub Dig_Click(sender As Object, e As EventArgs) Handles DigPB.Click, DigLabel.Click
        TabControl.SelectedTab = TabDiagnose
    End Sub
    Private Sub Pay_Click(sender As Object, e As EventArgs) Handles PayPB.Click, PayLabel.Click
        TabControl.SelectedTab = TabPayment
    End Sub
    Private Sub Reports_Click(sender As Object, e As EventArgs) Handles ReportsPB.Click, ReportLabel.Click
        TabControl.SelectedTab = TabReports
    End Sub
    Private Sub Admin_Click(sender As Object, e As EventArgs) Handles AdminPB.Click, AdminLabel.Click
        TabControl.SelectedTab = TabAdmin
    End Sub
    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Login.Show()
        Me.Close()
    End Sub

    'do some actions when tabs opened or closed [ex: refresh queue datagridview] 
    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl.SelectedIndexChanged
        If TabControl.SelectedTab.Name = "TabQueue" Then
            dgvrefresh()
        ElseIf TabControl.SelectedTab.Name = "TabDiagnose"
            DgWatingListRefresh()
        ElseIf TabControl.SelectedTab.Name = "TabPayment"
            PDGVrefesh()
            Paybtn.Enabled = False
        ElseIf TabControl.SelectedTab.Name = "TabReports"
            PatientReportDGV.Rows.Clear()
            'query to get patients list
            Dim Patientlist = From Patient In CmsDataSet1.Patient
                              Let fullName = Patient.FirstName & " " & Patient.LastName
                              Select Patient.idPatient, fullName

            patRcombobox.DataSource = Patientlist.ToList
            patRcombobox.DisplayMember = "fullName"
            patRcombobox.ValueMember = "idPatient"
            'to make sure comboboxes selects nothing in the start
            patRcombobox.SelectedIndex = -1
        End If

    End Sub
    Private Sub displayHelpNotes()

        MainHelpNote.Text = "Note:" & Environment.NewLine & "Select the section you want to go to from the buttons or the tabs above"

        AppointmentsHelpNote.Text = "Note:" &
            Environment.NewLine & "-Schedule appointment: choose the time of the " &
            Environment.NewLine & "appointment from the dayview calendar below and double click on the chosen time." &
            Environment.NewLine & "You will be directed to the appointment form" &
            Environment.NewLine &
            Environment.NewLine & "-Delete appointment: right click on the appointment to remove it" &
            Environment.NewLine &
            Environment.NewLine & "-Change the days in dayview calendar: using the month calendar on the left" &
            Environment.NewLine & "Select the start of the week you want to display in the dayview calendar"

        QueueHelpNote.Text = "Note:" &
            Environment.NewLine & "Data-grid below represent the full process of treatment starting from appointment & ending in payment and check-out" &
            Environment.NewLine & "-Add vital signs: click on the vital signs button associated with specific patient to add the vital signs of that patient" &
            Environment.NewLine & "-Diagnose: click on the diagnose button associated with specific patient to start the diagnose process of that patient" &
            Environment.NewLine & "-Payment: after the diagnose is done. payment button will show.click on payment button to go to payment page"

        MUsersHelpNote.Text = "Note:" &
            Environment.NewLine & "Use this form to add and modify users" &
            Environment.NewLine & "User types: " &
            Environment.NewLine & "A:Admin | D:Doctor | R:Receptionist | N:Nurse"

        MmedicinesHelpNote.Text = "Note:" &
            Environment.NewLine & "Use this form to add and modify medicines" &
            Environment.NewLine & "Medicine types:" &
            Environment.NewLine & "T:Tablets | C:capsules | I:Injection | L:Liquid | O:Ointments | D:Drops | A:Aerosol"

        CSHelpNote.Text = "Note:" &
            Environment.NewLine & "use this form to set clinic settings .. wokring time,days and clinic name"

        DiagnoseTabHelpNote.Text = "Note:" &
            Environment.NewLine & "The above data grid view contains list of waiting patientsClick on diagnose button to start diagnose process" &
            Environment.NewLine & "diagnose form will open to start the diagnose of the patient"

        PaymentTabHelpNote.Text = "Note:" &
            Environment.NewLine & "The above data grid view contains list of done appointments.Click on payment button to start payment process" &
            Environment.NewLine & "Select the payment type and if it was insurance please provide insurance number.Then click on confirm payment"

        PatientsListTabHelpNote.Text = "Note:" &
            Environment.NewLine & "This data grid view is used to display the list of patients.You can view and export all patients or use filters" &
            Environment.NewLine & "to view/export patients with specific characteristics "

        PatientsRTabHelpNote.Text = "Note:" &
            Environment.NewLine & "list of reports requested by doctors for patients.Enter the patient name or the appointment id to get the list of" &
            Environment.NewLine & "required reports.Click on print request button to print and upload button to upload results"

        DigHistabHelpNote.Text = "Note:" &
            Environment.NewLine & "This tab is used to view the patients past diagnosis.Select the patient form the list and if you need more specific" &
            Environment.NewLine & "result select the doctor form doctors list"

    End Sub
    'E:Main tab

    'S:Addmin tab
    Private Sub TabControlAdmin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlAdmin.SelectedIndexChanged
        If TabControlAdmin.SelectedIndex = 2 Then

            Clinictxt.Text = My.Settings.ClinicName
            FromCB.SelectedIndex = My.Settings.StartTIme
            ToCB.SelectedIndex = My.Settings.EndTime

            If My.Settings.WorkingDays.Contains("Sunday") Then
                Chk0.Checked = True
            End If

            If My.Settings.WorkingDays.Contains("Monday") Then
                Chk1.Checked = True
            End If

            If My.Settings.WorkingDays.Contains("Tuesday") Then
                Chk2.Checked = True
            End If

            If My.Settings.WorkingDays.Contains("Wednesday") Then
                Chk3.Checked = True
            End If

            If My.Settings.WorkingDays.Contains("Thursday") Then
                Chk4.Checked = True
            End If

            If My.Settings.WorkingDays.Contains("Friday") Then
                Chk5.Checked = True
            End If

            If My.Settings.WorkingDays.Contains("Saturday") Then
                Chk6.Checked = True
            End If

            FTtxtbox.Text = My.Settings.FTfees
            FUtxtbox.Text = My.Settings.FUfees

        End If
    End Sub
    Private Sub settings_SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click

        If ToCB.SelectedIndex > FromCB.SelectedIndex Then
            If Clinictxt.Text <> "" And FUtxtbox.Text <> "" And FTtxtbox.Text <> "" Then
                My.Settings.ClinicName = Clinictxt.Text
                My.Settings.StartTIme = FromCB.SelectedIndex
                My.Settings.EndTime = ToCB.SelectedIndex
                My.Settings.FTfees = FTtxtbox.Text
                My.Settings.FUfees = FUtxtbox.Text

                My.Settings.WorkingDays = ""

                If Chk0.Checked = True Then
                    My.Settings.WorkingDays += "Sunday,"
                End If

                If Chk1.Checked = True Then
                    My.Settings.WorkingDays += "Monday,"
                End If

                If Chk2.Checked = True Then
                    My.Settings.WorkingDays += "Tuesday,"
                End If

                If Chk3.Checked = True Then
                    My.Settings.WorkingDays += "Wednesday,"
                End If

                If Chk4.Checked = True Then
                    My.Settings.WorkingDays += "Thursday,"
                End If

                If Chk5.Checked = True Then
                    My.Settings.WorkingDays += "Friday,"
                End If

                If Chk6.Checked = True Then
                    My.Settings.WorkingDays += "Saturday,"
                End If
            Else
                MsgBox("Clinic name and Fees Should not be empty.")
            End If

        Else
            MsgBox("Clinic work end time must be > Clinic work start time")
        End If


    End Sub
    Private Sub DataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles UsersDataGridView.DataError, MedicineDataGridView.DataError
        MsgBox("Data Error: Make sure entered data are correct")
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        MedicineTableAdapter.Update(CmsDataSet1.Medicine)
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        UserTableAdapter.Update(CmsDataSet1.User)
    End Sub
    Private Sub KeyPressValidation(sender As Object, e As KeyPressEventArgs) Handles FTtxtbox.KeyPress, FUtxtbox.KeyPress
        If (Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 46) Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then
                MessageBox.Show("Please enter numbers only")
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub FTtxtbox_TextChanged(sender As Object, e As EventArgs) Handles FTtxtbox.TextChanged
        Try
            If FTtxtbox.Text > 0 Then

            End If

        Catch ex As Exception
            FTtxtbox.Text = ""
        End Try
    End Sub
    Private Sub FUtxtbox_TextChanged(sender As Object, e As EventArgs) Handles FUtxtbox.TextChanged
        Try
            If FUtxtbox.Text > 0 Then

            End If

        Catch ex As Exception
            FUtxtbox.Text = ""
        End Try
    End Sub
    'E:Admin tab

    'S:appointment tab
    'change the days shown in the DayView calendar by selecting specific date in the monthCalendar 
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        retrive_apps(MonthCalendar1.SelectionStart, MonthCalendar1.SelectionStart.AddDays(6))
        DayView1.StartDate = MonthCalendar1.SelectionStart

    End Sub
    'function to retrieve appointments from database and add it to appointments list

    Private Sub retrive_apps(startdate As Date, enddate As Date)
        appointments.Clear()
        startdate = startdate.Date
        enddate = enddate.Date
        enddate = enddate.AddHours(My.Settings.EndTime)

        Dim query = From app In CmsDataSet1.Appointment Join user In CmsDataSet1.User On app.User_idUser Equals user.idUser Join patient In CmsDataSet1.Patient On app.Patient_idPatient Equals patient.idPatient
                    Let uname = user.FirstName + " " + user.LastName
                    Let pname = patient.FirstName + " " + patient.LastName
                    Where app.Start >= startdate And app.Start < enddate
                    Select app, user, patient, uname, pname

        For Each row In query
            Dim app As Appointment
            app = New Appointment()
            app.StartDate = row.app.Start
            app.EndDate = row.app._End
            app.Title = CStr(row.app.idAppointment) + " - Patient: " + row.pname + vbCrLf + "Doctor: " + row.uname
            app.Locked = True
            appointments.Add(app)
        Next
        'refresh DayView calendar after each insertion or delete
        DayView1.Invalidate()


    End Sub
    'add appointment directly to appointments list and the DayView Calendar
    Public Sub addNewAppointment(appointment As Appointment)
        appointments.Add(appointment)
        DayView1.Invalidate()
    End Sub
    'open appointment form when user double click
    Private Sub DayView1_DoubleClick(sender As Object, e As EventArgs) Handles DayView1.DoubleClick
        selected = New Appointment
        selected.StartDate = DayView1.SelectionStart
        selected.EndDate = DayView1.SelectionEnd
        If selected.StartDate >= System.DateTime.Now Then

            If My.Settings.WorkingDays.Contains(DayView1.SelectionStart.DayOfWeek.ToString) = False Or DayView1.SelectionStart.Hour < My.Settings.StartTIme Or DayView1.SelectionEnd.Hour > My.Settings.EndTime Or DayView1.SelectionStart.Hour >= My.Settings.EndTime Then
                MsgBox("Selected time outside clinic working time.")
            Else
                Appointmentform.Show()
            End If
        Else
            MsgBox("appointment can't be in the past")
        End If
    End Sub
    'delete appointment when user press right click
    Private Sub DayView1_RightClick(sender As Object, e As MouseEventArgs) Handles DayView1.MouseDown
        If e.Button = MouseButtons.Right Then
            Try
                For Each app In appointments
                    If app.Title = DayView1.SelectedAppointment.Title Then
                        Dim approw As CMSDataSet.AppointmentRow
                        approw = CmsDataSet1.Appointment.FindByidAppointment(app.Title.Substring(0, app.Title.IndexOf(" ")))
                        If approw.status = "B" Then
                            If MessageBox.Show("Delete " & app.Title & " appointment ?", "delete apoointment", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                                Dim medquery = From med In CmsDataSet1.MedicalHistory
                                               Where med.Appointment_id = app.Title.Substring(0, app.Title.IndexOf(" "))
                                               Select med.MedicalHistory_id

                                Dim medrow As CMSDataSet.MedicalHistoryRow
                                medrow = CmsDataSet1.MedicalHistory.FindByMedicalHistory_id(medquery.First)

                                Dim invoicerow As CMSDataSet.InvoiceRow
                                invoicerow = CmsDataSet1.Invoice.FindByAppointment_id(app.Title.Substring(0, app.Title.IndexOf(" ")))

                                invoicerow.Delete()
                                InvoiceTableAdapter.Update(CmsDataSet1.Invoice)

                                medrow.Delete()
                                MedicalHistoryTableAdapter.Update(CmsDataSet1.MedicalHistory)

                                approw.Delete()
                                AppointmentTableAdapter.Update(CmsDataSet1.Appointment)

                                appointments.Remove(app)
                                DayView1.Invalidate()
                            End If
                        Else
                            MsgBox("Appointment already in the queue.")
                        End If

                    End If
                Next
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub dayView1_ResolveAppointments(sender As Object, args As ResolveAppointmentsEventArgs) Handles DayView1.ResolveAppointments
        Dim x As New List(Of Appointment)
        For Each ap As Appointment In appointments
            If ap.StartDate >= args.StartDate And ap.StartDate <= args.EndDate Then
                x.Add(ap)
            End If
        Next
        args.Appointments = x
    End Sub
    'E:appointment tab

    'S:Queue tab
    'handles queue datagridview buttons click
    Private Sub QueueDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles QueueDataGridView.CellContentClick
        Dim utquery = From user In CmsDataSet1.User
                      Where user.idUser.ToUpper = UserNameLabel.Text
                      Select user.UserType

        If e.ColumnIndex = 8 Then
            If e.RowIndex >= 0 And utquery.First = "N" Then
                VitalSignsform.appid = QueueDataGridView.Item(0, e.RowIndex).Value.ToString
                VitalSignsform.NameTextBox.Text = QueueDataGridView.Item(2, e.RowIndex).Value.ToString
                VitalSignsform.IDTextBox.Text = QueueDataGridView.Item(1, e.RowIndex).Value.ToString
                VitalSignsform.Show()
            Else
                MsgBox("Only nurse is allowed to enter vital signs.")
            End If

        ElseIf e.ColumnIndex = 9
            If e.RowIndex >= 0 Then
                Dim adquery = From app In CmsDataSet1.Appointment
                              Where app.idAppointment = QueueDataGridView.Item(0, e.RowIndex).Value.ToString
                              Select app.User_idUser.ToUpper

                If QueueDataGridView.Item(e.ColumnIndex, e.RowIndex).Value = "Dignose" Then
                    If adquery.First = UserNameLabel.Text Then
                        DiagnoseForm.appid = QueueDataGridView.Rows(e.RowIndex).Cells(0).Value.ToString
                        DiagnoseForm.Show()
                    Else
                        MsgBox("only the assinged doctor can do the diagnose.")
                    End If
                Else
                    If utquery.First = "R" Then

                    End If
                End If
            End If
        Else
            If e.RowIndex >= 0 Then
                Patientform.IDtextbox.Text = QueueDataGridView.Item(1, e.RowIndex).Value
                Patientform.isnew = False
                Patientform.Show()
            End If

        End If
    End Sub
    'for emergency cases add appointment in nearest time found
    Private Sub ATWQbtn_Click(sender As Object, e As EventArgs) Handles ATWQbtn.Click
        If PatientSearchComboBox.SelectedIndex <> -1 And DoctorComboBox.SelectedIndex <> -1 Then
            Dim start As Date
            Dim endd As Date
            Dim added As Boolean = False
            If Now.Hour < My.Settings.StartTIme Then
                start = TimeRoundUp(Now.AddHours(My.Settings.StartTIme - Now.Hour))
            Else
                start = TimeRoundUp(Now)
            End If

            endd = start.AddMinutes(15)


            If My.Settings.WorkingDays.Contains(start.DayOfWeek.ToString) = False Or endd.Hour > My.Settings.EndTime Then
                MsgBox("We are outside Working Time")
            Else
                While endd.Hour <= My.Settings.EndTime
                    If Appointmentform.insertvalidation(DoctorComboBox.SelectedValue, PatientSearchComboBox.SelectedValue, start, endd) Then
                        selected = New Appointment
                        selected.StartDate = start
                        selected.EndDate = endd
                        Appointmentform.Show()
                        Appointmentform.PatientComboBox.SelectedIndex = PatientSearchComboBox.SelectedIndex
                        Appointmentform.DoctorComboBox.SelectedIndex = DoctorComboBox.SelectedIndex
                        Appointmentform.queued = True
                        Appointmentform.PatientComboBox.Enabled = False
                        Appointmentform.DoctorComboBox.Enabled = False
                        added = True
                        Exit Sub
                    End If
                    start = endd
                    endd = start.AddMinutes(15)
                End While
                If added = False Then
                    MsgBox("no chance in doctor schedule today")
                End If
            End If
        Else
            MsgBox("Select Patient and Doctor from the list")
        End If

        dgvrefresh()
    End Sub
    'round the time to [0,15,30,45]
    Private Function TimeRoundUp(Input As Date) As Date
        Return New Date(Input.Year, Input.Month, Input.Day, Input.Hour, Input.Minute, 0).AddMinutes(If(Input.Minute Mod 15 = 0, 0, 15 - Input.Minute Mod 15))
    End Function
    'function to insert today appointments in the queue and refresh it
    Public Sub dgvrefresh()
        QueueDataGridView.Rows.Clear()

        Dim QueueQuery = From app In CmsDataSet1.Appointment Join patient In CmsDataSet1.Patient On patient.idPatient Equals app.Patient_idPatient Join user In CmsDataSet1.User On user.idUser Equals app.User_idUser
                         Let uname = "Dr." & user.FirstName + " " + user.LastName
                         Let pname = patient.FirstName + " " + patient.LastName
                         Let age = System.DateTime.Now.Year - patient.BirthDate.Year
                         Where app.Start.Date = System.DateTime.Now.Date
                         Select app, patient, user, uname, pname, age



        Dim i As Integer = 0
        For Each result In QueueQuery
            If result.app.status = "C" Then

            Else
                With QueueDataGridView
                    .Rows.Add()
                    .Item(0, i).Value = result.app.idAppointment
                    .Item(1, i).Value = result.patient.idPatient
                    .Item(2, i).Value = result.pname
                    If result.patient.Gender = "M" Then
                        .Item(3, i).Value = "Male"
                    Else
                        .Item(3, i).Value = "Female"
                    End If
                    .Item(4, i).Value = result.age
                    .Item(5, i).Value = result.uname
                    .Item(6, i).Value = result.app.Start.ToShortTimeString
                    If result.app.status = "B" Then
                        .Item(7, i).Value = "Booked"
                        .Item(9, i).Value = "Dignose"
                    ElseIf result.app.status = "W"
                        .Item(7, i).Value = "Waiting"
                        .Item(9, i).Value = "Dignose"
                    ElseIf result.app.status = "D"
                        .Item(7, i).Value = "Done"
                        .Item(9, i).Value = "Payment"
                    End If
                    .Item(8, i).Value = "Vital Signs"

                End With
                i += 1

            End If
        Next
        'populate patients, doctors combo-boxes with informations
        Dim Patientlist = From Patient In CmsDataSet1.Patient
                          Let fullName = Patient.FirstName & " " & Patient.LastName
                          Select Patient.idPatient, fullName

        Dim doctorlist = From doctor In CmsDataSet1.User
                         Let fullname = doctor.FirstName & " " & doctor.LastName
                         Where doctor.UserType = "D"
                         Select doctor.idUser, fullname

        PatientSearchComboBox.DataSource = Patientlist.ToList
        PatientSearchComboBox.DisplayMember = "fullName"
        PatientSearchComboBox.ValueMember = "idPatient"
        PatientSearchComboBox.SelectedIndex = -1

        DoctorComboBox.DataSource = doctorlist.ToList
        DoctorComboBox.DisplayMember = "fullname"
        DoctorComboBox.ValueMember = "idUser"
        DoctorComboBox.SelectedIndex = -1
        DgWatingListRefresh()
    End Sub
    'to add new patient
    Private Sub NPBtn_Click(sender As Object, e As EventArgs) Handles NPBtn.Click
        Patientform.isnew = True
        Patientform.Show()

    End Sub
    'E:Queue tab

    'S:Diagnose tab
    'fill-in diagnose waiting list with patients
    'each doctor has his/her waiting list [Appointments assigned to him/her]
    Private Sub DgWatingListRefresh()
        DiagnoseDataGridView.Rows.Clear()

        Dim DgQuery = From app In CmsDataSet1.Appointment Join patient In CmsDataSet1.Patient On patient.idPatient Equals app.Patient_idPatient Join user In CmsDataSet1.User On user.idUser Equals app.User_idUser
                      Let pname = patient.FirstName + " " + patient.LastName
                      Let age = System.DateTime.Now.Year - patient.BirthDate.Year
                      Where app.Start.Date = System.DateTime.Now.Date And app.status = "W" And user.idUser.ToUpper = UserNameLabel.Text
                      Select app, patient, user, pname, age

        Dim i As Integer = 0
        For Each result In DgQuery

            With DiagnoseDataGridView
                .Rows.Add()
                .Item(0, i).Value = result.app.idAppointment
                .Item(1, i).Value = result.patient.idPatient
                .Item(2, i).Value = result.pname
                If result.patient.Gender = "M" Then
                    .Item(3, i).Value = "Male"
                Else
                    .Item(3, i).Value = "Female"
                End If
                .Item(4, i).Value = result.age
                .Item(5, i).Value = result.app.Start.ToShortTimeString
                .Item(6, i).Value = "Diagnose"
            End With
            i += 1

        Next

    End Sub
    'handles Diagnose button click .. open diagnose form to start the process of diagnose
    Private Sub DiagnoseDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DiagnoseDataGridView.CellContentClick
        If e.ColumnIndex = 6 Then
            If e.RowIndex >= 0 Then
                DiagnoseForm.appid = DiagnoseDataGridView.Rows(e.RowIndex).Cells(0).Value.ToString
                DiagnoseForm.Show()
            End If
        End If
    End Sub
    'E:Diagnose tab

    'S:Payment tab
    'fill-in payment DataGridView with list of done appointment to complete the payment process
    Private Sub PDGVrefesh()
        PaymentDGV.Rows.Clear()

        Dim utquery = From user In CmsDataSet1.User
                      Where user.idUser.ToUpper = UserNameLabel.Text
                      Select user.UserType

        If utquery.First = "R" Then
            Dim pQuery = From app In CmsDataSet1.Appointment Join patient In CmsDataSet1.Patient On patient.idPatient Equals app.Patient_idPatient Join user In CmsDataSet1.User On user.idUser Equals app.User_idUser
                         Let pname = patient.FirstName + " " + patient.LastName
                         Let age = System.DateTime.Now.Year - patient.BirthDate.Year
                         Where app.status = "D"
                         Select app, patient, user, pname, age

            Dim i As Integer = 0
            For Each result In pQuery
                With PaymentDGV
                    .Rows.Add()
                    .Item(0, i).Value = result.app.idAppointment
                    .Item(1, i).Value = result.patient.idPatient
                    .Item(2, i).Value = result.pname
                    If result.patient.Gender = "M" Then
                        .Item(3, i).Value = "Male"
                    Else
                        .Item(3, i).Value = "Female"
                    End If
                    .Item(4, i).Value = result.age
                    .Item(5, i).Value = "Payment"
                End With
                i += 1
            Next
        End If
    End Sub
    'handele payment button click to start payment process of specific patient
    Private Sub PaymentDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PaymentDGV.CellContentClick
        If e.ColumnIndex = 5 And e.RowIndex >= 0 Then

            Dim appquery = From app In CmsDataSet1.Appointment Join invoice In CmsDataSet1.Invoice On app.idAppointment Equals invoice.Appointment_id Join patient In CmsDataSet1.Patient On app.Patient_idPatient Equals patient.idPatient
                           Let pname = patient.FirstName + " " + patient.LastName
                           Where app.idAppointment = PaymentDGV.Item(0, e.RowIndex).Value.ToString
                           Select app, invoice, pname

            appidtxtbox.Text = appquery.First.app.idAppointment
            patientidtxtbox.Text = appquery.First.app.Patient_idPatient
            patientnametxtbox.Text = appquery.First.pname
            appdatetxtbox.Text = appquery.First.app.Start.ToShortDateString
            If appquery.First.app.Type = "F" Then
                apptypetxtbox.Text = "First time visit"
            Else
                apptypetxtbox.Text = "Follow-up visit"
            End If
            apptotaltxtbox.Text = appquery.First.invoice.Total & " JOD"

            cashrb.Checked = True
            Paybtn.Enabled = True



        End If
    End Sub
    'handles insurance radiobuton checked changed .. when the user selects the payment method [insurance] insurance number textbox is enabled
    Private Sub insurancerb_CheckedChanged(sender As Object, e As EventArgs) Handles insurancerb.CheckedChanged
        If insurancerb.Checked = True Then
            insuranceidtxtbox.Enabled = True
        Else
            insuranceidtxtbox.Enabled = False
        End If
    End Sub
    'handles pay button click.complete the payment process and update database with payment information and print invoice and prescription
    Private Sub Paybtn_Click(sender As Object, e As EventArgs) Handles Paybtn.Click
        If insurancerb.Checked = True And insuranceidtxtbox.Text = "" Then
            MsgBox("please enter insurance number.")
        Else
            Dim invoicerow As CMSDataSet.InvoiceRow
            invoicerow = CmsDataSet1.Invoice.FindByAppointment_id(appidtxtbox.Text)
            If cashrb.Checked = True Then
                invoicerow.Payment_Method = "C"
                insuranceidtxtbox.Text = ""
            Else
                invoicerow.Payment_Method = "I"
            End If
            If insuranceidtxtbox.Text <> "" Then
                invoicerow.insurance_id = insuranceidtxtbox.Text
            End If

            Dim approw As CMSDataSet.AppointmentRow
            approw = CmsDataSet1.Appointment.FindByidAppointment(appidtxtbox.Text)
            approw.status = "C"

            InvoiceTableAdapter.Update(CmsDataSet1.Invoice)
            AppointmentTableAdapter.Update(CmsDataSet1.Appointment)

            If MessageBox.Show("whould you like to print invoice ?", "Payment Confirmed", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If File.Exists("c:\cms\invoice_" & appidtxtbox.Text & ".html") = False Then
                    generateinvoice()
                End If
                'print out prescription
                Dim prequery = From medicine In CmsDataSet1.Prescription Join med In CmsDataSet1.Medicine On medicine.Medicine_id Equals med.idMedicine
                               Where medicine.MedicalHistory_id = appidtxtbox.Text
                               Select med, medicine

                If prequery.Count > 0 Then
                    Dim doc = From app In CmsDataSet1.Appointment Join user In CmsDataSet1.User On app.User_idUser Equals user.idUser
                              Let uname = user.FirstName + " " + user.LastName
                              Where app.idAppointment = appidtxtbox.Text
                              Select uname

                    Dim sw As StreamWriter = New StreamWriter("c:\cms\prescription_" & appidtxtbox.Text & ".html", True)
                    Dim str As String = My.Resources.Prescription
                    str = str.Replace("clinic_name", My.Settings.ClinicName)
                    str = str.Replace("pname", patientnametxtbox.Text)
                    str = str.Replace("pdate", appdatetxtbox.Text)
                    str = str.Replace("pid", patientidtxtbox.Text)
                    str = str.Replace("doc_name", doc.First)
                    str = str.Replace("app_id", appidtxtbox.Text)

                    Dim added As String = ""
                    Dim i As Integer = 1
                    For Each result In prequery
                        Dim row As String = My.Resources.prerow
                        row = row.Replace("mednum", i)
                        row = row.Replace("medname", result.med.Name)
                        row = row.Replace("meddesc", result.med.Description)
                        row = row.Replace("medintake", result.medicine.Med_Intake)
                        row = row.Replace("midfreq", result.medicine.Med_Freq)
                        row = row.Replace("meddur", result.medicine.Med_Duration)
                        i += 1
                        added += row
                    Next
                    str = str.Replace("prerows", added)

                    sw.Write(str)
                    sw.Close()
                End If


                Process.Start("c:\cms\invoice_" & appidtxtbox.Text & ".html")
                Process.Start("c:\cms\prescription_" & appidtxtbox.Text & ".html")
            End If


        End If


    End Sub
    'fill-in invoice page with appointment payment information
    Private Sub generateinvoice()
        Dim sw As StreamWriter = New StreamWriter("c:\cms\invoice_" & appidtxtbox.Text & ".html", True)
        Dim str As String = My.Resources.Invoice
        str = str.Replace("clinic_name", My.Settings.ClinicName)
        str = str.Replace("app_id", appidtxtbox.Text)
        str = str.Replace("p_day", Now.ToShortDateString)
        If cashrb.Checked = True Then
            str = str.Replace("p_m", "Cash")
        Else
            str = str.Replace("p_m", "Insurance: " & insuranceidtxtbox.Text)
        End If

        str = str.Replace("app_date", appdatetxtbox.Text)
        str = str.Replace("app_info", patientnametxtbox.Text & " - " & apptypetxtbox.Text)
        str = str.Replace("app_fee", apptotaltxtbox.Text)
        str = str.Replace("app_total", apptotaltxtbox.Text)

        Dim uquery = From user In CmsDataSet1.User
                     Let uname = user.FirstName + " " + user.LastName
                     Where user.idUser.ToUpper = UserNameLabel.Text
                     Select uname

        str = str.Replace("rec_name", uquery.First)

        sw.Write(str)
        sw.Close()
    End Sub
    'E:Payment tab

    'S:Reports tab
    'do some actions when tabs opened or closed
    Private Sub ReportsTabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ReportsTabControl.SelectedIndexChanged
        If ReportsTabControl.SelectedTab.Name = "PatientLTab" Then
            PdgvRefresh()
        ElseIf ReportsTabControl.SelectedTab.Name = "digHTab"
            DgRepsDataGridView.Rows.Clear()
            Dim Doctorlist = From User In CmsDataSet1.User
                             Where User.UserType = "D"
                             Let fullName = User.FirstName & " " & User.LastName
                             Select fullName, User.idUser
            'populate the doctor combo box
            DoctComboBox.DataSource = Doctorlist.ToList
            DoctComboBox.DisplayMember = "fullName"
            DoctComboBox.ValueMember = "idUser"

            'query to get patients list
            Dim Patientlist = From Patient In CmsDataSet1.Patient
                              Let fullName = Patient.FirstName & " " & Patient.LastName
                              Select Patient.idPatient, fullName

            'populate the patient combo box
            PatComboBox.DataSource = Patientlist.ToList
            PatComboBox.DisplayMember = "fullName"
            PatComboBox.ValueMember = "idPatient"
            'to make sure comboboxes selects nothing in the start
            PatComboBox.SelectedIndex = -1
            DoctComboBox.SelectedIndex = -1
        ElseIf ReportsTabControl.SelectedTab.Name = "patientRTab"
            PatientReportDGV.Rows.Clear()
            'query to get patients list
            Dim Patientlist = From Patient In CmsDataSet1.Patient
                              Let fullName = Patient.FirstName & " " & Patient.LastName
                              Select Patient.idPatient, fullName

            patRcombobox.DataSource = Patientlist.ToList
            patRcombobox.DisplayMember = "fullName"
            patRcombobox.ValueMember = "idPatient"
            'to make sure comboboxes selects nothing in the start
            patRcombobox.SelectedIndex = -1

        End If

    End Sub

    'S:Reports tab:Patient list tab
    'export patients list to excel sheet
    Private Sub export_Click(sender As Object, e As EventArgs) Handles exportbtn.Click
        If ((PatientsDGV.Columns.Count = 0) Or (PatientsDGV.Rows.Count = 0)) Then
            Exit Sub
        End If

        'Creating dataset to export
        Dim dset As New DataSet
        'add table to dataset
        dset.Tables.Add()
        'add column to that table
        For i As Integer = 0 To PatientsDGV.ColumnCount - 1
            dset.Tables(0).Columns.Add(PatientsDGV.Columns(i).HeaderText)
        Next
        'add rows to the table
        Dim dr1 As DataRow
        For i As Integer = 0 To PatientsDGV.RowCount - 1
            dr1 = dset.Tables(0).NewRow
            For j As Integer = 0 To PatientsDGV.Columns.Count - 1
                dr1(j) = PatientsDGV.Rows(i).Cells(j).Value
            Next
            dset.Tables(0).Rows.Add(dr1)
        Next

        Dim excel As New Microsoft.Office.Interop.Excel.Application
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        Dim dt As System.Data.DataTable = dset.Tables(0)
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        For Each dc In dt.Columns
            colIndex = colIndex + 1
            excel.Cells(1, colIndex) = dc.ColumnName
        Next

        For Each dr In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)

            Next
        Next
        wSheet.Columns.AutoFit()
        Dim strFileName As String = "C:\cms\Patients_List" & Now.ToString("yyyy-MM-dd hh-mm-ss") & ".xls"
        Dim blnFileOpen As Boolean = False
        Try
            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
            fileTemp.Close()
        Catch ex As Exception
            blnFileOpen = False
        End Try

        If System.IO.File.Exists(strFileName) Then
            System.IO.File.Delete(strFileName)
        End If

        wBook.SaveAs(strFileName)
        excel.Workbooks.Open(strFileName)
        excel.Visible = True
    End Sub
    'fill-in patients list DataGridView with all patients
    Private Sub PdgvRefresh()
        PatientsDGV.Rows.Clear()

        Dim query = From patient In CmsDataSet1.Patient
                    Let pname = patient.FirstName + " " + patient.LastName
                    Let Age = Now.Year - patient.BirthDate.Year
                    Let Gender = If(patient.Gender = "M", "Male", "Female")
                    Select patient, pname, Age, Gender

        Dim i As Integer = 0
        For Each result In query
            PatientsDGV.Rows.Add()
            PatientsDGV.Item(0, i).Value = result.pname
            PatientsDGV.Item(1, i).Value = result.patient.idPatient
            PatientsDGV.Item(2, i).Value = result.patient.BirthDate.ToShortDateString
            PatientsDGV.Item(3, i).Value = result.Age
            PatientsDGV.Item(4, i).Value = result.Gender
            PatientsDGV.Item(5, i).Value = result.patient.Phone
            PatientsDGV.Item(6, i).Value = result.patient.Address
            PatientsDGV.Item(7, i).Value = result.patient.BloodType
            i += 1
        Next
    End Sub

    'reset filters and show the list of all patients
    Private Sub ShowAllbtn_Click(sender As Object, e As EventArgs) Handles ShowAllbtn.Click
        keywordtxtbox.Text = ""
        minagetxtbox.Text = ""
        maxagetxtbox.Text = ""
        GenderCB.SelectedIndex = -1
        BTCB.SelectedIndex = -1
        PdgvRefresh()
    End Sub
    'using filters to customize patients list [ex:male patients, child patients .. etc]
    Private Sub Filterbtn_Click(sender As Object, e As EventArgs) Handles Filterbtn.Click
        Dim keyword As String = ""
        Dim minage As Integer = 0
        Dim maxage As Integer = 0
        Dim gen As String = ""
        Dim bt As String = ""

        Dim todelete As New ArrayList()
        keyword = keywordtxtbox.Text
        Try
            minage = minagetxtbox.Text
        Catch ex As Exception

        End Try
        Try
            maxage = maxagetxtbox.Text
        Catch ex As Exception

        End Try

        gen = GenderCB.SelectedItem

        bt = BTCB.SelectedItem

        If maxage > 0 And maxage < minage Then
            MsgBox("Max age must be greater than min age.")
            Exit Sub
        End If

        If keyword <> "" Then
            For i As Integer = 0 To PatientsDGV.RowCount - 1
                If PatientsDGV.Item(0, i).Value.ToString.Contains(keyword) = False Then
                    todelete.Add(i)
                End If
            Next
        End If
        If minage > 0 Then
            For i As Integer = 0 To PatientsDGV.RowCount - 1
                If PatientsDGV.Item(3, i).Value < minage Then
                    todelete.Add(i)
                End If
            Next
        End If
        If maxage > 0 Then
            For i As Integer = 0 To PatientsDGV.RowCount - 1
                If PatientsDGV.Item(3, i).Value > maxage Then
                    todelete.Add(i)
                End If
            Next
        End If
        If gen <> "" Then
            For i As Integer = 0 To PatientsDGV.RowCount - 1
                If PatientsDGV.Item(4, i).Value.ToString.Contains(gen) = False Then
                    todelete.Add(i)
                End If
            Next
        End If
        If bt <> "" Then
            For i As Integer = 0 To PatientsDGV.RowCount - 1
                If PatientsDGV.Item(7, i).Value.ToString.Contains(bt) = False Then
                    todelete.Add(i)
                End If
            Next
        End If
        Dim j As Integer = 0
        todelete.Sort()
        For Each obj In todelete
            PatientsDGV.Rows.RemoveAt(obj - j)
            j += 1
        Next obj
    End Sub
    'keypress validation for numerical textboxes
    Private Sub numericaltxtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles maxagetxtbox.KeyPress, minagetxtbox.KeyPress, appidsebox.KeyPress

        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then
                MessageBox.Show("Please enter numbers only")
                e.Handled = True
            End If
        End If
    End Sub
    'E:Reports tab:Patient list tab

    'S:Reports tab:Diagnose history tab
    'fill-in diagnose history reports DataGridView with specific patient history
    Private Sub DgRepsDGVRefresh()
        DgRepsDataGridView.Rows.Clear()

        Dim dgrpquery = From med In CmsDataSet1.MedicalHistory Join patient In CmsDataSet1.Patient On med.Patient_id Equals patient.idPatient Join app In CmsDataSet1.Appointment On med.Appointment_id Equals app.idAppointment Join doc In CmsDataSet1.User On doc.idUser Equals app.User_idUser
                        Let dname = doc.FirstName + " " + doc.LastName
                        Where app.status = "C" And patient.idPatient = PatComboBox.SelectedValue
                        Select patient, doc, med, app, dname

        If DoctComboBox.SelectedIndex <> -1 Then
            dgrpquery = dgrpquery.Where(Function(a) a.doc.idUser = DoctComboBox.SelectedValue)
        End If

        Dim i As Integer = 0
        For Each result In dgrpquery
            DgRepsDataGridView.Rows.Add()
            DgRepsDataGridView.Item(0, i).Value = result.app.idAppointment
            DgRepsDataGridView.Item(1, i).Value = result.app.Start
            DgRepsDataGridView.Item(2, i).Value = result.med.Diagnose
            DgRepsDataGridView.Item(3, i).Value = result.dname



        Next

    End Sub
    'handles search button click.
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchDgHisBtn.Click
        If PatComboBox.SelectedIndex <> -1 Then
            DgRepsDGVRefresh()
        Else
            MsgBox("Please select patient.")
        End If
    End Sub
    'handles genertate button click.when user click diagnose report is generated
    Private Sub DgRepsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgRepsDataGridView.CellContentClick
        If e.ColumnIndex = 4 And e.RowIndex >= 0 Then
            generateDGHis(DgRepsDataGridView.Item(0, e.RowIndex).Value)
        End If

    End Sub
    'fill-in diagnose history report with patient and appointment information
    Public Sub generateDGHis(MedhisId As Integer)
        If File.Exists("c:\cms\Diagnose_Report_" & MedhisId & ".html") = False Then
            Dim genQuery = From med In CmsDataSet1.MedicalHistory Join app In CmsDataSet1.Appointment On med.Appointment_id Equals app.idAppointment Join doc In CmsDataSet1.User On doc.idUser Equals app.User_idUser Join patient In CmsDataSet1.Patient On app.Patient_idPatient Equals patient.idPatient
                           Let pname = patient.FirstName + " " + patient.LastName
                           Let dname = doc.FirstName + " " + doc.LastName
                           Let apptype = If(app.Type = "F", "First Time visit", "Follow-up visit")
                           Where med.MedicalHistory_id = MedhisId
                           Select app, med, dname, pname, patient, doc, apptype

            Dim sw As StreamWriter = New StreamWriter("c:\cms\Diagnose_Report_" & MedhisId & ".html", True)
            Dim str As String = My.Resources.Digreport
            str = str.Replace("clinic_name", My.Settings.ClinicName)
            str = str.Replace("pname", genQuery.First.pname)
            str = str.Replace("pdate", genQuery.First.app.Start.Date)
            str = str.Replace("pid", genQuery.First.patient.idPatient)
            str = str.Replace("doc_name", genQuery.First.dname)
            str = str.Replace("app_id", genQuery.First.app.idAppointment)
            str = str.Replace("app_type", genQuery.First.apptype)
            Try
                str = str.Replace("temp", genQuery.First.med.Tempreture)
            Catch ex As Exception
                str = str.Replace("temp", "")
            End Try
            Try
                str = str.Replace("bp", genQuery.First.med.BloodPressure)
            Catch ex As Exception
                str = str.Replace("bp", "")
            End Try
            Try
                str = str.Replace("hr", genQuery.First.med.HeartRate)
            Catch ex As Exception
                str = str.Replace("hr", "")
            End Try
            Try
                str = str.Replace("rr", genQuery.First.med.respiratoryRate)
            Catch ex As Exception
                str = str.Replace("rr", "")
            End Try
            Try
                If genQuery.First.med.TobaccoUse = 1 Then
                    str = str.Replace("tub", "Yes")
                Else
                    str = str.Replace("tub", "No")
                End If
            Catch ex As Exception
                str = str.Replace("tub", "")
            End Try
            Try
                str = str.Replace("psymp", genQuery.First.med.Symptoms)
            Catch ex As Exception
                str = str.Replace("psymp", "")
            End Try

            str = str.Replace("pdiag", genQuery.First.med.Diagnose)

            Try
                str = str.Replace("premarks", genQuery.First.med.remarks)
            Catch ex As Exception
                str = str.Replace("premarks", "")
            End Try


            sw.Write(str)
            sw.Close()
            Process.Start("c:\cms\Diagnose_Report_" & MedhisId & ".html")
        Else
            Process.Start("c:\cms\Diagnose_Report_" & MedhisId & ".html")
        End If


    End Sub
    'E:Reports tab:Diagnose history tab

    'S:Reports tab:Patient reports tab
    'fill-in patient reports DataGridView with specific patient history
    Private Sub PatientReportDGVRefresh()
        PatientReportDGV.Rows.Clear()
        Dim PRquery = From med In CmsDataSet1.MedicalHistory Join patient In CmsDataSet1.Patient On med.Patient_id Equals patient.idPatient Join app In CmsDataSet1.Appointment On med.Appointment_id Equals app.idAppointment Join doc In CmsDataSet1.User On doc.idUser Equals app.User_idUser Join Repts In CmsDataSet1.Reports On Repts.MedicalHistory_id Equals med.MedicalHistory_id
                      Let dname = doc.FirstName + " " + doc.LastName
                      Let pname = patient.FirstName + " " + patient.LastName
                      Select patient, doc, med, app, dname, pname, Repts

        If appidsebox.Text <> "" Then
            PRquery = PRquery.Where(Function(a) a.app.idAppointment = appidsebox.Text)
        Else
            PRquery = PRquery.Where(Function(a) a.patient.idPatient = patRcombobox.SelectedValue)
        End If

        Dim i As Integer = 0
        For Each result In PRquery
            PatientReportDGV.Rows.Add()
            PatientReportDGV.Item(0, i).Value = result.med.MedicalHistory_id
            PatientReportDGV.Item(1, i).Value = result.Repts.DocumentID
            PatientReportDGV.Item(2, i).Value = result.app.Start
            PatientReportDGV.Item(3, i).Value = result.Repts.DocumentType + " " + result.Repts.DocumentSubType
            PatientReportDGV.Item(4, i).Value = result.pname
            PatientReportDGV.Item(5, i).Value = result.dname
            Try
                'if attachemnt is uploaded .. change button text to show
                If result.Repts.Attachment <> "" Then
                    PatientReportDGV.Item(7, i).Value = "Show"
                Else
                    PatientReportDGV.Item(7, i).Value = "Upload"
                End If
            Catch ex As Exception
                PatientReportDGV.Item(7, i).Value = "Upload"
            End Try
            i += 1
        Next



    End Sub
    'handles search button click.perform search using patient ID or appointment ID
    Private Sub searchPatienRepBtn_Click(sender As Object, e As EventArgs) Handles searchPatienRepBtn.Click
        If patRcombobox.SelectedIndex <> -1 Or appidsebox.Text <> "" Then
            PatientReportDGVRefresh()
        Else
            MsgBox("Please select patient or appointment id")
        End If
    End Sub

    Private Sub PatientReportDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientReportDGV.CellContentClick
        'generate report request
        If e.ColumnIndex = 6 And e.RowIndex >= 0 Then
            If File.Exists("c:\cms\Report_Request_" & PatientReportDGV.Item(0, e.RowIndex).Value & ".html") = False Then
                Dim PRquery = From med In CmsDataSet1.MedicalHistory Join patient In CmsDataSet1.Patient On med.Patient_id Equals patient.idPatient Join app In CmsDataSet1.Appointment On med.Appointment_id Equals app.idAppointment Join doc In CmsDataSet1.User On doc.idUser Equals app.User_idUser Join Repts In CmsDataSet1.Reports On Repts.MedicalHistory_id Equals med.MedicalHistory_id
                              Let dname = doc.FirstName + " " + doc.LastName
                              Let pname = patient.FirstName + " " + patient.LastName
                              Where Repts.DocumentID = PatientReportDGV.Item(1, e.RowIndex).Value
                              Select patient.idPatient, app, dname, pname, Repts

                Dim sw As StreamWriter = New StreamWriter("c:\cms\Report_Request_" & PatientReportDGV.Item(1, e.RowIndex).Value & ".html", True)
                Dim str As String = My.Resources.Pr
                str = str.Replace("clinic_name", My.Settings.ClinicName)
                str = str.Replace("app_id", PRquery.First.app.idAppointment)
                str = str.Replace("pname", PRquery.First.pname)
                str = str.Replace("pdate", PRquery.First.app.Start.Date)
                str = str.Replace("pid", PRquery.First.idPatient)
                str = str.Replace("doc_name", "Dr. " & PRquery.First.dname)
                If PRquery.First.Repts.DocumentType = "X-Ray" Or PRquery.First.Repts.DocumentType = "CT" Or PRquery.First.Repts.DocumentType = "MRI" Then
                    str = str.Replace("rtype", PRquery.First.Repts.DocumentType & " scan of " & PRquery.First.Repts.DocumentSubType)
                Else
                    str = str.Replace("rtype", PRquery.First.Repts.DocumentSubType & " Test")
                End If

                sw.Write(str)
                sw.Close()
                Process.Start("c:\cms\Report_Request_" & PatientReportDGV.Item(1, e.RowIndex).Value & ".html")
            Else
                Process.Start("c:\cms\Report_Request_" & PatientReportDGV.Item(1, e.RowIndex).Value & ".html")
            End If
            'upload report results
        ElseIf e.ColumnIndex = 7 And e.RowIndex >= 0
            If PatientReportDGV.Item(7, e.RowIndex).Value = "Upload" Then
                Dim fd As OpenFileDialog = New OpenFileDialog()
                Dim strFileName As String
                fd.Title = "Open File Dialog"
                fd.InitialDirectory = "C:\"
                fd.RestoreDirectory = True

                If fd.ShowDialog() = DialogResult.OK Then
                    strFileName = fd.FileName
                    File.Copy(strFileName, "c:\cms\report_" & PatientReportDGV.Item(1, e.RowIndex).Value & strFileName.Substring(strFileName.IndexOfAny(".")))
                    Dim reportrow As CMSDataSet.ReportsRow
                    reportrow = CmsDataSet1.Reports.FindByDocumentID(PatientReportDGV.Item(1, e.RowIndex).Value)
                    reportrow.Attachment = "c:\cms\report_" & PatientReportDGV.Item(1, e.RowIndex).Value & strFileName.Substring(strFileName.IndexOfAny("."))
                    ReportsTableAdapter.Update(CmsDataSet1.Reports)
                    PatientReportDGVRefresh()
                End If
            ElseIf PatientReportDGV.Item(7, e.RowIndex).Value = "Show"
                Dim rpquery = From report In CmsDataSet1.Reports
                              Where report.DocumentID = PatientReportDGV.Item(1, e.RowIndex).Value
                              Select report.Attachment
                Try
                    Process.Start(rpquery.First.ToString)
                Catch ex As Exception

                End Try

            End If
        End If

    End Sub
    'E:Reports tab:Patient reports tab
    'E:Reports tab
End Class