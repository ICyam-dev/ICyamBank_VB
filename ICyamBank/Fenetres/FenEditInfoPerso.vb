Imports System.Data.SQLite
Imports System.IO
Public Class FenEditInfoPerso
    'Déclaration de la connextion
    Dim maConnectionUser As New SQLiteConnection
    'Langage de l'interface
    Dim langageApp As String = My.Settings.k_langueApp
    Private Sub FenEditInfoPerso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Traduction du formulaire
        traduireForm()

        'Récupération des données de la base de données
        Dim dataBase As String = FenPrincipale.StatusBarFileName.Text 'Récupération du chemin d'accés à la base de données
        connexionBDUser(dataBase) 'Connexion à la base de données
        Dim cmdSQL As New SQLiteCommand("SELECT * FROM tableUser WHERE (idUser=1)", maConnectionUser)
        Using lecture As SQLiteDataReader = cmdSQL.ExecuteReader() 'Exécution de la requete SQL
            While lecture.Read()
                TextBox_NomUser.Text = lecture("nomUser")
                TextBox_PrenomUser.Text = lecture("prenomUser")
                TextBox_Adr1User.Text = lecture("adr1User")
                TextBox_Adr2User.Text = lecture("adr2User")
                TextBox_Adr3User.Text = lecture("adr3User")
                TextBox_CPUser.Text = lecture("cpUser")
                TextBox_VilleUser.Text = lecture("villeUser")
                TextBox_Tel1User.Text = lecture("tel1User")
                TextBox_Tel2User.Text = lecture("tel2User")
                TextBox_MailUser.Text = lecture("mailUser")
            End While
        End Using
        cmdSQL.Parameters.Clear()
    End Sub
    Private Sub connexionBDUser(ByVal dataBase As String)

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

    Private Sub Btn_Annuler_Click(sender As Object, e As EventArgs) Handles Btn_Annuler.Click
        'Fermeture de la fenetre
        Me.Close()
    End Sub

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_OK.Click
        'Modification de l'enregistrement dans la base de données
        Dim dataBase As String = FenPrincipale.StatusBarFileName.Text 'Récupération du chemin d'accés à la base de données
        connexionBDUser(dataBase)
        Dim cmdSQL As New SQLiteCommand("UPDATE tableUser SET nomUser=@mNomUser,prenomUser=@mPrenomUser,adr1User=@mAdr1User,adr2User=@mAdr2User,adr3User=@mAdr3User,
        cpUser=@mCPUser,villeUser=@mVilleUser,tel1User=@mTel1User,tel2User=@mTel2User,mailUser=@mMailUser WHERE idUser=1", maConnectionUser)
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
        cmdSQL.ExecuteNonQuery()
        cmdSQL.Parameters.Clear()

        'Sortir de la fenetre
        Me.Close()
    End Sub

    Private Sub traduireForm()
        'Traduction du formulaire
        Me.Text = translateText(36, langageApp)
        Label_TitreFenetre.Text = translateText(37, langageApp)
        GroupBox_InfosPerso.Text = translateText(38, langageApp)
        TextBox_TexteInformation.Text = translateText(39, langageApp)
        Label_NomPrenom.Text = translateText(40, langageApp)
        Label_Adresse.Text = translateText(41, langageApp)
        Label_CPVille.Text = translateText(42, langageApp)
        Label_Telephones.Text = translateText(43, langageApp)
        Label_Mail.Text = translateText(44, langageApp)
        Btn_Annuler.Text = translateText(45, langageApp)
        Btn_OK.Text = translateText(46, langageApp)
    End Sub
End Class