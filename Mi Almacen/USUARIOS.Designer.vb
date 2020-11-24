<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class USUARIOS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(USUARIOS))
        Me.pnomtxt = New System.Windows.Forms.TextBox()
        Me.apetxt = New System.Windows.Forms.TextBox()
        Me.celtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.edadtxt = New System.Windows.Forms.TextBox()
        Me.dnitxt = New System.Windows.Forms.TextBox()
        Me.nomustxt = New System.Windows.Forms.TextBox()
        Me.passustxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tccb = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Archivos = New System.Windows.Forms.OpenFileDialog()
        Me.imgpb = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.imgpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnomtxt
        '
        Me.pnomtxt.Location = New System.Drawing.Point(59, 30)
        Me.pnomtxt.Name = "pnomtxt"
        Me.pnomtxt.Size = New System.Drawing.Size(100, 20)
        Me.pnomtxt.TabIndex = 1
        '
        'apetxt
        '
        Me.apetxt.Location = New System.Drawing.Point(165, 30)
        Me.apetxt.Name = "apetxt"
        Me.apetxt.Size = New System.Drawing.Size(181, 20)
        Me.apetxt.TabIndex = 2
        '
        'celtxt
        '
        Me.celtxt.Location = New System.Drawing.Point(202, 71)
        Me.celtxt.Name = "celtxt"
        Me.celtxt.Size = New System.Drawing.Size(144, 20)
        Me.celtxt.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TELEFONO CELULAR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.edadtxt)
        Me.GroupBox1.Controls.Add(Me.dnitxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.celtxt)
        Me.GroupBox1.Controls.Add(Me.apetxt)
        Me.GroupBox1.Controls.Add(Me.pnomtxt)
        Me.GroupBox1.Location = New System.Drawing.Point(378, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 148)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'edadtxt
        '
        Me.edadtxt.Location = New System.Drawing.Point(202, 108)
        Me.edadtxt.Name = "edadtxt"
        Me.edadtxt.Size = New System.Drawing.Size(100, 20)
        Me.edadtxt.TabIndex = 6
        '
        'dnitxt
        '
        Me.dnitxt.Location = New System.Drawing.Point(59, 108)
        Me.dnitxt.Name = "dnitxt"
        Me.dnitxt.Size = New System.Drawing.Size(100, 20)
        Me.dnitxt.TabIndex = 5
        '
        'nomustxt
        '
        Me.nomustxt.Location = New System.Drawing.Point(58, 122)
        Me.nomustxt.Name = "nomustxt"
        Me.nomustxt.Size = New System.Drawing.Size(287, 20)
        Me.nomustxt.TabIndex = 6
        '
        'passustxt
        '
        Me.passustxt.Location = New System.Drawing.Point(58, 197)
        Me.passustxt.Name = "passustxt"
        Me.passustxt.Size = New System.Drawing.Size(287, 20)
        Me.passustxt.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(287, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "GENERAR NOMBRE DE USUARIO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(58, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(287, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "GENERAR CONTRASEÑA SEGURA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tccb)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.passustxt)
        Me.GroupBox2.Controls.Add(Me.nomustxt)
        Me.GroupBox2.Location = New System.Drawing.Point(379, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(396, 243)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tipo de Cargo: "
        '
        'tccb
        '
        Me.tccb.FormattingEnabled = True
        Me.tccb.Items.AddRange(New Object() {"Jefe de Area", "Trabajador"})
        Me.tccb.Location = New System.Drawing.Point(141, 31)
        Me.tccb.Name = "tccb"
        Me.tccb.Size = New System.Drawing.Size(204, 21)
        Me.tccb.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.Location = New System.Drawing.Point(411, 476)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(156, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "REGISTRAR USUARIO"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.Location = New System.Drawing.Point(142, 421)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "EXAMINAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Archivos
        '
        Me.Archivos.Filter = "JPG |*.jpg|PNG|*.png"
        '
        'imgpb
        '
        Me.imgpb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgpb.Image = Global.Mi_Almacen.My.Resources.Resources.usuario
        Me.imgpb.Location = New System.Drawing.Point(23, 55)
        Me.imgpb.Name = "imgpb"
        Me.imgpb.Size = New System.Drawing.Size(327, 335)
        Me.imgpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgpb.TabIndex = 0
        Me.imgpb.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(500, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "* Ingrese los datos del nuevo usuario. LLene todos los campos de forma correcta p" &
    "ara un registro exitoso"
        '
        'USUARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(818, 527)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.imgpb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(834, 566)
        Me.Name = "USUARIOS"
        Me.Text = " NUEVO USUARIO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.imgpb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgpb As PictureBox
    Friend WithEvents pnomtxt As TextBox
    Friend WithEvents apetxt As TextBox
    Friend WithEvents celtxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dnitxt As TextBox
    Friend WithEvents nomustxt As TextBox
    Friend WithEvents passustxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents edadtxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tccb As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Archivos As OpenFileDialog
    Friend WithEvents Label3 As Label
End Class
