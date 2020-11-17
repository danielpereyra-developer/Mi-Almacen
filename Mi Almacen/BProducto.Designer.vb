<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BProducto
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
        Me.filtxt = New System.Windows.Forms.TextBox()
        Me.nomprotxt = New System.Windows.Forms.TextBox()
        Me.codprotxt = New System.Windows.Forms.TextBox()
        Me.marcaprotxt = New System.Windows.Forms.TextBox()
        Me.modeloprotxt = New System.Windows.Forms.TextBox()
        Me.exprotxt = New System.Windows.Forms.TextBox()
        Me.puprotxt = New System.Windows.Forms.TextBox()
        Me.canttxt = New System.Windows.Forms.TextBox()
        Me.totaltxt = New System.Windows.Forms.TextBox()
        Me.imgpropb = New System.Windows.Forms.PictureBox()
        Me.prodlb = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.imgpropb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'filtxt
        '
        Me.filtxt.Location = New System.Drawing.Point(131, 39)
        Me.filtxt.Name = "filtxt"
        Me.filtxt.Size = New System.Drawing.Size(504, 20)
        Me.filtxt.TabIndex = 0
        '
        'nomprotxt
        '
        Me.nomprotxt.Location = New System.Drawing.Point(131, 83)
        Me.nomprotxt.Name = "nomprotxt"
        Me.nomprotxt.Size = New System.Drawing.Size(227, 20)
        Me.nomprotxt.TabIndex = 1
        '
        'codprotxt
        '
        Me.codprotxt.Location = New System.Drawing.Point(131, 123)
        Me.codprotxt.Name = "codprotxt"
        Me.codprotxt.Size = New System.Drawing.Size(227, 20)
        Me.codprotxt.TabIndex = 2
        '
        'marcaprotxt
        '
        Me.marcaprotxt.Location = New System.Drawing.Point(131, 170)
        Me.marcaprotxt.Name = "marcaprotxt"
        Me.marcaprotxt.Size = New System.Drawing.Size(227, 20)
        Me.marcaprotxt.TabIndex = 3
        '
        'modeloprotxt
        '
        Me.modeloprotxt.Location = New System.Drawing.Point(131, 211)
        Me.modeloprotxt.Name = "modeloprotxt"
        Me.modeloprotxt.Size = New System.Drawing.Size(227, 20)
        Me.modeloprotxt.TabIndex = 4
        '
        'exprotxt
        '
        Me.exprotxt.Location = New System.Drawing.Point(131, 261)
        Me.exprotxt.Name = "exprotxt"
        Me.exprotxt.Size = New System.Drawing.Size(227, 20)
        Me.exprotxt.TabIndex = 5
        '
        'puprotxt
        '
        Me.puprotxt.Location = New System.Drawing.Point(131, 306)
        Me.puprotxt.Name = "puprotxt"
        Me.puprotxt.Size = New System.Drawing.Size(80, 20)
        Me.puprotxt.TabIndex = 6
        '
        'canttxt
        '
        Me.canttxt.Location = New System.Drawing.Point(286, 306)
        Me.canttxt.Name = "canttxt"
        Me.canttxt.Size = New System.Drawing.Size(72, 20)
        Me.canttxt.TabIndex = 7
        Me.canttxt.Text = "1"
        '
        'totaltxt
        '
        Me.totaltxt.Location = New System.Drawing.Point(131, 353)
        Me.totaltxt.Name = "totaltxt"
        Me.totaltxt.Size = New System.Drawing.Size(227, 20)
        Me.totaltxt.TabIndex = 8
        '
        'imgpropb
        '
        Me.imgpropb.Location = New System.Drawing.Point(418, 123)
        Me.imgpropb.Name = "imgpropb"
        Me.imgpropb.Size = New System.Drawing.Size(217, 219)
        Me.imgpropb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgpropb.TabIndex = 9
        Me.imgpropb.TabStop = False
        '
        'prodlb
        '
        Me.prodlb.FormattingEnabled = True
        Me.prodlb.Location = New System.Drawing.Point(670, 83)
        Me.prodlb.Name = "prodlb"
        Me.prodlb.Size = New System.Drawing.Size(210, 290)
        Me.prodlb.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(625, 418)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 33)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "AGREGAR A LA LISTA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 485)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.prodlb)
        Me.Controls.Add(Me.imgpropb)
        Me.Controls.Add(Me.totaltxt)
        Me.Controls.Add(Me.canttxt)
        Me.Controls.Add(Me.puprotxt)
        Me.Controls.Add(Me.exprotxt)
        Me.Controls.Add(Me.modeloprotxt)
        Me.Controls.Add(Me.marcaprotxt)
        Me.Controls.Add(Me.codprotxt)
        Me.Controls.Add(Me.nomprotxt)
        Me.Controls.Add(Me.filtxt)
        Me.Name = "BProducto"
        Me.Text = "BProducto"
        CType(Me.imgpropb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents filtxt As TextBox
    Friend WithEvents nomprotxt As TextBox
    Friend WithEvents codprotxt As TextBox
    Friend WithEvents marcaprotxt As TextBox
    Friend WithEvents modeloprotxt As TextBox
    Friend WithEvents exprotxt As TextBox
    Friend WithEvents puprotxt As TextBox
    Friend WithEvents canttxt As TextBox
    Friend WithEvents totaltxt As TextBox
    Friend WithEvents imgpropb As PictureBox
    Friend WithEvents prodlb As ListBox
    Friend WithEvents Button1 As Button
End Class
