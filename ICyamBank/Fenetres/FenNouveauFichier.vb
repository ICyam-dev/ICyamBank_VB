Imports System.Data.SQLite
Imports System.IO
Public Class FenNouveauFichier
    'Déclaration de la connextion
    Dim maConnectionUser As New SQLiteConnection
    'Langage de l'interface
    Dim langageApp As String = My.Settings.k_langueApp
    Private Sub Btn_Annuler_Click(sender As Object, e As EventArgs) Handles Btn_Annuler.Click
        'Fermeture de la fenetre
        Me.Close()
    End Sub

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_OK.Click
        'Test de la cohérence de la fenetre le Nom et le Prenom est obligatoire
        If TextBox_PrenomUser.Text = "" Or TextBox_NomUser.Text = "" Then
            MsgBox(translateText(35, langageApp)) 'Message d'avertissement pour le nom et le premon obligatoire
            Exit Sub
        End If

        'Fixe la nouvelle hauteur de la fenetre
        Me.Height = 520

        'Déactivation de deux bouton
        Btn_Annuler.Enabled = False
        Btn_OK.Enabled = False

        Btn_Valider.Focus()

        'Donne le répertoire par default et le nom du fichier
        Dim folderDefault As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\ICyamBank\" + TextBox_PrenomUser.Text + TextBox_NomUser.Text + "\"
        Dim fichierBDD As String = TextBox_PrenomUser.Text + TextBox_NomUser.Text + ".icb"
        TextBox_FolderDossier.Text = folderDefault
        TextBox_fichierBDD.Text = fichierBDD
    End Sub
    Public Sub connexionBDUser(ByVal dataBase As String)

        'Teste l'état de la Connexion
        If maConnectionUser.State = ConnectionState.Closed Then
            Try
                maConnectionUser.ConnectionString = "Data Source=" & dataBase
                maConnectionUser.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub FenNouveauFichier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fixe la hauteur de la fenetre
        Me.Height = 390

        'Traduction de la fenetre
        traduireForm()

    End Sub

    Private Sub Btn_ChoixDossier_Click(sender As Object, e As EventArgs) Handles Btn_ChoixDossier.Click
        'Modification du dossier par default
        Dim fichierBDD As New SaveFileDialog
        fichierBDD.InitialDirectory = TextBox_FolderDossier.Text
        fichierBDD.Filter = "Fichiers ICyamBank (*.icb)|*.icb"
        fichierBDD.FileName = TextBox_fichierBDD.Text
        If fichierBDD.ShowDialog() = 1 Then 'Si cliqué sur "OK"
            TextBox_fichierBDD.Text = Strings.Right(fichierBDD.FileName, Len(fichierBDD.FileName) - InStrRev(fichierBDD.FileName, "\"))
            TextBox_FolderDossier.Text = Strings.Left(fichierBDD.FileName, Len(fichierBDD.FileName) - (Len(fichierBDD.FileName) - InStrRev(fichierBDD.FileName, "\"))) + "ICyamBank\" + TextBox_PrenomUser.Text + TextBox_NomUser.Text + "\"
        End If
    End Sub

    Private Sub Btn_Valider_Click(sender As Object, e As EventArgs) Handles Btn_Valider.Click
        'Création du fichier

        My.Computer.FileSystem.CreateDirectory(TextBox_FolderDossier.Text) 'Création du dossier

        File.Copy("ICyamBank.db", TextBox_FolderDossier.Text + TextBox_fichierBDD.Text)
        'File.WriteAllBytes(TextBox_FolderDossier.Text + TextBox_fichierBDD.Text, My.) 'Copie depuis les ressources
        FenPrincipale.StatusBarFileName.Text = TextBox_FolderDossier.Text + TextBox_fichierBDD.Text 'Inscription du fichier dans la barre de status de la fenetre principale
        'Insertion de l'enregistrement dans la base de données
        Dim dataBase As String = TextBox_FolderDossier.Text + TextBox_fichierBDD.Text
        connexionBDUser(dataBase)
        Dim cmdSQL As New SQLiteCommand("INSERT INTO tableUser 
        (nomUser,prenomUser,adr1User,adr2User,adr3User,cpUser,villeUser,tel1User,tel2User,mailUser,password) VALUES
        (@mNomUser,@mPrenomUser,@mAdr1User,@mAdr2User,@mAdr3User,@mCPUser,@mVilleUser,@mTel1User,@mTel2User,@mMailUser,@mpwdUser)", maConnectionUser)
        cmdSQL.Parameters.AddWithValue("@mNomUser", TextBox_NomUser.Text)
        cmdSQL.Parameters.AddWithValue("@mPrenomUser", TextBox_PrenomUser.Text)
        cmdSQL.Parameters.AddWithValue("@mAdr1User", TextBox_Adr1User.Text)
        cmdSQL.Parameters.AddWithValue("@mAdr2User", TextBox_Adr2User.Text)
        cmdSQL.Parameters.AddWithValue("@mAdr3User", TextBox_Adr3User.Text)
        cmdSQL.Parameters.AddWithValue("@mCPUser", TextBox_CPUser.Text)
        cmdSQL.Parameters.AddWithValue("@mVilleUser", TextBox_VilleUser.Text)
        cmdSQL.Parameters.AddWithValue("@mTel1User", TextBox_Tel1User.Text)
        cmdSQL.Parameters.AddWithValue("@mTel2User", TextBox_Tel2User.Text)
        cmdSQL.Parameters.AddWithValue("@mMailUser", TextBox_MailUser.Text)
        cmdSQL.Parameters.AddWithValue("@mpwdUser", "")
        cmdSQL.ExecuteNonQuery()
        cmdSQL.Parameters.Clear()

        Me.Close()
    End Sub

    Private Sub traduireForm()
        'Traduction du formulaire
        Me.Text = translateText(19, langageApp)
        Label_TitreFenetre.Text = translateText(20, langageApp)
        GroupBox_InfosPersonnelles.Text = translateText(21, langageApp)
        TextBox_TexteInformation.Text = translateText(22, langageApp)
        Label_NomPrenom.Text = translateText(23, langageApp)
        Label_Adresse.Text = translateText(24, langageApp)
        Label_CPVille.Text = translateText(25, langageApp)
        Label_Telephones.Text = translateText(26, langageApp)
        Label_Mail.Text = translateText(27, langageApp)
        Label_ChampsObligatoire.Text = translateText(28, langageApp)
        Btn_Annuler.Text = translateText(29, langageApp)
        Btn_OK.Text = translateText(30, langageApp)
        GroupBox_SaveDossier.Text = translateText(31, langageApp)
        Label_ChDuDossier.Text = translateText(32, langageApp)
        Label_NomDossier.Text = translateText(33, langageApp)
        Btn_Valider.Text = translateText(34, langageApp)
    End Sub
End Class