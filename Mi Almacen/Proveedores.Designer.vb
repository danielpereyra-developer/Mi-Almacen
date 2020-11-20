<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Me.rucptxt = New System.Windows.Forms.TextBox()
        Me.peptxt = New System.Windows.Forms.TextBox()
        Me.telptxt = New System.Windows.Forms.TextBox()
        Me.dirptxt = New System.Windows.Forms.TextBox()
        Me.telpeptxt = New System.Windows.Forms.TextBox()
        Me.imgpb = New System.Windows.Forms.PictureBox()
        Me.regbtn = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Archivos = New System.Windows.Forms.OpenFileDialog()
        CType(Me.imgpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nomptxt
        '
        Me.nomptxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nomptxt.Location = New System.Drawing.Point(430, 120)
        Me.nomptxt.Name = "nomptxt"
        Me.nomptxt.Size = New System.Drawing.Size(281, 20)
        Me.nomptxt.TabIndex = 1
        '
        'rucptxt
        '
        Me.rucptxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rucptxt.Location = New System.Drawing.Point(430, 169)
        Me.rucptxt.Name = "rucptxt"
        Me.rucptxt.Size = New System.Drawing.Size(281, 20)
        Me.rucptxt.TabIndex = 2
        '
        'peptxt
        '
        Me.peptxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.peptxt.Location = New System.Drawing.Point(430, 310)
        Me.peptxt.Name = "peptxt"
        Me.peptxt.Size = New System.Drawing.Size(281, 20)
        Me.peptxt.TabIndex = 5
        '
        'telptxt
        '
        Me.telptxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.telptxt.Location = New System.Drawing.Point(430, 261)
        Me.telptxt.Name = "telptxt"
        Me.telptxt.Size = New System.Drawing.Size(281, 20)
        Me.telptxt.TabIndex = 4
        '
        'dirptxt
        '
        Me.dirptxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dirptxt.Location = New System.Drawing.Point(430, 213)
        Me.dirptxt.Name = "dirptxt"
        Me.dirptxt.Size = New System.Drawing.Size(281, 20)
        Me.dirptxt.TabIndex = 3
        '
        'telpeptxt
        '
        Me.telpeptxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.telpeptxt.Location = New System.Drawing.Point(430, 358)
        Me.telpeptxt.Name = "telpeptxt"
        Me.telpeptxt.Size = New System.Drawing.Size(281, 20)
        Me.telpeptxt.TabIndex = 6
        '
        'imgpb
        '
        Me.imgpb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgpb.Location = New System.Drawing.Point(98, 120)
        Me.imgpb.Name = "imgpb"
        Me.imgpb.Size = New System.Drawing.Size(287, 297)
        Me.imgpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgpb.TabIndex = 7
        Me.imgpb.TabStop = False
        '
        'regbtn
        '
        Me.regbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regbtn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.regbtn.Location = New System.Drawing.Point(506, 435)
        Me.regbtn.Name = "regbtn"
        Me.regbtn.Size = New System.Drawing.Size(187, 31)
        Me.regbtn.TabIndex = 8
        Me.regbtn.Text = "REGISTRAR"
        Me.regbtn.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.Location = New System.Drawing.Point(98, 423)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "EXAMINAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Archivos
        '
        Me.Archivos.Filter = "JPG |*.jpg|PNG|*.png"
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(818, 527)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.regbtn)
        Me.Controls.Add(Me.imgpb)
        Me.Controls.Add(Me.telpeptxt)
        Me.Controls.Add(Me.peptxt)
        Me.Controls.Add(Me.telptxt)
        Me.Controls.Add(Me.dirptxt)
        Me.Controls.Add(Me.rucptxt)
        Me.Controls.Add(Me.nomptxt)
        Me.MinimumSize = New System.Drawing.Size(834, 566)
        Me.Name = "Proveedores"
        Me.Text = "NUEVO PROVEEDOR"
        CType(Me.imgpb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nomptxt As TextBox
    Friend WithEvents rucptxt As TextBox
    Friend WithEvents peptxt As TextBox
    Friend WithEvents telptxt As TextBox
    Friend WithEvents dirptxt As TextBox
    Friend WithEvents telpeptxt As TextBox
    Friend WithEvents imgpb As PictureBox
    Friend WithEvents regbtn As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Archivos As OpenFileDialog
End Class
