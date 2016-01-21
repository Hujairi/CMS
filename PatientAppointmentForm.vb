Public Class PatientAppointmentForm


    'setup patinet appointment form
    Private Sub PatientAppointmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.UserTableAdapter.Fill(Main.CmsDataSet1.User)
        Main.PatientTableAdapter.Fill(Main.CmsDataSet1.Patient)
        Main.MedicalHistoryTableAdapter.Fill(Main.CmsDataSet1.MedicalHistory)
        Main.InvoiceTableAdapter.Fill(Main.CmsDataSet1.Invoice)
        Main.AppointmentTableAdapter.Fill(Main.CmsDataSet1.Appointment)

        Dim pquery = From patient In Main.CmsDataSet1.Patient
                     Let pname = patient.FirstName + " " + patient.LastName
                     Where patient.idPatient = Login.getUserID
                     Select patient, pname

        PatientName.Text = pquery.First.pname
        PatientID.Text = pquery.First.patient.idPatient

        HourNUP.Minimum = My.Settings.StartTIme
        HourNUP.Maximum = My.Settings.EndTime - 1
        AppDTP.MinDate = Now.Date


        Dim dqurey = From doctor In Main.CmsDataSet1.User
                     Let dname = "Dr. " + doctor.FirstName + " " + doctor.LastName
                     Where doctor.UserType = "D"
                     Select doctor.idUser, dname

        DoctorsCB.DataSource = dqurey.ToArray
        DoctorsCB.DisplayMember = "dname"
        DoctorsCB.ValueMember = "idUser"




    End Sub
    'handles schedule button click.Add appointment after validation
    Private Sub Schedulebtn_Click(sender As Object, e As EventArgs) Handles Schedulebtn.Click
        If AppDTP.Value.Date.AddHours(HourNUP.Value).AddMinutes(MinNUP.Value) < Now Then
            If Appointmentform.insertvalidation(DoctorsCB.SelectedValue, PatientID.Text, AppDTP.Value.Date.AddHours(HourNUP.Value).AddMinutes(MinNUP.Value), AppDTP.Value.Date.AddHours(HourNUP.Value).AddMinutes(MinNUP.Value + 15)) Then
                addAppointment()
            Else
                MsgBox("please choose another time or doctor.")
            End If
        Else
            MsgBox("Appointment can't be in the past.")
        End If

    End Sub
    'insert appointment information into database
    Private Sub addAppointment()
        Dim appquery = From Appointment In Main.CmsDataSet1.Appointment
                       Select Appointment.idAppointment



        'create appointment row for new appointment and fill in the information
        Dim newAppointmentRow As CMSDataSet.AppointmentRow
        newAppointmentRow = Main.CmsDataSet1.Appointment.NewAppointmentRow
        newAppointmentRow.Patient_idPatient = PatientID.Text
        newAppointmentRow.User_idUser = DoctorsCB.SelectedValue
        newAppointmentRow.Start = AppDTP.Value.Date.AddHours(HourNUP.Value).AddMinutes(MinNUP.Value)
        newAppointmentRow._End = AppDTP.Value.Date.AddHours(HourNUP.Value).AddMinutes(MinNUP.Value + 15)
        newAppointmentRow.status = "B"
        newAppointmentRow.Type = "F"
        newAppointmentRow.idAppointment = appquery.LastOrDefault + 1

        Dim medquery = From row In Main.CmsDataSet1.MedicalHistory
                       Select row.MedicalHistory_id

        Dim newmedrow As CMSDataSet.MedicalHistoryRow
        newmedrow = Main.CmsDataSet1.MedicalHistory.NewMedicalHistoryRow
        newmedrow.MedicalHistory_id = medquery.LastOrDefault + 1
        newmedrow.Patient_id = PatientID.Text
        newmedrow.Appointment_id = appquery.LastOrDefault + 1

        Dim newinvoicerow As CMSDataSet.InvoiceRow
        newinvoicerow = Main.CmsDataSet1.Invoice.NewInvoiceRow
        newinvoicerow.Appointment_id = appquery.LastOrDefault + 1
        newinvoicerow.Total = My.Settings.FTfees


        Main.CmsDataSet1.Appointment.Rows.Add(newAppointmentRow)
        Main.AppointmentTableAdapter.Update(Main.CmsDataSet1.Appointment)

        Main.CmsDataSet1.MedicalHistory.Rows.Add(newmedrow)
        Main.MedicalHistoryTableAdapter.Update(Main.CmsDataSet1.MedicalHistory)

        Main.CmsDataSet1.Invoice.Rows.Add(newinvoicerow)
        Main.InvoiceTableAdapter.Update(Main.CmsDataSet1.Invoice)

    End Sub
End Class