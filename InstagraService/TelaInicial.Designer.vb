<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TelaInicial
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaInicial))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Check_Coment = New System.Windows.Forms.CheckBox()
        Me.Bt_adm = New System.Windows.Forms.Button()
        Me.Bt_deslike = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Lb_iniciar_p_hashtag = New System.Windows.Forms.Label()
        Me.bt_Inicio_hashtag = New System.Windows.Forms.Button()
        Me.Txt_all_like = New System.Windows.Forms.TextBox()
        Me.Txt_like = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txt_all_folow = New System.Windows.Forms.TextBox()
        Me.Txt_folow = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Progress_principal = New System.Windows.Forms.ProgressBar()
        Me.Txt_Trabalho = New System.Windows.Forms.TextBox()
        Me.Lb_trabalho = New System.Windows.Forms.Label()
        Me.Check_seguir = New System.Windows.Forms.CheckBox()
        Me.Check_Reiniciar = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_espera = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Bt_fechar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.List_status = New System.Windows.Forms.ListBox()
        Me.Txt_Perfil_inform = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.List_andamento = New System.Windows.Forms.ListBox()
        Me.Group_Busca = New System.Windows.Forms.GroupBox()
        Me.List_Hashtag_perfil = New System.Windows.Forms.ListBox()
        Me.Bt_busca = New System.Windows.Forms.Button()
        Me.Cb_Busca = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Bt_dell_all = New System.Windows.Forms.Button()
        Me.Cb_dell_all = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cb_dell_saida = New System.Windows.Forms.ComboBox()
        Me.Bt_dell_hashtag_perfil = New System.Windows.Forms.Button()
        Me.lb_dell = New System.Windows.Forms.Label()
        Me.Cb_Dell = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txt_add = New System.Windows.Forms.TextBox()
        Me.Bt_Add_Hashtag_perfil = New System.Windows.Forms.Button()
        Me.Lb_add = New System.Windows.Forms.Label()
        Me.Cb_add = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbInferior = New System.Windows.Forms.Label()
        Me.Lb_superior = New System.Windows.Forms.Label()
        Me.Picture_ico = New System.Windows.Forms.PictureBox()
        Me.Lb_coment = New System.Windows.Forms.Label()
        Me.txt_coment = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.Group_Busca.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Picture_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Group_Busca)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1346, 723)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.txt_coment)
        Me.GroupBox6.Controls.Add(Me.Lb_coment)
        Me.GroupBox6.Controls.Add(Me.PictureBox1)
        Me.GroupBox6.Controls.Add(Me.Check_Coment)
        Me.GroupBox6.Controls.Add(Me.Bt_adm)
        Me.GroupBox6.Controls.Add(Me.Bt_deslike)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Lb_iniciar_p_hashtag)
        Me.GroupBox6.Controls.Add(Me.bt_Inicio_hashtag)
        Me.GroupBox6.Controls.Add(Me.Txt_all_like)
        Me.GroupBox6.Controls.Add(Me.Txt_like)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Txt_all_folow)
        Me.GroupBox6.Controls.Add(Me.Txt_folow)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Progress_principal)
        Me.GroupBox6.Controls.Add(Me.Txt_Trabalho)
        Me.GroupBox6.Controls.Add(Me.Lb_trabalho)
        Me.GroupBox6.Controls.Add(Me.Check_seguir)
        Me.GroupBox6.Controls.Add(Me.Check_Reiniciar)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Txt_espera)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Bt_fechar)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 396)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1334, 321)
        Me.GroupBox6.TabIndex = 20
        Me.GroupBox6.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(697, 106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(306, 148)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Check_Coment
        '
        Me.Check_Coment.AutoSize = True
        Me.Check_Coment.Location = New System.Drawing.Point(251, 79)
        Me.Check_Coment.Name = "Check_Coment"
        Me.Check_Coment.Size = New System.Drawing.Size(150, 17)
        Me.Check_Coment.TabIndex = 31
        Me.Check_Coment.Text = "Dar Like em Comentarios?"
        Me.Check_Coment.UseVisualStyleBackColor = True
        '
        'Bt_adm
        '
        Me.Bt_adm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_adm.ForeColor = System.Drawing.Color.Black
        Me.Bt_adm.Location = New System.Drawing.Point(6, 286)
        Me.Bt_adm.Name = "Bt_adm"
        Me.Bt_adm.Size = New System.Drawing.Size(86, 23)
        Me.Bt_adm.TabIndex = 30
        Me.Bt_adm.Text = "Administração"
        Me.Bt_adm.UseVisualStyleBackColor = True
        Me.Bt_adm.Visible = False
        '
        'Bt_deslike
        '
        Me.Bt_deslike.BackColor = System.Drawing.Color.Transparent
        Me.Bt_deslike.BackgroundImage = CType(resources.GetObject("Bt_deslike.BackgroundImage"), System.Drawing.Image)
        Me.Bt_deslike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_deslike.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_deslike.FlatAppearance.BorderSize = 0
        Me.Bt_deslike.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bt_deslike.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Bt_deslike.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Bt_deslike.Location = New System.Drawing.Point(1042, 118)
        Me.Bt_deslike.Name = "Bt_deslike"
        Me.Bt_deslike.Size = New System.Drawing.Size(73, 72)
        Me.Bt_deslike.TabIndex = 29
        Me.Bt_deslike.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(1009, 193)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(142, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Iniciar Por Deslikes"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lb_iniciar_p_hashtag
        '
        Me.Lb_iniciar_p_hashtag.Location = New System.Drawing.Point(518, 193)
        Me.Lb_iniciar_p_hashtag.Name = "Lb_iniciar_p_hashtag"
        Me.Lb_iniciar_p_hashtag.Size = New System.Drawing.Size(173, 13)
        Me.Lb_iniciar_p_hashtag.TabIndex = 26
        Me.Lb_iniciar_p_hashtag.Text = "Iniciar Por Hashtag"
        Me.Lb_iniciar_p_hashtag.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'bt_Inicio_hashtag
        '
        Me.bt_Inicio_hashtag.BackColor = System.Drawing.Color.Black
        Me.bt_Inicio_hashtag.BackgroundImage = CType(resources.GetObject("bt_Inicio_hashtag.BackgroundImage"), System.Drawing.Image)
        Me.bt_Inicio_hashtag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_Inicio_hashtag.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_Inicio_hashtag.FlatAppearance.BorderSize = 0
        Me.bt_Inicio_hashtag.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bt_Inicio_hashtag.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bt_Inicio_hashtag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Inicio_hashtag.ForeColor = System.Drawing.Color.White
        Me.bt_Inicio_hashtag.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bt_Inicio_hashtag.Location = New System.Drawing.Point(567, 118)
        Me.bt_Inicio_hashtag.Name = "bt_Inicio_hashtag"
        Me.bt_Inicio_hashtag.Size = New System.Drawing.Size(73, 72)
        Me.bt_Inicio_hashtag.TabIndex = 22
        Me.bt_Inicio_hashtag.UseVisualStyleBackColor = False
        '
        'Txt_all_like
        '
        Me.Txt_all_like.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_all_like.Location = New System.Drawing.Point(1085, 47)
        Me.Txt_all_like.Name = "Txt_all_like"
        Me.Txt_all_like.ReadOnly = True
        Me.Txt_all_like.Size = New System.Drawing.Size(110, 20)
        Me.Txt_all_like.TabIndex = 25
        Me.Txt_all_like.Text = "0"
        Me.Txt_all_like.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_like
        '
        Me.Txt_like.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_like.Location = New System.Drawing.Point(1085, 15)
        Me.Txt_like.Name = "Txt_like"
        Me.Txt_like.ReadOnly = True
        Me.Txt_like.Size = New System.Drawing.Size(110, 20)
        Me.Txt_like.TabIndex = 24
        Me.Txt_like.Text = "0"
        Me.Txt_like.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(918, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Quantidade de Fotos já Curtidas:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(958, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Quantidade de Curtidas:"
        '
        'Txt_all_folow
        '
        Me.Txt_all_folow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_all_folow.Location = New System.Drawing.Point(635, 51)
        Me.Txt_all_folow.Name = "Txt_all_folow"
        Me.Txt_all_folow.ReadOnly = True
        Me.Txt_all_folow.Size = New System.Drawing.Size(110, 20)
        Me.Txt_all_folow.TabIndex = 21
        Me.Txt_all_folow.Text = "0"
        Me.Txt_all_folow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_folow
        '
        Me.Txt_folow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_folow.Location = New System.Drawing.Point(635, 19)
        Me.Txt_folow.Name = "Txt_folow"
        Me.Txt_folow.ReadOnly = True
        Me.Txt_folow.Size = New System.Drawing.Size(110, 20)
        Me.Txt_folow.TabIndex = 20
        Me.Txt_folow.Text = "0"
        Me.Txt_folow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(462, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(167, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Quantidade de Perfis já Seguidos:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(473, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Quantidade de Perfis Seguidos:"
        '
        'Progress_principal
        '
        Me.Progress_principal.Location = New System.Drawing.Point(376, 282)
        Me.Progress_principal.Name = "Progress_principal"
        Me.Progress_principal.Size = New System.Drawing.Size(868, 23)
        Me.Progress_principal.TabIndex = 17
        '
        'Txt_Trabalho
        '
        Me.Txt_Trabalho.BackColor = System.Drawing.Color.White
        Me.Txt_Trabalho.Location = New System.Drawing.Point(178, 218)
        Me.Txt_Trabalho.Name = "Txt_Trabalho"
        Me.Txt_Trabalho.ReadOnly = True
        Me.Txt_Trabalho.Size = New System.Drawing.Size(179, 20)
        Me.Txt_Trabalho.TabIndex = 16
        '
        'Lb_trabalho
        '
        Me.Lb_trabalho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_trabalho.Location = New System.Drawing.Point(21, 221)
        Me.Lb_trabalho.Name = "Lb_trabalho"
        Me.Lb_trabalho.Size = New System.Drawing.Size(151, 13)
        Me.Lb_trabalho.TabIndex = 15
        Me.Lb_trabalho.Text = "Trabalhando na Hashtag:"
        Me.Lb_trabalho.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Check_seguir
        '
        Me.Check_seguir.AutoSize = True
        Me.Check_seguir.Checked = True
        Me.Check_seguir.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Check_seguir.Location = New System.Drawing.Point(251, 56)
        Me.Check_seguir.Name = "Check_seguir"
        Me.Check_seguir.Size = New System.Drawing.Size(101, 17)
        Me.Check_seguir.TabIndex = 14
        Me.Check_seguir.Text = "Seguir Usuário?"
        Me.Check_seguir.UseVisualStyleBackColor = True
        '
        'Check_Reiniciar
        '
        Me.Check_Reiniciar.AutoSize = True
        Me.Check_Reiniciar.Checked = True
        Me.Check_Reiniciar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Check_Reiniciar.Location = New System.Drawing.Point(251, 102)
        Me.Check_Reiniciar.Name = "Check_Reiniciar"
        Me.Check_Reiniciar.Size = New System.Drawing.Size(114, 17)
        Me.Check_Reiniciar.TabIndex = 13
        Me.Check_Reiniciar.Text = "Reiniciar Sozinha?"
        Me.Check_Reiniciar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(56, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "(1 - Equivale a 1 Segundo)"
        '
        'Txt_espera
        '
        Me.Txt_espera.Location = New System.Drawing.Point(139, 68)
        Me.Txt_espera.Name = "Txt_espera"
        Me.Txt_espera.Size = New System.Drawing.Size(100, 20)
        Me.Txt_espera.TabIndex = 11
        Me.Txt_espera.Text = "60"
        Me.Txt_espera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tempo de Espera:"
        '
        'Bt_fechar
        '
        Me.Bt_fechar.BackColor = System.Drawing.Color.DimGray
        Me.Bt_fechar.BackgroundImage = CType(resources.GetObject("Bt_fechar.BackgroundImage"), System.Drawing.Image)
        Me.Bt_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_fechar.FlatAppearance.BorderSize = 0
        Me.Bt_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Bt_fechar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Bt_fechar.Location = New System.Drawing.Point(1261, 247)
        Me.Bt_fechar.Name = "Bt_fechar"
        Me.Bt_fechar.Size = New System.Drawing.Size(60, 58)
        Me.Bt_fechar.TabIndex = 9
        Me.Bt_fechar.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.List_status)
        Me.GroupBox5.Controls.Add(Me.Txt_Perfil_inform)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.List_andamento)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(6, 119)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1079, 276)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Processamento"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DarkGray
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(865, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "      Perfil                  Status"
        '
        'List_status
        '
        Me.List_status.FormattingEnabled = True
        Me.List_status.Location = New System.Drawing.Point(865, 32)
        Me.List_status.Name = "List_status"
        Me.List_status.Size = New System.Drawing.Size(208, 238)
        Me.List_status.TabIndex = 20
        '
        'Txt_Perfil_inform
        '
        Me.Txt_Perfil_inform.BackColor = System.Drawing.Color.LightCoral
        Me.Txt_Perfil_inform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Perfil_inform.Location = New System.Drawing.Point(751, 145)
        Me.Txt_Perfil_inform.Name = "Txt_Perfil_inform"
        Me.Txt_Perfil_inform.ReadOnly = True
        Me.Txt_Perfil_inform.Size = New System.Drawing.Size(108, 20)
        Me.Txt_Perfil_inform.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(626, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Perfil Do Instagram:"
        '
        'List_andamento
        '
        Me.List_andamento.FormattingEnabled = True
        Me.List_andamento.Location = New System.Drawing.Point(6, 19)
        Me.List_andamento.Name = "List_andamento"
        Me.List_andamento.Size = New System.Drawing.Size(614, 251)
        Me.List_andamento.TabIndex = 0
        '
        'Group_Busca
        '
        Me.Group_Busca.Controls.Add(Me.List_Hashtag_perfil)
        Me.Group_Busca.Controls.Add(Me.Bt_busca)
        Me.Group_Busca.Controls.Add(Me.Cb_Busca)
        Me.Group_Busca.Controls.Add(Me.Label2)
        Me.Group_Busca.ForeColor = System.Drawing.Color.White
        Me.Group_Busca.Location = New System.Drawing.Point(1091, 19)
        Me.Group_Busca.Name = "Group_Busca"
        Me.Group_Busca.Size = New System.Drawing.Size(249, 376)
        Me.Group_Busca.TabIndex = 18
        Me.Group_Busca.TabStop = False
        Me.Group_Busca.Text = "Hashtag"
        '
        'List_Hashtag_perfil
        '
        Me.List_Hashtag_perfil.FormattingEnabled = True
        Me.List_Hashtag_perfil.Location = New System.Drawing.Point(6, 19)
        Me.List_Hashtag_perfil.Name = "List_Hashtag_perfil"
        Me.List_Hashtag_perfil.Size = New System.Drawing.Size(237, 290)
        Me.List_Hashtag_perfil.TabIndex = 17
        '
        'Bt_busca
        '
        Me.Bt_busca.BackColor = System.Drawing.Color.Transparent
        Me.Bt_busca.BackgroundImage = CType(resources.GetObject("Bt_busca.BackgroundImage"), System.Drawing.Image)
        Me.Bt_busca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_busca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_busca.FlatAppearance.BorderSize = 0
        Me.Bt_busca.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bt_busca.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Bt_busca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_busca.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Bt_busca.Location = New System.Drawing.Point(202, 328)
        Me.Bt_busca.Name = "Bt_busca"
        Me.Bt_busca.Size = New System.Drawing.Size(39, 38)
        Me.Bt_busca.TabIndex = 16
        Me.Bt_busca.UseVisualStyleBackColor = False
        '
        'Cb_Busca
        '
        Me.Cb_Busca.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cb_Busca.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Busca.FormattingEnabled = True
        Me.Cb_Busca.Location = New System.Drawing.Point(95, 338)
        Me.Cb_Busca.Name = "Cb_Busca"
        Me.Cb_Busca.Size = New System.Drawing.Size(91, 21)
        Me.Cb_Busca.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Buscar Por:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Bt_dell_all)
        Me.GroupBox4.Controls.Add(Me.Cb_dell_all)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(732, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(353, 94)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Deletar Registros"
        '
        'Bt_dell_all
        '
        Me.Bt_dell_all.BackColor = System.Drawing.Color.Transparent
        Me.Bt_dell_all.BackgroundImage = CType(resources.GetObject("Bt_dell_all.BackgroundImage"), System.Drawing.Image)
        Me.Bt_dell_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_dell_all.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_dell_all.FlatAppearance.BorderSize = 0
        Me.Bt_dell_all.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bt_dell_all.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Bt_dell_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_dell_all.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Bt_dell_all.Location = New System.Drawing.Point(268, 23)
        Me.Bt_dell_all.Name = "Bt_dell_all"
        Me.Bt_dell_all.Size = New System.Drawing.Size(61, 56)
        Me.Bt_dell_all.TabIndex = 14
        Me.Bt_dell_all.UseVisualStyleBackColor = False
        '
        'Cb_dell_all
        '
        Me.Cb_dell_all.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cb_dell_all.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_dell_all.FormattingEnabled = True
        Me.Cb_dell_all.Location = New System.Drawing.Point(88, 42)
        Me.Cb_dell_all.Name = "Cb_dell_all"
        Me.Cb_dell_all.Size = New System.Drawing.Size(145, 21)
        Me.Cb_dell_all.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Deletar:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Cb_dell_saida)
        Me.GroupBox3.Controls.Add(Me.Bt_dell_hashtag_perfil)
        Me.GroupBox3.Controls.Add(Me.lb_dell)
        Me.GroupBox3.Controls.Add(Me.Cb_Dell)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(369, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(357, 94)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Deletar"
        '
        'Cb_dell_saida
        '
        Me.Cb_dell_saida.FormattingEnabled = True
        Me.Cb_dell_saida.Location = New System.Drawing.Point(75, 23)
        Me.Cb_dell_saida.Name = "Cb_dell_saida"
        Me.Cb_dell_saida.Size = New System.Drawing.Size(202, 21)
        Me.Cb_dell_saida.TabIndex = 15
        '
        'Bt_dell_hashtag_perfil
        '
        Me.Bt_dell_hashtag_perfil.BackColor = System.Drawing.Color.Transparent
        Me.Bt_dell_hashtag_perfil.BackgroundImage = CType(resources.GetObject("Bt_dell_hashtag_perfil.BackgroundImage"), System.Drawing.Image)
        Me.Bt_dell_hashtag_perfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_dell_hashtag_perfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_dell_hashtag_perfil.FlatAppearance.BorderSize = 0
        Me.Bt_dell_hashtag_perfil.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bt_dell_hashtag_perfil.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Bt_dell_hashtag_perfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_dell_hashtag_perfil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Bt_dell_hashtag_perfil.Location = New System.Drawing.Point(283, 22)
        Me.Bt_dell_hashtag_perfil.Name = "Bt_dell_hashtag_perfil"
        Me.Bt_dell_hashtag_perfil.Size = New System.Drawing.Size(61, 56)
        Me.Bt_dell_hashtag_perfil.TabIndex = 14
        Me.Bt_dell_hashtag_perfil.UseVisualStyleBackColor = False
        '
        'lb_dell
        '
        Me.lb_dell.AutoSize = True
        Me.lb_dell.Location = New System.Drawing.Point(10, 26)
        Me.lb_dell.Name = "lb_dell"
        Me.lb_dell.Size = New System.Drawing.Size(50, 13)
        Me.lb_dell.TabIndex = 10
        Me.lb_dell.Text = "Hashtag:"
        Me.lb_dell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cb_Dell
        '
        Me.Cb_Dell.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cb_Dell.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Dell.FormattingEnabled = True
        Me.Cb_Dell.Location = New System.Drawing.Point(75, 58)
        Me.Cb_Dell.Name = "Cb_Dell"
        Me.Cb_Dell.Size = New System.Drawing.Size(78, 21)
        Me.Cb_Dell.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Deletar:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Txt_add)
        Me.GroupBox2.Controls.Add(Me.Bt_Add_Hashtag_perfil)
        Me.GroupBox2.Controls.Add(Me.Lb_add)
        Me.GroupBox2.Controls.Add(Me.Cb_add)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 94)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Adicionar Registro"
        '
        'Txt_add
        '
        Me.Txt_add.Location = New System.Drawing.Point(80, 23)
        Me.Txt_add.Name = "Txt_add"
        Me.Txt_add.Size = New System.Drawing.Size(197, 20)
        Me.Txt_add.TabIndex = 1
        '
        'Bt_Add_Hashtag_perfil
        '
        Me.Bt_Add_Hashtag_perfil.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Add_Hashtag_perfil.BackgroundImage = CType(resources.GetObject("Bt_Add_Hashtag_perfil.BackgroundImage"), System.Drawing.Image)
        Me.Bt_Add_Hashtag_perfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_Add_Hashtag_perfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_Add_Hashtag_perfil.FlatAppearance.BorderSize = 0
        Me.Bt_Add_Hashtag_perfil.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bt_Add_Hashtag_perfil.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Bt_Add_Hashtag_perfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_Add_Hashtag_perfil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Bt_Add_Hashtag_perfil.Location = New System.Drawing.Point(283, 22)
        Me.Bt_Add_Hashtag_perfil.Name = "Bt_Add_Hashtag_perfil"
        Me.Bt_Add_Hashtag_perfil.Size = New System.Drawing.Size(61, 56)
        Me.Bt_Add_Hashtag_perfil.TabIndex = 14
        Me.Bt_Add_Hashtag_perfil.UseVisualStyleBackColor = False
        '
        'Lb_add
        '
        Me.Lb_add.AutoSize = True
        Me.Lb_add.Location = New System.Drawing.Point(10, 26)
        Me.Lb_add.Name = "Lb_add"
        Me.Lb_add.Size = New System.Drawing.Size(50, 13)
        Me.Lb_add.TabIndex = 10
        Me.Lb_add.Text = "Hashtag:"
        Me.Lb_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cb_add
        '
        Me.Cb_add.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cb_add.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_add.FormattingEnabled = True
        Me.Cb_add.Location = New System.Drawing.Point(80, 57)
        Me.Cb_add.Name = "Cb_add"
        Me.Cb_add.Size = New System.Drawing.Size(78, 21)
        Me.Cb_add.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Adicionar:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LbInferior
        '
        Me.LbInferior.BackColor = System.Drawing.Color.Black
        Me.LbInferior.Location = New System.Drawing.Point(-14, 751)
        Me.LbInferior.Name = "LbInferior"
        Me.LbInferior.Size = New System.Drawing.Size(1380, 22)
        Me.LbInferior.TabIndex = 8
        Me.LbInferior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lb_superior
        '
        Me.Lb_superior.BackColor = System.Drawing.Color.Black
        Me.Lb_superior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_superior.ForeColor = System.Drawing.Color.White
        Me.Lb_superior.Location = New System.Drawing.Point(-3, 0)
        Me.Lb_superior.Name = "Lb_superior"
        Me.Lb_superior.Size = New System.Drawing.Size(1376, 22)
        Me.Lb_superior.TabIndex = 9
        Me.Lb_superior.Text = "          BRS - Sistemas"
        Me.Lb_superior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Picture_ico
        '
        Me.Picture_ico.BackColor = System.Drawing.Color.Black
        Me.Picture_ico.BackgroundImage = CType(resources.GetObject("Picture_ico.BackgroundImage"), System.Drawing.Image)
        Me.Picture_ico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Picture_ico.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Picture_ico.Location = New System.Drawing.Point(6, 1)
        Me.Picture_ico.Name = "Picture_ico"
        Me.Picture_ico.Size = New System.Drawing.Size(25, 21)
        Me.Picture_ico.TabIndex = 22
        Me.Picture_ico.TabStop = False
        '
        'Lb_coment
        '
        Me.Lb_coment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_coment.Location = New System.Drawing.Point(21, 168)
        Me.Lb_coment.Name = "Lb_coment"
        Me.Lb_coment.Size = New System.Drawing.Size(151, 13)
        Me.Lb_coment.TabIndex = 33
        Me.Lb_coment.Text = "Deixar o comentario:"
        Me.Lb_coment.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_coment
        '
        Me.txt_coment.BackColor = System.Drawing.Color.White
        Me.txt_coment.Location = New System.Drawing.Point(178, 165)
        Me.txt_coment.Name = "txt_coment"
        Me.txt_coment.Size = New System.Drawing.Size(179, 20)
        Me.txt_coment.TabIndex = 34
        '
        'TelaInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 773)
        Me.Controls.Add(Me.Picture_ico)
        Me.Controls.Add(Me.Lb_superior)
        Me.Controls.Add(Me.LbInferior)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TelaInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serviço do Instagram"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Group_Busca.ResumeLayout(False)
        Me.Group_Busca.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Picture_ico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LbInferior As Label
    Friend WithEvents Bt_fechar As Button
    Friend WithEvents Cb_add As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_add As TextBox
    Friend WithEvents Lb_add As Label
    Friend WithEvents Bt_Add_Hashtag_perfil As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Cb_dell_saida As ComboBox
    Friend WithEvents Bt_dell_hashtag_perfil As Button
    Friend WithEvents lb_dell As Label
    Friend WithEvents Cb_Dell As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Bt_dell_all As Button
    Friend WithEvents Cb_dell_all As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Group_Busca As GroupBox
    Friend WithEvents Bt_busca As Button
    Friend WithEvents Cb_Busca As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents List_Hashtag_perfil As ListBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Txt_Perfil_inform As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents List_andamento As ListBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents List_status As ListBox
    Friend WithEvents Txt_espera As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Check_Reiniciar As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Check_seguir As CheckBox
    Friend WithEvents Progress_principal As ProgressBar
    Friend WithEvents Txt_Trabalho As TextBox
    Friend WithEvents Lb_trabalho As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Bt_deslike As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Lb_iniciar_p_hashtag As Label
    Friend WithEvents bt_Inicio_hashtag As Button
    Friend WithEvents Txt_all_like As TextBox
    Friend WithEvents Txt_like As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Txt_all_folow As TextBox
    Friend WithEvents Txt_folow As TextBox
    Friend WithEvents Lb_superior As Label
    Friend WithEvents Picture_ico As PictureBox
    Friend WithEvents Bt_adm As Button
    Friend WithEvents Check_Coment As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_coment As TextBox
    Friend WithEvents Lb_coment As Label
End Class
