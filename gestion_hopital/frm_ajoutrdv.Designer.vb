<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ajoutrdv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ajoutrdv))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.dtp_rdv = New System.Windows.Forms.DateTimePicker()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "code du patient :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "date et heure :"
        '
        'txt_code
        '
        Me.txt_code.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_code.Location = New System.Drawing.Point(278, 150)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(343, 30)
        Me.txt_code.TabIndex = 3
        '
        'dtp_rdv
        '
        Me.dtp_rdv.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_rdv.Location = New System.Drawing.Point(273, 226)
        Me.dtp_rdv.Name = "dtp_rdv"
        Me.dtp_rdv.Size = New System.Drawing.Size(348, 33)
        Me.dtp_rdv.TabIndex = 4
        '
        'btn_ajouter
        '
        Me.btn_ajouter.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.Location = New System.Drawing.Point(310, 308)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(139, 61)
        Me.btn_ajouter.TabIndex = 5
        Me.btn_ajouter.Text = "ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = True
        '
        'btn_annuler
        '
        Me.btn_annuler.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(482, 308)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(139, 61)
        Me.btn_annuler.TabIndex = 6
        Me.btn_annuler.Text = "annuler"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'btn_retour
        '
        Me.btn_retour.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retour.Location = New System.Drawing.Point(133, 308)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(139, 61)
        Me.btn_retour.TabIndex = 7
        Me.btn_retour.Text = "retour"
        Me.btn_retour.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(323, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 129)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'frm_ajoutrdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_retour)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.dtp_rdv)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_ajoutrdv"
        Me.Text = "frm_ajoutrdv"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents dtp_rdv As DateTimePicker
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_retour As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
