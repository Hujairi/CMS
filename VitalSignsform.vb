Public Class VitalSignsform
    Public appid As Integer
    Dim MedId As Integer
    Dim flag As Boolean = True

    Private Sub VitalSignsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get the vital signs information if alreday existed from the database,so user can edit/update them
        Dim medquery = From row In Main.CmsDataSet1.MedicalHistory
                       Where row.Appointment_id = appid
                       Select row

        If medquery.Count > 0 Then
            Try
                MedId = medquery.First.MedicalHistory_id
                HeightTextBox.Text = medquery.First.Height
                WeightTextBox.Text = medquery.First.Weight
                Temptxtbox.Text = medquery.First.Tempreture
                PRtxtbox.Text = medquery.First.HeartRate
                ResTextBox.Text = medquery.First.respiratoryRate
                B1TextBox.Text = medquery.First.BloodPressure.Substring(0, medquery.First.BloodPressure.IndexOf("/"))
                B2TextBox.Text = medquery.First.BloodPressure.Substring(medquery.First.BloodPressure.IndexOf("/") + 1)
                SymptTextBox.Text = medquery.First.Symptoms
                If medquery.First.TobaccoUse = 1 Then
                    TUchkbox.Checked = True
                Else
                    TUchkbox.Checked = False
                End If
            Catch ex As Exception

            End Try

        End If


    End Sub

    'handles vital signs submit button and update medical history table
    Private Sub Submitbtn_Click(sender As Object, e As EventArgs) Handles Submitbtn.Click
        'For New vital signs get the data entered by user And update the database
        If flag = True Then
            Dim medrow As CMSDataSet.MedicalHistoryRow
            medrow = Main.CmsDataSet1.MedicalHistory.FindByMedicalHistory_id(MedId)
            medrow.Height = HeightTextBox.Text
            medrow.Weight = WeightTextBox.Text
            medrow.Tempreture = Temptxtbox.Text
            medrow.HeartRate = PRtxtbox.Text
            medrow.respiratoryRate = ResTextBox.Text
            medrow.BloodPressure = B1TextBox.Text & "/" & B2TextBox.Text
            medrow.Symptoms = SymptTextBox.Text
            If TUchkbox.Checked Then
                medrow.TobaccoUse = 1
            Else
                medrow.TobaccoUse = 0
            End If

            'after adding the vital signs .. change the status of the appointment to [waiting]     
            Dim approw As CMSDataSet.AppointmentRow
            approw = Main.CmsDataSet1.Appointment.FindByidAppointment(appid)
            approw.status = "W"

            Main.MedicalHistoryTableAdapter.Update(Main.CmsDataSet1.MedicalHistory)
            Main.AppointmentTableAdapter.Update(Main.CmsDataSet1.Appointment)
            Main.dgvrefresh()
            Me.Close()
        Else
        MsgBox("Check entered data.")
        End If

    End Sub

    'make sure user enters only numerical values
    Private Sub KeyPressValidation(sender As Object, e As KeyPressEventArgs) Handles WeightTextBox.KeyPress, HeightTextBox.KeyPress, ResTextBox.KeyPress, Temptxtbox.KeyPress, PRtxtbox.KeyPress, B1TextBox.KeyPress, B2TextBox.KeyPress
        If (Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 46) Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 8 Then
                MessageBox.Show("Please enter numbers only")
                e.Handled = True
            End If
        End If
    End Sub

    'all [textchanged] subs are used to validate the entered value
    Private Sub HeightTextBox_TextChanged(sender As Object, e As EventArgs) Handles HeightTextBox.TextChanged
        Try
            If HeightTextBox.Text < 50 Or HeightTextBox.Text > 250 Then
                flag = False
            Else
                flag = True
            End If
        Catch ex As Exception
            HeightTextBox.Text = ""
        End Try
    End Sub

    Private Sub WeightTextBox_TextChanged(sender As Object, e As EventArgs) Handles WeightTextBox.TextChanged
        Try
            If WeightTextBox.Text < 50 Or WeightTextBox.Text > 250 Then
                flag = False
            Else
                flag = True
            End If
        Catch ex As Exception
            WeightTextBox.Text = ""
        End Try
    End Sub

    Private Sub Temptxtbox_TextChanged(sender As Object, e As EventArgs) Handles Temptxtbox.TextChanged
        Try
            If Temptxtbox.Text < 0 Or Temptxtbox.Text > 100 Then
                flag = False
            Else
                flag = True
            End If
        Catch ex As Exception
            Temptxtbox.Text = ""
        End Try
    End Sub

    Private Sub B1TextBox_TextChanged(sender As Object, e As EventArgs) Handles B1TextBox.TextChanged
        Try
            If B1TextBox.Text < 60 Or B1TextBox.Text > 250 Then
                flag = False
            Else
                flag = True
            End If
        Catch ex As Exception
            B1TextBox.Text = ""
        End Try
    End Sub

    Private Sub B2TextBox_TextChanged(sender As Object, e As EventArgs) Handles B2TextBox.TextChanged
        Try
            If B2TextBox.Text < 80 Or B2TextBox.Text > 300 Then
                flag = False
            Else
                flag = True
            End If
        Catch ex As Exception
            B2TextBox.Text = ""
        End Try
    End Sub

    Private Sub PRtxtbox_TextChanged(sender As Object, e As EventArgs) Handles PRtxtbox.TextChanged
        Try
            If PRtxtbox.Text < 10 Or PRtxtbox.Text > 200 Then
                flag = False
            Else
                flag = True
            End If
        Catch ex As Exception
            PRtxtbox.Text = ""
        End Try
    End Sub

    Private Sub ResTextBox_TextChanged(sender As Object, e As EventArgs) Handles ResTextBox.TextChanged
        Try
            If ResTextBox.Text < 5 Or ResTextBox.Text > 70 Then
                flag = False
            Else
                flag = True
            End If
        Catch ex As Exception
            ResTextBox.Text = ""
        End Try
    End Sub

End Class