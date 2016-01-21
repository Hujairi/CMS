Public Class Patientform
    Public Fromapp As Boolean = False
    Public isnew As Boolean = True
    Private Sub Patientform_Load(sender As Object, e As EventArgs) Handles Me.Load
        Appointmentform.Close()

        If (IDtextbox.Text <> "" And IDtextbox.Text.Contains("[a-zA-Z]+") = False) Then
            Dim query = From patient In Main.CmsDataSet1.Patient
                        Where patient.idPatient = CInt(IDtextbox.Text)
                        Select patient
            If query.Count > 0 Then
                FNtextbox.Text = query.First.FirstName
                LNtextbox.Text = query.First.LastName
                BDPicker.Value = query.First.BirthDate
                Phonetextbox.Text = query.First.Phone
                Addtextbox.Text = query.First.Address
                Passwordtextbox.Text = query.First.LoginPassword
                BloodComboBox.SelectedIndex = BloodComboBox.FindString(query.First.BloodType)
            End If
        End If
    End Sub

    'handles the submit button
    Private Sub Submitbtn_Click(sender As Object, e As EventArgs) Handles Submitbtn.Click

        If (IDtextbox.Text <> "" And IDtextbox.Text.Contains("[a-zA-Z]+") = False) Then
            Dim query = From patient In Main.CmsDataSet1.Patient
                        Where patient.idPatient = CInt(IDtextbox.Text)
                        Select patient
            If query.Count = 0 Then
                submitPatientForm()
            Else
                If isnew = True Then
                    MsgBox("Already Existed Patient with the same ID")
                Else
                    updatepateintform()
                End If

            End If
        End If
        Main.dgvrefresh()

    End Sub

    'get the data submitted by the user and create new patient
    Private Sub submitPatientForm()
        'make sure all fields are NOT empty
        If FNtextbox.Text <> "" And LNtextbox.Text <> "" And IDtextbox.Text <> "" And Phonetextbox.Text <> "" And Addtextbox.Text <> "" And Passwordtextbox.Text <> "" And BloodComboBox.SelectedIndex >= 0 Then
            Dim newPatientRow As CMSDataSet.PatientRow
            newPatientRow = Main.CmsDataSet1.Patient.NewPatientRow
            newPatientRow.FirstName = FNtextbox.Text
            newPatientRow.LastName = LNtextbox.Text
            newPatientRow.idPatient = CInt(IDtextbox.Text)
            newPatientRow.BirthDate = BDPicker.Value
            newPatientRow.Phone = Phonetextbox.Text
            newPatientRow.Address = Addtextbox.Text
            If MRB.Checked Then
                newPatientRow.Gender = "M"
            Else
                newPatientRow.Gender = "F"
            End If
            newPatientRow.LoginPassword = Passwordtextbox.Text
            newPatientRow.BloodType = BloodComboBox.SelectedItem.ToString
            Main.CmsDataSet1.Patient.Rows.Add(newPatientRow)
            Main.PatientTableAdapter.Update(Main.CmsDataSet1.Patient)
            MsgBox("Patient profile created successfully")
            Me.Close()
        Else
            MsgBox("Please Fill In All Required Fields")
        End If

    End Sub

    'sub to update exisited patient with new information
    Private Sub updatepateintform()
        If FNtextbox.Text <> "" And LNtextbox.Text <> "" And Phonetextbox.Text <> "" And Addtextbox.Text <> "" And Passwordtextbox.Text <> "" And BloodComboBox.SelectedIndex >= 0 Then
            Dim patientrow As CMSDataSet.PatientRow
            patientrow = Main.CmsDataSet1.Patient.FindByidPatient(CInt(IDtextbox.Text))
            patientrow.FirstName = FNtextbox.Text
            patientrow.LastName = LNtextbox.Text
            patientrow.BirthDate = BDPicker.Value
            patientrow.Phone = Phonetextbox.Text
            patientrow.Address = Addtextbox.Text
            If MRB.Checked Then
                patientrow.Gender = "M"
            Else
                patientrow.Gender = "F"
            End If
            patientrow.LoginPassword = Passwordtextbox.Text
            patientrow.BloodType = BloodComboBox.SelectedItem.ToString
            Main.PatientTableAdapter.Update(Main.CmsDataSet1.Patient)
            MsgBox("Patient profile edited successfully")
            Me.Close()

        Else
            MsgBox("Please Fill In All Required Fields")
        End If

    End Sub

    Private Sub Patientform_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Fromapp = True Then
            Appointmentform.Show()
        End If
    End Sub


End Class