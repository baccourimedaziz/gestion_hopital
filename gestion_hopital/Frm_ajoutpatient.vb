Public Class Frm_ajoutpatient
    Private Sub btn_ajout_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        Dim p As patient
        p.code = txt_C.Text
        p.nom = txt_nom.Text
        p.prenom = txt_prenom.Text
        Ajouterpatient(p)

    End Sub
    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        txt_C.Clear()
        txt_nom.Clear()
        txt_prenom.Clear()
    End Sub

    Private Sub btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Me.Hide()
        frm_main.Show()
    End Sub

    Private Sub Frm_ajoutpatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class