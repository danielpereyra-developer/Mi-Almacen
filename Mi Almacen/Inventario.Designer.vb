<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Me.nomptxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.imgprpb = New System.Windows.Forms.PictureBox()
        Me.codprtxt = New System.Windows.Forms.TextBox()
        Me.nomprtxt = New System.Windows.Forms.TextBox()
        Me.marcaprtxt = New System.Windows.Forms.TextBox()
        Me.modeloprtxt = New System.Windows.Forms.TextBox()
        Me.catprtxt = New System.Windows.Forms.TextBox()
        Me.scatprtxt = New System.Windows.Forms.TextBox()
        Me.productoslb = New System.Windows.Forms.ListBox()
        Me.ubicprtxt = New System.Windows.Forms.TextBox()
        Me.exprtxt = New System.Windows.Forms.TextBox()
        Me.cmprtxt = New System.Windows.Forms.TextBox()
        Me.puprtxt = New System.Windows.Forms.TextBox()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.addbtn = New FontAwesome.Sharp.IconButton()
        Me.editbtn = New FontAwesome.Sharp.IconButton()
        Me.delbtn = New FontAwesome.Sharp.IconButton()
        CType(Me.imgprpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nomptxt
        '
        Me.nomptxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nomptxt.Location = New System.Drawing.Point(49, 90)
        Me.nomptxt.Name = "nomptxt"
        Me.nomptxt.Size = New System.Drawing.Size(284, 20)
        Me.nomptxt.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(339, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "BUSCAR PRODUCTO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Location = New System.Drawing.Point(49, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "EXPORTAR PDF"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.Location = New System.Drawing.Point(184, 132)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "PROXIMOS AGOTARSE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.Location = New System.Drawing.Point(339, 132)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "MOSTAR PRODUCTOS"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'imgprpb
        '
        Me.imgprpb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgprpb.Location = New System.Drawing.Point(0, 0)
        Me.imgprpb.Name = "imgprpb"
        Me.imgprpb.Padding = New System.Windows.Forms.Padding(10)
        Me.imgprpb.Size = New System.Drawing.Size(219, 220)
        Me.imgprpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgprpb.TabIndex = 5
        Me.imgprpb.TabStop = False
        '
        'codprtxt
        '
        Me.codprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.codprtxt.Location = New System.Drawing.Point(279, 229)
        Me.codprtxt.Name = "codprtxt"
        Me.codprtxt.Size = New System.Drawing.Size(100, 20)
        Me.codprtxt.TabIndex = 6
        '
        'nomprtxt
        '
        Me.nomprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nomprtxt.Location = New System.Drawing.Point(399, 229)
        Me.nomprtxt.Name = "nomprtxt"
        Me.nomprtxt.Size = New System.Drawing.Size(145, 20)
        Me.nomprtxt.TabIndex = 8
        '
        'marcaprtxt
        '
        Me.marcaprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.marcaprtxt.Location = New System.Drawing.Point(279, 287)
        Me.marcaprtxt.Name = "marcaprtxt"
        Me.marcaprtxt.Size = New System.Drawing.Size(115, 20)
        Me.marcaprtxt.TabIndex = 9
        '
        'modeloprtxt
        '
        Me.modeloprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.modeloprtxt.Location = New System.Drawing.Point(413, 287)
        Me.modeloprtxt.Name = "modeloprtxt"
        Me.modeloprtxt.Size = New System.Drawing.Size(131, 20)
        Me.modeloprtxt.TabIndex = 10
        '
        'catprtxt
        '
        Me.catprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.catprtxt.Location = New System.Drawing.Point(279, 345)
        Me.catprtxt.Name = "catprtxt"
        Me.catprtxt.Size = New System.Drawing.Size(115, 20)
        Me.catprtxt.TabIndex = 11
        '
        'scatprtxt
        '
        Me.scatprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.scatprtxt.Location = New System.Drawing.Point(413, 345)
        Me.scatprtxt.Name = "scatprtxt"
        Me.scatprtxt.Size = New System.Drawing.Size(131, 20)
        Me.scatprtxt.TabIndex = 12
        '
        'productoslb
        '
        Me.productoslb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.productoslb.FormattingEnabled = True
        Me.productoslb.Location = New System.Drawing.Point(588, 132)
        Me.productoslb.Name = "productoslb"
        Me.productoslb.Size = New System.Drawing.Size(176, 290)
        Me.productoslb.TabIndex = 13
        '
        'ubicprtxt
        '
        Me.ubicprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ubicprtxt.Location = New System.Drawing.Point(279, 404)
        Me.ubicprtxt.Name = "ubicprtxt"
        Me.ubicprtxt.Size = New System.Drawing.Size(265, 20)
        Me.ubicprtxt.TabIndex = 17
        '
        'exprtxt
        '
        Me.exprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.exprtxt.Location = New System.Drawing.Point(334, 460)
        Me.exprtxt.Name = "exprtxt"
        Me.exprtxt.Size = New System.Drawing.Size(100, 20)
        Me.exprtxt.TabIndex = 19
        '
        'cmprtxt
        '
        Me.cmprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmprtxt.Location = New System.Drawing.Point(156, 460)
        Me.cmprtxt.Name = "cmprtxt"
        Me.cmprtxt.Size = New System.Drawing.Size(100, 20)
        Me.cmprtxt.TabIndex = 18
        '
        'puprtxt
        '
        Me.puprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.puprtxt.Location = New System.Drawing.Point(507, 460)
        Me.puprtxt.Name = "puprtxt"
        Me.puprtxt.Size = New System.Drawing.Size(100, 20)
        Me.puprtxt.TabIndex = 20
        '
        'sfd
        '
        Me.sfd.Filter = "PDF|*.pdf"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(276, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(396, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Producto"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(276, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(410, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Modelo"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Categoria"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(412, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "SubCategoria"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(276, 383)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Ubicacion"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(82, 463)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Cant. Minima"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(268, 463)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Existencias"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(445, 463)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "P. Unitario"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.imgprpb)
        Me.Panel1.Location = New System.Drawing.Point(37, 204)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 220)
        Me.Panel1.TabIndex = 31
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.Color.YellowGreen
        Me.addbtn.FlatAppearance.BorderSize = 0
        Me.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addbtn.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.addbtn.IconColor = System.Drawing.Color.Blue
        Me.addbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.addbtn.IconSize = 40
        Me.addbtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.addbtn.Location = New System.Drawing.Point(588, 76)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(50, 50)
        Me.addbtn.TabIndex = 32
        Me.addbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.addbtn.UseVisualStyleBackColor = False
        '
        'editbtn
        '
        Me.editbtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.editbtn.FlatAppearance.BorderSize = 0
        Me.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.editbtn.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.editbtn.IconColor = System.Drawing.Color.ForestGreen
        Me.editbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.editbtn.IconSize = 40
        Me.editbtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.editbtn.Location = New System.Drawing.Point(646, 76)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(50, 50)
        Me.editbtn.TabIndex = 33
        Me.editbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.editbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.editbtn.UseVisualStyleBackColor = False
        '
        'delbtn
        '
        Me.delbtn.BackColor = System.Drawing.Color.Firebrick
        Me.delbtn.FlatAppearance.BorderSize = 0
        Me.delbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.delbtn.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.delbtn.IconColor = System.Drawing.Color.Black
        Me.delbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.delbtn.IconSize = 40
        Me.delbtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.delbtn.Location = New System.Drawing.Point(702, 76)
        Me.delbtn.Name = "delbtn"
        Me.delbtn.Size = New System.Drawing.Size(50, 50)
        Me.delbtn.TabIndex = 34
        Me.delbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.delbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.delbtn.UseVisualStyleBackColor = False
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 527)
        Me.Controls.Add(Me.delbtn)
        Me.Controls.Add(Me.editbtn)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.Panel1)
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
        Me.Controls.Add(Me.puprtxt)
        Me.Controls.Add(Me.exprtxt)
        Me.Controls.Add(Me.cmprtxt)
        Me.Controls.Add(Me.ubicprtxt)
        Me.Controls.Add(Me.productoslb)
        Me.Controls.Add(Me.scatprtxt)
        Me.Controls.Add(Me.catprtxt)
        Me.Controls.Add(Me.modeloprtxt)
        Me.Controls.Add(Me.marcaprtxt)
        Me.Controls.Add(Me.nomprtxt)
        Me.Controls.Add(Me.codprtxt)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nomptxt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(834, 566)
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        CType(Me.imgprpb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nomptxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents imgprpb As PictureBox
    Friend WithEvents codprtxt As TextBox
    Friend WithEvents nomprtxt As TextBox
    Friend WithEvents marcaprtxt As TextBox
    Friend WithEvents modeloprtxt As TextBox
    Friend WithEvents catprtxt As TextBox
    Friend WithEvents scatprtxt As TextBox
    Friend WithEvents productoslb As ListBox
    Friend WithEvents ubicprtxt As TextBox
    Friend WithEvents exprtxt As TextBox
    Friend WithEvents cmprtxt As TextBox
    Friend WithEvents puprtxt As TextBox
    Friend WithEvents sfd As SaveFileDialog
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents addbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents editbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents delbtn As FontAwesome.Sharp.IconButton
End Class
