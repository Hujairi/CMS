Public Class RReportsForm
    Public mdID
    'setup reports request form
    Private Sub RReportsdgvForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reportsquery = From med In Main.CmsDataSet1.MedicalHistory Join patient In Main.CmsDataSet1.Patient On med.Patient_id Equals patient.idPatient Join app In Main.CmsDataSet1.Appointment On med.Appointment_id Equals app.idAppointment
                           Let pname = patient.FirstName + " " + patient.LastName
                           Where med.MedicalHistory_id = mdID
                           Select patient, pname

        NameTextBox.Text = reportsquery.First.pname
        IDTextBox.Text = reportsquery.First.patient.idPatient


    End Sub
    'populate comboboxes with test and ray items
    Private Sub reportsdgv_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles reportsdgv.CellValueChanged
        Dim cboCol1 As DataGridViewComboBoxCell
        Dim xray() As String = {"Head", "Neck", "Chest", "Left Hand", "Right Hand", "Left Arm", "Right Arm", "stomach", "Upper Back", "Lower Back", "Left Thigh", "Right Thigh", "Left Knee", "Right Knee", "Left Shin", "Right Shin", "Left Foot", "Right Foot"}
        Dim lab() As String = {"CBC", " thyroid gland", "HEMOGLOBIN", "Liver Function", "kidney function", "Urine", "Hormones", "Osteoporosis", "pancreas function", "Cerebrospinal fluid", "Stool", "Hypersensitivity", "Enzymes", "C-Reactive Protien", "Hepatitis A", "Hepatitis B", "Hepatitis c"}
        Array.Sort(xray)
        Array.Sort(lab)

        Try
            If reportsdgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "X-Ray" Then
                cboCol1 = reportsdgv.Item(1, e.RowIndex)
                cboCol1.DataSource = xray
            ElseIf reportsdgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "MRI"
                cboCol1 = reportsdgv.Rows(e.RowIndex).Cells(1)
                cboCol1.DataSource = xray
            ElseIf reportsdgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "CT"
                cboCol1 = reportsdgv.Rows(e.RowIndex).Cells(1)
                cboCol1.DataSource = xray
            ElseIf reportsdgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "Labratory"
                cboCol1 = reportsdgv.Rows(e.RowIndex).Cells(1)
                cboCol1.DataSource = lab

            End If
        Catch ex As Exception

        End Try

    End Sub
    'set combobox settings
    Private Sub reportsdgv_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles reportsdgv.EditingControlShowing
        If reportsdgv.CurrentCell.ColumnIndex = 1 Then
            If TypeOf e.Control Is System.Windows.Forms.ComboBox Then
                With DirectCast(e.Control, System.Windows.Forms.ComboBox)
                    'Set the dropdown props.
                    .DropDownStyle = ComboBoxStyle.DropDown
                    .AutoCompleteMode = AutoCompleteMode.Suggest
                    .AutoCompleteSource = AutoCompleteSource.ListItems

                End With
            Else

            End If
        End If

    End Sub
    'allowing user to enter new sub-types reports
    Private Sub reportsdgv_CellValidating(ByVal sender As Object, ByVal e As DataGridViewCellValidatingEventArgs) Handles reportsdgv.CellValidating
        If e.ColumnIndex = 1 Then
            ' Add the value to column's Items to pass validation
            Dim cbobox As DataGridViewComboBoxCell = reportsdgv.Item(1, e.RowIndex)
            If cbobox.Items.Contains(e.FormattedValue) = False Then
                cbobox.Value = e.FormattedValue
                cbobox.Items.Add(e.FormattedValue)
            End If

        End If
    End Sub
    'handles submit button click.get requested reports and insert them into database
    Private Sub submitrrbtn_Click(sender As Object, e As EventArgs) Handles submitrrbtn.Click
        Dim newreportrow As CMSDataSet.ReportsRow

        For i = 0 To reportsdgv.RowCount - 2
            Dim queryrep = From rep In Main.CmsDataSet1.Reports
                           Select rep.DocumentID



            Try

                If reportsdgv.Rows(i).Cells(0).Value <> "" And reportsdgv.Rows(i).Cells(1).Value <> "" Then
                    newreportrow = Main.CmsDataSet1.Reports.NewReportsRow
                    newreportrow.DocumentID = queryrep.LastOrDefault + 1
                    newreportrow.MedicalHistory_id = mdID
                    newreportrow.DocumentType = reportsdgv.Rows(i).Cells(0).Value
                    newreportrow.DocumentSubType = reportsdgv.Rows(i).Cells(1).Value
                    Main.CmsDataSet1.Reports.Rows.Add(newreportrow)

                End If

            Catch ex As Exception
            MsgBox("enter info of report:   " & i + 1)
            Exit Sub
            End Try



        Next

        Me.Close()
    End Sub



End Class