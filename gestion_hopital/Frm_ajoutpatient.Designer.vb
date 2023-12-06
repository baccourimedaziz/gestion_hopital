<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ajoutpatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ajoutpatient))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_C = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.btn_ajout = New System.Windows.Forms.Button()
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
        Me.Label1.Location = New System.Drawing.Point(198, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(198, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "prenom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(198, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "nom"
        '
        'txt_C
        '
        Me.txt_C.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_C.Location = New System.Drawing.Point(319, 144)
        Me.txt_C.Name = "txt_C"
        Me.txt_C.Size = New System.Drawing.Size(220, 29)
        Me.txt_C.TabIndex = 4
        '
        'txt_nom
        '
        Me.txt_nom.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nom.Location = New System.Drawing.Point(319, 198)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(220, 29)
        Me.txt_nom.TabIndex = 5
        '
        'txt_prenom
        '
        Me.txt_prenom.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prenom.Location = New System.Drawing.Point(319, 255)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(220, 29)
        Me.txt_prenom.TabIndex = 6
        '
        'btn_ajout
        '
        Me.btn_ajout.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajout.Location = New System.Drawing.Point(321, 311)
        Me.btn_ajout.Name = "btn_ajout"
        Me.btn_ajout.Size = New System.Drawing.Size(117, 41)
        Me.btn_ajout.TabIndex = 7
        Me.btn_ajout.Text = "ajouter"
        Me.btn_ajout.UseVisualStyleBackColor = True
        '
        'btn_annuler
        '
        Me.btn_annuler.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(444, 311)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(117, 41)
        Me.btn_annuler.TabIndex = 8
        Me.btn_annuler.Text = "annuler"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'btn_retour
        '
        Me.btn_retour.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retour.Location = New System.Drawing.Point(191, 311)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(117, 41)
        Me.btn_retour.TabIndex = 9
        Me.btn_retour.Text = "retour"
        Me.btn_retour.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(319, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Frm_ajoutpatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_retour)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_ajout)
        Me.Controls.Add(Me.txt_prenom)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.txt_C)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_ajoutpatient"
        Me.Text = "Patient"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_C As TextBox
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents btn_ajout As Button
    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_retour As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
