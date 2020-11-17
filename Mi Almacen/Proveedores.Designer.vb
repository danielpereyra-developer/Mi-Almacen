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
        Me.nomptxt.Location = New System.Drawing.Point(370, 92)
        Me.nomptxt.Name = "nomptxt"
        Me.nomptxt.Size = New System.Drawing.Size(281, 20)
        Me.nomptxt.TabIndex = 1
        '
        'rucptxt
        '
        Me.rucptxt.Location = New System.Drawing.Point(370, 141)
        Me.rucptxt.Name = "rucptxt"
        Me.rucptxt.Size = New System.Drawing.Size(281, 20)
        Me.rucptxt.TabIndex = 2
        '
        'peptxt
        '
        Me.peptxt.Location = New System.Drawing.Point(370, 282)
        Me.peptxt.Name = "peptxt"
        Me.peptxt.Size = New System.Drawing.Size(281, 20)
        Me.peptxt.TabIndex = 5
        '
        'telptxt
        '
        Me.telptxt.Location = New System.Drawing.Point(370, 233)
        Me.telptxt.Name = "telptxt"
        Me.telptxt.Size = New System.Drawing.Size(281, 20)
        Me.telptxt.TabIndex = 4
        '
        'dirptxt
        '
        Me.dirptxt.Location = New System.Drawing.Point(370, 185)
        Me.dirptxt.Name = "dirptxt"
        Me.dirptxt.Size = New System.Drawing.Size(281, 20)
        Me.dirptxt.TabIndex = 3
        '
        'telpeptxt
        '
        Me.telpeptxt.Location = New System.Drawing.Point(370, 330)
        Me.telpeptxt.Name = "telpeptxt"
        Me.telpeptxt.Size = New System.Drawing.Size(281, 20)
        Me.telpeptxt.TabIndex = 6
        '
        'imgpb
        '
        Me.imgpb.Location = New System.Drawing.Point(38, 92)
        Me.imgpb.Name = "imgpb"
        Me.imgpb.Size = New System.Drawing.Size(287, 297)
        Me.imgpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgpb.TabIndex = 7
        Me.imgpb.TabStop = False
        '
        'regbtn
        '
        Me.regbtn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.regbtn.Location = New System.Drawing.Point(446, 407)
        Me.regbtn.Name = "regbtn"
        Me.regbtn.Size = New System.Drawing.Size(187, 31)
        Me.regbtn.TabIndex = 8
        Me.regbtn.Text = "REGISTRAR"
        Me.regbtn.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(38, 395)
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
        Me.ClientSize = New System.Drawing.Size(699, 471)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.regbtn)
        Me.Controls.Add(Me.imgpb)
        Me.Controls.Add(Me.telpeptxt)
        Me.Controls.Add(Me.peptxt)
        Me.Controls.Add(Me.telptxt)
        Me.Controls.Add(Me.dirptxt)
        Me.Controls.Add(Me.rucptxt)
        Me.Controls.Add(Me.nomptxt)
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
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
