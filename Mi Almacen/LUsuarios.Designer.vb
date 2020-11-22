<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LUsuarios
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.imguspb = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.userlb = New System.Windows.Forms.ListBox()
        Me.ustxt = New System.Windows.Forms.TextBox()
        Me.edadtxt = New System.Windows.Forms.TextBox()
        Me.dnitxt = New System.Windows.Forms.TextBox()
        Me.teltxt = New System.Windows.Forms.TextBox()
        Me.apetxt = New System.Windows.Forms.TextBox()
        Me.nomtxt = New System.Windows.Forms.TextBox()
        Me.cargtxt = New System.Windows.Forms.TextBox()
        Me.filtxt = New System.Windows.Forms.TextBox()
        Me.exppdfbtn = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        CType(Me.imguspb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.imguspb)
        Me.Panel1.Location = New System.Drawing.Point(289, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 290)
        Me.Panel1.TabIndex = 42
        '
        'imguspb
        '
        Me.imguspb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imguspb.Location = New System.Drawing.Point(0, 0)
        Me.imguspb.Name = "imguspb"
        Me.imguspb.Padding = New System.Windows.Forms.Padding(10)
        Me.imguspb.Size = New System.Drawing.Size(318, 290)
        Me.imguspb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imguspb.TabIndex = 9
        Me.imguspb.TabStop = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Usuario"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Edad"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "DNI"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Cargo"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "FILTRO"
        '
        'userlb
        '
        Me.userlb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.userlb.FormattingEnabled = True
        Me.userlb.Location = New System.Drawing.Point(644, 98)
        Me.userlb.Name = "userlb"
        Me.userlb.Size = New System.Drawing.Size(138, 290)
        Me.userlb.TabIndex = 31
        '
        'ustxt
        '
        Me.ustxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ustxt.Location = New System.Drawing.Point(107, 349)
        Me.ustxt.Name = "ustxt"
        Me.ustxt.Size = New System.Drawing.Size(150, 20)
        Me.ustxt.TabIndex = 30
        '
        'edadtxt
        '
        Me.edadtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.edadtxt.Location = New System.Drawing.Point(107, 302)
        Me.edadtxt.Name = "edadtxt"
        Me.edadtxt.Size = New System.Drawing.Size(80, 20)
        Me.edadtxt.TabIndex = 28
        '
        'dnitxt
        '
        Me.dnitxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dnitxt.Location = New System.Drawing.Point(107, 264)
        Me.dnitxt.Name = "dnitxt"
        Me.dnitxt.Size = New System.Drawing.Size(150, 20)
        Me.dnitxt.TabIndex = 27
        '
        'teltxt
        '
        Me.teltxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.teltxt.Location = New System.Drawing.Point(107, 226)
        Me.teltxt.Name = "teltxt"
        Me.teltxt.Size = New System.Drawing.Size(150, 20)
        Me.teltxt.TabIndex = 26
        '
        'apetxt
        '
        Me.apetxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.apetxt.Location = New System.Drawing.Point(107, 185)
        Me.apetxt.Name = "apetxt"
        Me.apetxt.Size = New System.Drawing.Size(150, 20)
        Me.apetxt.TabIndex = 25
        '
        'nomtxt
        '
        Me.nomtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nomtxt.Location = New System.Drawing.Point(107, 138)
        Me.nomtxt.Name = "nomtxt"
        Me.nomtxt.Size = New System.Drawing.Size(150, 20)
        Me.nomtxt.TabIndex = 24
        '
        'cargtxt
        '
        Me.cargtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cargtxt.Location = New System.Drawing.Point(107, 98)
        Me.cargtxt.Name = "cargtxt"
        Me.cargtxt.Size = New System.Drawing.Size(150, 20)
        Me.cargtxt.TabIndex = 23
        '
        'filtxt
        '
        Me.filtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.filtxt.Location = New System.Drawing.Point(128, 54)
        Me.filtxt.Name = "filtxt"
        Me.filtxt.Size = New System.Drawing.Size(504, 20)
        Me.filtxt.TabIndex = 22
        '
        'exppdfbtn
        '
        Me.exppdfbtn.IconChar = FontAwesome.Sharp.IconChar.None
        Me.exppdfbtn.IconColor = System.Drawing.Color.Black
        Me.exppdfbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.exppdfbtn.Location = New System.Drawing.Point(259, 426)
        Me.exppdfbtn.Name = "exppdfbtn"
        Me.exppdfbtn.Size = New System.Drawing.Size(385, 54)
        Me.exppdfbtn.TabIndex = 43
        Me.exppdfbtn.Text = "IMPRIMIR USUARIOS PDF"
        Me.exppdfbtn.UseVisualStyleBackColor = True
        '
        'LUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 527)
        Me.Controls.Add(Me.exppdfbtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.userlb)
        Me.Controls.Add(Me.ustxt)
        Me.Controls.Add(Me.edadtxt)
        Me.Controls.Add(Me.dnitxt)
        Me.Controls.Add(Me.teltxt)
        Me.Controls.Add(Me.apetxt)
        Me.Controls.Add(Me.nomtxt)
        Me.Controls.Add(Me.cargtxt)
        Me.Controls.Add(Me.filtxt)
        Me.MinimumSize = New System.Drawing.Size(834, 566)
        Me.Name = "LUsuarios"
        Me.Text = "LUsuarios"
        Me.Panel1.ResumeLayout(False)
        CType(Me.imguspb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents imguspb As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents userlb As ListBox
    Friend WithEvents ustxt As TextBox
    Friend WithEvents edadtxt As TextBox
    Friend WithEvents dnitxt As TextBox
    Friend WithEvents teltxt As TextBox
    Friend WithEvents apetxt As TextBox
    Friend WithEvents nomtxt As TextBox
    Friend WithEvents cargtxt As TextBox
    Friend WithEvents filtxt As TextBox
    Friend WithEvents exppdfbtn As FontAwesome.Sharp.IconButton
End Class
