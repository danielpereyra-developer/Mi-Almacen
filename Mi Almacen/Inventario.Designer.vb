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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ubicprtxt = New System.Windows.Forms.TextBox()
        Me.exprtxt = New System.Windows.Forms.TextBox()
        Me.cmprtxt = New System.Windows.Forms.TextBox()
        Me.puprtxt = New System.Windows.Forms.TextBox()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        CType(Me.imgprpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nomptxt
        '
        Me.nomptxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nomptxt.Location = New System.Drawing.Point(94, 90)
        Me.nomptxt.Name = "nomptxt"
        Me.nomptxt.Size = New System.Drawing.Size(162, 20)
        Me.nomptxt.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(289, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Location = New System.Drawing.Point(82, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.Location = New System.Drawing.Point(209, 132)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.Location = New System.Drawing.Point(314, 132)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(78, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'imgprpb
        '
        Me.imgprpb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgprpb.Location = New System.Drawing.Point(37, 215)
        Me.imgprpb.Name = "imgprpb"
        Me.imgprpb.Size = New System.Drawing.Size(219, 211)
        Me.imgprpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgprpb.TabIndex = 5
        Me.imgprpb.TabStop = False
        '
        'codprtxt
        '
        Me.codprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.codprtxt.Location = New System.Drawing.Point(279, 278)
        Me.codprtxt.Name = "codprtxt"
        Me.codprtxt.Size = New System.Drawing.Size(100, 20)
        Me.codprtxt.TabIndex = 6
        '
        'nomprtxt
        '
        Me.nomprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nomprtxt.Location = New System.Drawing.Point(444, 278)
        Me.nomprtxt.Name = "nomprtxt"
        Me.nomprtxt.Size = New System.Drawing.Size(100, 20)
        Me.nomprtxt.TabIndex = 8
        '
        'marcaprtxt
        '
        Me.marcaprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.marcaprtxt.Location = New System.Drawing.Point(279, 318)
        Me.marcaprtxt.Name = "marcaprtxt"
        Me.marcaprtxt.Size = New System.Drawing.Size(100, 20)
        Me.marcaprtxt.TabIndex = 9
        '
        'modeloprtxt
        '
        Me.modeloprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.modeloprtxt.Location = New System.Drawing.Point(444, 318)
        Me.modeloprtxt.Name = "modeloprtxt"
        Me.modeloprtxt.Size = New System.Drawing.Size(100, 20)
        Me.modeloprtxt.TabIndex = 10
        '
        'catprtxt
        '
        Me.catprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.catprtxt.Location = New System.Drawing.Point(279, 353)
        Me.catprtxt.Name = "catprtxt"
        Me.catprtxt.Size = New System.Drawing.Size(100, 20)
        Me.catprtxt.TabIndex = 11
        '
        'scatprtxt
        '
        Me.scatprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.scatprtxt.Location = New System.Drawing.Point(444, 353)
        Me.scatprtxt.Name = "scatprtxt"
        Me.scatprtxt.Size = New System.Drawing.Size(100, 20)
        Me.scatprtxt.TabIndex = 12
        '
        'productoslb
        '
        Me.productoslb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.productoslb.FormattingEnabled = True
        Me.productoslb.Location = New System.Drawing.Point(588, 132)
        Me.productoslb.Name = "productoslb"
        Me.productoslb.Size = New System.Drawing.Size(176, 264)
        Me.productoslb.TabIndex = 13
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.Location = New System.Drawing.Point(588, 66)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(51, 45)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Agregar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.Location = New System.Drawing.Point(645, 66)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(56, 45)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "Modificar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.Location = New System.Drawing.Point(707, 66)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 45)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "Borrar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ubicprtxt
        '
        Me.ubicprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ubicprtxt.Location = New System.Drawing.Point(279, 395)
        Me.ubicprtxt.Name = "ubicprtxt"
        Me.ubicprtxt.Size = New System.Drawing.Size(265, 20)
        Me.ubicprtxt.TabIndex = 17
        '
        'exprtxt
        '
        Me.exprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.exprtxt.Location = New System.Drawing.Point(383, 462)
        Me.exprtxt.Name = "exprtxt"
        Me.exprtxt.Size = New System.Drawing.Size(100, 20)
        Me.exprtxt.TabIndex = 19
        '
        'cmprtxt
        '
        Me.cmprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmprtxt.Location = New System.Drawing.Point(233, 462)
        Me.cmprtxt.Name = "cmprtxt"
        Me.cmprtxt.Size = New System.Drawing.Size(100, 20)
        Me.cmprtxt.TabIndex = 18
        '
        'puprtxt
        '
        Me.puprtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.puprtxt.Location = New System.Drawing.Point(529, 462)
        Me.puprtxt.Name = "puprtxt"
        Me.puprtxt.Size = New System.Drawing.Size(100, 20)
        Me.puprtxt.TabIndex = 20
        '
        'sfd
        '
        Me.sfd.Filter = "PDF|*.pdf"
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 527)
        Me.Controls.Add(Me.puprtxt)
        Me.Controls.Add(Me.exprtxt)
        Me.Controls.Add(Me.cmprtxt)
        Me.Controls.Add(Me.ubicprtxt)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.productoslb)
        Me.Controls.Add(Me.scatprtxt)
        Me.Controls.Add(Me.catprtxt)
        Me.Controls.Add(Me.modeloprtxt)
        Me.Controls.Add(Me.marcaprtxt)
        Me.Controls.Add(Me.nomprtxt)
        Me.Controls.Add(Me.codprtxt)
        Me.Controls.Add(Me.imgprpb)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nomptxt)
        Me.MinimumSize = New System.Drawing.Size(834, 566)
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        CType(Me.imgprpb, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents ubicprtxt As TextBox
    Friend WithEvents exprtxt As TextBox
    Friend WithEvents cmprtxt As TextBox
    Friend WithEvents puprtxt As TextBox
    Friend WithEvents sfd As SaveFileDialog
End Class
