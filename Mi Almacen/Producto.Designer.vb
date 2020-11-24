<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Producto))
        Me.codtxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.exabtn = New System.Windows.Forms.Button()
        Me.nomptxt = New System.Windows.Forms.TextBox()
        Me.modeloptxt = New System.Windows.Forms.TextBox()
        Me.marcaptxt = New System.Windows.Forms.TextBox()
        Me.catpcb = New System.Windows.Forms.ComboBox()
        Me.subcatpcb = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ubiccb = New System.Windows.Forms.ComboBox()
        Me.cantmtxt = New System.Windows.Forms.TextBox()
        Me.exptxt = New System.Windows.Forms.TextBox()
        Me.puptxt = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Archivos = New System.Windows.Forms.OpenFileDialog()
        Me.imagenpb = New System.Windows.Forms.PictureBox()
        Me.codbarpb = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.imagenpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.codbarpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'codtxt
        '
        Me.codtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.codtxt.Enabled = False
        Me.codtxt.Location = New System.Drawing.Point(387, 74)
        Me.codtxt.Name = "codtxt"
        Me.codtxt.Size = New System.Drawing.Size(145, 20)
        Me.codtxt.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(574, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "GENERAR CODIGO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'exabtn
        '
        Me.exabtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.exabtn.Location = New System.Drawing.Point(264, 84)
        Me.exabtn.Name = "exabtn"
        Me.exabtn.Size = New System.Drawing.Size(75, 23)
        Me.exabtn.TabIndex = 4
        Me.exabtn.Text = "EXAMINAR"
        Me.exabtn.UseVisualStyleBackColor = True
        '
        'nomptxt
        '
        Me.nomptxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nomptxt.Location = New System.Drawing.Point(387, 131)
        Me.nomptxt.Name = "nomptxt"
        Me.nomptxt.Size = New System.Drawing.Size(335, 20)
        Me.nomptxt.TabIndex = 5
        '
        'modeloptxt
        '
        Me.modeloptxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.modeloptxt.Location = New System.Drawing.Point(574, 183)
        Me.modeloptxt.Name = "modeloptxt"
        Me.modeloptxt.Size = New System.Drawing.Size(148, 20)
        Me.modeloptxt.TabIndex = 7
        '
        'marcaptxt
        '
        Me.marcaptxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.marcaptxt.Location = New System.Drawing.Point(387, 183)
        Me.marcaptxt.Name = "marcaptxt"
        Me.marcaptxt.Size = New System.Drawing.Size(148, 20)
        Me.marcaptxt.TabIndex = 6
        '
        'catpcb
        '
        Me.catpcb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.catpcb.FormattingEnabled = True
        Me.catpcb.Location = New System.Drawing.Point(387, 242)
        Me.catpcb.Name = "catpcb"
        Me.catpcb.Size = New System.Drawing.Size(121, 21)
        Me.catpcb.TabIndex = 12
        '
        'subcatpcb
        '
        Me.subcatpcb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.subcatpcb.FormattingEnabled = True
        Me.subcatpcb.Location = New System.Drawing.Point(574, 242)
        Me.subcatpcb.Name = "subcatpcb"
        Me.subcatpcb.Size = New System.Drawing.Size(121, 21)
        Me.subcatpcb.TabIndex = 13
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.Location = New System.Drawing.Point(514, 240)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(36, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.Location = New System.Drawing.Point(701, 242)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ubiccb
        '
        Me.ubiccb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ubiccb.FormattingEnabled = True
        Me.ubiccb.Location = New System.Drawing.Point(387, 304)
        Me.ubiccb.Name = "ubiccb"
        Me.ubiccb.Size = New System.Drawing.Size(344, 21)
        Me.ubiccb.TabIndex = 16
        '
        'cantmtxt
        '
        Me.cantmtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cantmtxt.Location = New System.Drawing.Point(387, 368)
        Me.cantmtxt.Name = "cantmtxt"
        Me.cantmtxt.Size = New System.Drawing.Size(148, 20)
        Me.cantmtxt.TabIndex = 17
        '
        'exptxt
        '
        Me.exptxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.exptxt.Location = New System.Drawing.Point(574, 368)
        Me.exptxt.Name = "exptxt"
        Me.exptxt.Size = New System.Drawing.Size(148, 20)
        Me.exptxt.TabIndex = 18
        '
        'puptxt
        '
        Me.puptxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.puptxt.Location = New System.Drawing.Point(387, 422)
        Me.puptxt.Name = "puptxt"
        Me.puptxt.Size = New System.Drawing.Size(148, 20)
        Me.puptxt.TabIndex = 19
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.Location = New System.Drawing.Point(626, 452)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(105, 41)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "GUARDAR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Archivos
        '
        Me.Archivos.Filter = "JPG |*.jpg|PNG|*.png"
        '
        'imagenpb
        '
        Me.imagenpb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imagenpb.Image = Global.Mi_Almacen.My.Resources.Resources.paquete
        Me.imagenpb.Location = New System.Drawing.Point(10, 10)
        Me.imagenpb.Name = "imagenpb"
        Me.imagenpb.Size = New System.Drawing.Size(257, 211)
        Me.imagenpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagenpb.TabIndex = 3
        Me.imagenpb.TabStop = False
        '
        'codbarpb
        '
        Me.codbarpb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.codbarpb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.codbarpb.Location = New System.Drawing.Point(99, 368)
        Me.codbarpb.Name = "codbarpb"
        Me.codbarpb.Size = New System.Drawing.Size(180, 60)
        Me.codbarpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.codbarpb.TabIndex = 1
        Me.codbarpb.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.imagenpb)
        Me.Panel1.Location = New System.Drawing.Point(62, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(277, 231)
        Me.Panel1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(384, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(384, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nombre del Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(384, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(571, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Modelo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(384, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Categoria"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(573, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "SubCategoria"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(384, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Ubicacion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(384, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Cantidad Minima"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(573, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Existencias"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(384, 406)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Precio Unitario"
        '
        'Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 527)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.puptxt)
        Me.Controls.Add(Me.exptxt)
        Me.Controls.Add(Me.cantmtxt)
        Me.Controls.Add(Me.ubiccb)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.subcatpcb)
        Me.Controls.Add(Me.catpcb)
        Me.Controls.Add(Me.modeloptxt)
        Me.Controls.Add(Me.marcaptxt)
        Me.Controls.Add(Me.nomptxt)
        Me.Controls.Add(Me.exabtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.codbarpb)
        Me.Controls.Add(Me.codtxt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(834, 566)
        Me.Name = "Producto"
        Me.Text = "Producto"
        CType(Me.imagenpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.codbarpb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents codtxt As TextBox
    Friend WithEvents codbarpb As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents imagenpb As PictureBox
    Friend WithEvents exabtn As Button
    Friend WithEvents nomptxt As TextBox
    Friend WithEvents modeloptxt As TextBox
    Friend WithEvents marcaptxt As TextBox
    Friend WithEvents catpcb As ComboBox
    Friend WithEvents subcatpcb As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ubiccb As ComboBox
    Friend WithEvents cantmtxt As TextBox
    Friend WithEvents exptxt As TextBox
    Friend WithEvents puptxt As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Archivos As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
