<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_afficherpatient
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGV_patient = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.btn_supp = New System.Windows.Forms.Button()
        CType(Me.DGV_patient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_patient
        '
        Me.DGV_patient.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGV_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_patient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column3})
        Me.DGV_patient.Location = New System.Drawing.Point(37, 12)
        Me.DGV_patient.Name = "DGV_patient"
        Me.DGV_patient.RowHeadersWidth = 51
        Me.DGV_patient.RowTemplate.Height = 24
        Me.DGV_patient.Size = New System.Drawing.Size(891, 527)
        Me.DGV_patient.TabIndex = 0
        '
        'Column2
        '
        Me.Column2.HeaderText = "Prenom "
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nom"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "code patient "
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'btn_retour
        '
        Me.btn_retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_retour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_retour.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retour.ForeColor = System.Drawing.Color.Black
        Me.btn_retour.Location = New System.Drawing.Point(634, 545)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(138, 54)
        Me.btn_retour.TabIndex = 10
        Me.btn_retour.Text = "retour"
        Me.btn_retour.UseVisualStyleBackColor = False
        '
        'btn_supp
        '
        Me.btn_supp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_supp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_supp.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supp.ForeColor = System.Drawing.Color.Black
        Me.btn_supp.Location = New System.Drawing.Point(787, 545)
        Me.btn_supp.Name = "btn_supp"
        Me.btn_supp.Size = New System.Drawing.Size(141, 54)
        Me.btn_supp.TabIndex = 9
        Me.btn_supp.Text = "supprimer"
        Me.btn_supp.UseVisualStyleBackColor = False
        '
        'frm_afficherpatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 633)
        Me.Controls.Add(Me.btn_retour)
        Me.Controls.Add(Me.btn_supp)
        Me.Controls.Add(Me.DGV_patient)
        Me.Name = "frm_afficherpatient"
        Me.Text = "listes des patients"
        CType(Me.DGV_patient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_patient As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btn_retour As Button
    Friend WithEvents btn_supp As Button
End Class
