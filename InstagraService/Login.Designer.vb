<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bt_cadastrar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Bt_fechar = New System.Windows.Forms.Button()
        Me.Bt_entrar = New System.Windows.Forms.Button()
        Me.Txt_Senha = New System.Windows.Forms.TextBox()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LB_inferior = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Bt_cadastrar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_email)
        Me.GroupBox1.Controls.Add(Me.Bt_fechar)
        Me.GroupBox1.Controls.Add(Me.Bt_entrar)
        Me.GroupBox1.Controls.Add(Me.Txt_Senha)
        Me.GroupBox1.Controls.Add(Me.Txt_Usuario)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Bt_cadastrar
        '
        Me.Bt_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_cadastrar.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.Bt_cadastrar, "Bt_cadastrar")
        Me.Bt_cadastrar.Name = "Bt_cadastrar"
        Me.Bt_cadastrar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'txt_email
        '
        resources.ApplyResources(Me.txt_email, "txt_email")
        Me.txt_email.Name = "txt_email"
        '
        'Bt_fechar
        '
        Me.Bt_fechar.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Bt_fechar, "Bt_fechar")
        Me.Bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_fechar.FlatAppearance.BorderSize = 0
        Me.Bt_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Bt_fechar.Name = "Bt_fechar"
        Me.Bt_fechar.UseVisualStyleBackColor = False
        '
        'Bt_entrar
        '
        Me.Bt_entrar.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Bt_entrar, "Bt_entrar")
        Me.Bt_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_entrar.FlatAppearance.BorderSize = 0
        Me.Bt_entrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Bt_entrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Bt_entrar.Name = "Bt_entrar"
        Me.Bt_entrar.UseVisualStyleBackColor = False
        '
        'Txt_Senha
        '
        resources.ApplyResources(Me.Txt_Senha, "Txt_Senha")
        Me.Txt_Senha.Name = "Txt_Senha"
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.BackColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.Txt_Usuario, "Txt_Usuario")
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.ReadOnly = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'LB_inferior
        '
        Me.LB_inferior.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.LB_inferior, "LB_inferior")
        Me.LB_inferior.Name = "LB_inferior"
        '
        'Login
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.Controls.Add(Me.LB_inferior)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_Senha As TextBox
    Friend WithEvents Txt_Usuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Bt_fechar As Button
    Friend WithEvents Bt_entrar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Bt_cadastrar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents LB_inferior As Label
End Class
