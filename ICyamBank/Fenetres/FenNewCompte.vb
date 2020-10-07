Imports System.Data.SQLite
Imports System.IO
Public Class FenNewCompte
    'Déclaration de la connextion
    Dim maConnectionUser As New SQLiteConnection
    'Langage de l'interface
    Dim langageApp As String = My.Settings.k_langueApp
    Private Sub Btn_Annuler_Click(sender As Object, e As EventArgs) Handles Btn_Annuler.Click
        'Fermeture de la fenetre
        Me.Close()
    End Sub

    Private Sub FenNewCompte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Traduction de la fenetre
        traduireForm()

        'Clean les Textbox
        TextBox_NomCompte.Text = ""
        TextBox_NoCompte.Text = ""
        TextBox_RemarqueCompte.Text = ""
        TextBox_Liste.Text = ""
        TextBox_SoldeOuverture.Text = "0"
        TextBox_SoldeMini.Text = "0"
        TextBox_SoldeMax.Text = "999999999"
        CheckBox_Actif.Checked = True
        CheckBox_Favori.Checked = True
        CheckBox_Visible.Checked = True

        'Formater la fenetre sur un largeur à 500px
        Me.Width = 500

        'Traitement des ComboBox qu'il faut remplir en fonction de ce qui est présent dans les tables correspondantes
        '
        'Traitement de la comboBox Type de compte (Epargne, courant, carte de crédit, etc...)
        listTypeCompte()
        '
        'Traitement de la comboBox Groupe de compte (Groupe comptes courant, ou groupe CIC par exemple)
        listGroupCompte()
        '
        'Traitement de la combobox Devise, Table près-remplis avec les devises connues et courantes
        ComboBox_Devise.Items.Clear()
        Dim dataBase As String = FenPrincipale.StatusBarFileName.Text 'Récupération du chemin d'accés à la base de données
        connexionBDUser(dataBase) 'Connexion à la base de données
        Dim cmdSQL As New SQLiteCommand("SELECT * FROM tableDevise", maConnectionUser)
        Using lecture As SQLiteDataReader = cmdSQL.ExecuteReader() 'Exécution de la requete SQL
            While lecture.Read()
                ComboBox_Devise.Items.Add(lecture("texte"))
            End While
        End Using
        cmdSQL.Parameters.Clear()
    End Sub
    Private Sub traduireForm()
        'Traduition des label et des textbox
        Me.Text = translateText(47, langageApp)
        Label_TitreFenetre.Text = translateText(48, langageApp)
        GroupBox_NewCompte.Text = translateText(49, langageApp)
        Label_NomCompte.Text = translateText(50, langageApp)
        Label_Type.Text = translateText(51, langageApp)
        Label_Devise.Text = translateText(52, langageApp)
        Label_Groupe.Text = translateText(53, langageApp)
        Label_NoCompte.Text = translateText(54, langageApp)
        CheckBox_Actif.Text = translateText(56, langageApp)
        CheckBox_Favori.Text = translateText(57, langageApp)
        CheckBox_Visible.Text = translateText(58, langageApp)
        Label_SoldeOuverture.Text = translateText(60, langageApp)
        Label_SoldeMini.Text = translateText(61, langageApp)
        Label_SoldeMax.Text = translateText(62, langageApp)
        GroupBox_Remarques.Text = translateText(63, langageApp)
        Label_ChObligatoire.Text = translateText(64, langageApp)
        Btn_Annuler.Text = translateText(65, langageApp)
        Btn_Ok.Text = translateText(66, langageApp)
        Btn_ValiderList.Text = translateText(67, langageApp)
    End Sub

    Private Sub Btn_PlusGroup_Click(sender As Object, e As EventArgs)
        'Ouverture de la fenetre Liste des type
        'FenTypeCompte.ShowDialog()
        ComboBox_Type.Items.Add(ComboBox_Type.Text)
    End Sub
    Private Sub listTypeCompte()
        'Traitement de la comboBox Type de compte (Epargne, courant, carte de crédit, etc...)
        ComboBox_Type.Items.Clear() 'On vide la combo
        ComboBox_Type.Items.Add(translateText(55, langageApp)) 'Premiere option des différentes ComboBox qui premettra d'accésder au remplissage personnalisé de la combo en question
        Dim dataBase As String = FenPrincipale.StatusBarFileName.Text 'Récupération du chemin d'accés à la base de données
        connexionBDUser(dataBase) 'Connexion à la base de données
        Dim cmdSQL As New SQLiteCommand("SELECT * FROM tableTypeCompte", maConnectionUser)
        Using lecture As SQLiteDataReader = cmdSQL.ExecuteReader() 'Exécution de la requete SQL
            While lecture.Read()
                ComboBox_Type.Items.Add(lecture("texte"))
            End While
        End Using
        cmdSQL.Parameters.Clear()
        ComboBox_Type.Text = ""
    End Sub
    Private Sub listGroupCompte()
        'Traitement de la comboBox Groupe de compte (Groupe comptes courant, ou groupe CIC par exemple)
        ComboBox_Groupe.Items.Clear() 'On vide la combo
        ComboBox_Groupe.Items.Add(translateText(55, langageApp)) 'Premiere option des différentes ComboBox qui premettra d'accésder au remplissage personnalisé de la combo en question
        Dim dataBase As String = FenPrincipale.StatusBarFileName.Text 'Récupération du chemin d'accés à la base de données
        connexionBDUser(dataBase) 'Connexion à la base de données
        Dim cmdSQL As New SQLiteCommand("SELECT * FROM tableGroupCompte", maConnectionUser)
        Using lecture As SQLiteDataReader = cmdSQL.ExecuteReader() 'Exécution de la requete SQL
            While lecture.Read()
                ComboBox_Groupe.Items.Add(lecture("texte"))
            End While
        End Using
        cmdSQL.Parameters.Clear()
        ComboBox_Groupe.Text = ""
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

    Private Sub ComboBox_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Type.SelectedIndexChanged
        'Test de l'Items sélectionne
        If ComboBox_Type.SelectedIndex = 0 Then 'Si l'item sélectionné est le premier <ma liste>

            'Numéro de liste en cours de traitement 
            Label_NoListe.Text = "1"

            Label_ListeComboBox.Text = translateText(59, langageApp) 'Titre du label dans la fenetre
            Me.Width = 750 'Elargissement de la fenetre

            'désactivation des bouton de validation et d'annulation
            Btn_Annuler.Enabled = False
            Btn_Ok.Enabled = False

            'Lire la liste dans la combobox correspondante et compléter la textbox
            For i As Integer = 1 To ComboBox_Type.Items.Count - 1
                TextBox_Liste.Text = TextBox_Liste.Text + ComboBox_Type.Items(i) + Chr(13)
            Next
        End If
    End Sub

    Private Sub Btn_ValiderList_Click(sender As Object, e As EventArgs) Handles Btn_ValiderList.Click
        'Test du Numéro de liste à traiter
        If Label_NoListe.Text = "1" Then 'Si la liste est la liste des type de compte :

            'Traiter la table dans la banse de données
            Dim dataBase As String = FenPrincipale.StatusBarFileName.Text 'Récupération du chemin d'accés à la base de données
            connexionBDUser(dataBase) 'Connexion à la base de données

            'Suppression complete de la table
            Dim cmdSQL As New SQLiteCommand("DELETE FROM tableTypeCompte", maConnectionUser)
            cmdSQL.ExecuteNonQuery()

            'MsgBox(TextBox_Liste.Text)

            'Identifier les différents éléments et les mettre dans un tableau lesTypes()
            Dim leTexte As String = TextBox_Liste.Text
            Dim lesTypes() As String = leTexte.Split(New String() {Chr(13)}, StringSplitOptions.RemoveEmptyEntries) 'séparer avec CHR(13)

            'Mettre à jour les nouvelles données dans la table
            cmdSQL = New SQLiteCommand("INSERT INTO tableTypeCompte (texte) VALUEs (@mTexte)", maConnectionUser)
            For Each type As String In lesTypes
                cmdSQL.Parameters.AddWithValue("@mTexte", type)
                cmdSQL.ExecuteNonQuery()
                cmdSQL.Parameters.Clear()
            Next

            'Mettre à jour la combobox
            listTypeCompte()


        ElseIf Label_NoListe.Text = "2" Then 'Si la liste est la liste des groupe de compte :

            'Traiter la table dans la banse de données
            Dim dataBase As String = FenPrincipale.StatusBarFileName.Text 'Récupération du chemin d'accés à la base de données
            connexionBDUser(dataBase) 'Connexion à la base de données

            'Suppression complete de la table
            Dim cmdSQL As New SQLiteCommand("DELETE FROM tableGroupCompte", maConnectionUser)
            cmdSQL.ExecuteNonQuery()

            'MsgBox(TextBox_Liste.Text)

            'Identifier les différents éléments et les mettre dans un tableau lesTypes()
            Dim leTexte As String = TextBox_Liste.Text
            Dim lesTypes() As String = leTexte.Split(New String() {Chr(13)}, StringSplitOptions.RemoveEmptyEntries) 'séparer avec CHR(13)

            'Mettre à jour les nouvelles données dans la table
            cmdSQL = New SQLiteCommand("INSERT INTO tableGroupCompte (texte) VALUEs (@mTexte)", maConnectionUser)
            For Each type As String In lesTypes
                cmdSQL.Parameters.AddWithValue("@mTexte", type)
                cmdSQL.ExecuteNonQuery()
                cmdSQL.Parameters.Clear()
            Next

            'Mettre à jour la combobox
            listGroupCompte()

        End If

        Label_NoListe.Text = "0" 'Remettre la liste en cours de traitement à 0

        'Revalider les boutons
        Btn_Annuler.Enabled = True
        Btn_Ok.Enabled = True

        'Reduite la fenetre
        Me.Width = 500
    End Sub

    Private Sub ComboBox_Groupe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Groupe.SelectedIndexChanged
        'Test de l'Items sélectionne
        If ComboBox_Groupe.SelectedIndex = 0 Then 'Si l'item sélectionné est le premier <ma liste>

            'Numéro de liste en cours de traitement 
            Label_NoListe.Text = "2"

            Label_ListeComboBox.Text = translateText(68, langageApp) 'Titre du label dans la fenetre
            Me.Width = 750 'Elargissement de la fenetre

            'désactivation des bouton de validation et d'annulation
            Btn_Annuler.Enabled = False
            Btn_Ok.Enabled = False

            'Lire la liste dans la combobox correspondante et compléter la textbox
            For i As Integer = 1 To ComboBox_Groupe.Items.Count - 1
                TextBox_Liste.Text = TextBox_Liste.Text + ComboBox_Groupe.Items(i) + Chr(13)
            Next
        End If
    End Sub

    Private Sub Btn_Ok_Click(sender As Object, e As EventArgs) Handles Btn_Ok.Click
        'Test de la cohérence du formulaire (Champs Obligatoires)
        If TextBox_NomCompte.Text <> "" And ComboBox_Type.Text <> "" And ComboBox_Devise.Text <> "" And ComboBox_Groupe.Text <> "" Then
            'Enregsitrement du nouveau compte dans la table de la base de données
            Dim cmdSQL As New SQLiteCommand("INSERT INTO tableCompte (nomCompte,groupCompte,typeCompte,deviseCompte,noCompte,soldeOuvertureCompte,soldeMinCompte,
                                            soldeMaxCompte,soldeReelCompte,soldeConsoCompte,actifCompte,favoriCompte,afficherCompte,rqCompte)
                                            VALUES (@mnomCompte,@mgroupCompte,@mtypeCompte,@mdeviseCompte,@mnoCompte,@msoldeOuvertureCompte,@msoldeMinCompte,
                                            @msoldeMaxCompte,@msoldeReelCompte,@msoldeConsoCompte,@mactifCompte,@mfavoriCompte,@mafficherCompte,@mrqCompte)", maConnectionUser)
            cmdSQL.Parameters.AddWithValue("@mnomCompte", TextBox_NomCompte.Text)
            cmdSQL.Parameters.AddWithValue("@mgroupCompte", ComboBox_Groupe.Text)
            cmdSQL.Parameters.AddWithValue("@mtypeCompte", ComboBox_Type.Text)
            cmdSQL.Parameters.AddWithValue("@mdeviseCompte", ComboBox_Devise.Text)
            cmdSQL.Parameters.AddWithValue("@mnoCompte", TextBox_NoCompte.Text)
            cmdSQL.Parameters.AddWithValue("@msoldeOuvertureCompte", TextBox_SoldeOuverture.Text)
            cmdSQL.Parameters.AddWithValue("@msoldeMinCompte", TextBox_SoldeMini.Text)
            cmdSQL.Parameters.AddWithValue("@msoldeMaxCompte", TextBox_SoldeMax.Text)
            cmdSQL.Parameters.AddWithValue("@msoldeReelCompte", TextBox_SoldeOuverture.Text)
            cmdSQL.Parameters.AddWithValue("@msoldeConsoCompte", TextBox_SoldeOuverture.Text)
            cmdSQL.Parameters.AddWithValue("@mactifCompte", CheckBox_Actif.CheckState)
            cmdSQL.Parameters.AddWithValue("@mfavoriCompte", CheckBox_Favori.CheckState)
            cmdSQL.Parameters.AddWithValue("@mafficherCompte", CheckBox_Visible.CheckState)
            cmdSQL.Parameters.AddWithValue("@mrqCompte", TextBox_RemarqueCompte.Text)
            cmdSQL.ExecuteNonQuery()
            cmdSQL.Parameters.Clear()
            Me.Close()
        Else
            MsgBox(translateText(69, langageApp)) 'Message d'alerte
            TextBox_NomCompte.Focus()
            Exit Sub
        End If
    End Sub
End Class