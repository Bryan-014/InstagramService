Imports Tulpep.NotificationWindow
Imports System.Data.OleDb
Imports System.Threading.Thread
Imports System.Globalization

Public Class Controle_Usuario

    Private Sub Controle_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Verifica_conexao()

        If aprovação = F Then

            Me.Close()

        End If

        Dim sql As String

        sql = "SELECT Usuario, Email, sexo, Data, licenca, Tipo_usuario, on_off, usuario_insta FROM tb_usuario WHERE usuario = '" & UserVerifica & "'"

        Using TB As New DataTable()

            Dim DA As New OleDbDataAdapter(sql, Conexao)
            TB.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA.Fill(TB)

            Txt_user.Text = TB.Rows(0)("usuario").ToString & " / " & TB.Rows(0)("Tipo_usuario").ToString & " - " & TB.Rows(0)("on_off").ToString
            Txt_email.Text = TB.Rows(0)("Email").ToString
            Txt_user_insta.Text = TB.Rows(0)("usuario_insta").ToString
            Txt_sexo.Text = TB.Rows(0)("sexo").ToString
            Txt_data.Text = TB.Rows(0)("Data").ToString
            Txt_red_licenca.Text = TB.Rows(0)("licenca").ToString

        End Using

        Dim sql1 As String

        sql1 = "SELECT hashtag, data FROM tb_hashtag WHERE usuario = '" & UserVerifica & "'"

        Using TB1 As New DataTable()

            Dim DA1 As New OleDbDataAdapter(sql1, Conexao)
            TB1.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA1.Fill(TB1)

            If TB1.Rows.Count = 0 Then

                dg_Hashtag.DataSource = ""
                dg_Hashtag.Enabled = F
                GoTo Skip

            End If

            dg_Hashtag.DataSource = TB1
            dg_Hashtag.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            dg_Hashtag.AutoResizeColumns()
            dg_Hashtag.Enabled = T

        End Using

Skip:

        Dim sql2 As String

        sql2 = "SELECT Perfil, status, data FROM tb_Perfil WHERE usuario = '" & UserVerifica & "'"

        Using TB2 As New DataTable()

            Dim DA2 As New OleDbDataAdapter(sql2, Conexao)
            TB2.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA2.Fill(TB2)

            If TB2.Rows.Count = 0 Then

                Dg_perfis.DataSource = ""
                Dg_perfis.Enabled = F
                GoTo Skip1

            End If

            Dg_perfis.DataSource = TB2
            Dg_perfis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Dg_perfis.AutoResizeColumns()
            Dg_perfis.Enabled = T

        End Using

Skip1:

        Dim sql3 As String

        sql3 = "SELECT Bloqueado, data FROM tb_block WHERE usuario = '" & UserVerifica & "'"

        Using TB3 As New DataTable()

            Dim DA3 As New OleDbDataAdapter(sql3, Conexao)
            TB3.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA3.Fill(TB3)

            If TB3.Rows.Count = 0 Then

                Dg_blocks.DataSource = ""
                Dg_blocks.Enabled = F
                GoTo Skip2

            End If

            Dg_blocks.DataSource = TB3
            Dg_blocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Dg_blocks.AutoResizeColumns()
            Dg_blocks.Enabled = T

        End Using

Skip2:

        Dim sql4 As String

        sql4 = "SELECT Controle FROM tb_log_control WHERE (((tb_log_control.Perfil) = '" & UserVerifica & "'))"

        Using TB4 As New DataTable()

            Dim DA4 As New OleDbDataAdapter(sql4, Conexao)
            TB4.Locale = System.Globalization.CultureInfo.CurrentCulture
            DA4.Fill(TB4)

            If TB4.Rows.Count = 0 Then

                Dg_control.DataSource = ""
                Dg_control.Enabled = F
                GoTo Skip3

            End If

            Dg_control.DataSource = TB4
            Dg_control.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
            Dg_control.AutoResizeColumns()
            Dg_control.Enabled = T

        End Using

Skip3:

    End Sub

    Private Sub Bt_fechar_Click(sender As Object, e As EventArgs) Handles Bt_fechar.Click

        Me.Close()

    End Sub

End Class