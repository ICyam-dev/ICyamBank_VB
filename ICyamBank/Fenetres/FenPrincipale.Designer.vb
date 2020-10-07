<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FenPrincipale
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FenPrincipale))
        Me.MenuP = New System.Windows.Forms.MenuStrip()
        Me.MenuP_Fichier = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuP_FichierNouveau = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuP_FichierOuvrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuP_FichierFermer = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuP_FichierEnregistrerSous = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuP_FichierInfosPerso = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuP_FichierBackup = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuP_FichierQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuP_Comptes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuP_ComptesNewCompte = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuP_ComptesEditComptes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuP_Datas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuP_DatasTypeComptes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuP_Outils = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuP_OutilsLangues = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuP_OutilsLanguesFrench = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.StatusBarFileName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl_General = New System.Windows.Forms.TabControl()
        Me.TabPage_Syntese = New System.Windows.Forms.TabPage()
        Me.Label_TitreSynteseComptes = New System.Windows.Forms.Label()
        Me.MenuP.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.TabControl_General.SuspendLayout()
        Me.TabPage_Syntese.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuP
        '
        Me.MenuP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuP_Fichier, Me.MenuP_Comptes, Me.MenuP_Datas, Me.MenuP_Outils})
        Me.MenuP.Location = New System.Drawing.Point(0, 0)
        Me.MenuP.Name = "MenuP"
        Me.MenuP.Size = New System.Drawing.Size(948, 24)
        Me.MenuP.TabIndex = 0
        Me.MenuP.Text = "MenuStrip1"
        '
        'MenuP_Fichier
        '
        Me.MenuP_Fichier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuP_FichierNouveau, Me.MenuP_FichierOuvrir, Me.MenuP_FichierFermer, Me.MenuP_FichierEnregistrerSous, Me.ToolStripSeparator1, Me.MenuP_FichierInfosPerso, Me.ToolStripSeparator2, Me.MenuP_FichierBackup, Me.ToolStripSeparator3, Me.MenuP_FichierQuit})
        Me.MenuP_Fichier.Name = "MenuP_Fichier"
        Me.MenuP_Fichier.Size = New System.Drawing.Size(54, 20)
        Me.MenuP_Fichier.Text = "Fichier"
        '
        'MenuP_FichierNouveau
        '
        Me.MenuP_FichierNouveau.Image = CType(resources.GetObject("MenuP_FichierNouveau.Image"), System.Drawing.Image)
        Me.MenuP_FichierNouveau.Name = "MenuP_FichierNouveau"
        Me.MenuP_FichierNouveau.Size = New System.Drawing.Size(198, 22)
        Me.MenuP_FichierNouveau.Text = "Nouveau..."
        '
        'MenuP_FichierOuvrir
        '
        Me.MenuP_FichierOuvrir.Image = CType(resources.GetObject("MenuP_FichierOuvrir.Image"), System.Drawing.Image)
        Me.MenuP_FichierOuvrir.Name = "MenuP_FichierOuvrir"
        Me.MenuP_FichierOuvrir.Size = New System.Drawing.Size(198, 22)
        Me.MenuP_FichierOuvrir.Text = "Ouvrir..."
        '
        'MenuP_FichierFermer
        '
        Me.MenuP_FichierFermer.Image = CType(resources.GetObject("MenuP_FichierFermer.Image"), System.Drawing.Image)
        Me.MenuP_FichierFermer.Name = "MenuP_FichierFermer"
        Me.MenuP_FichierFermer.Size = New System.Drawing.Size(198, 22)
        Me.MenuP_FichierFermer.Text = "Fermer"
        '
        'MenuP_FichierEnregistrerSous
        '
        Me.MenuP_FichierEnregistrerSous.Image = CType(resources.GetObject("MenuP_FichierEnregistrerSous.Image"), System.Drawing.Image)
        Me.MenuP_FichierEnregistrerSous.Name = "MenuP_FichierEnregistrerSous"
        Me.MenuP_FichierEnregistrerSous.Size = New System.Drawing.Size(198, 22)
        Me.MenuP_FichierEnregistrerSous.Text = "Enregistrer sous..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(195, 6)
        '
        'MenuP_FichierInfosPerso
        '
        Me.MenuP_FichierInfosPerso.Image = CType(resources.GetObject("MenuP_FichierInfosPerso.Image"), System.Drawing.Image)
        Me.MenuP_FichierInfosPerso.Name = "MenuP_FichierInfosPerso"
        Me.MenuP_FichierInfosPerso.Size = New System.Drawing.Size(198, 22)
        Me.MenuP_FichierInfosPerso.Text = "Données Personnelles..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(195, 6)
        '
        'MenuP_FichierBackup
        '
        Me.MenuP_FichierBackup.Image = CType(resources.GetObject("MenuP_FichierBackup.Image"), System.Drawing.Image)
        Me.MenuP_FichierBackup.Name = "MenuP_FichierBackup"
        Me.MenuP_FichierBackup.Size = New System.Drawing.Size(198, 22)
        Me.MenuP_FichierBackup.Text = "Sauvegarder le fichier..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(195, 6)
        '
        'MenuP_FichierQuit
        '
        Me.MenuP_FichierQuit.Image = CType(resources.GetObject("MenuP_FichierQuit.Image"), System.Drawing.Image)
        Me.MenuP_FichierQuit.Name = "MenuP_FichierQuit"
        Me.MenuP_FichierQuit.Size = New System.Drawing.Size(198, 22)
        Me.MenuP_FichierQuit.Text = "Quitter"
        '
        'MenuP_Comptes
        '
        Me.MenuP_Comptes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuP_ComptesNewCompte, Me.MenuP_ComptesEditComptes})
        Me.MenuP_Comptes.Enabled = False
        Me.MenuP_Comptes.Name = "MenuP_Comptes"
        Me.MenuP_Comptes.Size = New System.Drawing.Size(67, 20)
        Me.MenuP_Comptes.Text = "Comptes"
        '
        'MenuP_ComptesNewCompte
        '
        Me.MenuP_ComptesNewCompte.Image = CType(resources.GetObject("MenuP_ComptesNewCompte.Image"), System.Drawing.Image)
        Me.MenuP_ComptesNewCompte.Name = "MenuP_ComptesNewCompte"
        Me.MenuP_ComptesNewCompte.Size = New System.Drawing.Size(177, 22)
        Me.MenuP_ComptesNewCompte.Text = "Nouveau Compte..."
        '
        'MenuP_ComptesEditComptes
        '
        Me.MenuP_ComptesEditComptes.Name = "MenuP_ComptesEditComptes"
        Me.MenuP_ComptesEditComptes.Size = New System.Drawing.Size(177, 22)
        Me.MenuP_ComptesEditComptes.Text = "Editer Comptes..."
        '
        'MenuP_Datas
        '
        Me.MenuP_Datas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuP_DatasTypeComptes})
        Me.MenuP_Datas.Enabled = False
        Me.MenuP_Datas.Name = "MenuP_Datas"
        Me.MenuP_Datas.Size = New System.Drawing.Size(65, 20)
        Me.MenuP_Datas.Text = "Données"
        '
        'MenuP_DatasTypeComptes
        '
        Me.MenuP_DatasTypeComptes.Name = "MenuP_DatasTypeComptes"
        Me.MenuP_DatasTypeComptes.Size = New System.Drawing.Size(174, 22)
        Me.MenuP_DatasTypeComptes.Text = "Type de Comptes..."
        '
        'MenuP_Outils
        '
        Me.MenuP_Outils.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuP_OutilsLangues})
        Me.MenuP_Outils.Enabled = False
        Me.MenuP_Outils.Name = "MenuP_Outils"
        Me.MenuP_Outils.Size = New System.Drawing.Size(50, 20)
        Me.MenuP_Outils.Text = "Outils"
        '
        'MenuP_OutilsLangues
        '
        Me.MenuP_OutilsLangues.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuP_OutilsLanguesFrench})
        Me.MenuP_OutilsLangues.Name = "MenuP_OutilsLangues"
        Me.MenuP_OutilsLangues.Size = New System.Drawing.Size(124, 22)
        Me.MenuP_OutilsLangues.Text = "Langages"
        '
        'MenuP_OutilsLanguesFrench
        '
        Me.MenuP_OutilsLanguesFrench.Checked = True
        Me.MenuP_OutilsLanguesFrench.CheckOnClick = True
        Me.MenuP_OutilsLanguesFrench.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MenuP_OutilsLanguesFrench.Enabled = False
        Me.MenuP_OutilsLanguesFrench.Name = "MenuP_OutilsLanguesFrench"
        Me.MenuP_OutilsLanguesFrench.Size = New System.Drawing.Size(110, 22)
        Me.MenuP_OutilsLanguesFrench.Text = "French"
        '
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBarFileName})
        Me.StatusBar.Location = New System.Drawing.Point(0, 516)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(948, 22)
        Me.StatusBar.TabIndex = 1
        Me.StatusBar.Text = "StatusBar"
        '
        'StatusBarFileName
        '
        Me.StatusBarFileName.Name = "StatusBarFileName"
        Me.StatusBarFileName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StatusBarFileName.Size = New System.Drawing.Size(42, 17)
        Me.StatusBarFileName.Text = "Aucun"
        '
        'TabControl_General
        '
        Me.TabControl_General.Controls.Add(Me.TabPage_Syntese)
        Me.TabControl_General.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_General.Location = New System.Drawing.Point(0, 24)
        Me.TabControl_General.Name = "TabControl_General"
        Me.TabControl_General.SelectedIndex = 0
        Me.TabControl_General.Size = New System.Drawing.Size(948, 492)
        Me.TabControl_General.TabIndex = 2
        '
        'TabPage_Syntese
        '
        Me.TabPage_Syntese.Controls.Add(Me.Label_TitreSynteseComptes)
        Me.TabPage_Syntese.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Syntese.Name = "TabPage_Syntese"
        Me.TabPage_Syntese.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Syntese.Size = New System.Drawing.Size(940, 466)
        Me.TabPage_Syntese.TabIndex = 0
        Me.TabPage_Syntese.Text = "Syntése Financière"
        Me.TabPage_Syntese.UseVisualStyleBackColor = True
        '
        'Label_TitreSynteseComptes
        '
        Me.Label_TitreSynteseComptes.BackColor = System.Drawing.Color.SteelBlue
        Me.Label_TitreSynteseComptes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_TitreSynteseComptes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label_TitreSynteseComptes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TitreSynteseComptes.Location = New System.Drawing.Point(8, 13)
        Me.Label_TitreSynteseComptes.Name = "Label_TitreSynteseComptes"
        Me.Label_TitreSynteseComptes.Size = New System.Drawing.Size(460, 29)
        Me.Label_TitreSynteseComptes.TabIndex = 20
        Me.Label_TitreSynteseComptes.Text = "Nouveau compte"
        Me.Label_TitreSynteseComptes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FenPrincipale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 538)
        Me.Controls.Add(Me.TabControl_General)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.MenuP)
        Me.MainMenuStrip = Me.MenuP
        Me.Name = "FenPrincipale"
        Me.Text = " ICyambank"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuP.ResumeLayout(False)
        Me.MenuP.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.TabControl_General.ResumeLayout(False)
        Me.TabPage_Syntese.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuP As MenuStrip
    Friend WithEvents MenuP_Fichier As ToolStripMenuItem
    Friend WithEvents StatusBar As StatusStrip
    Friend WithEvents StatusBarFileName As ToolStripStatusLabel
    Friend WithEvents MenuP_FichierNouveau As ToolStripMenuItem
    Friend WithEvents MenuP_FichierOuvrir As ToolStripMenuItem
    Friend WithEvents MenuP_FichierFermer As ToolStripMenuItem
    Friend WithEvents MenuP_FichierEnregistrerSous As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MenuP_FichierInfosPerso As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents MenuP_FichierBackup As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents MenuP_FichierQuit As ToolStripMenuItem
    Friend WithEvents MenuP_Comptes As ToolStripMenuItem
    Friend WithEvents MenuP_ComptesNewCompte As ToolStripMenuItem
    Friend WithEvents MenuP_ComptesEditComptes As ToolStripMenuItem
    Friend WithEvents MenuP_Datas As ToolStripMenuItem
    Friend WithEvents MenuP_DatasTypeComptes As ToolStripMenuItem
    Friend WithEvents MenuP_Outils As ToolStripMenuItem
    Friend WithEvents MenuP_OutilsLangues As ToolStripMenuItem
    Friend WithEvents MenuP_OutilsLanguesFrench As ToolStripMenuItem
    Friend WithEvents TabControl_General As TabControl
    Friend WithEvents TabPage_Syntese As TabPage
    Friend WithEvents Label_TitreSynteseComptes As Label
End Class
