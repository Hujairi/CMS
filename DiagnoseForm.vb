Imports System.IO

Public Class DiagnoseForm
    Public appid As String
    Dim midid As String

    Private Sub DiagnoseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim cboCol1 As DataGridViewComboBoxColumn
        cboCol1 = PrescriptionDGV.Columns.Item(0)

        Dim query = From med In Main.CmsDataSet1.Medicine
                    Select med

        cboCol1.DataSource = query.ToArray
        cboCol1.DisplayMember = "Name"
        cboCol1.ValueMember = "idMedicine"

        Dim digquery = From med In Main.CmsDataSet1.MedicalHistory Join patient In Main.CmsDataSet1.Patient On med.Patient_id Equals patient.idPatient Join app In Main.CmsDataSet1.Appointment On med.Appointment_id Equals app.idAppointment
                       Let age = Now.Year - patient.BirthDate.Year
                       Let pname = patient.FirstName + " " + patient.LastName
                       Where med.Appointment_id = appid
                       Select med, patient, app, age, pname

        midid = digquery.First.med.MedicalHistory_id

        NameLabel.Text = digquery.First.pname
        IDLabe.Text = digquery.First.patient.idPatient
        AgeLabel.Text = digquery.First.age
        If digquery.First.patient.Gender = "M" Then
            GLabel.Text = "Male"
        Else
            GLabel.Text = "Female"
        End If
        BTLabel.Text = digquery.First.patient.BloodType
        Try
            heightLabel.Text = digquery.First.med.Height + " CM"
            weightlabel.Text = digquery.First.med.Weight + " Kg"
            Templabel.Text = digquery.First.med.Tempreture + " °C"
            BPLabel.Text = digquery.First.med.BloodPressure
            PulseLabel.Text = digquery.First.med.HeartRate + " PPM"
            RRlabel.Text = digquery.First.med.respiratoryRate + " BPM"
            If digquery.First.med.TobaccoUse = 1 Then
                TUlabel.Text = "Yes"
            Else
                TUlabel.Text = "No"
            End If
            SymptomsRTB.Text = digquery.First.med.Symptoms
        Catch ex As Exception

        End Try



    End Sub
    Private Sub DiagnoseTabcontrol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DiagnoseTabcontrol.SelectedIndexChanged
        If DiagnoseTabcontrol.SelectedIndex = 1 Then
            pdDgvRefrsh()
        End If
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles PrescriptionDGV.CellValueChanged
        If e.ColumnIndex = 0 Then
            Try
                Dim query = From med In Main.CmsDataSet1.Medicine
                            Where med.idMedicine = PrescriptionDGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
                            Select med
                '"T:Tablets | C:capsules | I:Injection | L:Liquid | O:Ointments | D:Drops | A:Aerosol"
                If query.First.Type = "T" Then
                    PrescriptionDGV.Rows(e.RowIndex).Cells(2).Value = "Tablets"
                ElseIf query.First.Type = "C"
                    PrescriptionDGV.Rows(e.RowIndex).Cells(2).Value = "Capsules"
                ElseIf query.First.Type = "I"
                    PrescriptionDGV.Rows(e.RowIndex).Cells(2).Value = "mL"
                ElseIf query.First.Type = "L"
                    PrescriptionDGV.Rows(e.RowIndex).Cells(2).Value = "mL"
                ElseIf query.First.Type = "O"
                    PrescriptionDGV.Rows(e.RowIndex).Cells(1).ReadOnly = True
                    PrescriptionDGV.Rows(e.RowIndex).Cells(1).Value = "1"
                ElseIf query.First.Type = "D"
                    PrescriptionDGV.Rows(e.RowIndex).Cells(2).Value = "Drops"
                ElseIf query.First.Type = "A"
                    PrescriptionDGV.Rows(e.RowIndex).Cells(2).Value = "Inhale"
                End If


            Catch ex As Exception

            End Try

        End If


    End Sub
    Private Sub VitalSignsGB_DoubleClick(sender As Object, e As EventArgs) Handles VitalSignsGB.DoubleClick
        VitalSignsform.appid = appid
        VitalSignsform.NameTextBox.Text = NameLabel.Text
        VitalSignsform.IDTextBox.Text = IDLabe.Text
        VitalSignsform.Show()

    End Sub

    Public sldays As Integer
    Public rsl As Boolean = False

    Private Sub gensickleave()
        If File.Exists("c:\cms\Sick_Leave_" & appid & ".html") = False Then
            Dim PRquery = From med In Main.CmsDataSet1.MedicalHistory Join patient In Main.CmsDataSet1.Patient On med.Patient_id Equals patient.idPatient Join app In Main.CmsDataSet1.Appointment On med.Appointment_id Equals app.idAppointment Join doc In Main.CmsDataSet1.User On doc.idUser Equals app.User_idUser
                          Let dname = doc.FirstName + " " + doc.LastName
                          Let pname = patient.FirstName + " " + patient.LastName
                          Where app.idAppointment = appid
                          Select app, dname, pname, med

            Dim sw As StreamWriter = New StreamWriter("c:\cms\Sick_Leave_" & appid & ".html", True)
            Dim str As String = My.Resources.SL
            str = str.Replace("clinic_name", My.Settings.ClinicName)
            str = str.Replace("pname", PRquery.First.pname)
            str = str.Replace("pdate", PRquery.First.app.Start.Date)
            str = str.Replace("pdig", PRquery.First.med.Diagnose)
            str = str.Replace("sld", sldays)
            str = str.Replace("doc_name", "Dr. " & PRquery.First.dname)

            sw.Write(str)
            sw.Close()
            Process.Start("c:\cms\Sick_Leave_" & appid & ".html")
        End If


    End Sub
    Private Sub SLbtn_Click(sender As Object, e As EventArgs) Handles SLbtn.Click
        Sickleave.Show()
    End Sub
    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        If MessageBox.Show("Are you sure you want to exit ?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub CDgButton_Click(sender As Object, e As EventArgs) Handles CDgButton.Click
        If DiagnoseTextBox.Text <> "" Then
            If MessageBox.Show("finish dignose?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                Dim medrow As CMSDataSet.MedicalHistoryRow
                medrow = Main.CmsDataSet1.MedicalHistory.FindByMedicalHistory_id(midid)
                medrow.Diagnose = DiagnoseTextBox.Text
                medrow.remarks = RemarksRTB.Text

                For i As Integer = 0 To (PrescriptionDGV.RowCount - 2)
                    If PrescriptionDGV.Rows(i).Cells(0).Value.ToString <> "" Then

                        If PrescriptionDGV.Rows(i).Cells(1).Value <> "" And PrescriptionDGV.Rows(i).Cells(3).Value <> "" And PrescriptionDGV.Rows(i).Cells(4).Value <> "" Then
                            Try
                                Dim newpsrow As CMSDataSet.PrescriptionRow
                                newpsrow = Main.CmsDataSet1.Prescription.NewPrescriptionRow
                                newpsrow.MedicalHistory_id = midid
                                newpsrow.Medicine_id = PrescriptionDGV.Rows(i).Cells(0).Value
                                newpsrow.Med_Intake = PrescriptionDGV.Rows(i).Cells(1).Value
                                newpsrow.Med_Freq = PrescriptionDGV.Rows(i).Cells(3).Value
                                newpsrow.Med_Duration = PrescriptionDGV.Rows(i).Cells(4).Value
                                Main.CmsDataSet1.Prescription.Rows.Add(newpsrow)
                            Catch ex As Exception

                            End Try
                        Else
                            MsgBox("enter info for mednicine: " & PrescriptionDGV.Rows(i).Index + 1)
                            Exit Sub
                        End If

                    End If
                Next

                Dim approw As CMSDataSet.AppointmentRow
                approw = Main.CmsDataSet1.Appointment.FindByidAppointment(appid)
                approw.status = "D"

                Main.AppointmentTableAdapter.Update(Main.CmsDataSet1.Appointment)
                Main.MedicalHistoryTableAdapter.Update(Main.CmsDataSet1.MedicalHistory)
                Main.PrescriptionTableAdapter.Update(Main.CmsDataSet1.Prescription)
                Main.ReportsTableAdapter.Update(Main.CmsDataSet1.Reports)

                Main.dgvrefresh()
                If rsl Then
                    gensickleave()
                End If
                Me.Close()
            End If
        End If


    End Sub
    Private Sub RRButton_Click(sender As Object, e As EventArgs) Handles RRButton.Click


        RReportsForm.mdID = midid
        RReportsForm.Show()



    End Sub

    Private Sub pdDgvRefrsh()
        PastDgDataGridView.Rows.Clear()

        Dim pastdiagnoses = From med In Main.CmsDataSet1.MedicalHistory Join patient In Main.CmsDataSet1.Patient On med.Patient_id Equals patient.idPatient Join app In Main.CmsDataSet1.Appointment On med.Appointment_id Equals app.idAppointment Join doc In Main.CmsDataSet1.User On doc.idUser Equals app.User_idUser
                            Let pname = patient.FirstName + " " + patient.LastName
                            Let dname = doc.FirstName + " " + doc.LastName
                            Where patient.idPatient = IDLabe.Text And app.idAppointment <> appid And app.Start < Now
                            Select med, patient, app, doc, dname

        Dim i As Integer = 0
        For Each result In pastdiagnoses
            Try
                With PastDgDataGridView
                    .Rows.Add()
                    .Item(0, i).Value = result.med.MedicalHistory_id
                    .Item(1, i).Value = result.app.Start.Date.ToShortDateString
                    .Item(2, i).Value = result.med.Diagnose
                    .Item(3, i).Value = result.dname
                End With
                i += 1
            Catch ex As Exception

            End Try


        Next


    End Sub
    Private Sub PastDgDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PastDgDataGridView.CellContentClick
        ClearPastDg()
        If e.RowIndex >= 0 Then
            Dim medid As String = PastDgDataGridView.Rows(e.RowIndex).Cells(0).Value
            Dim medquery = From med In Main.CmsDataSet1.MedicalHistory
                           Where med.MedicalHistory_id = medid
                           Select med

            Try
                hlabel.Text = medquery.First.Height + " CM"
            Catch ex As Exception

            End Try
            Try
                wlabel.Text = medquery.First.Weight + " Kg"
            Catch ex As Exception

            End Try
            Try
                Tlabel.Text = medquery.First.Tempreture + " °C"
            Catch ex As Exception

            End Try
            Try
                blabel.Text = medquery.First.BloodPressure
            Catch ex As Exception

            End Try
            Try
                prlabel.Text = medquery.First.HeartRate + " PPM"
            Catch ex As Exception

            End Try
            Try
                rrlable.Text = medquery.First.respiratoryRate + " BPM"
            Catch ex As Exception

            End Try
            Try
                If medquery.First.TobaccoUse = 1 Then
                    tobaccolabel.Text = "Yes"
                Else
                    tobaccolabel.Text = "No"
                End If
            Catch ex As Exception

            End Try
            Try
                SRTB.Text = medquery.First.Symptoms
            Catch ex As Exception

            End Try
            Try
                DRTB.Text = medquery.First.Diagnose
            Catch ex As Exception

            End Try
            Try
                RRTB.Text = medquery.First.remarks
            Catch ex As Exception

            End Try
        End If

    End Sub
    Private Sub ClearPastDg()
        hlabel.Text = ""
        wlabel.Text = ""
        Tlabel.Text = ""
        blabel.Text = ""
        prlabel.Text = ""
        rrlable.Text = ""
        tobaccolabel.Text = ""
        SRTB.Text = ""
        DRTB.Text = ""
        RRTB.Text = ""

    End Sub


End Class