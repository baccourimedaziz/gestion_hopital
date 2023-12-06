Public Class frm_afficherrdv
    Private Sub frm_afficherrdv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficherRDVsDuJour(DGV_RDV)
    End Sub

    Private Sub btn_sup_Click(sender As Object, e As EventArgs) Handles btn_sup.Click
        Dim i As Integer = DGV_RDV.SelectedCells(0).RowIndex
        If i < 0 Then
            MsgBox("aucune selection")
        Else
            DGV_RDV.Rows.RemoveAt(i)
            patients(i) = Nothing
        End If
    End Sub
    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_ret.Click
        DGV_RDV.ClearSelection()
        Me.Close()
        frm_main.Show()
    End Sub
End Class