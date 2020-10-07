Imports System.Data.SQLite
Imports System.IO

Public Class FenPrincipale
    'Langage de l'interface
    Dim langageApp As String = My.Settings.k_langueApp
    Private Sub FenPrincipale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Mise en place des éléemnts dans l'onglet 1
        Label_TitreSynteseComptes.Width = TabControl_General.Width * 45 / 100 '45% de la largeur de la fenetre

        'Traduction de la fenetre
        traduireForm()

        'Vérification de la présence de fichier icb_setup_file.ini dans le répertoire racine de l'application
        'qui recence les 10 derniers fichiers ouverts
        'Si pas présent, le créer
        '

        Dim fichierFilesIni As String = "icb_setup_file.ini"
        If File.Exists(fichierFilesIni) = False Then 'Si pas présent
            File.Copy("icyambank_setup.ini", fichierFilesIni)
            'File.WriteAllText(fichierFilesIni, My.Resources.icyambank_setup) 'Copie depuis les ressources
            'Ecriture de l'étiquette File:
            FileOpen(1, fichierFilesIni, OpenMode.Output)
            WriteLine(1, "File:")
            FileClose(1)
        End If

        'Lecture du fichier icb_setup_file.ini
        Dim lastFile As String = "" 'Chaine de string représentant le dernier fichier ouvert
        FileOpen(1, fichierFilesIni, OpenMode.Input)
        While Not EOF(1)
            lastFile = LineInput(1) 'Lecture de la ligne
            lastFile = Mid(lastFile, 2, Len(lastFile) - 2) 'Suppression des double cote ""
        End While
        FileClose(1)
        'MsgBox(lastFile)
        If lastFile = "File:" Then 'aucun fichier récement ouvert donc création d'un fichier
            'Création d'un nouvel Utilisateur
            FenNouveauFichier.ShowDialog()
            setupFileIni()
        Else
            StatusBarFileName.Text = lastFile
        End If
    End Sub

    Private Sub StatusBarFileName_TextChanged(sender As Object, e As EventArgs) Handles StatusBarFileName.TextChanged
        'Evenement si fichier en cours d'utilisation OK
        If StatusBarFileName.Text <> "Aucun" Then 'si OK
            'MenuPrincipal Fichier
            MenuP_FichierNouveau.Enabled = True
            MenuP_FichierOuvrir.Enabled = True
            MenuP_FichierEnregistrerSous.Enabled = True
            MenuP_FichierFermer.Enabled = True
            MenuP_FichierInfosPerso.Enabled = True
            MenuP_FichierBackup.Enabled = True
            MenuP_FichierQuit.Enabled = True
            MenuP_Comptes.Enabled = True
            MenuP_Datas.Enabled = True
            MenuP_Outils.Enabled = True
        ElseIf StatusBarFileName.Text = "Aucun" Then 'si KO
            'MenuPrincipal Fichier
            MenuP_FichierNouveau.Enabled = True
            MenuP_FichierOuvrir.Enabled = True
            MenuP_FichierEnregistrerSous.Enabled = False
            MenuP_FichierFermer.Enabled = False
            MenuP_FichierInfosPerso.Enabled = False
            MenuP_FichierBackup.Enabled = False
            MenuP_FichierQuit.Enabled = True
            MenuP_Comptes.Enabled = False
            MenuP_Datas.Enabled = False
            MenuP_Outils.Enabled = False
        End If
    End Sub

    Private Sub MenuP_FichierFermer_Click(sender As Object, e As EventArgs) Handles MenuP_FichierFermer.Click
        'Fermeture d'un fichier
        StatusBarFileName.Text = "Aucun"
    End Sub

    Private Sub MenuP_FichierOuvrir_Click(sender As Object, e As EventArgs) Handles MenuP_FichierOuvrir.Click
        'Ouverture d'une fichier
        Dim openFile As New OpenFileDialog
        openFile.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        openFile.Filter = "Fichiers ICyamBank (*.icb)|*.icb"
        If openFile.ShowDialog() = 1 Then
            StatusBarFileName.Text = openFile.FileName 'On inscris le fichier ouvert dans la barre de status
        End If
    End Sub

    Private Sub MenuP_FichierBackup_Click(sender As Object, e As EventArgs) Handles MenuP_FichierBackup.Click
        'créer un fichier de backup de la base de données
        Dim backupFile As New SaveFileDialog
        backupFile.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim dateDuJour As String = Date.Now
        dateDuJour = Replace(dateDuJour, "/", "-") 'Remplacement des "/" par des "-" pour la date
        dateDuJour = Replace(dateDuJour, ":", "") 'Remplacement des ":" par des "" pour l'heure
        dateDuJour = Replace(dateDuJour, " ", "_") 'Remplacement des " " par des "_"
        'MsgBox(dateDuJour)
        backupFile.FileName = "BACKUP_ICYAMBANK_DU_" + dateDuJour + ".icbbackup"
        backupFile.Filter = "Fichier Backup|*.icbbackup"
        If backupFile.ShowDialog() = 1 Then
            File.Copy(StatusBarFileName.Text, backupFile.FileName) 'Copie le fichier d'origine
        End If
    End Sub

    Private Sub MenuP_FichierQuit_Click(sender As Object, e As EventArgs) Handles MenuP_FichierQuit.Click
        'Quitter l'application
        Me.Close()
    End Sub

    Private Sub MenuP_FichierEnregistrerSous_Click(sender As Object, e As EventArgs) Handles MenuP_FichierEnregistrerSous.Click
        'enregistrer les fichier sous un autre nom
        Dim saveFile As New SaveFileDialog
        saveFile.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        saveFile.FileName = "AutreNom.icb"
        saveFile.Filter = "Fichier ICyamBank (*.icb)|*.icb"
        If saveFile.ShowDialog() = 1 Then
            File.Copy(StatusBarFileName.Text, saveFile.FileName) 'Copie le fichier d'origine
            StatusBarFileName.Text = saveFile.FileName
            setupFileIni()
            'Effacement de l'ancien fichier à l'initiative de l'utilisateur via l'explorateur de son OS
        End If
    End Sub

    Private Sub MenuP_FichierInfosPerso_Click(sender As Object, e As EventArgs) Handles MenuP_FichierInfosPerso.Click
        'Editer les données personnelles
        FenEditInfoPerso.ShowDialog()
    End Sub

    Private Sub MenuP_FichierNouveau_Click(sender As Object, e As EventArgs) Handles MenuP_FichierNouveau.Click
        'Création d'un nouveau fichier
        FenNouveauFichier.ShowDialog()
        setupFileIni()
    End Sub
    Private Sub setupFileIni()
        'Inscription du nouveau fichier dans icb_setup_file.ini
        Dim fichierFilesIni As String = "icb_setup_file.ini"
        FileOpen(1, fichierFilesIni, OpenMode.Output)
        WriteLine(1, "File:")
        WriteLine(1, StatusBarFileName.Text)
        FileClose(1)
    End Sub

    Private Sub traduireForm()
        'Traduction de la fenetre via la fonction globale Function translateText(ByVal ligneFichier As Integer, ByVal langApp As String) As String
        'Menu Principal
        MenuP_Fichier.Text = translateText(1, langageApp)
        MenuP_FichierNouveau.Text = translateText(2, langageApp)
        MenuP_FichierOuvrir.Text = translateText(3, langageApp)
        MenuP_FichierFermer.Text = translateText(4, langageApp)
        MenuP_FichierEnregistrerSous.Text = translateText(5, langageApp)
        MenuP_FichierInfosPerso.Text = translateText(6, langageApp)
        MenuP_FichierBackup.Text = translateText(7, langageApp)
        MenuP_FichierQuit.Text = translateText(8, langageApp)
        MenuP_Comptes.Text = translateText(9, langageApp)
        MenuP_ComptesNewCompte.Text = translateText(12, langageApp)
        MenuP_ComptesEditComptes.Text = translateText(13, langageApp)
        MenuP_Datas.Text = translateText(14, langageApp)
        MenuP_DatasTypeComptes.Text = translateText(15, langageApp)
        MenuP_Outils.Text = translateText(17, langageApp)
        MenuP_OutilsLangues.Text = translateText(18, langageApp)
        'Onglet "Syntése Financiere
        TabPage_Syntese.Text = translateText(10, langageApp)
        Label_TitreSynteseComptes.Text = translateText(11, langageApp)

        'Barre de status
        StatusBarFileName.Text = translateText(16, langageApp)
    End Sub

    Private Sub MenuP_ComptesNewCompte_Click(sender As Object, e As EventArgs) Handles MenuP_ComptesNewCompte.Click
        'Ouverture de la fenetre Nouveau Compte
        FenNewCompte.ShowDialog()
    End Sub

    Private Sub FenPrincipale_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'Mise en place des éléemnts dans l'onglet 1
        Label_TitreSynteseComptes.Width = TabControl_General.Width * 45 / 100 '45% de la largeur de la fenetre
    End Sub
End Class
