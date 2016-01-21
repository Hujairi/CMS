Public Class Login
    Dim username As String
    Dim pass As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CmsDataSet1.User' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.CmsDataSet1.User)
        'TODO: This line of code loads data into the 'CmsDataSet1.Patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me.CmsDataSet1.Patient)

    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        username = UsernameTextBox.Text
        pass = PasswordTextBox.Text

        'identifing user type
        If (username.Contains("[a-zA-Z]+") = False And username.Length = 9) Then
            Dim query = From patient In CmsDataSet1.Patient
                        Where patient.idPatient = username
                        Select patient.LoginPassword

            'vaildating password
            Try
                If query.First = pass Then
                    PatientAppointmentForm.Show()
                    Me.Close()
                Else
                    MsgBox("incorrect password")
                End If
            Catch ex As Exception
                MsgBox("incorrect username")
            End Try
        Else
            Dim query = From user In CmsDataSet1.User
                        Where user.idUser.ToUpper = username.ToUpper
                        Select user.LoginPassword

            'vaildating password
            Try
                If query.First = pass Then
                    Main.Show()
                    Me.Close()

                Else
                    MsgBox("incorrect password")
                End If
            Catch ex As Exception
                MsgBox("incorrect username")
            End Try

        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Public Function getUserID() As String
        Return username
    End Function


End Class
