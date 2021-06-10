Imports Tulpep.NotificationWindow
Imports System.Data.OleDb
Imports System.Threading.Thread
Imports System.Threading
Imports System.Globalization

Public Class Login

    Private Sub Bt_entrar_Click(sender As Object, e As EventArgs) Handles Bt_entrar.Click

        Fun_entrar()

    End Sub

    Private Sub Txt_email_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_email.KeyUp

        If e.KeyCode = 13 Then

            Fun_entrar()

        End If

    End Sub

    Private Sub Txt_Senha_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Senha.KeyUp

        If e.KeyCode = 13 Then

            Fun_entrar()

        End If

    End Sub

    Private Sub Txt_Usuario_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Usuario.KeyUp

        If e.KeyCode = 13 Then

            Fun_entrar()

        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LB_inferior.Text = "VS 1.2                                                                                            BRS Sistemas"
        Txt_Senha.PasswordChar = "*"

        Verifica_conexao()

    End Sub

    Private Sub Bt_fechar_Click(sender As Object, e As EventArgs) Handles Bt_fechar.Click

        If MsgBox("Você Deseja fechar o programa?", vbYesNo, "Atenção") = vbYes Then

            Me.Close()

        Else

            MsgBox("Fechamento Cancelado!", vbInformation, "Atenção!")

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bt_cadastrar.Click

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        Me.Visible = F
        MsgBox("Favor se Cadastrar com o mesmo Email da compra do aplicativo, Caso contrario, não nos " &
               "responsabilizamos por reprovações de contas!", vbInformation, "Atenção!")
        Cadastrar.Show()

    End Sub

    Private Sub Txt_email_LostFocus(sender As Object, e As EventArgs) Handles txt_email.LostFocus

        Verifica_conexao()

        If aprovação = F Then

            Exit Sub

        End If

        If txt_email.Text = "" Then

            Exit Sub

        End If

        vsql = "SELECT usuario FROM tb_usuario WHERE email = '" & txt_email.Text & "'"

        Using TB As New DataTable()

            Dim DA As New OleDbDataAdapter(vsql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA.Fill(TB)

            If TB.Rows.Count = 1 Then

                Txt_Usuario.Text = TB.Rows(0)("usuario").ToString

            Else

                Notificação = "Usuario não encontrado no sistema!"
                Fun_gerar_salvar_notificacao(Notificação)
                txt_email.Focus()

            End If

        End Using

    End Sub

End Class