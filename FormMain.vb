Imports System
Imports System.Net
'Imports System.Timers
Imports System.Net.Sockets
Imports System.Text
Imports System.IO
Imports System.Threading


Public Class FormMain
    Inherits System.Windows.Forms.Form

    Public valeurbt(3) As String 'trame de 3 caratères à envoyer contenant les positions des poussoirs et du slider)
    Public client As TcpClient
    Public stream As NetworkStream
    Public sr As StreamReader
    Dim str As String = "f,f,000000" 'init de la variable de réception de trame
    Dim flag As Boolean = False 'flag du sélecteur 2 positions
    Dim flag1 As Boolean = False 'flag du poussoir devenant un toggle
    Dim valeur3 As Integer 'variable d'affichage des graphiques
    Public connected As Boolean
    Private Sub FormMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TimerReceive.Stop() 'arret du timer sur la form load
        TimerReceive.Enabled = False
    End Sub
    Private Sub connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles connect.Click

        Try
            
            client = New TcpClient(IP_Address.Text, Port.Text)
            stream = client.GetStream()
            sr = New StreamReader(stream)
            connected = True
            stream.ReadTimeout = 100
            Thread.Sleep(500)
            Dim devstr As String = "Connected"
            Label3.Text = devstr
            'sr.ReadLine() 'lecture du buffer d'entrée streamReader et consommation de la ligne

            Dim initSerOut As String = "f,f,000000" 'init de la trame à envoyer dès le début
            Dim monbuffer As Byte() = Encoding.ASCII.GetBytes(initSerOut)
            stream.Write(monbuffer, 0, monbuffer.Length)
            'Thread.Sleep(2)

            'init des caracteres de la trame états des poussoirs à envoyer
            valeurbt(1) = "f"
            valeurbt(2) = "f"
            valeurbt(3) = "000000" 'init de la donnée numérique à envoyer
            flag = False 'init des flag des boutons toggle
            flag1 = False
            'TimerCourbe.Stop()
            TimerReceive.Enabled = True 'démarrage du timer après connexion
            TimerReceive.Start()

        Catch
            MsgBox("Erreur de connexion avec le Robot 6 axes")
        End Try
    End Sub

    Private Function readBack() As String 'fonction de lecture des données entrantes
        If Not connected Then
            Return "f,f,000000"
        End If
        Dim buffer As New StringBuilder
        Dim returnstring As New String("f,f,000000")
        Try
            If sr.Peek Then
                buffer.Append(sr.ReadLine() + vbCrLf)
            End If
            Return buffer.ToString
        Catch
        End Try
        Return "f,f,000000" 'init de la trame reçu pour éviter les erreurs de parsing

    End Function

    Private Sub TimerReceive_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerReceive.Tick
        Dim affich As String 'memoire tempo des données entrantes pour affichage dans TextBoxCh0
        Dim valeur As Integer 'variable d'affichage de la jauge
        Dim valeur2 As Integer 'variable d'affichage de l'afficheur numérique

        str = readBack()
        sr.DiscardBufferedData() 'efface les donnée passées du buffer

        affich = str
        'str.Remove(0, str.Length) 'clear le string str après affichage
        'Thread.Sleep(1) '2 milliseconde


        valeur = Val(affich) 'conversion string to integer
        TextBoxCh0.Text = affich.ToString 'affichage de la trame entrante

        'pilotage de la jauge
        GaugeControl1.SetPointerValue("Scale1", "Pointer1", valeur2 / 100)



        Dim affich2 As String 'parsing pour afficher les dermiers strings de la trame
        affich2 = String.Concat(affich(4), affich(5), affich(6), affich(7), affich(8), affich(9))
        'la trame f,o,123456 a les indices 0 à 9
        'donc on concate les derniers termes indices 4 à 9

        'pilotage de l'afficheur 
        valeur2 = Val(affich2) 'conversion string vers integer pour afficheur
        DigitalPanelMeterBlue1.Value = valeur2
        Thread.Sleep(1) '2 milliseconde
        valeur3 = valeur2


        'pilotage d'un afficheur avec le début de la trame qui commence à affich(0) en string
        Select Case (affich(0))
            Case "o"
                PilotLight1.Value = True
            Case "f"
                PilotLight1.Value = False
        End Select

        'envoi de la trame
        Dim send As String
        send = vbCrLf
        Dim trame As String = String.Join(",", valeurbt, 1, 3) 'constitution de la trame en rejoignant valeurbt(1),valeurbt(2),valeurbt(3)
        Dim monbuffer As Byte() = Encoding.ASCII.GetBytes(trame) 'transforme de l'integer pour envoi en ASCII
        Dim saut As Byte() = Encoding.ASCII.GetBytes(send)
        stream.Write(monbuffer, 0, monbuffer.Length)
        stream.Write(saut, 0, saut.Length)
        TextBoxCh1.Text = trame
       
        'le metro tracker
        'MetroTracker1.Value = valeur3

    End Sub

    Private Sub disconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disconnect.Click

        'faire l'init de la dernière trame à envoyer si on ferme l'application
        Dim initSerOut As String = "f,f,000000" 'init de la trame à envoyer dès le début
        Dim monbuffer As Byte() = Encoding.ASCII.GetBytes(initSerOut)
        stream.Write(monbuffer, 0, monbuffer.Length)
        stream.Flush()
        sr.Close()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSubscribe.Click
        valeurbt(1) = "o"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUnsubscribe.Click
        'valeurbt(2) = "o"
        Dim initSerOut As String = "f,f,000000" 'init de la trame à envoyer dès le début
        Dim monbuffer As Byte() = Encoding.ASCII.GetBytes(initSerOut)
        stream.Write(monbuffer, 0, monbuffer.Length)
    End Sub

    Private Sub KnobControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KnobControl1.Click
        Dim curseur As Integer
        curseur = KnobControl1.Value 'acquisition des valeurs du curseur
        'DigitalPanelMeterBlue1.Value = curseur
        valeurbt(3) = curseur.ToString("000000") 'interger to string pour l'intégrer dans le 3iéme caractère de la trame sur 6 caracteres
    End Sub

    Private Sub SelectorSwitch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectorSwitch1.Click
        'pour un mode toggle avec des sémaphores
        If (flag) Then
            valeurbt(1) = "f"
            flag = False
        Else
            valeurbt(1) = "o"
            flag = True
        End If
    End Sub

    Private Sub PushButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PushButton1.Click
        'pour un mode toggle avec des sémaphores
        If (flag1) Then
            valeurbt(2) = "f"
            flag1 = False
        Else
            valeurbt(2) = "o"
            flag1 = True
        End If
    End Sub

    Private Sub TimerCourbe_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCourbe.Tick
        'affichage sur le graphique, changer les option de l'axe X chart area collection
        Chart1.Series("Valeur 2").Points.AddY(valeur3)
        Chart2.Series("Series1").Points.AddY(valeur3)
    End Sub
End Class







