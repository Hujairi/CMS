Imports Calendar
Public Class Appointmentform
    Public app As Appointment
    Dim appointmentid As Integer
    Public queued As Boolean = False
    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get the data of the selected appointment from dayview calendar
        app = Main.selected

        'comboboxes are populated with data from database 
        'query to get doctors list
        Dim Doctorlist = From User In Main.CmsDataSet1.User
                         Where User.UserType = "D"
                         Let fullName = User.FirstName & " " & User.LastName
                         Select fullName, User.idUser
        'populate the doctor combo box
        DoctorComboBox.DataSource = Doctorlist.ToList
        DoctorComboBox.DisplayMember = "fullName"
        DoctorComboBox.ValueMember = "idUser"

        'query to get patients list
        Dim Patientlist = From Patient In Main.CmsDataSet1.Patient
                          Let fullName = Patient.FirstName & " " & Patient.LastName
                          Select Patient.idPatient, fullName

        'populate the patient combo box
        PatientComboBox.DataSource = Patientlist.ToList
        PatientComboBox.DisplayMember = "fullName"
        PatientComboBox.ValueMember = "idPatient"
        'to make sure comboboxes selects nothing in the start
        PatientComboBox.SelectedIndex = -1
        DoctorComboBox.SelectedIndex = -1



        'appointment date and time
        DateLabel.Text += app.StartDate.ToShortDateString
        StartLabel.Text += app.StartDate.TimeOfDay.ToString
        EndLabel.Text += app.EndDate.TimeOfDay.ToString

        'set the default appointment type (first time)
        FT.Checked = True


    End Sub

    'cancel the process of adding appointment
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    'adding appointment To database
    Private Sub addAppointment()
        'create appointment row for new appointment and fill in the information
        Dim newAppointmentRow As CMSDataSet.AppointmentRow
        newAppointmentRow = Main.CmsDataSet1.Appointment.NewAppointmentRow
        newAppointmentRow.Patient_idPatient = PatientComboBox.SelectedValue
        newAppointmentRow.User_idUser = DoctorComboBox.SelectedValue
        newAppointmentRow.Start = app.StartDate
        newAppointmentRow._End = app.EndDate
        If queued = False Then
            newAppointmentRow.status = "B"
        Else
            newAppointmentRow.status = "W"
        End If

        If FT.Checked = True Then
            newAppointmentRow.Type = "F"
        Else
            newAppointmentRow.Type = "U"
        End If
        newAppointmentRow.idAppointment = appointmentid

        Dim medquery = From row In Main.CmsDataSet1.MedicalHistory
                       Select row.MedicalHistory_id

        Dim newmedrow As CMSDataSet.MedicalHistoryRow
        newmedrow = Main.CmsDataSet1.MedicalHistory.NewMedicalHistoryRow
        newmedrow.MedicalHistory_id = medquery.LastOrDefault + 1
        newmedrow.Patient_id = PatientComboBox.SelectedValue
        newmedrow.Appointment_id = appointmentid

        Dim newinvoicerow As CMSDataSet.InvoiceRow
        newinvoicerow = Main.CmsDataSet1.Invoice.NewInvoiceRow
        newinvoicerow.Appointment_id = appointmentid
        If FT.Checked = True Then
            newinvoicerow.Total = My.Settings.FTfees
        Else
            newinvoicerow.Total = My.Settings.FUfees
        End If



        Main.CmsDataSet1.Appointment.Rows.Add(newAppointmentRow)
        Main.AppointmentTableAdapter.Update(Main.CmsDataSet1.Appointment)

        Main.CmsDataSet1.MedicalHistory.Rows.Add(newmedrow)
        Main.MedicalHistoryTableAdapter.Update(Main.CmsDataSet1.MedicalHistory)

        Main.CmsDataSet1.Invoice.Rows.Add(newinvoicerow)
        Main.InvoiceTableAdapter.Update(Main.CmsDataSet1.Invoice)

    End Sub

    'adding appointment to dayview appointment and add it to the database
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        If PatientComboBox.SelectedIndex >= 0 And DoctorComboBox.SelectedIndex >= 0 Then
            'get the last appointment id , then increase by 1
            Dim query = From Appointment In Main.CmsDataSet1.Appointment
                        Select Appointment.idAppointment

            appointmentid = query.LastOrDefault + 1
            'set the information of the appointment [patient , doctor]
            app.Title = CStr(appointmentid) + " - Patient: " + PatientComboBox.GetItemText(PatientComboBox.SelectedItem) + vbCrLf + "Doctor: " + DoctorComboBox.GetItemText(DoctorComboBox.SelectedItem)
            app.Locked = True
            'check first if the appointment can be added to the list and then add it to the appointment list
            If (insertvalidation(DoctorComboBox.SelectedValue, PatientComboBox.SelectedValue, app.StartDate, app.EndDate)) Then
                addAppointment()
                Main.addNewAppointment(app)
                Main.dgvrefresh()
            End If

            Me.Close()
        Else
            MsgBox("please select patient and doctor.")
        End If



    End Sub

    'validate appointment before inserting into database
    Public Function insertvalidation(DoctorID As String, PatientID As Integer, StartD As Date, EndD As Date) As Boolean
        'query to find any conflit between appointments
        Dim query = From appointment In Main.CmsDataSet1.Appointment
                    Where (StartD >= appointment.Start And StartD < appointment._End) Or (EndD > appointment.Start And EndD <= appointment._End)
                    Select appointment
        'if there is conflict in time check if there is conflit in patient and doctor (patient can't have 2 appointments at the same time,Doctors also..)
        For Each appointment In query
            If appointment.User_idUser = DoctorID Then
                Return False
            ElseIf appointment.Patient_idPatient = PatientID
                Return False
            Else
                Return True

            End If
        Next
        Return True

    End Function

    'add new patient to the system [show the patient form]
    Private Sub NPBtn_Click(sender As Object, e As EventArgs) Handles NPBtn.Click
        Patientform.Show()
        Patientform.Fromapp = True
    End Sub

End Class