Imports Tulpep.NotificationWindow
Imports System.Data.OleDb
Imports System.Threading.Thread
Imports System.Globalization

Public Class Cadastrar

    Dim usuario_len As Integer
    Dim usuario As String
    Dim Email_len As Integer
    Dim email_valid As String
    Dim email As String
    Dim senha_len As Integer
    Dim senha As String
    Dim check_valid As String
    Dim UserIn As String

    Private Sub Cadastrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Lb_valid_usuario.Visible = T
        Lb_valid_usuario.Text = ""
        lb_valid_email.Visible = T
        lb_valid_email.Text = ""
        Lb_valid_rep_email.Visible = T
        Lb_valid_rep_email.Text = ""
        Lb_valid_senha.Visible = T
        Lb_valid_senha.Text = ""
        Lb_valid_rep_senha.Visible = T
        Lb_valid_rep_senha.Text = ""
        Lb_valid_genero.Visible = T
        Lb_valid_genero.Text = ""

    End Sub

    Private Sub Bt_fechar_Click(sender As Object, e As EventArgs) Handles Bt_fechar.Click

        Login.Visible = T
        Me.Close()

    End Sub

    Private Sub Txt_usuario_LostFocus(sender As Object, e As EventArgs) Handles Txt_usuario.LostFocus

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        usuario_len = Len(Txt_usuario.Text)

        If usuario_len = 0 Then

            Lb_valid_usuario.Visible = T
            Lb_valid_usuario.Text = "*Favor inserir usuario."
            Exit Sub

        End If

        If usuario_len <= 2 Then

            Lb_valid_usuario.Visible = T
            Lb_valid_usuario.Text = "*Usuario muito curto."
            Exit Sub

        End If

        vsql = "SELECT usuario FROM tb_usuario WHERE usuario = '" & Txt_usuario.Text & "'"

        Using TB As New DataTable()

            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA.Fill(TB)

            If TB.Rows.Count <> 0 Then

                Lb_valid_usuario.Visible = T
                Lb_valid_usuario.Text = "*Usuario ja existente."
                Exit Sub

            End If

        End Using

        Lb_valid_usuario.Visible = F
        usuario = Txt_usuario.Text

    End Sub

    Private Sub Txt_email_LostFocus(sender As Object, e As EventArgs) Handles Txt_email.LostFocus

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        Email_len = Len(Txt_email.Text)
        email_valid = ""

        If Email_len = 0 Then

            lb_valid_email.Visible = T
            lb_valid_email.Text = "*Favor inserir um email."
            Exit Sub

        End If

        If Email_len <= 10 Then

            lb_valid_email.Visible = T
            lb_valid_email.Text = "*Email deve conter uma extenção @gmail.com."
            Exit Sub

        End If

        Dim i As Integer = 1
        Dim email_char As String
        Dim result As String
        Dim tamanho As Integer
        Dim valida As String = "não"
        email_char = Txt_email.Text
        result = Mid(Txt_email.Text, i, 1)
        tamanho = Len(Txt_email.Text)

        For i = 1 To tamanho Step 1

            result = Mid(Txt_email.Text, i, 1)

            If result = "@" Then

                valida = "sim"
                email_valid &= "@"

            End If

            If valida = "sim" Then

                If result = "g" Then

                    email_valid &= "g"

                End If

                If result = "m" Then

                    email_valid &= "m"

                End If

                If result = "a" Then

                    email_valid &= "a"

                End If

                If result = "i" Then

                    email_valid &= "i"

                End If

                If result = "l" Then

                    email_valid &= "l"

                End If

                If result = "." Then

                    email_valid &= "."

                End If

                If result = "c" Then

                    email_valid &= "c"

                End If

                If result = "o" Then

                    email_valid &= "o"

                End If

                If result = "m" Then

                    If email_valid = "@gmail.co" Then

                        email_valid &= "m"

                    End If

                End If

            End If

        Next

        If valida = "não" Then

            lb_valid_email.Visible = T
            lb_valid_email.Text = "*Email deve conter um @."
            Exit Sub

        End If

        If email_valid <> "@gmail.com" Then

            lb_valid_email.Visible = T
            lb_valid_email.Text = "*Email deve conter uma extenção @gmail.com."
            Exit Sub

        End If

        vsql = "SELECT email FROM tb_usuario WHERE email = '" & Txt_email.Text & "'"

        Using TB As New DataTable()

            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.InvariantCulture
            DA.Fill(TB)

            If TB.Rows.Count <> 0 Then

                lb_valid_email.Visible = T
                lb_valid_email.Text = "*Email ja existente."
                Exit Sub

            End If

        End Using

        lb_valid_email.Visible = F

    End Sub

    Private Sub Txt_rep_email_LostFocus(sender As Object, e As EventArgs) Handles Txt_rep_email.LostFocus

        If Txt_rep_email.Text <> Txt_email.Text Then

            Lb_valid_rep_email.Visible = T
            Lb_valid_rep_email.Text = "*Emails não combinam."
            Exit Sub

        End If

        email = Txt_rep_email.Text
        Lb_valid_rep_email.Visible = F

    End Sub

    Private Sub Txt_senha_LostFocus(sender As Object, e As EventArgs) Handles Txt_senha.LostFocus

        senha_len = Len(Txt_senha.Text)

        If senha_len = 0 Then

            Lb_valid_senha.Visible = T
            Lb_valid_senha.Text = "*favor inserir senha."
            Exit Sub

        End If

        If senha_len <= 5 Then

            Lb_valid_senha.Visible = T
            Lb_valid_senha.Text = "*Senha deve conter ao minimo 6 caracteres."
            Exit Sub

        End If

        Lb_valid_senha.Visible = F

    End Sub

    Private Sub Txt_rep_senha_LostFocus(sender As Object, e As EventArgs) Handles Txt_rep_senha.LostFocus

        If Txt_rep_senha.Text <> Txt_senha.Text Then

            Lb_valid_rep_senha.Visible = T
            Lb_valid_rep_senha.Text = "Senhas não combinam"
            Exit Sub

        End If

        senha = Txt_rep_senha.Text
        Lb_valid_rep_senha.Visible = F

    End Sub

    Private Sub Txt_usuario_instagram_LostFocus(sender As Object, e As EventArgs) Handles Txt_usuario_instagram.LostFocus

        If Txt_usuario_instagram.Text = "" Then

            Lb_valid_inst_user.Visible = T
            Lb_valid_inst_user.Text = "Favor informar seu usuario do instagram!"
            Exit Sub

        End If

        UserIn = Replace(Txt_usuario_instagram.Text, "@", "")
        UserIn = Replace(UserIn, " ", "_")

        Dim sql1 As String

        sql1 = "SELECT usuario_insta FROM tb_usuario WHERE usuario_insta = '" & UserIn & "'"

        Using TB As New DataTable()

            Dim DA As New OleDbDataAdapter(sql1, Conexao)
            TB.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA.Fill(TB)

            If TB.Rows.Count <> 0 Then

                Lb_valid_inst_user.Visible = T
                Lb_valid_inst_user.Text = "Usuario ja existe, contate um adm caso seja sua conta!"
                Exit Sub

            End If

        End Using

        Lb_valid_inst_user.Visible = F

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = T Then

            CheckBox2.Checked = F
            check_valid = "Masculino"
            GoTo Check1

        End If

        check_valid = ""

Check1:

        If check_valid = "" Then

            Lb_valid_genero.Visible = T
            Lb_valid_genero.Text = "*Favor selecionar um genero."
            Exit Sub

        End If

        Lb_valid_genero.Visible = F

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = T Then

            CheckBox1.Checked = F
            check_valid = "Feminino"
            GoTo Check2

        End If

        check_valid = ""

Check2:

        If check_valid = "" Then

            Lb_valid_genero.Visible = T
            Lb_valid_genero.Text = "*Favor selecionar um genero."
            Exit Sub

        End If

        Lb_valid_genero.Visible = F

    End Sub

    Private Sub Bt_cadastrar_Click(sender As Object, e As EventArgs) Handles Bt_cadastrar.Click

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        If Lb_valid_usuario.Visible = T Then

            MsgBox("Favor Preencher todos os campos!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If lb_valid_email.Visible = T Then

            MsgBox("Favor Preencher todos os campos!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If Lb_valid_rep_email.Visible = T Then

            MsgBox("Favor Preencher todos os campos!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If Lb_valid_senha.Visible = T Then

            MsgBox("Favor Preencher todos os campos!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If Lb_valid_senha.Visible = T Then

            MsgBox("Favor Preencher todos os campos!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If Lb_valid_inst_user.Visible = T Then

            MsgBox("Favor Preencher todos os campoa!", vbCritical, "Atenção!")
            Exit Sub

        End If

        If Lb_valid_genero.Visible = T Then

            MsgBox("Favor Preencher todos os campos!", vbCritical, "Atenção!")
            Exit Sub

        End If

        Using cmd As New OleDbCommand With {
            .Connection = Conexao
        }

            If Var_conecet = "fechado" Then

                cmd.Connection.Open()
                Var_conecet = "aberto"

            End If

            cmd.CommandText = "INSERT into tb_usuario (usuario, usuario_insta, senha, email, sexo, data, status, tipo_usuario) values" &
                              "('" & usuario & "', '" & UserIn & "', '" & senha & "', '" & email & "', '" & check_valid & "', '" & Now & "', '" & "Pendente" & "', '" & "USER" & "')"

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.Connection.Close()
                Var_conecet = "fechado"
                MsgBox(ex.Message, vbCritical, "Atenção!")
                Exit Sub
            End Try
            cmd.Connection.Close()

            Var_conecet = "fechado"

        End Using

        MsgBox("Aguardar por confirmação!", vbInformation, "Atenção!")

        Login.Visible = T

        Txt_usuario.Text = ""
        Txt_email.Text = ""
        Txt_rep_email.Text = ""
        Txt_senha.Text = ""
        Txt_rep_senha.Text = ""
        CheckBox1.Checked = F
        CheckBox2.Checked = F

        Me.Close()

    End Sub

End Class