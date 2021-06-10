Imports Tulpep.NotificationWindow
Imports System.Data.OleDb
Imports System.Threading.Thread
Imports System.Globalization
Imports System.IO

Public Class Administração

    Private Sub Administração_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        Fun_valida_user()

    End Sub

    Private Sub Bt_reload_Click(sender As Object, e As EventArgs) Handles Bt_reload.Click

        Fun_Atualizar()

    End Sub

    Private Sub Bt_cancelar_Click(sender As Object, e As EventArgs) Handles bt_cancelar.Click

        TelaInicial.Visible = T
        Me.Close()

    End Sub

    Private Sub Bt_atualizar_Click(sender As Object, e As EventArgs) Handles Bt_atualizar.Click

        Fun_Atualizar()

        MsgBox("Licenças atualizadas com sucesso!", vbInformation, "Atenção!")
        Progress_update.Visible = F

    End Sub

    Private Sub Administração_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cb_busca.Items.Add("Hashtag")
        Cb_busca.Items.Add("Bloqueados")

        Fun_Atualizar()

    End Sub

    Private Sub Bt_comtrol_Click(sender As Object, e As EventArgs) Handles Bt_comtrol.Click

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        Controle_Usuario.ShowDialog()

    End Sub

    Private Sub Bt_pend_banir_Click(sender As Object, e As EventArgs) Handles bt_pend_banir.Click

        If Txt_pend_usuario.Text = "" Then

            Txt_defn_licença.Focus()
            MsgBox("Favor selecionar um email!", vbCritical, "Atenção!")
            Exit Sub

        End If

        Email_fun = Txt_pend_email.Text

        Fun_Banimento()

        Txt_pend_data.Text = ""
        Txt_pend_email.Text = ""
        Txt_pend_sexo.Text = ""
        Txt_pend_usuario.Text = ""
        Txt_defn_licença.Text = ""
        Txt_defn_licença.Focus()

    End Sub

    Private Sub Bt_banir_user_Click(sender As Object, e As EventArgs) Handles Bt_banir_user.Click

        If Txt_email.Text = "" Then

            Cb_busca.Focus()
            MsgBox("Favor Selecionar um email!", vbCritical, "Atenção!")
            Exit Sub

        End If

        Email_fun = Txt_email.Text

        Fun_Banimento()

        Txt_pend_data.Text = ""
        Txt_pend_email.Text = ""
        Txt_pend_sexo.Text = ""
        Txt_pend_usuario.Text = ""
        Txt_defn_licença.Text = ""
        Txt_defn_licença.Focus()

    End Sub

    Private Sub Dg_pendentes_DoubleClick(sender As Object, e As EventArgs) Handles Dg_pendentes.DoubleClick

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        If Dg_pendentes.CurrentRow.Cells(0).FormattedValue = "" Then

            Exit Sub

        End If

        Txt_pend_data.Text = ""
        Txt_pend_email.Text = ""
        Txt_pend_sexo.Text = ""
        Txt_pend_usuario.Text = ""
        Txt_insta_user_pend.Text = ""
        Txt_defn_licença.Focus()

        vsql = "SELECT usuario, email, sexo, data, uxuario_insta from tb_usuario where Email = '" & Dg_pendentes.CurrentRow.Cells(0).Value & "'"

        Using TB As New DataTable()

            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA.Fill(TB)

            Txt_pend_usuario.Text = TB.Rows(0)("usuario").ToString
            Txt_pend_email.Text = TB.Rows(0)("email").ToString
            Txt_insta_user_pend.Text = TB.Rows(0)("usuario_insta").ToString
            Txt_pend_sexo.Text = TB.Rows(0)("sexo").ToString
            Txt_pend_data.Text = TB.Rows(0)("data").ToString

        End Using

    End Sub

    Private Sub Bt_pend_aprovar_Click(sender As Object, e As EventArgs) Handles Bt_pend_aprovar.Click

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        If Txt_pend_usuario.Text = "" Then

            Txt_defn_licença.Focus()
            MsgBox("Favor selecionar um email!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If Txt_defn_licença.Text = "" Then

            Txt_defn_licença.Focus()
            MsgBox("Fevor inserir uma data limite para a licança!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If Txt_defn_licença.Text < Now Then

            Txt_defn_licença.Text = ""
            Txt_defn_licença.Focus()
            MsgBox("Licença deve ser maior que a data de hoje!", vbCritical, "Atenção!")
            Exit Sub

        End If

        Using cmd As New OleDbCommand With {
                .Connection = Conexao
        }

            If Var_conecet = C Then

                Var_conecet = O
                cmd.Connection.Open()

            End If

            cmd.CommandText = "UPDATE tb_usuario set status = '" & "Aprovado" & "', licenca = '" & Txt_defn_licença.Text & "', lic_ex = '" & "Em dia" & "', on_off = '" & "Offline" & "'" &
                              "WHERE email = '" & Txt_pend_email.Text & "'"

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

            QTD_Perfis_lib += 1

        End Using

        Fun_Carregar()

        MsgBox("Usuario aprovado!", vbInformation, "Atenção!")

        Txt_pend_data.Text = ""
        Txt_pend_email.Text = ""
        Txt_pend_sexo.Text = ""
        Txt_insta_user_pend.Text = ""
        Txt_pend_usuario.Text = ""
        Txt_defn_licença.Text = ""
        Txt_defn_licença.Focus()

    End Sub

    Private Sub Dg_banido_DoubleClick(sender As Object, e As EventArgs) Handles dg_banido.DoubleClick

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        If dg_banido.CurrentRow.Cells(0).FormattedValue = "" Then

            Exit Sub

        End If

        Txt_ban_data.Text = ""
        Txt_ban_email.Text = ""
        Txt_ban_sexo.Text = ""
        Txt_ban_usuario.Text = ""
        Txt_ban_user_isnta.Text = ""
        Txt_redeterm_licenca.Text = ""
        Txt_redeterm_licenca.Focus()

        vsql = "SELECT usuario, email, sexo, data, licenca, usuario_insta from tb_usuario where email = '" & dg_banido.CurrentRow.Cells(0).Value & "'"

        Using TB As New DataTable()

            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA.Fill(TB)

            Txt_ban_email.Text = TB.Rows(0)("Email").ToString
            Txt_ban_usuario.Text = TB.Rows(0)("usuario").ToString
            Txt_ban_user_isnta.Text = TB.Rows(0)("usuario_insta").ToString
            Txt_ban_sexo.Text = TB.Rows(0)("sexo").ToString
            Txt_ban_data.Text = TB.Rows(0)("Data").ToString
            Txt_redeterm_licenca.Text = TB.Rows(0)("licenca").ToString

        End Using

        Txt_redeterm_licenca.Focus()

    End Sub

    Private Sub Bt_re_aprovar_Click(sender As Object, e As EventArgs) Handles Bt_re_aprovar.Click

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        If Txt_redeterm_licenca.Text = "" Then

            Txt_redeterm_licenca.Focus()
            MsgBox("Favor selecionar uma data limite para a licença!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If MsgBox("Você tem certeza que deseja re-aprovar o usuario?", vbYesNo, "Atenção!") = vbYes Then

            Using cmd As New OleDbCommand With {
                    .Connection = Conexao
            }

                If Var_conecet = C Then

                    Var_conecet = O
                    cmd.Connection.Open()

                End If

                cmd.CommandText = "UPDATE tb_usuario set status = '" & "Aprovado" & "', licenca = '" & Txt_redeterm_licenca.Text & "'" &
                                  "Where email = '" & Txt_ban_email.Text & "'"

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

                QTD_perfis_desbloq += 1

            End Using

            Fun_Carregar()

            MsgBox("Usuario Reaprovado com Sucesso!", vbInformation, "Atenção!")

            Txt_ban_data.Text = ""
            Txt_ban_email.Text = ""
            Txt_ban_sexo.Text = ""
            Txt_ban_user_isnta.Text = ""
            Txt_ban_usuario.Text = ""
            Txt_redeterm_licenca.Text = ""
            Txt_redeterm_licenca.Focus()

        End If

    End Sub

    Private Sub Dg_user_DoubleClick(sender As Object, e As EventArgs) Handles dg_user.DoubleClick

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        If dg_user.CurrentRow.Cells(0).FormattedValue = "" Then

            Exit Sub

        End If

        Txt_user.Text = ""
        Txt_email.Text = ""
        Txt_sexo.Text = ""
        Txt_data.Text = ""
        Txt_red_licenca.Text = ""
        UserVerifica = ""
        Bt_comtrol.Visible = T

        vsql = "SELECT usuario, email, usuario_insta, sexo, data, licenca, on_off From TB_usuario WHERE email = '" & dg_user.CurrentRow.Cells(0).Value & "'"

        Using TB As New DataTable()

            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA.Fill(TB)

            Txt_user.Text = TB.Rows(0)("usuario").ToString & " - " & TB.Rows(0)("on_off").ToString
            UserVerifica = TB.Rows(0)("usuario").ToString
            Txt_email.Text = TB.Rows(0)("Email").ToString
            Txt_insta_user.Text = TB.Rows(0)("usuario_insta").ToString
            Txt_sexo.Text = TB.Rows(0)("sexo").ToString
            Txt_data.Text = TB.Rows(0)("Data").ToString
            Txt_red_licenca.Text = TB.Rows(0)("licenca").ToString

        End Using

        Cb_busca.Focus()

    End Sub

    Private Sub Bt_re_det_Click(sender As Object, e As EventArgs) Handles Bt_re_det.Click

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        If Txt_email.Text = "" Then

            MsgBox("favor  selecionar umm usuario!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If Txt_red_licenca.Text = "" Then

            Txt_red_licenca.Focus()
            MsgBox("Favor selecionar uma data limite para a licença!", vbCritical, "Atenção")
            Exit Sub

        End If

        If Txt_red_licenca.Text < Now Then

            Txt_red_licenca.Text = ""
            Txt_red_licenca.Focus()
            MsgBox("Nova data de licença deve ser maior que a data de hoje!", vbCritical, "Atenção!")
            Exit Sub

        End If

        vsql = "SELECT licenca from tb_usuario WHERE email = '" & Txt_email.Text & "'"

        Using TB3 As New DataTable()

            Dim DA3 As New OleDbDataAdapter(vsql, Conexao)
            TB3.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA3.Fill(TB3)

            If TB3.Rows(0)("licenca").ToString = Txt_red_licenca.Text Then

                Txt_red_licenca.Text = ""
                Txt_red_licenca.Focus()
                MsgBox("Nova liceça deve ser diferente da atual!", vbCritical, "Atenção!")
                Exit Sub

            End If

        End Using

        Using cmd As New OleDbCommand With {
                 .Connection = Conexao
        }

            If Var_conecet = C Then

                Var_conecet = O
                cmd.Connection.Open()

            End If

            cmd.CommandText = "UPDATE tb_usuario set licenca = '" & Txt_red_licenca.Text & "'" &
                              "WHERE email = '" & Txt_email.Text & "'"

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

        Fun_Carregar()

        Txt_user.Text = ""
        Txt_email.Text = ""
        Txt_insta_user.Text = ""
        Txt_sexo.Text = ""
        Txt_data.Text = ""
        Txt_red_licenca.Text = ""
        UserVerifica = ""
        MsgBox("Licença redefinida!", vbInformation, "Atenção!")

    End Sub

    Private Sub Bt_Busca_Click(sender As Object, e As EventArgs) Handles Bt_Busca.Click

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        If Txt_user.Text = "" Then

            MsgBox("Favor selecionar um usuario!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If Cb_busca.Text = "" Then

            MsgBox("Favor selecionar uma forma de busca!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If Cb_busca.Text = "Hashtag" Then

            Var_busca = "Hashtag"

            vsql = "SELECT hashtag FROM tb_hashtag WHERE (((tb_hashtag.usuario) = '" & UserVerifica & "'))"

            Dim TB As New DataTable()
            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA.Fill(TB)
            List_busca.DataSource = TB
            List_busca.DisplayMember = "hashtag"
            List_busca.ValueMember = "hashtag"
            List_busca.SelectedIndex = -1

        End If

        If Cb_busca.Text = "Bloqueados" Then

            Var_busca = "Bloqueados"

            vsql = "SELECT Bloqueado FROM Tb_Block WHERE (((tb_Block.usuario) = '" & UserVerifica & "'))"

            Dim TB As New DataTable()
            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA.Fill(TB)
            List_busca.DataSource = TB
            List_busca.DisplayMember = "Bloqueado"
            List_busca.ValueMember = "Bloqueado"
            List_busca.SelectedIndex = -1

        End If

        Cb_busca.Text = Var_busca

    End Sub

    Private Sub Dg_expirado_DoubleClick(sender As Object, e As EventArgs) Handles Dg_expirado.DoubleClick

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        If Dg_expirado.CurrentRow.Cells(0).FormattedValue = "" Then

            Exit Sub

        End If

        txt_user_expirado.Text = ""
        Txt_email_expirado.Text = ""
        txt_sexo_expirado.Text = ""
        txt_data_expirada.Text = ""
        Txt_lic_user_insta.Text = ""
        txt_renovar_licenca.Text = ""
        txt_renovar_licenca.Focus()

        vsql = "SELECT usuario, email, sexo, data, licenca, usuario_insta FROM tb_usuario where email = '" & Dg_expirado.CurrentRow.Cells(0).Value & "'"

        Using TB As New DataTable()

            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA.Fill(TB)

            txt_user_expirado.Text = TB.Rows(0)("usuario").ToString
            Txt_email_expirado.Text = TB.Rows(0)("email").ToString
            Txt_lic_user_insta.Text = TB.Rows(0)("usuario_insta").ToString
            txt_sexo_expirado.Text = TB.Rows(0)("sexo").ToString
            txt_data_expirada.Text = TB.Rows(0)("data").ToString
            txt_renovar_licenca.Text = TB.Rows(0)("licenca").ToString

        End Using

    End Sub

    Private Sub Bt_renovar_Licenca_Click(sender As Object, e As EventArgs) Handles Bt_renovar_Licenca.Click

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        If Txt_email_expirado.Text = "" Then

            txt_renovar_licenca.Focus()
            MsgBox("favor selecionar um perfil!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If txt_renovar_licenca.Text = "" Then

            txt_renovar_licenca.Focus()
            MsgBox("Favor inserir uma data limite para a licenaça!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If txt_renovar_licenca.Text < Now Then

            txt_renovar_licenca.Focus()
            MsgBox("Data limite da licença deve ser maior qque a data de hoje!", vbCritical, "Atenção!")
            Exit Sub

        End If

        vsql = "SELECT licenca FROM tb_usuario WHERE email = '" & Txt_email_expirado.Text & "'"

        Using TB As New DataTable()

            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA.Fill(TB)

            If txt_renovar_licenca.Text = TB.Rows(0)("licenca").ToString Then

                txt_renovar_licenca.Focus()
                MsgBox("Favor Alterar a data limite da licença!", vbCritical, "Atenção!")
                Exit Sub

            End If

        End Using

        Using cmd As New OleDbCommand With {
                 .Connection = Conexao
        }

            If Var_conecet = C Then

                Var_conecet = O
                cmd.Connection.Open()

            End If

            cmd.CommandText = "UPDATE tb_usuario set licenca = '" & txt_renovar_licenca.Text & "', lic_ex = '" & "Em dia" & "'" &
                              "Where email = '" & Txt_email_expirado.Text & "'"

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

            QTD_licencas_renov += 1

        End Using

        Fun_Carregar()

        txt_user_expirado.Text = ""
        Txt_email_expirado.Text = ""
        txt_sexo_expirado.Text = ""
        txt_data_expirada.Text = ""
        txt_renovar_licenca.Text = ""
        Txt_lic_user_insta.Text = ""
        txt_renovar_licenca.Focus()
        MsgBox("Licença renovada com sucesso!", vbInformation, "Atenção!")

    End Sub

End Class