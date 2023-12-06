<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class authentification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(authentification))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(33, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "password"
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txt_password.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(155, 65)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(150, 33)
        Me.txt_password.TabIndex = 3
        Me.txt_password.Tag = "*"
        Me.txt_password.UseSystemPasswordChar = True
        '
        'txt_nom
        '
        Me.txt_nom.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txt_nom.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nom.Location = New System.Drawing.Point(155, 20)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(150, 33)
        Me.txt_nom.TabIndex = 4
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_annuler.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(334, 193)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(116, 54)
        Me.btn_annuler.TabIndex = 5
        Me.btn_annuler.Text = "annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'btn_valider
        '
        Me.btn_valider.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_valider.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_valider.Location = New System.Drawing.Point(143, 193)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(126, 54)
        Me.btn_valider.TabIndex = 6
        Me.btn_valider.Text = "valider"
        Me.btn_valider.UseVisualStyleBackColor = False
        '
        'authentification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(602, 311)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "authentification"
        Me.Text = "authentification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents btn_annuler As Button
    Friend WithEvents btn_valider As Button
End Class
