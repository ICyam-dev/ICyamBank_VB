<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FenNewCompte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FenNewCompte))
        Me.Label_TitreFenetre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox_NewCompte = New System.Windows.Forms.GroupBox()
        Me.Label_SoldeMini = New System.Windows.Forms.Label()
        Me.TextBox_SoldeMax = New System.Windows.Forms.TextBox()
        Me.Label_SoldeMax = New System.Windows.Forms.Label()
        Me.TextBox_SoldeMini = New System.Windows.Forms.TextBox()
        Me.TextBox_SoldeOuverture = New System.Windows.Forms.TextBox()
        Me.Label_SoldeOuverture = New System.Windows.Forms.Label()
        Me.TextBox_NomCompte = New System.Windows.Forms.TextBox()
        Me.Label_NomCompte = New System.Windows.Forms.Label()
        Me.TextBox_NoCompte = New System.Windows.Forms.TextBox()
        Me.Label_NoCompte = New System.Windows.Forms.Label()
        Me.ComboBox_Groupe = New System.Windows.Forms.ComboBox()
        Me.Label_Groupe = New System.Windows.Forms.Label()
        Me.Label_Devise = New System.Windows.Forms.Label()
        Me.ComboBox_Devise = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Type = New System.Windows.Forms.ComboBox()
        Me.Label_Type = New System.Windows.Forms.Label()
        Me.Btn_Ok = New System.Windows.Forms.Button()
        Me.Btn_Annuler = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox_Remarques = New System.Windows.Forms.GroupBox()
        Me.TextBox_RemarqueCompte = New System.Windows.Forms.TextBox()
        Me.Label_ChObligatoire = New System.Windows.Forms.Label()
        Me.CheckBox_Visible = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Favori = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Actif = New System.Windows.Forms.CheckBox()
        Me.Label_ListeComboBox = New System.Windows.Forms.Label()
        Me.TextBox_Liste = New System.Windows.Forms.TextBox()
        Me.Btn_ValiderList = New System.Windows.Forms.Button()
        Me.Label_NoListe = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_NewCompte.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Remarques.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_TitreFenetre
        '
        Me.Label_TitreFenetre.BackColor = System.Drawing.Color.SteelBlue
        Me.Label_TitreFenetre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_TitreFenetre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_TitreFenetre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TitreFenetre.Location = New System.Drawing.Point(12, 9)
        Me.Label_TitreFenetre.Name = "Label_TitreFenetre"
        Me.Label_TitreFenetre.Size = New System.Drawing.Size(460, 29)
        Me.Label_TitreFenetre.TabIndex = 19
        Me.Label_TitreFenetre.Text = "Nouveau compte"
        Me.Label_TitreFenetre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'GroupBox_NewCompte
        '
        Me.GroupBox_NewCompte.Controls.Add(Me.Label_SoldeMini)
        Me.GroupBox_NewCompte.Controls.Add(Me.TextBox_SoldeMax)
        Me.GroupBox_NewCompte.Controls.Add(Me.Label_SoldeMax)
        Me.GroupBox_NewCompte.Controls.Add(Me.TextBox_SoldeMini)
        Me.GroupBox_NewCompte.Controls.Add(Me.TextBox_SoldeOuverture)
        Me.GroupBox_NewCompte.Controls.Add(Me.Label_SoldeOuverture)
        Me.GroupBox_NewCompte.Controls.Add(Me.TextBox_NomCompte)
        Me.GroupBox_NewCompte.Controls.Add(Me.Label_NomCompte)
        Me.GroupBox_NewCompte.Controls.Add(Me.TextBox_NoCompte)
        Me.GroupBox_NewCompte.Controls.Add(Me.Label_NoCompte)
        Me.GroupBox_NewCompte.Controls.Add(Me.ComboBox_Groupe)
        Me.GroupBox_NewCompte.Controls.Add(Me.Label_Groupe)
        Me.GroupBox_NewCompte.Controls.Add(Me.Label_Devise)
        Me.GroupBox_NewCompte.Controls.Add(Me.ComboBox_Devise)
        Me.GroupBox_NewCompte.Controls.Add(Me.ComboBox_Type)
        Me.GroupBox_NewCompte.Controls.Add(Me.Label_Type)
        Me.GroupBox_NewCompte.Location = New System.Drawing.Point(83, 42)
        Me.GroupBox_NewCompte.Name = "GroupBox_NewCompte"
        Me.GroupBox_NewCompte.Size = New System.Drawing.Size(389, 176)
        Me.GroupBox_NewCompte.TabIndex = 1
        Me.GroupBox_NewCompte.TabStop = False
        Me.GroupBox_NewCompte.Text = "Ajouter un compte en banque"
        '
        'Label_SoldeMini
        '
        Me.Label_SoldeMini.AutoSize = True
        Me.Label_SoldeMini.Location = New System.Drawing.Point(141, 129)
        Me.Label_SoldeMini.Name = "Label_SoldeMini"
        Me.Label_SoldeMini.Size = New System.Drawing.Size(84, 13)
        Me.Label_SoldeMini.TabIndex = 21
        Me.Label_SoldeMini.Text = "Solde Minimum :"
        '
        'TextBox_SoldeMax
        '
        Me.TextBox_SoldeMax.Location = New System.Drawing.Point(272, 146)
        Me.TextBox_SoldeMax.Name = "TextBox_SoldeMax"
        Me.TextBox_SoldeMax.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_SoldeMax.TabIndex = 20
        Me.TextBox_SoldeMax.Text = "999999.99"
        Me.TextBox_SoldeMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_SoldeMax
        '
        Me.Label_SoldeMax.AutoSize = True
        Me.Label_SoldeMax.Location = New System.Drawing.Point(269, 129)
        Me.Label_SoldeMax.Name = "Label_SoldeMax"
        Me.Label_SoldeMax.Size = New System.Drawing.Size(87, 13)
        Me.Label_SoldeMax.TabIndex = 17
        Me.Label_SoldeMax.Text = "Solde Maximum :"
        '
        'TextBox_SoldeMini
        '
        Me.TextBox_SoldeMini.Location = New System.Drawing.Point(144, 145)
        Me.TextBox_SoldeMini.Name = "TextBox_SoldeMini"
        Me.TextBox_SoldeMini.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_SoldeMini.TabIndex = 19
        Me.TextBox_SoldeMini.Text = "0.00"
        Me.TextBox_SoldeMini.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox_SoldeOuverture
        '
        Me.TextBox_SoldeOuverture.Location = New System.Drawing.Point(13, 146)
        Me.TextBox_SoldeOuverture.Name = "TextBox_SoldeOuverture"
        Me.TextBox_SoldeOuverture.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_SoldeOuverture.TabIndex = 18
        Me.TextBox_SoldeOuverture.Text = "0.00"
        Me.TextBox_SoldeOuverture.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_SoldeOuverture
        '
        Me.Label_SoldeOuverture.AutoSize = True
        Me.Label_SoldeOuverture.Location = New System.Drawing.Point(10, 129)
        Me.Label_SoldeOuverture.Name = "Label_SoldeOuverture"
        Me.Label_SoldeOuverture.Size = New System.Drawing.Size(90, 13)
        Me.Label_SoldeOuverture.TabIndex = 15
        Me.Label_SoldeOuverture.Text = "Solde Ouverture :"
        '
        'TextBox_NomCompte
        '
        Me.TextBox_NomCompte.BackColor = System.Drawing.Color.LightSalmon
        Me.TextBox_NomCompte.Location = New System.Drawing.Point(119, 18)
        Me.TextBox_NomCompte.Name = "TextBox_NomCompte"
        Me.TextBox_NomCompte.Size = New System.Drawing.Size(253, 20)
        Me.TextBox_NomCompte.TabIndex = 1
        '
        'Label_NomCompte
        '
        Me.Label_NomCompte.AutoSize = True
        Me.Label_NomCompte.Location = New System.Drawing.Point(6, 21)
        Me.Label_NomCompte.Name = "Label_NomCompte"
        Me.Label_NomCompte.Size = New System.Drawing.Size(92, 13)
        Me.Label_NomCompte.TabIndex = 11
        Me.Label_NomCompte.Text = "Nom du compte* :"
        '
        'TextBox_NoCompte
        '
        Me.TextBox_NoCompte.Location = New System.Drawing.Point(119, 98)
        Me.TextBox_NoCompte.Name = "TextBox_NoCompte"
        Me.TextBox_NoCompte.Size = New System.Drawing.Size(253, 20)
        Me.TextBox_NoCompte.TabIndex = 5
        '
        'Label_NoCompte
        '
        Me.Label_NoCompte.AutoSize = True
        Me.Label_NoCompte.Location = New System.Drawing.Point(10, 101)
        Me.Label_NoCompte.Name = "Label_NoCompte"
        Me.Label_NoCompte.Size = New System.Drawing.Size(103, 13)
        Me.Label_NoCompte.TabIndex = 9
        Me.Label_NoCompte.Text = "Numéro de compte :"
        '
        'ComboBox_Groupe
        '
        Me.ComboBox_Groupe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox_Groupe.BackColor = System.Drawing.Color.LightSalmon
        Me.ComboBox_Groupe.FormattingEnabled = True
        Me.ComboBox_Groupe.Location = New System.Drawing.Point(119, 71)
        Me.ComboBox_Groupe.Name = "ComboBox_Groupe"
        Me.ComboBox_Groupe.Size = New System.Drawing.Size(253, 21)
        Me.ComboBox_Groupe.TabIndex = 4
        '
        'Label_Groupe
        '
        Me.Label_Groupe.AutoSize = True
        Me.Label_Groupe.Location = New System.Drawing.Point(10, 74)
        Me.Label_Groupe.Name = "Label_Groupe"
        Me.Label_Groupe.Size = New System.Drawing.Size(52, 13)
        Me.Label_Groupe.TabIndex = 6
        Me.Label_Groupe.Text = "Groupe* :"
        '
        'Label_Devise
        '
        Me.Label_Devise.AutoSize = True
        Me.Label_Devise.Location = New System.Drawing.Point(234, 47)
        Me.Label_Devise.Name = "Label_Devise"
        Me.Label_Devise.Size = New System.Drawing.Size(50, 13)
        Me.Label_Devise.TabIndex = 3
        Me.Label_Devise.Text = "Devise* :"
        '
        'ComboBox_Devise
        '
        Me.ComboBox_Devise.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox_Devise.BackColor = System.Drawing.Color.LightSalmon
        Me.ComboBox_Devise.FormattingEnabled = True
        Me.ComboBox_Devise.Items.AddRange(New Object() {"Dollar ($)", "Euro (€)"})
        Me.ComboBox_Devise.Location = New System.Drawing.Point(290, 44)
        Me.ComboBox_Devise.Name = "ComboBox_Devise"
        Me.ComboBox_Devise.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox_Devise.Sorted = True
        Me.ComboBox_Devise.TabIndex = 3
        '
        'ComboBox_Type
        '
        Me.ComboBox_Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox_Type.BackColor = System.Drawing.Color.LightSalmon
        Me.ComboBox_Type.FormattingEnabled = True
        Me.ComboBox_Type.Location = New System.Drawing.Point(119, 44)
        Me.ComboBox_Type.Name = "ComboBox_Type"
        Me.ComboBox_Type.Size = New System.Drawing.Size(109, 21)
        Me.ComboBox_Type.TabIndex = 2
        '
        'Label_Type
        '
        Me.Label_Type.AutoSize = True
        Me.Label_Type.Location = New System.Drawing.Point(6, 47)
        Me.Label_Type.Name = "Label_Type"
        Me.Label_Type.Size = New System.Drawing.Size(41, 13)
        Me.Label_Type.TabIndex = 0
        Me.Label_Type.Text = "Type* :"
        '
        'Btn_Ok
        '
        Me.Btn_Ok.Location = New System.Drawing.Point(397, 384)
        Me.Btn_Ok.Name = "Btn_Ok"
        Me.Btn_Ok.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Ok.TabIndex = 14
        Me.Btn_Ok.Text = "Ok"
        Me.Btn_Ok.UseVisualStyleBackColor = True
        '
        'Btn_Annuler
        '
        Me.Btn_Annuler.Location = New System.Drawing.Point(312, 384)
        Me.Btn_Annuler.Name = "Btn_Annuler"
        Me.Btn_Annuler.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Annuler.TabIndex = 13
        Me.Btn_Annuler.Text = "Annuler"
        Me.Btn_Annuler.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(83, 384)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'GroupBox_Remarques
        '
        Me.GroupBox_Remarques.Controls.Add(Me.TextBox_RemarqueCompte)
        Me.GroupBox_Remarques.Location = New System.Drawing.Point(83, 224)
        Me.GroupBox_Remarques.Name = "GroupBox_Remarques"
        Me.GroupBox_Remarques.Size = New System.Drawing.Size(389, 154)
        Me.GroupBox_Remarques.TabIndex = 4
        Me.GroupBox_Remarques.TabStop = False
        Me.GroupBox_Remarques.Text = "Remarques"
        '
        'TextBox_RemarqueCompte
        '
        Me.TextBox_RemarqueCompte.Location = New System.Drawing.Point(13, 19)
        Me.TextBox_RemarqueCompte.Multiline = True
        Me.TextBox_RemarqueCompte.Name = "TextBox_RemarqueCompte"
        Me.TextBox_RemarqueCompte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_RemarqueCompte.Size = New System.Drawing.Size(359, 123)
        Me.TextBox_RemarqueCompte.TabIndex = 12
        Me.TextBox_RemarqueCompte.Text = " "
        '
        'Label_ChObligatoire
        '
        Me.Label_ChObligatoire.AutoSize = True
        Me.Label_ChObligatoire.BackColor = System.Drawing.SystemColors.Control
        Me.Label_ChObligatoire.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ChObligatoire.ForeColor = System.Drawing.Color.Salmon
        Me.Label_ChObligatoire.Location = New System.Drawing.Point(112, 389)
        Me.Label_ChObligatoire.Name = "Label_ChObligatoire"
        Me.Label_ChObligatoire.Size = New System.Drawing.Size(127, 13)
        Me.Label_ChObligatoire.TabIndex = 28
        Me.Label_ChObligatoire.Text = "*Champs Obligatoires"
        '
        'CheckBox_Visible
        '
        Me.CheckBox_Visible.AutoSize = True
        Me.CheckBox_Visible.Checked = True
        Me.CheckBox_Visible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Visible.Location = New System.Drawing.Point(12, 270)
        Me.CheckBox_Visible.Name = "CheckBox_Visible"
        Me.CheckBox_Visible.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox_Visible.TabIndex = 14
        Me.CheckBox_Visible.Text = "Visible"
        Me.CheckBox_Visible.UseVisualStyleBackColor = True
        '
        'CheckBox_Favori
        '
        Me.CheckBox_Favori.AutoSize = True
        Me.CheckBox_Favori.Checked = True
        Me.CheckBox_Favori.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Favori.Location = New System.Drawing.Point(12, 247)
        Me.CheckBox_Favori.Name = "CheckBox_Favori"
        Me.CheckBox_Favori.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox_Favori.TabIndex = 13
        Me.CheckBox_Favori.Text = "Favori"
        Me.CheckBox_Favori.UseVisualStyleBackColor = True
        '
        'CheckBox_Actif
        '
        Me.CheckBox_Actif.AutoSize = True
        Me.CheckBox_Actif.Checked = True
        Me.CheckBox_Actif.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Actif.Location = New System.Drawing.Point(12, 224)
        Me.CheckBox_Actif.Name = "CheckBox_Actif"
        Me.CheckBox_Actif.Size = New System.Drawing.Size(47, 17)
        Me.CheckBox_Actif.TabIndex = 12
        Me.CheckBox_Actif.Text = "Actif"
        Me.CheckBox_Actif.UseVisualStyleBackColor = True
        '
        'Label_ListeComboBox
        '
        Me.Label_ListeComboBox.BackColor = System.Drawing.Color.SteelBlue
        Me.Label_ListeComboBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_ListeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_ListeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ListeComboBox.Location = New System.Drawing.Point(489, 9)
        Me.Label_ListeComboBox.Name = "Label_ListeComboBox"
        Me.Label_ListeComboBox.Size = New System.Drawing.Size(233, 29)
        Me.Label_ListeComboBox.TabIndex = 29
        Me.Label_ListeComboBox.Text = " "
        Me.Label_ListeComboBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_Liste
        '
        Me.TextBox_Liste.Location = New System.Drawing.Point(489, 42)
        Me.TextBox_Liste.Multiline = True
        Me.TextBox_Liste.Name = "TextBox_Liste"
        Me.TextBox_Liste.Size = New System.Drawing.Size(233, 336)
        Me.TextBox_Liste.TabIndex = 30
        '
        'Btn_ValiderList
        '
        Me.Btn_ValiderList.Location = New System.Drawing.Point(647, 384)
        Me.Btn_ValiderList.Name = "Btn_ValiderList"
        Me.Btn_ValiderList.Size = New System.Drawing.Size(75, 23)
        Me.Btn_ValiderList.TabIndex = 31
        Me.Btn_ValiderList.Text = "Valider"
        Me.Btn_ValiderList.UseVisualStyleBackColor = True
        '
        'Label_NoListe
        '
        Me.Label_NoListe.AutoSize = True
        Me.Label_NoListe.Location = New System.Drawing.Point(486, 389)
        Me.Label_NoListe.Name = "Label_NoListe"
        Me.Label_NoListe.Size = New System.Drawing.Size(13, 13)
        Me.Label_NoListe.TabIndex = 32
        Me.Label_NoListe.Text = "0"
        Me.Label_NoListe.Visible = False
        '
        'FenNewCompte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 420)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label_NoListe)
        Me.Controls.Add(Me.Btn_ValiderList)
        Me.Controls.Add(Me.TextBox_Liste)
        Me.Controls.Add(Me.Label_ListeComboBox)
        Me.Controls.Add(Me.Label_ChObligatoire)
        Me.Controls.Add(Me.GroupBox_Remarques)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Btn_Annuler)
        Me.Controls.Add(Me.Btn_Ok)
        Me.Controls.Add(Me.GroupBox_NewCompte)
        Me.Controls.Add(Me.CheckBox_Visible)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBox_Favori)
        Me.Controls.Add(Me.Label_TitreFenetre)
        Me.Controls.Add(Me.CheckBox_Actif)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FenNewCompte"
        Me.Text = "Nouveau compte"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_NewCompte.ResumeLayout(False)
        Me.GroupBox_NewCompte.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Remarques.ResumeLayout(False)
        Me.GroupBox_Remarques.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_TitreFenetre As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox_NewCompte As GroupBox
    Friend WithEvents ComboBox_Groupe As ComboBox
    Friend WithEvents Label_Groupe As Label
    Friend WithEvents Label_Devise As Label
    Friend WithEvents ComboBox_Devise As ComboBox
    Friend WithEvents ComboBox_Type As ComboBox
    Friend WithEvents Label_Type As Label
    Friend WithEvents TextBox_NoCompte As TextBox
    Friend WithEvents Label_NoCompte As Label
    Friend WithEvents Btn_Ok As Button
    Friend WithEvents Btn_Annuler As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox_NomCompte As TextBox
    Friend WithEvents Label_NomCompte As Label
    Friend WithEvents GroupBox_Remarques As GroupBox
    Friend WithEvents TextBox_RemarqueCompte As TextBox
    Friend WithEvents Label_ChObligatoire As Label
    Friend WithEvents Label_SoldeMini As Label
    Friend WithEvents TextBox_SoldeMax As TextBox
    Friend WithEvents Label_SoldeMax As Label
    Friend WithEvents TextBox_SoldeMini As TextBox
    Friend WithEvents TextBox_SoldeOuverture As TextBox
    Friend WithEvents Label_SoldeOuverture As Label
    Friend WithEvents CheckBox_Visible As CheckBox
    Friend WithEvents CheckBox_Favori As CheckBox
    Friend WithEvents CheckBox_Actif As CheckBox
    Friend WithEvents Label_ListeComboBox As Label
    Friend WithEvents TextBox_Liste As TextBox
    Friend WithEvents Btn_ValiderList As Button
    Friend WithEvents Label_NoListe As Label
End Class
