<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_afficherrdv
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DGV_RDV = New System.Windows.Forms.DataGridView()
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateheure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_sup = New System.Windows.Forms.Button()
        Me.btn_ret = New System.Windows.Forms.Button()
        CType(Me.DGV_RDV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(829, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'DGV_RDV
        '
        Me.DGV_RDV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGV_RDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_RDV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code, Me.dateheure})
        Me.DGV_RDV.Location = New System.Drawing.Point(12, 12)
        Me.DGV_RDV.Name = "DGV_RDV"
        Me.DGV_RDV.RowHeadersWidth = 51
        Me.DGV_RDV.RowTemplate.Height = 24
        Me.DGV_RDV.Size = New System.Drawing.Size(805, 439)
        Me.DGV_RDV.TabIndex = 2
        '
        'code
        '
        Me.code.HeaderText = "code"
        Me.code.MinimumWidth = 6
        Me.code.Name = "code"
        Me.code.Width = 125
        '
        'dateheure
        '
        Me.dateheure.HeaderText = "date et heure"
        Me.dateheure.MinimumWidth = 6
        Me.dateheure.Name = "dateheure"
        Me.dateheure.Width = 125
        '
        'btn_sup
        '
        Me.btn_sup.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_sup.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sup.Location = New System.Drawing.Point(676, 457)
        Me.btn_sup.Name = "btn_sup"
        Me.btn_sup.Size = New System.Drawing.Size(141, 49)
        Me.btn_sup.TabIndex = 7
        Me.btn_sup.Text = "supprimer"
        Me.btn_sup.UseVisualStyleBackColor = False
        '
        'btn_ret
        '
        Me.btn_ret.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_ret.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ret.Location = New System.Drawing.Point(512, 457)
        Me.btn_ret.Name = "btn_ret"
        Me.btn_ret.Size = New System.Drawing.Size(138, 49)
        Me.btn_ret.TabIndex = 8
        Me.btn_ret.Text = "retour"
        Me.btn_ret.UseVisualStyleBackColor = False
        '
        'frm_afficherrdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 533)
        Me.Controls.Add(Me.btn_ret)
        Me.Controls.Add(Me.btn_sup)
        Me.Controls.Add(Me.DGV_RDV)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_afficherrdv"
        Me.Text = "frm_afficherrdv"
        CType(Me.DGV_RDV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DGV_RDV As DataGridView
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents dateheure As DataGridViewTextBoxColumn
    Friend WithEvents btn_sup As Button
    Friend WithEvents btn_ret As Button
End Class
