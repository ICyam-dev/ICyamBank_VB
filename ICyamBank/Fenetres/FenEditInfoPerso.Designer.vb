<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FenEditInfoPerso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FenEditInfoPerso))
        Me.Btn_Annuler = New System.Windows.Forms.Button()
        Me.Btn_OK = New System.Windows.Forms.Button()
        Me.GroupBox_InfosPerso = New System.Windows.Forms.GroupBox()
        Me.TextBox_TexteInformation = New System.Windows.Forms.TextBox()
        Me.TextBox_Tel2User = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox_Tel1User = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox_CPUser = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox_MailUser = New System.Windows.Forms.TextBox()
        Me.Label_Mail = New System.Windows.Forms.Label()
        Me.Label_Telephones = New System.Windows.Forms.Label()
        Me.TextBox_VilleUser = New System.Windows.Forms.TextBox()
        Me.Label_CPVille = New System.Windows.Forms.Label()
        Me.TextBox_Adr3User = New System.Windows.Forms.TextBox()
        Me.TextBox_Adr2User = New System.Windows.Forms.TextBox()
        Me.TextBox_Adr1User = New System.Windows.Forms.TextBox()
        Me.TextBox_PrenomUser = New System.Windows.Forms.TextBox()
        Me.TextBox_NomUser = New System.Windows.Forms.TextBox()
        Me.Label_Adresse = New System.Windows.Forms.Label()
        Me.Label_NomPrenom = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_TitreFenetre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox_InfosPerso.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Annuler
        '
        Me.Btn_Annuler.Location = New System.Drawing.Point(415, 311)
        Me.Btn_Annuler.Name = "Btn_Annuler"
        Me.Btn_Annuler.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Annuler.TabIndex = 20
        Me.Btn_Annuler.Text = "&Annuler"
        Me.Btn_Annuler.UseVisualStyleBackColor = True
        '
        'Btn_OK
        '
        Me.Btn_OK.Location = New System.Drawing.Point(496, 311)
        Me.Btn_OK.Name = "Btn_OK"
        Me.Btn_OK.Size = New System.Drawing.Size(75, 23)
        Me.Btn_OK.TabIndex = 19
        Me.Btn_OK.Text = "&Ok"
        Me.Btn_OK.UseVisualStyleBackColor = True
        '
        'GroupBox_InfosPerso
        '
        Me.GroupBox_InfosPerso.Controls.Add(Me.TextBox_TexteInformation)
        Me.GroupBox_InfosPerso.Controls.Add(Me.TextBox_Tel2User)
        Me.GroupBox_InfosPerso.Controls.Add(Me.TextBox_Tel1User)
        Me.GroupBox_InfosPerso.Controls.Add(Me.TextBox_CPUser)
        Me.GroupBox_InfosPerso.Controls.Add(Me.TextBox_MailUser)
        Me.GroupBox_InfosPerso.Controls.Add(Me.Label_Mail)
        Me.GroupBox_InfosPerso.Controls.Add(Me.Label_Telephones)
        Me.GroupBox_InfosPerso.Controls.Add(Me.TextBox_VilleUser)
        Me.GroupBox_InfosPerso.Controls.Add(Me.Label_CPVille)
        Me.GroupBox_InfosPerso.Controls.Add(Me.TextBox_Adr3User)
        Me.GroupBox_InfosPerso.Controls.Add(Me.TextBox_Adr2User)
        Me.GroupBox_InfosPerso.Controls.Add(Me.TextBox_Adr1User)
        Me.GroupBox_InfosPerso.Controls.Add(Me.TextBox_PrenomUser)
        Me.GroupBox_InfosPerso.Controls.Add(Me.TextBox_NomUser)
        Me.GroupBox_InfosPerso.Controls.Add(Me.Label_Adresse)
        Me.GroupBox_InfosPerso.Controls.Add(Me.Label_NomPrenom)
        Me.GroupBox_InfosPerso.Controls.Add(Me.Label3)
        Me.GroupBox_InfosPerso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_InfosPerso.Location = New System.Drawing.Point(121, 41)
        Me.GroupBox_InfosPerso.Name = "GroupBox_InfosPerso"
        Me.GroupBox_InfosPerso.Size = New System.Drawing.Size(450, 264)
        Me.GroupBox_InfosPerso.TabIndex = 18
        Me.GroupBox_InfosPerso.TabStop = False
        Me.GroupBox_InfosPerso.Text = "Informations Personnelles"
        '
        'TextBox_TexteInformation
        '
        Me.TextBox_TexteInformation.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox_TexteInformation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_TexteInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TexteInformation.Location = New System.Drawing.Point(9, 17)
        Me.TextBox_TexteInformation.Multiline = True
        Me.TextBox_TexteInformation.Name = "TextBox_TexteInformation"
        Me.TextBox_TexteInformation.Size = New System.Drawing.Size(429, 45)
        Me.TextBox_TexteInformation.TabIndex = 17
        Me.TextBox_TexteInformation.Text = "Toutes ces informations sont optionnelles et ne sont pas nécessaires au fonctionn" &
    "emment de l'application. Elles ne sont utilisées que dans le fonctionnement de l" &
    "'application ICyamBank"
        '
        'TextBox_Tel2User
        '
        Me.TextBox_Tel2User.Location = New System.Drawing.Point(274, 202)
        Me.TextBox_Tel2User.Mask = "00 00 00 00 00"
        Me.TextBox_Tel2User.Name = "TextBox_Tel2User"
        Me.TextBox_Tel2User.Size = New System.Drawing.Size(165, 20)
        Me.TextBox_Tel2User.TabIndex = 12
        '
        'TextBox_Tel1User
        '
        Me.TextBox_Tel1User.Location = New System.Drawing.Point(113, 202)
        Me.TextBox_Tel1User.Mask = "00 00 00 00 00"
        Me.TextBox_Tel1User.Name = "TextBox_Tel1User"
        Me.TextBox_Tel1User.Size = New System.Drawing.Size(155, 20)
        Me.TextBox_Tel1User.TabIndex = 11
        '
        'TextBox_CPUser
        '
        Me.TextBox_CPUser.Location = New System.Drawing.Point(113, 176)
        Me.TextBox_CPUser.Mask = "99999"
        Me.TextBox_CPUser.Name = "TextBox_CPUser"
        Me.TextBox_CPUser.Size = New System.Drawing.Size(79, 20)
        Me.TextBox_CPUser.TabIndex = 9
        Me.TextBox_CPUser.ValidatingType = GetType(Integer)
        '
        'TextBox_MailUser
        '
        Me.TextBox_MailUser.Location = New System.Drawing.Point(113, 228)
        Me.TextBox_MailUser.Name = "TextBox_MailUser"
        Me.TextBox_MailUser.Size = New System.Drawing.Size(326, 20)
        Me.TextBox_MailUser.TabIndex = 13
        '
        'Label_Mail
        '
        Me.Label_Mail.AutoSize = True
        Me.Label_Mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Mail.Location = New System.Drawing.Point(7, 231)
        Me.Label_Mail.Name = "Label_Mail"
        Me.Label_Mail.Size = New System.Drawing.Size(32, 13)
        Me.Label_Mail.TabIndex = 15
        Me.Label_Mail.Text = "Mail :"
        '
        'Label_Telephones
        '
        Me.Label_Telephones.AutoSize = True
        Me.Label_Telephones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Telephones.Location = New System.Drawing.Point(7, 205)
        Me.Label_Telephones.Name = "Label_Telephones"
        Me.Label_Telephones.Size = New System.Drawing.Size(69, 13)
        Me.Label_Telephones.TabIndex = 12
        Me.Label_Telephones.Text = "Téléphones :"
        '
        'TextBox_VilleUser
        '
        Me.TextBox_VilleUser.Location = New System.Drawing.Point(198, 176)
        Me.TextBox_VilleUser.Name = "TextBox_VilleUser"
        Me.TextBox_VilleUser.Size = New System.Drawing.Size(241, 20)
        Me.TextBox_VilleUser.TabIndex = 10
        '
        'Label_CPVille
        '
        Me.Label_CPVille.AutoSize = True
        Me.Label_CPVille.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CPVille.Location = New System.Drawing.Point(6, 179)
        Me.Label_CPVille.Name = "Label_CPVille"
        Me.Label_CPVille.Size = New System.Drawing.Size(100, 13)
        Me.Label_CPVille.TabIndex = 9
        Me.Label_CPVille.Text = "Code postal && Ville :"
        '
        'TextBox_Adr3User
        '
        Me.TextBox_Adr3User.Location = New System.Drawing.Point(113, 150)
        Me.TextBox_Adr3User.Name = "TextBox_Adr3User"
        Me.TextBox_Adr3User.Size = New System.Drawing.Size(326, 20)
        Me.TextBox_Adr3User.TabIndex = 8
        '
        'TextBox_Adr2User
        '
        Me.TextBox_Adr2User.Location = New System.Drawing.Point(113, 130)
        Me.TextBox_Adr2User.Name = "TextBox_Adr2User"
        Me.TextBox_Adr2User.Size = New System.Drawing.Size(326, 20)
        Me.TextBox_Adr2User.TabIndex = 7
        '
        'TextBox_Adr1User
        '
        Me.TextBox_Adr1User.Location = New System.Drawing.Point(113, 110)
        Me.TextBox_Adr1User.Name = "TextBox_Adr1User"
        Me.TextBox_Adr1User.Size = New System.Drawing.Size(326, 20)
        Me.TextBox_Adr1User.TabIndex = 6
        '
        'TextBox_PrenomUser
        '
        Me.TextBox_PrenomUser.Location = New System.Drawing.Point(274, 83)
        Me.TextBox_PrenomUser.Name = "TextBox_PrenomUser"
        Me.TextBox_PrenomUser.Size = New System.Drawing.Size(165, 20)
        Me.TextBox_PrenomUser.TabIndex = 5
        '
        'TextBox_NomUser
        '
        Me.TextBox_NomUser.Location = New System.Drawing.Point(113, 83)
        Me.TextBox_NomUser.Name = "TextBox_NomUser"
        Me.TextBox_NomUser.Size = New System.Drawing.Size(155, 20)
        Me.TextBox_NomUser.TabIndex = 4
        '
        'Label_Adresse
        '
        Me.Label_Adresse.AutoSize = True
        Me.Label_Adresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Adresse.Location = New System.Drawing.Point(7, 113)
        Me.Label_Adresse.Name = "Label_Adresse"
        Me.Label_Adresse.Size = New System.Drawing.Size(51, 13)
        Me.Label_Adresse.TabIndex = 3
        Me.Label_Adresse.Text = "Adresse :"
        '
        'Label_NomPrenom
        '
        Me.Label_NomPrenom.AutoSize = True
        Me.Label_NomPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NomPrenom.Location = New System.Drawing.Point(7, 86)
        Me.Label_NomPrenom.Name = "Label_NomPrenom"
        Me.Label_NomPrenom.Size = New System.Drawing.Size(83, 13)
        Me.Label_NomPrenom.TabIndex = 2
        Me.Label_NomPrenom.Text = "Nom && Prénom :"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(10, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(429, 1)
        Me.Label3.TabIndex = 1
        '
        'Label_TitreFenetre
        '
        Me.Label_TitreFenetre.BackColor = System.Drawing.Color.SteelBlue
        Me.Label_TitreFenetre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_TitreFenetre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_TitreFenetre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TitreFenetre.Location = New System.Drawing.Point(12, 9)
        Me.Label_TitreFenetre.Name = "Label_TitreFenetre"
        Me.Label_TitreFenetre.Size = New System.Drawing.Size(559, 29)
        Me.Label_TitreFenetre.TabIndex = 17
        Me.Label_TitreFenetre.Text = "Modifier les données personnelles"
        Me.Label_TitreFenetre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 104)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'FenEditInfoPerso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Annuler)
        Me.Controls.Add(Me.Btn_OK)
        Me.Controls.Add(Me.GroupBox_InfosPerso)
        Me.Controls.Add(Me.Label_TitreFenetre)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FenEditInfoPerso"
        Me.Text = "Modifier les données personelles"
        Me.GroupBox_InfosPerso.ResumeLayout(False)
        Me.GroupBox_InfosPerso.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Annuler As Button
    Friend WithEvents Btn_OK As Button
    Friend WithEvents GroupBox_InfosPerso As GroupBox
    Friend WithEvents TextBox_Tel2User As MaskedTextBox
    Friend WithEvents TextBox_Tel1User As MaskedTextBox
    Friend WithEvents TextBox_CPUser As MaskedTextBox
    Friend WithEvents TextBox_MailUser As TextBox
    Friend WithEvents Label_Mail As Label
    Friend WithEvents Label_Telephones As Label
    Friend WithEvents TextBox_VilleUser As TextBox
    Friend WithEvents Label_CPVille As Label
    Friend WithEvents TextBox_Adr3User As TextBox
    Friend WithEvents TextBox_Adr2User As TextBox
    Friend WithEvents TextBox_Adr1User As TextBox
    Friend WithEvents TextBox_PrenomUser As TextBox
    Friend WithEvents TextBox_NomUser As TextBox
    Friend WithEvents Label_Adresse As Label
    Friend WithEvents Label_NomPrenom As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_TitreFenetre As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox_TexteInformation As TextBox
End Class
