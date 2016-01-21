Imports System.Windows.Forms

Public Class Sickleave

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If sldayscb.SelectedIndex <> -1 Then
            DiagnoseForm.rsl = True
            DiagnoseForm.sldays = sldayscb.SelectedItem
            MsgBox("sick leave will be printed after completeing diagnose.")
            Me.Close()
        Else
            MsgBox("Select number of days")
        End If

    End Sub


End Class
