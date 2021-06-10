Imports Tulpep.NotificationWindow
Imports System.Data.OleDb
Imports System.Threading.Thread
Imports System.Globalization

Module Mod_Variavel_Conexao

    Public Conexao As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\bancoInstagram.mdb" & ";Jet OLEDB:Database Password=critico1")
    Public IDLogon As String = Environment.UserName

    Public Var_conecet As String = "fechado"
    Public Var_user As String
    Public Var_add As String
    Public Var_dell As String
    Public Var_dell_all As String
    Public Var_busca As String
    Public Var_insta_user As String
    Public vsql As String
    Public Email_fun As String
    Public MomentoInicial As String
    Public MomentoFinal As String
    Public UserVerifica As String
    Public Notificação As String
    Public QTD_Hashtag_add As Integer = 0
    Public QTD_Hashtag_del As Integer = 0
    Public QTD_Perfil_add As Integer = 0
    Public QTD_Perfil_del As Integer = 0
    Public QTD_Bloqs_add As Integer = 0
    Public QTD_Bloqs_del As Integer = 0
    Public QTD_Perfis_lib As Integer = 0
    Public QTD_perfis_bloq As Integer = 0
    Public QTD_perfis_desbloq As Integer = 0
    Public QTD_licencas_renov As Integer = 0
    Public Const T As Boolean = True
    Public Const F As Boolean = False
    Public Const O As String = "aberto"
    Public Const C As String = "fechado"
    Public aprovação As Boolean = F
    Public NumeroAleatorio As Random = New Random()

    Public Function Verifica_conexao() As String

        If My.Computer.Network.IsAvailable = F Then

            Notificação = "           Você precisa de uma conexão Wi-Fi para usar o sistema!!!"
            Fun_gerar_salvar_notificacao(Notificação)
            aprovação = F

        Else

            aprovação = T

        End If

#Disable Warning bc42105
    End Function
#Enable Warning bc42105

    Public Function Fun_gerar_salvar_notificacao(Notificação)

        Dim notification = New PopupNotifier()
        notification.TitleText = "                                                 BRS Sistemas"
        notification.TitleColor = Color.Red
        notification.BorderColor = Color.White
        notification.BodyColor = Color.Black
        notification.ButtonHoverColor = Color.Red
        notification.ContentColor = Color.White
        notification.ContentHoverColor = Color.White
        notification.IsRightToLeft = F
        notification.ContentText = Notificação
        notification.Popup()

#Disable Warning bc42105
    End Function
#Enable Warning bc42105

    Public Function Fun_Carregar() As String

        Verifica_conexao()

        If aprovação = F Then

            Exit Function

        End If

        Dim vsql11 As String

        vsql11 = "SELECT email from tb_usuario where status = '" & "Pendente" & "'"

        Using TB55 As New DataTable()

            Dim DA55 As New OleDbDataAdapter(vsql11, Conexao)
            TB55.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA55.Fill(TB55)

            If TB55.Rows.Count = 0 Then

                Administração.Dg_pendentes.DataSource = ""
                Administração.Dg_pendentes.Enabled = F
                GoTo skip11

            End If

            Administração.Dg_pendentes.DataSource = TB55
            Administração.Dg_pendentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Administração.Dg_pendentes.AutoResizeColumns()
            Administração.Dg_pendentes.Enabled = T

        End Using

skip11:

        Dim sql00 As String

        sql00 = "SELECT email from tb_usuario where status = '" & "Banido" & "'"

        Using TB11 As New DataTable()

            Dim DA11 As New OleDbDataAdapter(sql00, Conexao)
            TB11.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA11.Fill(TB11)

            If TB11.Rows.Count = 0 Then

                Administração.dg_banido.DataSource = ""
                Administração.dg_banido.Enabled = F
                GoTo skip22

            End If

            Administração.dg_banido.DataSource = TB11
            Administração.dg_banido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Administração.dg_banido.AutoResizeColumns()
            Administração.dg_banido.Enabled = T

        End Using

skip22:

        Dim sql1 As String

        sql1 = "SELECT email From tb_usuario WHERE status = '" & "Aprovado" & "' AND lic_ex = '" & "Em dia" & "'"

        Using tb22 As New DataTable()

            Dim DA22 As New OleDbDataAdapter(sql1, Conexao)
            tb22.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA22.Fill(tb22)

            If tb22.Rows.Count = 0 Then

                Administração.dg_user.DataSource = ""
                Administração.dg_user.Enabled = F
                GoTo skip33

            End If

            Administração.dg_user.DataSource = tb22
            Administração.dg_user.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Administração.dg_user.AutoResizeColumns()
            Administração.dg_user.Enabled = T

        End Using

skip33:

        Dim sql22 As String

        sql22 = "SELECT email FROM tb_usuario WHERE status = '" & "Aprovado " & "' AND lic_ex = '" & "Expirado" & "'"

        Using TB33 As New DataTable()

            Dim DA33 As New OleDbDataAdapter(sql22, Conexao)
            TB33.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA33.Fill(TB33)

            If TB33.Rows.Count = 0 Then

                Administração.Dg_expirado.DataSource = ""
                Administração.Dg_expirado.Enabled = F
                GoTo Skip44

            End If

            Administração.Dg_expirado.DataSource = TB33
            Administração.Dg_expirado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Administração.Dg_expirado.AutoResizeColumns()
            Administração.Dg_expirado.Enabled = T

        End Using

Skip44:

#Disable Warning BC42105
    End Function
#Enable Warning BC42105

    Public Function Fun_Banimento() As String

        Verifica_conexao()

        If aprovação = F Then

            Exit Function

        End If

        If MsgBox("Você realmente deseja banir o usuario?", vbYesNo, "Atenção!") = vbYes Then

            Using cmd As New OleDbCommand With {
                   .Connection = Conexao
            }

                If Var_conecet = C Then

                    Var_conecet = O
                    cmd.Connection.Open()

                End If

                cmd.CommandText = "UPDATE tb_usuario set status = '" & "Banido" & "'" &
                                  "Where email = '" & Email_fun & "'"

                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    cmd.Connection.Close()
                    Var_conecet = C
                    MsgBox(ex.Message, vbCritical, "Atenção!")
                    Exit Function
                End Try
                cmd.Connection.Close()
                Var_conecet = C

                QTD_perfis_bloq += 1

            End Using

            MsgBox("Usuario Banido com Sucesso!", vbInformation, "Atenção!")

        End If

        Fun_Carregar()

#Disable Warning BC42105
    End Function
#Enable Warning BC42105

    Public Function Fun_Atualizar() As String

        Verifica_conexao()

        If aprovação = F Then

            Exit Function

        End If

        Administração.Progress_update.Visible = T
        Administração.Progress_update.Value = 1
        Administração.Cursor = Cursors.WaitCursor

        vsql = "SELECT codigo FROM tb_usuario"

        Dim TB As New DataTable()
        Dim DA As New OleDbDataAdapter(vsql, Conexao)

        TB.Locale = System.Globalization.CultureInfo.CurrentCulture
        DA.Fill(TB)

        Dim i As Integer
        Dim limite As Integer = TB.Rows.Count

        Administração.Progress_update.Minimum = 1
        Administração.Progress_update.Maximum = limite

        For i = 1 To limite Step 1

            Dim sql3 As String

            sql3 = "SELECT licenca from tb_usuario where codigo = " & i & ""

            Dim TB1 As New DataTable()
            Dim DA1 As New OleDbDataAdapter(sql3, Conexao)

            TB1.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA1.Fill(TB1)

            If TB1.Rows(0)("licenca").ToString = "" Then

                GoTo Skip

            End If

            If Now < TB1.Rows(0)("licenca").ToString Then

                Dim cmd As New OleDbCommand With {
                            .Connection = Conexao
                }

                If Var_conecet = C Then

                    Var_conecet = O
                    cmd.Connection.Open()

                End If

                cmd.CommandText = "UPDATE tb_usuario set lic_ex = '" & "Em dia" & "'" &
                                   "WHERE codigo = " & i & ""

                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    cmd.Connection.Close()
                    Var_conecet = C
                    MsgBox(ex.Message, vbCritical, "Atenção!")
                    Exit Function
                End Try
                cmd.Connection.Close()
                Var_conecet = C

                GoTo Skip

            End If

            If TB1.Rows(0)("licenca").ToString < Now Then

                Dim cmd As New OleDbCommand With {
                            .Connection = Conexao
                }

                If Var_conecet = C Then

                    Var_conecet = O
                    cmd.Connection.Open()

                End If

                cmd.CommandText = "UPDATE tb_usuario set lic_ex = '" & "Expirado" & "'" &
                                   "WHERE codigo = " & i & ""

                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    cmd.Connection.Close()
                    Var_conecet = C
                    MsgBox(ex.Message, vbCritical, "Atenção!")
                    Exit Function
                End Try
                cmd.Connection.Close()
                Var_conecet = C

                GoTo Skip

            End If

Skip:

            Administração.Progress_update.Value = i

        Next

        Fun_Carregar()

        Administração.Cursor = Cursors.Default
        Administração.Progress_update.Visible = F

#Disable Warning BC42105
    End Function
#Enable Warning BC42105

    Public Function Fun_valida_user() As String

        Verifica_conexao()

        If aprovação = F Then

            Exit Function

        End If

        vsql = "SELECT status, lic_ex FROM tb_usuario WHERE usuario = '" & Var_user & "'"

        Using TB As New DataTable()

            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA.Fill(TB)

            If TB.Rows(0)("Status").ToString = "Banido" Then

                MsgBox("Seu usuario foi banido, caso haja uma reclamação entre em contato com os desenvolvedores!", vbCritical, "Atenção!")
                Application.Exit()

            ElseIf TB.Rows(0)("lic_ex").ToString = "Expirado" Then

                MsgBox("Sua liceça expirou, renove-a para continuar com o acesso!", vbCritical, "Atenção!")
                Application.Exit()

            End If

        End Using

#Disable Warning BC42105
    End Function
#Enable Warning BC41205

    Public Function Fun_entrar() As String

        Verifica_conexao()

        If aprovação = F Then

            Exit Function

        End If

        If Login.Txt_Usuario.Text = "" Then

            MsgBox("Favor informar Usuario!", vbCritical, "Atenção!")
            Exit Function

        End If

        If Login.Txt_Senha.Text = "" Then

            MsgBox("Favor informar Senha!", vbCritical, "Atenção!")
            Exit Function

        End If


        Dim sql As String
        sql = "SELECT usuario, usuario_insta ,senha, status, licenca, lic_ex from TB_usuario Where usuario = '" & Login.Txt_Usuario.Text & "'"

        Using TB11 As New DataTable()

            Dim DA11 As New OleDbDataAdapter(sql, Conexao)
            TB11.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA11.Fill(TB11)

            If TB11.Rows.Count <> 0 Then

                If TB11.Rows(0)("Status").ToString = "Pendente" Then

                    Login.Txt_Senha.Text = ""
                    Login.txt_email.Focus()
                    MsgBox("Confirmação pendente. Feche o aplicativo e espere alguns minutos!", vbCritical, "Atenção!")
                    Exit Function

                End If

                If TB11.Rows(0)("status").ToString = "Banido" Then

                    Login.Txt_Senha.Text = ""
                    Login.txt_email.Focus()
                    MsgBox("Sua conta foi banida. Entre em contato com os Administradores caso queira exclarecer alguma duvida!", vbCritical, "Atenção!")
                    Exit Function

                End If

                If TB11.Rows(0)("lic_ex").ToString = "Em dia" Then

                    If TB11.Rows(0)("senha").ToString <> Login.Txt_Senha.Text Then

                        Login.Txt_Senha.Text = ""
                        Login.Txt_Senha.Focus()
                        MsgBox("Senha Incorreta", vbCritical, "Ateñção!")
                        Exit Function

                    End If

                    GoTo entrar

                Else

                    Login.Txt_Senha.Text = ""
                    MsgBox("Licença expirada!", vbCritical, "Atenção!")
                    Exit Function

                End If

            Else

                Login.Txt_Senha.Text = ""
                Login.Txt_Usuario.Text = ""
                Login.Txt_Usuario.Focus()
                MsgBox("Usuário não Encontrado!", vbCritical, "Atenção!")
                Exit Function

            End If

entrar:

            Var_user = TB11.Rows(0)("Usuario").ToString
            Var_insta_user = TB11.Rows(0)("usuario_insta").ToString

        End Using

        Using cmd As New OleDbCommand With {
            .Connection = Conexao
        }

            If Var_conecet = C Then

                Var_conecet = O
                cmd.Connection.Open()

            End If

            cmd.CommandText = "UPDATE tb_usuario set on_off = '" & "Online" & "'" &
                              "Where usuario = '" & Var_user & "'"

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.Connection.Close()
                Var_conecet = C
                MsgBox(ex.Message, vbCritical, "Atenção!")
                Exit Function
            End Try
            cmd.Connection.Close()
            Var_conecet = C

        End Using

        MsgBox("Seja Bem-Vindo!", vbInformation, "Sistemas BRS")
        Login.Visible = F
        TelaInicial.ShowDialog()

#Disable Warning bc41205
    End Function
#Enable Warning bc41205

End Module