<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastrar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastrar))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_usuario_instagram = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Lb_valid_inst_user = New System.Windows.Forms.Label()
        Me.Bt_fechar = New System.Windows.Forms.Button()
        Me.Bt_cadastrar = New System.Windows.Forms.Button()
        Me.Lb_valid_genero = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lb_valid_rep_senha = New System.Windows.Forms.Label()
        Me.Txt_rep_senha = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_senha = New System.Windows.Forms.TextBox()
        Me.Lb_valid_senha = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lb_valid_rep_email = New System.Windows.Forms.Label()
        Me.Txt_rep_email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lb_valid_email = New System.Windows.Forms.Label()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_usuario = New System.Windows.Forms.TextBox()
        Me.Lb_valid_usuario = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(-4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(405, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "       BRS Sistemas"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(-4, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "       Sistemas BRS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(17, 17)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(29, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Usuário:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.Txt_usuario_instagram)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Lb_valid_inst_user)
        Me.GroupBox1.Controls.Add(Me.Bt_fechar)
        Me.GroupBox1.Controls.Add(Me.Bt_cadastrar)
        Me.GroupBox1.Controls.Add(Me.Lb_valid_genero)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Lb_valid_rep_senha)
        Me.GroupBox1.Controls.Add(Me.Txt_rep_senha)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Txt_senha)
        Me.GroupBox1.Controls.Add(Me.Lb_valid_senha)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Lb_valid_rep_email)
        Me.GroupBox1.Controls.Add(Me.Txt_rep_email)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lb_valid_email)
        Me.GroupBox1.Controls.Add(Me.Txt_email)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_usuario)
        Me.GroupBox1.Controls.Add(Me.Lb_valid_usuario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 359)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cadastrar"
        '
        'Txt_usuario_instagram
        '
        Me.Txt_usuario_instagram.Location = New System.Drawing.Point(106, 221)
        Me.Txt_usuario_instagram.Name = "Txt_usuario_instagram"
        Me.Txt_usuario_instagram.Size = New System.Drawing.Size(238, 20)
        Me.Txt_usuario_instagram.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(14, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "User do Insta:"
        '
        'Lb_valid_inst_user
        '
        Me.Lb_valid_inst_user.AutoSize = True
        Me.Lb_valid_inst_user.ForeColor = System.Drawing.Color.Red
        Me.Lb_valid_inst_user.Location = New System.Drawing.Point(102, 242)
        Me.Lb_valid_inst_user.Name = "Lb_valid_inst_user"
        Me.Lb_valid_inst_user.Size = New System.Drawing.Size(60, 13)
        Me.Lb_valid_inst_user.TabIndex = 28
        Me.Lb_valid_inst_user.Text = "Validação7"
        Me.Lb_valid_inst_user.Visible = False
        '
        'Bt_fechar
        '
        Me.Bt_fechar.BackColor = System.Drawing.Color.Transparent
        Me.Bt_fechar.BackgroundImage = CType(resources.GetObject("Bt_fechar.BackgroundImage"), System.Drawing.Image)
        Me.Bt_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_fechar.FlatAppearance.BorderSize = 0
        Me.Bt_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bt_fechar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Bt_fechar.Location = New System.Drawing.Point(297, 295)
        Me.Bt_fechar.Name = "Bt_fechar"
        Me.Bt_fechar.Size = New System.Drawing.Size(60, 58)
        Me.Bt_fechar.TabIndex = 10
        Me.Bt_fechar.UseVisualStyleBackColor = False
        '
        'Bt_cadastrar
        '
        Me.Bt_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_cadastrar.ForeColor = System.Drawing.Color.Black
        Me.Bt_cadastrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Bt_cadastrar.Location = New System.Drawing.Point(182, 330)
        Me.Bt_cadastrar.Name = "Bt_cadastrar"
        Me.Bt_cadastrar.Size = New System.Drawing.Size(75, 23)
        Me.Bt_cadastrar.TabIndex = 9
        Me.Bt_cadastrar.Text = "Cadastrar"
        Me.Bt_cadastrar.UseVisualStyleBackColor = True
        '
        'Lb_valid_genero
        '
        Me.Lb_valid_genero.AutoSize = True
        Me.Lb_valid_genero.ForeColor = System.Drawing.Color.Red
        Me.Lb_valid_genero.Location = New System.Drawing.Point(125, 278)
        Me.Lb_valid_genero.Name = "Lb_valid_genero"
        Me.Lb_valid_genero.Size = New System.Drawing.Size(60, 13)
        Me.Lb_valid_genero.TabIndex = 25
        Me.Lb_valid_genero.Text = "Validação6"
        Me.Lb_valid_genero.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(209, 258)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox2.TabIndex = 8
        Me.CheckBox2.Text = "Feminino"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(128, 258)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(74, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Masculino"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(53, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Gênero:"
        '
        'Lb_valid_rep_senha
        '
        Me.Lb_valid_rep_senha.AutoSize = True
        Me.Lb_valid_rep_senha.ForeColor = System.Drawing.Color.Red
        Me.Lb_valid_rep_senha.Location = New System.Drawing.Point(102, 205)
        Me.Lb_valid_rep_senha.Name = "Lb_valid_rep_senha"
        Me.Lb_valid_rep_senha.Size = New System.Drawing.Size(60, 13)
        Me.Lb_valid_rep_senha.TabIndex = 21
        Me.Lb_valid_rep_senha.Text = "Validação5"
        Me.Lb_valid_rep_senha.Visible = False
        '
        'Txt_rep_senha
        '
        Me.Txt_rep_senha.Location = New System.Drawing.Point(105, 182)
        Me.Txt_rep_senha.Name = "Txt_rep_senha"
        Me.Txt_rep_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_rep_senha.Size = New System.Drawing.Size(238, 20)
        Me.Txt_rep_senha.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(13, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Repetir Senha:"
        '
        'Txt_senha
        '
        Me.Txt_senha.Location = New System.Drawing.Point(105, 143)
        Me.Txt_senha.Name = "Txt_senha"
        Me.Txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_senha.Size = New System.Drawing.Size(238, 20)
        Me.Txt_senha.TabIndex = 4
        '
        'Lb_valid_senha
        '
        Me.Lb_valid_senha.AutoSize = True
        Me.Lb_valid_senha.ForeColor = System.Drawing.Color.Red
        Me.Lb_valid_senha.Location = New System.Drawing.Point(102, 166)
        Me.Lb_valid_senha.Name = "Lb_valid_senha"
        Me.Lb_valid_senha.Size = New System.Drawing.Size(60, 13)
        Me.Lb_valid_senha.TabIndex = 17
        Me.Lb_valid_senha.Text = "Validação4"
        Me.Lb_valid_senha.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(30, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Senha:"
        '
        'Lb_valid_rep_email
        '
        Me.Lb_valid_rep_email.AutoSize = True
        Me.Lb_valid_rep_email.ForeColor = System.Drawing.Color.Red
        Me.Lb_valid_rep_email.Location = New System.Drawing.Point(102, 127)
        Me.Lb_valid_rep_email.Name = "Lb_valid_rep_email"
        Me.Lb_valid_rep_email.Size = New System.Drawing.Size(60, 13)
        Me.Lb_valid_rep_email.TabIndex = 15
        Me.Lb_valid_rep_email.Text = "Validação3"
        Me.Lb_valid_rep_email.Visible = False
        '
        'Txt_rep_email
        '
        Me.Txt_rep_email.Location = New System.Drawing.Point(105, 104)
        Me.Txt_rep_email.Name = "Txt_rep_email"
        Me.Txt_rep_email.Size = New System.Drawing.Size(239, 20)
        Me.Txt_rep_email.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(13, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Repetir Email:"
        '
        'lb_valid_email
        '
        Me.lb_valid_email.AutoSize = True
        Me.lb_valid_email.ForeColor = System.Drawing.Color.Red
        Me.lb_valid_email.Location = New System.Drawing.Point(102, 88)
        Me.lb_valid_email.Name = "lb_valid_email"
        Me.lb_valid_email.Size = New System.Drawing.Size(60, 13)
        Me.lb_valid_email.TabIndex = 12
        Me.lb_valid_email.Text = "Validação2"
        Me.lb_valid_email.Visible = False
        '
        'Txt_email
        '
        Me.Txt_email.Location = New System.Drawing.Point(105, 65)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(238, 20)
        Me.Txt_email.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(33, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Email:"
        '
        'Txt_usuario
        '
        Me.Txt_usuario.Location = New System.Drawing.Point(105, 24)
        Me.Txt_usuario.Name = "Txt_usuario"
        Me.Txt_usuario.Size = New System.Drawing.Size(238, 20)
        Me.Txt_usuario.TabIndex = 1
        '
        'Lb_valid_usuario
        '
        Me.Lb_valid_usuario.AutoSize = True
        Me.Lb_valid_usuario.ForeColor = System.Drawing.Color.Red
        Me.Lb_valid_usuario.Location = New System.Drawing.Point(102, 47)
        Me.Lb_valid_usuario.Name = "Lb_valid_usuario"
        Me.Lb_valid_usuario.Size = New System.Drawing.Size(60, 13)
        Me.Lb_valid_usuario.TabIndex = 8
        Me.Lb_valid_usuario.Text = "Validação1"
        Me.Lb_valid_usuario.Visible = False
        '
        'Cadastrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(387, 400)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cadastrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_rep_email As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lb_valid_email As Label
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_usuario As TextBox
    Friend WithEvents Lb_valid_usuario As Label
    Friend WithEvents Lb_valid_rep_email As Label
    Friend WithEvents Lb_valid_genero As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Lb_valid_rep_senha As Label
    Friend WithEvents Txt_rep_senha As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_senha As TextBox
    Friend WithEvents Lb_valid_senha As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Bt_cadastrar As Button
    Friend WithEvents Bt_fechar As Button
    Friend WithEvents Txt_usuario_instagram As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Lb_valid_inst_user As Label
End Class
