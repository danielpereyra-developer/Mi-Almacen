<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.loginp = New System.Windows.Forms.Panel()
        Me.ingbtn = New FontAwesome.Sharp.IconButton()
        Me.minbtn = New FontAwesome.Sharp.IconButton()
        Me.closebtn = New FontAwesome.Sharp.IconButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.usertxt = New System.Windows.Forms.TextBox()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.loginp.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginp
        '
        Me.loginp.Controls.Add(Me.ingbtn)
        Me.loginp.Controls.Add(Me.minbtn)
        Me.loginp.Controls.Add(Me.closebtn)
        Me.loginp.Controls.Add(Me.PictureBox3)
        Me.loginp.Controls.Add(Me.PictureBox2)
        Me.loginp.Controls.Add(Me.PictureBox1)
        Me.loginp.Controls.Add(Me.usertxt)
        Me.loginp.Controls.Add(Me.passtxt)
        Me.loginp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.loginp.Location = New System.Drawing.Point(0, 0)
        Me.loginp.Name = "loginp"
        Me.loginp.Size = New System.Drawing.Size(414, 481)
        Me.loginp.TabIndex = 0
        '
        'ingbtn
        '
        Me.ingbtn.BackColor = System.Drawing.Color.Green
        Me.ingbtn.FlatAppearance.BorderSize = 0
        Me.ingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ingbtn.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingbtn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt
        Me.ingbtn.IconColor = System.Drawing.Color.Black
        Me.ingbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ingbtn.IconSize = 40
        Me.ingbtn.Location = New System.Drawing.Point(94, 395)
        Me.ingbtn.Name = "ingbtn"
        Me.ingbtn.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ingbtn.Size = New System.Drawing.Size(224, 46)
        Me.ingbtn.TabIndex = 19
        Me.ingbtn.Text = "INGRESAR"
        Me.ingbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ingbtn.UseVisualStyleBackColor = False
        '
        'minbtn
        '
        Me.minbtn.FlatAppearance.BorderSize = 0
        Me.minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minbtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.minbtn.IconColor = System.Drawing.Color.Black
        Me.minbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.minbtn.IconSize = 24
        Me.minbtn.Location = New System.Drawing.Point(357, 0)
        Me.minbtn.Name = "minbtn"
        Me.minbtn.Size = New System.Drawing.Size(30, 26)
        Me.minbtn.TabIndex = 18
        Me.minbtn.UseVisualStyleBackColor = True
        '
        'closebtn
        '
        Me.closebtn.FlatAppearance.BorderSize = 0
        Me.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closebtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.closebtn.IconColor = System.Drawing.Color.Black
        Me.closebtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.closebtn.IconSize = 24
        Me.closebtn.Location = New System.Drawing.Point(384, 0)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(30, 26)
        Me.closebtn.TabIndex = 17
        Me.closebtn.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Mi_Almacen.My.Resources.Resources.candado_cerrado
        Me.PictureBox3.Location = New System.Drawing.Point(103, 342)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Mi_Almacen.My.Resources.Resources.usuario__2_
        Me.PictureBox2.Location = New System.Drawing.Point(103, 295)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Mi_Almacen.My.Resources.Resources.usuario_de_perfil
        Me.PictureBox1.Location = New System.Drawing.Point(94, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 209)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'usertxt
        '
        Me.usertxt.BackColor = System.Drawing.Color.Orange
        Me.usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usertxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usertxt.Location = New System.Drawing.Point(134, 299)
        Me.usertxt.Name = "usertxt"
        Me.usertxt.Size = New System.Drawing.Size(170, 20)
        Me.usertxt.TabIndex = 13
        Me.usertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'passtxt
        '
        Me.passtxt.BackColor = System.Drawing.Color.Orange
        Me.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passtxt.Location = New System.Drawing.Point(134, 346)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passtxt.Size = New System.Drawing.Size(170, 20)
        Me.passtxt.TabIndex = 10
        Me.passtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(414, 481)
        Me.Controls.Add(Me.loginp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(430, 520)
        Me.MinimumSize = New System.Drawing.Size(430, 520)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.loginp.ResumeLayout(False)
        Me.loginp.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loginp As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents usertxt As TextBox
    Friend WithEvents passtxt As TextBox
    Friend WithEvents minbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents closebtn As FontAwesome.Sharp.IconButton
    Friend WithEvents ingbtn As FontAwesome.Sharp.IconButton
End Class
