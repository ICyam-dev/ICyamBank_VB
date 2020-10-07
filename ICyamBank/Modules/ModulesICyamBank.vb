Module ModulesICyamBank

    'Fonction de traduction de l'interface de l'application
    Function translateText(ByVal ligneFichier As Integer, ByVal langApp As String) As String
        Dim texteTraduis As String = ""
        Dim fichierLangue As String = "langues\" + langApp + ".lg"
        If IO.File.Exists(fichierLangue) = False Then
            fichierLangue = "langues\French.lg"
        End If

        'Lecture du fichier
        Try
            If IO.File.Exists(fichierLangue) Then
                Dim lectureLigne As String = "" 'Lecture de la ligne
                Dim noLigne As Integer = 1 'Numéro de la ligne
                FileOpen(1, fichierLangue, OpenMode.Input)
                While Not EOF(1)
                    lectureLigne = LineInput(1) 'Lecture de la ligne
                    If noLigne = ligneFichier Then Exit While 'Si no de ligne est OK -> Exit de la boucle
                    noLigne = noLigne + 1
                End While
                FileClose(1)
                texteTraduis = Strings.Right(lectureLigne, Len(lectureLigne) - InStrRev(lectureLigne, "|")) 'Extraire le texte traduis
                'MsgBox(texteTraduis)
            End If
        Catch ex As Exception

        End Try
        Return texteTraduis
    End Function

End Module
