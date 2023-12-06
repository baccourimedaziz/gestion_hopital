Public Class authentification

    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim login As String
        Dim pw As String
        login = txt_nom.Text
        pw = txt_password.Text
        If (login = "admin") And (pw = "1234") Then
            Me.Hide()
            frm_main.Show()
        End If

    End Sub



    Private Sub txt_nom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nom.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_password.Focus()
        End If
    End Sub



    Private Sub txt_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_password.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btn_valider.PerformClick()
        End If
    End Sub
End Class