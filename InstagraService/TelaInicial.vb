Imports Tulpep.NotificationWindow
Imports System.Data.OleDb
Imports System.Globalization
Imports System.IO

Public Class TelaInicial

    Private Sub TelaInicial_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        Fun_valida_user()

    End Sub

    Private Sub TelaInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Verifica_conexao()

        If aprovação = F Then

            Application.Exit()

        End If

        MomentoInicial = Format(Now, "dd/MM/yyyy hh:mm:ss")

        LbInferior.Text = "Acesso: " & Var_user & "  " & Format(Now, "dd/MM/yyyy") & "  "
        Cb_add.Items.Add("Hashtag")
        Cb_add.Items.Add("Bloqueados")
        Cb_add.Text = "Hashtag"
        Cb_Dell.Items.Add("Hashtag")
        Cb_Dell.Items.Add("Bloqueados")
        Cb_Dell.Text = "Hashtag"
        Cb_dell_all.Items.Add("Hashtag")
        Cb_dell_all.Items.Add("Bloqueados")
        Cb_dell_all.Text = "Hashtag"
        Cb_Busca.Items.Add("Hashtag")
        Cb_Busca.Items.Add("Bloqueados")
        Cb_Busca.Text = "Hashtag"
        Txt_Perfil_inform.Text = Var_insta_user

        If Cb_add.Text = "Hashtag" Then

            Lb_add.Text = "Hashtag:"
            Var_add = "Hashtag"

        End If

        If Cb_add.Text = "Bloqueados" Then

            Lb_add.Text = "Bloqueados:"
            Var_add = "Bloqueados"

        End If

        Cb_add.Text = Var_add


        If Cb_Dell.Text = "Hashtag" Then

            lb_dell.Text = "Hashtag:"
            Var_dell = "Hashtag"

        End If

        If Cb_Dell.Text = "Bloqueados" Then

            lb_dell.Text = "Bloqueados:"
            Var_dell = "Bloqueados"

        End If

        Cb_Dell.Text = Var_dell

        If Cb_dell_all.Text = "Hashtag" Then

            Var_dell_all = "Hashtag"

        End If

        If Cb_dell_all.Text = "Bloqueados" Then

            Var_dell_all = "Bloqueados"

        End If

        Cb_dell_all.Text = Var_dell_all

        Dim sql As String

        sql = "SELECT tipo_usuario, licenca from tb_usuario WHERE usuario = '" & Var_user & "'"

        Using TB As New DataTable()

            Dim DA As New OleDbDataAdapter(sql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA.Fill(TB)

            If TB.Rows(0)("tipo_usuario").ToString = "ADM" Then

                Bt_adm.Visible = T

                Notificação = "Olá administrador " & Var_user & "!"

                Dim sql5 As String

                sql5 = "SELECT USuario From tb_usuario WHERE Status = '" & "Pendente" & "'"

                Using TB44 As New DataTable()

                    Dim DA44 As New OleDbDataAdapter(sql5, Conexao)
                    TB44.Locale = System.Globalization.CultureInfo.CurrentCulture
                    DA44.Fill(TB44)

                    If TB44.Rows.Count = 0 Then

                        Notificação &= vbNewLine & "Não Há nenhuma solicitação pendente para utilização do sistema!"

                    Else

                        Notificação &= vbNewLine & "Há " & TB44.Rows.Count & " Novas solicitações para utilização do sistema,  Favor acessar " & vbNewLine &
                                       "a área administrativa e confira as solicitações!"

                    End If

                End Using

            End If

            Dim sql6 As String

            sql6 = "SELECT usuario FROM tb_usuario WHERE on_off = '" & "Online" & "'"

            Using TB5 As New DataTable()

                Dim DA5 As New OleDbDataAdapter(sql6, Conexao)
                TB5.Locale = System.Globalization.CultureInfo.CurrentCulture
                DA5.Fill(TB5)

                Notificação &= vbNewLine & "Há " & TB5.Rows.Count & " Usuario(s) Online nesse momento!"

            End Using

            Notificação &= vbNewLine & "Sua licença expira " & TB.Rows(0)("licenca").ToString

        End Using

        If Group_Busca.Text = "Hashtag" Then

            vsql = "SELECT hashtag FROM tb_hashtag WHERE (((tb_hashtag.usuario_insta) = '" & Txt_Perfil_inform.Text & "'))"

            Dim TB2 As New DataTable()
            Dim DA2 As New OleDbDataAdapter(vsql, Conexao)
            TB2.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA2.Fill(TB2)
            List_Hashtag_perfil.DataSource = TB2
            List_Hashtag_perfil.DisplayMember = "hashtag"
            List_Hashtag_perfil.ValueMember = "hashtag"
            List_Hashtag_perfil.SelectedIndex = -1

        End If

        If Group_Busca.Text = "Bloqueados" Then

            vsql = "SELECT Bloqueado FROM Tb_Block WHERE (((tb_block.usuario_insta) = '" & Txt_Perfil_inform.Text & "'))"

            Dim TB2 As New DataTable()
            Dim DA2 As New OleDbDataAdapter(vsql, Conexao)
            TB2.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA2.Fill(TB2)
            List_Hashtag_perfil.DataSource = TB2
            List_Hashtag_perfil.DisplayMember = "Bloqueado"
            List_Hashtag_perfil.ValueMember = "Bloqueado"
            List_Hashtag_perfil.SelectedIndex = -1

        End If

        If lb_dell.Text = "Hashtag:" Then

            vsql = "SELECT Hashtag FROM tb_hashtag WHERE (((tb_hashtag.usuario_insta) = '" & Txt_Perfil_inform.Text & "'))"

            Dim TB3 As New DataTable()
            Dim DA3 As New OleDbDataAdapter(vsql, Conexao)
            TB3.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA3.Fill(TB3)
            Cb_dell_saida.DataSource = TB3
            Cb_dell_saida.DisplayMember = "Hashtag"
            Cb_dell_saida.ValueMember = "Hashtag"
            Cb_dell_saida.SelectedIndex = -1

        End If

        If lb_dell.Text = "bloqueado:" Then

            vsql = "SELECT Bloqueado FROM tb_Block WHERE (((tb_block.usuario_insta) = '" & Txt_Perfil_inform.Text & "'))"

            Dim TB3 As New DataTable()
            Dim DA3 As New OleDbDataAdapter(vsql, Conexao)
            TB3.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA3.Fill(TB3)
            Cb_dell_saida.DataSource = TB3
            Cb_dell_saida.DisplayMember = "Bloqueado"
            Cb_dell_saida.ValueMember = "Bloqueado"
            Cb_dell_saida.SelectedIndex = -1

        End If

        Dim sql1 As String

        sql1 = "SELECT Controle FROM Tb_log_control WHERE (((tb_log_control.Perfil) = '" & Var_user & "'))"

        Dim TB4 As New DataTable()
        Dim DA4 As New OleDbDataAdapter(sql1, Conexao)
        TB4.Locale = System.Globalization.CultureInfo.InvariantCulture
        DA4.Fill(TB4)

        List_andamento.DataSource = TB4
        List_andamento.DisplayMember = "Controle"
        List_andamento.ValueMember = "Controle"
        List_andamento.SelectedIndex = -1
        List_andamento.HorizontalScrollbar = True

        Fun_gerar_salvar_notificacao(Notificação)

    End Sub

    Private Sub Bt_adm_Click(sender As Object, e As EventArgs) Handles Bt_adm.Click

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        Me.Visible = F
        Administração.Show()

    End Sub

    Private Sub Bt_fechar_Click(sender As Object, e As EventArgs) Handles Bt_fechar.Click

        If My.Computer.Network.IsAvailable = F Then

            GoTo Skipupdate

        End If

        MomentoFinal = Format(Now, "dd/MM/yyyy hh:mm:ss")

        Me.Cursor = Cursors.WaitCursor

        Using cmd As New OleDbCommand With {
            .Connection = Conexao
           }

            If Var_conecet = C Then

                Var_conecet = O
                cmd.Connection.Open()

            End If

            Dim sql As String

            sql = "SELECT tipo_usuario FROM tb_usuario WHERE usuario = '" & Var_user & "'"

            Using TB As New DataTable()

                Dim DA As New OleDbDataAdapter(sql, Conexao)
                TB.Locale = System.Globalization.CultureInfo.CurrentCulture
                DA.Fill(TB)

                If TB.Rows(0)("tipo_usuario").ToString = "USER" Then

                    cmd.CommandText = "INSERT into Tb_log_control(Perfil, Controle) Values " &
                                      "('" & Var_user & "', '" & "Data/Hora logado: " & MomentoInicial & ". Data/Hora saida: " & MomentoFinal & ". Total de Hashtags Adicionadas: " & QTD_Hashtag_add &
                                      ". " & "Total de Hashtags Deletadas: " & QTD_Hashtag_del & ". Total d" & "e Perfis Bloqueados Adicionados: " & QTD_Bloqs_add & ". Total de Perfis" &
                                      "Bloquados deletados: " & QTD_Bloqs_del & "." & "')"

                ElseIf TB.Rows(0)("tipo_usuario").ToString = "ADM" Then

                    cmd.CommandText = "INSERT into tb_log_control(Perfil, Controle) Values " &
                                      "('" & Var_user & "', '" & "Data/Hora logado: " & MomentoInicial & ". Data/Hora saida: " & MomentoFinal & ". Total de Hashtags Adicionadas: " & QTD_Hashtag_add &
                                      ". " & "Total de Hashtags Deletadas: " & QTD_Hashtag_del & ".Total d" & "e Perfis Bloqueados Adicionados: " & QTD_Bloqs_add & ". Total de Perfis Bloquados" &
                                      "deletados: " & QTD_Bloqs_del & ". /Funções Administrativas; " & "Quantidade de perfis Liberados: " & QTD_Perfis_lib & ". Quantidade de Perfis Banidos: " & QTD_perfis_bloq& &
                                      ". Quantidade de perfis tirados do banimento: " & QTD_perfis_desbloq & ". Quantidade de licenças renovadas: " & QTD_licencas_renov & "')"

                End If

            End Using

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.Connection.Close()
                Var_conecet = "fechado"
                Me.Cursor = Cursors.Default
                MsgBox(ex.Message, vbCritical, "Atenção!")
                Exit Sub
            End Try
            cmd.Connection.Close()
            Var_conecet = "fechado"

        End Using

        Using cmd As New OleDbCommand With {
            .Connection = Conexao
        }

            If Var_conecet = C Then

                Var_conecet = O
                cmd.Connection.Open()

            End If

            cmd.CommandText = "UPDATE tb_usuario set on_off = '" & "Offline" & "'" &
                              "Where usuario = '" & Var_user & "'"

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.Connection.Close()
                Var_conecet = C
                MsgBox(ex.Message, vbCritical, "Atenção!")
                Exit Sub
            End Try
            cmd.Connection.Close()
            Var_conecet = C

        End Using

Skipupdate:

        Application.Exit()

    End Sub

    Private Sub Cb_add_LostFocus(sender As Object, e As EventArgs) Handles Cb_add.LostFocus

        If Cb_add.Text = "Hashtag" Then

            Lb_add.Text = "Hashtag:"
            Var_add = "Hashtag"

        End If

        If Cb_add.Text = "Bloqueados" Then

            Lb_add.Text = "Bloqueados:"
            Var_add = "Bloqueados"

        End If

        Cb_add.Text = Var_add

    End Sub

    Private Sub Cb_Dell_LostFocus(sender As Object, e As EventArgs) Handles Cb_Dell.LostFocus

        Verifica_conexao()

        If aprovação = F Then

            Cb_Dell.Text = Var_dell
            Exit Sub

        End If

        If Cb_Dell.Text = "Hashtag" Then

            lb_dell.Text = "Hashtag:"
            Var_dell = "Hashtag"

        End If

        If Cb_Dell.Text = "Bloqueados" Then

            lb_dell.Text = "Bloqueados:"
            Var_dell = "Bloqueados"

        End If

        Cb_Dell.Text = Var_dell

        If lb_dell.Text = "Hashtag:" Then

            vsql = "SELECT Hashtag FROM tb_hashtag WHERE (((tb_hashtag.usuario_insta) = '" & Txt_Perfil_inform.Text & "'))"

            Dim TB3 As New DataTable()
            Dim DA3 As New OleDbDataAdapter(vsql, Conexao)
            TB3.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA3.Fill(TB3)
            Cb_dell_saida.DataSource = TB3
            Cb_dell_saida.DisplayMember = "Hashtag"
            Cb_dell_saida.ValueMember = "Hashtag"
            Cb_dell_saida.SelectedIndex = -1

        End If

        If lb_dell.Text = "Bloqueados:" Then

            vsql = "SELECT Bloqueado FROM tb_Block WHERE (((tb_block.usuario_insta) = '" & Txt_Perfil_inform.Text & "'))"

            Dim TB5 As New DataTable()
            Dim DA5 As New OleDbDataAdapter(vsql, Conexao)
            TB5.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA5.Fill(TB5)
            Cb_dell_saida.DataSource = TB5
            Cb_dell_saida.DisplayMember = "Bloqueado"
            Cb_dell_saida.ValueMember = "Bloqueado"
            Cb_dell_saida.SelectedIndex = -1

        End If

    End Sub

    Private Sub Check_seguir_Layout(sender As Object, e As LayoutEventArgs) Handles Check_seguir.Layout

        If Cb_dell_all.Text = "Hashtag" Then

            Var_dell_all = "Hashtag"

        End If

        If Cb_dell_all.Text = "Bloqueados" Then

            Var_dell_all = "Bloqueados"

        End If

        Cb_dell_all.Text = Var_dell_all

    End Sub

    Private Sub Bt_busca_Click(sender As Object, e As EventArgs) Handles Bt_busca.Click

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        If Cb_Busca.Text = "Hashtag" Then

            Group_Busca.Text = "Hashtag"
            Var_busca = "Hashtag"

            vsql = "SELECT hashtag FROM tb_hashtag WHERE (((tb_hashtag.usuario_insta) = '" & Txt_Perfil_inform.Text & "'))"

            Dim TB As New DataTable()
            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA.Fill(TB)
            List_Hashtag_perfil.DataSource = TB
            List_Hashtag_perfil.DisplayMember = "hashtag"
            List_Hashtag_perfil.ValueMember = "hashtag"
            List_Hashtag_perfil.SelectedIndex = -1

        End If

        If Cb_Busca.Text = "Bloqueados" Then

            Group_Busca.Text = "Bloqueados"
            Var_busca = "bloqueados"

            vsql = "SELECT Bloqueado FROM Tb_Block WHERE (((tb_Block.usuario_insta) = '" & Txt_Perfil_inform.Text & "'))"

            Dim TB As New DataTable()
            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA.Fill(TB)
            List_Hashtag_perfil.DataSource = TB
            List_Hashtag_perfil.DisplayMember = "Bloqueado"
            List_Hashtag_perfil.ValueMember = "Bloqueado"
            List_Hashtag_perfil.SelectedIndex = -1

        End If

        Cb_Busca.Text = Var_busca

    End Sub

    Private Sub Txt_Perfil_inform_LostFocus(sender As Object, e As EventArgs) Handles Txt_Perfil_inform.LostFocus

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        If Group_Busca.Text = "Hashtag" Then

            vsql = "SELECT hashtag FROM tb_hashtag WHERE (((tb_hashtag.usuario_insta) = '" & Txt_Perfil_inform.Text & "'))"

            Dim TB As New DataTable()
            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA.Fill(TB)
            List_Hashtag_perfil.DataSource = TB
            List_Hashtag_perfil.DisplayMember = "hashtag"
            List_Hashtag_perfil.ValueMember = "hashtag"
            List_Hashtag_perfil.SelectedIndex = -1

        End If

        If Group_Busca.Text = "Bloqueados" Then

            vsql = "SELECT Bloqueado FROM Tb_Block WHERE (((tb_Block.usuario_insta) = '" & Txt_Perfil_inform.Text & "'))"

            Dim TB As New DataTable()
            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA.Fill(TB)
            List_Hashtag_perfil.DataSource = TB
            List_Hashtag_perfil.DisplayMember = "Bloqueado"
            List_Hashtag_perfil.ValueMember = "Bloqueado"
            List_Hashtag_perfil.SelectedIndex = -1

        End If

    End Sub

    Private Sub Bt_Add_Hashtag_perfil_Click(sender As Object, e As EventArgs) Handles Bt_Add_Hashtag_perfil.Click

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        If Txt_Perfil_inform.Text = "" Then

            Txt_Perfil_inform.Focus()
            MsgBox("Favor Informar Um perfil do Instagram!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If Lb_add.Text = "Hashtag:" Then

            If Txt_add.Text = "" Then

                Txt_add.Focus()
                MsgBox("Favor Inserir Uma Hashtag!", vbCritical, "Atenção!")
                Exit Sub

            End If

            Dim TxtHashtag As String

            TxtHashtag = Replace(Txt_add.Text, "#", "")
            TxtHashtag = Replace(TxtHashtag, " ", "")

            Me.Cursor = Cursors.WaitCursor

            Using cmd As New OleDbCommand With {
                .Connection = Conexao
            }

                If Var_conecet = "fechado" Then

                    cmd.Connection.Open()
                    Var_conecet = "aberto"

                End If

                cmd.CommandText = "INSERT into tb_hashtag (hashtag, usuario, usuario_insta, data) values" &
                                  "('" & TxtHashtag & "' , '" & Var_user & "' , '" & Var_insta_user & "' , '" & Now & "')"

                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    cmd.Connection.Close()
                    Var_conecet = "fechado"
                    Me.Cursor = Cursors.Default
                    MsgBox(ex.Message, vbCritical, "Atenção!")
                    Exit Sub
                End Try
                cmd.Connection.Close()
                Var_conecet = "fechado"

                QTD_Hashtag_add += 1

            End Using

            Me.Cursor = Cursors.Default

            GoTo Carregamento1

        End If

        If Lb_add.Text = "Bloqueados:" Then

            If Txt_add.Text = "" Then

                Txt_add.Focus()
                MsgBox("Favor Inserir Um Perfil para Bloquear!", vbCritical, "Atenção!")
                Exit Sub

            End If

            Dim TxtBloq As String

            TxtBloq = Replace(Txt_add.Text, "@", "")
            TxtBloq = Replace(TxtBloq, " ", "_")

            Me.Cursor = Cursors.WaitCursor

            Using cmd As New OleDbCommand With {
                    .Connection = Conexao
            }

                If Var_conecet = "fechado" Then

                    cmd.Connection.Open()
                    Var_conecet = "aberto"

                End If

                cmd.CommandText = "INSERT into tb_block (Bloqueado, usuario, usuario_insta, data) values" &
                                  "('" & TxtBloq & "', '" & Var_user & "', '" & Var_insta_user & "', '" & Now & "')"

                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    cmd.Connection.Close()
                    Var_conecet = "fechado"
                    Me.Cursor = Cursors.Default
                    MsgBox(ex.Message, vbCritical, "Atenção!")
                    Exit Sub
                End Try
                cmd.Connection.Close()

                Var_conecet = "fechado"

                QTD_Bloqs_add += 1

            End Using

            Me.Cursor = Cursors.Default

            GoTo Carregamento1

        End If

Carregamento1:

        If Group_Busca.Text = "Hashtag" Then

            vsql = "SELECT hashtag FROM tb_hashtag WHERE (((tb_hashtag.usuario_insta) = '" & Txt_Perfil_inform.Text & "'))"

            Dim TB As New DataTable()
            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA.Fill(TB)
            List_Hashtag_perfil.DataSource = TB

            List_Hashtag_perfil.DisplayMember = "hashtag"
            List_Hashtag_perfil.ValueMember = "hashtag"
            List_Hashtag_perfil.SelectedIndex = -1

            MsgBox("Hashtag '" & Txt_add.Text & "' Cadastrada!", vbInformation, "Atenção!")

        End If

        If Group_Busca.Text = "Bloqueados" Then

            vsql = "SELECT Bloqueado FROM Tb_Block WHERE (((tb_block.usuario_insta) = '" & Txt_Perfil_inform.Text & "'))"

            Dim TB As New DataTable()
            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA.Fill(TB)
            List_Hashtag_perfil.DataSource = TB

            List_Hashtag_perfil.DisplayMember = "Bloqueado"
            List_Hashtag_perfil.ValueMember = "Bloqueado"
            List_Hashtag_perfil.SelectedIndex = -1

            MsgBox("Perfil Bloqueado '" & Txt_add.Text & "' Cadastrada!", vbInformation, "Atenção!")

        End If

        Txt_add.Text = ""
        Txt_add.Focus()

    End Sub

    Private Sub Bt_dell_hashtag_perfil_Click(sender As Object, e As EventArgs) Handles Bt_dell_hashtag_perfil.Click

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        If Txt_Perfil_inform.Text = "" Then

            Txt_Perfil_inform.Focus()
            MsgBox("Favor Informar Um perfil do Instagram!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If lb_dell.Text = "Hashtag:" Then

            If Cb_dell_saida.Text = "" Then

                MsgBox("Favor Selecionar Uma hashtag!", vbCritical, "Atenção!")
                Exit Sub

            End If

            Me.Cursor = Cursors.WaitCursor

            Dim sql As String

            sql = "SELECT * from tb_hashtag WHERE hashtag = '" & Cb_dell_saida.Text & "'"

            Using TB1 As New DataTable()

                Dim DA1 As New OleDbDataAdapter(sql, Conexao)
                TB1.Locale = System.Globalization.CultureInfo.CurrentCulture
                DA1.Fill(TB1)

                If TB1.Rows.Count = 0 Then

                    Cb_dell_saida.Text = ""
                    MsgBox("hashtag não encontrada!", vbCritical, "Atenção!")
                    Me.Cursor = Cursors.Default
                    Exit Sub

                End If

            End Using

            Using cmd As New OleDbCommand With {
                .Connection = Conexao
            }

                If Var_conecet = "fechado" Then

                    cmd.Connection.Open()
                    Var_conecet = "aberto"

                End If

                cmd.CommandText = "DELETE * FROM tb_hashtag WHERE hashtag = '" & Cb_dell_saida.Text & "' AND usuario_insta = '" & Txt_Perfil_inform.Text & "'"

                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    cmd.Connection.Close()
                    Var_conecet = "fechado"
                    Me.Cursor = Cursors.Default
                    MsgBox(ex.Message, vbCritical, "Atenção!")
                    Exit Sub
                End Try
                cmd.Connection.Close()
                Var_conecet = "fechado"

                QTD_Hashtag_del += 1

            End Using

            Me.Cursor = Cursors.Default

            GoTo Carregamento2

        End If

        If lb_dell.Text = "Bloqueados:" Then

            If Cb_dell_saida.Text = "" Then

                MsgBox("Favor Selecionar Um perfil Bloqueado!", vbCritical, "Atenção!")
                Exit Sub

            End If

            Me.Cursor = Cursors.WaitCursor

            Dim sql As String

            sql = "SELECT * from tb_Block WHERE bloqueado = '" & Cb_dell_saida.Text & "'"

            Using TB1 As New DataTable()

                Dim DA1 As New OleDbDataAdapter(sql, Conexao)
                TB1.Locale = System.Globalization.CultureInfo.CurrentCulture
                DA1.Fill(TB1)

                If TB1.Rows.Count = 0 Then

                    Cb_dell_saida.Text = ""
                    MsgBox("Perfil bloqueado não encontrado!", vbCritical, "Atenção!")
                    Me.Cursor = Cursors.Default
                    Exit Sub

                End If

            End Using

            Using cmd As New OleDbCommand With {
                .Connection = Conexao
            }

                If Var_conecet = "fechado" Then

                    cmd.Connection.Open()
                    Var_conecet = "aberto"

                End If

                cmd.CommandText = "DELETE * from tb_block where Bloqueado = '" & Cb_dell_saida.Text & "'AND usuario_insta = '" & Txt_Perfil_inform.Text & "'"

                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    cmd.Connection.Close()
                    Var_conecet = "fechado"
                    Me.Cursor = Cursors.Default
                    MsgBox(ex.Message, vbCritical, "Atenção!")
                    Exit Sub
                End Try
                cmd.Connection.Close()
                Var_conecet = "fechado"

                QTD_Bloqs_del += 1

            End Using

            Me.Cursor = Cursors.Default

            GoTo Carregamento2

        End If

Carregamento2:

        If Group_Busca.Text = "Hashtag" Then

            vsql = "SELECT hashtag FROM tb_hashtag WHERE (((tb_hashtag.usuario_insta) = '" & Txt_Perfil_inform.Text & "'))"

            Dim TB As New DataTable()
            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA.Fill(TB)
            List_Hashtag_perfil.DataSource = TB

            List_Hashtag_perfil.DisplayMember = "hashtag"
            List_Hashtag_perfil.ValueMember = "hashtag"
            List_Hashtag_perfil.SelectedIndex = -1

            MsgBox("Hashtag '" & Cb_dell_saida.Text & "' Excluida!", vbInformation, "Atenção!")

        End If

        If Group_Busca.Text = "Bloqueados" Then

            vsql = "SELECT bloqueado FROM tb_Block WHERE usuario_insta = ('" & Txt_Perfil_inform.Text & "')"

            Dim TB As New DataTable()
            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA.Fill(TB)
            List_Hashtag_perfil.DataSource = TB

            List_Hashtag_perfil.DisplayMember = "bloqueado"
            List_Hashtag_perfil.ValueMember = "bloqueado"
            List_Hashtag_perfil.SelectedIndex = -1

            MsgBox("Perfil Bloqueado '" & Cb_dell_saida.Text & "' Excluido!", vbInformation, "Atenção!")

        End If

        Cb_dell_saida.Text = ""
        Txt_add.Focus()

    End Sub

    Private Sub Bt_dell_all_Click(sender As Object, e As EventArgs) Handles Bt_dell_all.Click

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        If Txt_Perfil_inform.Text = "" Then

            Txt_Perfil_inform.Focus()
            MsgBox("Favor Informar Um perfil do Instagram!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If Cb_dell_all.Text = "Hashtag" Then

            If MsgBox("Você realmente deseja excluir todas as hashtags do perfil " & Txt_Perfil_inform.Text & "?", vbYesNo, "Atenção!") = vbYes Then

                Me.Cursor = Cursors.WaitCursor

                Dim sql As String

                sql = "SELECT * from tb_hashtag WHERE usuario_insta = '" & Txt_Perfil_inform.Text & "'"

                Using TB1 As New DataTable()

                    Dim DA1 As New OleDbDataAdapter(sql, Conexao)
                    TB1.Locale = System.Globalization.CultureInfo.CurrentCulture
                    DA1.Fill(TB1)

                    If TB1.Rows.Count = 0 Then

                        MsgBox("Nenhuma hashtag encontrada!", vbCritical, "Atenção!")
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    End If

                    QTD_Hashtag_del = TB1.Rows.Count

                End Using

                Using cmd As New OleDbCommand With {
                        .Connection = Conexao
                }

                    If Var_conecet = "fechado" Then

                        cmd.Connection.Open()
                        Var_conecet = "aberto"

                    End If

                    cmd.CommandText = "DELETE * From tb_hashtag where usuario_insta = '" & Txt_Perfil_inform.Text & "'"

                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        cmd.Connection.Close()
                        Var_conecet = "fechado"
                        Me.Cursor = Cursors.Default
                        MsgBox(ex.Message, vbCritical, "Atenção!")
                        Exit Sub
                    End Try
                    cmd.Connection.Close()
                    Var_conecet = "fechado"

                End Using

                Me.Cursor = Cursors.Default

                GoTo Carregamento3

            Else

                MsgBox("Operação cancelada!", vbInformation, "Atenção!")

            End If

        End If

        If Cb_dell_all.Text = "Bloqueados" Then

            If MsgBox("Você realmente deseja excluir todos os perfis Bloqueados do perfil " & Txt_Perfil_inform.Text & "?", vbYesNo, "Atenção!") = vbYes Then

                Me.Cursor = Cursors.WaitCursor

                Dim sql As String

                sql = "SELECT * from tb_Block WHERE usuario_insta = '" & Txt_Perfil_inform.Text & "'"

                Using TB1 As New DataTable()

                    Dim DA1 As New OleDbDataAdapter(sql, Conexao)
                    TB1.Locale = System.Globalization.CultureInfo.CurrentCulture
                    DA1.Fill(TB1)

                    If TB1.Rows.Count = 0 Then

                        MsgBox("Nenhum Perfil bloqueado não encontrado!", vbCritical, "Atenção!")
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    End If

                    QTD_Bloqs_del = TB1.Rows.Count

                End Using

                Using cmd As New OleDbCommand With {
                        .Connection = Conexao
                }

                    If Var_conecet = "fechado" Then

                        cmd.Connection.Open()
                        Var_conecet = "aberto"

                    End If

                    cmd.CommandText = "DELETE * From tb_block where usuario_insta = '" & Txt_Perfil_inform.Text & "'"

                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        cmd.Connection.Close()
                        Me.Cursor = Cursors.Default
                        Var_conecet = "fechado"
                        MsgBox(ex.Message, vbCritical, "Atenção!")
                        Exit Sub
                    End Try
                    cmd.Connection.Close()
                    Var_conecet = "fechado"

                End Using

                Me.Cursor = Cursors.Default

                GoTo Carregamento3

            Else

                MsgBox("Operação cancelada!", vbInformation, "Atenção!")

            End If

        End If

Carregamento3:

        If Group_Busca.Text = "Hashtag" Then

            vsql = "SELECT hashtag FROM tb_hashtag WHERE (((tb_hashtag.usuario_insta) = '" & Txt_Perfil_inform.Text & "'))"

            Dim TB As New DataTable()
            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA.Fill(TB)
            List_Hashtag_perfil.DataSource = TB

            List_Hashtag_perfil.DisplayMember = "hashtag"
            List_Hashtag_perfil.ValueMember = "hashtag"
            List_Hashtag_perfil.SelectedIndex = -1

            MsgBox("Hashtags do perfil " & Txt_Perfil_inform.Text & " excluidas!", vbInformation, "Atenção!")

        End If

        If Group_Busca.Text = "Bloqueados" Then

            vsql = "SELECT Bloqueado FROM Tb_Block WHERE (((tb_block.usuario_insta) = '" & Txt_Perfil_inform.Text & "'))"

            Dim TB As New DataTable()
            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA.Fill(TB)

            List_Hashtag_perfil.DataSource = TB
            List_Hashtag_perfil.DisplayMember = "Bloqueado"
            List_Hashtag_perfil.ValueMember = "Bloqueado"
            List_Hashtag_perfil.SelectedIndex = -1

            MsgBox("Perfis Bloquados do perfil " & Txt_Perfil_inform.Text & "excluidos!", vbInformation, "Atenção!")

        End If

    End Sub

    Private Sub Bt_Inicio_hashtag_Click(sender As Object, e As EventArgs) Handles bt_Inicio_hashtag.Click

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        Dim k

        Dim Prosseso() As Process = System.Diagnostics.Process.GetProcessesByName("iexplore.exe")

        For Each x As Process In Prosseso

            x.Kill()

        Next

        If Txt_espera.Text = "" Then

            Txt_espera.Focus()
            MsgBox("Favor informar um tempo de espera!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If Not IsNumeric(Txt_espera.Text) Then

            Txt_espera.Focus()
            MsgBox("Tempo de espera deve ser Numerico!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If Txt_espera.Text <= 59 Then

            If MsgBox("Tempo de espera inferior ao padrão, pode-se decorrer travamentos no instagram, deseja prosseguir?", vbYesNo, "Atenção!") = vbNo Then

                Txt_espera.Focus()
                Exit Sub

            End If

        End If

        Lb_iniciar_p_hashtag.Text = "Abrindo O internet explorer"

        Me.Cursor = Cursors.WaitCursor

        Dim IE As Object

        IE = CreateObject("InternetExplorer.Application")

        Lb_iniciar_p_hashtag.Text = "Iniciando"

        IE.Navigate("https://www.instagram.com")
        IE.visible = T

        Do While IE.readystate <> 4 : Loop
        Do While IE.busy : Loop

        Dim obj1 As Object

        obj1 = IE.document.getElementsByTagName("span")
        k = 0

        System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

        While k < obj1.length

            If Trim$(obj1(k).classname) = Trim("_2dbep qNELH") Then

                obj1(k).click()
                Do While IE.readyState <> 4 : Loop
                Do While IE.busy : Loop
                System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))
                GoTo Fora_perfil

            End If

            k += 1

        End While

Fora_perfil:

        obj1 = IE.Document.getElementsByTagName("div")
        k = 0

        System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

        While k < obj1.Length

            If Trim$(obj1(k).innertext) = "Sair" Then

                obj1(k).click()
                Do While IE.ReadyState <> 4 : Loop
                Do While IE.busy : Loop
                System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))
                GoTo Fora_Perfil_cfg

            End If

            k += 1

        End While

Fora_Perfil_cfg:

        Do While IE.ReadyState <> 4 : Loop
        Do While IE.Busy : Loop
        System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

        obj1 = IE.Document.getElementsByTagName("button")
        k = 0

        While k < obj1.Length

            If Trim$(obj1(k).innertext) = "Trocar de conta" Then

                obj1(k).click()
                Do While IE.ReadyState <> 4 : Loop
                Do While IE.Busy : Loop
                System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))
                GoTo Fora_Trocar_conta1

            End If

            k += 1

        End While

Fora_Trocar_conta1:

        Notificação = "Efetue o login no instagram aberto!!! Favor sair dessa caixa de texto apenas após o login!!"
        MsgBox(Notificação, vbCritical, "Atenção!")

        Do While IE.ReadyState <> 4 : Loop
        Do While IE.Busy : Loop

        System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

        obj1 = IE.Document.getElementsByTagName("a")
        k = 0

        While k < obj1.Length

            If Trim$(obj1(k).classname) = Trim("gmFkV") Then

                obj1(k).click()
                Do While IE.ReadyState <> 4 : Loop
                Do While IE.Busy : Loop
                System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))
                GoTo Fora_perfil1

            End If

            k += 1

        End While

Fora_perfil1:

        System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

        Dim VerificaUser As String

        VerificaUser = Replace(Replace(IE.LocationURL, "https://www.instagram.com", ""), "/", "")

        Dim sql As String

        sql = "SELECT usuario, status FROM tb_usuario WHERE usuario_insta = '" & Trim(VerificaUser) & "'"

        Using TB As New DataTable()

            Dim DA As New OleDbDataAdapter(sql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA.Fill(TB)

            If TB.Rows.Count = 0 Then

                Notificação = "Usuario não encontrado no sistema, contate um administrador!!!"
                Fun_gerar_salvar_notificacao(Notificação)
                GoTo Fora_final

            Else

                If TB.Rows(0)("Status").ToString <> "Aprovado" Then

                    Notificação = "Usuario não permitido para usar o sistema, contate um administrador!!!"
                    Fun_gerar_salvar_notificacao(Notificação)
                    GoTo Fora_final

                End If

            End If

        End Using

        Dim QTDseguidores As String
        Dim QTDpostagens As String
        Dim QTDseguindo As String
        Dim msg As String

        obj1 = IE.Document.getElementsByTagName("span")
        Do While IE.ReadyState <> 4 : Loop
        Do While IE.Busy : Loop
        QTDpostagens = obj1(1).innertext

        obj1 = IE.Document.getElementsByTagName("span")
        Do While IE.ReadyState <> 4 : Loop
        Do While IE.Busy : Loop
        QTDseguindo = obj1(3).innertext

        obj1 = IE.Document.getElementsByTagName("span")
        Do While IE.ReadyState <> 4 : Loop
        Do While IE.Busy : Loop
        QTDseguidores = obj1(2).innertext

        msg = Now & " - " & Trim(VerificaUser) & " - " & "QTD Seguidores: " & QTDseguidores & "   QTD seguindo: " & QTDseguindo & "   QTD postagens: " & QTDpostagens

        Using cmd As New OleDbCommand With {
            .Connection = Conexao
            }

            If Var_conecet = C Then

                Var_conecet = O
                cmd.Connection.Open()

            End If

            cmd.CommandText = "INSERT into Tb_log_control (Perfil ,Controle) Values ('" & Var_user & "', '" & msg & "')"

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Atenção!")
                Var_conecet = C
                cmd.Connection.Close()
                GoTo Fora_final
            End Try
            Var_conecet = C
            cmd.Connection.Close()

        End Using

        Dim sql1 As String

        sql1 = "SELECT Codigo, Perfil, Controle FROM Tb_log_control WHERE Perfil = '" & Trim(VerificaUser) & "'"

        Using TB1 As New DataTable()

            Dim DA1 As New OleDbDataAdapter(sql1, Conexao)
            TB1.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA1.Fill(TB1)

            If TB1.Rows.Count > 0 Then

                List_andamento.DataSource = TB1
                List_andamento.DisplayMember = "Controle"
                List_andamento.ValueMember = "Codigo"
                List_andamento.SelectedIndex = -1

            End If

        End Using

        Dim sql2 As String

        sql2 = "SELECT count(Hashtag) AS QTDhashtag FROM Tb_hashtag WHERE usuario_insta = '" & Trim(VerificaUser) & "'"

        Using TB3 As New DataTable()

            Dim DA3 As New OleDbDataAdapter(sql2, Conexao)
            TB3.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA3.Fill(TB3)

            Dim QTDhashtag As Integer = TB3.Rows(0)("QTDhashtag").ToString()

            If QTDhashtag = 0 Then

                Notificação = "Não há hashtags cadastradas para esse perfil!!!"
                Fun_gerar_salvar_notificacao(Notificação)
                GoTo Fora_final

            End If

            Progress_principal.Minimum = 0
            Progress_principal.Maximum = QTDhashtag - 1

            Dim i As Integer
            Dim HashtagAtual(QTDhashtag - 1)

            Dim sql3 As String

            sql3 = "SELECT hashtag FROM tb_hashtag WHERE usuario_insta = '" & Trim(VerificaUser) & "'"

            Using TB4 As New DataTable()

                Dim DA4 As New OleDbDataAdapter(sql3, Conexao)
                TB4.Locale = System.Globalization.CultureInfo.CurrentCulture
                DA4.Fill(TB4)

                QTDhashtag = QTDhashtag - 1

                For i = 0 To QTDhashtag Step 1

                    HashtagAtual(i) = TB4.Rows(i)("hashtag").ToString()

                Next

            End Using

Reiniciar_ferramenta:

            Lb_iniciar_p_hashtag.Text = "Ferramenta em Funcionamento"
            Lb_trabalho.Text = "Trabalhando na Hashttag:"
            Me.Cursor = Cursors.Default

            Dim TempoEspera As Integer = Txt_espera.Text * 1000

            For i = 0 To QTDhashtag Step 1

                Txt_Trabalho.Text = Trim(HashtagAtual(i))
                Progress_principal.Value = i
                IE.Navigate("https://www.instagram.com/explore/tags/" & Trim(HashtagAtual(i)) & "/?hl=pt-br")

                Do While IE.ReadyState <> 4 : Loop
                Do While IE.busy : Loop
                System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

                Dim obj2 As Object
                Dim A
                Dim GG
                Dim Valor
                obj2 = IE.Document.getElementsByTagName("div")
                A = 0

                While A < obj2.Length

                    If obj2(A).classname = "eLAPa" Then

                        obj2(A).click()

                        System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

                        Do While IE.ReadyState <> 4 : Loop
                        Do While IE.Busy : Loop

                        Dim obj3 As Object
                        Dim Perfil As String
                        obj3 = IE.Document.getElementsByTagName("div")
                        GG = 0

                        While GG < obj3.Length

                            If Trim$(obj3(GG).classname) = "QBdPU" Then

                                Valor = obj3(GG).innerhtml

                                Dim valuetxt As String
                                Dim validalike As Integer

                                valuetxt = "Descurtir"
                                validalike = Valor.IndexOf(valuetxt)

                                If validalike > -1 Then

                                    Txt_all_like.Text += 1
                                    GoTo Fora_like

                                End If

                                valuetxt = "Curtir"
                                validalike = Valor.IndexOf(valuetxt)

                                If validalike > -1 Then

                                    obj3(GG).click()

                                    Do While IE.ReadyState <> 4 : Loop
                                    Do While IE.Busy : Loop

                                    If Check_Coment.Checked = F Then

                                        Exit While

                                    End If

                                    System.Threading.Thread.Sleep(TempoEspera + NumeroAleatorio.Next(-10000, 10000))

                                End If

                            End If

                            GG += 1

                        End While

                        Txt_like.Text += 1

Fora_like:

                        Do While IE.ReadyState <> 4 : Loop
                        Do While IE.Busy : Loop

                        System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

                        If txt_coment.Text <> "" Then

                            Dim obj55 As Object
                            Dim hh
                            obj55 = IE.Document.GetElementsByTagName("textarea")
                            hh = 0

                            While hh < obj55.Length

                                If obj55(hh).classname = "Ypffh" Then

                                    obj55(hh).classname = "Ypffh focus-visible"

                                    obj55(hh).Innertext = txt_coment.Text

                                    Do While IE.ReadyState <> 4 : Loop
                                    Do While IE.Busy : Loop

                                    System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

                                    Dim obj66 As Object
                                    Dim kk
                                    obj66 = IE.Document.GetElementsByTagName("button")
                                    kk = 0

                                    While kk < obj66.Length

                                        If obj66(kk).innertext = "Publicar" Then

                                            obj66(kk).click()

                                            Do While IE.ReadyState <> 4 : Loop
                                            Do While IE.Busy : Loop

                                            System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

                                            Exit While

                                        End If

                                        kk += 1

                                    End While

                                    Exit While

                                End If

                                hh += 1

                            End While

                        End If

                        If Check_seguir.Checked = T Then

                            Dim obj4 As Object
                            Dim b
                            obj4 = IE.document.getElementsByTagName("span")
                            b = 0

                            While b < obj4.Length

                                If Trim(obj4(b).classname) = "Jv7Aj mArmR MqpiF" Then

                                    Perfil = obj4(b).innertext

                                    Dim sql6 As String

                                    sql6 = "SELECT perfil, usuario_insta FROM TB_perfil WHERE Usuario_insta = '" & Trim(VerificaUser) & "' and perfil = '" & Perfil & "'"

                                    Using TB4 As New DataTable()

                                        Dim DA4 As New OleDbDataAdapter(sql6, Conexao)
                                        TB4.Locale = System.Globalization.CultureInfo.InvariantCulture
                                        DA4.Fill(TB4)

                                        If TB4.Rows.Count = 0 Then

                                            Dim obj5 As Object
                                            Dim u
                                            obj5 = IE.Document.GetElementsByTagName("button")
                                            u = 0

                                            While u < obj5.Length

                                                If obj5(u).innertext = "Seguir" Then

                                                    obj5(u).click()
                                                    Txt_folow.Text += 1

                                                    System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

                                                    Do While IE.ReadyState <> 4 : Loop
                                                    Do While IE.Busy : Loop

                                                    Using cmd As New OleDbCommand With {
                                                      .Connection = Conexao
                                                      }

                                                        If Var_conecet = C Then

                                                            Var_conecet = O
                                                            cmd.Connection.Open()

                                                        End If

                                                        cmd.CommandText = "INSERT into Tb_Perfil (perfil, usuario, usuario_insta, status, data)" &
                                                                                      "Values('" & Perfil & "', '" & Var_user & "', '" & Trim(VerificaUser) & "', '" & "SEGUINDO" & "', '" & Now & "')"

                                                        Try
                                                            cmd.ExecuteNonQuery()
                                                        Catch ex As Exception
                                                            cmd.Connection.Close()
                                                            Var_conecet = C
                                                            MsgBox(ex, vbCritical, "Atenção!!!")
                                                            GoTo Fora_final
                                                        End Try
                                                        cmd.Connection.Close()
                                                        Var_conecet = C

                                                    End Using

                                                End If

                                                u += 1

                                            End While

                                        End If

                                    End Using

                                    Txt_all_folow.Text += 1
                                    GoTo Proxima_foto

                                End If

                                b += 1

                            End While

                        End If

                        Txt_all_like.Text += 1

Proxima_foto:

                        System.Threading.Thread.Sleep(TempoEspera + NumeroAleatorio.Next(-10000, 10000))

                        Dim obj6 As Object
                        Dim h
                        obj6 = IE.Document.GetElementsByTagName("button")
                        h = 0

                        While h < obj6.Length

                            If Trim(obj6(h).classname) = "wpO6b" Then

                                Dim Valor2 As String = obj6(h).innerhtml
                                Dim Valortxt As String = "Fechar"
                                Dim validaSaida As Integer = Valor2.IndexOf(Valortxt)

                                If validaSaida > -1 Then

                                    obj6(h).click()

                                    Do While IE.ReadyState <> 4 : Loop
                                    Do While IE.Busy : Loop

                                    System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

                                    GoTo Fora_foto

                                End If

                            End If

                            h += 1

                        End While

Fora_foto:

                        Dim sql4 As String

                        sql4 = "SELECT Tb_perfil.data, [Tb_perfil]![perfil] & ""  -  "" & [Tb_perfil]![status] as NOME, Tb_perfil.status " &
                               "FROM (tb_perfil) WHERE (((tb_perfil.usuario_insta) = '" & Trim(VerificaUser) & "') and ((tb_perfil.status) = '" & "SEGUINDO" & "'))"

                        Using TB5 As New DataTable()

                            Dim DA5 As New OleDbDataAdapter(sql4, Conexao)
                            TB5.Locale = System.Globalization.CultureInfo.CurrentCulture
                            DA5.Fill(TB5)

                            List_status.DataSource = TB5
                            List_status.DisplayMember = "NOME"
                            List_status.ValueMember = "data"
                            List_status.SelectedIndex = -1

                        End Using

                    End If

                    A += 1

                End While

                Do While IE.ReadyState <> 4 : Loop
                Do While IE.Busy : Loop

                System.Threading.Thread.Sleep(TempoEspera + NumeroAleatorio.Next(-10000, 10000))

                Dim sql5 As String

                sql5 = "SELECT Tb_perfil.data, [Tb_perfil]![Perfil]& ""  -  "" &[tb_perfil]![status] as NOME, Tb_perfil.Status " &
                       "FROM (tb_perfil) WHERE (((tb_perfil.usuario_insta) = '" & Trim(VerificaUser) & "') and ((tb_perfil.status) = '" & "SEGUINDO" & "'))"

                Using TB6 As New DataTable()

                    Dim DA6 As New OleDbDataAdapter(sql5, Conexao)
                    TB6.Locale = System.Globalization.CultureInfo.CurrentCulture
                    DA6.Fill(TB6)

                    List_status.DataSource = TB6
                    List_status.DisplayMember = "NOME"
                    List_status.ValueMember = "data"
                    List_status.SelectedIndex = -1

                End Using

            Next

            If Check_Reiniciar.Checked = T Then

                GoTo Reiniciar_ferramenta

            End If

        End Using

Fora_final:

        IE.quit()
        Lb_iniciar_p_hashtag.Text = "Iniciar Por Hashtag"
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Bt_deslike_Click(sender As Object, e As EventArgs) Handles Bt_deslike.Click

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        Dim k

        Dim Prosseso() As Process = System.Diagnostics.Process.GetProcessesByName("iexplore.exe")

        For Each x As Process In Prosseso

            x.Kill()

        Next

        If Txt_espera.Text = "" Then

            Txt_espera.Focus()
            MsgBox("Favor informar um tempo de espera!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If Not IsNumeric(Txt_espera.Text) Then

            Txt_espera.Focus()
            MsgBox("Tempo de espera deve ser Numerico!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If Txt_espera.Text <= 59 Then

            If MsgBox("Tempo de espera inferior ao padrão, pode-se decorrer travamentos no instagram, deseja prosseguir?", vbYesNo, "Atenção!") = vbNo Then

                Txt_espera.Focus()
                Exit Sub

            End If

        End If

        Label15.Text = "Abrindo O internet explorer"

        Me.Cursor = Cursors.WaitCursor

        Dim IE As Object

        IE = CreateObject("InternetExplorer.Application")

        Label15.Text = "Iniciando"

        IE.Navigate("https://www.instagram.com")
        IE.visible = T

        Do While IE.readystate <> 4 : Loop
        Do While IE.busy : Loop

        Dim obj1 As Object

        obj1 = IE.document.getElementsByTagName("span")
        k = 0

        System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

        While k < obj1.length

            If Trim$(obj1(k).classname) = Trim("_2dbep qNELH") Then

                obj1(k).click()
                Do While IE.readyState <> 4 : Loop
                Do While IE.busy : Loop
                System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))
                GoTo Fora_perfil

            End If

            k += 1

        End While

Fora_perfil:

        obj1 = IE.Document.getElementsByTagName("div")
        k = 0

        System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

        While k < obj1.Length

            If Trim$(obj1(k).innertext) = "Sair" Then

                obj1(k).click()
                Do While IE.ReadyState <> 4 : Loop
                Do While IE.busy : Loop
                System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))
                GoTo Fora_Perfil_cfg

            End If

            k += 1

        End While

Fora_Perfil_cfg:

        Do While IE.ReadyState <> 4 : Loop
        Do While IE.Busy : Loop
        System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

        obj1 = IE.Document.getElementsByTagName("button")
        k = 0

        While k < obj1.Length

            If Trim$(obj1(k).innertext) = "Trocar de conta" Then

                obj1(k).click()
                Do While IE.ReadyState <> 4 : Loop
                Do While IE.Busy : Loop
                System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))
                GoTo Fora_Trocar_conta1

            End If

            k += 1

        End While

Fora_Trocar_conta1:

        Notificação = "Efetue o login no instagram aberto!!! Favor sair dessa caixa de texto apenas após o login!!"
        MsgBox(Notificação, vbCritical, "Atenção!")

        Do While IE.ReadyState <> 4 : Loop
        Do While IE.Busy : Loop

        obj1 = IE.Document.getElementsByTagName("a")
        k = 0

        While k < obj1.Length

            If Trim$(obj1(k).classname) = Trim("gmFkV") Then

                obj1(k).click()
                Do While IE.ReadyState <> 4 : Loop
                Do While IE.Busy : Loop
                System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))
                GoTo Fora_perfil1

            End If

            k += 1

        End While

Fora_perfil1:

        System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

        Dim VerificaUser As String

        VerificaUser = Replace(Replace(IE.LocationURL, "https://www.instagram.com", ""), "/", "")

        Dim sql As String

        sql = "SELECT usuario, status FROM tb_usuario WHERE usuario_insta = '" & Trim(VerificaUser) & "'"

        Using TB As New DataTable()

            Dim DA As New OleDbDataAdapter(sql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA.Fill(TB)

            If TB.Rows.Count = 0 Then

                Notificação = "Usuario não encontrado no sistema, contate um administrador!!!"
                Fun_gerar_salvar_notificacao(Notificação)
                GoTo Fora_final

            Else

                If TB.Rows(0)("Status").ToString <> "Aprovado" Then

                    Notificação = "Usuario não permitido para usar o sistema, contate um administrador!!!"
                    Fun_gerar_salvar_notificacao(Notificação)
                    GoTo Fora_final

                End If

            End If

        End Using

        Dim QTDseguidores As Integer
        Dim QTDpostagens As String
        Dim QTDseguindo As String
        Dim msg As String

        obj1 = IE.Document.getElementsByTagName("span")
        Do While IE.ReadyState <> 4 : Loop
        Do While IE.Busy : Loop
        QTDpostagens = obj1(1).innertext

        obj1 = IE.Document.getElementsByTagName("span")
        Do While IE.ReadyState <> 4 : Loop
        Do While IE.Busy : Loop
        QTDseguindo = obj1(3).innertext

        obj1 = IE.Document.getElementsByTagName("span")
        Do While IE.ReadyState <> 4 : Loop
        Do While IE.Busy : Loop
        QTDseguidores = obj1(2).innertext

        msg = Now & " - " & Trim(VerificaUser) & " - " & "QTD Seguidores: " & QTDseguidores & "   QTD seguindo: " & QTDseguindo & "   QTD postagens: " & QTDpostagens

        Using cmd As New OleDbCommand With {
            .Connection = Conexao
            }

            If Var_conecet = C Then

                Var_conecet = O
                cmd.Connection.Open()

            End If

            cmd.CommandText = "INSERT into Tb_log_control (Perfil ,Controle) Values ('" & Var_user & "', '" & msg & "')"

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Atenção!")
                Var_conecet = C
                cmd.Connection.Close()
                GoTo Fora_final
            End Try
            Var_conecet = C
            cmd.Connection.Close()

        End Using

        Dim sql1 As String

        Dim obj11 As Object
        Dim ç
        Dim i
        Dim seguidores(QTDseguindo)

        obj11 = IE.Document.GetElementsByTagName("a")
        ç = 0

        Do While IE.ReadyState <> 4 : Loop
        Do While IE.Busy : Loop

        System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

        While ç < obj11.Length

            If Trim(obj11(ç).classname) = "-nal3" Then

                obj11(ç).click()

                Do While IE.ReadyState <> 4 : Loop
                Do While IE.Busy : Loop

                System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

                Dim obj22 As Object
                Dim kl
                i = 1
                obj22 = IE.Document.GetElementsByTagName("a")
                kl = 0

                While kl < obj22.Length

                    If Trim(obj22(kl).classname) = "FPmhX notranslate  _0imsa" Then

                        seguidores(i) = obj22(kl).innertext

                        Do While IE.ReadyState <> 4 : Loop
                        Do While IE.Busy : Loop

                        System.Threading.Thread.Sleep(NumeroAleatorio.Next(1000, 2000))

                        i += 1

                    End If

                    kl += 1

                End While

                Dim obj33 As Object
                Dim fg

                obj33 = IE.Document.GetElementsByTagName("button")
                fg = 0

                Do While IE.ReadyState <> 4 : Loop
                Do While IE.Busy : Loop

                System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

                While fg < obj33.Length

                    Dim Val As String = obj33(fg).innerhtml
                    Dim ValE As String = "Fechar"
                    Dim Valida As Integer = Val.IndexOf(ValE)

                    If Valida > -1 Then

                        obj33(fg).click()

                        Do While IE.ReadyState <> 4 : Loop
                        Do While IE.Busy : Loop

                        System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

                        Exit While

                    End If

                    fg += 1

                End While

                Exit While

            End If

            ç += 1

        End While

        sql1 = "SELECT Codigo, Perfil, Controle FROM Tb_log_control WHERE Perfil = '" & Trim(VerificaUser) & "'"

        Using TB1 As New DataTable()

            Dim DA1 As New OleDbDataAdapter(sql1, Conexao)
            TB1.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA1.Fill(TB1)

            If TB1.Rows.Count > 0 Then

                List_andamento.DataSource = TB1
                List_andamento.DisplayMember = "Controle"
                List_andamento.ValueMember = "Codigo"
                List_andamento.SelectedIndex = -1

            End If

        End Using

        Dim sql2 As String

        sql2 = "SELECT Perfil From Tb_perfil Where usuario_insta = '" & Trim(VerificaUser) & "' AND status = '" & "SEGUINDO" & "'"

        Using TB2 As New DataTable()

            Dim DA2 As New OleDbDataAdapter(sql2, Conexao)
            TB2.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA2.Fill(TB2)

            If TB2.Rows.Count = 0 Then

                Notificação = "Você não possui registros de perfis seguidos!"
                Fun_gerar_salvar_notificacao(Notificação)
                GoTo Fora_final

            End If

            Dim QTDperfil As Integer

            QTDperfil = TB2.Rows.Count - 1

            If QTDperfil = 0 Then

                Notificação = "Não há perfis cadastradas para esse perfil!!!"
                Fun_gerar_salvar_notificacao(Notificação)
                GoTo Fora_final

            End If

            Progress_principal.Minimum = 0
            Progress_principal.Maximum = QTDperfil

            Dim o As Integer
            Dim PerfilAtual(QTDperfil - 1)

            Dim sql3 As String

            sql3 = "SELECT Perfil, usuario, usuario_insta, status, data FROM tb_perfil " &
                   "WHERE (((tb_perfil.status) = '" & "SEGUINDO" & "')) AND (((tb_perfil.usuario_insta) = '" & Trim(VerificaUser) & "'))"

            Using TB3 As New DataTable()

                Dim DA3 As New OleDbDataAdapter(sql3, Conexao)
                TB3.Locale = System.Globalization.CultureInfo.InvariantCulture
                DA3.Fill(TB3)

                QTDperfil -= 1

                For o = 0 To QTDperfil Step 1

                    PerfilAtual(o) = TB3.Rows(o)("Perfil").ToString()

                Next

            End Using

            Dim TempoEspera As Integer = Txt_espera.Text * 1000

            Label15.Text = "Ferramenta iniciada"
            Lb_trabalho.Text = "Trabalhando no Perfil:"

            For o = 0 To QTDperfil Step 1

                Progress_principal.Value = o
                Txt_Trabalho.Text = Trim(PerfilAtual(o))
                IE.Navigate("https://www.instagram.com/" & Trim(PerfilAtual(o)))

                Do While IE.ReadyState <> 4 : Loop
                Do While IE.Busy : Loop
                System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))

                For i = 0 To QTDseguidores Step 1

                    If PerfilAtual(o) = seguidores(i) Then

                        GoTo Proximo_insta

                    End If

                Next

                Dim valor
                Dim obj As Object
                Dim A
                obj = IE.Document.getElementsByTagName("button")
                A = 0

                While A < obj.Length

                    valor = obj(A).innerhtml

                    Dim valuetxt As String = "Seguindo"

                    Dim validalike As Integer = valor.indexof(valuetxt)

                    If validalike > -1 Then

                        obj(A).Click()
                        Do While IE.ReadyState <> 4 : Loop
                        Do While IE.Busy : Loop
                        System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))
                        GoTo Proxima_foto

                    End If

                    A += 1

                End While

Proxima_foto:

                System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))
                obj = IE.Document.getElementsByTagName("button")
                A = 0

                While A < obj.Length

                    If obj(A).innertext = "Deixar de seguir" Then

                        Using cmd As New OleDbCommand With {
                            .Connection = Conexao
                            }

                            If Var_conecet = C Then

                                Var_conecet = o
                                cmd.Connection.Open()

                            End If

                            cmd.CommandText = "UPDATE tb_perfil SET status = '" & "DESLIKE OK" & "' " &
                                              "WHERE (usuario_insta = '" & Trim(VerificaUser) & "' AND perfil = '" & Trim(PerfilAtual(o)) & "')"

                            Try
                                cmd.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox(ex.Message, vbCritical, "Atenção!")
                                Var_conecet = C
                                cmd.Connection.Close()
                                GoTo Fora_final
                            End Try
                            Var_conecet = C
                            cmd.Connection.Close()

                        End Using

                        obj(A).Click()

                        Do While IE.ReadyState <> 4 : Loop
                        Do While IE.Busy : Loop
                        System.Threading.Thread.Sleep(NumeroAleatorio.Next(5000, 10000))
                        GoTo Proximo_insta

                    End If

                    A += 1

                End While

Proximo_insta:

                System.Threading.Thread.Sleep(TempoEspera + NumeroAleatorio.Next(-10000, 10000))

                Dim sql5 As String

                sql5 = "SELECT Tb_perfil.data, [Tb_perfil]![Perfil]& ""  -  "" &[tb_perfil]![status] as NOME, Tb_perfil.Status " &
                       "FROM (tb_perfil) WHERE (((tb_perfil.usuario_insta) = '" & Trim(VerificaUser) & "') and ((tb_perfil.status) = '" & "SEGUINDO" & "'))"

                Using TB6 As New DataTable()

                    Dim DA6 As New OleDbDataAdapter(sql5, Conexao)
                    TB6.Locale = System.Globalization.CultureInfo.CurrentCulture
                    DA6.Fill(TB6)

                    List_status.DataSource = TB6
                    List_status.DisplayMember = "NOME"
                    List_status.ValueMember = "data"
                    List_status.SelectedIndex = -1

                End Using

            Next

        End Using

Fora_final:

        IE.quit()
        Label15.Text = "Iniciar por deslikes"
        Me.Cursor = Cursors.Default
        Notificação = "Deslikes Terminados, Seu histórico ficou salvo!"
        Fun_gerar_salvar_notificacao(Notificação)

    End Sub

End Class